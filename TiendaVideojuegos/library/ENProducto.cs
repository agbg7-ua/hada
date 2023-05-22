using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library
{
    public class ENProducto
    {
        // Todos las variables con respaldo
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _id_categoria;
        public int id_categoria
        {
            get { return _id_categoria; }
            set { _id_categoria = value; }
        }

        private int _id_desarrollador;
        public int id_desarrollador
        {
            get { return _id_desarrollador; }
            set { _id_desarrollador = value; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private float _pvp;
        public float pvp
        {
            get { return _pvp; }
            set { _pvp = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private DateTime _fecha_salida;
        public DateTime fecha_salida
        {
            get { return _fecha_salida; }
            set { _fecha_salida = value; }
        }

        private int _clasificacion;
        public int clasificacion
        {
            get { return _clasificacion; }
            set { _clasificacion = value; }
        }

        private string _imagen;
        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        private bool _mostrar;
        public bool mostrar
        {
            get { return _mostrar; }
            set { _mostrar = value; }
        }

        // Constructor vacío
        public ENProducto() { 
        
        }

        // Constructor sobrecargado
        public ENProducto(int id_categoria, int id_desarrollador, string nombre, float pvp, string descripcion, DateTime fecha_salida, int clasificacion, string imagen, bool mostrar) 
        {
            this.id_categoria = id_categoria;
            this.id_desarrollador = id_desarrollador;
            this.nombre = nombre;
            this.pvp = pvp;
            this.descripcion = descripcion;
            this.fecha_salida = fecha_salida;
            this.clasificacion = clasificacion;
            this.imagen = imagen;
            this.mostrar = mostrar;
        }

        // Método para crear un producto
        public bool createProducto() 
        {
            CADProducto c = new CADProducto();
            ENCategoriaProducto en = new ENCategoriaProducto();
            en.id = this.id_categoria;

            // Comprobamos que no exista un producto con ese nombre y que la categoría de producto exista
            if (c.readByNameProducto(this) != true && en.readCategoriaProducto() == true)
            {
                return c.createProducto(this);
            }

            return false;
        }

        // Método que lee un producto -> si existe un producto determinado
        public bool readProducto()
        {
            CADProducto c = new CADProducto();
            return c.readProducto(this);
        }

        // Método que lee un producto por su nombre -> nombre es UNIQUE por lo que comprobamos si ya existe un producto con dicho nombre
        public bool readByNameProducto()
        {
            CADProducto c = new CADProducto();
            return c.readByNameProducto(this);
        }

        // Método para enseñar un producto
        public DataSet showProducto() 
        {
            CADProducto c = new CADProducto();
            DataSet a = c.showProducto(this);
            return a;
        }

        // Método para actualizar un producto
        public bool updateProducto()
        {
            CADProducto c = new CADProducto();
            ENProducto en = new ENProducto();
            ENCategoriaProducto cat = new ENCategoriaProducto();

            en.id = this.id;

            if (en.readProducto())
            {
                cat.id = this.id_categoria;

                if (cat.readCategoriaProducto())
                {
                    return c.updateProducto(this);
                }
            }

            return false;
        }

        // Método para borrar un producto
        public bool deleteProducto()
        {
            bool delete = false;
            CADProducto c = new CADProducto();

            // Comprobamos que existe el producto
            if (c.readProducto(this) == true)
            {
                delete = c.deleteProducto(this);
            }
    
            return delete;
        }

        // Método para enseñar todos los productos
        public DataSet showAllProducto() 
        {
            CADProducto c = new CADProducto();
            DataSet a = c.showAllProducto();
            return a;
        }

        public DataSet showAllProductoAdmin()
        {
            CADProducto c = new CADProducto();
            DataSet a = c.showAllProductoAdmin();
            return a;
        }

        // ---------------------------------------------------------------------- 
        /*
         * Ordenar Productos de una Categoría
        */
        // ----------------------------------------------------------------------

        // Método que enseña por nombre en orden ascendiente los productos
        public DataSet showOrderByNameASCProducto(ENCategoriaProducto en)
        {
            DataSet a = new DataSet();

            // Comprobamos que existe la categoría de producto
            if (en.readCategoriaProducto() == true) {
                CADProducto c = new CADProducto();
                a = c.showOrderByNameASCProducto(en);
            }

            return a;
        }

        // Método que enseña por nombre en orden descendiente los productos
        public DataSet showOrderByNameDESCProducto(ENCategoriaProducto en)
        {
            DataSet a = new DataSet();

            // Comprobamos que existe la categoría de producto
            if (en.readCategoriaProducto() == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByNameDESCProducto(en);
            }

            return a;
        }

        // Método que enseña por precio en orden ascendiente los productos
        public DataSet showOrderByPriceASCProducto(ENCategoriaProducto en)
        {
            DataSet a = new DataSet();

            // Comprobamos que existe la categoría de producto
            if (en.readCategoriaProducto() == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByPriceASCProducto(en);
            }

            return a;
        }

        // Método que enseña por precio en orden descendiente los productos
        public DataSet showOrderByPriceDESCProducto(ENCategoriaProducto en)
        {
            DataSet a = new DataSet();

            // Comprobamos que existe la categoría de producto
            if (en.readCategoriaProducto() == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByPriceDESCProducto(en);
            }

            return a;
        }

        // ---------------------------------------------------------------------- 
        /*
         * Ordenar Productos
        */
        // ----------------------------------------------------------------------

        // Método que enseña por nombre en orden ascendiente los productos
        public DataSet showOrderByNameASCProductos()
        {
            DataSet a = new DataSet();
           
            CADProducto c = new CADProducto();
            a = c.showOrderByNameASCProductos();

            return a;
        }

        // Método que enseña por nombre en orden descendiente los productos
        public DataSet showOrderByNameDESCProductos()
        {
            DataSet a = new DataSet();

            CADProducto c = new CADProducto();
            a = c.showOrderByNameDESCProductos();

            return a;
        }

        // Método que enseña por precio en orden ascendiente los productos
        public DataSet showOrderByPriceASCProductos()
        {
            DataSet a = new DataSet();

            CADProducto c = new CADProducto();
            a = c.showOrderByPriceASCProductos();

            return a;
        }

        // Método que enseña por precio en orden descendiente los productos
        public DataSet showOrderByPriceDESCProductos()
        {
            DataSet a = new DataSet();

            CADProducto c = new CADProducto();
            a = c.showOrderByPriceDESCProductos();

            return a;
        }

        // Método que busca por nombre un producto
        public DataSet searchByNameProducto(String name)
        {
            CADProducto c = new CADProducto();
            DataSet a = c.searchByNameProducto(name);
            return a;
        }
    }
}
