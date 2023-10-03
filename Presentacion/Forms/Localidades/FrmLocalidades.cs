using Microsoft.EntityFrameworkCore;
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

namespace Presentacion.Forms.Localidades
{
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            AgendaContext db = new AgendaContext();
            dataGridLocalidades.DataSource = db.Localidades.Include(l=>l.Provincia).ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaFiltrada();
        }
        private void CargarGrillaFiltrada()
        {
            AgendaContext db = new AgendaContext();
            dataGridLocalidades.DataSource = db.Localidades.Where(c => c.Nombre.Contains(txtBusqueda.Text)).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarLocalidad frmNuevoEditarLocalidad = new FrmNuevoEditarLocalidad();
            frmNuevoEditarLocalidad.ShowDialog();
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el id a modificar
            int idAModificar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;

            //llamamos al formulario nuevo/editar y le pasamos como argumento el idAModificar
            FrmNuevoEditarLocalidad frmNuevoEditarLocalidad = new FrmNuevoEditarLocalidad(idAModificar);
            frmNuevoEditarLocalidad.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AgendaContext db = new AgendaContext();
            //obtenemos el id y el nombre del contacto seleccionado
            int idABorrar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;
            string localidadABorrar = (string)dataGridLocalidades.CurrentRow.Cells[1].Value ;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar la localidad {localidadABorrar}?", "Eliminar localidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    Localidad localidad = db.Localidades.Find(idABorrar);
                    db.Localidades.Remove(localidad);
                    db.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
