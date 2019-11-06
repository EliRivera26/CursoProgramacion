using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WailOnLoad a true significa que la imagen se carga de forma sincrónica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();
            if(fd.FileName != string.Empty)
            {
                //pictureBox.Image = Image.FromFile(fd.FileName);
               // pictureBox.Image = Image.FromFile(@"C:\Users\eliza\Desktop\maxresdefault.jpg");
                pictureBox.ImageLocation = fd.FileName;
            }

        }
    }
}
