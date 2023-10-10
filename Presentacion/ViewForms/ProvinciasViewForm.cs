using Microsoft.Reporting.WinForms;
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

namespace Presentacion.ViewForms
{
    public partial class ProvinciasViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        AgendaContext db = new AgendaContext();
        public ProvinciasViewForm()
        {
            InitializeComponent();
            //reporte ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;

            //establece la vista de impresión
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //establecer el zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            Controls.Add(reporte);
        }

        private void ProvinciasViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.ProvinciasReport.rdlc";
            var provincias = db.Provincias.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSProvincias", provincias));

            reporte.RefreshReport();
        }
    }
}
