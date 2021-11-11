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
        private int nro_calendario;
        private int nro_hist_clinica;

        private Detalle_calendario_vac detalle;
        private DetalleCalendarioVacServicio detalle_servicio;
        private VacunasServicio vacuna_servicio;

        public Frm_Registrar_Detalle(int ndc, int cal)
        {
            this.nro_hist_clinica = ndc;
            this.nro_calendario = cal;
            detalle = new Detalle_calendario_vac();
            detalle_servicio = new DetalleCalendarioVacServicio();
            vacuna_servicio = new VacunasServicio();

            InitializeComponent();
        }

        private void Lbl_Dosis_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosDetalle()
        {
            Lbl_Nro_HC.Text = nro_hist_clinica.ToString();
            Lbl_Nro_CV.Text = nro_calendario.ToString();
        }

        private void Frm_Registrar_Detalle_Load(object sender, EventArgs e)
        {
            this.Cmb_Vacuna.DisplayMember = "nombre";
            this.Cmb_Vacuna.ValueMember = "id_vacuna";

            // TODO: This line of code loads data into the 'dSVacunasConStock.VACUNAS' table. You can move, or remove it, as needed.
            this.vACUNASTableAdapter.Fill(this.dSVacunasConStock.VACUNAS);
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

            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(nro_hist_clinica, nro_calendario);
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
            var nro_historia_clinica = nro_hist_clinica;
            var nro_cal = nro_calendario;
            var id_vacuna = Convert.ToInt32(Cmb_Vacuna.SelectedValue);
            var dosis = Txt_Dosis.Text;
            var fecha_prev = Convert.ToDateTime(Dtp_Fecha_Prevista.Text);
            var estado = "Creado";

            var det = new Detalle_calendario_vac(nro_historia_clinica, nro_cal, id_vacuna, fecha_prev, dosis, estado);
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

            vacuna_servicio.RestarUnoStockVacuna(detalle.id_vacuna);

            MessageBox.Show("¡Se registro la vacunación con exito, y se actualizó el stock de las vacunas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(nro_hist_clinica, nro_calendario);
            menu.Show();
            this.Dispose();
        }

    }
}
