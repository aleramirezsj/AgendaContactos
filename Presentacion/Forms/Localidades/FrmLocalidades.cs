using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using Presentacion.Respositories;
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
        RepositoryLocalidades repositoryLocalidades = new RepositoryLocalidades();
        public FrmLocalidades()
        {
            InitializeComponent();
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            dataGridLocalidades.DataSource = repositoryLocalidades.GetAll();
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
            dataGridLocalidades.DataSource = repositoryLocalidades.GetAll(txtBusqueda.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarLocalidad frmNuevoEditarLocalidad = new FrmNuevoEditarLocalidad();
            frmNuevoEditarLocalidad.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarLocalidad.IdAgregadoModificado);
        }

        private void SeleccionarIdAgregadoModificado(int idAgregadoModificado)
        {
            foreach(DataGridViewRow fila in dataGridLocalidades.Rows)
            {
                if ((int)fila.Cells[0].Value == idAgregadoModificado)
                {
                    dataGridLocalidades.CurrentCell =fila.Cells[0];
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el id a modificar
            int idAModificar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;

            //llamamos al formulario nuevo/editar y le pasamos como argumento el idAModificar
            FrmNuevoEditarLocalidad frmNuevoEditarLocalidad = new FrmNuevoEditarLocalidad(idAModificar);
            frmNuevoEditarLocalidad.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarLocalidad.IdAgregadoModificado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del contacto seleccionado
            int idABorrar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;
            string localidadABorrar = (string)dataGridLocalidades.CurrentRow.Cells[1].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar la localidad {localidadABorrar}?", "Eliminar localidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryLocalidades.Remove(idABorrar);
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
