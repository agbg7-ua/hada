using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_buscar_OnClientClick(object sender, EventArgs e)
        {
            string cad = "BuscarProducto.aspx?b=" + tbox.Text;
            Response.Redirect(cad);
        }
    }
}