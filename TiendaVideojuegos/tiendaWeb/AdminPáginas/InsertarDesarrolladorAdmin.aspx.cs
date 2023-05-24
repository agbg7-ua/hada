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
    public partial class InsertarDesarrolladorAdmin : System.Web.UI.Page
    {
        ENDesarrollador en = new ENDesarrollador();
        ENDesarrollador backup = new ENDesarrollador();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    Label_info.Text += ex.Message;
                }


            }
        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("DesarrolladorAdmin.aspx");
        }

        protected void TextBox_nombre_TextChanged(object sender, EventArgs e)
        {
            Button_cancelar.Enabled = true;
            Button_guardar.Enabled = true;
            //Button_recargar.Enabled = true;
        }

        protected void Button_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {

                    ENDesarrollador nuevo = new ENDesarrollador();
                    nuevo.id = Convert.ToInt32(Session["desarrolladorID"]);
                    nuevo.nombre = TextBox_nombre.Text;
                    nuevo.descripcion = TextBox_descripcion.Text.Replace("'", "''");
                    nuevo.origen = DropDownList1.Text;
                    nuevo.web = TextBox_web.Text;
                    nuevo.fecha_creacion = Convert.ToDateTime(TextBox_Date.Text);
                    nuevo.imagen = ProductImage.ImageUrl;

                    nuevo.insertar();
                    Label_info.Text = "Desarrollador registrado con exito";
                }
            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message; return;
            }
        }

        protected void Button_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("DesarrolladorAdmin.aspx");
        }

        //protected void Button_recargar_Click(object sender, EventArgs e)
        //{
        //    ProductImage.ImageUrl = backup.imagen;
        //    TextBox_nombre.Text = backup.nombre;
        //    TextBox_descripcion.Text = backup.descripcion;
        //    //TextBox_origen.Text = backup.origen;
        //    TextBox_web.Text = backup.web;
        //}

        protected void Button_upload_image_Click(object sender, EventArgs e)
        {
            string base_save = "~/Imagenes/";
            try
            {
                FileUpload1.SaveAs(Server.MapPath(base_save) + FileUpload1.FileName);
                ProductImage.ImageUrl = base_save + FileUpload1.FileName;
                Button_upload_image.Text = "Imagen Guardada";
                en.imagen = ProductImage.ImageUrl;
            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
                // TODO Mensaje de error(info en la pagina
            }
        }
    }
}