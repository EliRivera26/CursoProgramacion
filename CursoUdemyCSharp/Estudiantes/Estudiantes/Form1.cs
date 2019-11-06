using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante = new LEstudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 //           InitializeComponent();
        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.CargarImagen(fotoEstudiante);
        }

        private void TextBox3Nid_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3Nid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "Nid";
            }
        }

        private void TextBox1Nombre_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Nombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void TextBox2Apellido_TextChanged(object sender, EventArgs e)
        {
            if (textBox2Apellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }

        }

        private void TextBox1Email_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Email.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "E-mail";
            }
        }

        private void TextBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox1Email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3Nid_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3Nid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "Nid";
            }
        }

        private void textBox3Nid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox3Nid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}
