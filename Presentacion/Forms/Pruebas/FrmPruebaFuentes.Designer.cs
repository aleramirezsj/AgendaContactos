namespace Presentacion
{
    partial class FrmPruebaFuentes
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
            CboColor = new ComboBox();
            label1 = new Label();
            CboFuente = new ComboBox();
            label2 = new Label();
            TxtTexto = new TextBox();
            label3 = new Label();
            BtnAceptar = new Button();
            ChkNegrita = new CheckBox();
            ChkCursiva = new CheckBox();
            TxtTamaño = new Label();
            RdbIzquierda = new RadioButton();
            RdbCentrado = new RadioButton();
            RdbDerecha = new RadioButton();
            PnlVistaPrevia = new Panel();
            LblVistaprevia = new Label();
            NudTamaño = new NumericUpDown();
            RdbInferior = new RadioButton();
            RdbMedio = new RadioButton();
            RdbSuperior = new RadioButton();
            panel1 = new Panel();
            DtpFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            PnlVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudTamaño).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CboColor
            // 
            CboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            CboColor.FormattingEnabled = true;
            CboColor.Items.AddRange(new object[] { "Azul", "Rojo", "Verde" });
            CboColor.Location = new Point(456, 50);
            CboColor.Margin = new Padding(3, 4, 3, 4);
            CboColor.Name = "CboColor";
            CboColor.Size = new Size(115, 28);
            CboColor.TabIndex = 0;
            CboColor.SelectedIndexChanged += CboColor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 53);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Fuente:";
            // 
            // CboFuente
            // 
            CboFuente.FormattingEnabled = true;
            CboFuente.Location = new Point(124, 50);
            CboFuente.Name = "CboFuente";
            CboFuente.Size = new Size(151, 28);
            CboFuente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 53);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Color:";
            // 
            // TxtTexto
            // 
            TxtTexto.Location = new Point(104, 151);
            TxtTexto.Name = "TxtTexto";
            TxtTexto.Size = new Size(291, 27);
            TxtTexto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 153);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Texto:";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(421, 149);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(94, 29);
            BtnAceptar.TabIndex = 6;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // ChkNegrita
            // 
            ChkNegrita.AutoSize = true;
            ChkNegrita.Location = new Point(104, 205);
            ChkNegrita.Name = "ChkNegrita";
            ChkNegrita.Size = new Size(81, 24);
            ChkNegrita.TabIndex = 7;
            ChkNegrita.Text = "Negrita";
            ChkNegrita.UseVisualStyleBackColor = true;
            ChkNegrita.CheckedChanged += ChkNegrita_CheckedChanged;
            // 
            // ChkCursiva
            // 
            ChkCursiva.AutoSize = true;
            ChkCursiva.Location = new Point(197, 205);
            ChkCursiva.Name = "ChkCursiva";
            ChkCursiva.Size = new Size(78, 24);
            ChkCursiva.TabIndex = 8;
            ChkCursiva.Text = "Cursiva";
            ChkCursiva.UseVisualStyleBackColor = true;
            ChkCursiva.CheckedChanged += ChkCursiva_CheckedChanged;
            // 
            // TxtTamaño
            // 
            TxtTamaño.AutoSize = true;
            TxtTamaño.Location = new Point(296, 208);
            TxtTamaño.Name = "TxtTamaño";
            TxtTamaño.Size = new Size(64, 20);
            TxtTamaño.TabIndex = 10;
            TxtTamaño.Text = "Tamaño:";
            // 
            // RdbIzquierda
            // 
            RdbIzquierda.AutoSize = true;
            RdbIzquierda.Location = new Point(104, 271);
            RdbIzquierda.Name = "RdbIzquierda";
            RdbIzquierda.Size = new Size(92, 24);
            RdbIzquierda.TabIndex = 11;
            RdbIzquierda.TabStop = true;
            RdbIzquierda.Text = "Izquierda";
            RdbIzquierda.UseVisualStyleBackColor = true;
            RdbIzquierda.CheckedChanged += RdbIzquierda_CheckedChanged;
            // 
            // RdbCentrado
            // 
            RdbCentrado.Location = new Point(286, 271);
            RdbCentrado.Name = "RdbCentrado";
            RdbCentrado.Size = new Size(109, 24);
            RdbCentrado.TabIndex = 12;
            RdbCentrado.Text = "Centrado";
            RdbCentrado.UseVisualStyleBackColor = true;
            RdbCentrado.CheckedChanged += RdbCentrado_CheckedChanged;
            // 
            // RdbDerecha
            // 
            RdbDerecha.AutoSize = true;
            RdbDerecha.Location = new Point(456, 271);
            RdbDerecha.Name = "RdbDerecha";
            RdbDerecha.Size = new Size(85, 24);
            RdbDerecha.TabIndex = 13;
            RdbDerecha.TabStop = true;
            RdbDerecha.Text = "Derecha";
            RdbDerecha.UseVisualStyleBackColor = true;
            RdbDerecha.CheckedChanged += RdbDerecha_CheckedChanged;
            // 
            // PnlVistaPrevia
            // 
            PnlVistaPrevia.BorderStyle = BorderStyle.Fixed3D;
            PnlVistaPrevia.Controls.Add(LblVistaprevia);
            PnlVistaPrevia.Location = new Point(25, 409);
            PnlVistaPrevia.Name = "PnlVistaPrevia";
            PnlVistaPrevia.Size = new Size(572, 170);
            PnlVistaPrevia.TabIndex = 14;
            // 
            // LblVistaprevia
            // 
            LblVistaprevia.Location = new Point(8, 9);
            LblVistaprevia.Name = "LblVistaprevia";
            LblVistaprevia.Size = new Size(551, 150);
            LblVistaprevia.TabIndex = 0;
            LblVistaprevia.Text = "Probando la label";
            // 
            // NudTamaño
            // 
            NudTamaño.Location = new Point(368, 205);
            NudTamaño.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            NudTamaño.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            NudTamaño.Name = "NudTamaño";
            NudTamaño.Size = new Size(150, 27);
            NudTamaño.TabIndex = 15;
            NudTamaño.Value = new decimal(new int[] { 6, 0, 0, 0 });
            NudTamaño.ValueChanged += NudTamaño_ValueChanged;
            // 
            // RdbInferior
            // 
            RdbInferior.AutoSize = true;
            RdbInferior.Location = new Point(358, 7);
            RdbInferior.Name = "RdbInferior";
            RdbInferior.Size = new Size(78, 24);
            RdbInferior.TabIndex = 18;
            RdbInferior.TabStop = true;
            RdbInferior.Text = "Inferior";
            RdbInferior.UseVisualStyleBackColor = true;
            RdbInferior.CheckedChanged += rdbInferior_CheckedChanged;
            // 
            // RdbMedio
            // 
            RdbMedio.Location = new Point(188, 7);
            RdbMedio.Name = "RdbMedio";
            RdbMedio.Size = new Size(109, 24);
            RdbMedio.TabIndex = 17;
            RdbMedio.Text = "Medio";
            RdbMedio.UseVisualStyleBackColor = true;
            RdbMedio.CheckedChanged += rdbMedio_CheckedChanged;
            // 
            // RdbSuperior
            // 
            RdbSuperior.AutoSize = true;
            RdbSuperior.Location = new Point(6, 7);
            RdbSuperior.Name = "RdbSuperior";
            RdbSuperior.Size = new Size(86, 24);
            RdbSuperior.TabIndex = 16;
            RdbSuperior.TabStop = true;
            RdbSuperior.Text = "Superior";
            RdbSuperior.UseVisualStyleBackColor = true;
            RdbSuperior.CheckedChanged += rdbSuperior_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(RdbInferior);
            panel1.Controls.Add(RdbSuperior);
            panel1.Controls.Add(RdbMedio);
            panel1.Location = new Point(104, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 46);
            panel1.TabIndex = 19;
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            DtpFechaNacimiento.Location = new Point(202, 98);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.Size = new Size(124, 27);
            DtpFechaNacimiento.TabIndex = 20;
            DtpFechaNacimiento.ValueChanged += DtpFechaNacimiento_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 105);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 21;
            label4.Text = "Fecha de nacimiento:";
            // 
            // FrmPruebaFuentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 591);
            Controls.Add(label4);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(panel1);
            Controls.Add(NudTamaño);
            Controls.Add(PnlVistaPrevia);
            Controls.Add(RdbDerecha);
            Controls.Add(RdbCentrado);
            Controls.Add(RdbIzquierda);
            Controls.Add(TxtTamaño);
            Controls.Add(ChkCursiva);
            Controls.Add(ChkNegrita);
            Controls.Add(BtnAceptar);
            Controls.Add(label3);
            Controls.Add(TxtTexto);
            Controls.Add(label2);
            Controls.Add(CboFuente);
            Controls.Add(label1);
            Controls.Add(CboColor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPruebaFuentes";
            Text = "FrmPruebaFuentes";
            PnlVistaPrevia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NudTamaño).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboColor;
        private Label label1;
        private ComboBox CboFuente;
        private Label label2;
        private TextBox TxtTexto;
        private Label label3;
        private Button BtnAceptar;
        private CheckBox ChkNegrita;
        private CheckBox ChkCursiva;
        private Label TxtTamaño;
        private RadioButton RdbIzquierda;
        private RadioButton RdbCentrado;
        private RadioButton RdbDerecha;
        private Panel PnlVistaPrevia;
        private Label LblVistaprevia;
        private NumericUpDown NudTamaño;
        private RadioButton RdbInferior;
        private RadioButton RdbMedio;
        private RadioButton RdbSuperior;
        private Panel panel1;
        private DateTimePicker DtpFechaNacimiento;
        private Label label4;
    }
}