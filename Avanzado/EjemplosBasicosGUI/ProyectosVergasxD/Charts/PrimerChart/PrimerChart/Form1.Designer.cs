namespace PrimerChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materiasCLB = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lineaRdB = new System.Windows.Forms.RadioButton();
            this.columnaRdB = new System.Windows.Forms.RadioButton();
            this.graficarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafica
            // 
            this.grafica.BackColor = System.Drawing.Color.Transparent;
            this.grafica.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.grafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grafica.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(12, 111);
            this.grafica.Name = "grafica";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Reprobados";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Aprobados";
            this.grafica.Series.Add(series1);
            this.grafica.Series.Add(series2);
            this.grafica.Size = new System.Drawing.Size(467, 242);
            this.grafica.TabIndex = 0;
            this.grafica.Text = "chart1";
            // 
            // materiasCLB
            // 
            this.materiasCLB.FormattingEnabled = true;
            this.materiasCLB.Items.AddRange(new object[] {
            "Álgebra",
            "Cálculo",
            "Dibujo",
            "Progra. A.",
            "Quimica"});
            this.materiasCLB.Location = new System.Drawing.Point(12, 7);
            this.materiasCLB.Name = "materiasCLB";
            this.materiasCLB.Size = new System.Drawing.Size(145, 94);
            this.materiasCLB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lineaRdB);
            this.groupBox1.Controls.Add(this.columnaRdB);
            this.groupBox1.Location = new System.Drawing.Point(173, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // lineaRdB
            // 
            this.lineaRdB.AutoSize = true;
            this.lineaRdB.Location = new System.Drawing.Point(6, 37);
            this.lineaRdB.Name = "lineaRdB";
            this.lineaRdB.Size = new System.Drawing.Size(51, 17);
            this.lineaRdB.TabIndex = 1;
            this.lineaRdB.Text = "Linea";
            this.lineaRdB.UseVisualStyleBackColor = true;
            this.lineaRdB.CheckedChanged += new System.EventHandler(this.lineaRdB_CheckedChanged);
            // 
            // columnaRdB
            // 
            this.columnaRdB.AutoSize = true;
            this.columnaRdB.Checked = true;
            this.columnaRdB.Location = new System.Drawing.Point(7, 20);
            this.columnaRdB.Name = "columnaRdB";
            this.columnaRdB.Size = new System.Drawing.Size(66, 17);
            this.columnaRdB.TabIndex = 0;
            this.columnaRdB.TabStop = true;
            this.columnaRdB.Text = "Columna";
            this.columnaRdB.UseVisualStyleBackColor = true;
            this.columnaRdB.CheckedChanged += new System.EventHandler(this.lineaRdB_CheckedChanged);
            // 
            // graficarBtn
            // 
            this.graficarBtn.Location = new System.Drawing.Point(180, 78);
            this.graficarBtn.Name = "graficarBtn";
            this.graficarBtn.Size = new System.Drawing.Size(75, 23);
            this.graficarBtn.TabIndex = 3;
            this.graficarBtn.Text = "Graficar";
            this.graficarBtn.UseVisualStyleBackColor = true;
            this.graficarBtn.Click += new System.EventHandler(this.graficarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 365);
            this.Controls.Add(this.graficarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materiasCLB);
            this.Controls.Add(this.grafica);
            this.Name = "Form1";
            this.Text = "Grafica Simple";
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.CheckedListBox materiasCLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lineaRdB;
        private System.Windows.Forms.RadioButton columnaRdB;
        private System.Windows.Forms.Button graficarBtn;
    }
}

