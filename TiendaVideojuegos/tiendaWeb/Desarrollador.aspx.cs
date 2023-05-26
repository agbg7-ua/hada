using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace tiendaWeb
{

    public class Item
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
    }

    public partial class Desarrrolador : System.Web.UI.Page
    {

        // datos de ejemplo

        string nombre = "Bungie";
        string descripcion = @"
Bungie Studios és una empresa dissenyadora de videojocs fundada en 1991 sota el nom de Bungie Programari Productes Corporation per dos estudiants de la Universitat de Chicago, Alex Seropian i Jason Jones. Forma part dels estudis de videojocs de Microsoft des que aquesta empresa la va comprar en l'any 2000
            ";

        System.DateTime fecha = DateTime.Now;
        string web = "www.counter-strike.net";
        string origen = "Estados Unidos";
        string imagen = "~/Imagenes/bungie.png";

        static bool edit_mode = false;
        static bool nuevo_mode = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    string nombre = (string)Session["desarrollador"];

                    if (nombre == null)
                    {
                        Response.Redirect("~/Home.aspx");
                    }

                    ENDesarrollador en = new ENDesarrollador();
                    en.nombre = nombre;
                    en = en.obtener_by_nombre(nombre);

                    descripcion = en.descripcion;
                    fecha = en.fecha_creacion;
                    web = en.web;
                    origen = en.origen;
                    imagen = en.imagen;

                    Label_nombre.Text = nombre;
                    Label_descripcion.Text = descripcion;
                    Label_fecha.Text = fecha.ToString().Split(' ')[0];
                    Label_web.Text = web;
                    Label_origen.Text = origen;
                    Image3.ImageUrl = imagen;

                    //Label_error_info.Text = imagen;



                    List<ENProducto> juegos = new List<ENProducto>();
                    juegos = en.obtener_juegos();

                    ListView1.DataSource = juegos;
                    ListView1.DataBind();
                }
                catch (Exception ex)
                {

                    Label_error_info.Text = ex.Message;
                }
            }



        }

        /// <summary>
        /// quita todas las " ' " de un texto para que no de problemas al insertar en la base de datos
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private string adapt_texto_for_sql(string texto)
        {
            return texto.Replace("'", "''");
        }




    }
}