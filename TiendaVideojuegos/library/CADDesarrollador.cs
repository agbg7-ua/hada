using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data;


//CREATE TABLE[dbo].[Desarrollador] (
//    [id]             INT IDENTITY(1, 1) NOT NULL,
//    [nombre]         VARCHAR (30)  NOT NULL,
//    [descripcion]    TEXT          NOT NULL,
//    [origen]         VARCHAR (25)  NOT NULL,
//    [fecha_creacion] DATE          NOT NULL,
//    [web]            VARCHAR (50)  NULL,
//    [imagen]         VARCHAR (MAX) NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC),
//    UNIQUE NONCLUSTERED([nombre] ASC)
//);


/// TODO la mierda de modo conectado y descnoectado


namespace library
{
    public class CADDesarrollador
    {
        private string constring;

        public CADDesarrollador()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        /// <summary>
        /// Inserta un desarrollador en la base de datos, con un ENDesarrolador como argumento
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool insertar(ENDesarrollador en)
        {
            bool insertado = false;

            SqlConnection c = new SqlConnection(constring);

            try
            {
                string sql_q = String.Format(
                                       "insert into Desarrollador (nombre, descripcion, origen, fecha_creacion, web, imagen) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                                        en.nombre,
                                        en.descripcion,
                                        en.origen,
                                        en.fecha_creacion.ToString(),
                                        en.web,
                                        en.imagen);


                c.Open();
                SqlCommand com = new SqlCommand(sql_q,c);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // TODO Controlar expceciones comunes y excribirlas bien
                throw new Exception("Error al insertar el desarrollador: " + ex.Message);
            }
            finally
            {
                c.Close();
            }

            return insertado;
        }



        /// <summary>
        /// Actualiza el registro del Desarrollador con los nuevos datos del objeto ENDesarrollador
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool modificar(ENDesarrollador en)
        {
            bool modificado = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                if (en.id == 0)
                {
                    throw new Exception("No se puede modificar un desarrollador sin id");
                }

                String sql_q = String.Format(
                                       "update Desarrollador set nombre = '{0}', descripcion = '{1}', origen = '{2}', fecha_creacion = '{3}', web = '{4}', imagen = '{5}' where id = {6}",
                                        en.nombre,
                                        en.descripcion,
                                        en.origen,
                                        en.fecha_creacion,
                                        en.web,
                                        en.imagen,
                                        en.id);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q, c);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                c.Close();
            }
            return modificado;
        }

        /// <summary>
        /// Elimina el Desarrlollador por ID o por nombre en caso de que no tenga ID
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool eliminar(ENDesarrollador en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Update Desarrollador set borrado=1 where id =" + en.id;
            String comando2 = "Update Producto set borrado=1 where id_desarrollador=" + en.id;

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
        /// OBteener el desarrollador con el id o nombre indicado en el ENDesarrollador
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public ENDesarrollador obtener_by_id(int id)
        {
            ENDesarrollador en = new ENDesarrollador();
            bool obtenido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                if (id == 0)
                {
                    throw new Exception("No se puede obtener un desarrollador sin id");
                }
                String sql_q = String.Format(
                         "select * from Desarrollador where id = {0} and borrado=0",
                         id);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q,c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.nombre = dr["nombre"].ToString();
                    en.descripcion = dr["descripcion"].ToString();
                    en.origen = dr["origen"].ToString();
                    en.fecha_creacion = DateTime.Parse(dr["fecha_creacion"].ToString());
                    en.web = dr["web"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    obtenido = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                c.Close();
            }
            return en;
        }


        public ENDesarrollador obtener_by_nombre(String nombre)
        {
            ENDesarrollador en = new ENDesarrollador();
            bool obtenido = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                if (nombre == null)
                {
                    throw new Exception("No se puede obtener un desarrollador sin nombre");
                }
                String sql_q = String.Format(
                         "select * from Desarrollador where nombre = '{0}' and borrado=0",
                         nombre);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.nombre = dr["nombre"].ToString();
                    en.descripcion = dr["descripcion"].ToString();
                    en.origen = dr["origen"].ToString();
                    en.fecha_creacion = DateTime.Parse(dr["fecha_creacion"].ToString());
                    en.web = dr["web"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    obtenido = true;
                }
                if (!obtenido)
                {
                    throw new Exception("No se ha encontrado el desarrollador con Nombre= "+nombre);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw new Exception("Error en obtener_by_nombre al consultar la BBDD: " + ex.Message);
            }
            finally
            {
                c.Close();
            }
            return en;
        }



        /// <summary>
        /// Obtiene una lista de todos los desarrolladores con fecha entre 'inicio' y 'final'
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public List<ENDesarrollador> filtrar_rango(DateTime inicio, DateTime final)
        {
            List<ENDesarrollador> lista_final = new List<ENDesarrollador>();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                String sql_q = String.Format(
                        "select * from Desarrollador where fecha_creacion between '{0}' and '{1}' and borrado=0",
                        inicio,
                        final);
                SqlCommand com = new SqlCommand(sql_q, c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ENDesarrollador en = new ENDesarrollador();
                    en.nombre = dr["nombre"].ToString();
                    en.descripcion = dr["descripcion"].ToString();
                    en.origen = dr["origen"].ToString();
                    en.fecha_creacion = DateTime.Parse(dr["fecha_creacion"].ToString());
                    en.web = dr["web"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    lista_final.Add(en);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                c.Close();
            }
            return lista_final;
        }



        public List<ENDesarrollador> obtener_todos()
        {
            List<ENDesarrollador> lista_final = new List<ENDesarrollador>();
            
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                String sql_q = String.Format(
                                           "select * from Desarrollador where borrado=0;");
                SqlCommand com = new SqlCommand(sql_q,c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ENDesarrollador en = new ENDesarrollador();
                    en.nombre = dr["nombre"].ToString();
                    en.descripcion = dr["descripcion"].ToString();
                    en.origen = dr["origen"].ToString();
                    en.fecha_creacion = DateTime.Parse(dr["fecha_creacion"].ToString());
                    en.web = dr["web"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    en.id = int.Parse(dr["id"].ToString());
                    lista_final.Add(en);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Excepcion al leer todos los registros : " + ex.Message);
            }
            finally
            {
                c.Close();
            }
            return lista_final;
        }

        public DataSet getDesarrollador()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select nombre, id From Desarrollador where borrado=0";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Desarrollador");
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
