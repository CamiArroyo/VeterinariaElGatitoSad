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

namespace WindowsFormsApp1.Interfaces.Diagnosticos
{
    public partial class Frm_Eliminar_Diagnostico : Form
    {
        private Diagnostico diag;
        private DiagnosticosServicio diag_Servicios;

        public Frm_Eliminar_Diagnostico(long id)
        {
            diag_Servicios = new DiagnosticosServicio();
            diag = diag_Servicios.GetDiagnostico(id);
            InitializeComponent();
        }

        public Frm_Eliminar_Diagnostico()
        {
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaDiagnostico();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form consultar_diagnosticos = new Frm_Consultar_Diagnosticos();
            consultar_diagnosticos.Show();
            this.Dispose();
        }

        private void DarBajaDiagnostico()
        {
            diag_Servicios.DarBajaDiagnostico(diag);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_diagnosticos = new Frm_Consultar_Diagnosticos();
            consultar_diagnosticos.Show();
            this.Dispose();
        }
    }
}
