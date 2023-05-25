using library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//CREATE TABLE[dbo].[Oferta] (
//    [id]        INT IDENTITY(1, 1) NOT NULL,
//    [oferta]      	DECIMAL (7,2)  	NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC),
//    CONSTRAINT[fk_Oferta_Producto] FOREIGN KEY([id]) REFERENCES[dbo].[Producto]([id])
//);

//----------------------------------------------------------------------------------------------
//--OFERTA_HAS_PRODUCTO

//CREATE TABLE[dbo].[Oferta_has_Producto] (
//    [oferta_id]     INT NOT NULL,
//    [producto_id]      	INT  	NOT NULL,
//    PRIMARY KEY CLUSTERED ([oferta_id] ASC, [producto_id] ASC),
//    CONSTRAINT[fk_OfertaHProducto_Oferta] FOREIGN KEY([oferta_id]) REFERENCES[dbo].[Oferta]([id]),
//    CONSTRAINT[fk_OfertaHProducto_Producto] FOREIGN KEY([producto_id]) REFERENCES[dbo].[Producto]([id])
//);

namespace library
{
    internal class CADOferta
    {

        private string constring;

        public CADOferta()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool readOferta(ENOferta o)
        {
            bool read = false;
            SqlConnection c = null;
            String comando = "Select * From Oferta where id=" + o.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    read = true;
                    o.id_producto = Convert.ToInt32(dr["id_producto"].ToString());
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

        public bool primeraOferta(ENOferta o, ENProducto prod)
        {
            bool update = false;
            SqlConnection c = null;
            o.oferta = prod.pvp / 2;
            String comando = "Update Producto set borrado=0, mostrar=1 where id=" + prod.id;
            String comando2 = "Update Oferta set id_producto=" + prod.id + ", oferta=" + o.oferta + " where id=" + o.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlCommand com2 = new SqlCommand(comando2, c);

                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
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

        public bool segundaOferta(ENOferta o, ENProducto prod)
        {
            bool update = false;
            SqlConnection c = null;
            o.oferta = prod.pvp - (prod.pvp * 25 / 100);
            String comando = "Update Producto set borrado=0, mostrar=1 where id=" + prod.id;
            String comando2 = "Update Oferta set id_producto=" + prod.id + ", oferta=" + o.oferta + " where id=" + o.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlCommand com2 = new SqlCommand(comando2, c);

                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
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

        public bool terceraOferta(ENOferta o, ENProducto prod)
        {
            bool update = false;
            SqlConnection c = null;
            o.oferta = prod.pvp - (prod.pvp * 15 / 100);
            String comando = "Update Producto set borrado=0, mostrar=1 where id=" + prod.id;
            String comando2 = "Update Oferta set id_producto=" + prod.id + ", oferta=" + o.oferta + " where id=" + o.id;

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlCommand com2 = new SqlCommand(comando2, c);

                com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
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
    }
}
