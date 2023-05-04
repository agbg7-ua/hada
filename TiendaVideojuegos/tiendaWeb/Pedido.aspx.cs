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
    public partial class Pedido : System.Web.UI.Page
    {
        DataTable tb = new DataTable();
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            createTable();
        }
        public void createTable()
        {
            tb.Columns.Add("ID", typeof(string));
            tb.Columns.Add("Usuario", typeof(string));
            tb.Columns.Add("Fecha", typeof(string));
            tb.Columns.Add("Importe total", typeof(string));
            dr = tb.NewRow();
            tb.Rows.Add(dr);
            DataTable.DataSource = tb;
            DataTable.DataBind();
            ViewState["table1"] = tb;
        }
        protected void addNewRow()
        {

        }

        protected System.Void ButtonID_Click()
        {

        }
    }
}