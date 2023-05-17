using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace tiendaWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                    usuario.Visible = false;
                    perfil.Visible = true;
                    carrito.Visible = true;
                    pedidos.Visible = true;
                    cerrar_sesion.Visible = true;
                    if (usu.isAdminUsuario())
                    {
                        administrador.Visible = true;
                    }
                    else {
                        administrador.Visible = false;
                    }
                }
                else 
                {
                    usuario.Visible = true;
                    perfil.Visible = false;
                    carrito.Visible = false;
                    pedidos.Visible = false;
                    cerrar_sesion.Visible = false;
                    administrador.Visible = false;
                }
            }
        }

        protected void button_buscar_OnClientClick(object sender, EventArgs e)
        {
            string cad = "BuscarProducto.aspx?b=" + tbox.Text;
            Response.Redirect(cad);
        }

        protected void button_usuarioOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Registro.aspx");
        }

        protected void button_perfilOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuario.aspx");
        }

        protected void button_carritoOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Carrito.aspx");
        }

        protected void button_pedidosOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pedido.aspx");
        }

        protected void button_sesionOnClientClick(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Home.aspx");
        }

        protected void button_adminOnClientClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin.aspx");
        }
    }
}