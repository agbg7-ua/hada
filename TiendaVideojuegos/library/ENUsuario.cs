using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;

namespace library
{
    class ENUsuario
    {
        private string _username;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _contraseña;
        private int _edad;
        private string _calle;
        private string _pueblo;
        private string _provincia;
        private string _codigo_postal;
        private string _telefono;

        public string username { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int edad { get; set; }
        public string calle { get; set; }
        public string pueblo { get; set; }
        public string provincia { get; set; }
        public string codigo_postal { get; set; }
        public string telefono { get; set; }

        public ENUsuario()
        {
            this.username = "";
            this.nombre = "";
            this.apellidos = "";
            this.email = "";
            this.password = "";
            this.edad = 0;
            this.calle = "";
            this.pueblo = "";
            this.provincia = "";
            this.codigo_postal = "";
            this.telefono = "";
        }
        public ENUsuario(string username, string nombre, string apellidos, string email, string password, int edad, string calle,string pueblo, string provincia, string codigo_postal, string telefono)
        {
            this.username = username;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.password = password;
            this.edad = edad;
            this.calle = calle;
            this.pueblo = pueblo;
            this.provincia = provincia;
            this.codigo_postal = codigo_postal;
            this.telefono = telefono;
        }
        public ENUsuario(ENUsuario usu)
        {
            this.username = usu.username;
            this.nombre = usu.nombre;
            this.apellidos = usu.apellidos;
            this.email = usu.email;
            this.password = usu.password;
            this.edad = usu.edad;
            this.calle = usu.calle;
            this.pueblo = usu.pueblo;
            this.provincia = usu.provincia;
            this.codigo_postal = usu.codigo_postal;
            this.telefono = usu.telefono;
        }
        public bool createUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.createUsuario(this);
        }
        public bool updateUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.updateUsuario(this);
        }
        public bool deleteUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.deleteUsuario(this);
        }
        public bool readUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readUsuario(this);
        }
        public bool showUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.showUsuario(this);
        }
    }
}
