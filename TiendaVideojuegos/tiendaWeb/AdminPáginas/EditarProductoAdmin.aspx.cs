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
    public partial class EditarProductoAdmin : System.Web.UI.Page
    {
        ENProducto en = new ENProducto();
        DataSet d = new DataSet();
        string idProd;

        protected void Page_Load(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

            d = en.showProducto();

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

        protected void Clasificacion(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                DropDownList clas = (DropDownList)dataItem.FindControl("clasificacion");

                en.id = Convert.ToInt32(Request.Params["idProd"]);
                en.readProducto();

                if (en.clasificacion == 2)
                {
                    clas.SelectedValue = "2";
                }
                else if (en.clasificacion == 3)
                {
                    clas.SelectedValue = "3";
                }
                else if (en.clasificacion == 4)
                {
                    clas.SelectedValue = "4";
                }
                else if (en.clasificacion == 5)
                {
                    clas.SelectedValue = "5";
                }
                else
                {
                    clas.SelectedValue = "1";
                }
            }
        }

        protected void clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("ProductoAdmin.aspx");
        }

        protected void ButtonGuardar(object sender, EventArgs e)
        {

                int i = Convert.ToInt32(Request.Params["idProd"]);
                TextBox name = (TextBox)FindControl("nombre");
                TextBox price = (TextBox)FindControl("precio");
                TextBox date = (TextBox)FindControl("fecha");

                en.nombre = name.Text;
                en.pvp = float.Parse(price.Text);
                en.fecha_salida = DateTime.Parse(date.Text);
                en.updateProducto(i);
                Response.Redirect("ProductoAdmin.aspx");
            
        }
    }
}