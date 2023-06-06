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
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Bold);
            else
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Regular);

        }

        private void ChkCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCursiva.Checked)
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Italic);
            else
                LblVistaprevia.Font = new Font(LblVistaprevia.Font, FontStyle.Regular);
        }

        private void NudTamaño_ValueChanged(object sender, EventArgs e)
        {
            LblVistaprevia.Font = new Font(LblVistaprevia.Font.FontFamily, (float)NudTamaño.Value);
        }


        private void RdbIzquierda_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbIzquierda.Checked)
            {
                if (RdbSuperior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopLeft;
                if (RdbMedio.Checked)
                    LblVistaprevia.TextAlign =
              ContentAlignment.MiddleLeft;
                if (RdbInferior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomLeft;
            }

        }

        private void RdbCentrado_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCentrado.Checked)
            {
                if (RdbSuperior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopCenter;
                if (RdbMedio.Checked)
                    LblVistaprevia.TextAlign =
              ContentAlignment.MiddleCenter;
                if (RdbInferior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomCenter;
            }
        }

        private void RdbDerecha_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDerecha.Checked)
            {
                if (RdbSuperior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopRight;
                if (RdbMedio.Checked)
                    LblVistaprevia.TextAlign =
              ContentAlignment.MiddleRight;
                if (RdbInferior.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomRight;
            }
        }

        private void rdbSuperior_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSuperior.Checked)
            {
                if (RdbIzquierda.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopLeft;
                if (RdbCentrado.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopCenter;
                if (RdbDerecha.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.TopRight;
            }

        }

        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbMedio.Checked)
            {
                if (RdbIzquierda.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.MiddleLeft;
                if (RdbCentrado.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.MiddleCenter;
                if (RdbDerecha.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private void rdbInferior_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbInferior.Checked)
            {
                if (RdbIzquierda.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomLeft;
                if (RdbCentrado.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomCenter;
                if (RdbDerecha.Checked)
                    LblVistaprevia.TextAlign = ContentAlignment.BottomRight;
            }
        }

        private void DtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            LblVistaprevia.Text = DtpFechaNacimiento.Value.ToShortDateString();
        }
    }
}
