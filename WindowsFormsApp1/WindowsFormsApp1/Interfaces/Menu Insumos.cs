using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Laboratorios;
using WindowsFormsApp1.Interfaces.Vacs;
using WindowsFormsApp1.Interfaces.Medicamentos;
using WindowsFormsApp1.Interfaces.Stock;

namespace WindowsFormsApp1.Interfaces
{
    public partial class Frm_Menu_Insumos : Form
    {
        public Frm_Menu_Insumos()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_prin = new FrmMenu_Principal();
            menu_prin.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Laboratorio_Click(object sender, EventArgs e)
        {
            Form labs = new Registrar_Laboratorio();
            labs.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Laboratorio_Click(object sender, EventArgs e)
        {
            Form Clab = new Consultar_Laboratorio();
            Clab.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Vacuna_Click(object sender, EventArgs e)
        {
            Form vacs = new Frm_Registrar_Vacuna();
            vacs.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Medicamento_Click(object sender, EventArgs e)
        {
            Form Med = new Frm_Consultar_Medicamentos();
            Med.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Vacuna_Click(object sender, EventArgs e)
        {
            Form Cvac = new Frm_Consultar_Vacuna();
            Cvac.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Medicamento_Click(object sender, EventArgs e)
        {
            Form Rmedicamento = new Frm_Registrar_Medicamento();
            Rmedicamento.Show();
            this.Dispose();
        }

        private void Lbl_Laboratorio_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Stock_Med_Click(object sender, EventArgs e)
        {
            Form stock_med = new Frm_Stock_Medicamentos();
            stock_med.Show();
            this.Dispose();

        }

        private void Btn_Stock_Vac_Click(object sender, EventArgs e)
        {
            Form stock_vac = new Stock_Vacunas();
            stock_vac.Show();
            this.Dispose();
        }
    }
}
