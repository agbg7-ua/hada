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
    public partial class EditarProductoAdmin : System.Web.UI.Page
    {
        ENProducto en = new ENProducto();

        protected void Page_Load(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

            ProductImage.ImageUrl = en.imagen;
            nombre.Attributes.Add("placeholder", en.nombre);
            precio.Attributes.Add("placeholder", en.pvp.ToString());
            descripcion.Attributes.Add("placeholder", en.descripcion);

            if (!Page.IsPostBack)
            {
                clasificacion.SelectedValue = en.clasificacion.ToString();
            }
        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("ProductoAdmin.aspx");
        }

        protected void ButtonGuardar(object sender, EventArgs e)
        {
            ENProducto aux = new ENProducto();
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

            if (nombre.Text != "")
            { 
                en.nombre = nombre.Text;
            } 
            if (precio.Text != "")
            {
                en.pvp = (float)Convert.ToDouble(precio.Text);
            }
            if (descripcion.Text != "")
            {
                en.descripcion = descripcion.Text;
            }

            en.clasificacion = Convert.ToInt32(clasificacion.SelectedValue);

            textboxVacio.Visible = true;
            textboxVacio.Text = clasificacion.SelectedValue;

            en.updateProducto();
            Response.Redirect("ProductoAdmin.aspx");
        }
    }
}