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
    public partial class ProductoAdmin : System.Web.UI.Page
    {

        ENProducto producto = new ENProducto();
        ENUsuario usu = new ENUsuario();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
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

                d = producto.showAllProductoAdmin();

                if (d.Tables[0].Rows.Count > 0)
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

        protected void ImagenClasificacion(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                Image imagen1 = (Image)dataItem.FindControl("Imagen1");

                int clas = Convert.ToInt32(DataBinder.Eval(dataItem.DataItem, "id").ToString());

                producto.id = clas;
                producto.readProducto();

                if (producto.clasificacion == 1)
                {
                    imagen1.ImageUrl = "~/Imagenes/Clasificacion/pegi3.png";
                }
                else if (producto.clasificacion == 2)
                {
                    imagen1.ImageUrl = "~/Imagenes/Clasificacion/pegi7.png";
                }
                else if (producto.clasificacion == 3)
                {
                    imagen1.ImageUrl = "~/Imagenes/Clasificacion/pegi12.png";
                }
                else if (producto.clasificacion == 4)
                {
                    imagen1.ImageUrl = "~/Imagenes/Clasificacion/pegi16.png";
                }
                else if (producto.clasificacion == 5)
                {
                    imagen1.ImageUrl = "~/Imagenes/Clasificacion/pegi18.png";
                }
                else 
                {
                    imagen1.Visible = false;
                }
            }
        }

        protected void ButtonAñadir(object sender, EventArgs e)
        {
            Response.Redirect("InsertarProductoAdmin.aspx");
        }

        protected void ButtonEditar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("EditarProductoAdmin.aspx?idProd=" + i);
        }

        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENProducto en = new ENProducto();

            LinkButton myButton = (LinkButton)sender;
            int i = int.Parse(myButton.CommandArgument.ToString());

            en.id = i;

            en.deleteProducto();
            Response.Redirect("ProductoAdmin.aspx");
        }
    }
}