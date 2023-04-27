using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace library
{
	class CADLineaCarrito
	{
		private string constring;

        public CADLineaCarrito()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool createLineaCarrito(ENLineaCarrito en)
        {
            bool created = false;
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO LineaCarrito (id_carrito, id_producto, cantidad, importe, fecha) VALUES (@id_carrito, @id_producto, @cantidad, @importe, @fecha)", c);
                cmd.Parameters.AddWithValue("@id_carrito", en.id_carrito);
                cmd.Parameters.AddWithValue("@id_producto", en.id_producto);
                cmd.Parameters.AddWithValue("@cantidad", en.cantidad);
                cmd.Parameters.AddWithValue("@importe", en.importe);
                cmd.Parameters.AddWithValue("@fecha", en.fecha);

                c.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    created = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return created;
        }
        public bool updateLineaCarrito(ENLineaCarrito en)
        {
            bool updated = false;
            SqlConnection c = new SqlConnection(constring);

            try
            {
                c.Open();

                SqlCommand cmd = new SqlCommand("UPDATE LineaCarrito SET id_producto = @id_producto, cantidad = @cantidad, importe = @importe, fecha = @fecha WHERE id_carrito = @id_carrito AND id_linea = @id_linea", c);
                cmd.Parameters.AddWithValue("@id_producto", en.id_producto);
                cmd.Parameters.AddWithValue("@cantidad", en.cantidad);
                cmd.Parameters.AddWithValue("@importe", en.importe);
                cmd.Parameters.AddWithValue("@fecha", en.fecha);
                cmd.Parameters.AddWithValue("@id_carrito", en.id_carrito);
                cmd.Parameters.AddWithValue("@id_linea", en.id_linea);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    updated = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                updated = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                updated = false;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return updated;
        }
        public bool deleteLineaCarrito(int id_carrito, int id_linea)
        {
            bool deleted = false;
            SqlConnection c = new SqlConnection(constring);

            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LineaCarrito WHERE id_carrito = @id_carrito AND id_linea = @id_linea", c);
                cmd.Parameters.AddWithValue("@id_carrito", id_carrito);
                cmd.Parameters.AddWithValue("@id_linea", id_linea);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    deleted = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                deleted = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                deleted = false;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return deleted;
        }
        public ENLineaCarrito selectLineaCarrito(int id)
        {
            ENLineaCarrito en = new ENLineaCarrito();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                string query = "SELECT * FROM LineaCarrito WHERE id_linea = @id";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.Parameters.AddWithValue("@id", id);
                c.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    en.id_carrito = int.Parse(dr["id_carrito"].ToString());
                    en.id_linea = int.Parse(dr["id_linea"].ToString());
                    en.id_producto = int.Parse(dr["id_producto"].ToString());
                    en.cantidad = int.Parse(dr["cantidad"].ToString());
                    en.importe = float.Parse(dr["importe"].ToString());
                    en.fecha = DateTime.Parse(dr["fecha"].ToString());
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return en;
        }

        public List<ENLineaCarrito> ListaLineaCarritos()
        {
            List<ENLineaCarrito> listaLineasCarrito = new List<ENLineaCarrito>();
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM LineaCarrito", c);
                ad.Fill(bdvirtual, "LineaCarrito");
                DataTable t = bdvirtual.Tables["LineaCarrito"];
                foreach (DataRow fila in t.Rows)
                {
                    ENLineaCarrito lineaCarrito = new ENLineaCarrito();
                    lineaCarrito.id_carrito = int.Parse(fila["id_carrito"].ToString());
                    lineaCarrito.id_linea = int.Parse(fila["id_linea"].ToString());
                    lineaCarrito.id_producto = int.Parse(fila["id_producto"].ToString());
                    lineaCarrito.cantidad = int.Parse(fila["cantidad"].ToString());
                    lineaCarrito.importe = float.Parse(fila["importe"].ToString());
                    lineaCarrito.fecha = DateTime.Parse(fila["fecha"].ToString());
                    listaLineasCarrito.Add(lineaCarrito);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                c.Close();
            }

            return listaLineasCarrito;
        }

        /*
        public List<ENLineaCarrito> ListaLineaCarritos(string id_usuario)
        {
            List<ENLineaCarrito> listaLineasCarrito = new List<ENLineaCarrito>();
            SqlConnection con = new SqlConnection(constring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LineaCarrito INNER JOIN Carrito ON LineaCarrito.id_carrito = Carrito.id WHERE Carrito.id_usuario = @id_usuario", con);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ENLineaCarrito lineaCarrito = new ENLineaCarrito();
                    lineaCarrito.id_carrito = int.Parse(dr["id_carrito"].ToString());
                    lineaCarrito.id_linea = int.Parse(dr["id_linea"].ToString());
                    lineaCarrito.id_producto = int.Parse(dr["id_producto"].ToString());
                    lineaCarrito.cantidad = int.Parse(dr["cantidad"].ToString());
                    lineaCarrito.importe = float.Parse(dr["importe"].ToString());
                    lineaCarrito.fecha = DateTime.Parse(dr["fecha"].ToString());
                    listaLineasCarrito.Add(lineaCarrito);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                con.Close();
            }
            return listaLineasCarrito;
        }

        */

    }
}
