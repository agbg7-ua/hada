﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace tiendaWeb
{
    public partial class Desarrrolador : System.Web.UI.Page
    {

        // datos de ejemplo

        string nombre = "nombre";
        string descripcion = @"
            Counter-Strike es una serie de videojuegos tácticos multijugador de disparos en primera persona en 
            los que equipos de terroristas luchan para perpetrar un acto terrorista mientras
            los contraterroristas intentan prevenirlo. La serie comenzó en Windows en 1999 
            con el lanzamiento del primer juego, Counter-Strike.
            ";

        DateTime fecha = System.DateTime.Now;
        string web = "www.counter-strike.net";
        string origen = "Estados Unidos";

        static bool edit_mode = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TextBox_descripcion.Visible = false;
            TextBox_fecha.Visible = false;
            TextBox_nombre.Visible = false;
            TextBox_web.Visible = false;
            TextBox_origen.Visible = false;
            Button_nuevo.Visible = false;
            Button_eliminar.Visible = false;


            Label_nombre.Text = nombre;
            Label_descripcion.Text = descripcion;
            Label_fecha.Text = fecha.ToString();
            Label_web.Text = web;
            Label_origen.Text = origen;

            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button_editar_Click(object sender, EventArgs e)
        {
            if (edit_mode == false)
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
            } else
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
            }
            edit_mode = !edit_mode;

        }

        protected void TextBox_descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}