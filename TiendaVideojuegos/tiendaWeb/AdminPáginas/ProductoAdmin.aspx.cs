using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb.AdminPáginas
{
    public partial class ProductoAdmin : System.Web.UI.Page
    {
        ENProducto producto = new ENProducto();

        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            d = producto.showAllProducto();

            if (d.Tables[0].Rows.Count > 0)
            {
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        protected void ButtonEditar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("~/Producto.aspx?idProd=" + i);
        }
    }
}