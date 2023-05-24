using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;
//CREATE TABLE[dbo].[Desarrollador] (
//    [id]            INT IDENTITY(1, 1) NOT NULL,
//    [nombre] 		VARCHAR (30)  NOT NULL,
//    [descripcion] 	TEXT          NOT NULL,
//    [origen]      	VARCHAR (25)  NOT NULL,
//    [fecha_creacion]    DATE          NOT NULL,
//    [web]      		VARCHAR (50)  NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC)
//);

namespace library
{
    public class ENDesarrollador
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _origen;
        private DateTime _fecha_creacion;
        private string _web;
        private string _imagen;
        private bool _borrado;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string origen
        {
            get { return _origen; }
            set { _origen = value; }
        }
        public DateTime fecha_creacion
        {
            get { return _fecha_creacion; }
            set { _fecha_creacion = value; }
        }
        public string web
        {
            get { return _web; }
            set { _web = value; }
        }

        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        public bool borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public ENDesarrollador()
        {
            this.id = 0;
            this.nombre = "";
            this.descripcion = "";
            this.origen = "";
            this.fecha_creacion = DateTime.Now;
            this.web = "";
        }

        public ENDesarrollador(int id, string nombre, string descripcion, string origen, DateTime fecha_creacion, string web, bool borrado)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.origen = origen;
            this.fecha_creacion = fecha_creacion;
            this.web = web;
            this.borrado = borrado;
        }

        public ENDesarrollador(ENDesarrollador d)
        {
            this.id = d.id;
            this.nombre = d.nombre;
            this.descripcion = d.descripcion;
            this.origen = d.origen;
            this.fecha_creacion = d.fecha_creacion;
            this.web = d.web;
            this.borrado = d.borrado;
        }


        public bool insertar()
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.insertar(this);
        }

        public bool modificar()
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.modificar(this);
        }

        public bool eliminar()
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.eliminar(this);
        }

        public ENDesarrollador obtener_by_id(int id)
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.obtener_by_id(id);
        }

        public List<ENDesarrollador> obtener_todos()
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.obtener_todos();
        }

        public ENDesarrollador obtener_by_nombre(string nombre)
        {
            CADDesarrollador cad = new CADDesarrollador();
            return cad.obtener_by_nombre(nombre);
        }

        public DataSet getDesarrollador()
        {
            CADDesarrollador c = new CADDesarrollador();
            DataSet a = c.getDesarrollador();
            return a;
        }
    }
}
