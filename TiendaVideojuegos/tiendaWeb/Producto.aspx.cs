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
                LinkButton comprar = (LinkButton)dataItem.FindControl("comprar");
                LinkButton registro = (LinkButton)dataItem.FindControl("registrarse");

                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                    guardar.Visible = true;
                    comprar.Visible = true;
                    registro.Visible = false;
                }
                else
                {
                    guardar.Visible = false;
                    comprar.Visible = false;
                    registro.Visible = true;
                }
            }
        }

        protected void button_carrito_OnClientClick(object sender, EventArgs e) 
        {
            ENProducto prod = new ENProducto();
            DateTime hoy = DateTime.Now;
            LinkButton myButton = (LinkButton)sender;
            int i = Convert.ToInt32(myButton.CommandArgument.ToString());
            prod.id = i;
            prod.readProducto();

            ENCarrito car = new ENCarrito();
            ENLineaCarrito lcar = new ENLineaCarrito();
            car.readCarritoByUser(usu);
            lcar.id_carrito = car.id;
            lcar.id_producto = i;
            lcar.cantidad = 1;
            lcar.fecha = hoy;
            lcar.importe = prod.pvp;
            lcar.createLineaCarrito();

            Response.Redirect("Carrito.aspx");
        }

        protected void button_comprar_OnClientClick(object sender, EventArgs e)
        {

        }

        protected void button_registro_OnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }
    }
}