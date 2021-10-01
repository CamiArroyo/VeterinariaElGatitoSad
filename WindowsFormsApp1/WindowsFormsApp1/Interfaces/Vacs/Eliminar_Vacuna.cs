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

namespace WindowsFormsApp1.Interfaces.Vacs
{
    public partial class Frm_Eliminar_Vacuna : Form
    {
        private Vacuna vac;
        private VacunasServicio vacService;

        public Frm_Eliminar_Vacuna(long id)
        {
            vacService = new VacunasServicio();
            vac = vacService.GetVacuna(id);
            InitializeComponent();
        }

        private void BtnE_Cancelar_Vacuna_Click(object sender, EventArgs e)
        {
            Form consultarvac = new Frm_Consultar_Vacuna();
            consultarvac.Show();
            this.Dispose();
        }

        private void BtnE_Vacuna_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaVacuna();
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

            Form menuxD = new Frm_Consultar_Vacuna();
            menuxD.Show();
            this.Dispose();
        }

        private void DarBajaVacuna()
        {
            vacService.DarBajaVacuna(vac);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

    }
}
