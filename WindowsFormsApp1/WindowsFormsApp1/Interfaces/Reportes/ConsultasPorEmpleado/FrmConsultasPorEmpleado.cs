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

namespace WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEmpleado
{
    public partial class FrmConsultasPorEmpleado : Form
    {
        private ReporteConsXEmpRepositorio reporteRepo;

        public FrmConsultasPorEmpleado()
        {
            reporteRepo = new ReporteConsXEmpRepositorio();
            InitializeComponent();
        }

        private void FrmConsultasPorEmpleado_Load(object sender, EventArgs e)
        {
            this.CargarReporte();
        }

        private void CargarReporte()
        {
            //obtenemos los datos desde la BD
            var datos = reporteRepo.ObtenerConsultasPorEmpleado();
            //limpiamos los datos cargados en el Datasource
            this.RwConsultasPorEmpleado.LocalReport.DataSources.Clear();
            //asociamos los datos al Datasource que acabamos de limpiar
            var ds = new ReportDataSource("DTConsultasXEmpleado", datos);
            //asociamos el Datasource al reporte
            this.RwConsultasPorEmpleado.LocalReport.DataSources.Add(ds);
            //agregamos al reporte el valor del parámetro
            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwConsultasPorEmpleado.LocalReport.SetParameters(parametros);
            //cargamos el reporte
            this.RwConsultasPorEmpleado.RefreshReport();
        }
    }
}
