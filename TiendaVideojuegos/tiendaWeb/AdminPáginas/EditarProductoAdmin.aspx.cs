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
        ENCategoriaProducto cat = new ENCategoriaProducto();
        ENDesarrollador des = new ENDesarrollador();
        DataSet d = new DataSet();
        DataSet ddes = new DataSet();

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

                d = cat.getCategoriaProducto();

                if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
                {
                    categoria.DataSource = d;
                    categoria.DataTextField = "nombre";
                    categoria.DataValueField = "id";
                    categoria.DataBind();
                }

                ddes = des.getDesarrollador();

                if ((ddes.Tables.Count != 0) && (ddes.Tables[0].Rows.Count > 0))
                {
                    desarrollador.DataSource = ddes;
                    desarrollador.DataTextField = "nombre";
                    desarrollador.DataValueField = "id";
                    desarrollador.DataBind();
                }

                nombre.Attributes.Add("placeholder", en.nombre);
                pvp.Attributes.Add("placeholder", en.pvp.ToString());
                categoria.SelectedValue = "en.id_categoria";
                desarrollador.SelectedValue = "en.id_desarrollador";
                clasificacion.SelectedValue = en.clasificacion.ToString();
                mostrar.Value = "en.mostrar";
                descripcion.Attributes.Add("placeholder", en.descripcion);
            }
        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("ProductoAdmin.aspx");
        }

        protected void ButtonGuardar(object sender, EventArgs e)
        {
            en.id = Convert.ToInt32(Request.Params["idProd"]);
            en.readProducto();

            string name, description;
            float price;

            if (nombre.Text == "")
            {
                name = en.nombre;
            }
            else 
            {
                name = nombre.Text;
            }
            if (pvp.Text == "")
            {
                price = en.pvp;
            }
            else 
            {
                if (float.TryParse(pvp.Text, out price))
                {
                    price = float.Parse(pvp.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
            }
            if (descripcion.Text == "")
            {
                description = en.descripcion;
            }
            else
            {
                description = descripcion.Text;
            }

            int category = Convert.ToInt32(categoria.SelectedValue);
            int desarrolladora = Convert.ToInt32(desarrollador.SelectedValue);
            int clas = Convert.ToInt32(clasificacion.SelectedValue);
            bool show = mostrar.Checked;

            if (Page.IsValid)
            {
                en.id_categoria = category;
                en.id_desarrollador = desarrolladora;
                en.nombre = name;
                en.pvp = price;
                en.descripcion = description;
                en.clasificacion = clas;
                en.mostrar = show;

                if (en.updateProducto())
                {
                    Response.Redirect("ProductoAdmin.aspx");
                }
                else
                {
                    Msg.Text = "El nombre introducido ya existe";
                }
            }
        }
    }
}