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
    public partial class LineaPedido : System.Web.UI.Page
    {
        ENPedido pedido = new ENPedido();
        ENProducto producto = new ENProducto();
        ENUsuario usu = new ENUsuario();
        DataSet d = new DataSet();
        ENLineaPedido elp = new ENLineaPedido();

        protected void Page_Load(object sender, EventArgs e)
        {
            pedido.id = Convert.ToInt32(Request.Params["idPed"]);
            pedido.readPedido();

            titulo.Text = "Pedido nº " + pedido.id;

            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("~/Home.aspx");
                }
            }

            d = elp.listaLineasPedido(pedido);
;
            total.Text = "Total: " + pedido.importe_total + "€";

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

        protected void ImagenProducto(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                Image imagen1 = (Image)dataItem.FindControl("Image1");
                Label name = (Label)dataItem.FindControl("nombre");

                int clas = Convert.ToInt32(DataBinder.Eval(dataItem.DataItem, "id_producto").ToString());

                producto.id = clas;
                producto.readProductoEliminado();

                imagen1.ImageUrl = producto.imagen;
                name.Text = producto.nombre;
            }
        }
    }
}