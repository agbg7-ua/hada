using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;

namespace tiendaWeb.AdminPáginas
{
    public partial class CarritoAdmin : System.Web.UI.Page
    {
        ENCarrito carrito = new ENCarrito();
        ENUsuario usu = new ENUsuario();

        DataSet d = new DataSet();

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

            d = carrito.listarCarritos();

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

        protected void ButtonVer(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("VerCarritoAdmin.aspx?idCarrito=" + i);
        }
    }
}