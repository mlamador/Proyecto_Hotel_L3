namespace ProyectoHotel_Lengua3
{
    partial class FormReportes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.habitacionesOcupadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasPorTiempoRentadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeGananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesOcupadasToolStripMenuItem,
            this.gananciasPorTiempoRentadoToolStripMenuItem,
            this.pagoDeDeudasToolStripMenuItem,
            this.totalDeGananciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gananciasPorTiempoRentadoToolStripMenuItem
            // 
            this.gananciasPorTiempoRentadoToolStripMenuItem.Name = "gananciasPorTiempoRentadoToolStripMenuItem";
            this.gananciasPorTiempoRentadoToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.gananciasPorTiempoRentadoToolStripMenuItem.Text = "Ganancias por tiempo rentado";
            this.gananciasPorTiempoRentadoToolStripMenuItem.Click += new System.EventHandler(this.gananciasPorTiempoRentadoToolStripMenuItem_Click);
            // 
            // pagoDeDeudasToolStripMenuItem
            // 
            this.pagoDeDeudasToolStripMenuItem.Name = "pagoDeDeudasToolStripMenuItem";
            this.pagoDeDeudasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.pagoDeDeudasToolStripMenuItem.Text = "Pago de deudas";
            this.pagoDeDeudasToolStripMenuItem.Click += new System.EventHandler(this.pagoDeDeudasToolStripMenuItem_Click);
            // 
            // totalDeGananciasToolStripMenuItem
            // 
            this.totalDeGananciasToolStripMenuItem.Name = "totalDeGananciasToolStripMenuItem";
            this.totalDeGananciasToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.totalDeGananciasToolStripMenuItem.Text = "Total de ganancias";
            this.totalDeGananciasToolStripMenuItem.Click += new System.EventHandler(this.totalDeGananciasToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReportes";
            this.Text = "Reportes de la actividad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habitacionesOcupadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasPorTiempoRentadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeDeudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeGananciasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}