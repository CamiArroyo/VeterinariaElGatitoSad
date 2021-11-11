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
    public partial class Frm_Eliminar_Detalle : Form
    {
        private Detalle_calendario_vac detalle;
        private DetalleCalendarioVacServicio detalle_servicio;

        public Frm_Eliminar_Detalle(int ndd)
        {
            detalle_servicio = new DetalleCalendarioVacServicio();
            detalle = detalle_servicio.GetDetalleCalendario(ndd);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaDetalle();
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

        private void DarBajaDetalle()
        {
            detalle_servicio.EliminarDetallePendiente(detalle);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
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
