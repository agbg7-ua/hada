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
    class CADCategoriaProducto
    {
        private string constring;

        /// <summary>
        /// Conexión
        /// </summary>
        public CADCategoriaProducto() 
        { 
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        /// <summary>
        /// Método para crear una Categoría de Producto -> modo conectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createCategoriaProducto(ENCategoriaProducto en) 
        {
            bool create = false;
            SqlConnection c = null;
            String comando = "Insert Into CategoriaProducto (nombre, descripcion, imagen) VALUES ('" + en.nombre + "','" + en.descripcion + "','" + en.imagen + "')";

            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                create = true;
            }
            catch (SqlException ex)
            {
                create = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                create = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return create;
        }

        /// <summary>
        /// Método para leer una Categoría de Producto -> modo conectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readCategoriaProducto(ENCategoriaProducto en)
        {
            bool read_CP = false;
            SqlConnection c = null;
            String comando = "Select * From CategoriaProducto";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    if (int.Parse(dr["id"].ToString()) == en.id)
                    {
                        read_CP = true;
                        en.nombre = dr["nombre"].ToString();
                        en.descripcion = dr["descripcion"].ToString();
                        en.imagen = dr["imagen"].ToString();
                    }
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                read_CP = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                read_CP = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return read_CP;
        }

        /// <summary>
        /// Método para actualizar una Categoría de Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateCategoriaProducto(ENCategoriaProducto en)
        {
            bool update = false;
            SqlConnection c = null;
            String comando = "Update CategoriaProducto set nombre='" + en.nombre + "', descripcion='" + en.descripcion + "', imagen='" + en.imagen + "' where id=" + en.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                update = true;
            }
            catch (SqlException ex)
            {
                update = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                update = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return update;
        }

        /// <summary>
        /// Método para borrar una Categoría de Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool deleteCategoriaProducto(ENCategoriaProducto en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Update CategoriaProducto set borrado=1 where id =" + en.id;
            String comando2 = "Update Producto set borrado=1 where id_categoria=" + en.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlCommand com2 = new SqlCommand(comando2, c);

                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                delete = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                delete = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }

        /// <summary>
        /// Método para enseñar todos las categorías de productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showAllCategoriaProducto()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From CategoriaProducto where borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "CategoriaProducto");
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

        /// <summary>
        /// Método para conseguir una Categoría de Producto -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet getCategoriaProducto()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select nombre, id From CategoriaProducto";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "CategoriaProducto");
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
