using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using library;
using System.Data;
using System.Data.SqlClient;

namespace library
{
    class ENCarrito

    {
        /*
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }

        }


        private string _id_usuario;
        public string id_usuario
        {

            get { return _id_usuario; }
            set { _id_usuario = value; }
        }
        private float _importe_total;
        public float importe_total
        {
            get { return _importe_total; }
            set { _importe_total = value; }
        }



        public ENCarrito()
        {
            this.id = 0;
            this.id_usuario = "";
            this.importe_total = 0;
        }

        public ENCarrito(int id, string id_usuario, float importe_total)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.importe_total = importe_total;
        }

        public ENCarrito(ENCarrito c)
        {
            this.id = c.id;
            this.id_usuario = c.id_usuario;
            this.importe_total = c.importe_total;
        }


        public bool createCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.createCarrito(this);
        }

        public DataSet showCarrito()
        {
            CADCarrito c = new CADCarrito();
            DataSet a = c.showCarrito(this);
            return a;
        }


        //Update

        public DataSet updateCarrito(int Id)
        {
            CADCarrito cad = new CADCarrito();
            DataSet d = cad.updateCarrito(this, Id);
            return cad.updateCarrito(this, Id);
        }
        //read 
        public bool readCarrito()
        {
            CADCarrito c = new CADCarrito();
            return c.readCarrito(this);
        }


        public DataSet deleteCarrito(int Id)

        {
<<<<<<< HEAD
            CADCarrito cad = new CADCarrito();
            DataSet d = cad.deleteCarrito(this, Id);
            return cad.deleteCarrito(this, Id);
        }

        public List<ENCarrito> listCarritos()
        {
            CADCarrito cad = new CADCarrito();
            return cad.listCarritos();
        }
        /*
        public List<ENCarrito> listCarritosByUser(string idUsuario)
        {
            CADCarrito cad = new CADCarrito();
            return cad.listCarritosByUser(idUsuario);
        }

        
=======
            DataSet a = new DataSet();
            CADCarrito c = new CADCarrito();

            if (c.readCarrito(this) == true)
            {
                a = c.deleteCarrito(this, Id);
            }
            return a;
        }
    
        public DataSet listCarritos()
        {
            CADCarrito c = new CADCarrito();
            DataSet a = c.listCarritos();
            return a;
        }

        public DataSet listCarritosByUser(string idUsuario) {

            CADCarrito c = new CADCarrito();
            DataSet a = c.listCarritosByUser(idUsuario);
            return a;
        }
*/
    }
}
