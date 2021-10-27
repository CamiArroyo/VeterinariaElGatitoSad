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

namespace WindowsFormsApp1.Interfaces.Consultas
{
    public partial class Frm_Agregar_Consulta : Form
    {
        private Consulta cons;
        private ConsultasServicio consService;
        private int nro_historia_clinica;
        public Frm_Agregar_Consulta(int nro)
        {
            this.nro_historia_clinica = nro;
            cons = new Consulta();
            consService = new ConsultasServicio();
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form consultas = new Frm_Consultar_Mascota();
            consultas.Show();
            this.Dispose();
        }

        private void Frm_Agregar_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleados.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.EmpleadosActivos(this.empleados.EMPLEADOS);

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsConsultaValida())
                    return;
                RegistrarConsulta(cons);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Dispose();
        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsConsultaValida()
        {
            var nro = nro_historia_clinica;
            var temperatura = Txt_Temperatura.Text;
            var empleado = Convert.ToInt32(Cb_Empleados.Text);
            var fecha_ingreso = Convert.ToDateTime(Dtm_Fecha_Ingreso.Text);
            var fecha_egreso = Convert.ToDateTime(Dtm_Fecha_Egreso.Text);
            var observaciones = Txt_Observaciones.Text;
            var tratamiento = Txt_Tratamiento.Text;
            var consulta = new Consulta(nro, empleado, fecha_ingreso, fecha_egreso, temperatura, observaciones, tratamiento);
            cons = consulta;
            return true;
        }
        private void RegistrarConsulta(Consulta cons)
        {
            if (!consService.RegistrarConsulta(cons))
            {
                MessageBox.Show("Ocurrió un problema al registrar la consulta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡Se registro la consulta con exito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void empleadosActivosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLEADOSTableAdapter.EmpleadosActivos(this.empleados.EMPLEADOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Cb_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
