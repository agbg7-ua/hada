using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library
{
    class ENProducto
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

        public ENProducto() { 
        
        }

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

        public bool createProducto() 
        {
            CADProducto c = new CADProducto();
            ENCategoriaProducto en = new ENCategoriaProducto();
            en.id = this.id_categoria;

            if (c.readByNameProducto(this) != true && en.readCategoriaProducto() == true)
            {
                return c.createProducto(this);
            }

            return false;
        }

        public bool readProducto()
        {
            CADProducto c = new CADProducto();
            return c.readProducto(this);
        }

        public bool readByNameProducto()
        {
            CADProducto c = new CADProducto();
            return c.readByNameProducto(this);
        }

        public DataSet showProducto() 
        {
            CADProducto c = new CADProducto();
            DataSet a = c.showProducto(this);
            return a;
        }

        public DataSet updateProducto(int i)
        {
            DataSet a = new DataSet();
            CADProducto c = new CADProducto();
            ENProducto en = new ENProducto();
            ENCategoriaProducto cat = new ENCategoriaProducto();

            en.id_categoria = this.id_categoria;
            en.id_desarrollador = this.id_desarrollador;
            en.nombre = this.nombre;
            en.pvp = this.pvp;
            en.descripcion = this.descripcion;
            en.fecha_salida = this.fecha_salida;
            en.clasificacion = this.clasificacion;
            en.imagen = this.imagen;
            en.mostrar = this.mostrar;

            cat.id = this.id_categoria;

            if (c.readProducto(this) == true && cat.readCategoriaProducto() == true) {
                this.id_categoria = en.id_categoria;
                this.id_desarrollador = en.id_desarrollador;
                this.nombre = en.nombre;
                this.pvp = en.pvp;
                this.descripcion = en.descripcion;
                this.fecha_salida = en.fecha_salida;
                this.clasificacion = en.clasificacion;
                this.imagen = en.imagen;
                this.mostrar = en.mostrar;
                a = c.updateProducto(this, i);
            }
            
            return a;
        }

        public DataSet deleteProducto(int i)
        {
            DataSet a = new DataSet();
            CADProducto c = new CADProducto();

            if (c.readProducto(this) == true)
            {
                a = c.deleteProducto(this, i);
            }
    
            return a;
        }

        public DataSet showAllProducto() 
        {
            CADProducto c = new CADProducto();
            DataSet a = c.showAllProducto();
            return a;
        }

        public DataSet showOrderByNameASCProducto(ENCategoriaProducto en)
        {
            bool exist = false;
            DataSet a = new DataSet();
            exist = en.readCategoriaProducto();

            if (exist == true) {
                CADProducto c = new CADProducto();
                a = c.showOrderByNameASCProducto(en);
            }

            return a;
        }

        public DataSet showOrderByNameDESCProducto(ENCategoriaProducto en)
        {
            bool exist = false;
            DataSet a = new DataSet();
            exist = en.readCategoriaProducto();

            if (exist == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByNameDESCProducto(en);
            }

            return a;
        }

        public DataSet showOrderByPriceASCProducto(ENCategoriaProducto en)
        {
            bool exist = false;
            DataSet a = new DataSet();
            exist = en.readCategoriaProducto();

            if (exist == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByPriceASCProducto(en);
            }

            return a;
        }

        public DataSet showOrderByPriceDESCProducto(ENCategoriaProducto en)
        {
            bool exist = false;
            DataSet a = new DataSet();
            exist = en.readCategoriaProducto();

            if (exist == true)
            {
                CADProducto c = new CADProducto();
                a = c.showOrderByPriceDESCProducto(en);
            }

            return a;
        }

        public DataSet searchByNameProducto(String name)
        {
            CADProducto c = new CADProducto();
            DataSet a = c.searchByNameProducto(name);
            return a;
        }
    }
}
