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
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LineaCarrito", c);
                da.Fill(bdvirtual, "LineaCarrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["LineaCarrito"];

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataRow fila = t.Rows[i];

                    if (en.id_carrito == int.Parse(fila[0].ToString()) && en.id_linea == int.Parse(fila[1].ToString()))
                    {
                        read = true;
                        en.id_producto = int.Parse(fila[2].ToString());
                        en.cantidad = int.Parse(fila[3].ToString());
                        en.importe = float.Parse(fila[4].ToString());
                        en.fecha = DateTime.Parse(fila[5].ToString());
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
        public DataSet deleteLineaCarrito(ENLineaCarrito en, int i)
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
                t.Rows[i].Delete();
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

        public DataSet vaciarCarrito(ENCarrito en)
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

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    t.Rows[i].Delete();
                }

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
    }
}