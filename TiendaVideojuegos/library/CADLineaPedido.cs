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
    public class CADLineaPedido
    {
        private string constring;
        public CADLineaPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        // Crear Línea de Pedido
        public bool createLineaPedido(ENLineaPedido en)
        {
            bool created = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From LineaPedido", c);
                da.Fill(bdvirtual, "LineaPedido");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["LineaPedido"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = en.id_pedido;
                nuevafila[2] = en.id_producto;
                nuevafila[3] = en.cantidad;
                nuevafila[4] = en.importe;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "LineaPedido");
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
    
        // Leer Línea de Pedida
        public bool readLineaPedido(ENLineaPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand readSql = new SqlCommand("Select * from LineaPedido", c);
                SqlDataReader dr = readSql.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["id_linea"].ToString() == en.id_linea.ToString() && dr["id_pedido"].ToString() == en.id_pedido.ToString())
                    {
                        res = true;
                        en.id_producto = int.Parse(dr["id_producto"].ToString());
                        en.cantidad = int.Parse(dr["cantidad"].ToString());
                        en.importe = float.Parse(dr["importe"].ToString());
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
        public DataSet listaLineasPedido(ENPedido en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * from LineaPedido where id_pedido=" + en.id;
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "LineaPedido");
                return bdvirtual;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
                return bdvirtual;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return bdvirtual;
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
        }

        // Lista los 10 productos más vendidos
        public DataTable top10Productos()
        {
            DataTable table = new DataTable();

            SqlConnection c = new SqlConnection(constring);

            try
            {
                c.Open();
                string command = "SELECT TOP 10 P.nombre, SUM(LP.cantidad) AS total_vendido FROM Producto AS P JOIN LineaPedido AS LP ON P.id = LP.id_producto GROUP BY P.id, P.nombre ORDER BY total_vendido DESC; ";
                SqlCommand cmd = new SqlCommand(command, c);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                return table;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error: {0}", sqlEx.Message);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return table;
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
        }
    }
}