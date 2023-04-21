using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;

namespace library
{
    class ENCarrito

    { 
         private int _id;
        private string _id_usuario;
        private float _importe_total;
      

        public int id { get; set; }
        public string id_usuario { get; set; }
        public float importe_total { get; set; }
    
           
        public ENCarrito()
        {
            this.id = 0;
            this.id_usuario = "";
            this.importe_total = 0;
        }

        public ENCarrito(int id, string id_usuario, float importe_total)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.importe_total = importe_total;
        }

        public ENCarrito(ENCarrito c)
        {
            this.id = c.id;
            this.id_usuario = c.id_usuario;
            this.importe_total = c.importe_total;
        }


        public bool createCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.createCarrito(this);
        }
        
        public bool showCarrito()
        {
            CADCarrito cad = new CADCarrito();
            return cad.showCarrito(this);
        }


        //metodo desconectado se devuelve en DataSet

        public DataSet updateCarrito(int Id)
        {
            CADCarrito cad = new CADCarrito();
            DataSet d = cad.updateCarrito(this,Id);
            return cad.updateCarrito(this,Id);
        }

        public DataSet deleteCarrito(int Id)
        {
            CADCarrito cad = new CADCarrito();
            DataSet d = cad.deleteCarrito(thisId)
            return cad.deleteCarrito(this, Id);
        }

        public List<ENCarrito> listCarritos()
        {
            CADCarrito cad = new CADCarrito();
            return cad.listCarritos();
        }
        public List<ENCarrito> listCarritosByUser(string idUsuario)
        {
            CADCarrito cad = new CADCarrito();
            return cad.listCarritosByUser(idUsuario);
        }


    }
}
