using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb.AdminPáginas
{
    public partial class UsuarioAdmin : System.Web.UI.Page
    {
        ENUsuario usu = new ENUsuario();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
                    usu.username = Session["username"].ToString();

                    if (!usu.isAdminUsuario())
                    {
                        Response.Redirect("~/Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/Home.aspx");
                }  
            }

            d = usu.showAllUsers();

            if (d.Tables[0].Rows.Count > 0)
            {
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        protected void ButtonVer(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("VerUsuarioAdmin.aspx?idUsu=" + i);
        }

        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();

            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            en.username = i;

            en.deleteUsuario();
            Response.Redirect("UsuarioAdmin.aspx");
        }

        protected void ButtonCambiar(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            bool nuevo;

            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            en.username = i;
            en.readUsuario();

            if (en.admin == true)
            {
                nuevo = false;
            }
            else 
            {
                nuevo = true;
            }

            en.admin = nuevo;

            en.updateAdminUser();
            Response.Redirect("UsuarioAdmin.aspx");
        }
    }
}