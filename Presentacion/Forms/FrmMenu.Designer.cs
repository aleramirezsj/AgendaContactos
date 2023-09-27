namespace Presentacion
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            gestionarLocalidadesToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            gestionarProvinciasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem3, gestionarLocalidadesToolStripMenuItem, gestionarProvinciasToolStripMenuItem });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(93, 24);
            iconMenuItem1.Text = "Contactos";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(190, 26);
            iconMenuItem3.Text = "Gestionar contactos";
            iconMenuItem3.Click += iconMenuItem3_Click;
            // 
            // gestionarLocalidadesToolStripMenuItem
            // 
            gestionarLocalidadesToolStripMenuItem.Name = "gestionarLocalidadesToolStripMenuItem";
            gestionarLocalidadesToolStripMenuItem.Size = new Size(190, 26);
            gestionarLocalidadesToolStripMenuItem.Text = "Gestionar localidades";
            gestionarLocalidadesToolStripMenuItem.Click += gestionarLocalidadesToolStripMenuItem_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem4, toolStripSeparator1, iconMenuItem5 });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(61, 24);
            iconMenuItem2.Text = "Salir";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(158, 22);
            iconMenuItem4.Text = "Salir del sistema";
            iconMenuItem4.Click += iconMenuItem4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(158, 22);
            iconMenuItem5.Text = "Acerca de ...";
            iconMenuItem5.Click += iconMenuItem5_Click;
            // 
            // gestionarProvinciasToolStripMenuItem
            // 
            gestionarProvinciasToolStripMenuItem.Name = "gestionarProvinciasToolStripMenuItem";
            gestionarProvinciasToolStripMenuItem.Size = new Size(190, 26);
            gestionarProvinciasToolStripMenuItem.Text = "Gestionar provincias";
            gestionarProvinciasToolStripMenuItem.Click += gestionarProvinciasToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Agenda de contactos :: Programación I - 2023";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private ToolStripMenuItem gestionarLocalidadesToolStripMenuItem;
        private ToolStripMenuItem gestionarProvinciasToolStripMenuItem;
    }
}