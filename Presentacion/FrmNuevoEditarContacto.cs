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
        public FrmNuevoEditarContacto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto()
            {
                Nombre=txtNombre.Text,
                Apellido=txtApellido.Text,
                Email=txtEmail.Text,
                Direccion=txtDirección.Text,
                Telefono=(long)numericTelefono.Value,
                Favorito=checkFavorito.Checked
            };
            db.Contactos.Add(contacto);
            db.SaveChanges();
            this.Close();
        }
    }
}
