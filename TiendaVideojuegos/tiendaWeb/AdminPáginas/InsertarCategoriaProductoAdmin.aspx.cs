using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;
using System.IO;

namespace tiendaWeb.AdminPáginas
{
    public partial class InsertarCategoriaProductoAdmin : System.Web.UI.Page
    {
        ENUsuario usu = new ENUsuario();
        ENCategoriaProducto cat = new ENCategoriaProducto();

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

                alerta.Visible = false;
            }
        }

        protected void ButtonGuardar(Object sender, EventArgs e)
        {
            string image;

            //Access the File using the Name of HTML INPUT File.
            HttpPostedFile postedFile = Request.Files["FileUpload"];

            //Check if File is available.
            if (postedFile != null && postedFile.ContentLength > 0)
            {
                //Save the File.
                string filePath = Server.MapPath("~/Imagenes/Uploads/") + Path.GetFileName(postedFile.FileName);
                postedFile.SaveAs(filePath);
                image = postedFile.FileName;
            }
            else
            {
                image = "sinimagen.jpeg";
            }

            string name = nombre.Text;
            string description = descripcion.Text;

            if (Page.IsValid)
            {
                cat.nombre = name;
                cat.descripcion = description;
                cat.imagen = "~/Imagenes/Uploads/" + image;

                if (cat.createCategoriaProducto())
                {
                    Response.Redirect("CategoriaProductoAdmin.aspx");
                }
                else
                {
                    Msg.Text = "El nombre introducido ya existe";
                }
            }
            else 
            {
                alerta.Visible = true;
            }
        }

        protected void ButtonVolver(Object sender, EventArgs e)
        {
            Response.Redirect("CategoriaProductoAdmin.aspx");
        }
    }
}