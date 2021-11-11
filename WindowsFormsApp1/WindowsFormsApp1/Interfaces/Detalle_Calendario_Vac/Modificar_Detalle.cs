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
    public partial class Frm_Modificar_Detalle : Form
    {
        private Detalle_calendario_vac detalle;
        private DetalleCalendarioVacServicio detalle_servicio;

        public Frm_Modificar_Detalle(int ndd)
        {
            detalle_servicio = new DetalleCalendarioVacServicio();
            detalle = detalle_servicio.GetDetalleCalendario(ndd);
            InitializeComponent();
        }

        private void CargarDatosDetalle()
        {

            Lbl_Nro_HC.Text = detalle.nro_historia_clinica.ToString(); //se muestra fijo
            Lbl_Nro_CV.Text = detalle.nro_calendario_vac.ToString(); //se muestra fijo
            Lbl_Nro_Det.Text = detalle.nro_detalle_calendario.ToString(); //se muestra fijo
            Lbl_ID_Vac.Text = detalle.id_vacuna.ToString(); //se muestra fijo 
            Txt_Dosis.Text = detalle.dosis; //se puede cambiar
            Lbl_Fecha_Prev.Text = detalle.fecha_prevista.ToString(); //se muestra fijo
        }

        private void Frm_Modificar_Detalle_Load(object sender, EventArgs e)
        {
            this.Cmb_Empleado.DisplayMember = "nombre";
            this.Cmb_Empleado.ValueMember = "id_empleado";

            // TODO: This line of code loads data into the 'empleados.EMPLEADOS' table. You can move, or remove it, as needed.
            this.eMPLEADOSTableAdapter.Fill(this.empleados.EMPLEADOS);

            CargarDatosDetalle();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosDetalleCalendario();
                ModificarDetalle();
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

            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(detalle.nro_historia_clinica, detalle.nro_calendario_vac);
            menu.Show();
            this.Dispose();
        }

        private void TomarDatosDetalleCalendario()
        {
            detalle.dosis = Txt_Dosis.Text;
            detalle.fecha_real = Dtp_Fecha_Real.Value;
            var id_emp = Convert.ToInt32(Cmb_Empleado.SelectedValue);
            detalle.id_empleado = id_emp;
        }

        private void ModificarDetalle()
        {
            detalle_servicio.ModificarDetalle(detalle);
            MessageBox.Show("Se registró la confirmación de vacunación con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Detalle_Calendario_Vac(detalle.nro_historia_clinica, detalle.nro_calendario_vac);
            menu.Show();
            this.Dispose();
        }
    }
}
