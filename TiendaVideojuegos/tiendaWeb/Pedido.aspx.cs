using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace tiendaWeb
{
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            ENPedido en = new ENPedido();
            if (IDBox.Text == "" || DateBox.Text == "" || ITotalBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id = int.Parse(IDBox.Text);
                en.fecha = DateTime.Parse(DateBox.Text);
                en.importe_total = double.Parse(ITotalBox.Text);
                if (UserBox.Text != "")
                {
                    en.id_usuario = int.Parse(UserBox.Text);
                }
                if (!en.readPedido())
                {
                    en.createPedido();
                    resLabel.Text = "Pedido creado";
                }
                else
                {
                    resLabel.Text = "No se puede crear el pedido";
                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ENPedido en = new ENPedido();
            if (IDBox.Text == "" || DateBox.Text == "" || ITotalBox.Text == "")
            {
                resLabel.Text = "DATOS VACÍOS";
            }
            else
            {
                en.id = int.Parse(IDBox.Text);
                en.fecha = DateTime.Parse(DateBox.Text);
                en.importe_total = double.Parse(ITotalBox.Text);
                if (UserBox.Text != "")
                {
                    en.id_usuario = int.Parse(UserBox.Text);
                }
                if (!en.updatePedido())
                {
                    en.updatePedido();
                }
                else
                {
                    resLabel.Text = "No se pudo actualizar el pedido";
                }
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ENPedido en = new ENPedido();
            if (IDBox.Text == "")
            {
                resLabel.Text = "ID VACÍA";
            }
            else
            {
                en.id = int.Parse(IDBox.Text);
                if (en.deletePedido())
                {
                    resLabel.Text = "Pedido eliminado";
                }
                else
                {
                    resLabel.Text = "No se pudo eliminar el pedido";
                }
            }
        }

        protected void ButtonAll_Click(object sender, EventArgs e)
        {
            ENPedido en = new ENPedido();
            DataSet ds = new DataSet();
            ds = en.listarPedidos();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ListaPedidos.DataSource = ds;
                ListaPedidos.DataBind();
            }
        }

        protected void ButtonAsc_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonDesc_Click(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}