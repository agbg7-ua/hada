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

            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
                    if (usu.readUsuario())
                    {
                        username.Text = usu.username;
                        email.Text = usu.email;
                        nombre.Attributes.Add("placeholder", usu.nombre);
                        apellidos.Attributes.Add("placeholder", usu.apellidos);
                        telefono.Attributes.Add("placeholder", usu.telefono);
                        edad.Attributes.Add("placeholder", usu.edad.ToString());
                        calle.Attributes.Add("placeholder", usu.calle);
                        pueblo.Attributes.Add("placeholder", usu.pueblo);
                        provincia.Attributes.Add("placeholder", usu.provincia);
                        codpostal.Attributes.Add("placeholder", usu.codigo_postal);
                    }
                }
                else
                {
                    Response.Redirect("~/Home.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            string name, lastname, phone, street, town, province, postal;
            int age;

            usu.username = Session["username"].ToString();
            usu.readUsuario();

            Page.Validate("signup");
            if (Page.IsValid)
            {
                if (nombre.Text == "")
                {
                    name = usu.nombre;
                    usu.nombre = name;
                }
                else
                {
                    usu.nombre = nombre.Text;
                }
                if (apellidos.Text == "")
                {
                    lastname = usu.apellidos;
                    usu.apellidos = lastname;
                }
                else
                {
                    usu.apellidos = apellidos.Text;
                }
                if (telefono.Text == "")
                {
                    phone = usu.telefono;
                    usu.telefono = phone;
                }
                else
                {
                    usu.telefono = telefono.Text;
                }
                if (edad.Text == "")
                {
                    age = usu.edad;
                    usu.edad = age;
                }
                else
                {
                    usu.edad = Convert.ToInt32(edad.Text);
                }
                if (calle.Text == "")
                {
                    street = usu.calle;
                    usu.calle = street;
                }
                else
                {
                    usu.calle = calle.Text;
                }
                if (pueblo.Text == "")
                {
                    town = usu.pueblo;
                    usu.pueblo = town;
                }
                else
                {
                    usu.pueblo = pueblo.Text;
                }
                if (provincia.Text == "")
                {
                    province = usu.provincia;
                    usu.provincia = province;
                }
                else
                {
                    usu.provincia = provincia.Text;
                }
                if (codpostal.Text == "")
                {
                    postal = usu.codigo_postal;
                    usu.codigo_postal = postal;
                }
                else
                {
                    usu.codigo_postal = codpostal.Text;
                }

                if (usu.updateUsuario())
                {
                    Response.Redirect("Usuario.aspx");
                }
                else 
                {
                    Msg2.Text = "Oh oh, algo ha ido mal. Vuelva a revisar sus credenciales.";
                }

            }
        }
    }
}