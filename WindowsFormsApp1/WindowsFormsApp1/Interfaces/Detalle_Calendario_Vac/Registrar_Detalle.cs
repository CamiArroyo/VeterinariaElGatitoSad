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

namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    public partial class Frm_Registrar_Detalle : Form
    {
        public int nro_calendario;

        private Detalle_calendario_vac detalle;
        private DetalleCalendarioVacServicio detalle_servicio;

        private Calendario_Vacunacion mi_calendario;
        private CalendariosVacServicio calendario_servicio;

        public Frm_Registrar_Detalle(int nro)
        { //nro es el numero de calendario seleccionado

            nro_calendario = nro;
            detalle = new Detalle_calendario_vac();
            detalle_servicio = new DetalleCalendarioVacServicio();

            calendario_servicio = new CalendariosVacServicio();
            mi_calendario = calendario_servicio.GetCalendarioXNumCal(nro_calendario);
            InitializeComponent();
        }

        private void Lbl_Dosis_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosDetalle()
        {
            Lbl_Nro_HC.Text = mi_calendario.nro_historia_clinica;
            Lbl_Nro_CV.Text = mi_calendario.nro_calendario_vac.ToString();
        }

        private void Frm_Registrar_Detalle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSVacunasConStock.VACUNAS' table. You can move, or remove it, as needed.
            this.vACUNASTableAdapter.Fill(this.dSVacunasConStock.VACUNAS);
            // TODO: This line of code loads data into the 'empleados.EMPLEADOS' table. You can move, or remove it, as needed.
            this.eMPLEADOSTableAdapter.Fill(this.empleados.EMPLEADOS);
            CargarDatosDetalle();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsDetalleValido())
                    return;
                RegistrarDetalle(detalle);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(nro_calendario);
            menu.Show();
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsDetalleValido()
        {
            var nro_historia_clinica = Convert.ToInt32(Lbl_Nro_HC);
            var nro_cal = nro_calendario;
            var id_vacuna = Convert.ToInt32(Cmb_Vacuna.Text);
            var dosis = Txt_Dosis.Text;
            var fecha_prev = Convert.ToDateTime(Dtp_Fecha_Prevista.Text);
            var fecha_real = Convert.ToDateTime(Dtp_Fecha_Real.Text);
            var id_empleado = Convert.ToInt32(Cmb_Empleado.Text);
            var estado = "Creado";

            var det = new Detalle_calendario_vac(nro_historia_clinica, nro_cal, id_vacuna, fecha_prev, fecha_real, dosis, id_empleado, estado);
            detalle = det;
            return true;
        }

        private void RegistrarDetalle(Detalle_calendario_vac detalle)
        {
            if (!detalle_servicio.RegistrarDetalle(detalle))
            {
                MessageBox.Show("Ocurrió un problema al registrar la consulta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡Se registro la consulta con exito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(nro_calendario);
            menu.Show();
            this.Dispose();
        }

    }
}
