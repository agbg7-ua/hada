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

        protected void ButtonEditar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();
            //ImageButton b = (ImageButton)sender;

            Session["desarrolladorID"] = i;

            Response.Redirect("EditarDesarrolladorAdmin.aspx?idProd=" + i);
        }

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