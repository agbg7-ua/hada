using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string contraseña { get; set; }
        public int edad { get; set; }
        public string calle { get; set; }
        public string pueblo { get; set; }
        public string provincia { get; set; }
        public string codigo_postal { get; set; }
        public string telefono { get; set; }
    }
}
