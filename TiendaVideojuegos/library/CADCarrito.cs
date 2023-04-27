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
    class CADCarrito
    {
        private string constring;

        public CADCarrito()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
      public bool createCarrito(ENCarrito en) 
        {
           bool creado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {

                SqlDataAdapter ad = new SqlDataAdapter("select * from Carrito", c);
                ad.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                DataRow nuevafila = t.NewRow();
                nuevafila[1] = en.id_usuario;
                nuevafila[2] = en.importe_total;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(ad);
                ad.Update(bdvirtual, "Carrito");
                creado = true;
                
            }
            catch (SqlException ex)
            {
                creado = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                c.Close();
            }

            return creado;
        }
        public DataSet updateCarrito(ENCarrito en, int Id)
        {

            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito";
                SqlDataAdapter ad = new SqlDataAdapter(comando, c);
                ad.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                t.Rows[Id]["id_usuario"] = en.id_usuario;
                t.Rows[Id]["importe_total"] = en.importe_total;
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(ad);
                ad.Update(bdvirtual, "Carrito");
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
                c.Close();
            }
        }

        public DataSet deleteCarrito(ENCarrito en,int Id)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito";
                SqlDataAdapter ad = new SqlDataAdapter(comando, c);
                ad.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                t.Rows[Id].Delete();
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(ad);
                ad.Update(bdvirtual, "Carrito");
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
                c.Close();
            }
        }

        public bool showCarrito(ENCarrito en)
        {
            bool found = false;
            SqlConnection c = new SqlConnection(constring);

            try
            {
                c.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Carrito WHERE id = @id", c);
                cmd.Parameters.AddWithValue("@id", en.id);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    found = true;
                    en.id_usuario = dr["id_usuario"].ToString();
                    en.importe_total = float.Parse(dr["importe_total"].ToString());

                    Console.WriteLine("ID: {0}", en.id);
                    Console.WriteLine("ID Usuario: {0}", en.id_usuario);
                    Console.WriteLine("Importe Total: {0}", en.importe_total);
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            finally
            {
                c.Close();
            }

            return found;
        }



        public List<ENCarrito> listCarritos()
{
    List<ENCarrito> listaCarritos = new List<ENCarrito>();
    DataSet bdvirtual = new DataSet();
    SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from Carrito", c);
                ad.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataRow fila = t.Rows[i];
                    ENCarrito carrito = new ENCarrito();
                    carrito.id = int.Parse(fila[0].ToString());
                    carrito.id_usuario = fila[1].ToString();
                    carrito.importe_total = float.Parse(fila[2].ToString());
                    listaCarritos.Add(carrito);
                }
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
                c.Close();
            }

            return listaCarritos;

        }

        /*
public List<ENCarrito> listCarritosByUser(string idUsuario)
{
    List<ENCarrito> lista = new List<ENCarrito>();
    string consulta = "SELECT * FROM Carrito WHERE id_usuario = @id_usuario";
            SqlConnection c = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(consulta, c);

    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

    SqlDataReader dr = cmd.ExecuteReader();

    while (dr.Read())
    {
        ENCarrito c = new ENCarrito();

        c.id = int.Parse(dr["id"].ToString());
        c.id_usuario = dr["id_usuario"].ToString();
        c.importe_total = float.Parse(dr["importe_total"].ToString());

        lista.Add(c);
    }

    dr.Close();
    c.Close();

    return lista;
}
        */
    }
        
   

}