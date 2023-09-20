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

namespace Presentacion
{
    public partial class FrmNuevoEditarContacto : Form
    {
        AgendaContext db=new AgendaContext();
        
        //campos que utilizamos si modificamos a un contacto
        int idModificado=0;
        Contacto contacto=new Contacto();


        //constructor que se ejecuta cuando creamos un nuevo contacto
        public FrmNuevoEditarContacto()
        {
            InitializeComponent();

        }

        //constructor que se ejecuta cuando modificamos a un contacto
        public FrmNuevoEditarContacto(int idAModificar)
        {
            InitializeComponent();  
            this.idModificado = idAModificar;
            CargarDatosDeContactoAModificar();
        }

        private void CargarDatosDeContactoAModificar()
        {
            contacto=db.Contactos.Find(this.idModificado);
            txtApellido.Text = contacto.Apellido;
            txtNombre.Text= contacto.Nombre;
            txtDirección.Text = contacto.Direccion;
            txtEmail.Text = contacto.Email;
            numericTelefono.Value=contacto.Telefono??0;
            checkFavorito.Checked = contacto.Favorito??false;
            
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
            
            if (this.idModificado == 0)
            {
                db.Contactos.Add(contacto);
            } else
            {
                contacto.Id = this.idModificado;
                db.Entry((Contacto)contacto).State = EntityState.Modified;
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
