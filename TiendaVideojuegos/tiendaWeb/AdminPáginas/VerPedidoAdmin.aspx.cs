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

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Comprobamos que el usuario esté registrado que sea administrador
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

            // Recogemos el id del pedido para mostrarlo como título de página
            titulo.Text = "Pedido nº " + ped.id + " de " + ped.id_usuario;

            // Mostramos el total del carrito
            total.Text = "Total: " + ped.importe_total + "€";

            d = lped.listaLineasPedido(ped);

            // Rellenamos el ListView
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

        /// <summary>
        /// Método para mostrar la imagen y nombre de producto correspondiente a cada línea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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