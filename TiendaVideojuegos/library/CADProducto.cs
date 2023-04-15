using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library
{
    class CADProducto
    {
        private string constring;

        public CADProducto() { 
            this.constring = this.constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
    }
}
