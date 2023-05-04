using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/*CREATE TABLE [dbo].[Carrito] (
    [id] INT          	IDENTITY (1, 1) NOT NULL,
    [id_usuario]    	VARCHAR (30) 	NOT NULL,
    [importe_total]   	DECIMAL (7,2) 	DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [fk_Carrito_Usuario] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[Usuario] ([username])
);*/
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
              if(c != null)  c.Close();
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
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                t.Rows[Id]["id_usuario"] = en.id_usuario;
                t.Rows[Id]["importe_total"] = en.importe_total;
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
               if(c != null) c.Close();
            }
        }

        //readCarrito

        public bool readCarrito(ENCarrito en)
        {
            bool read = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

           
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Carrito", c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];

                for (int i = 0; i < t.Rows.Count; i++) {
                    DataRow fila = t.Rows[i];

                    if (en.id == int.Parse(fila[0].ToString())) {
                        read = true;
                        en.id_usuario = fila[1].ToString();
                        en.importe_total = float.Parse(fila[2].ToString());
                       
                    }
                }
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

        public DataSet deleteCarrito(ENCarrito en,int Id)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito";
                SqlDataAdapter  da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Carrito");
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
              if(c != null)  c.Close();
            }
        }

        public DataSet showCarrito(ENCarrito en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            { 
                String comando = "Select * FROM Carrito WHERE id =" + en.id;
                SqlDataAdapter da = new SqlDataAdapter(comando,c);
                da.Fill(bdvirtual,"Carrito");
                
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
              if(c != null)  c.Close();
            }
        }


        //list all carritos
        public DataSet listCarritos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                string comando = "Select * From Carrito ";
                SqlDataAdapter da = new SqlDataAdapter(comando , c);
                da.Fill(bdvirtual, "Carrito");
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
                if( c != null) c.Close();
            }
        }

        //show carrito by name de usuario
      public DataSet listCarritosByUser(string idUsuario)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                String comando = "Select * From Carrito where id_usuario like '%" + idUsuario + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(comando,c);
                da.Fill (bdvirtual, "Carrito");
                return bdvirtual;
            }
            catch(SqlException ex)
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
                if( c != null) c.Close();
            }


        }
   

}