using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace tiendaWeb
{

    public class Item
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
    }

    public partial class Desarrrolador : System.Web.UI.Page
    {

        // datos de ejemplo

        string nombre = "Bungie";
        string descripcion = @"
Bungie Studios és una empresa dissenyadora de videojocs fundada en 1991 sota el nom de Bungie Programari Productes Corporation per dos estudiants de la Universitat de Chicago, Alex Seropian i Jason Jones. Forma part dels estudis de videojocs de Microsoft des que aquesta empresa la va comprar en l'any 2000
            ";

        System.DateTime fecha = DateTime.Now;
        string web = "www.counter-strike.net";
        string origen = "Estados Unidos";
        string imagen = "~/Imagenes/bungie.png";

        static bool edit_mode = false;
        static bool nuevo_mode = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    string nombre = (string)Session["desarrollador"];

                    ENDesarrollador en = new ENDesarrollador();
                    en.nombre = nombre;
                    en = en.obtener_by_nombre(nombre);

                    descripcion = en.descripcion;
                    fecha = en.fecha_creacion;
                    web = en.web;
                    origen = en.origen;
                    imagen = en.imagen;

                    Label_nombre.Text = nombre;
                    Label_descripcion.Text = descripcion;
                    Label_fecha.Text = fecha.ToString().Split(' ')[0];
                    Label_web.Text = web;
                    Label_origen.Text = origen;
                    Image3.ImageUrl = imagen;

                    Label_error_info.Text = imagen;
                }
                catch (Exception ex)
                {

                    Label_error_info.Text = ex.Message;
                }
            }

            //TextBox_descripcion.Visible = false;
            //TextBox_fecha.Visible = false;
            //TextBox_nombre.Visible = false;
            //TextBox_web.Visible = false;
            //TextBox_origen.Visible = false;
            //Button_nuevo.Visible = false;
            //Button_eliminar.Visible = false;

            //FileUpload1.Visible = false;
            //Button_upload_image.Visible = false;

            //Label_nombre.Text = nombre;
            //Label_descripcion.Text = descripcion;
            //Label_fecha.Text = fecha.ToString().Split(' ')[0];
            //Label_web.Text = web;
            //Label_origen.Text = origen;



            //DataTable dt = new DataTable();
            //DataColumn col = new DataColumn("login");
            //dt.Columns.Add(col);
            //col = new DataColumn("name");
            //dt.Columns.Add(col);
            //col = new DataColumn("firstname");
            //dt.Columns.Add(col);
            //DataRow row = dt.NewRow();

            //row["login"] = "we";
            //row["name"] = "123123";
            //row["firstname"] = "123123";
            //dt.Rows.Add(row);

            //GridView1.DataSource = dt;
            //GridView1.DataBind();


            List<Item> list = new List<Item>();
            list.Add(new Item() { ImageURL = "~/Imagenes/sample.jpeg", Title = "             Titulo 1" });
            list.Add(new Item() { ImageURL = "~/Imagenes/rana.png", Title = "             Titulo 2" });
            list.Add(new Item() { ImageURL = "~/Imagenes/dredge.png", Title = "             Titulo 3" });
            list.Add(new Item() { ImageURL = "~/Imagenes/dredge.png", Title = "             Titulo 3" });
            list.Add(new Item() { ImageURL = "~/Imagenes/rana.png", Title = "             Titulo 2" });
            list.Add(new Item() { ImageURL = "~/Imagenes/sample.jpeg", Title = "             Titulo 1" });
            ListView1.DataSource = list;
            ListView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button_editar_Click(object sender, EventArgs e)
        {
            if (edit_mode == false)
            {
                to_edit_mode();

            }
            else
            {
                to_consulta_mode();
            }
            edit_mode = !edit_mode;

        }

        protected void TextBox_descripcion_TextChanged(object sender, EventArgs e)
        {

        }


        private void to_edit_mode()
        {
            TextBox_descripcion.Visible = true;
            TextBox_fecha.Visible = true;
            TextBox_nombre.Visible = true;
            TextBox_web.Visible = true;
            TextBox_origen.Visible = true;

            TextBox_descripcion.Text = Label_descripcion.Text;
            TextBox_fecha.Text = Label_fecha.Text;
            TextBox_nombre.Text = Label_nombre.Text;
            TextBox_web.Text = Label_web.Text;
            TextBox_origen.Text = Label_origen.Text;

            Label_nombre.Visible = false;
            Label_descripcion.Visible = false;
            Label_fecha.Visible = false;
            Label_web.Visible = false;
            Label_origen.Visible = false;

            TextBox_descripcion.Height = Label_descripcion.Height;
            TextBox_nombre.Height = Label_nombre.Height;
            TextBox_descripcion.Height = Label_descripcion.Height;
            TextBox_descripcion.Height = Label_descripcion.Height;
            TextBox_descripcion.Height = Label_descripcion.Height;

            Button_agregar_imagen.Visible = true;
            Button_nuevo.Visible = true;
            Button_eliminar.Visible = true;
            Button_editar.Text = "Guardar Cambios";

            FileUpload1.Visible = true;
            Button_upload_image.Visible = true;
        }

        private void to_consulta_mode()
        {
            TextBox_descripcion.Visible = false;
            TextBox_fecha.Visible = false;
            TextBox_nombre.Visible = false;
            TextBox_web.Visible = false;
            TextBox_origen.Visible = false;

            Label_nombre.Visible = true;
            Label_descripcion.Visible = true;
            Label_fecha.Visible = true;
            Label_web.Visible = true;
            Label_origen.Visible = true;

            Label_nombre.Text = TextBox_nombre.Text;
            Label_descripcion.Text = TextBox_descripcion.Text;
            Label_fecha.Text = TextBox_fecha.Text;
            Label_web.Text = TextBox_web.Text;
            Label_origen.Text = TextBox_origen.Text;

            Button_agregar_imagen.Visible = false;
            Button_nuevo.Visible = false;
            Button_eliminar.Visible = false;

            FileUpload1.Visible = false;
            Button_upload_image.Visible = false;

            Button_editar.Text = "Editar";
        }



        private void to_nuevo_mode()
        {
            TextBox_descripcion.Visible = false;
            TextBox_fecha.Visible = false;
            TextBox_nombre.Visible = false;
            TextBox_web.Visible = false;
            TextBox_origen.Visible = false;

            Label_nombre.Visible = true;
            Label_descripcion.Visible = true;
            Label_fecha.Visible = true;
            Label_web.Visible = true;
            Label_origen.Visible = true;



            Button_agregar_imagen.Visible = false;
            Button_nuevo.Visible = false;
            Button_eliminar.Visible = false;

            FileUpload1.Visible = false;
            Button_upload_image.Visible = false;

            Button_editar.Text = "Editar";
        }
        private string adapt_texto_for_sql(string texto)
        {
            return texto.Replace("'", "''");
        }

        protected void Button_nuevo_click(object sender, EventArgs e)
        {



            Label_error_info.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            ENDesarrollador en = new ENDesarrollador();
            try
            {
                en.nombre = TextBox_nombre.Text;
                en.descripcion = adapt_texto_for_sql(TextBox_descripcion.Text);
                en.fecha_creacion = Convert.ToDateTime(TextBox_fecha.Text);
                en.web = TextBox_web.Text;
                en.origen = TextBox_origen.Text;
                en.imagen = Image3.ImageUrl;
                en.insertar();

                Label_error_info.Text = "Desarrollador guardado correctamente";
                to_consulta_mode();




            }
            catch (Exception ex)
            {
                Label_error_info.Text = ex.Message;
                // TODO Mensaje de error(info en la pagina
            }



        }



        protected void Button_upload_image_click(object sender, EventArgs e)
        {
            string base_save = "/Imagenes/";
            string base_dos = "Imagenes/";
            string file_relative_path;
            try
            {
                FileUpload1.SaveAs(Server.MapPath(base_save) + FileUpload1.FileName);
                file_relative_path = base_dos + FileUpload1.FileName;
                //Image3.ImageUrl = base_save;
                Image3.ImageUrl = file_relative_path;
                Button_upload_image.Text = "Imagen Guardada";
            }
            catch (Exception ex)
            {
                Label_error_info.Text = ex.Message;
                // TODO Mensaje de error(info en la pagina
            }
        }




        protected void cancelar_click(object sender, EventArgs e)
        {

        }




    }
}