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
    public partial class OfertaAdmin : System.Web.UI.Page
    {
        ENProducto enp = new ENProducto();
        protected void Page_Load(object sender, EventArgs e)
        {
            // get a list of all products
            ENUsuario usu = new ENUsuario();
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
                DataSet ds = new DataSet();
                ds = enp.showAllProducto();
                DropDownList_juego_1.DataSource = ds;
                DropDownList_juego_1.DataTextField = "nombre";
                DropDownList_juego_1.DataValueField = "id";
                DropDownList_juego_1.DataBind();

                DropDownList_juego_2.DataSource = ds;
                DropDownList_juego_2.DataTextField = "nombre";
                DropDownList_juego_2.DataValueField = "id";
                DropDownList_juego_2.DataBind();

                DropDownList_juego_3.DataSource = ds;
                DropDownList_juego_3.DataTextField = "nombre";
                DropDownList_juego_3.DataValueField = "id";
                DropDownList_juego_3.DataBind();

                ENOferta o1 = new ENOferta();
                o1.id = 1;
                ENOferta o2 = new ENOferta();
                o2.id = 2;
                ENOferta o3 = new ENOferta();
                o3.id = 3;
                o1.readOferta();
                o2.readOferta();
                o3.readOferta();

                float porcentaje;
                int final;

                enp.id = o1.id_producto;
                enp.readProducto();
                DropDownList_juego_1.SelectedIndex = DropDownList_juego_1.Items.IndexOf(DropDownList_juego_1.Items.FindByText(enp.nombre));
                porcentaje = o1.oferta*100 / enp.pvp;
                final = 100 - (int)porcentaje;
                TextBox_precio_1.Text = final.ToString();

                enp.id = o2.id_producto;
                enp.readProducto();
                DropDownList_juego_2.SelectedIndex = DropDownList_juego_2.Items.IndexOf(DropDownList_juego_2.Items.FindByText(enp.nombre));
                porcentaje = o2.oferta * 100 / enp.pvp;
                final = 100 - (int)porcentaje;
                TextBox_precio_2.Text = final.ToString();

                enp.id = o3.id_producto;
                enp.readProducto();
                DropDownList_juego_3.SelectedIndex = DropDownList_juego_3.Items.IndexOf(DropDownList_juego_3.Items.FindByText(enp.nombre));
                porcentaje = o3.oferta * 100 / enp.pvp;
                final = 100 - (int)porcentaje;
                TextBox_precio_3.Text = final.ToString();

            }




        }

        protected void ButtonVolver(object sender, EventArgs e)
        {
            Response.Redirect("../Admin.aspx");
        }



        protected void Button_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin.aspx");
        }

        protected void Guardar_1_Click(object sender, EventArgs e)
        {
            try
            {

                ENOferta eno = new ENOferta();
                eno.oferta = float.Parse(TextBox_precio_1.Text);
                eno.id_producto = (int)enp.searchByNameProducto(DropDownList_juego_1.SelectedItem.Text).Tables[0].Rows[0][0];
                eno.primeraOferta(enp, (int)eno.oferta);
                Label_info.Text = "Oferta guardada";
            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }

        }

        protected void Borrar_1_Click(object sender, EventArgs e)
        {
            try
            {
                ENOferta eno = new ENOferta();
                eno.id = 1;
                eno.borrar();

            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Guardar_2_Click(object sender, EventArgs e)
        {
            try
            {

                ENOferta eno = new ENOferta();
                eno.oferta = float.Parse(TextBox_precio_2.Text);
                eno.id_producto = (int)enp.searchByNameProducto(DropDownList_juego_2.SelectedItem.Text).Tables[0].Rows[0][0];
                eno.segundaOferta(enp, (int)eno.oferta);
                Label_info.Text = "Oferta guardada";
            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }
        }

        protected void Borrar_2_Click(object sender, EventArgs e)
        {
            try
            {
                ENOferta eno = new ENOferta();
                eno.id = 2;
                eno.borrar();

            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }
        }

        protected void Guardar_3_Click(object sender, EventArgs e)
        {
            try
            {

                ENOferta eno = new ENOferta();
                eno.oferta = float.Parse(TextBox_precio_3.Text);
                eno.id_producto = (int)enp.searchByNameProducto(DropDownList_juego_3.SelectedItem.Text).Tables[0].Rows[0][0];
                eno.terceraOferta(enp, (int)eno.oferta);
                Label_info.Text = "Oferta guardada";
            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }
        }

        protected void Borrar_3_Click(object sender, EventArgs e)
        {
            try
            {
                ENOferta eno = new ENOferta();
                eno.id = 3;
                eno.borrar();

            }
            catch (Exception ex)
            {
                Label_info.Text = ex.Message;
            }
        }
    }
}