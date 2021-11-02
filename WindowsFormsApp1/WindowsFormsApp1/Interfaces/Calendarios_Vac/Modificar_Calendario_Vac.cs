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
    public partial class Frm_Modificar_Calendario_Vac : Form
    {
        private Calendario_Vacunacion calendario;
        private CalendariosVacServicio calendario_servicio;

        public Frm_Modificar_Calendario_Vac(int id)
        { //id es el nro_historia_clinica de la mascota
            calendario_servicio = new CalendariosVacServicio();
            calendario = calendario_servicio.GetCalendario(id);
            InitializeComponent();
        }

        private void CargarDatos()
        {
            Lbl_Nro_Historia_Clinica_Selecc.Text = calendario.nro_historia_clinica;
            Dtp_Fecha_Inicio.Value = calendario.fecha_inicio;
            Txt_Observaciones.Text = calendario.observaciones;
            Txt_Estado.Text = calendario.estado;
        }

        private void Frm_Modificar_Calendario_Vac_Load(object sender, EventArgs e)
        {
            //no tengo un Combobox donde se carguen los nro_historia_clinica, porque es un valor fijo
            CargarDatos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosCalendario();
                ActualizarCalendario();
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

        private void TomarDatosCalendario()
        {
            //no tomo el nro_historia_clinica porque es el mismo
            calendario.fecha_inicio = Dtp_Fecha_Inicio.Value;
            calendario.observaciones = Txt_Observaciones.Text;
            calendario.estado = Txt_Estado.Text; //se puede cambiar el estado
        }

        private void ActualizarCalendario()
        {
            calendario_servicio.ActualizarCalendario(calendario);
            MessageBox.Show("Se actualizo el calendario con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
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
