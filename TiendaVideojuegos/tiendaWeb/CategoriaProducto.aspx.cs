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
    public partial class CategoriaProducto : System.Web.UI.Page
    {
        ENCategoriaProducto catproducto = new ENCategoriaProducto();

        DataSet d = new DataSet();

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Llamamos al EN que lista todas las Categorías de Productos
            d = catproducto.showAllCategoriaProducto();

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

    }
}