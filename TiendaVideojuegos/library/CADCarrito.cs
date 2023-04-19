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
            Dataset bdvirtual = new Dataset();
            Sqlconnection c = new Sqlconnection(constring);
            try
            {

                SqlDataAdapter ad = new SqlDataAdapter("select * from Carrito", c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                DataRow nuevafila = t.NewRow();
                nuevafila[1] = en.id_usuario;
                nuevafila[2] = en.importe_total;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(ad);
                ad.Update(bdvirtual, "Producto");
                creado = true;
                
            }
            catch (SqlException ex)
            {
                creado = false;
                Console.WriteLine("User operation has failed. Error: {0}", excS.Message);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine("User operation has failed. Error: {0}", exc.Message);
            }
            finally
            {
                c.close();
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
                da.Fill(bdvirtual, "Carrito");
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
                da.Update(bdvirtual, "Carrito");
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
    
        //modo conectado para hacer show
        public bool showCarrito(ENCarrito en)
        {
            bool show = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select * from Carrito", c);
                ad.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                for (int  i = 0; i < t.Rows.Count; i++)
                {
                    DataRow fila = t.Rows[i];
                    if (en.id == int.Parse(fila[0].ToString()))
                    {
                        show = true;
                        en.id_usuario = int.Parse(fila[1].ToString());
                        en.importe_total = float.Parse(fila[2].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                show = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                show = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
             c.Close();
            }

            return show;

        }
    }
}