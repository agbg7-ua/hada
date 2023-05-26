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
    public partial class ListarProducto : System.Web.UI.Page
    {
        ENProducto producto = new ENProducto();
        ENUsuario usu = new ENUsuario();
        DataSet d = new DataSet();

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTest_SelectedIndexChanged(this, e);
            }
        }

        /// <summary>
        /// Dropdownlist --> opción seleccionada sobre cómo listar los Productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTest.SelectedValue == "2")
            {
                d = producto.showOrderByNameDESCProductos();
            }
            else if (ddlTest.SelectedValue == "3")
            {
                d = producto.showOrderByPriceASCProductos();
            }
            else if (ddlTest.SelectedValue == "4")
            {
                d = producto.showOrderByPriceDESCProductos();
            }
            else
            {
                d = producto.showOrderByNameASCProductos();
            }

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
        /// Método que enseña el botón de comprar únicamente a alguien que haya iniciado sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Buttons(object sender, ListViewItemEventArgs e)
        {
            // Recorremos el ListView
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                // Buscamos el botón de comprar en el Listview
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

        /// <summary>
        /// Creamos un pedido y una línea de pedido del Producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonComprar(Object sender, EventArgs e)
        {
            LinkButton buy = (LinkButton)sender;
            int id_prod = Convert.ToInt32(buy.CommandArgument.ToString());
            producto.id = id_prod;
            producto.readProducto();

            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            // Creamos un pedido
            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = producto.pvp;
            ped.createPedido();
            ped.lastPedido();

            // Creamos una línea de pedido
            lped.id_pedido = ped.id;
            lped.id_producto = producto.id;
            lped.cantidad = 1;
            lped.importe = producto.pvp;
            lped.createLineaPedido();

            // Nos redirige a la página de Pedidos
            Response.Redirect("Pedido.aspx");
        }
    }
}