using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Interfaces.Reportes.CantidadPorMedicamento
{
    public partial class FrmCantidadPorMedicamento : Form
    {
        private ReporteCantXMedRepositorio reporteRepo;

        public FrmCantidadPorMedicamento()
        {
            reporteRepo = new ReporteCantXMedRepositorio();
            InitializeComponent();
        }

        private void FrmCantidadPorMedicamento_Load(object sender, EventArgs e)
        {
            this.CargarReporte();
        }

        private void CargarReporte()
        {
            //obtenemos los datos desde la BD
            var datos = reporteRepo.ObtenerCantidadPorMedicamento();
            //limpiamos los datos cargados en el Datasource
            this.RwCantidadPorMedicamento.LocalReport.DataSources.Clear();
            //asociamos los datos al Datasource que acabamos de limpiar
            var ds = new ReportDataSource("DTCantidadXMedicamento", datos);
            //asociamos el Datasource al reporte
            this.RwCantidadPorMedicamento.LocalReport.DataSources.Add(ds);
            //agregamos al reporte el valor del parámetro
            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Today.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwCantidadPorMedicamento.LocalReport.SetParameters(parametros);
            //cargamos el reporte
            this.RwCantidadPorMedicamento.RefreshReport();
        }
    }
}
