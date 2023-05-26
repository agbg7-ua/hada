﻿using System;
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
    public class CADCarrito
    {
        private string constring;

        public CADCarrito()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createCarrito(ENCarrito en)
        {
            //Crear un nuevo carrito en la BBDD
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
                if (c != null) c.Close();
            }

            return creado;
        }
        public bool updateCarrito(ENCarrito en)
        {
            //Actualizar importe total de un carrito existente en BBDD tomando ENCarrito como parametro
            bool update = false;
            SqlConnection c = new SqlConnection(constring);

            try
            {
                c.Open();
                String comando = "Update Carrito set importe_total=" + en.importe_total + " where id_usuario='" + en.id_usuario + "'";
                SqlCommand com = new SqlCommand(comando, c);
                com.ExecuteNonQuery();
                update = true;
                return update;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return update;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return update;
            }
            finally
            {
                if (c != null) c.Close();
            }
        }

        public bool readCarrito(ENCarrito en)
        {
            //Leer los detalles de un carrito de la BBDD utilizando su Id
            bool read = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Carrito", c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataRow fila = t.Rows[i];

                    if (en.id == int.Parse(fila[0].ToString()))
                    {
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

        public bool readCarritoByUser(ENCarrito car, ENUsuario en)
        {
            //Leer detalles de  un carrito de la BBDD utilizando el nombre de usuario asociado
            bool read = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);


            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Carrito", c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    DataRow fila = t.Rows[i];

                    if (en.username == fila[1].ToString())
                    {
                        read = true;
                        car.id = int.Parse(fila[0].ToString());
                        car.importe_total = float.Parse(fila[2].ToString());
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

        public DataSet deleteCarrito(ENCarrito en, int Id)
        {
            //Eliminar carrito de la BBDD utilizando su Id
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Carrito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Carrito"];
                t.Rows[Id].Delete();
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
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
                if (c != null) c.Close();
            }
        }

        public DataSet showCarrito(ENCarrito en)
        {
            //Mostrar los detalles de un carrito de la BBDD utilizando su Id
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * FROM Carrito WHERE id =" + en.id;
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
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
                if (c != null) c.Close();
            }
        }

        public DataSet showCarritoByUser(ENUsuario en)
        {
            //Mostrar los detalles de un carrito de la BBDD utilizando nombre de usuario asociado
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito where id_usuario=" + en.nombre;
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
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
                if (c != null) c.Close();
            }
        }

        //Lista todos los Carritos
        public DataSet listarCarritos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Carrito";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Carrito");

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