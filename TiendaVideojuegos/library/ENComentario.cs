using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;

namespace library
{
    class ENComentario
    {
        private int _id_producto;
        private int _id;
        private string _id_usuario;
        private DateTime _date;
        private string _text;
        private int _valoracion;


        public int id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        public int valoracion {
            get { return _valoracion; }
            set { _valoracion = value; }
        }

        public ENComentario()
        {
            this.id_producto = 0;
            this.id = 0;
            this.id_usuario = "";
            this.date = DateTime.Now;
            this.text = "";
            this.valoracion = 0;
        }
        public ENComentario(int id_producto,int id, string id_usuario,DateTime date, string text, int valoracion)
        {
            this.id_producto = id_producto;
            this.id = id;
            this.id_usuario = id_usuario;
            this.date = date;
            this.text = text;
            this.valoracion = valoracion;
        }
        public ENComentario(ENComentario coment) {
            this.id_producto = coment.id_producto;
            this.id = coment.id;
            this.id_usuario = coment.id_usuario;
            this.date = coment.date;
            this.text = coment.text;
            this.valoracion = coment.valoracion;
        }
        public bool createComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.createComentario(this);
        }
        public bool updateComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.updateComentario(this);
        }
        public bool deleteComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.deleteComentario(this);
        }
        public bool showComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.showComentario(this);
        }
        public bool readComentario()
        {
            CADComentario cad = new CADComentario();
            return cad.readComentario(this);
        }
        public ENComentario filterProducto(int producto)
        {
            CADComentario cad = new CADComentario();
            return cad.filterProducto(producto);
        }
        public ENComentario filterValoracion(int valoracion)
        {
            CADComentario cad = new CADComentario();
            return cad.filterValoracion(valoracion);
        }
        public ENComentario filterFecha(DateTime fecha)
        {
            CADComentario cad = new CADComentario();
            return cad.filterFecha(fecha);
        }


    }
}
