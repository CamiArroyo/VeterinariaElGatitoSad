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

namespace WindowsFormsApp1.Interfaces.Mascotas
{
    public partial class Frm_Eliminar_Mascota : Form
    {
        private Mascota mas;
        private MascotasServicio mas_Servicios;
        public Frm_Eliminar_Mascota(long ndh)
        {
            mas_Servicios = new MascotasServicio();
            mas = mas_Servicios.GetMascota(ndh);
            InitializeComponent();
        }

        private void Btm_Si_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaMascota();
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

            Form ConsultMacota = new Frm_Consultar_Mascota();
            ConsultMacota.Show();
            this.Dispose();
        }
        private void DarBajaMascota()
        {
            mas_Servicios.DarBajaMascota(mas);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btm_No_Click(object sender, EventArgs e)
        {
            Form Cmenu = new Frm_Consultar_Mascota();
            Cmenu.Show();
            this.Dispose();
        }
    }
}
