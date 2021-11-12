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
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEspecie
{
    public partial class FrmConsultasPorEspecie : Form
    {
        private ReporteConsXEspRepositorio reporteRepo;

        public FrmConsultasPorEspecie()
        {
            reporteRepo = new ReporteConsXEspRepositorio();
            InitializeComponent();
        }

        private void Btm_Registrar_Click(object sender, EventArgs e)
        {
            var filtros = new ConsXEmpFiltros();
            filtros.FechaDesde = Dtp_Fecha_Desde.Value;
            filtros.FechaHasta = Dtp_Fecha_Hasta.Value;

            CargarReporte(filtros);
        }

        private void FrmConsultasPorEspecie_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarReporte(ConsXEmpFiltros filtros)
        {
            //obtenemos los datos desde la BD
            var datos = reporteRepo.ObtenerConsultasPorEspecie(filtros);

            //limpiamos los datos cargados en el Datasource
            this.RwConsultasPorEspecie.LocalReport.DataSources.Clear();

            //asociamos los datos al Datasource que acabamos de limpiar
            var ds = new ReportDataSource("DTConsultasXEspecie", datos);

            //asociamos el Datasource al reporte
            this.RwConsultasPorEspecie.LocalReport.DataSources.Add(ds);
            //agregamos al reporte el valor del parámetro

            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwConsultasPorEspecie.LocalReport.SetParameters(parametros);

            //cargamos el reporte
            this.RwConsultasPorEspecie.RefreshReport();
        }
    }
}
