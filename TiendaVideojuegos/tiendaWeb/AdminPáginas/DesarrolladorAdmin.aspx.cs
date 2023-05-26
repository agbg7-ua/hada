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
    public partial class DesarrolladorAdmin : System.Web.UI.Page
    {
        ENDesarrollador en = new ENDesarrollador();
        DataSet d= new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
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
                List<ENDesarrollador> l = new List<ENDesarrollador>();
            l  = en.obtener_todos();
            if (l.Count != 0)
            {
                listView1.DataSource = l;
                listView1.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        protected void ButtonAñadir(object sender, EventArgs e)
        {
            Response.Redirect("InsertarDesarrolladorAdmin.aspx");
        }

        /// <summary>
        /// Guarda el di en una variale Session y redirige a la página de editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonEditar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();
            //ImageButton b = (ImageButton)sender;

            Session["desarrolladorID"] = i;

            Response.Redirect("EditarDesarrolladorAdmin.aspx?idProd=" + i);
        }

        /// <summary>
        /// Borra el desarrollador correspondiente en la linea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENDesarrollador en = new ENDesarrollador();

            LinkButton myButton = (LinkButton)sender;
            int i = int.Parse(myButton.CommandArgument.ToString());

            en.id = i;
            en.obtener_by_id(i);

            en.eliminar();
            Response.Redirect("DesarrolladorAdmin.aspx");
        }
    }
}