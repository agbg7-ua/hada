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
    }
}