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
            CboTamaño = new ComboBox();
            TxtTamaño = new Label();
            RdbIzquierda = new RadioButton();
            RdbCentrado = new RadioButton();
            RdbDerecha = new RadioButton();
            PnlVistaPrevia = new Panel();
            LblVistaprevia = new Label();
            PnlVistaPrevia.SuspendLayout();
            SuspendLayout();
            // 
            // CboColor
            // 
            CboColor.FormattingEnabled = true;
            CboColor.Location = new Point(456, 50);
            CboColor.Margin = new Padding(3, 4, 3, 4);
            CboColor.Name = "CboColor";
            CboColor.Size = new Size(115, 28);
            CboColor.TabIndex = 0;
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
            TxtTexto.Size = new Size(247, 27);
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
            // 
            // CboTamaño
            // 
            CboTamaño.FormattingEnabled = true;
            CboTamaño.Location = new Point(371, 203);
            CboTamaño.Name = "CboTamaño";
            CboTamaño.Size = new Size(151, 28);
            CboTamaño.TabIndex = 9;
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
            // 
            // RdbCentrado
            // 
            RdbCentrado.AutoSize = true;
            RdbCentrado.Location = new Point(285, 271);
            RdbCentrado.Name = "RdbCentrado";
            RdbCentrado.Size = new Size(91, 24);
            RdbCentrado.TabIndex = 12;
            RdbCentrado.TabStop = true;
            RdbCentrado.Text = "Centrado";
            RdbCentrado.UseVisualStyleBackColor = true;
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
            // 
            // PnlVistaPrevia
            // 
            PnlVistaPrevia.Controls.Add(LblVistaprevia);
            PnlVistaPrevia.Location = new Point(124, 352);
            PnlVistaPrevia.Name = "PnlVistaPrevia";
            PnlVistaPrevia.Size = new Size(398, 125);
            PnlVistaPrevia.TabIndex = 14;
            // 
            // LblVistaprevia
            // 
            LblVistaprevia.Location = new Point(10, 11);
            LblVistaprevia.Name = "LblVistaprevia";
            LblVistaprevia.Size = new Size(381, 104);
            LblVistaprevia.TabIndex = 0;
            // 
            // FrmPruebaFuentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 591);
            Controls.Add(PnlVistaPrevia);
            Controls.Add(RdbDerecha);
            Controls.Add(RdbCentrado);
            Controls.Add(RdbIzquierda);
            Controls.Add(TxtTamaño);
            Controls.Add(CboTamaño);
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
        private ComboBox CboTamaño;
        private Label TxtTamaño;
        private RadioButton RdbIzquierda;
        private RadioButton RdbCentrado;
        private RadioButton RdbDerecha;
        private Panel PnlVistaPrevia;
        private Label LblVistaprevia;
    }
}