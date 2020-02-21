namespace ProyectoHotel_Lengua3
{
    partial class FormEstado
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.habitacionesOcupadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesApartadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesOcupadasToolStripMenuItem,
            this.habitacionesDisponiblesToolStripMenuItem,
            this.habitacionesApartadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // habitacionesOcupadasToolStripMenuItem
            // 
            this.habitacionesOcupadasToolStripMenuItem.Name = "habitacionesOcupadasToolStripMenuItem";
            this.habitacionesOcupadasToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.habitacionesOcupadasToolStripMenuItem.Text = "Habitaciones ocupadas";
            this.habitacionesOcupadasToolStripMenuItem.Click += new System.EventHandler(this.habitacionesOcupadasToolStripMenuItem_Click);
            // 
            // habitacionesDisponiblesToolStripMenuItem
            // 
            this.habitacionesDisponiblesToolStripMenuItem.Name = "habitacionesDisponiblesToolStripMenuItem";
            this.habitacionesDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.habitacionesDisponiblesToolStripMenuItem.Text = "Habitaciones disponibles";
            this.habitacionesDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesDisponiblesToolStripMenuItem_Click);
            // 
            // habitacionesApartadosToolStripMenuItem
            // 
            this.habitacionesApartadosToolStripMenuItem.Name = "habitacionesApartadosToolStripMenuItem";
            this.habitacionesApartadosToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.habitacionesApartadosToolStripMenuItem.Text = "Habitaciones apartados";
            this.habitacionesApartadosToolStripMenuItem.Click += new System.EventHandler(this.habitacionesApartadosToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 92);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "1";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEstado";
            this.Text = "Estado de las habitaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habitacionesOcupadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesApartadosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button button1;
    }
}