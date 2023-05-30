using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lsvListaContactos.Items.Add("Juan Perez");
            MessageBox.Show("Se ha agregado un contacto");
        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {
            if (nudEdad.Value % 5 == 0)
            {
                this.Text = "Agenda de Contactos : " + DateTime.Now;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaximizado.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
