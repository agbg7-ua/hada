﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb
{
    public partial class ListarProductoCategoría : System.Web.UI.Page
    {
        ENCategoriaProducto enCat = new ENCategoriaProducto();
        ENProducto enProd = new ENProducto();
        DataSet d = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                ddlTest_SelectedIndexChanged(this, e);
            }
        }
        
        // Recoger género seleccionado
        protected void catchId()
        {
            enCat.id = Convert.ToInt32(Request.Params["idCat"]);

            // Poner título específico
            enCat.readCategoriaProducto();
            titulo.Text = "Videojuegos del Género " + enCat.nombre;
        }
        
        // Dropdownlist --> opción seleccionada
        protected void ddlTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            catchId();

            if (ddlTest.SelectedValue == "2")
            {
                d = enProd.showOrderByNameDESCProducto(enCat);
            }
            else if (ddlTest.SelectedValue == "3")
            {
                d = enProd.showOrderByPriceASCProducto(enCat);
            }
            else if (ddlTest.SelectedValue == "4")
            {
                d = enProd.showOrderByPriceDESCProducto(enCat);
            }
            else 
            {
                d = enProd.showOrderByNameASCProducto(enCat);
            }

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

        protected void Buttons(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                LinkButton comprar = (LinkButton)dataItem.FindControl("comprar");

                if (Session["username"] != null)
                {
                    comprar.Visible = true;
                }
                else
                {
                    comprar.Visible = false;
                }
            }
        }
    }
}