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

            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();
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
                else
                {
                    Response.Redirect("~/Home.aspx");
                }
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
            usu.username = Session["username"].ToString();
            if (usu.deleteUsuario())
            {
                Session.Clear();
                Response.Redirect("~/Registro.aspx");
            }
            else
            {
                outputmsg.Text = "No se pudo eliminar el usuario";
            }
        }
    }
}