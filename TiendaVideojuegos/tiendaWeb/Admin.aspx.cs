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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTest_SelectedIndexChanged(this, e);
            }
        }

        // Dropdownlist --> opción seleccionada
        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTest.SelectedValue == "1")
            {
                Response.Redirect("CategoriaProducto.aspx");
            }
            else if (ddlTest.SelectedValue == "2")
            {
                Response.Redirect("Producto.aspx");
            }
            else if (ddlTest.SelectedValue == "3")
            {
                Response.Redirect("Desarrollador.aspx");
            }
            else if (ddlTest.SelectedValue == "4")
            {
                Response.Redirect("Pedido.aspx");
            }
            else
            {
                textboxVacio.Visible = true;
                textboxVacio.Text = "Elija la opción que desee";
            }
        }
    }
}