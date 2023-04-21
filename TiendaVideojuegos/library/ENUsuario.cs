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
        private string _contrasenya;
        private int _edad;
        private string _calle;
        private string _pueblo;
        private string _provincia;
        private string _codigo_postal;
        private string _telefono;

        public string username { 
            get {return _username;}
            set {_username = value;} 
        }
        public string nombre { 
            get {return _nombre;}
            set {_nombre = value;}
        }
        public string apellidos { 
            get {return _apellidos;}
            set {_apellidos = value;}
        }
        public string email { 
            get {return _email;}
            set {_email = value;}
        }
        public string password { 
            get {return _contrasenya;}
            set {_contrasenya = value;}
        }
        public int edad { 
            get {return _edad;}
            set {_edad = value;}
        }
        public string calle { 
            get {return _calle;}
            set {_calle = value;}
        }
        public string pueblo { 
            get {return _pueblo;}
            set {_pueblo = value;}       
        }
        public string provincia {
            get { return _provincia; }
            set { _provincia = value; }
        }
        public string codigo_postal {
            get { return _codigo_postal; }
            set { _codigo_postal = value; }
        }
        public string telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }

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
