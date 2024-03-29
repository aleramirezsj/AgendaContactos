﻿using Microsoft.EntityFrameworkCore;
using Presentacion.Forms.Provincias;
using Presentacion.Modelos;
using Presentacion.Respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms.Localidades
{
    public partial class FrmNuevoEditarLocalidad : Form
    {
        RepositoryLocalidades repositoryLocalidades= new RepositoryLocalidades();
        RepositoryProvincias repositoryProvincias= new RepositoryProvincias();
        public int IdAgregadoModificado { get; set; }

        //campos que utilizamos si modificamos a un contacto
        int idModificado = 0;
        Localidad localidad = new Localidad();

        public FrmNuevoEditarLocalidad()
        {
            InitializeComponent();
            CargarComboProvincia();
        }

        private void CargarComboProvincia()
        {
            cboProvincia.DataSource = repositoryProvincias.GetAll();
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.ValueMember = "Id";
        }

        public FrmNuevoEditarLocalidad(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarComboProvincia();
            CargarDatosDeLocalidadAModificar();

        }

        private void CargarDatosDeLocalidadAModificar()
        {
            localidad = repositoryLocalidades.GetById(this.idModificado);

            txtNombre.Text = localidad.Nombre;
            numericCodigoPostal.Value = localidad.CodigoPostal;
            //establecemos la provincia, de la localidad que estamos editando, en el combobox, a través de la propiedad SelectValue
            cboProvincia.SelectedValue = localidad.ProvinciaId;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            localidad.Nombre = txtNombre.Text;
            localidad.CodigoPostal = (int)numericCodigoPostal.Value;
            localidad.ProvinciaId = (int)cboProvincia.SelectedValue;

            if (this.idModificado == 0)
            {
               repositoryLocalidades.Add(localidad);
            }
            else
            {
                localidad.Id = this.idModificado;
                repositoryLocalidades.Update(localidad);
            }
            this.IdAgregadoModificado = localidad.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProvincia_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia();
            frmNuevoEditarProvincia.ShowDialog();
            CargarComboProvincia();
            cboProvincia.SelectedValue = frmNuevoEditarProvincia.IdAgregadoEditado;
            

        }
    }
}
