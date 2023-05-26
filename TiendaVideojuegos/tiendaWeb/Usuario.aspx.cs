using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb
{
    public partial class Usuario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.username = (string)Session["Datos"];
            if (usu.readUsuario())
            {
                NameUsu.Text = usu.nombre;
                SurnameUsu.Text = usu.apellidos;
                NumberUsu.Text = usu.telefono;
                AddresUsu.Text = usu.calle;
                PostUsu.Text = usu.codigo_postal;
                LocationUsu.Text = usu.pueblo;
                ProvUsu.Text = usu.provincia;
                EdadUsu.Text = usu.edad.ToString();
                Username.Text = usu.username;
                EmailUsu.Text = usu.email;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = (string)Session["Datos"];
            Session["Datos1"] = usuario;
            Response.Redirect("~/EditUsuario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.username = (string)Session["Datos"];
            if (usu.deleteUsuario())
            {
               Response.Redirect("~/Registro.aspx");
            }
            else
            {
                outputmsg.Text = "No se pudo eliminar el usuario";
            }
            
        }
    }
}