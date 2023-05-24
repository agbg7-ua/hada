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
    public partial class VerPedidoAdmin : System.Web.UI.Page
    {
        ENLineaPedido lped = new ENLineaPedido();
        ENPedido ped = new ENPedido();
        ENUsuario usu = new ENUsuario();
        ENProducto producto = new ENProducto();

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

            ped.id = Convert.ToInt32(Request.Params["idPedido"]);
            ped.readPedido();

            titulo.Text = "Pedido nº " + ped.id + " de " + ped.id_usuario;

            total.Text = "Total: " + ped.importe_total + "€";

            d = lped.listaLineasPedido(ped);

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
            lped.id_linea = Convert.ToInt32(Request.Params["idPedido"]);
            lped.readLineaPedido();
            ped.id = lped.id_pedido;
            ped.readPedido();

            titulo.Text = "Pedido nº " + ped.id + "de " + ped.id_usuario;
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