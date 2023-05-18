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

        protected void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.TextMode = TextBoxMode.SingleLine;
            }
            else
            {
                passwordTextBox.TextMode = TextBoxMode.Password;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario;
            ENUsuario usu = new ENUsuario();
            usu.username = TextBox1.Text;
            usu.password = passwordTextBox.Text;
            usuario = usu.username;
            if (usu.readUsuario())
            {
                Response.Redirect("~/Usuario.aspx" + Uri.EscapeDataString(usuario));
            }
            else
            {
                outputMsg.Text = "Nombre de usuario o contraseña incorrectos";
            }


        }
        protected void Button2_Click(object sender, EventArgs e)
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
                Response.Redirect("~/Usuario.aspx" + Uri.EscapeDataString(usuario));
            }
            else
            {
                outputMsg2.Text = "Falta algún dato o alguno introducido es incorrecto";
            }


        }

    }
}