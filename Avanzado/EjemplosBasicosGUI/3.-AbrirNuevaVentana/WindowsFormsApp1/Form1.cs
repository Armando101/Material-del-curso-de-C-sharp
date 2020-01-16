using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola como estas!!","Mensaje de bienvenida");
        }

        private void despedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto", "Mensaje de despedida");
        }

        private void buscadorArchivos(object sender, EventArgs e)
        {
            string directorio = "C:\\Users\\arman\\Documents";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = directorio;
        /*  Para cada una de las opciones de filtrado, la cadena de filtro contiene una descripción del filtro, seguida de la barra vertical (|) y el modelo de filtro. Las cadenas de las diferentes opciones de filtrado se separan mediante la barra vertical.
            A continuación se muestra un ejemplo de una cadena de filtro:
            Text files (*.txt)|*.txt|All files (*.*)|*.*
            Se pueden agregar varios modelos de filtro a un filtro separando los tipos de archivo con puntos y comas; por ejemplo:
            Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*
        */
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            //FilterIndex, indica el filtro a tomar en cuenta de Filter
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
        }
    }
}
