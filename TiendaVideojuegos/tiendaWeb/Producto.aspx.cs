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
    public partial class Producto : System.Web.UI.Page
    {
        ENProducto en = new ENProducto();
        DataSet d = new DataSet();
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

            d = en.showProducto();

            if (d.Tables[0].Rows.Count > 0)
            {
                ListView1.DataSource = d;
                ListView1.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        protected void Buttons(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                LinkButton guardar = (LinkButton)dataItem.FindControl("carrito");
                LinkButton registro = (LinkButton)dataItem.FindControl("registrarse");

                if (Session["username"] != null)
                {
                    guardar.Visible = true;
                    registro.Visible = false;
                }
                else
                {
                    guardar.Visible = false;
                    registro.Visible = true;
                }
            }
        }

        protected void button_carrito_OnClientClick(object sender, EventArgs e) 
        {
            
        }

        protected void button_registro_OnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }
    }
}