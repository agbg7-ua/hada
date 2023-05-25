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
    public partial class OfertaAdmin : System.Web.UI.Page
    {
        ENDesarrollador en = new ENDesarrollador();
        ENDesarrollador backup = new ENDesarrollador();
        protected void Page_Load(object sender, EventArgs e)
        {
            // get a list of all products
            List<ENDesarrollador> lista = new List<ENDesarrollador>();
      
        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("../Admin.aspx");
        }



        protected void Button_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin.aspx");
        }
    }
}