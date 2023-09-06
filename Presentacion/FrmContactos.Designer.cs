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
            ((System.ComponentModel.ISupportInitialize)dataGridContactos).BeginInit();
            SuspendLayout();
            // 
            // dataGridContactos
            // 
            dataGridContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContactos.Location = new Point(73, 39);
            dataGridContactos.Name = "dataGridContactos";
            dataGridContactos.RowHeadersWidth = 51;
            dataGridContactos.RowTemplate.Height = 29;
            dataGridContactos.Size = new Size(659, 270);
            dataGridContactos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(93, 343);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridContactos);
            Name = "FrmContactos";
            Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)dataGridContactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridContactos;
        private Button btnNuevo;
    }
}