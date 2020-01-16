namespace ComprasCheckBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manzanaCkb = new System.Windows.Forms.CheckBox();
            this.peraCkb = new System.Windows.Forms.CheckBox();
            this.mangoCkb = new System.Windows.Forms.CheckBox();
            this.naranjaCkb = new System.Windows.Forms.CheckBox();
            this.descuentoGrb = new System.Windows.Forms.GroupBox();
            this.unamRbt = new System.Windows.Forms.RadioButton();
            this.martesRbt = new System.Windows.Forms.RadioButton();
            this.noRbt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadMz = new System.Windows.Forms.TextBox();
            this.cantidadPe = new System.Windows.Forms.TextBox();
            this.cantidadMg = new System.Windows.Forms.TextBox();
            this.cantidadNa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descuentoGrb.SuspendLayout();
            this.SuspendLayout();
            // 
            // manzanaCkb
            // 
            this.manzanaCkb.AutoSize = true;
            this.manzanaCkb.Location = new System.Drawing.Point(13, 35);
            this.manzanaCkb.Name = "manzanaCkb";
            this.manzanaCkb.Size = new System.Drawing.Size(95, 17);
            this.manzanaCkb.TabIndex = 0;
            this.manzanaCkb.Text = "manzanas $25";
            this.manzanaCkb.UseVisualStyleBackColor = true;
            this.manzanaCkb.CheckedChanged += new System.EventHandler(this.carrito);
            // 
            // peraCkb
            // 
            this.peraCkb.AutoSize = true;
            this.peraCkb.Location = new System.Drawing.Point(13, 59);
            this.peraCkb.Name = "peraCkb";
            this.peraCkb.Size = new System.Drawing.Size(73, 17);
            this.peraCkb.TabIndex = 1;
            this.peraCkb.Text = "peras $30";
            this.peraCkb.UseVisualStyleBackColor = true;
            this.peraCkb.CheckedChanged += new System.EventHandler(this.carrito);
            // 
            // mangoCkb
            // 
            this.mangoCkb.AutoSize = true;
            this.mangoCkb.Location = new System.Drawing.Point(13, 83);
            this.mangoCkb.Name = "mangoCkb";
            this.mangoCkb.Size = new System.Drawing.Size(84, 17);
            this.mangoCkb.TabIndex = 2;
            this.mangoCkb.Text = "mangos $20";
            this.mangoCkb.UseVisualStyleBackColor = true;
            this.mangoCkb.CheckedChanged += new System.EventHandler(this.carrito);
            // 
            // naranjaCkb
            // 
            this.naranjaCkb.AutoSize = true;
            this.naranjaCkb.Location = new System.Drawing.Point(13, 107);
            this.naranjaCkb.Name = "naranjaCkb";
            this.naranjaCkb.Size = new System.Drawing.Size(87, 17);
            this.naranjaCkb.TabIndex = 3;
            this.naranjaCkb.Text = "naranjas $15";
            this.naranjaCkb.UseVisualStyleBackColor = true;
            this.naranjaCkb.CheckedChanged += new System.EventHandler(this.carrito);
            // 
            // descuentoGrb
            // 
            this.descuentoGrb.Controls.Add(this.unamRbt);
            this.descuentoGrb.Controls.Add(this.martesRbt);
            this.descuentoGrb.Controls.Add(this.noRbt);
            this.descuentoGrb.Location = new System.Drawing.Point(219, 35);
            this.descuentoGrb.Name = "descuentoGrb";
            this.descuentoGrb.Size = new System.Drawing.Size(200, 100);
            this.descuentoGrb.TabIndex = 4;
            this.descuentoGrb.TabStop = false;
            this.descuentoGrb.Text = "Descuentos";
            // 
            // unamRbt
            // 
            this.unamRbt.AutoSize = true;
            this.unamRbt.Location = new System.Drawing.Point(7, 72);
            this.unamRbt.Name = "unamRbt";
            this.unamRbt.Size = new System.Drawing.Size(86, 17);
            this.unamRbt.TabIndex = 2;
            this.unamRbt.Text = "UNAM (10%)";
            this.unamRbt.UseVisualStyleBackColor = true;
            this.unamRbt.CheckedChanged += new System.EventHandler(this.hacerDescuento);
            // 
            // martesRbt
            // 
            this.martesRbt.AutoSize = true;
            this.martesRbt.Location = new System.Drawing.Point(7, 48);
            this.martesRbt.Name = "martesRbt";
            this.martesRbt.Size = new System.Drawing.Size(140, 17);
            this.martesRbt.TabIndex = 1;
            this.martesRbt.Text = "Martes de tianguis (15%)";
            this.martesRbt.UseVisualStyleBackColor = true;
            this.martesRbt.CheckedChanged += new System.EventHandler(this.hacerDescuento);
            // 
            // noRbt
            // 
            this.noRbt.AutoSize = true;
            this.noRbt.Checked = true;
            this.noRbt.Location = new System.Drawing.Point(7, 23);
            this.noRbt.Name = "noRbt";
            this.noRbt.Size = new System.Drawing.Size(93, 17);
            this.noRbt.TabIndex = 0;
            this.noRbt.TabStop = true;
            this.noRbt.Text = "Sin descuento";
            this.noRbt.UseVisualStyleBackColor = true;
            this.noRbt.CheckedChanged += new System.EventHandler(this.hacerDescuento);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(71, 152);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(0, 18);
            this.totalLbl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio x Kilo";
            // 
            // cantidadMz
            // 
            this.cantidadMz.Location = new System.Drawing.Point(115, 35);
            this.cantidadMz.Name = "cantidadMz";
            this.cantidadMz.Size = new System.Drawing.Size(51, 20);
            this.cantidadMz.TabIndex = 8;
            this.cantidadMz.TextChanged += new System.EventHandler(this.validarPrecio);
            // 
            // cantidadPe
            // 
            this.cantidadPe.Location = new System.Drawing.Point(115, 57);
            this.cantidadPe.Name = "cantidadPe";
            this.cantidadPe.Size = new System.Drawing.Size(51, 20);
            this.cantidadPe.TabIndex = 9;
            this.cantidadPe.TextChanged += new System.EventHandler(this.validarPrecio);
            // 
            // cantidadMg
            // 
            this.cantidadMg.Location = new System.Drawing.Point(115, 81);
            this.cantidadMg.Name = "cantidadMg";
            this.cantidadMg.Size = new System.Drawing.Size(51, 20);
            this.cantidadMg.TabIndex = 10;
            this.cantidadMg.TextChanged += new System.EventHandler(this.validarPrecio);
            // 
            // cantidadNa
            // 
            this.cantidadNa.Location = new System.Drawing.Point(115, 105);
            this.cantidadNa.Name = "cantidadNa";
            this.cantidadNa.Size = new System.Drawing.Size(51, 20);
            this.cantidadNa.TabIndex = 11;
            this.cantidadNa.TextChanged += new System.EventHandler(this.validarPrecio);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kilos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 233);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidadNa);
            this.Controls.Add(this.cantidadMg);
            this.Controls.Add(this.cantidadPe);
            this.Controls.Add(this.cantidadMz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descuentoGrb);
            this.Controls.Add(this.naranjaCkb);
            this.Controls.Add(this.mangoCkb);
            this.Controls.Add(this.peraCkb);
            this.Controls.Add(this.manzanaCkb);
            this.Name = "Form1";
            this.Text = "Tienda";
            this.descuentoGrb.ResumeLayout(false);
            this.descuentoGrb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox manzanaCkb;
        private System.Windows.Forms.CheckBox peraCkb;
        private System.Windows.Forms.CheckBox mangoCkb;
        private System.Windows.Forms.CheckBox naranjaCkb;
        private System.Windows.Forms.GroupBox descuentoGrb;
        private System.Windows.Forms.RadioButton unamRbt;
        private System.Windows.Forms.RadioButton martesRbt;
        private System.Windows.Forms.RadioButton noRbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadMz;
        private System.Windows.Forms.TextBox cantidadPe;
        private System.Windows.Forms.TextBox cantidadMg;
        private System.Windows.Forms.TextBox cantidadNa;
        private System.Windows.Forms.Label label3;
    }
}

