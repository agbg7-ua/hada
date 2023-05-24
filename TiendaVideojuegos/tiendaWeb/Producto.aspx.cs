using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;
using System.Web.UI.HtmlControls;

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

            ProductImage.ImageUrl = en.imagen;
            nombre.Text = en.nombre;
            precio.Text = en.pvp.ToString() + "€";
            fecha.Text = en.fecha_salida.Date.ToString();
            descripcion.Text = en.descripcion;
            comentario.NavigateUrl = "Comentario.aspx?idProd=" + en.id;

            if (Session["username"] != null)
            {
                usu.username = Session["username"].ToString();
                carrito.Visible = true;
                comprar.Visible = true;
                registrarse.Visible = false;
            }
            else
            {
                carrito.Visible = false;
                comprar.Visible = false;
                registrarse.Visible = true;
            }
        }

        protected void button_carrito_OnClientClick(object sender, EventArgs e) 
        {
            ENProducto prod = new ENProducto();
            DateTime hoy = DateTime.Now;
            int cant;
 
            prod.id = en.id;
            prod.readProducto();

            if (cantidad.Text == "")
            {
                cant = 1;
            }
            else
            {
                cant = Convert.ToInt32(cantidad.Text);
            }

            ENCarrito car = new ENCarrito();
            ENLineaCarrito lcar = new ENLineaCarrito();

            if (!car.readCarritoByUser(usu))
            {
                car.id_usuario = usu.username;
                car.importe_total = prod.pvp * cant;
                car.createCarrito();
            }

            lcar.id_carrito = car.id;
            lcar.id_producto = prod.id;
            lcar.cantidad = cant;
            lcar.fecha = hoy;
            lcar.importe = prod.pvp * lcar.cantidad;
            lcar.createLineaCarrito();

            Response.Redirect("Carrito.aspx");
        }

        protected void button_comprar_OnClientClick(object sender, EventArgs e)
        {
            ENProducto prod = new ENProducto();
            ENPedido ped = new ENPedido();
            DateTime hoy = DateTime.Now;
            int cant;

            prod.id = en.id;
            prod.readProducto();

            if (cantidad.Text == "")
            {
                cant = 1;
            }
            else
            {
                cant = Convert.ToInt32(cantidad.Text);
            }

            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = prod.pvp * cant;
            ped.createPedido();
            ped.lastPedido();
            
            ENLineaPedido lped = new ENLineaPedido();

            lped.id_pedido = ped.id;
            lped.id_producto = prod.id;
            lped.cantidad = cant;
            lped.importe = prod.pvp * cant;
            lped.createLineaPedido();
            
        }

        protected void button_registro_OnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }
    }
}