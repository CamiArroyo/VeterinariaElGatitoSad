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

namespace WindowsFormsApp1.Interfaces.Especies
{
    public partial class Frm_Eliminar_Especie : Form
    {
        private Especie esp;
        private EspeciesServicio especie_servicio;

        public Frm_Eliminar_Especie(long id)
        {
            especie_servicio = new EspeciesServicio();
            esp = especie_servicio.GetEspecie(id);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaEspecie();
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

            Form menu = new Frm_Consultar_Especies();
            menu.Show();
        }

        private void DarBajaEspecie()
        {
            especie_servicio.DarBajaEspecie(esp);
            MessageBox.Show("¡La operación se realizó con éxito!", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Especies();
            menu.Show();
            this.Dispose();
        }
    }
}
