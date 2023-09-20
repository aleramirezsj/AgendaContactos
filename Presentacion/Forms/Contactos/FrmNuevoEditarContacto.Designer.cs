namespace Presentacion
{
    partial class FrmNuevoEditarContacto
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
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericTelefono = new NumericUpDown();
            txtDirección = new TextBox();
            label5 = new Label();
            checkFavorito = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericTelefono).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 41);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(237, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(237, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 194);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // numericTelefono
            // 
            numericTelefono.Location = new Point(237, 194);
            numericTelefono.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericTelefono.Name = "numericTelefono";
            numericTelefono.Size = new Size(253, 27);
            numericTelefono.TabIndex = 7;
            // 
            // txtDirección
            // 
            txtDirección.Location = new Point(237, 249);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(253, 27);
            txtDirección.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 249);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Dirección:";
            // 
            // checkFavorito
            // 
            checkFavorito.AutoSize = true;
            checkFavorito.Location = new Point(238, 299);
            checkFavorito.Name = "checkFavorito";
            checkFavorito.Size = new Size(84, 24);
            checkFavorito.TabIndex = 10;
            checkFavorito.Text = "Favorito";
            checkFavorito.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(175, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoEditarContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 399);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(checkFavorito);
            Controls.Add(txtDirección);
            Controls.Add(label5);
            Controls.Add(numericTelefono);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Name = "FrmNuevoEditarContacto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo/Editar Contacto";
            ((System.ComponentModel.ISupportInitialize)numericTelefono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private NumericUpDown numericTelefono;
        private TextBox txtDirección;
        private Label label5;
        private CheckBox checkFavorito;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}