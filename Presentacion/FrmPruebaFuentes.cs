using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPruebaFuentes : Form
    {
        public FrmPruebaFuentes()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            LblVistaprevia.Text = TxtTexto.Text;
        }

        private void ChkNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNegrita.Checked)
            {
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Bold);
            }
            else
            {
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Regular);
            }

        }

        private void ChkCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCursiva.Checked)
            {
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Italic);
            }
            else
            {
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Regular);
            }
        }

        private void NudTamaño_ValueChanged(object sender, EventArgs e)
        {
            LblVistaprevia.Font = new Font(LblVistaprevia.Font.FontFamily, (float)NudTamaño.Value);
        }
    }
}
