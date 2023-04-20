using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

//CREATE TABLE[dbo].[LineaPedido] (
// [id_pedido]     INT NOT NULL,
// [id_linea]     	INT         	IDENTITY (1, 1) NOT NULL,
// [id_producto]  	INT         	NOT NULL,
// [cantidad]  	INT            	NOT NULL,
// [importe]   	DECIMAL (7,2) 	NOT NULL,
// PRIMARY KEY CLUSTERED ([id_pedido] ASC, [id_linea] ASC),
// CONSTRAINT[fk_LineaPedido_Pedido] FOREIGN KEY([id_pedido]) REFERENCES[dbo].[Pedido]([id]),
// CONSTRAINT[fk_LineaPedido_Producto] FOREIGN KEY([id_producto]) REFERENCES[dbo].[Producto]([id])
// );

namespace library
{
    class CADLineaPedido
    {
        private string _constring;
        public string constring
        {
            get { return _constring; }
            set { _constring = value; }
        }
        public CADLineaPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        // Crear Línea de Pedido
        public bool createLineaPedido(ENLineaPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand insertSql = new SqlCommand("Insert into LineaPedido(id_pedido,id_linea,id_producto,cantidad,importe) VALUES ('" + en.id_pedido + "','" + en.id_linea + "','" + en.id_producto + "','" + en.cantidad + "','" + en.importe + "')", c);
                insertSql.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return res;
        }
        // Leer Línea de Pedida
        public bool readLineaPedido(ENLineaPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand readSql = new SqlCommand("Select * from Usuarios", c);
                SqlDataReader dr = readSql.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_linea"].ToString() == en.id_linea.ToString() && dr["id_pedido"].ToString() == en.id_pedido.ToString())
                    {
                        res = true;
                        en.id_producto = int.Parse(dr["id_producto"].ToString());
                        en.cantidad = int.Parse(dr["cantidad"].ToString());
                        en.importe = double.Parse(dr["importe"].ToString());
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return res;
        }
        // Actualizar Línea de Pedido
        public bool updateLineaPedido(ENLineaPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand updateSql = new SqlCommand("UPDATE LineaPedido SET id_producto = '" + en.id_producto + "', importe = '" + en.importe + "' where id_linea = '" + en.id_linea + "' AND id_pedido = '" + en.id_pedido + "'", c);
                updateSql.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);

            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return res;
        }
        // Borrar Línea de Pedido
        public bool deleteLineaPedido(ENLineaPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand deleteSql = new SqlCommand("DELETE from LineaPedido where id_linea = '" + en.id_linea + "' AND id_pedido = '" + en.id_pedido + "'", c);
                deleteSql.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);

            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return res;
        }
        // Listar Líneas de un mismo Pedido
        public List<ENLineaPedido> listaLineasPedido(ENLineaPedido en)
        {
            List<ENLineaPedido> res = new List<ENLineaPedido>();
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand listSql = new SqlCommand("Select * from LineaPedido where id_pedido = '" + en.id_pedido + "'", c);
                SqlDataReader dr = listSql.ExecuteReader();
                while (dr.Read())
                { 
                    ENLineaPedido nEn = new ENLineaPedido(en.id_pedido, int.Parse(dr["id_linea"].ToString()), int.Parse(dr["id_producto"].ToString()), int.Parse(dr["cantidad"].ToString()) ,double.Parse(dr["importe"].ToString()));
                    res.Add(nEn);
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);

            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return res;
        }
    }
}