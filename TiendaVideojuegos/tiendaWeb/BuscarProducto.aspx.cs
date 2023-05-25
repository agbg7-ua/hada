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
        ENUsuario usu = new ENUsuario();
        string name;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Recogemos lo escrito en la barra de búsqueda
            catchSearch();

            // Llamamos al EN correspondiente
            d = en.searchByNameProducto(name);

            // Rellenamos el ListView con los resultados
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

        // Recoger lo escrito en la barra de búsqueda
        protected void catchSearch()
        {
            name = Request.Params["b"];
            // Escribir en el título de la página la búsqueda realizada
            titulo.Text = "Resultados de la Búsqueda: \"" + name + "\"";
        }

        // Método que enseña el botón de comprar únicamente a alguien que haya iniciado sesión
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

        // Creamos un pedido y una línea de pedido del Producto seleccionado
        protected void ButtonComprar(Object sender, EventArgs e)
        {
            LinkButton buy = (LinkButton)sender;
            int id_prod = Convert.ToInt32(buy.CommandArgument.ToString());
            en.id = id_prod;
            en.readProducto();

            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            // Creamos un pedido
            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = en.pvp;
            ped.createPedido();
            ped.lastPedido();

            // Creamos una línea de pedido
            lped.id_pedido = ped.id;
            lped.id_producto = en.id;
            lped.cantidad = 1;
            lped.importe = en.pvp;
            lped.createLineaPedido();

            // Nos redirige a la página de Pedidos
            Response.Redirect("Pedido.aspx");
        }
    }
}