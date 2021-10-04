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

namespace WindowsFormsApp1.Interfaces.Razas
{
    public partial class Frm_Eliminar_Raza : Form
    {
        private Raza raza;
        private RazasServicio raza_servicio;

        public Frm_Eliminar_Raza(long id)
        {
            raza_servicio = new RazasServicio();
            raza = raza_servicio.GetRaza(id);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaRaza();
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

            Form menu = new Frm_Consultar_Raza();
            menu.Show();
        }

        private void DarBajaRaza()
        {
            raza_servicio.DarBajaRaza(raza);
            MessageBox.Show("¡La operación se realizó con éxito!", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Raza();
            menu.Show();
            this.Dispose();
        }
    }
}
