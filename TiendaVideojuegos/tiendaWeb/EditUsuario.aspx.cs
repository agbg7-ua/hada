using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb
{
    public partial class EditUsuario : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.username = (string)Session["Datos"];

            if (usu.readUsuario())
            {
                TextBox2.Text = usu.nombre;
                TextBox1.Text = usu.apellidos;
                TextBox3.Text = usu.telefono;
                TextBox4.Text = usu.calle;
                TextBox5.Text = usu.codigo_postal;
                TextBox6.Text = usu.pueblo;
                TextBox7.Text = usu.provincia;
                TextBox8.Text = usu.edad.ToString();
                TextBox10.Text = usu.username;
                TextBox9.Text = usu.email;

            }
    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.nombre = TextBox2.Text;
            usu.apellidos = TextBox1.Text;
            usu.telefono = TextBox3.Text;
            usu.calle = TextBox4.Text;
            usu.codigo_postal = TextBox5.Text;
            usu.pueblo = TextBox6.Text;
            usu.provincia = TextBox7.Text;
            usu.edad = int.Parse(TextBox8.Text);
            usu.username = TextBox10.Text;
            usu.email = TextBox9.Text;
            if (usu.updateUsuario())
            {
                outputMsg.Text = "Usuario actualizado con exito.";
            }
            else
            {
                outputMsg.Text = "Usuario no actualizado";   
            }
        }
    }
}