using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;

namespace library
{
     class ENLineaCarrito
    {
        private int _id_carrito;
        private int _id_linea;
        private int _id_producto;
        private int _cantidad;
        private float _importe;
        private DateTime _fecha;

        public int id_carrito { get; set; }
        public int id_linea{ get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public float importe { get; set; }
        public DateTime fecha { get; set; }

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
            return cad.deleteLineaCarrito(this);
        }

        public ENLineaCarrito selectLineaCarrito(int id)
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.selectLineaCarrito(id);
        }

        public List<ENLineaCarrito> listLineaCarritos()
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.listLineaCarritos();
        }

        public List<ENLineaCarrito> listLineaCarritosByCarrito(int id_carrito)
        {
            CADLineaCarrito cad = new CADLineaCarrito();
            return cad.listLineaCarritosByCarrito(id_carrito);
        }




    }
}
