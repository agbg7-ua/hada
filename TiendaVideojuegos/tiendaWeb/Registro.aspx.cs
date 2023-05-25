using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;
using System.Globalization;

namespace tiendaWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(Object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();

            Page.Validate("login");
            if (Page.IsValid)
            {
                usu.username = username1.Text;
                usu.password = password1.Text;
                if (usu.logIn())
                {
                    Session.Add("username", usu.username);
                    Response.Redirect("~/Usuario.aspx");
                }
                else
                {
                    Msg.Text = "El usuario o la contraseña son incorrectas";
                }
            }
        }

        protected void Button2_Click(Object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();

            Page.Validate("signup");
            if (Page.IsValid)
            {
                usu.username = username2.Text;
                usu.nombre = nombre.Text;
                usu.apellidos = apellidos.Text;
                usu.email = email.Text;
                usu.password = password2.Text;
                usu.edad = Convert.ToInt32(edad.Text);
                usu.calle = calle.Text;
                usu.pueblo = pueblo.Text;
                usu.provincia = provincia.Text;
                usu.codigo_postal = codpostal.Text;
                usu.telefono = telefono.Text;
                usu.admin = false;
                if (usu.signIn())
                {
                    ENCarrito car = new ENCarrito();
                    car.id_usuario = usu.username;
                    car.importe_total = 0;
                    car.createCarrito();
                    Session.Add("username", usu.username);
                    Response.Redirect("Home.aspx");
                }
                else 
                {
                    Msg2.Text = "El email introducido ya existe";
                }
            }
        }
    }
}