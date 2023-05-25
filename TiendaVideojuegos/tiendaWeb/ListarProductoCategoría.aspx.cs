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
    public partial class ListarProductoCategoría : System.Web.UI.Page
    {
        ENCategoriaProducto enCat = new ENCategoriaProducto();
        ENProducto enProd = new ENProducto();
        ENUsuario usu = new ENUsuario();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                ddlTest_SelectedIndexChanged(this, e);
            }
        }
        
        // Recoger género seleccionado
        protected void catchId()
        {
            enCat.id = Convert.ToInt32(Request.Params["idCat"]);

            // Poner título específico
            enCat.readCategoriaProducto();
            titulo.Text = "Videojuegos del Género " + enCat.nombre;
        }
        
        // Dropdownlist --> opción seleccionada sobre cómo listar los Productos
        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            catchId();

            if (ddlTest.SelectedValue == "2")
            {
                d = enProd.showOrderByNameDESCProducto(enCat);
            }
            else if (ddlTest.SelectedValue == "3")
            {
                d = enProd.showOrderByPriceASCProducto(enCat);
            }
            else if (ddlTest.SelectedValue == "4")
            {
                d = enProd.showOrderByPriceDESCProducto(enCat);
            }
            else 
            {
                d = enProd.showOrderByNameASCProducto(enCat);
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
            enProd.id = id_prod;
            enProd.readProducto();

            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            // Creamos un pedido
            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = enProd.pvp;
            ped.createPedido();
            ped.lastPedido();

            // Creamos una línea de pedido
            lped.id_pedido = ped.id;
            lped.id_producto = enProd.id;
            lped.cantidad = 1;
            lped.importe = enProd.pvp;
            lped.createLineaPedido();

            // Nos redirige a la página de Pedidos
            Response.Redirect("Pedido.aspx");
        }
    }
}