namespace Presentacion.Forms.Localidades
{
    partial class FrmLocalidades
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
            dataGridLocalidades = new DataGridView();
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            SuspendLayout();
            // 
            // dataGridLocalidades
            // 
            dataGridLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(129, 52);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.RowTemplate.Height = 25;
            dataGridLocalidades.Size = new Size(499, 193);
            dataGridLocalidades.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(189, 24);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(246, 23);
            txtBusqueda.TabIndex = 7;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(605, 341);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(352, 321);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(239, 321);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(129, 321);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 22);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuev&o";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // FrmLocalidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridLocalidades);
            Name = "FrmLocalidades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Localidades";
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridLocalidades;
        private Label label1;
        private TextBox txtBusqueda;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
    }
}