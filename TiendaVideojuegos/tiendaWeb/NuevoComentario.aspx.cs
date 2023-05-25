using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Globalization;

namespace tiendaWeb
{
    public partial class NuevoComentario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENComentario com = new ENComentario();
            com.date = DateTime.Now;
            com.id = 1;
            com.text = TextBox1.Text;
            com.valoracion = 5;

            if (com.createComentario())
            {

            }
            else
            {
                outputMsg.Text = "Falta algún dato o alguno introducido es incorrecto";
            }
        }
        protected void RatingChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedStarId = radioButton.ID;
            int selectedScore = Convert.ToInt32(radioButton.Text);

            // Clear all star images
            ClearAllStarImages();

            // Set the selected star image to full
            Image selectedStarImage = (Image)FindControlRecursive(Page, "starImage" + selectedStarId);
            if (selectedStarImage != null)
            {
                selectedStarImage.ImageUrl = "Imagenes/full-star.png"; // Replace with the path to your full star image

                // Store the selected score in a variable, session, database, or any other desired location
                // For example, you can store it in a session variable:
                Session["SelectedScore"] = selectedScore;
            }
        }

        private void ClearAllStarImages()
        {
            foreach (Control control in Page.Controls)
            {
                ClearStarImagesRecursive(control);
            }
        }

        private void ClearStarImagesRecursive(Control control)
        {
            if (control is Image image && image.ID.StartsWith("starImage"))
            {
                image.ImageUrl = "Imagenes/empty-star.png"; // Replace with the path to your empty star image
            }

            foreach (Control childControl in control.Controls)
            {
                ClearStarImagesRecursive(childControl);
            }
        }

        private Control FindControlRecursive(Control control, string id)
        {
            if (control.ID == id)
            {
                return control;
            }

            foreach (Control childControl in control.Controls)
            {
                Control foundControl = FindControlRecursive(childControl, id);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }

            return null;
        }
    }
}