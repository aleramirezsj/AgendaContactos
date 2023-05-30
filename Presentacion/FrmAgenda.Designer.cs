namespace Presentacion
{
    partial class FrmAgenda
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
            btnAgregar = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            pbxFoto = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            lsvListaContactos = new ListView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(59, 62);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(59, 111);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Favorito";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Contactos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(45, 153);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // pbxFoto
            // 
            pbxFoto.Image = Properties.Resources._1526495_572316106233301_6765618852665394721_n;
            pbxFoto.Location = new Point(237, 23);
            pbxFoto.Name = "pbxFoto";
            pbxFoto.Size = new Size(133, 118);
            pbxFoto.TabIndex = 4;
            pbxFoto.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 213);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Boca";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(90, 213);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 24);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "River";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(159, 213);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(126, 24);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Independiente";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(237, 412);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lsvListaContactos
            // 
            lsvListaContactos.Location = new Point(12, 261);
            lsvListaContactos.Name = "lsvListaContactos";
            lsvListaContactos.Size = new Size(183, 156);
            lsvListaContactos.TabIndex = 9;
            lsvListaContactos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(382, 453);
            Controls.Add(lsvListaContactos);
            Controls.Add(btnSalir);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pbxFoto);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contactos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private CheckBox checkBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private PictureBox pbxFoto;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private FontAwesome.Sharp.IconButton btnSalir;
        private ListView lsvListaContactos;
    }
}