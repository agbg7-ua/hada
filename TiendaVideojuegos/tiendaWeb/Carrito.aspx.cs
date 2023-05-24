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
    public partial class Carrito : System.Web.UI.Page
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

            usu.username = Session["username"].ToString();
            usu.readUsuario();
            car.readCarritoByUser(usu);

            d = lcar.showLineasCarritoByCarrito(car);

            if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
            {
                total.Text = "Total: " + car.importe_total + "€";
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
                comprar.Visible = false;
                vaciar.Visible = false;
            }
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

        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENLineaCarrito en = new ENLineaCarrito();

            LinkButton myButton = (LinkButton)sender;
            string[] arg = new string[2];
            arg = myButton.CommandArgument.ToString().Split(';');
            int il = int.Parse(arg[0]);
            int ic = int.Parse(arg[1]);

            en.id_linea = il;
            en.id_carrito = ic;

            en.deleteLineaCarrito();
            Response.Redirect("Carrito.aspx");
        }

        protected void ButtonComprar(Object sender, EventArgs e)
        {
            ENPedido ped = new ENPedido();
            DateTime hoy = DateTime.Now;

            ped.id_usuario = Session["username"].ToString();
            ped.fecha = hoy;
            ped.importe_total = car.importe_total;
            ped.createPedido();


        }

        protected void ButtonVaciar(Object sender, EventArgs e)
        {
            lcar.vaciarCarrito(car);
            Response.Redirect("Carrito.aspx");
        }
    }
}
