using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_buscar_OnClientClick(object sender, EventArgs e)
        {
            string cad = "BuscarProducto.aspx?b=" + tbox.Text;
            Response.Redirect(cad);
        }

        protected void button_usuarioOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void button_perfilOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("Usuario.aspx");
        }

        protected void button_carritoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

        protected void button_pedidosOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("Pedido.aspx");
        }
    }
}