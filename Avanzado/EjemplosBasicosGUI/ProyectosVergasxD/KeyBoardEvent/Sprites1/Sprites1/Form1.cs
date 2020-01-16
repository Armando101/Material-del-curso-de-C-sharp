using System;
using System.Drawing;   // Added
using System.Media; // Added
using System.Windows.Forms;

namespace Sprites1
{
    public partial class FormEscenario : Form
    {
        /*Para evitar que un Form cambie de tamaño es necesario colocar la
         * propiedad BorderStyle = FixedSingle
         */
        
        //Clase Keys asigna un codigo a cada tecla
        private Keys direccion;
        //Obtenemos las imagenes de link
        private Image imgA = Sprites1.Properties.Resources.link7;
        private Image imgB = Sprites1.Properties.Resources.link8;
        //Obtenemos el sonido a mostrar
        private SoundPlayer sound = new SoundPlayer(Sprites1.Properties.Resources.LOZnesitem);
        //Variables auxiliares que usaremos para el movimiento del muñeco
        private bool usandoImgA = true;
        private bool walked = false;
        private bool played = false;

        public FormEscenario()
        {
            InitializeComponent();
        }

        private void Form1Escenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                // KeyCode: enumeración que contiene los códigos de las teclas
                direccion = e.KeyCode;

                // Bandera que indica el inicio de caminar
                walked = true;
            }
        }

        //Evento asocidado al timer, este evento se lanzara cada determinado tiempo, de acuero al timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (walked)
            {
                switch (direccion)
                {
                    case Keys.Down:
                        // Actualiza las imágenes temporales
                        // según la dirección
                        imgA = Sprites1.Properties.Resources.link1;
                        imgB = Sprites1.Properties.Resources.link2;

                        // Restricción sobre los pixeles
                        //Y: recibe el parametro int con respecto a Y
                        //Size: Estructura que almacena altura y ancho de un objeto determinado.
                        if (Link.Location.Y < (440 - Link.Size.Height))
                            // Para mover se sobreescribe Location
                            // creando una nueva estructura Point, define
                            // las cooredenadas en las que situra la imagen
                            Link.Location = new Point(Link.Location.X, Link.Location.Y + 10);
                        break;
                    case Keys.Left:
                        imgA = Sprites1.Properties.Resources.link3;
                        imgB = Sprites1.Properties.Resources.link4;
                        //Recordar que link location tine como origen la esquina superior izquierda
                        if(Link.Location.X>50)
                            Link.Location = new Point(Link.Location.X - 10, Link.Location.Y);
                        break;
                    case Keys.Right:
                        imgA = Sprites1.Properties.Resources.link5;
                        imgB = Sprites1.Properties.Resources.link6;
                        if (Link.Location.X < (490 - Link.Size.Width))
                            Link.Location = new Point(Link.Location.X + 10, Link.Location.Y);
                        break;
                    case Keys.Up:
                        imgA = Sprites1.Properties.Resources.link7;
                        imgB = Sprites1.Properties.Resources.link8;
                        if(Link.Location.Y>60)
                            Link.Location = new Point(Link.Location.X, Link.Location.Y - 10);
                        break;
                }

                if (Link.Location.Y<125 && Link.Location.X>180 && Link.Location.X<(200+Chest.Width))
                {
                    if (!played)
                    {
                        Chest.Visible = false;
                        sound.Play();
                        played = true;
                    }
                }

                // Alterna las imágenes imgA e imgB
                if (usandoImgA)
                {
                    Link.Image = imgB;
                    usandoImgA = false;
                }
                else
                {
                    Link.Image = imgA;
                    usandoImgA = true;
                }
            }
        }

        private void FormEscenario_KeyUp(object sender, KeyEventArgs e)
        {
            // bandera que indice que se terminó de caminar
            // (soltar la tecla)
            walked = false;
        }
    }
}
