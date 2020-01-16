namespace Juego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chest = new System.Windows.Forms.PictureBox();
            this.personaje = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bala = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opciones = new System.Windows.Forms.MenuStrip();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callaTuJaladaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bala)).BeginInit();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // chest
            // 
            this.chest.BackColor = System.Drawing.Color.Transparent;
            this.chest.Image = global::Juego.Properties.Resources.chest;
            this.chest.Location = new System.Drawing.Point(234, 364);
            this.chest.Name = "chest";
            this.chest.Size = new System.Drawing.Size(53, 42);
            this.chest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chest.TabIndex = 2;
            this.chest.TabStop = false;
            // 
            // personaje
            // 
            this.personaje.BackColor = System.Drawing.Color.Transparent;
            this.personaje.Image = global::Juego.Properties.Resources.link1;
            this.personaje.Location = new System.Drawing.Point(234, 69);
            this.personaje.Name = "personaje";
            this.personaje.Size = new System.Drawing.Size(51, 67);
            this.personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.personaje.TabIndex = 3;
            this.personaje.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // bala
            // 
            this.bala.BackColor = System.Drawing.Color.Transparent;
            this.bala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bala.Image = global::Juego.Properties.Resources.bala;
            this.bala.Location = new System.Drawing.Point(234, 84);
            this.bala.Name = "bala";
            this.bala.Size = new System.Drawing.Size(22, 20);
            this.bala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bala.TabIndex = 4;
            this.bala.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // opciones
            // 
            this.opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.opciones.Location = new System.Drawing.Point(0, 0);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(521, 24);
            this.opciones.TabIndex = 7;
            this.opciones.Text = "menuStrip1";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.callaTuJaladaToolStripMenuItem});
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.reiniciarToolStripMenuItem.Text = "Opciones";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // callaTuJaladaToolStripMenuItem
            // 
            this.callaTuJaladaToolStripMenuItem.Name = "callaTuJaladaToolStripMenuItem";
            this.callaTuJaladaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.callaTuJaladaToolStripMenuItem.Text = "Calla tu jalada";
            this.callaTuJaladaToolStripMenuItem.Click += new System.EventHandler(this.callaTuJaladaToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Juego.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(521, 497);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.bala);
            this.Controls.Add(this.personaje);
            this.Controls.Add(this.chest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.opciones;
            this.Name = "Form1";
            this.Text = "  MiPrimerJuego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.chest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bala)).EndInit();
            this.opciones.ResumeLayout(false);
            this.opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox chest;
        private System.Windows.Forms.PictureBox personaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bala;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip opciones;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callaTuJaladaToolStripMenuItem;
    }
}

