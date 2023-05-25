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
    public partial class SobreNosotros : System.Web.UI.Page
    {
        ENLineaPedido lineaPedido = new ENLineaPedido();
        DataTable d = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            d = lineaPedido.top10Productos();
            Chart1.DataSource = d;
            Chart1.Series[0].Points.DataBind(d.DefaultView, d.Columns[0].ColumnName, d.Columns[1].ColumnName, null);
        }
    }
}