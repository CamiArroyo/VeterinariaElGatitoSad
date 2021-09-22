using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Empleados;

namespace WindowsFormsApp1
{
    public partial class FrmMenu_Principal : Form
    {
        public FrmMenu_Principal()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrar_emp =new Frm_Registrar_Empleado();
            registrar_emp.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darDeBajaMasctoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultar_emp = new Frm_Consultar_Empleado();
            consultar_emp.Show();
        }
    }
}
