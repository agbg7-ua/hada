using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENPedido
    {
        private int _id;
        private int _id_usuario;
        private DateTime _fecha;
        private double _importe_total;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public int id_usuario
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
        public double importe_total
        {
            get { return _importe_total; }
            set
            {
                _importe_total = value;
            }
        }
        //Constructor sobrecargado
        public ENPedido(int id, int id_usuario, DateTime fecha, double importe_total)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.fecha = fecha;
            this.importe_total = importe_total;
        }
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
        public List<ENPedido> pedidosUsuario()
        {
            List<ENPedido> res = new List<ENPedido>();
            CADPedido c = new CADPedido();
            res = c.pedidosUsuario(this);
            return res;
        }
    }
}