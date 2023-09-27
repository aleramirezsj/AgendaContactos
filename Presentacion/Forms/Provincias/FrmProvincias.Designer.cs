namespace Presentacion.Forms.Provincias
{
    partial class FrmProvincias
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
            dataGridProvincias = new DataGridView();
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProvincias).BeginInit();
            SuspendLayout();
            // 
            // dataGridProvincias
            // 
            dataGridProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProvincias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProvincias.Location = new Point(82, 40);
            dataGridProvincias.Name = "dataGridProvincias";
            dataGridProvincias.RowTemplate.Height = 25;
            dataGridProvincias.Size = new Size(506, 191);
            dataGridProvincias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 12;
            label1.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(112, 11);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(246, 23);
            txtBusqueda.TabIndex = 11;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(545, 301);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(292, 281);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(179, 281);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(69, 281);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 22);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuev&o";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // FrmProvincias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 334);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridProvincias);
            Name = "FrmProvincias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Provincias";
            ((System.ComponentModel.ISupportInitialize)dataGridProvincias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProvincias;
        private Label label1;
        private TextBox txtBusqueda;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
    }
}