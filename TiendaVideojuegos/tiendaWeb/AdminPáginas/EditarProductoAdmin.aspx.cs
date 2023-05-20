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
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

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

                ProductImage.ImageUrl = en.imagen;
                nombre.Attributes.Add("placeholder", en.nombre);
                precio.Attributes.Add("placeholder", en.pvp.ToString());
                descripcion.Attributes.Add("placeholder", en.descripcion);
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
                en.pvp = float.Parse(precio.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
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