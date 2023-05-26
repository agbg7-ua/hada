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
    public class ENLineaCarrito
    {

        private int _id_carrito;
        public int id_carrito
        {
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

        public ENLineaCarrito(int id_carrito, int id_linea, int id_producto, int cantidad, float importe, DateTime fecha)
        {
            this.id_carrito = id_carrito;
            this.id_linea = id_linea;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.importe = importe;
            this.fecha = fecha;
        }

        public bool createLineaCarrito()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            ENCarrito en = new ENCarrito();
            en.id = this.id_carrito;

            if (cad.readLineaCarrito(this) != true && en.readCarrito() == true)
            {
                return cad.createLineaCarrito(this);
            }

            return false;
        }

        public bool readLineaCarrito()
        {
            CADLineaCarrito c = new CADLineaCarrito();
            return c.readLineaCarrito(this);
        }

        public DataSet updateLineaCarrito(int i)
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            DataSet a = new DataSet();
            ENLineaCarrito en = new ENLineaCarrito();

            en.id_producto = this.id_producto;
            en.cantidad = this.cantidad;
            en.importe = this.importe;
            en.fecha = this.fecha;

            if (cad.readLineaCarrito(this) == true)
            {
                this.id_producto = en.id_producto;
                this.cantidad = en.cantidad;
                this.importe = en.importe;
                this.fecha = en.fecha;
                a = cad.updateLineaCarrito(this, i);
            }

            return a;
        }


        public bool deleteLineaCarrito()
        {
            CADLineaCarrito cad = new CADLineaCarrito();

            if (cad.readLineaCarrito(this))
            {
                return cad.deleteLineaCarrito(this);
            }

            return false;
        }

        public bool vaciarCarrito(ENCarrito en)
        {
            CADLineaCarrito c = new CADLineaCarrito();

            if (en.readCarrito() == true)
            {
                return c.vaciarCarrito(en);
            }

            return false;
        }

        public DataSet showLineasCarritoByCarrito(ENCarrito en)
        {
            CADLineaCarrito c = new CADLineaCarrito();
            DataSet a = new DataSet();

            if (en.readCarrito() == true)
            {
                a = c.showLineasCarritoByCarrito(en);
            }

            return a;
        }

        public bool deleteByProducto(ENProducto en)
        {
            CADLineaCarrito lcar = new CADLineaCarrito();
            return lcar.deleteByProducto(en);
        }
    }
}