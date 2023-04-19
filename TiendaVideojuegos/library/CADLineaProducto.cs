using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemConfiguratio;
using System.Data.SqlClient;

namespace library
{
	class CADLineaProducto
	{
		private string constring;
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



    }
}
