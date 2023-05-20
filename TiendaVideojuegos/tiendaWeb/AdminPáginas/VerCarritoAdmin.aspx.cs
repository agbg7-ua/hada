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
    public partial class VerCarritoAdmin : System.Web.UI.Page
    {
        ENLineaCarrito lcar = new ENLineaCarrito();
        ENCarrito car = new ENCarrito();
        ENUsuario usu = new ENUsuario();
        ENProducto producto = new ENProducto();

        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/Home.aspx");

                }
            }

            catchId();
            usu.readUsuario();
            car.readCarritoByUser(usu);

            total.Text = "Total: " + car.importe_total + "€";

            d = lcar.showLineasCarritoByCarrito(car);

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

        protected void catchId()
        {
            usu.username = Request.Params["idCarrito"];

            titulo.Text = "Carrito de " + usu.username;
        }

        protected void ImagenProducto(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                Image imagen1 = (Image)dataItem.FindControl("Image1");
                Label name = (Label)dataItem.FindControl("nombre");

                int idProd = Convert.ToInt32(DataBinder.Eval(dataItem.DataItem, "id_producto").ToString());

                producto.id = idProd;
                producto.readProducto();

                imagen1.ImageUrl = producto.imagen;
                name.Text = producto.nombre;
            }
        }
    }
}