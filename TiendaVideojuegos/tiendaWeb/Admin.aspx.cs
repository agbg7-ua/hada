using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace tiendaWeb
{
    public partial class Admin : System.Web.UI.Page
    {
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();

                    if (!usu.isAdminUsuario())
                    {
                        Response.Redirect("~/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Home.aspx");
                }
            }
        }

        protected void button_usuarioOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_productoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminPáginas/ProductoAdmin.aspx");
        }

        protected void button_categoriaOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminPáginas/CategoriaProductoAdmin.aspx");
        }

        protected void button_carritoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminPáginas/CarritoAdmin.aspx");
        }

        protected void button_pedidoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_desarrolladorOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminPáginas/DesarrolladorAdmin.aspx");
        }

    }
}