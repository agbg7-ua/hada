using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tiendaWeb
{
    public partial class Oferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void comentButton(object sender, EventArgs e)
        {
            Response.Redirect("~/NuevoComentario.aspx");
        }
    }
}