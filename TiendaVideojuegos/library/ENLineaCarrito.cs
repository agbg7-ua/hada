using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace library
{
     class ENLineaCarrito
    {
        private int _id_carrito;
        public int id_carrito {
            get { return _id_carrito; }
            set { _id_carrito = value; }
        }

        private int _id_linea;
        public int id_linea
        {
            get { return _id_linea; }
            set { _id_linea = value; }
        }
        private int _id_producto;
        public int id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        private int _cantidad;
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private float _importe;
        public float importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        private DateTime _fecha;
        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public ENLineaCarrito()
        {
            this.id_carrito = 0;
            this.id_linea = 0;
            this.id_producto = 0;
            this.cantidad = 0;
            this.importe = 0;
            this.fecha = DateTime.Now;
           
        }

        public ENLineaCarrito(int id_carrito,int id_linea, int id_producto, int cantidad, float importe,DateTime fecha)
        {
            this.id_carrito = id_carrito;
            this.id_linea = id_linea;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.importe = importe;
            this.fecha = fecha;
        }

        public ENLineaCarrito(ENLineaCarrito c)
        {
            this.id_carrito = c.id_carrito;
            this.id_linea = c.id_linea;
            this.id_producto = c.id_producto;
            this.cantidad = c.cantidad;
            this.importe = c.importe;
            this.fecha = c.fecha;
        }


        public bool createLineaCarrito()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.createLineaCarrito(this);
        }

        public bool updateLineaCarrito()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.updateLineaCarrito(this);
        }

        
        public bool deleteLineaCarrito()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return true;
        }
        
<<<<<<< HEAD
=======


>>>>>>> Y8317372B

        public ENLineaCarrito selectLineaCarrito(int id)
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.selectLineaCarrito(id);
        }

       public DataSet showLineaCarrito()
        {
<<<<<<< HEAD
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.ListaLineaCarritos();
        }

=======
            CADLineaCarrito c = new CADLineaCarrito();
            DataSet a = c.showLineaCarrito();
            return a;
        }

        public DataSet showLineaCarritoByCarrito(int carrito)
        {
            CADLineaCarrito c = new CADLineaCarrito();
            DataSet a = c.showLineaCarritoByCarrito(carrito);
            return a;

        }

        /*public List<ENLineaCarrito> listLineaCarritos()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.ListaLineaCarritos();
        }

>>>>>>> Y8317372B
        /*
        public List<ENLineaCarrito> listLineaCarritosByCarrito(int id_carrito)
        {
            CADLineaCarrito cad = new CADLineaCarrito();
<<<<<<< HEAD
            return cad.listLineaCarritosByCarrito(id_carrito);
        }
        
        */
=======

        }
     



        }
        
        */

>>>>>>> Y8317372B


    }
}
