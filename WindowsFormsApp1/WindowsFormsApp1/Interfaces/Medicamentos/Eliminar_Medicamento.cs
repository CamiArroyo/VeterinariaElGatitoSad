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

namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    public partial class Frm_Eliminar_Medicamento : Form
    {
        private Medicamento med;
        private MedicamentosServicio med_servicio;

        public Frm_Eliminar_Medicamento(long id)
        {
            med_servicio = new MedicamentosServicio();
            med = med_servicio.GetMedicamento(id);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaMedicamento();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Frm_Consultar_Medicamentos();
            menu.Show();
        }

        private void DarBajaMedicamento()
        {
            med_servicio.DarBajaMedicamento(med);
            MessageBox.Show("¡La operación se realizó con éxito!", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Medicamentos();
            menu.Show();
            this.Dispose();
        }
    }
}
