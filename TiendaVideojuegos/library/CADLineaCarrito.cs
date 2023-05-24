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
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From LineaCarrito", c);
                da.Fill(bdvirtual, "LineaCarrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["LineaCarrito"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = en.id_carrito;
                nuevafila[2] = en.id_producto;
                nuevafila[3] = en.cantidad;
                nuevafila[4] = en.importe;
                nuevafila[5] = en.fecha;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "LineaCarrito");
                created = true;
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

        public bool readLineaCarrito(ENLineaCarrito en)
        {
            bool read = false;
            SqlConnection c = null;

            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand readSql = new SqlCommand("Select * from LineaCarrito", c);
                SqlDataReader dr = readSql.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_linea"].ToString() == en.id_linea.ToString() && dr["id_carrito"].ToString() == en.id_carrito.ToString())
                    {
                        read = true;
                        en.id_producto = int.Parse(dr["id_producto"].ToString());
                        en.cantidad = int.Parse(dr["cantidad"].ToString());
                        en.importe = float.Parse(dr["importe"].ToString());
                        en.fecha = DateTime.Parse(dr["fecha"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                read = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                read = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return read;
        }
        public DataSet updateLineaCarrito(ENLineaCarrito en, int i)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From LineaCarrito";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "LineaCarrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["LineaCarrito"];
                t.Rows[i]["id_producto"] = en.id_producto;
                t.Rows[i]["cantidad"] = en.cantidad;
                t.Rows[i]["importe"] = en.importe;
                t.Rows[i]["fecha"] = en.fecha;
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "LineaCarrito");
                return bdvirtual;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return bdvirtual;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return bdvirtual;
            }
            finally
            {
                if (c != null) c.Close();
            }
        }
        public bool deleteLineaCarrito(ENLineaCarrito en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Delete From LineaCarrito where id_linea=" + en.id_linea + " and id_carrito=" + en.id_carrito;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }

        public bool vaciarCarrito(ENCarrito en)
        {
            bool delete = false;
            SqlConnection c = null;
            string comando;

            comando = "Delete From LineaCarrito where id_carrito=" + en.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }

        public DataSet showLineasCarritoByCarrito(ENCarrito en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * from LineaCarrito where id_carrito=" + en.id;
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "LineaCarrito");
                return bdvirtual;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return bdvirtual;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return bdvirtual;
            }
            finally
            {
                if (c != null) c.Close();
            }
        }

        public bool deleteByProducto(ENProducto en)
        {
            bool delete = false;
            SqlConnection c = null;
            string comando;

            comando = "Delete From LineaCarrito where id_producto=" + en.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                delete = false; ;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }
    }
}