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
    public partial class BuscarProducto : System.Web.UI.Page
    {
        ENProducto en = new ENProducto();
        DataSet d = new DataSet();
        string name;

        protected void Page_Load(object sender, EventArgs e)
        {
            catchSearch();

            d = en.searchByNameProducto(name);

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

        // Recoger género seleccionado
        protected void catchSearch()
        {
            name = Request.Params["b"];
            titulo.Text = "Resultados de la Búsqueda: \"" + name + "\"";
        }

        protected void Buttons(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                LinkButton comprar = (LinkButton)dataItem.FindControl("comprar");

                if (Session["username"] != null)
                {
                    comprar.Visible = true;
                }
                else
                {
                    comprar.Visible = false;
                }
            }
        }
    }
}