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
        ENPedido pedido = new ENPedido();
        DataSet d = new DataSet();
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/Home.aspx");
                }
                ddlTest_SelectedIndexChanged(this, e);
            }
        }

        // Dropdownlist --> opción seleccionada
        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            usu.username = Session["username"].ToString();
            if (ddlTest.SelectedValue == "2")
            {
                d = pedido.listarPedidosImporteDesc(usu);
            }
            else
            {
                d = pedido.listarPedidosImporteAsc(usu);
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