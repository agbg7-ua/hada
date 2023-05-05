using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb
{
	public partial class LineaCarrito : System.Web.UI.Page
	{
		ENLineaCarrito lc = new ENLineaCarrito();
		DataSet d = new DataSet();
		protected void Page_Load(object sender, EventArgs e)
		{
			ENCarrito en = new ENCarrito();
			d = lc.showLineasCarritoByCarrito(en);
			if (d.Tables.Count > 0)
			{
				gridViewLineaCarrito.DataSource = d;
				gridViewLineaCarrito.DataBind();
			}
			else
			{
				textboxVacio.Visible = true;
			}
		}
		

	}
	}
