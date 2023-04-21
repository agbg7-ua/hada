using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CREATE TABLE[dbo].[Desarrollador] (
//    [id]            INT IDENTITY(1, 1) NOT NULL,
//    [nombre] 		VARCHAR (30)  NOT NULL,
//    [descripcion] 	TEXT          NOT NULL,
//    [origen]      	VARCHAR (25)  NOT NULL,
//    [fecha_creacion]    DATE          NOT NULL,
//    [web]      		VARCHAR (50)  NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC)
//);


namespace library
{
    internal class CADDesarrollador
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
                String sql_q = String.Format(
                    "insert into Desarrollador (nombre, descripcion, origen, fecha_creacion, web) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    en.nombre,
                    en.descripcion,
                    en.origen,
                    en.fecha_creacion,
                    en.web);

                c.Open();
                SqlCommand com = new SqlCommand(sql_q);
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

            return insertado;
        }



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
                    "update Desarrollador set nombre = '{0}', descripcion = '{1}', origen = '{2}', fecha_creacion = '{3}', web = '{4}' where id = {5}",
                    en.nombre,
                    en.descripcion,
                    en.origen,
                    en.fecha_creacion,
                    en.web,
                    en.id);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q);
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


        public bool eliminar(ENDesarrollador en)
        {
            bool eliminado = false;
            SqlConnection c = new SqlConnection(constring);
            try
            {
                if (en.id == 0)
                {
                    throw new Exception("No se puede eliminar un desarrollador sin id");
                }
                String sql_q = String.Format(
                    "delete from Desarrollador where id = {0}",
                    en.id);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q);
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
            return eliminado;
        }

        /// <summary>
        /// OBteener el desarrollador con el id indicado en el ENDesarrollador
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
                         "select * from Desarrollador where id = {0}",
                         id);
                c.Open();
                SqlCommand com = new SqlCommand(sql_q);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.nombre = dr["nombre"].ToString();
                    en.descripcion = dr["descripcion"].ToString();
                    en.origen = dr["origen"].ToString();
                    en.fecha_creacion = DateTime.Parse(dr["fecha_creacion"].ToString());
                    en.web = dr["web"].ToString();
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



    }
}
