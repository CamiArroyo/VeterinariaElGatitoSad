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

namespace WindowsFormsApp1.Interfaces.Dueños
{
    public partial class Frm_Modificar_Dueño : Form
    {
        private Dueño due;
        private DueñosServicio dueService;

        public Frm_Modificar_Dueño(int id)
        {
            dueService = new DueñosServicio();
            due = dueService.GetDueño(id);
            InitializeComponent();
        }

        private void BtnM_Guardar_Cambios_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosDueño();
                ActualizarDueño();
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

            Form RCDueño = new Frm_Consultar_Dueños();
            RCDueño.Show();
            this.Dispose();
        }

        private void TomarDatosDueño()
        {
            due.nombre = Txt_Nombre.Text;
            due.apellido = Txt_Apellido.Text;
            due.telefono = Txt_Telefono.Text;
            due.estado = Cb_Estado_Dueño.Text;
        }

        private void ActualizarDueño()
        {
            dueService.ActualizarDueño(due);
            MessageBox.Show("Se actualizo el dueño con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void CargarDatos()
        {
            Txt_Nombre.Text = due.nombre;
            Txt_Apellido.Text = due.apellido;
            Txt_Telefono.Text = due.telefono;
            Cb_Estado_Dueño.Text = due.estado;
        }

        private void Frm_Modificar_Dueño_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12Dueños.DUEÑOS' Puede moverla o quitarla según sea necesario.
            this.dUEÑOSTableAdapter.Fill(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            CargarDatos();
        }

        private void BtnM_Cancelar_Click(object sender, EventArgs e)
        {
            Form CDueño = new Frm_Consultar_Dueños();
            CDueño.Show();
            this.Dispose();
        }
    }
}
