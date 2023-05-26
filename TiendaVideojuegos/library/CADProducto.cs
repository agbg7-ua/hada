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
    class CADProducto
    {
        private string constring;

        /// <summary>
        /// Conexión
        /// </summary>
        public CADProducto() 
        { 
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        /// <summary>
        /// Método para crear un Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool createProducto(ENProducto en)
        {
            bool create = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Producto",c);
                da.Fill(bdvirtual,"Producto");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Producto"];
                DataRow nuevafila = t.NewRow();
                nuevafila[1] = en.id_categoria;
                nuevafila[2] = en.id_desarrollador;
                nuevafila[3] = en.nombre;
                nuevafila[4] = en.pvp;
                nuevafila[5] = en.descripcion;
                nuevafila[6] = en.fecha_salida;
                nuevafila[7] = en.clasificacion;
                nuevafila[8] = en.imagen;
                nuevafila[9] = en.mostrar;
                nuevafila[10] = en.borrado;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "Producto");
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
        /// Método para leer un Producto (por id) -> modo conectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readProducto(ENProducto en) 
        {
            bool read = false;
            SqlConnection c = null;
            String comando = "Select * From Producto where id=" + en.id + " and borrado=0";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    read = true;
                    en.id_categoria = Convert.ToInt32(dr["id_categoria"].ToString());
                    en.id_desarrollador = Convert.ToInt32(dr["id_desarrollador"].ToString());
                    en.nombre = dr["nombre"].ToString();
                    en.pvp = (float)Convert.ToDouble(dr["pvp"].ToString());
                    en.descripcion = dr["descripcion"].ToString();
                    en.fecha_salida = Convert.ToDateTime(dr["fecha_salida"].ToString());
                    en.clasificacion = Convert.ToInt32(dr["clasificacion"].ToString());
                    en.imagen = dr["imagen"].ToString();
                    en.mostrar = Convert.ToBoolean(dr["mostrar"].ToString());
                }

                dr.Close();
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

        /// <summary>
        /// Método para leer un producto (por id) a pesar de haber sido eliminado -> modo conectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readProductoEliminado(ENProducto en)
        {
            bool read = false;
            SqlConnection c = null;
            String comando = "Select * From Producto where id=" + en.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    read = true;
                    en.id_categoria = Convert.ToInt32(dr["id_categoria"].ToString());
                    en.id_desarrollador = Convert.ToInt32(dr["id_desarrollador"].ToString());
                    en.nombre = dr["nombre"].ToString();
                    en.pvp = (float)Convert.ToDouble(dr["pvp"].ToString());
                    en.descripcion = dr["descripcion"].ToString();
                    en.fecha_salida = Convert.ToDateTime(dr["fecha_salida"].ToString());
                    en.clasificacion = Convert.ToInt32(dr["clasificacion"].ToString());
                    en.imagen = dr["imagen"].ToString();
                    en.mostrar = Convert.ToBoolean(dr["mostrar"].ToString());
                }

                dr.Close();
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

        /// <summary>
        /// Método para leer un Producto (por nombre) -> modo conectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readByNameProducto(ENProducto en)
        {
            bool read = false;
            SqlConnection c = null;
            String comando = "Select * From Producto where nombre='" + en.nombre + "' and borrado=0";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    read = true;
                    en.clasificacion = Convert.ToInt32(dr["clasificacion"].ToString());
                }

                dr.Close();
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

        /// <summary>
        /// Método para enseñar Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public DataSet showProducto(ENProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
          
            try
            { 
                String comando = "Select * From Producto where id=" + en.id + " and borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");

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
        /// Método para actualizar un Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool updateProducto(ENProducto en)
        {
            bool update = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Producto"];
                int i = 0;
                while (i < t.Rows.Count)
                {
                    if (t.Rows[i]["nombre"].ToString() == en.nombre.ToString())
                    {
                        if (t.Rows[i]["id"].ToString() != en.id.ToString())
                        {
                            update = false;
                            break;
                        }
                    }
                    if (t.Rows[i]["id"].ToString() == en.id.ToString())
                    {
                        t.Rows[i]["id_categoria"] = en.id_categoria;
                        t.Rows[i]["id_desarrollador"] = en.id_desarrollador;
                        t.Rows[i]["nombre"] = en.nombre;
                        t.Rows[i]["pvp"] = en.pvp;
                        t.Rows[i]["descripcion"] = en.descripcion;
                        t.Rows[i]["clasificacion"] = en.clasificacion;
                        t.Rows[i]["mostrar"] = en.mostrar;
                        update = true;
                    }
                    i++;
                }

                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "Producto");
                return update;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return update;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return update;
            }
            finally
            {
                if (c != null) c.Close();
            }
        }

        /// <summary>
        /// Método para borrar un Producto -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool deleteProducto(ENProducto en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Update Producto set borrado=1 where id= " + en.id + " and borrado=0";

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
                return delete;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return delete;
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }

        /// <summary>
        /// Método para enseñar todos los Productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showAllProducto()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try 
            {
                String comando = "Select * From Producto where mostrar=1 and borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando,c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar todos los Productos para el administrador -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showAllProductoAdmin()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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

        // ---------------------------------------------------------------------- 
        /*
         * Ordenar Productos de una Categoría
        */
        // ----------------------------------------------------------------------

        /// <summary>
        /// Método para enseñar por nombre en orden ascendiente Productos -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public DataSet showOrderByNameASCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try 
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + "and mostrar=1 and borrado=0 order by nombre asc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por nombre en orden descendiente Productos -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public DataSet showOrderByNameDESCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 and borrado=0 order by nombre desc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por precio en orden ascendiente Productos -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public DataSet showOrderByPriceASCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 and borrado=0 order by pvp asc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por precio en orden descendiente Productos -> modo desconectado
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public DataSet showOrderByPriceDESCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 and borrado=0 order by pvp desc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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

        // ---------------------------------------------------------------------- 
        /*
         * Ordenar Productos
        */
        // ----------------------------------------------------------------------

        /// <summary>
        /// Método para enseñar por nombre en orden ascendiente Productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showOrderByNameASCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 and borrado=0 order by nombre asc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por nombre en orden descendiente Productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showOrderByNameDESCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 and borrado=0 order by nombre desc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por precio en orden ascendiente Productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showOrderByPriceASCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 and borrado=0 order by pvp asc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para enseñar por precio en orden descendiente Productos -> modo desconectado
        /// </summary>
        /// <returns></returns>
        public DataSet showOrderByPriceDESCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 and borrado=0 order by pvp desc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
        /// Método para buscar Productos por nombre -> modo desconectado
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataSet searchByNameProducto(String name)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where nombre like '%" + name + "%' and mostrar=1 and borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Producto");
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
