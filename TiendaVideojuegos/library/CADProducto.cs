using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


// CREATE TABLE [dbo].[Producto] (
// [id]                INT            IDENTITY(1, 1) NOT NULL,
// [id_categoria]      INT   	      NOT NULL,
// [id_desarrollador]  INT            NOT NULL,
// [nombre]            VARCHAR (45)   NOT NULL,
// [pvp] 		       DECIMAL (7,2)  NULL,
// [descripcion]       TEXT           NOT NULL,
// [fecha_salida]      DATE           NOT NULL,
// [clasificacion]     INT            NULL,
// [imagen]            VARCHAR (MAX)  NULL,
// [mostrar]           BIT            DEFAULT((0)) NOT NULL,
// PRIMARY KEY CLUSTERED ([id] ASC),
// UNIQUE NONCLUSTERED([nombre] ASC),
// CONSTRAINT[fk_Producto_CategoriaProducto] FOREIGN KEY([id_categoria]) REFERENCES[dbo].[CategoriaProducto]([id]),
// CONSTRAINT[fk_Producto_Desarrollador] FOREIGN KEY([id_desarrollador]) REFERENCES[dbo].[Desarrollador]([id])
// );


namespace library
{
    class CADProducto
    {
        private string constring;

        public CADProducto() 
        { 
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        // Método para crear un Producto -> modo desconectado
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
                nuevafila[6] = en.clasificacion;
                nuevafila[7] = en.imagen;
                nuevafila[8] = en.mostrar;
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

        // Método para leer un Producto (por id) -> modo desconectado
        public bool readProducto(ENProducto en) 
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

        // Método para leer un Producto (por nombre) -> modo desconectado
        public bool readByNameProducto(ENProducto en)
        {
            bool read = false;
            SqlConnection c = null;
            String comando = "Select * From Producto where nombre='" + en.nombre + "'";

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

        // Métodor para enseñar Producto -> modo desconectado
        public DataSet showProducto(ENProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
          
            try
            { 
                String comando = "Select * From Producto where id=" + en.id;
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

        // Método para actualizar un Producto -> modo conectado
        public bool updateProducto(ENProducto en)
        {
            bool update = false;
            SqlConnection c = null;
            String comando = "Update Producto set nombre='" + en.nombre + "', pvp=" + en.pvp + ", descripcion='" + en.descripcion + "', clasificacion=" + en.clasificacion + " where id=" + en.id;

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

        // Método para borrar un Producto -> modo desconectado
        public bool deleteProducto(ENProducto en)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Delete From Producto where id= " + en.id;

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

        // Método para enseñar todos los Productos -> modo desconectado
        public DataSet showAllProducto()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try 
            {
                String comando = "Select * From Producto where mostrar=1";
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

        // ---------------------------------------------------------------------- 
        /*
         * Ordenar Productos de una Categoría
        */
        // ----------------------------------------------------------------------

        // Método para enseñar por nombre en orden ascendiente Productos -> modo desconectado
        public DataSet showOrderByNameASCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try 
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + "and mostrar=1 order by nombre asc";
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

        // Método para enseñar por nombre en orden descendiente Productos -> modo desconectado
        public DataSet showOrderByNameDESCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 order by nombre desc";
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

        // Método para enseñar por precio en orden ascendiente Productos -> modo desconectado
        public DataSet showOrderByPriceASCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 order by pvp asc";
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

        // Método para enseñar por precio en orden descendiente Productos -> modo desconectado
        public DataSet showOrderByPriceDESCProducto(ENCategoriaProducto en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where id_categoria=" + en.id + " and mostrar=1 order by pvp desc";
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

        // Método para enseñar por nombre en orden ascendiente Productos -> modo desconectado
        public DataSet showOrderByNameASCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 order by nombre asc";
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

        // Método para enseñar por nombre en orden descendiente Productos -> modo desconectado
        public DataSet showOrderByNameDESCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 order by nombre desc";
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

        // Método para enseñar por precio en orden ascendiente Productos -> modo desconectado
        public DataSet showOrderByPriceASCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 order by pvp asc";
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

        // Método para enseñar por precio en orden descendiente Productos -> modo desconectado
        public DataSet showOrderByPriceDESCProductos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where mostrar=1 order by pvp desc";
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

        // Método para buscar Productos por nombre -> modo desconectado
        public DataSet searchByNameProducto(String name)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Producto where nombre like '%" + name + "%' and mostrar=1";
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
