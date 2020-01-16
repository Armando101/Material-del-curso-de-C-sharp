using System;
using System.Windows.Forms;

namespace PrimerChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sender, objeto que lanzo el evento, e, objeto que lanzo el evento, pero encapsula propiedades de rapido uso.
        private void graficarBtn_Click(object sender, EventArgs e)
        {
            // Limpiar la gráfica, limpiamos cada una de las series que tenga
            foreach (var serie in grafica.Series)
                serie.Points.Clear();

            // Clase para generar números aleatorios
            Random num = new Random();
            int random;

            // Recorrer el CheckedListBox
            for (int i = 0; i < materiasCLB.Items.Count; i++)
            {
                // Para cada materia genero un nuevo número aleatorio
                random = num.Next(1,100);
                // Ver si sus elementos estan checados
                if (materiasCLB.GetItemChecked(i))
                {
                    // Cadena para agregar el elemento a la gráfica
                    string str = materiasCLB.Items[i].ToString();

                    /*Series = nombre que aparece en el recuadro superior derecho
                     *Points = puntos del grafico
                     *Add = Nombre eje X, valor en eje Y.
                     */
                    grafica.Series["Reprobados"].Points.AddXY(str,random);
                    grafica.Series["Aprobados"].Points.AddXY(str, 100 - random);
                }
            }
        }

        //Evento que se lanza cuando cambia el check en el radioButton
        private void lineaRdB_CheckedChanged(object sender, KeyEventArgs e)
        {
            if((sender as RadioButton).Name.Equals("columnaRdB"))
                foreach (var item in grafica.Series)
                    item.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            else
                foreach (var item in grafica.Series)
                    item.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }
    }
}
