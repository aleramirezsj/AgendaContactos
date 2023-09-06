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
    public partial class FrmContactos : Form
    {
        AgendaContext db = new AgendaContext();
        public FrmContactos()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dataGridContactos.DataSource = db.Contactos.ToList();
        }
    }
}
