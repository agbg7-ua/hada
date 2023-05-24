using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE[dbo].[Oferta] (
//    [id]        INT IDENTITY(1, 1) NOT NULL,
//    [oferta]      	DECIMAL (7,2)  	NULL,
//    [id_producto]      	INT  	NOT NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC),
//    CONSTRAINT[fk_Oferta_Producto] FOREIGN KEY([id_producto]) REFERENCES[dbo].[Producto]([id])
//);

namespace library
{
    public class ENOferta
    {
        private int _id;
        private float _oferta;
        private int _id_producto;

        public int id { 
            get { return _id; }
            set { _id = value; }
        }
        public float oferta { 
            get { return _oferta; }
            set { _oferta = value; }
        }
        public int id_producto {
            get { return _id_producto; }
            set { _id_producto = value; }
        }


        public ENOferta()
        {
 
        }

        public ENOferta(int id, float oferta, int id_producto)
        {
            this.id = id;
            this.oferta = oferta;
            this.id_producto = id_producto;
        }

        public bool primeraOferta(ENProducto prod)
        {
            CADOferta of = new CADOferta();
            this.id = 1;
            of.readOferta(this);
            prod.id = this.id_producto;
            prod.readProducto();
            return of.primeraOferta(this, prod);
        }

        public bool segundaOferta(ENProducto prod)
        {
            CADOferta of = new CADOferta();
            this.id = 2;
            of.readOferta(this);
            prod.id = this.id_producto;
            prod.readProducto();
            return of.segundaOferta(this, prod);
        }

        public bool terceraOferta(ENProducto prod)
        {
            CADOferta of = new CADOferta();
            this.id = 3;
            of.readOferta(this);
            prod.id = this.id_producto;
            prod.readProducto();
            return of.terceraOferta(this, prod);
        }
    }
}
