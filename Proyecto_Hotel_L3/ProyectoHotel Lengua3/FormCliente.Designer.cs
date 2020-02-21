namespace ProyectoHotel_Lengua3
{
    partial class FormCliente
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
            System.Windows.Forms.Label efectivoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tarjetaLabel;
            System.Windows.Forms.Label tipoHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.efectivoCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.tarjetaCheckBox = new System.Windows.Forms.CheckBox();
            this.tipoHTextBox = new System.Windows.Forms.TextBox();
            this.listaHabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaHabitacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaHabitacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listaHabitacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            efectivoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tarjetaLabel = new System.Windows.Forms.Label();
            tipoHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesBindingNavigator)).BeginInit();
            this.listaHabitacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // efectivoLabel
            // 
            efectivoLabel.AutoSize = true;
            efectivoLabel.Location = new System.Drawing.Point(313, 119);
            efectivoLabel.Name = "efectivoLabel";
            efectivoLabel.Size = new System.Drawing.Size(49, 13);
            efectivoLabel.TabIndex = 2;
            efectivoLabel.Text = "Efectivo:";
            // 
            // efectivoCheckBox
            // 
            this.efectivoCheckBox.Location = new System.Drawing.Point(368, 114);
            this.efectivoCheckBox.Name = "efectivoCheckBox";
            this.efectivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.efectivoCheckBox.TabIndex = 3;
            this.efectivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(35, 74);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(90, 71);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(35, 100);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(90, 97);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(104, 20);
            this.precioTextBox.TabIndex = 7;
            // 
            // tarjetaLabel
            // 
            tarjetaLabel.AutoSize = true;
            tarjetaLabel.Location = new System.Drawing.Point(313, 97);
            tarjetaLabel.Name = "tarjetaLabel";
            tarjetaLabel.Size = new System.Drawing.Size(43, 13);
            tarjetaLabel.TabIndex = 8;
            tarjetaLabel.Text = "Tarjeta:";
            // 
            // tarjetaCheckBox
            // 
            this.tarjetaCheckBox.Location = new System.Drawing.Point(368, 92);
            this.tarjetaCheckBox.Name = "tarjetaCheckBox";
            this.tarjetaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tarjetaCheckBox.TabIndex = 9;
            this.tarjetaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tipoHLabel
            // 
            tipoHLabel.AutoSize = true;
            tipoHLabel.Location = new System.Drawing.Point(35, 126);
            tipoHLabel.Name = "tipoHLabel";
            tipoHLabel.Size = new System.Drawing.Size(42, 13);
            tipoHLabel.TabIndex = 10;
            tipoHLabel.Text = "Tipo H:";
            // 
            // tipoHTextBox
            // 
            this.tipoHTextBox.Location = new System.Drawing.Point(90, 123);
            this.tipoHTextBox.Name = "tipoHTextBox";
            this.tipoHTextBox.Size = new System.Drawing.Size(104, 20);
            this.tipoHTextBox.TabIndex = 11;
            // 
            // listaHabitacionesBindingSource
            // 
            this.listaHabitacionesBindingSource.DataSource = typeof(BL.Apartados.Habitacion);
            // 
            // listaHabitacionesBindingNavigator
            // 
            this.listaHabitacionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaHabitacionesBindingNavigator.BindingSource = this.listaHabitacionesBindingSource;
            this.listaHabitacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaHabitacionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaHabitacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaHabitacionesBindingNavigatorSaveItem});
            this.listaHabitacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaHabitacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaHabitacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaHabitacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaHabitacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaHabitacionesBindingNavigator.Name = "listaHabitacionesBindingNavigator";
            this.listaHabitacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaHabitacionesBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.listaHabitacionesBindingNavigator.TabIndex = 12;
            this.listaHabitacionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaHabitacionesBindingNavigatorSaveItem
            // 
            this.listaHabitacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaHabitacionesBindingNavigatorSaveItem.Enabled = false;
            this.listaHabitacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaHabitacionesBindingNavigatorSaveItem.Image")));
            this.listaHabitacionesBindingNavigatorSaveItem.Name = "listaHabitacionesBindingNavigatorSaveItem";
            this.listaHabitacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaHabitacionesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // listaHabitacionesDataGridView
            // 
            this.listaHabitacionesDataGridView.AutoGenerateColumns = false;
            this.listaHabitacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaHabitacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.listaHabitacionesDataGridView.DataSource = this.listaHabitacionesBindingSource;
            this.listaHabitacionesDataGridView.Location = new System.Drawing.Point(12, 173);
            this.listaHabitacionesDataGridView.Name = "listaHabitacionesDataGridView";
            this.listaHabitacionesDataGridView.Size = new System.Drawing.Size(551, 271);
            this.listaHabitacionesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.FillWeight = 250F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TipoH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Efectivo";
            this.dataGridViewCheckBoxColumn1.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Efectivo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Tarjeta";
            this.dataGridViewCheckBoxColumn2.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Tarjeta";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 456);
            this.Controls.Add(this.listaHabitacionesDataGridView);
            this.Controls.Add(this.listaHabitacionesBindingNavigator);
            this.Controls.Add(efectivoLabel);
            this.Controls.Add(this.efectivoCheckBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(tarjetaLabel);
            this.Controls.Add(this.tarjetaCheckBox);
            this.Controls.Add(tipoHLabel);
            this.Controls.Add(this.tipoHTextBox);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesBindingNavigator)).EndInit();
            this.listaHabitacionesBindingNavigator.ResumeLayout(false);
            this.listaHabitacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaHabitacionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox efectivoCheckBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.CheckBox tarjetaCheckBox;
        private System.Windows.Forms.TextBox tipoHTextBox;
        private System.Windows.Forms.BindingSource listaHabitacionesBindingSource;
        private System.Windows.Forms.BindingNavigator listaHabitacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaHabitacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listaHabitacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}