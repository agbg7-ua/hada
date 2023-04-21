using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENCategoriaProducto
    {
        // Todos las variables con respaldo
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

        // Constructor vacío
        public ENCategoriaProducto() { 
        
        }

        // Constructor sobrecargado
        public ENCategoriaProducto(string nombre, string descripcion, string imagen) 
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        // Método para crear una categoría de producto
        public bool createCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();

            // Comprobamos que existe la categoría
            if (c.readCategoriaProducto(this) != true)
            { 
                return c.createCategoriaProducto(this);
            }

            return false;
        }

        // Método que lee una categoría de producto -> si existe un producto determinado
        public bool readCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();
            return c.readCategoriaProducto(this);
        }

        // Método para actualizar una categoría de producto
        public bool updateCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();

            string name = this.nombre;
            string description = this.descripcion;
            string image = this.imagen;

            // Comprobamos que existe la categoría
            if (c.readCategoriaProducto(this) == true)
            { 
                this.nombre = name;
                this.descripcion = description;
                this.imagen = image;
                return c.updateCategoriaProducto(this);
            }

            return false;
        }

        // Método para borrar una categría de producto
        public bool deleteCategoriaProducto()
        {
            CADCategoriaProducto c = new CADCategoriaProducto();

            // Comprobamos que existe la categoría
            if (c.readCategoriaProducto(this) == true)
            { 
                return c.deleteCategoriaProducto(this);
            }

            return false;
        }
    }
}
