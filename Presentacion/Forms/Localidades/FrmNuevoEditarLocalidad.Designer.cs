namespace Presentacion.Forms.Localidades
{
    partial class FrmNuevoEditarLocalidad
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
            txtNombre = new TextBox();
            label2 = new Label();
            numericCodigoPostal = new NumericUpDown();
            label4 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cboProvincia = new ComboBox();
            label1 = new Label();
            btnAgregarProvincia = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCodigoPostal).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(279, 80);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // numericCodigoPostal
            // 
            numericCodigoPostal.Location = new Point(280, 124);
            numericCodigoPostal.Margin = new Padding(3, 2, 3, 2);
            numericCodigoPostal.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericCodigoPostal.Name = "numericCodigoPostal";
            numericCodigoPostal.Size = new Size(221, 23);
            numericCodigoPostal.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 124);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Codigo postal:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 281);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(292, 281);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(280, 173);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(222, 23);
            cboProvincia.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 176);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 16;
            label1.Text = "Provincia:";
            // 
            // btnAgregarProvincia
            // 
            btnAgregarProvincia.Location = new Point(508, 173);
            btnAgregarProvincia.Name = "btnAgregarProvincia";
            btnAgregarProvincia.Size = new Size(39, 23);
            btnAgregarProvincia.TabIndex = 17;
            btnAgregarProvincia.Text = "...";
            btnAgregarProvincia.UseVisualStyleBackColor = true;
            btnAgregarProvincia.Click += btnAgregarProvincia_Click;
            // 
            // FrmNuevoEditarLocalidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 356);
            Controls.Add(btnAgregarProvincia);
            Controls.Add(label1);
            Controls.Add(cboProvincia);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(numericCodigoPostal);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "FrmNuevoEditarLocalidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmNuevoEditarLocalidad";
            ((System.ComponentModel.ISupportInitialize)numericCodigoPostal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label2;
        private NumericUpDown numericCodigoPostal;
        private Label label4;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cboProvincia;
        private Label label1;
        private Button btnAgregarProvincia;
    }
}