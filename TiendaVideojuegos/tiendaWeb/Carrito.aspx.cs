using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

<<<<<<< HEAD


namespace tiendaWeb
{
	public partial class Carrito : System.Web.UI.Page
	{
		ENCarrito cesta = new ENCarrito();
		DataSet d = new DataSet();
		protected void Page_Load(object sender, EventArgs e)
		{
			d = cesta.showCarrito();
			if(d.Tables[0].Rows.Count > 0)
            {
				listView.DataSource = d;
				listView.DataBind();
            }
            else
            {
				textboxVacio.Visible = true;
            }
		}
	}
=======
namespace tiendaWeb
{
    public partial class Carrito : System.Web.UI.Page
    {
        ENLineaCarrito lcar = new ENLineaCarrito();
        ENCarrito car = new ENCarrito();
        ENUsuario u = new ENUsuario();

        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Provisional hasta que se termine usuario
            u.username = "usuario 1";
            u.readUsuario();
            car.readCarritoByUser(u);

            d = lcar.showLineasCarritoByCarrito(car);

            if ((d.Tables.Count > 0) && (d.Tables[0].Rows.Count > 0))
            {
                GridView1.DataSource = d;
                GridView1.DataBind();
            }
        }

        protected void button_eliminar_OnClientClick(object sender, EventArgs e)
        {
            
        }
    }
>>>>>>> develop
}