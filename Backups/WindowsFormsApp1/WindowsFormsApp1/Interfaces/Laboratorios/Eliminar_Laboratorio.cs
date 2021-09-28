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
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    public partial class Eliminar_Laboratorio : Form
    {
        private Laboratorio laboratorio;
        private LaboratoriosServicio labService;

        public Eliminar_Laboratorio(long id)
        {
            labService = new LaboratoriosServicio();
            laboratorio = labService.GetLaboratorio(id);
            InitializeComponent();
        }

        public void CargarMenu()
        {
            Form menu = new FrmMenu_Principal();
            menu.Show();
        }

        private void BtnE_Laboratorio_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaLaboratorio();
                CerrarFormulario();
                CargarMenu();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DarBajaLaboratorio()
        {
            labService.DarBajaLaboratorio(laboratorio);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }
        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnEL_Cancelar_Click(object sender, EventArgs e)
        {
            CargarMenu();
        }

    }
}
