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

            // Recogemos el id de la categoría a Editar
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readCategoriaProducto();

            // Rellenamos los placeholder de los campos con los datos de la categoría
            nombre.Attributes.Add("placeholder", en.nombre);
            descripcion.Attributes.Add("placeholder", en.descripcion);
        }
        
        /// <summary>
        /// Botón de volver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaProductoAdmin.aspx");
        }

        /// <summary>
        /// Botón de guardos los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonGuardar(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readCategoriaProducto();

            string name, description;

            // En caso de que los campos no hayan sido rellenados, se dejarán los datos anteriores
            if (nombre.Text == "")
            {
                name = en.nombre;
            }
            else
            {
                name = nombre.Text;
            }
            if (descripcion.Text == "")
            {
                description = en.descripcion;
            }
            else 
            {
                description = descripcion.Text;
            }

            // Comprobamos las validaciones
            if (Page.IsValid)
            {
                en.nombre = name;
                en.descripcion = description;

                // Si no se actualiza, será porque el nombre ya existe
                if (en.updateCategoriaProducto())
                {
                    Response.Redirect("CategoriaProductoAdmin.aspx");
                }
                else
                {
                    Msg.Text = "El nombre introducido ya existe";
                }
            }
        }
    }
}