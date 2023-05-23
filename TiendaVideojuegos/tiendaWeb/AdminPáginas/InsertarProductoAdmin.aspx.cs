using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;
using System.IO;
using System.Globalization;

namespace tiendaWeb.AdminPáginas
{
    public partial class InsertarProductoAdmin : System.Web.UI.Page
    {
        ENUsuario usu = new ENUsuario();
        ENProducto prod = new ENProducto();
        ENCategoriaProducto cat = new ENCategoriaProducto();
        ENDesarrollador des = new ENDesarrollador();
        DataSet d = new DataSet();
        DataSet ddes = new DataSet();

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
                warning.Visible = false;

                d = cat.getCategoriaProducto();

                if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
                {
                    categoria.DataSource = d;
                    categoria.DataTextField = "nombre";
                    categoria.DataValueField = "id";
                    categoria.DataBind();
                }
                else
                {
                    warning.Visible = true;
                    tarde.Visible = true;
                    tarde.Text = "No existen Géneros en estos momentos, por favor inténtelo más tarde";
                }

                ddes = des.getDesarrollador();

                if ((ddes.Tables.Count != 0) && (ddes.Tables[0].Rows.Count > 0))
                {
                    desarrollador.DataSource = ddes;
                    desarrollador.DataTextField = "nombre";
                    desarrollador.DataValueField = "id";
                    desarrollador.DataBind();
                }
                else
                {
                    warning.Visible = true;
                    tarde.Visible = true;
                    tarde.Text = "No existen Desarrolladoras en estos momentos, por favor inténtelo más tarde";
                }
            }
        }

        protected void ButtonGuardar(Object sender, EventArgs e)
        {
            string image;
            float price;

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

            DateTime hoy = DateTime.Now;

            string name = nombre.Text;

            if (float.TryParse(pvp.Text, out price))
            {
                price = float.Parse(pvp.Text, System.Globalization.CultureInfo.InvariantCulture);
            }

            string description = descripcion.Text;
            int category = Convert.ToInt32(categoria.SelectedValue);
            int desarrolladora = Convert.ToInt32(desarrollador.SelectedValue);
            int clas = Convert.ToInt32(clasificacion.SelectedValue);
            bool show = mostrar.Checked;

            if (Page.IsValid)
            {
                prod.id_categoria = category;
                prod.id_desarrollador = desarrolladora;
                prod.nombre = name;
                prod.pvp = price;
                prod.descripcion = description;
                prod.clasificacion = clas;
                prod.imagen = "~/Imagenes/Uploads/" + image;
                prod.mostrar = show;
                prod.fecha_salida = hoy;

                if (prod.createProducto())
                {
                    Response.Redirect("ProductoAdmin.aspx");
                }
                else
                {
                    alerta.Visible = true;
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
            Response.Redirect("ProductoAdmin.aspx");
        }
    }
}