using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace tiendaWeb
{
    public class Item2
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Pais { get; set; }
        public string ImagenURL { get; set; }
    }
    public partial class ListaDesarrolladores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            List<Item2> list = new List<Item2>();
            list.Add(new Item2() { Nombre = "Bungie", Fecha = DateTime.Now.ToString().Split(' ')[0], Pais="Alemania" , ImagenURL="Imagenes/uno.png"});
            list.Add(new Item2() { Nombre = "Anapurna ", Fecha = DateTime.Now.AddDays(700).ToString().Split(' ')[0], Pais = "EEUU", ImagenURL = "Imagenes/ana.png"});
            list.Add(new Item2() { Nombre = "Desarrolladora 2 ", Fecha = DateTime.Now.AddDays(700).ToString().Split(' ')[0], Pais = "EEUU", ImagenURL = "Imagenes/sinimagen.jpeg" });
            list.Add(new Item2() { Nombre = "Bungie", Fecha = DateTime.Now.ToString().Split(' ')[0], Pais = "Alemania", ImagenURL = "Imagenes/uno.png" });
            list.Add(new Item2() { Nombre = "Anapurna ", Fecha = DateTime.Now.AddDays(700).ToString().Split(' ')[0], Pais = "EEUU", ImagenURL = "Imagenes/ana.png" });
            list.Add(new Item2() { Nombre = "Desarrolladora 2 ", Fecha = DateTime.Now.AddDays(700).ToString().Split(' ')[0], Pais = "EEUU", ImagenURL = "Imagenes/sinimagen.jpeg" });


            ListView1.DataSource = list;
            ListView1.DataBind();
        }
    }
}