using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound = new SoundPlayer("C:/Users/arman/Documents/PROTECO/C#/Avanzado/ProyectosVergasxD/KeyBoardEvent/Monos/SoundTrack.wav");
        public Keys direccion;
        public bool atacar;
        public bool caminar = false;
        public bool cofre = true;
        public Image imgA= Properties.Resources.link1;
        public Image imgB = Properties.Resources.link2;
        public bool usandoImgA = true;

        public Form1()
        {
            InitializeComponent();
            bala.Visible = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            caminar = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (caminar)
            {
                switch (direccion)
                {
                    case Keys.Left:
                        imgA = Properties.Resources.link3;
                        imgB = Properties.Resources.link4;
                        if (personaje.Location.X > 40)
                        {
                            personaje.Location = new Point(personaje.Location.X - 10, personaje.Location.Y);
                        }
                        break;
                    case Keys.Right:
                        imgA = Properties.Resources.link5;
                        imgB = Properties.Resources.link6;
                        if (personaje.Location.X < (500 - personaje.Size.Width))
                        {
                            personaje.Location = new Point(personaje.Location.X + 10, personaje.Location.Y);
                        }
                        break;
                    case Keys.Up:
                        imgA = Properties.Resources.link7;
                        imgB = Properties.Resources.link8;
                        if (personaje.Location.Y > 40)
                        {
                            personaje.Location = new Point(personaje.Location.X, personaje.Location.Y - 10);
                        }
                        break;
                    case Keys.Down:
                        imgA = Properties.Resources.link1;
                        imgB = Properties.Resources.link2;
                        if (personaje.Location.Y < (500 - personaje.Size.Height))
                        {
                            personaje.Location = new Point(personaje.Location.X, personaje.Location.Y + 10);
                        }
                        break;
                }
                if ((personaje.Location.Y > chest.Location.Y) && (personaje.Location.Y < (chest.Location.Y + chest.Height)) && (personaje.Location.X > chest.Location.X) && cofre && (personaje.Location.X < (chest.Location.X + chest.Size.Width)))
                {
                    chest.Visible = false;
                    cofre = false;
                    sound.Play();

                }
                if (usandoImgA)
                {
                    personaje.Image = imgB;
                    usandoImgA = false;
                }
                else
                {
                    personaje.Image = imgA;
                    usandoImgA = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // e sera el objeto que lanze el evento, en este caso el direcciondo y el mouse
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                // KeyCode: enumeración que contiene los códigos de las direccions
                direccion = e.KeyCode;

                // Bandera que indica el inicio de caminar
                caminar = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                atacar = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (atacar && (bala.Location.X > 0))
            {
                bala.Location = new Point(bala.Location.X - 10, bala.Location.Y);
                bala.Visible = true;
            }
            else
            {
                bala.Location = new Point(personaje.Location.X, personaje.Location.Y + 30);
                bala.Visible = false;
                atacar = false;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cofre = true;
            chest.Visible = true;
        }

        private void callaTuJaladaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}
