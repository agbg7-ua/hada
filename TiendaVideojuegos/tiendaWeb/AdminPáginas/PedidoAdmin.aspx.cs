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
    public partial class PedidoAdmin : System.Web.UI.Page
    {
        ENPedido pedido = new ENPedido();
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

            d = pedido.listarPedidos();

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
        /// Botón de ver Pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonVer(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("VerPedidoAdmin.aspx?idPedido=" + i);
        }

        /// <summary>
        /// Botón de borrar Pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBorrar(object sender, EventArgs e)
        {
            // Recogemos el id del pedido seleccionado
            LinkButton myButton = (LinkButton)sender;
            pedido.id = Convert.ToInt32(myButton.CommandArgument.ToString());

            // Llamamos al EN de eliminar pedido
            pedido.deletePedido();
            Response.Redirect("PedidoAdmin.aspx");
        }
    }
}