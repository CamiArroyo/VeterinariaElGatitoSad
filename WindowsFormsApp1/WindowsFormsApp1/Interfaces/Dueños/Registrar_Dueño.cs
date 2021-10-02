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
    public partial class Frm_Registrar_Dueños : Form
    {
        private Dueño due;
        private DueñosServicio dueService;

        public Frm_Registrar_Dueños()
        {
            dueService = new DueñosServicio();
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Dueños();
            menu.Show();
            this.Dispose();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!TomarDatosDueño())
                    return;
                RegistrarDueño(due);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form CDueño = new Frm_Consultar_Dueños();
            CDueño.Show();
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool TomarDatosDueño()
        {
            var nombre = Txt_Nombre.Text;
            var apellido = Txt_Apellido.Text;
            var telefono = Txt_Telefono.Text;
            var estado = "Activo";

            var dueño = new Dueño(nombre, apellido, telefono, estado);
            due = dueño;
            return true;
        }

        private void RegistrarDueño(Dueño due)
        {
            if (!dueService.RegistrarDueño(due))
            {
                MessageBox.Show("Ocurrió un problema al registrar La vacuna", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El dueño se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
