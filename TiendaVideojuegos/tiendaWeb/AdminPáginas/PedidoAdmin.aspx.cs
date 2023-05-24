﻿using System;
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
            }

            d = pedido.listarPedidos();

            if (d.Tables[0].Rows.Count > 0)
            {
                listView.DataSource = d;
                listView.DataBind();
            }
            else
            {
                textboxVacio.Visible = true;
            }
        }

        protected void ButtonVer(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            string i = myButton.CommandArgument.ToString();

            Response.Redirect("VerPedidoAdmin.aspx?idPedido=" + i);
        }

        protected void ButtonBorrar(object sender, EventArgs e)
        {
            LinkButton myButton = (LinkButton)sender;
            pedido.id = Convert.ToInt32(myButton.CommandArgument.ToString());

            pedido.deletePedido();
            Response.Redirect("PedidoAdmin.aspx");
        }
    }
}