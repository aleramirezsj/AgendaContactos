﻿using Presentacion.Forms.Localidades;
using Presentacion.Forms.Provincias;
using Presentacion.ViewForms;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            FrmAcercade frmAcercade = new FrmAcercade();
            frmAcercade.ShowDialog();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            FrmContactos frmContactos = new FrmContactos();
            frmContactos.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionarLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalidades frmLocalidades = new FrmLocalidades();
            frmLocalidades.ShowDialog();
        }

        private void gestionarProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvincias frmProvincias = new FrmProvincias();
            frmProvincias.ShowDialog();
        }

        private void listadoDeProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasViewForm provinciasViewForm = new ProvinciasViewForm();
            provinciasViewForm.ShowDialog();
        }
    }
}
