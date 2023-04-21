using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

// CREATE TABLE [dbo].[CategoriaProducto] (
// [id]             INT           IDENTITY(1, 1) NOT NULL,
// [nombre] 		VARCHAR (45)  NOT NULL,
// [descripcion] 	TEXT          NOT NULL,
// [imagen]      	VARCHAR (MAX) NULL,
// PRIMARY KEY CLUSTERED ([id] ASC),
// UNIQUE NONCLUSTERED([nombre] ASC)
// );

namespace library
{
    class CADCategoriaProducto
    {
        private string constring;

        public CADCategoriaProducto() 
        { 
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        // Método para crear una Categoría de Producto -> modo conectado
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

        // Método para leer una Categoría de Producto -> modo conectado
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

        // Método para actualizar una Categoría de Producto -> modo conectado
        public bool updateCategoriaProducto(ENCategoriaProducto en)
        {
            bool update = false;
            SqlConnection c = null;
            String comando = "Update CategoriaProducto set nombre='" + en.nombre + "', descripcion='" + en.descripcion + "', imagen='" + en.imagen + "' where id='" + en.id + "'";

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

        // Método para borrar una Categoría de Producto -> modo conectado
        public bool deleteCategoriaProducto(ENCategoriaProducto en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Delete From CategoriaProducto where id = '" + en.id + "'";

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
    }
}
