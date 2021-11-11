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
using WindowsFormsApp1.Interfaces.Mascotas;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    public partial class Frm_Registrar_Calendario_Vac : Form
    {
        private Calendario_Vacunacion cal;
        private CalendariosVacServicio cal_servicio;

        public Frm_Registrar_Calendario_Vac()
        {
            cal_servicio = new CalendariosVacServicio();
            InitializeComponent();
        }

        private void Frm_Registrar_Calendario_Vac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMascotasSinCalendario.MASCOTAS' table. You can move, or remove it, as needed.
            this.mASCOTASTableAdapter1.Fill(this.dSMascotasSinCalendario.MASCOTAS);
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet13.MASCOTAS' table. You can move, or remove it, as needed.
            this.mASCOTASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet13.MASCOTAS);
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsCalendarioValido())
                    return;
                RegistrarCalendario(cal);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Frm_Consultar_Mascota();
            menu.Show();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsCalendarioValido()
        {
            var nroHist = Cmb_Nro_Historia_Clinica.Text;
            var fechaIni = Dtp_Fecha_Inicio.Value;
            var obs = Txt_Observaciones.Text;
            var est = "Activo";

            var cal_ingresado = new Calendario_Vacunacion(nroHist, fechaIni, obs, est);
            cal = cal_ingresado;
            return true;
        }

        private void RegistrarCalendario(Calendario_Vacunacion cal)
        {
            if (!cal_servicio.RegistrarCalendario(cal))
            {
                MessageBox.Show("Ocurrió un problema al registrar el calendario de vacunación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡El calendario de vacunación se registró con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Calendarios_Vac();
            menu.Show();
            this.Dispose();
        }

    }
}
