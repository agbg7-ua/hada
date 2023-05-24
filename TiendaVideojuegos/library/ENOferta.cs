using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREATE TABLE[dbo].[Oferta] (
//    [id]        INT IDENTITY(1, 1) NOT NULL,
//    [oferta]      	DECIMAL (7,2)  	NULL,
//    PRIMARY KEY CLUSTERED ([id] ASC),
//    CONSTRAINT[fk_Oferta_Producto] FOREIGN KEY([id]) REFERENCES[dbo].[Producto]([id])
//);

//----------------------------------------------------------------------------------------------
//--OFERTA_HAS_PRODUCTO

//CREATE TABLE[dbo].[Oferta_has_Producto] (
//    [oferta_id]     INT NOT NULL,
//    [producto_id]      	INT  	NOT NULL,
//    PRIMARY KEY CLUSTERED ([oferta_id] ASC, [producto_id] ASC),
//    CONSTRAINT[fk_OfertaHProducto_Oferta] FOREIGN KEY([oferta_id]) REFERENCES[dbo].[Oferta]([id]),
//    CONSTRAINT[fk_OfertaHProducto_Producto] FOREIGN KEY([producto_id]) REFERENCES[dbo].[Producto]([id])
//);

namespace library
{
    public class ENOferta
    {
        private int _id;
        private decimal _oferta;
        private int _producto_id;

        public int id { 
            get { return _id; }
            set { _id = value; }
        }
        public decimal oferta { 
            get { return _oferta; }
            set { _oferta = value; }
        }
        public int producto_id {
            get { return _producto_id; }
            set { _producto_id = value; }
        }


        public ENOferta()
        {
            this.id = -1;
            this.oferta = -1;
            this.producto_id = -1;
        }

        public ENOferta(int id, decimal oferta, int producto_id)
        {
            this.id = id;
            this.oferta = oferta;
            this.producto_id = producto_id;
        }




        public ENOferta(ENOferta o)
        {
            this.id = o.id;
            this.oferta = o.oferta;
            this.producto_id = o.producto_id;
        }


        public bool insertar()
        {
            CADOferta cad = new CADOferta();
            return cad.insertar(this);
        }

        public bool borrar()
        {
            CADOferta cad = new CADOferta();
            return cad.borrar(this);
        }

        public bool modificar()
        {
            CADOferta cad = new CADOferta();
            return cad.modificar(this);
        }

        public List<ENOferta> obtener()
        {
            CADOferta cad = new CADOferta();
            return cad.obtener(this);
        }
    }
}
