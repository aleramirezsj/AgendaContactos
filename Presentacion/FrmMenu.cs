﻿using System;
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
    }
}