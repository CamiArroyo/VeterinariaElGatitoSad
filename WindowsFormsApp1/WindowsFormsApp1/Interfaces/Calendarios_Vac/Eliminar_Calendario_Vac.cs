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

namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    public partial class Frm_Eliminar_Calendario_Vac : Form
    {
        private Calendario_Vacunacion calendario;
        private CalendariosVacServicio calendario_servicio;

        public Frm_Eliminar_Calendario_Vac(long id)
        {
            calendario_servicio = new CalendariosVacServicio();
            calendario = calendario_servicio.GetCalendario(id);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaCalendario();
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

            Form consultar_calendarios = new Frm_Consultar_Calendarios_Vac();
            consultar_calendarios.Show();
            this.Dispose();
        }

        private void DarBajaCalendario()
        {
            calendario_servicio.DarBajaCalendario(calendario);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_calendarios = new Frm_Consultar_Calendarios_Vac();
            consultar_calendarios.Show();
            this.Dispose();
        }
    }
}
