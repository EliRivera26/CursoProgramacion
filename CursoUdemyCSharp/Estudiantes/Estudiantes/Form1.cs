using Logic;
using Logic.Library;
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
        private LEstudiantes estudiante;
        //private Librarys librarys;
        public Form1()
        {
            InitializeComponent();
            //librarys = new Librarys();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBox3Nid);
            listTextBox.Add(textBox1Nombre);
            listTextBox.Add(textBox2Apellido);
            listTextBox.Add(textBox1Email);
            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            Object[] objetos = { 
                fotoEstudiante,
                Properties.Resources.maxresdefault,
                dataGridView1
            };
            estudiante = new LEstudiantes(listTextBox, listLabel, objetos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 //           InitializeComponent();
        }

        private void PictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadimage.CargarImagen(fotoEstudiante);
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
        private void TextBox3Nid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void TextBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void TextBox2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }
        private void ButtonAgrerar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }

        private void textBox1Buscar_TextChanged(object sender, EventArgs e)
        {
            estudiante.SearchEstudiante(textBox1Buscar.Text);
        }
    }
}
