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

namespace Presentacion.Forms.Provincias
{
    public partial class FrmNuevoEditarProvincia : Form
    {
        Provincia provincia=new Provincia();
        int idProvinciaEditada = 0;
        public FrmNuevoEditarProvincia()
        {
            InitializeComponent();
        }

        public FrmNuevoEditarProvincia(int idProvinciaAModificar)
        {
            InitializeComponent();
            this.idProvinciaEditada=idProvinciaAModificar;
            CargarDatosDeLaProvincia();
        }

        private void CargarDatosDeLaProvincia()
        {
            AgendaContext db= new AgendaContext();
            provincia=db.Provincias.Find(this.idProvinciaEditada);
            if (provincia != null)
            {
                txtNombre.Text = provincia.Nombre;
                txtRegion.Text = provincia.Region;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //tomamos los datos que están en la pantalla y los almacenamos en el campo provincia del formulario
            provincia.Nombre=txtNombre.Text;
            provincia.Region=txtRegion.Text;

            //instanciamos la clase AgendaContext para poder operar con los datos
            AgendaContext db= new AgendaContext();
            
            //chequeamos si estamos cargando una nueva provincia, evaluando el campo idProvinciaEditada
            if(this.idProvinciaEditada==0)
            {
                db.Provincias.Add(provincia);
            }else
            {
                db.Entry((Provincia)provincia).State = EntityState.Modified;
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
