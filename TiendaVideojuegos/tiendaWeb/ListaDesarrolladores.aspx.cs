using library;
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


            if (!IsPostBack)
            {
                ENDesarrollador en = new ENDesarrollador();
                try
                {


                    List<ENDesarrollador> list = new List<ENDesarrollador>();
                    list = en.obtener_todos();

                        


                    ListView1.DataSource = list;
                    ListView1.DataBind();

                    if (list.Count == 0)
                    {
                        Label_vacio.Visible = true;
                    }

                    List<string> paises = new List<string>();
                    paises = en.obtener_paises();
                    paises.Add("Seleccionar Pais de origen");
                    DropDownList1.DataSource = paises;
                    DropDownList1.DataBind();
                    DropDownList1.Text = "Seleccionar Pais de origen";
                }
                catch (Exception ex)
                {
                    Label_error.Text = ex.Message;
                }



            }

        }


        /// <summary>
        /// Guarda el id del Desarrollador seleccionado en un variable Session y redirige a la página de Desarrollador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void test(object sender, EventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            string nombre = b.CommandArgument;
            Session["desarrollador"] = nombre;
            // redirect with the name as parameter to the next page
            Response.Redirect("Desarrollador.aspx");
        }

        /// <summary>
        /// Aplica la busqueda de Desarrolladores segun los parametros introducidos en los controladores de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_buscar_Click(object sender, EventArgs e)
        {
            ENDesarrollador en = new ENDesarrollador();

            if (TextBox1.Text != "")
            {
                en.nombre = TextBox1.Text;
            }
            else
            {
                en.nombre = "";
            }
            if (TextBox_Date.Text != "")
            {
                en.fecha_creacion = Convert.ToDateTime(TextBox_Date.Text);
            }
            else
            {
                en.fecha_creacion = DateTime.MinValue;
            }
            if (DropDownList1.Text != "Seleccionar Pais de origen")
            {
                en.origen = DropDownList1.Text;
            }
            else
            {
                en.origen = "";
            }


            try
            {
                List<ENDesarrollador> list = new List<ENDesarrollador>();
                list = en.filtrar();
                ListView1.DataSource = list;
                ListView1.DataBind();
            }
            catch (Exception ex)
            {
                Label_error.Text = ex.Message;
            }

        }

        /// <summary>
        /// Limpia los controladores de la página y muestra todos los Desarrolladores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            DropDownList1.Text = "Seleccionar Pais de origen";
            TextBox1.Text = "";
            TextBox_Date.Text = "";

            try
            {
                ENDesarrollador en = new ENDesarrollador();
                List<ENDesarrollador> list = new List<ENDesarrollador>();
                list = en.obtener_todos();
                ListView1.DataSource = list;
                ListView1.DataBind();
            }
            catch (Exception ex)
            {
                Label_error.Text = ex.Message;
            }
        }
    }
}