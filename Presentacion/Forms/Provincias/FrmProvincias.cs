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

namespace Presentacion.Forms.Provincias
{
    public partial class FrmProvincias : Form
    {
        RepositoryProvincias repositoryProvincias= new RepositoryProvincias();
        //constructor

        public FrmProvincias()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            AgendaContext db = new AgendaContext();
            //si hay texto escrito en el txtBusqueda va a ejecutar el filtro
            if(txtBusqueda.Text.Trim().Length > 0 )
            {
                dataGridProvincias.DataSource = repositoryProvincias.GetAll(txtBusqueda.Text);
            }
            else
            {
                dataGridProvincias.DataSource = repositoryProvincias.GetAll();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia();
            frmNuevoEditarProvincia.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre de la provincia seleccionada en la grilla
            int idProvinciaActual = (int)dataGridProvincias.CurrentRow.Cells[0].Value;
            string nombreProvincia = (string)dataGridProvincias.CurrentRow.Cells[1].Value;

            //preguntamos si está seguro que quiere borrar

            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar la provincia {nombreProvincia}?", "Eliminar provincia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryProvincias.Remove(idProvinciaActual);
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el id de la provincia seleccionada en la grilla
            int idProvinciaActual = (int)dataGridProvincias.CurrentRow.Cells[0].Value;

            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia(idProvinciaActual);
            frmNuevoEditarProvincia.ShowDialog();
            CargarGrilla();

        }
    }
}
