using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace library
{
    public class CADUsuario
    {
        private String constring;
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        public bool createUsuario(ENUsuario usu)
        {
            bool create = false;
            try
            {
                SqlConnection conection = null;
                conection = new SqlConnection(constring);
                conection.Open();
                string str = "Insert INTO[dbo].[Usuarios](username,nombre, apellidos,email,password,edad,calle,pueblo,provincia,codigo_postal,telefono) VALUES('" + usu.username + "', '" + usu.nombre + "', " + usu.apellidos + "', " + usu.email + "', " + usu.password + "', " + usu.edad + "', " + usu.calle + "', " + usu.pueblo + "', " + usu.provincia + "', " + usu.codigo_postal + "', " + usu.telefono + ")";
                SqlCommand cons = new SqlCommand(str, conection);
                cons.ExecuteNonQuery();
                create = true;
                conection.Close();
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
        public bool updateUsuario(ENUsuario usu)
        {
            return true;
        }
        public bool deleteUsuario(ENUsuario usu)
        {
            return true;
        }
        public bool signIn(ENUsuario usu)
        {
            return true;
        }
        public bool readUsuario(ENUsuario usu)
        {
            return true;
        }
        public bool addOferta(bool admin)
        {
            return true;
        }
        public bool addDesarrollador(bool admin)
        {
            return true;
        }
        public bool addProducto(bool admin)
        {
            return true;
        }
        public bool deleteOferta(bool admin)
        {
            return true;
        }
        public bool deleteDesarrollador(bool admin)
        {
            return true;
        }
        public bool deleteProducto(bool admin)
        {
            return true;
        }
        public bool modifyOferta(bool admin)
        {
            return true;
        }
        public bool modifyDesarrollador(bool admin)
        {
            return true;
        }
        public bool modifyProducto(bool admin)
        {
            return true;
        }
    }
}
