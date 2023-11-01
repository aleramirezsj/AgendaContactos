using Microsoft.EntityFrameworkCore;
using Presentacion.Forms.Localidades;
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
    public partial class FrmNuevoEditarContacto : Form
    {
        AgendaContext db = new AgendaContext();
        RepositoryContactos repositoryContactos = new RepositoryContactos();

        //campos que utilizamos si modificamos a un contacto
        int idModificado = 0;
        Contacto contacto = new Contacto();


        //constructor que se ejecuta cuando creamos un nuevo contacto
        public FrmNuevoEditarContacto()
        {
            InitializeComponent();
            CargarComboLocalidad();

        }

        private void CargarComboLocalidad()
        {
            comboLocalidad.DataSource = db.Localidades.ToList();
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.ValueMember = "Id";
        }

        //constructor que se ejecuta cuando modificamos a un contacto
        public FrmNuevoEditarContacto(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarComboLocalidad();
            CargarDatosDeContactoAModificar();

        }

        private void CargarDatosDeContactoAModificar()
        {
            contacto = repositoryContactos.GetById(this.idModificado);
            txtApellido.Text = contacto.Apellido;
            txtNombre.Text = contacto.Nombre;
            txtDirección.Text = contacto.Direccion;
            txtEmail.Text = contacto.Email;
            numericTelefono.Value = contacto.Telefono ?? 0;
            checkFavorito.Checked = contacto.Favorito ?? false;
            comboLocalidad.SelectedValue = contacto.LocalidadId ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            contacto.Nombre = txtNombre.Text;
            contacto.Apellido = txtApellido.Text;
            contacto.Email = txtEmail.Text;
            contacto.Direccion = txtDirección.Text;
            contacto.Telefono = (long)numericTelefono.Value;
            contacto.Favorito = checkFavorito.Checked;
            contacto.LocalidadId = (int)comboLocalidad.SelectedValue;

            if (this.idModificado == 0)
            {
                repositoryContactos.Add(contacto);
            }
            else
            {
                contacto.Id = this.idModificado;
                repositoryContactos.Update(contacto);
            }
            this.Close();
        }

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarLocalidad frmNuevoEditarLocalidad = new FrmNuevoEditarLocalidad();
            frmNuevoEditarLocalidad.ShowDialog();
            CargarComboLocalidad();
            comboLocalidad.SelectedValue= frmNuevoEditarLocalidad.IdAgregadoModificado;
        }
    }
}
