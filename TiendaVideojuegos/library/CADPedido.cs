using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

//CREATE TABLE[dbo].[Pedido] (
// [id]        INT IDENTITY(1, 1) NOT NULL,
// [id_usuario]    	VARCHAR (30) 	NOT NULL,
// [fecha]      	DATE         	NOT NULL,
// [importe_total] 	DECIMAL (7,2)   NOT NULL,
// PRIMARY KEY CLUSTERED ([id] ASC),
// CONSTRAINT[fk_Pedido_Usuario] FOREIGN KEY([id_usuario]) REFERENCES[dbo].[Usuario]([username])
// );

namespace library
{
    public class CADPedido
    {
        private string constring;
        public CADPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        // Crear Pedido
        public bool createPedido(ENPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand insertSql = new SqlCommand("Insert into Pedido(id,id_usuario,fecha,importe_total) VALUES ('" + en.id + "','" + en.id_usuario + "','" + en.fecha + "','" + en.importe_total + "')", c);
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
        // Leer Pedido
        public bool readPedido(ENPedido en)
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
                    if (dr["id"].ToString() == en.id.ToString())
                    {
                        res = true;
                        en.id_usuario = int.Parse(dr["id_usuario"].ToString());
                        en.fecha = DateTime.Parse(dr["fecha"].ToString());
                        en.importe_total = double.Parse(dr["importe_total"].ToString());
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
        //Actualizar Pedido
        public bool updatePedido(ENPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                if (en.fecha == null)
                {
                    throw new ArgumentException("FECHA NULA");
                }
                if (en.importe_total == 0)
                {
                    throw new ArgumentException("IMPORTE TOTAL NULO");
                }
                SqlCommand updateSql = new SqlCommand("UPDATE Pedido SET id_usuario ='" + en.id_usuario + "', fecha = '" + en.fecha + "', importe_total= '" + en.importe_total + "' where id = '" + en.id + "'", c);
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
        //Borrar Pedido
        public bool deletePedido(ENPedido en)
        {
            bool res = false;
            SqlConnection c = null;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand deleteSql = new SqlCommand("Delete from Pedido where id = '" + en.id + "'", c);
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
        //Lista todos los Pedidos
        public DataSet listarPedidos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Pedido";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Pedido");

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
        // Listar Pedidos importe_total ASCENDENTE -> de un mismo usuario
        public DataSet listarPedidosImporteAsc(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Pedido where id_usuario=" + en.nombre + " order by importe_total asc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Pedido");
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
        // Listar Pedidos importe_total DESCENDENTE -> de un mismo usuario
        public DataSet listarPedidosImporteDesc(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Pedido where id_usuario=" + en.nombre + " order by importe_total desc";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Pedido");
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
    }
}