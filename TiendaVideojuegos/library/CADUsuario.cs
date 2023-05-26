﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace library
{
    public class CADUsuario
    {
        private string constring;

        public CADUsuario()
        {
            this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool signIn(ENUsuario usu)
        {
            bool create = false;
            string hashed_pass = hashPassword(usu.password);
            SqlConnection conection = new SqlConnection(constring);

            String str = "Insert INTO Usuario (username,nombre,apellidos,email,contraseña,edad,calle,pueblo,provincia,codigo_postal,telefono,admin) VALUES('" + usu.username + "', '" + usu.nombre + "', '" + usu.apellidos + "', '" + usu.email + "', '" + hashed_pass +
                "', " + usu.edad + ", '" + usu.calle + "', '" + usu.pueblo + "', '" + usu.provincia + "', '" + usu.codigo_postal +
                "', '" + usu.telefono + "', '" + usu.admin + "')";
            try
            {
                conection.Open();
                SqlCommand cons = new SqlCommand(str, conection);
                cons.ExecuteNonQuery();
                create = true;
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
            finally
            {
                if (conection != null) conection.Close();
            }
            return create;
        }


        public bool updateUsuario(ENUsuario usu)
        {
            bool update = false;
            string hashed_pass = null;
            if (usu.password != null)
            {
                hashed_pass = hashPassword(usu.password);
            }
            
            SqlConnection c = null;
            String comando = "Update Usuario set nombre='" + usu.nombre + "', apellidos='" + usu.apellidos + "', edad=" + usu.edad + ", calle='" + usu.calle + "', pueblo='" + usu.pueblo + "', provincia='" + usu.provincia + "', codigo_postal='" + usu.codigo_postal + 
                "', telefono='" + usu.telefono + "' where username='" + usu.username + "'";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
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

        public bool deleteUsuario(ENUsuario usu)
        {
            bool delete = false;
            SqlConnection c = null;
            String comando = "Delete From Usuario where username = '" + usu.username + "'";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                delete = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                delete = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return delete;
        }

        public bool readUsuario(ENUsuario usu)
        {
            bool read_user = false;
            SqlConnection c = null;
            String comando = "Select * From Usuario where username='" + usu.username + "'";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    read_user = true;
                    usu.nombre = dr["nombre"].ToString();
                    usu.apellidos = dr["apellidos"].ToString();
                    usu.email = dr["email"].ToString();
                    usu.password = dr["contraseña"].ToString();
                    usu.edad = int.Parse(dr["edad"].ToString());
                    usu.calle = dr["calle"].ToString();
                    usu.pueblo = dr["pueblo"].ToString();
                    usu.provincia = dr["provincia"].ToString();
                    usu.codigo_postal = dr["codigo_postal"].ToString();
                    usu.telefono = dr["telefono"].ToString();
                    usu.admin = bool.Parse(dr["admin"].ToString());
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                read_user = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                read_user = false;
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (c != null) c.Close();
            }

            return read_user;
        }

        public DataSet profileUsuario(ENUsuario usu)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Usuario where username=" + usu.username;
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Usuario");

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

        // Método para enseñar todos los Usuarios -> modo desconectado
        public DataSet showAllUsers()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                String comando = "Select * From Usuario";
                SqlDataAdapter da = new SqlDataAdapter(comando, c);
                da.Fill(bdvirtual, "Usuario");
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

        public bool updateAdminUser(ENUsuario usu)
        {
            bool update = false;
            SqlConnection c = null;
            String comando = "Update Usuario set admin='" + usu.admin + "' where username='" + usu.username + "'";

            try
            {
                c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(comando, c);

                com.ExecuteNonQuery();
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


        public string hashPassword(string password)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(password);
            byte[] hash = sha1.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
