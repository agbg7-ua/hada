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
    public class ENCarrito
    {
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
            this.id_usuario = "";
            this.importe_total = 0;
        }

        public ENCarrito(int id, string id_usuario, float importe_total)
        {
            this.id_usuario = id_usuario;
            this.importe_total = importe_total;
        }

        public bool createCarrito()
        {
            CADCarrito cad = new CADCarrito();
            ENUsuario usuario = new ENUsuario();

            if (cad.readCarrito(this) != true)
            {
                return cad.createCarrito(this);
            }

            return false;
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
            ENCarrito en = new ENCarrito();

            en.id_usuario = this.id_usuario;
            en.importe_total = this.importe_total;

            if (cad.readCarrito(this)) 
            {
                this.id_usuario = en.id_usuario;
                this.importe_total = en.importe_total;
                d = cad.updateCarrito(this, Id);
            }

            return d;
        }

        //read 
        public bool readCarrito()
        {
            CADCarrito c = new CADCarrito();
            return c.readCarrito(this);
        }

        public bool readCarritoByUser(ENUsuario en)
        {
            CADCarrito c = new CADCarrito();
            return c.readCarritoByUser(this, en);
        }


        public DataSet deleteCarrito(int Id)

        {
            CADCarrito cad = new CADCarrito();
            DataSet d = cad.deleteCarrito(this, Id);

            if (cad.readCarrito(this))
            {
                d = cad.deleteCarrito(this, Id);
            }

            return d;
        }

        public DataSet showCarritoByUser(ENUsuario en)
        {
            DataSet a = new DataSet();

            if (en.readUsuario() == true)
            {
                CADCarrito c = new CADCarrito();
                a = c.showCarritoByUser(en);
            }

            return a;
        }
    }
}
