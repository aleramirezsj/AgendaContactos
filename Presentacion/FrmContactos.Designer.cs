namespace Presentacion
{
    partial class FrmContactos
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
            dataGridContactos = new DataGridView();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            txtBusqueda = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridContactos).BeginInit();
            SuspendLayout();
            // 
            // dataGridContactos
            // 
            dataGridContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContactos.Location = new Point(73, 66);
            dataGridContactos.Name = "dataGridContactos";
            dataGridContactos.RowHeadersWidth = 51;
            dataGridContactos.RowTemplate.Height = 29;
            dataGridContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridContactos.Size = new Size(659, 270);
            dataGridContactos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(94, 383);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuev&o";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(220, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(349, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(638, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(143, 23);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(280, 27);
            txtBusqueda.TabIndex = 5;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Buscar:";
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridContactos);
            Name = "FrmContactos";
            Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)dataGridContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridContactos;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtBusqueda;
        private Label label1;
    }
}