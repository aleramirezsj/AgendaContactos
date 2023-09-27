using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms.Provincias
{
    public partial class FrmProvincias : Form
    {
        //constructor
        public FrmProvincias()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            AgendaContext db = new AgendaContext();
            dataGridProvincias.DataSource = db.Provincias.ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia();
            frmNuevoEditarProvincia.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaFiltrada();
        }

        private void CargarGrillaFiltrada()
        {
            AgendaContext db = new AgendaContext();
            dataGridProvincias.DataSource = db.Provincias.Where(p=>p.Nombre.Contains(txtBusqueda.Text)).ToList();
        }
    }
}
