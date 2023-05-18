using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library
{
    public class ENPedido
    {
        private int _id;
        private string _id_usuario;
        private DateTime _fecha;
        private float _importe_total;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string id_usuario
        {
            get { return _id_usuario; }
            set
            {
                _id_usuario = value;
            }
        }
        public DateTime fecha
        {
            get { return _fecha; }
            set
            {
                _fecha = value;
            }
        }
        public float importe_total
        {
            get { return _importe_total; }
            set
            {
                _importe_total = value;
            }
        }

        // Constructor por defecto
        public ENPedido()
        {
            this.id = 0;
            this.id_usuario = "";
            this.fecha = new DateTime();
            this.importe_total = 0;
        }

        //Constructor sobrecargado
        public ENPedido(int id, string id_usuario, DateTime fecha, float importe_total)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.fecha = fecha;
            this.importe_total = importe_total;
        }
        // Crear Pedido
        public bool createPedido()
        {
            bool res = false;
            CADPedido c = new CADPedido();
            if (!c.readPedido(this))
            {
                if (c.createPedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        // Leer Pedido
        public bool readPedido()
        {
            bool res = false;
            CADPedido c = new CADPedido();
            if (c.readPedido(this))
            {
                res = true;
            }
            return res;
        }
        //Actualizar Pedido
        public bool updatePedido()
        {
            bool res = false;
            CADPedido c = new CADPedido();
            if (c.readPedido(this))
            {
                if (c.updatePedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        //Borrar Pedido
        public bool deletePedido()
        {
            bool res = false;
            CADPedido c = new CADPedido();
            if (c.readPedido(this))
            {
                if (c.deletePedido(this))
                {
                    res = true;
                }
            }
            return res;
        }
        //Lista todos los Pedidos
        public DataSet listarPedidos()
        {
            CADPedido c = new CADPedido();
            DataSet a = c.listarPedidos();
            return a;
        }
        // Listar Pedidos importe_total ASCENDENTE -> de un mismo usuario
        public DataSet listarPedidosImporteAsc(ENUsuario en)
        {
            DataSet a = new DataSet();

            if (en.readUsuario() == true)
            {
                CADPedido c = new CADPedido();
                a = c.listarPedidosImporteAsc(en);
            }

            return a;
        }
        // Listar Pedidos importe_total DESCENDENTE -> de un mismo usuario
        public DataSet listarPedidosImporteDesc(ENUsuario en)
        {
            DataSet a = new DataSet();

            if (en.readUsuario() == true)
            {
                CADPedido c = new CADPedido();
                a = c.listarPedidosImporteDesc(en);
            }

            return a;
        }
    }
}