using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasCheckBox
{
    public partial class Form1 : Form
    {

        public double Cuenta { get; set; }

        double flag = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void carrito(object sender, EventArgs e)
        {
            calcula();
        }

        private void hacerDescuento(object sender, EventArgs e)
        {
            RadioButton eleccion = sender as RadioButton;
            if (eleccion.Name.ToString() == "martesRbt")
            {
                flag = 0.85;
            }
            else
            {
                if (eleccion.Name.ToString() == "unamRbt")
                {
                    flag = 0.90;
                }else{
                    flag = 1;
                }
            }
            totalLbl.Text = String.Format("{0:C}", Cuenta*flag);
        }

        private void validarPrecio(object sender, EventArgs e)
        {
            calcula();
        }

        private void calcula() {
            try
            {
                Cuenta = 0;
                if (manzanaCkb.Checked == true && cantidadMz.TextLength > 0)
                    Cuenta += (25 * Double.Parse(cantidadMz.Text));
                if (mangoCkb.Checked == true && cantidadMg.TextLength > 0)
                    Cuenta += (20 * Double.Parse(cantidadMg.Text));
                if (peraCkb.Checked == true && cantidadPe.TextLength > 0)
                    Cuenta += (30 * Double.Parse(cantidadPe.Text));
                if (naranjaCkb.Checked == true && cantidadNa.TextLength > 0)
                    Cuenta += (15 * Double.Parse(cantidadNa.Text));
                totalLbl.Text = String.Format("{0:C}", Cuenta * flag);
            }
            catch (Exception e) {
                totalLbl.Text = " Error en ingresar datos";
            }
        }

    }
}
