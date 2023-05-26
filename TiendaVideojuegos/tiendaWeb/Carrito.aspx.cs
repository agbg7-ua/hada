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
        //EN utilizadas
        ENLineaCarrito lcar = new ENLineaCarrito();
        ENCarrito car = new ENCarrito();
        ENUsuario usu = new ENUsuario();
        ENProducto producto = new ENProducto();

        DataSet d = new DataSet(); //DataSet para almacenar los datos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Verificar si el usuario ha iniciado sesion 
                if (Session["username"] == null)
                {
                    Response.Redirect("~/Home.aspx");

                }
            }
            //Obtener el nombre de usuario de la sesion y leer los datos del usuario
            usu.username = Session["username"].ToString();
            usu.readUsuario();
            //Leer el carrito asociado al usuario
            car.readCarritoByUser(usu);
            //Mostrar las lineas del carrito en ListView
            d = lcar.showLineasCarritoByCarrito(car);

            if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
            { 
                listView.DataSource = d;
                listView.DataBind();

                DataTable t = new DataTable();
                t = d.Tables[0];
                //Calcular el importe total sumando los importes de cada linea 
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    car.importe_total = car.importe_total + float.Parse(t.Rows[i][4].ToString());
                }
                
                total.Text = "Total: " + car.importe_total.ToString("0. ##") + "€";
            }
            else
            {
                //Si el carrito esta vacio, mostrar un mensaje y ocultar los botones de compra y vaciar carrito
                textboxVacio.Visible = true;
                comprar.Visible = false;
                vaciar.Visible = false;
            }
        }

        protected void ImagenProducto(object sender, ListViewItemEventArgs e)
        {
            //Mostrar la imagen y el nombre del producto en cada linea del carrito
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
            //Eliminar una linea del carrito al hacer clic en el boton "Borrar"
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
            //Realizar la compra de los productos en el carrito al hacer clic en el boton "Comprar" 
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            ped.id_usuario = Session["username"].ToString();
            ped.fecha = hoy;
            ped.importe_total = car.importe_total;
            ped.createPedido();
            ped.lastPedido();

            DataTable t = new DataTable();
            t = d.Tables[0];
            //Crear lineas de pedido para cada producto en el carrito
            for (int i = 0; i < t.Rows.Count; i++)
            {
                ENProducto prod = new ENProducto();
                lped.id_pedido = ped.id;
                lped.id_producto = Convert.ToInt32(t.Rows[i][2].ToString());
                lped.cantidad = Convert.ToInt32(t.Rows[i][3].ToString());
                lped.importe = float.Parse(t.Rows[i][4].ToString());
                lped.createLineaPedido();
            }
            //Vaciar el  carrito despues de realizar la compra y redirigir a la pagina de pedidos
            lcar.vaciarCarrito(car);
            Response.Redirect("Pedido.aspx");
        }

        protected void ButtonVaciar(Object sender, EventArgs e)
        {
            //Vaciar el carrito 
            lcar.vaciarCarrito(car);
            Response.Redirect("Carrito.aspx");
        }
    }
}
