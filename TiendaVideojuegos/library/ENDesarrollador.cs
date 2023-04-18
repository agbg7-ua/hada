using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
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
    internal class ENDesarrollador
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private string _origen;
        private DateTime _fecha_creacion;
        private string _web;

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string origen { get; set; }
        public DateTime fecha_creacion { get; set; }
        public string web { get; set; }
           
        public ENDesarrollador()
        {
            this.id = 0;
            this.nombre = "";
            this.descripcion = "";
            this.origen = "";
            this.fecha_creacion = DateTime.Now;
            this.web = "";
        }

        public ENDesarrollador(int id, string nombre, string descripcion, string origen, DateTime fecha_creacion, string web)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.origen = origen;
            this.fecha_creacion = fecha_creacion;
            this.web = web;
        }

        public ENDesarrollador(ENDesarrollador d)
        {
            this.id = d.id;
            this.nombre = d.nombre;
            this.descripcion = d.descripcion;
            this.origen = d.origen;
            this.fecha_creacion = d.fecha_creacion;
            this.web = d.web;
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




    }
}
