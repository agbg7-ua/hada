﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace library
{
    public class CADComentario
    {
        private string constring;
        public CADComentario()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool createComentario(ENComentario coment)
        {
            bool created = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Comentario", c);
                da.Fill(bdvirtual, "Comentario");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["Comentario"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = coment.id_producto;
                nuevafila[2] = coment.id_usuario;
                nuevafila[3] = coment.date;
                nuevafila[4] = coment.text;
                nuevafila[5] = coment.valoracion;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                da.Update(bdvirtual, "Comentario");
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
        public bool updateComentario(ENComentario coment)
        {
            bool update = false;
            try
            {
                SqlConnection conection = null;
                conection = new SqlConnection(constring);
                conection.Open();
                string str = "Update[dbo].[Comentario](id_producto,id,id_usuario,fecha,comentario,valoracion) set id_producto = '"+coment.id_producto +"' ,id= '" + coment.id + "' ,comentario=" + coment.text + "' ,valoracion= " + coment.valoracion + "WHERE id = '" + coment.id + "'";
                SqlCommand cons = new SqlCommand(str, conection);
                cons.ExecuteNonQuery();
                update = true;
                conection.Close();
            }
            catch (SqlException e)
            {
                update = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);

            }
            catch (Exception e)
            {
                update = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            return update;
        }
        public bool deleteComentario(ENComentario coment)
        {
            bool update = false;
            try
            {
                SqlConnection conection = null;
                conection = new SqlConnection(constring);
                conection.Open();
                string str = "DELETE FROM [dbo].[Comentario] WHERE id = '" + coment.id + "'";
                SqlCommand cons = new SqlCommand(str, conection);
                cons.ExecuteNonQuery();
                update = true;
                conection.Close();
            }
            catch (SqlException e)
            {
                update = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);

            }
            catch (Exception e)
            {
                update = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            return update;
        }
        public bool readComentario(ENComentario coment)
        {
            bool create = true;
            try
            {
                SqlConnection conect = null;
                conect = new SqlConnection(constring);
                conect.Open();

                string str = "Select * From [dbo].[Comentario] Where id = '" + coment.id + "' ";
                SqlCommand cons = new SqlCommand(str, conect);
                SqlDataReader search = cons.ExecuteReader();
                search.Read();
                if ((int)search["id"] == coment.id)
                {
                    coment.id_producto = (int)search["id_producto"];
                    coment.id_usuario = search["id_usuario"].ToString();
                    coment.text = search["text"].ToString();
                    coment.valoracion = (int)search["valoracion"];
                    coment.date = (DateTime)search["fecha"];
                    coment.id = (int)search["id"];
                    create = true;
                }
                else
                {
                    create = false;
                }
                search.Close();
                conect.Close();
            }
            catch (SqlException e)
            {
                create = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                create = false;
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            return create;
        }

         public DataSet filterProducto(ENProducto prod)
        {
            DataSet dataset = new DataSet();
            SqlConnection conect = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Comentario where id_producto=" + prod.id + "mostrar =1 and borrado=0";
                SqlDataAdapter ada = new SqlDataAdapter(comando, conect);
                ada.Fill(dataset, "Comentario");
                return dataset;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            finally
            {
                if (conect != null) conect.Close();
            }
        }
         public DataSet filterValoracion(ENComentario coment)
        {
            DataSet dataset = new DataSet();
            SqlConnection conect = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Comentario where valoracion=" + coment.valoracion + " and mostrar =1 and borrado=0";
                SqlDataAdapter ada = new SqlDataAdapter(comando, conect);
                ada.Fill(dataset, "Comentario");
                return dataset;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            finally
            {
                if (conect != null) conect.Close();
            }
        }
         public DataSet filterFecha(ENComentario coment)
        {
            DataSet dataset = new DataSet();
            SqlConnection conect = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Comentario where date=" + coment.date + "mostrar =1 and borrado=0";
                SqlDataAdapter ada = new SqlDataAdapter(comando, conect);
                ada.Fill(dataset, "Comentario");
                return dataset;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            finally
            {
                if (conect != null) conect.Close();
            }
        }
        public DataSet showAll(ENProducto en)
        {
            DataSet dataset = new DataSet();
            SqlConnection conect = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Comentario where id_producto=" + en.id;
                SqlDataAdapter ada = new SqlDataAdapter(comando, conect);
                ada.Fill(dataset, "Comentario");
                return dataset;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return dataset;
            }
            finally
            {
                if (conect != null) conect.Close();
            }
        }
    }
}
