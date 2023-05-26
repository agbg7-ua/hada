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
    public partial class CategoriaProductoAdmin : System.Web.UI.Page
    {
        ENCategoriaProducto catproducto = new ENCategoriaProducto();
        ENUsuario usu = new ENUsuario();

        DataSet d = new DataSet();

        /// <summary>
        /// Page_Load de la página
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Comprobamos que el usuario esté registrado que sea administrador
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
            }

            // EN para listar las categorías
            d = catproducto.showAllCategoriaProducto();

            // Rellenamos el ListView
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

        /// <summary>
        /// Botón de añadir categoría
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonAñadir(object sender, EventArgs e)
        {
            Response.Redirect("InsertarCategoriaProductoAdmin.aspx");
        }

        /// <summary>
        /// Botón de editar categoría
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonEditar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("EditarCategoriaProductoAdmin.aspx?idProd=" + i);
        }

        /// <summary>
        /// Botón de borrar categoría
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBorrar(object sender, EventArgs e)
        {
            ENCategoriaProducto en = new ENCategoriaProducto();

            // Recogemos el id de la categoría seleccionada
            LinkButton myButton = (LinkButton)sender;
            int i = int.Parse(myButton.CommandArgument.ToString());

            en.id = i;

            // Llamamos al EN de eliminar categoría
            en.deleteCategoriaProducto();
            Response.Redirect("CategoriaProductoAdmin.aspx");
        }
    }
}