using library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool insertar(ENOferta en)
        {
            bool res = false;
            string sql = "INSERT INTO Oferta (oferta) VALUES (@oferta)";
            string sql2 = "INSERT INTO Oferta_has_Producto (oferta_id, producto_id) VALUES (@oferta_id, @producto_id)";
            try
            {
                // usando 'using' para que se cierre la conexion automaticamente aun si hay error
                using (var con = new System.Data.SqlClient.SqlConnection(constring))
                {
                    con.Open();
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@oferta", en.oferta);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql2, con))
                    {
                        cmd.Parameters.AddWithValue("@oferta_id", en.id);
                        cmd.Parameters.AddWithValue("@producto_id", en.producto_id);
                        cmd.ExecuteNonQuery();
                    }
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return res;
        }




        public bool borrar(ENOferta en)
        {
            bool res = false;
            string sql = "DELETE FROM Oferta WHERE id = @id";
            string sql2 = "DELETE FROM Oferta_has_Producto WHERE oferta_id = @oferta_id";
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql2, con))
                    {
                        cmd.Parameters.AddWithValue("@oferta_id", en.id);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", en.id);
                        cmd.ExecuteNonQuery();
                    }
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return res;
        }

        /// <summary>
        /// Modifica solo el precio de la oferta
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool modificar(ENOferta en)
        {
            bool res = false;
            string sql = "UPDATE Oferta SET oferta = @oferta WHERE id = @id";

            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@oferta", en.oferta);
                        cmd.Parameters.AddWithValue("@id", en.id);
                        cmd.ExecuteNonQuery();
                    }
                    res = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return res;
        }


        public List<ENOferta> obtener(ENOferta oferta)
        {
            int id = oferta.id;
            List<ENOferta> res = new List<ENOferta>();

            string sql = String.Format(@"
                Select Overta.id, Oferta.oferta, Oferta_has_Producto.producto_id
                From Oferta, Oferta_has_Producto
                Where Oferta.id = Oferta_has_Producto.oferta_id
                and Oferta_has_Producto.producto_id = {0}", id);
            SqlConnection con = new SqlConnection(constring);
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ENOferta en = new ENOferta();
                    en.id = dr.GetInt32(0);
                    en.oferta = dr.GetDecimal(1);
                    en.producto_id = dr.GetInt32(2);
                    res.Add(en);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }
            return res;
        }



    }
}
