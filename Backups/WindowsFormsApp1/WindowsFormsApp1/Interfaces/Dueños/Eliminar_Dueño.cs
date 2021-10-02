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
    public partial class Frm_Eliminar_Dueño : Form
    {
        private Dueño due;
        private DueñosServicio dueService;

        public Frm_Eliminar_Dueño(long id)
        {
            dueService = new DueñosServicio();
            due = dueService.GetDueño(id);
            InitializeComponent();
        }

        private void BtnE_Cancelar_Click(object sender, EventArgs e)
        {
            Form Cmenu = new Frm_Consultar_Dueños();
            Cmenu.Show();
            this.Dispose();
        }

        private void BtnE_Dueño_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaDueño();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form ConsultDueño = new Frm_Consultar_Dueños();
            ConsultDueño.Show();
            this.Dispose();
        }

        private void DarBajaDueño()
        {
            dueService.DarBajaDueño(due);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }
    }
}
