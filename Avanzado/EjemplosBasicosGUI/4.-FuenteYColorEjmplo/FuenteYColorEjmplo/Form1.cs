using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuenteYColorEjmplo
{
    public partial class Form1 : Form
    {
        string textoF = "La fuente es: ";
        string textoC = "El color es: ";
        public Form1()
        {
            InitializeComponent();
            labelF.Text = textoF + mensajeMostrado.Font.Name;
            labelC.Text = textoC + mensajeMostrado.ForeColor.Name;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mensajeMostrado.Font = dlg.Font;
                labelF.Text = textoF + mensajeMostrado.Font.Name;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mensajeMostrado.ForeColor = dlg.Color;
                labelC.Text = textoC + mensajeMostrado.ForeColor.Name;
            }
        }

        private void mensajeOriginal(object sender, EventArgs e)
        {
            mensajeMostrado.Text = "qUE OndAa que PeXx";
        }

        private void mensajeCambiado(object sender, MouseEventArgs e)
        {
            mensajeMostrado.Text = "Puntero sobre mi :)";
        }
    }
}
