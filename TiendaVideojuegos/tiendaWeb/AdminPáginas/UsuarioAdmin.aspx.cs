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

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Comprobamos que el usuario esté registrado que sea administrador
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

            // Rellenamos el ListView
            if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
            {
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        /// <summary>
        /// Botón de borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();

            // Recogemos el username del usuario seleccionado
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            en.username = i;

            // Llamamos al EN de eliminar usuario
            en.deleteUsuario();
            Response.Redirect("UsuarioAdmin.aspx");
        }

        /// <summary>
        /// Botón para cambiar el estado de administrador de un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonCambiar(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            bool nuevo;

            // Recogemos el username del usuario seleccionado
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            en.username = i;
            en.readUsuario();

            // Y cambiamos el estado de admin
            if (en.admin == true)
            {
                nuevo = false;
            }
            else 
            {
                nuevo = true;
            }

            en.admin = nuevo;

            // Actualizamos el usuario
            en.updateAdminUser();
            Response.Redirect("UsuarioAdmin.aspx");
        }
    }
}