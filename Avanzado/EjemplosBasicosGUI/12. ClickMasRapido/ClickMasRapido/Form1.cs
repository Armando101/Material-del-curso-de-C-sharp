using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClickMasRapido
{
    public partial class Form1 : Form
    {
        public int Contador { get; set; }
        public DateTime inicio;
        public Thread hilo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            if (Contador == 0) {
                // Dando Metodo a correr al hilo
                //hilo = new Thread(new ThreadStart(Segundero));
                // Iniciando el hilo
                //hilo.Start();
                segundos.RunWorkerAsync();
                inicio = DateTime.Now;
            }

            if (DateTime.Now.Subtract(inicio).Seconds == 10)
            {
                clickBtn.Enabled = false;
                //hilo.Abort();
                restartBtn.Enabled = true;
            }
            else {
                Contador++;
                contadorLbl.Text = "Clicks: " + Contador;
            }

        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Contador = 0;
            contadorLbl.Text = "Clicks: "+Contador;
            segundosLbl.Text = "Segundos: ";
            clickBtn.Enabled = true;
            restartBtn.Enabled = false;
        }

        private void segundos_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                segundos.ReportProgress(i);
                Thread.Sleep(1000);
            }
        }

        private void segundos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //segundosLbl.Text = "Segundos: " + e.ProgressPercentage;
            segundosLbl.Text = "Segundos: " + DateTime.Now.ToLongTimeString();
        }

        private void segundos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("El numero de clicks es: " + Contador,"Finalizado");
        }
    }
}
