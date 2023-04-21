using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADComentario
    {
        public bool createComentario(ENComentario coment)
        {
            return true;
        }
        public bool updateComentario(ENComentario coment)
        {
            return true;
        }
        public bool deleteComentario(ENComentario coment)
        {
            return true;
        }
        public bool readComentario(ENComentario coment)
        {
            return true;
        }
        public bool showComentario(ENComentario coment)
        {
            return true;
        }
         public ENComentario filterProducto(int producto)
        {
            ENComentario en = new ENComentario();
            return en;
        }
         public ENComentario filterValoracion(int valoracion)
        {
            ENComentario en = new ENComentario();
            return en;
        }
         public ENComentario filterFecha(DateTime fecha)
        {
            ENComentario en = new ENComentario();
            return en;
        }

    }
}
