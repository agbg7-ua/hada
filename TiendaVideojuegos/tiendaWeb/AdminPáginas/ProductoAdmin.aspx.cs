using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb.AdminPáginas
{
    public partial class ProductoAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_usuarioOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_productoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("ProductoAdmin.aspx");
        }

        protected void button_categoriaOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_carritoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_pedidoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }

        protected void button_desarrolladorOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("#");
        }
    }
}