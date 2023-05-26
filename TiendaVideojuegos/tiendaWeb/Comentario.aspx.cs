using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using library;

namespace tiendaWeb
{
    public partial class Oferta : System.Web.UI.Page
    {
        ENComentario comentario = new ENComentario();
        ENProducto producto = new ENProducto();
        DataSet d = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["idProd"] != null)
            {
                string idProducto = Request.Params["idProd"];
                producto.id = Convert.ToInt32(idProducto);
                producto.readProducto();
                descText.Text = producto.descripcion;
                nameText.Text = producto.nombre;
                myImage.ImageUrl = producto.imagen;
                d = comentario.showAll(producto);
            }
        }
        protected void comentButton(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            string producto;
            if(Request.QueryString["idProd"] != null)
            {
                producto = Request.Params["idProd"];
                Session["Datos1"] = producto;
            }
            Response.Redirect("~/NuevoComentario.aspx");
        }

        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlTest.SelectedValue == "1")
            {
                ENComentario com = new ENComentario();
                com.valoracion = 1;
                d = comentario.filterValoracion(com);
            }
            else if (ddlTest.SelectedValue == "2")
            {
                ENComentario com = new ENComentario();
                com.valoracion = 2;
                d = comentario.filterValoracion(com);
            }
            else if (ddlTest.SelectedValue == "3")
            {
                ENComentario com = new ENComentario();
                com.valoracion = 3;
                d = comentario.filterValoracion(com);
            }
            else if (ddlTest.SelectedValue == "4")
            {
                ENComentario com = new ENComentario();
                com.valoracion = 4;
                d = comentario.filterValoracion(com);
            }
            else
            {
                ENComentario com = new ENComentario();
                com.valoracion = 5;
                d = comentario.filterValoracion(com);
            }

            if ((d.Tables.Count != 0) && (d.Tables[0].Rows.Count > 0))
            {
                gridView.DataSource = d;
                gridView.DataBind();
            }
            else
            {

                outputMsg.Text = " No se encontraron comentarios con las características especificadas";
            }
        }
    }
}