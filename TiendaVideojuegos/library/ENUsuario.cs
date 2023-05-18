using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;

namespace library
{
    public class ENUsuario
    {
        private string _username;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;
        private int _edad;
        private string _calle;
        private string _pueblo;
        private string _provincia;
        private string _codigo_postal;
        private string _telefono;
        private bool _admin;

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
            get {return _password;}
            set {_password = value;}
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
        public bool admin
        {
            get { return _admin; }
            set { _admin = value; }
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
            this.admin = false;
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

        public bool signIn()
        {
            CADUsuario usu = new CADUsuario();
            bool create = false;
            if (!usu.readUsuario(this))
            {
                create = usu.signIn(this);
            }
            return create;
        }

        public bool updateUsuario()
        {
            ENUsuario aux = new ENUsuario();
            CADUsuario usu = new CADUsuario();

            bool update = false;
            aux.nombre = this.nombre;
            aux.edad = this.edad;
            aux.username = this.username;
            aux.apellidos = this.apellidos;
            aux.email = this.email;
            aux.password = this.password;
            aux.calle = this.calle;
            aux.pueblo = this.pueblo;
            aux.provincia = this.provincia;
            aux.codigo_postal = this.codigo_postal;
            aux.telefono = this.telefono;
            if (usu.readUsuario(this))
            {
                this.nombre = aux.nombre;
                this.edad = aux.edad;
                this.username = aux.username;
                this.apellidos = aux.apellidos;
                this.email = aux.email;
                this.password = aux.password;
                this.calle = aux.calle;
                this.pueblo = aux.pueblo;
                this.provincia = aux.provincia;
                this.codigo_postal = aux.codigo_postal;
                this.telefono = aux.telefono;
                update = usu.updateUsuario(this);
            }
            return update;
        }

        public bool deleteUsuario()
        {
            CADUsuario usu = new CADUsuario();
            bool read = false;
            if (usu.readUsuario(this))
            {
                read = usu.deleteUsuario(this);
            }
            return read;
        }

        public bool logIn()
        {
            ENUsuario en = new ENUsuario();
            CADUsuario usu = new CADUsuario();
            en.username = this.username;
            bool read = false;
            if (usu.readUsuario(en))
            {
                if (en.password == this.password)
                {
                    read = true;
                }
            }
            return read;
        }

        public bool readUsuario()
        {
            CADUsuario cad = new CADUsuario();
            return cad.readUsuario(this);
        }

        public DataSet profileUsuario()
        {
            DataSet a = new DataSet();
            CADUsuario usu = new CADUsuario();
            if (usu.readUsuario(this))
            {
                a = usu.profileUsuario(this);
            }

            return a;
        }

        // Método que dice si un usuario es administrador o no
        public bool isAdminUsuario()
        {
            CADUsuario usu = new CADUsuario();
            bool isAdmin = false;
            if (usu.readUsuario(this))
            {
                if (this.admin == true) {
                    isAdmin = true;
                }
            }
            return isAdmin;
        }
    }
}
