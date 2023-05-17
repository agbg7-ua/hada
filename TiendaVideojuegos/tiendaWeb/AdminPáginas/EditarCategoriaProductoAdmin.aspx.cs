using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;

namespace tiendaWeb.AdminPáginas
{
    public partial class EditarCategoriaProductoAdmin : System.Web.UI.Page
    {
        ENCategoriaProducto en = new ENCategoriaProducto();
        ENUsuario usu = new ENUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] != null)
                {
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

            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readCategoriaProducto();

            ProductImage.ImageUrl = en.imagen;
            nombre.Attributes.Add("placeholder", en.nombre);
            descripcion.Attributes.Add("placeholder", en.descripcion);
        }
            
        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaProductoAdmin.aspx");
        }

        protected void ButtonGuardar(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.nombre = nombre.Text;
            en.descripcion = descripcion.Text;
            en.updateCategoriaProducto();
            Response.Redirect("CategoriaProductoAdmin.aspx");
        }
    }
}