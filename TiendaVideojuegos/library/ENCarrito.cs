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
            //Constructor sin parametros
            this.id_usuario = "";
            this.importe_total = 0;
        }

        public ENCarrito(int id, string id_usuario, float importe_total)
        {
            //Constructor con parametros
            this.id_usuario = id_usuario;
            this.importe_total = importe_total;
        }

        public bool createCarrito()
        {
            //Crear un carrito
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
            //Mostrar los datos del carrito
            CADCarrito c = new CADCarrito();
            DataSet a = c.showCarrito(this);
            return a;
        }

     
        public bool updateCarrito()
        {
            //Actualizar el carrito
            CADCarrito cad = new CADCarrito();

            if (cad.readCarrito(this))
            {
                return cad.updateCarrito(this);
            }

            return false;
        }

        public bool readCarrito()
        {
            //Leer los datos del carrito
            CADCarrito c = new CADCarrito();
            return c.readCarrito(this);
        }

        public bool readCarritoByUser(ENUsuario en)
        {
            //Leer los datos del carrito por usuario
            CADCarrito c = new CADCarrito();
            return c.readCarritoByUser(this, en);
        }


        public DataSet deleteCarrito(int Id)

        {
            //Eliminar el carrito
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
            //Mostrar los datos del carrito por usuario
            DataSet a = new DataSet();

            if (en.readUsuario() == true)
            {
                CADCarrito c = new CADCarrito();
                a = c.showCarritoByUser(en);
            }

            return a;
        }

        // Actualizar importe de carrito
        // Mostrar todos los carritos
        public DataSet listarCarritos()
        {
            //Listar todos los carritos 
            CADCarrito c = new CADCarrito();
            DataSet a = c.listarCarritos();
            return a;
        }
    }
}
