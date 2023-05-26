using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace tiendaWeb
{
    public partial class Oferta1 : System.Web.UI.Page
    {
        ENProducto prod1 = new ENProducto();
        ENOferta of1 = new ENOferta();
        ENProducto prod2 = new ENProducto();
        ENOferta of2 = new ENOferta();
        ENProducto prod3 = new ENProducto();
        ENOferta of3 = new ENOferta();
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                }
                else 
                {
                    Response.Redirect("Home.aspx");
                }
            }

            ENOferta o1 = new ENOferta();
            o1.id = 1;
            ENOferta o2 = new ENOferta();
            o2.id = 2;
            ENOferta o3 = new ENOferta();
            o3.id = 3;
            o1.readOferta();
            o2.readOferta();
            o3.readOferta();
            of1 = o1;
            of2 = o2;
            of3 = o3;
            //of1.primeraOferta(prod1);

            prod1.id = of1.id_producto;
            prod1.readProducto();

            Image1.ImageUrl = prod1.imagen;
            nombre1.Text = prod1.nombre;
            precioant1.Text = prod1.pvp.ToString("0. ##") + "€";
            oferta1.Text = of1.oferta.ToString("0. ##") + "€";

            //of2.segundaOferta(prod2);

            prod2.id = of2.id_producto;
            prod2.readProducto();

            Image2.ImageUrl = prod2.imagen;
            nombre2.Text = prod2.nombre;
            precioant2.Text = prod2.pvp.ToString("0. ##") + "€";
            oferta2.Text = of2.oferta.ToString("0. ##") + "€";

            //of3.terceraOferta(prod3);

            prod3.id = of3.id_producto;
            prod3.readProducto();

            Image3.ImageUrl = prod3.imagen;
            nombre3.Text = prod3.nombre;
            precioant3.Text = prod3.pvp.ToString("0. ##") + "€";
            oferta3.Text = of3.oferta.ToString("0. ##") + "€";

        }

        protected void ButtonComprar1(Object sender, EventArgs e)
        {
            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = of1.oferta;
            ped.createPedido();
            ped.lastPedido();

            lped.id_pedido = ped.id;
            lped.id_producto = prod1.id;
            lped.cantidad = 1;
            lped.importe = of1.oferta;
            lped.createLineaPedido(); 
        }

        protected void ButtonComprar2(Object sender, EventArgs e)
        {
            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = of2.oferta;
            ped.createPedido();
            ped.lastPedido();

            lped.id_pedido = ped.id;
            lped.id_producto = prod2.id;
            lped.cantidad = 1;
            lped.importe = of2.oferta;
            lped.createLineaPedido();
        }

        protected void ButtonComprar3(Object sender, EventArgs e)
        {
            usu.username = Session["username"].ToString();
            ENPedido ped = new ENPedido();
            ENLineaPedido lped = new ENLineaPedido();
            DateTime hoy = DateTime.Now;

            ped.id_usuario = usu.username;
            ped.fecha = hoy;
            ped.importe_total = of3.oferta;
            ped.createPedido();
            ped.lastPedido();

            lped.id_pedido = ped.id;
            lped.id_producto = prod3.id;
            lped.cantidad = 1;
            lped.importe = of3.oferta;
            lped.createLineaPedido();
        }
    }
}