using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoFechas
{
    public partial class Form1 : Form
    {
        DateTime fecha, hoy;
        double pagar;

        public Form1()
        {
            InitializeComponent();
            pagar = double.Parse(costoLbl.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
            (sender as LinkLabel).LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
            (sender as LinkLabel).LinkVisited = true;
        }

        private void calendario_ValueChanged(object sender, EventArgs e)
        {
            fecha = calendario.Value;
            hoy = DateTime.Now;
            // TimeSpan para ver diferencia en días, horas, y minutos
            TimeSpan dif = fecha - hoy;
            double costo = pagar;

            if (dif.Days > 1)
            {
                if(dif.Days >3)
                    costo = pagar * Math.Pow(0.95, dif.Days);

                totalLbl.Text = string.Format("{0:C}",costo);
            }
            else {
                MessageBox.Show("No se puede entregar en menos de dos días");
            }
            
        }
    }
}
