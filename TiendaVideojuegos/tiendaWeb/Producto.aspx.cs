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

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Recogemos el id del Producto
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();


            // Relleanmos los campos con los datos del Producto
            ProductImage.ImageUrl = en.imagen;
            nombre.Text = en.nombre;
            precio.Text = en.pvp.ToString() + "€";
            fecha.Text = en.fecha_salida.Date.ToString();
            descripcion.Text = en.descripcion;
            comentario.NavigateUrl = "Comentario.aspx?idProd=" + en.id;

            // En caso de que el usuario esté registrado:
            // Podrá comprar o añadir al carrito
            // Sino, solo podrá registrarse
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

        /// <summary>
        /// Método para añadir al carrito el Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void button_carrito_OnClientClick(object sender, EventArgs e) 
        {
            ENProducto prod = new ENProducto();
            DateTime hoy = DateTime.Now;
            int cant;
 
            prod.id = en.id;
            prod.readProducto();

            // En caso de que no se especifique la cantidad, ésta será 1 por defecto
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
            
            // Si no existe un carrito para el usuario registrado, lo creamos
            if (!car.readCarritoByUser(usu))
            {
                car.id_usuario = usu.username;
                car.importe_total = prod.pvp * cant;
                car.createCarrito();
            }

            // Creamos la línea de carrito con los datos correspondientes
            lcar.id_carrito = car.id;
            lcar.id_producto = prod.id;
            lcar.cantidad = cant;
            lcar.fecha = hoy;
            lcar.importe = prod.pvp * lcar.cantidad;
            lcar.createLineaCarrito();

            // Redirigimos a la página de carrito
            Response.Redirect("Carrito.aspx");
        }

        /// <summary>
        /// Método para comprar ya un Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void button_comprar_OnClientClick(object sender, EventArgs e)
        {
            ENProducto prod = new ENProducto();
            ENPedido ped = new ENPedido();
            DateTime hoy = DateTime.Now;
            int cant;

            prod.id = en.id;
            prod.readProducto();

            // En caso de que no se especifique la cantidad, ésta será 1 por defecto
            if (cantidad.Text == "")
            {
                cant = 1;
            }
            else
            {
                cant = Convert.ToInt32(cantidad.Text);
            }

            // Creamos un Pedido Nuevo
            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = prod.pvp * cant;
            ped.createPedido();
            ped.lastPedido();
            
            // Creamos la línea de pedido con el producto seleccionado
            ENLineaPedido lped = new ENLineaPedido();

            lped.id_pedido = ped.id;
            lped.id_producto = prod.id;
            lped.cantidad = cant;
            lped.importe = prod.pvp * cant;
            lped.createLineaPedido();

            // Redirigimos a la página de Pedidos
            Response.Redirect("Pedido.aspx");
        }

        /// <summary>
        /// Método del botón de Iniciar Sesión/Registrarse para usuarios no registrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void button_registro_OnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }
    }
}