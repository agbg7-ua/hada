using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb
{
    public partial class ListarProducto : System.Web.UI.Page
    {
        ENProducto producto = new ENProducto();

        DataSet d = new DataSet();
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
            if (ddlTest.SelectedValue == "2")
            {
                d = producto.showOrderByNameDESCProductos();
            }
            else if (ddlTest.SelectedValue == "3")
            {
                d = producto.showOrderByPriceASCProductos();
            }
            else if (ddlTest.SelectedValue == "4")
            {
                d = producto.showOrderByPriceDESCProductos();
            }
            else
            {
                d = producto.showOrderByNameASCProductos();
            }

            if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
            {
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }
    }
}