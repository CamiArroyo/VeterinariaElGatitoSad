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
            this.RwCantidadPorMedicamento.RefreshReport();
        }

        private void CargarReporte()
        {
            //obtenemos los datos desde la BD
            var datosMedicamentos = reporteRepo.ObtenerCantidadPorMedicamento();
            var datosVacunas = reporteRepo.ObtenerCantidadPorVacuna();

            //limpiamos los datos cargados en el Datasource
            this.RwCantidadPorMedicamento.LocalReport.DataSources.Clear();

            //asociamos los datos al Datasource que acabamos de limpiar
            var dsMedicamentos = new ReportDataSource("DSCantidadXMedicamento", datosMedicamentos);
            var dsVacunas = new ReportDataSource("DSCantidadXVacuna", datosVacunas);

            //asociamos el Datasource al reporte
            this.RwCantidadPorMedicamento.LocalReport.DataSources.Add(dsMedicamentos);
            this.RwCantidadPorMedicamento.LocalReport.DataSources.Add(dsVacunas);

            //agregamos al reporte el valor del parámetro
            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwCantidadPorMedicamento.LocalReport.SetParameters(parametros);

            //cargamos el reporte
            this.RwCantidadPorMedicamento.RefreshReport();
        }
    }
}
