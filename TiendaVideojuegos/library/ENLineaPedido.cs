using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENLineaPedido
    {
        private int _id_pedido;
        private int _id_linea;
        private int _id_producto;
        private int _cantidad;
        private double _importe;
        public int id_pedido
        {
            get { return _id_pedido; }
            set { _id_pedido = value; }
        }
        public int id_linea
        {
            get { return id_linea; }
            set { _id_linea = value; }
        }
        public int id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public double importe
        {
            get { return importe; }
            set { _importe = value; }
        }
        public ENLineaPedido(int id_pedido, int id_linea, int id_producto, int cantidad, double importe)
        {
            this.id_pedido = id_pedido;
            this.id_linea = id_linea;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.importe = importe;
        }
        public bool createLineaPedido()
        {
            bool res = false;
            CADLineaPedido c = new CADLineaPedido();
            if (!c.readLineaPedido(this))
            {
                if (c.createLineaPedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        public bool readLineaPedido()
        {
            bool res = false;
            CADLineaPedido c = new CADLineaPedido();
            if (c.readLineaPedido(this))
            {
                res = true;
            }
            return res;
        }
        public bool updateLineaPedido()
        {
            bool res = false;
            CADLineaPedido c = new CADLineaPedido();
            if (c.readLineaPedido(this))
            {
                if (c.updateLineaPedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        public bool deleteLineaPedido()
        {
            bool res = false;
            CADLineaPedido c = new CADLineaPedido();
            if (c.readLineaPedido(this))
            {
                if (c.deleteLineaPedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        public List<ENLineaPedido> listaLineasPedido()
        {
            List<ENLineaPedido> res = new List<ENLineaPedido>();
            CADLineaPedido c = new CADLineaPedido();
            res = c.listaLineasPedido(this);
            return res;
        }
    }
}