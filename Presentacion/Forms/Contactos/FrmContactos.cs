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

namespace Presentacion
{
    public partial class FrmContactos : Form
    {
        RepositoryContactos repositoryContactos=new RepositoryContactos();
        public FrmContactos()
        {
            InitializeComponent();
            CargarGrilla();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CargarGrilla()
        {
            AgendaContext db = new AgendaContext();
            if(txtBusqueda.Text.Trim().Length > 0 )
            {
                dataGridContactos.DataSource = repositoryContactos.GetAll(txtBusqueda.Text);
            }
            else
            {
                dataGridContactos.DataSource = repositoryContactos.GetAll();
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarContacto frmNuevoEditarContacto = new FrmNuevoEditarContacto();
            frmNuevoEditarContacto.ShowDialog();
            CargarGrilla();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del contacto seleccionado
            int idABorrar = (int)dataGridContactos.CurrentRow.Cells[0].Value;
            string contactoABorrar = (string)dataGridContactos.CurrentRow.Cells[1].Value + " " + dataGridContactos.CurrentRow.Cells[2].Value;

            //preguntamos si está seguro que desea borrar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea borrar al contacto {contactoABorrar}?", "Eliminar contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryContactos.Remove(idABorrar);
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el id a modificar
            int idAModificar = (int)dataGridContactos.CurrentRow.Cells[0].Value;

            //llamamos al formulario nuevo/editar y le pasamos como argumento el idAModificar
            FrmNuevoEditarContacto frmNuevoEditarContacto = new FrmNuevoEditarContacto(idAModificar);
            frmNuevoEditarContacto.ShowDialog();
            CargarGrilla();
        }
    }
}
