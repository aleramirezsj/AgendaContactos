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

namespace Presentacion.Forms.Provincias
{
    public partial class FrmNuevoEditarProvincia : Form
    {
        RepositoryProvincias repositoryProvincias = new RepositoryProvincias();
        Provincia provincia = new Provincia();
        int idProvinciaEditada = 0;
        public int IdAgregadoEditado { get; set; }

        public FrmNuevoEditarProvincia()
        {
            InitializeComponent();
            CargarComboRegiones();
        }

        private void CargarComboRegiones()
        {
            comboRegion.DataSource = Enum.GetValues(typeof(RegionEnum));
        }

        public FrmNuevoEditarProvincia(int idProvinciaAModificar)
        {
            InitializeComponent();
            this.idProvinciaEditada = idProvinciaAModificar;
            CargarComboRegiones();
            CargarDatosDeLaProvincia();
        }

        private void CargarDatosDeLaProvincia()
        {
            provincia = repositoryProvincias.GetById(this.idProvinciaEditada);
            if (provincia != null)
            {
                txtNombre.Text = provincia.Nombre;
                comboRegion.SelectedItem = provincia.Region;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //tomamos los datos que están en la pantalla y los almacenamos en el campo provincia del formulario
            provincia.Nombre = txtNombre.Text;
            provincia.Region = (RegionEnum)comboRegion.SelectedValue;

            //instanciamos la clase AgendaContext para poder operar con los datos

            //chequeamos si estamos cargando una nueva provincia, evaluando el campo idProvinciaEditada
            if (this.idProvinciaEditada == 0)
            {
                repositoryProvincias.Add(provincia);
            }
            else
            {
                repositoryProvincias.Update(provincia);
            }
            this.IdAgregadoEditado = provincia.Id;
            this.Close();
        }
    }
}
