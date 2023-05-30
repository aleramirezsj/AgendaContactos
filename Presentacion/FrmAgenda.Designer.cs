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
            chkMaximizado = new CheckBox();
            label1 = new Label();
            nudEdad = new NumericUpDown();
            pbxFoto = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            lsvListaContactos = new ListView();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(52, 34);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chkMaximizado
            // 
            chkMaximizado.AutoSize = true;
            chkMaximizado.Location = new Point(39, 86);
            chkMaximizado.Margin = new Padding(3, 2, 3, 2);
            chkMaximizado.Name = "chkMaximizado";
            chkMaximizado.Size = new Size(152, 19);
            chkMaximizado.TabIndex = 1;
            chkMaximizado.Text = "Formulario Maximizado";
            chkMaximizado.UseVisualStyleBackColor = true;
            chkMaximizado.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Contactos";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(39, 115);
            nudEdad.Margin = new Padding(3, 2, 3, 2);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(131, 23);
            nudEdad.TabIndex = 3;
            nudEdad.ValueChanged += nudEdad_ValueChanged;
            // 
            // pbxFoto
            // 
            pbxFoto.Anchor = AnchorStyles.None;
            pbxFoto.Image = Properties.Resources._1526495_572316106233301_6765618852665394721_n;
            pbxFoto.Location = new Point(207, 17);
            pbxFoto.Margin = new Padding(3, 2, 3, 2);
            pbxFoto.Name = "pbxFoto";
            pbxFoto.Size = new Size(160, 160);
            pbxFoto.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxFoto.TabIndex = 4;
            pbxFoto.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 160);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Boca";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(79, 160);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "River";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(139, 160);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(101, 19);
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
            btnSalir.Location = new Point(207, 309);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 22);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lsvListaContactos
            // 
            lsvListaContactos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvListaContactos.Location = new Point(10, 196);
            lsvListaContactos.Margin = new Padding(3, 2, 3, 2);
            lsvListaContactos.Name = "lsvListaContactos";
            lsvListaContactos.Size = new Size(161, 118);
            lsvListaContactos.TabIndex = 9;
            lsvListaContactos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 340);
            Controls.Add(lsvListaContactos);
            Controls.Add(btnSalir);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pbxFoto);
            Controls.Add(nudEdad);
            Controls.Add(label1);
            Controls.Add(chkMaximizado);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contactos";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private CheckBox chkMaximizado;
        private Label label1;
        private NumericUpDown nudEdad;
        private PictureBox pbxFoto;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private FontAwesome.Sharp.IconButton btnSalir;
        private ListView lsvListaContactos;
    }
}