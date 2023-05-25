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
            string usuario;
            ENUsuario usu = new ENUsuario();

            Page.Validate("login");
            if (Page.IsValid)
            {
                usu.username = username1.Text;
                usu.password = password1.Text;
                usuario = usu.username;
                if (usu.logIn())
                {
                    Session["Datos"] = usuario;
                    Session.Add("username", usuario);
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
            string usuario;
            ENUsuario usu = new ENUsuario();
            usu.edad = int.Parse(textEdad.Text);
            usu.pueblo = textLocalidad.Text;
            usu.provincia = textProvincia.Text;
            usu.nombre = textNombre.Text;
            usu.password = textPassword.Text;
            usu.apellidos = textApellidos.Text;
            usu.calle = textDireccion.Text;
            usu.codigo_postal = textCodigo.Text;
            usu.email = textEmail.Text;
            usu.telefono = textNumero.Text;
            usu.username = textUsername.Text;
            usu.admin = false;
            usuario = usu.username;
            if (usu.signIn())
            {
                Session["Datos"] = usuario;
                Response.Redirect("~/Usuario.aspx");
            }
            else
            {
                outputMsg2.Text = "Falta algún dato o alguno introducido es incorrecto";
            }


        }

    }
}