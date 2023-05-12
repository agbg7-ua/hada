using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using library;

namespace tiendaWeb
{
    public partial class LineaPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            ENLineaPedido en = new ENLineaPedido();
            if (IDLBox.Text == "" || IDPedBox.Text == "" || IDProdBox.Text == "" || CantBox.Text == "" || ImportBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id_pedido = int.Parse(IDPedBox.Text);
                en.id_linea = int.Parse(IDLBox.Text);
                en.id_producto = int.Parse(IDProdBox.Text);
                en.cantidad = int.Parse(CantBox.Text);
                en.importe = int.Parse(ImportBox.Text);
                if (!en.readLineaPedido())
                {
                    en.createLineaPedido();
                    resLabel.Text = "Linea de Pedido creada";
                }
                else
                {
                    resLabel.Text = "No se puede crear la línea de pedido";
                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ENLineaPedido en = new ENLineaPedido();
            if (IDLBox.Text == "" || IDPedBox.Text == "" || IDProdBox.Text == "" || CantBox.Text == "" || ImportBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id_pedido = int.Parse(IDPedBox.Text);
                en.id_linea = int.Parse(IDLBox.Text);
                en.id_producto = int.Parse(IDProdBox.Text);
                en.cantidad = int.Parse(CantBox.Text);
                en.importe = int.Parse(ImportBox.Text);
                if (en.readLineaPedido())
                {
                    en.updateLineaPedido();
                    resLabel.Text = "Línea de pedido actualizada";
                }
                else
                {
                    resLabel.Text = "No se puede actualizar la línea de pedido";
                }
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ENLineaPedido en = new ENLineaPedido();
            if (IDLBox.Text == "" || IDPedBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id_pedido = int.Parse(IDPedBox.Text);
                en.id_linea = int.Parse(IDLBox.Text);
                if (en.deleteLineaPedido())
                {
                    resLabel.Text = "Línea de pedido borrada";
                }
                else
                {
                    resLabel.Text = "No se puede borrar la línea de pedido";
                }
            }
        }

        protected void ButtonAllPed_Click(object sender, EventArgs e)
        {
            ENLineaPedido en = new ENLineaPedido();
            ENPedido enP = new ENPedido();
            if (IDPedBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id_pedido = int.Parse(IDPedBox.Text);
                enP.id = int.Parse(IDPedBox.Text);
                DataSet ds = new DataSet();
                ds = en.listaLineasPedido(enP);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    listaLineasPedido.DataSource = ds;
                    listaLineasPedido.DataBind();
                }
            }
        }

        protected void ButtonAllProd_Click(object sender, EventArgs e)
        {

        }
    }
}