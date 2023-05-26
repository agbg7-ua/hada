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
        ENUsuario usu = new ENUsuario();
        ENProducto prod = new ENProducto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("~/Registro.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            prod.id = Convert.ToInt32(Request.Params["idProd"]);
            ENComentario com = new ENComentario();
            usu.username = Session["username"].ToString();

            com.id_usuario = usu.username;
            com.date = DateTime.Now;
            com.id_producto = prod.id;
            com.text = TextBox1.Text;
            com.valoracion = Convert.ToInt32(TextBox2.Text);

            if (com.createComentario())
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                outputMsg.Text = usu.username;
            }
        }
    }
}