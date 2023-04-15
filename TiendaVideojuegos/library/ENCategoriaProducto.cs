using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENCategoriaProducto
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _imagen;

        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        public ENCategoriaProducto()
        {
            this.nombre = "";
            this.descripcion = "";
            this.imagen = "";
        }

        public ENCategoriaProducto(string nombre, string descripcion, string imagen) 
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public bool createCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();
            if (c.readCategoriaProducto(this) != true)
            { 
                return c.createCategoriaProducto(this);
            }

            return false;
        }

        public bool readCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();
            return c.readCategoriaProducto(this);
        }

        public bool updateCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();
            ENCategoriaProducto en = new ENCategoriaProducto();

            en.nombre = this.nombre;
            en.descripcion = this.descripcion;
            en.imagen = this.imagen;

            if (c.readCategoriaProducto(this) == true)
            { 
                this.nombre = en.nombre;
                this.descripcion = en.descripcion;
                this.imagen = en.imagen;
                return c.updateCategoriaProducto(this);
            }

            return false;
        }

        public bool deleteCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();
            if (c.readCategoriaProducto(this) == true)
            { 
                return c.deleteCategoriaProducto(this);
            }

            return false;
        }
    }
}
