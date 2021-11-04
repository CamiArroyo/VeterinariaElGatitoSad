using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Reportes.CantidadPorMedicamento;
using WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEmpleado;
using WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEspecie;

namespace WindowsFormsApp1.Interfaces
{
    public partial class FrmReportesYListados : Form
    {
        public FrmReportesYListados()
        {
            InitializeComponent();
        }

        private void Lbl_Reportes_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporte_ConsXEmp_Click(object sender, EventArgs e)
        {
            var f = new FrmConsultasPorEmpleado();
            f.ShowDialog();
        }

        private void BtnReporte_ConsXEsp_Click(object sender, EventArgs e)
        {
            var f = new FrmConsultasPorEspecie();
            f.ShowDialog();
        }

        private void BtnReporte_StockMedYVac_Click(object sender, EventArgs e)
        {
            var f = new FrmCantidadPorMedicamento();
            f.ShowDialog();
        }

        private void Btn_Animales_Salir_Click(object sender, EventArgs e)
        {
            Form menu_principal = new FrmMenu_Principal();
            menu_principal.Show();
            this.Dispose();
        }
    }
}
