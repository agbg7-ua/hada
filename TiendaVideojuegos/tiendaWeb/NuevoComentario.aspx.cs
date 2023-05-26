using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Globalization;

namespace tiendaWeb
{
    public partial class NuevoComentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENComentario com = new ENComentario();
            com.id_usuario = (string)Session["Datos"];
            com.date = DateTime.Now;
            com.id = (int)Session["Datos1"];
            com.text = TextBox1.Text;
            com.valoracion = Convert.ToInt32(TextBox2.Text);

            if (com.createComentario())
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                outputMsg.Text = "Falta algún dato o alguno introducido es incorrecto";
            }
        }


    }
}