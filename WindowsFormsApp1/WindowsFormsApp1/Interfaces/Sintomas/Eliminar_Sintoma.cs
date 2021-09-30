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

namespace WindowsFormsApp1.Interfaces.Sintomas
{
    public partial class Frm_Eliminar_Sintoma : Form
    {
        private Sintoma sint;
        private SintomasServicio sintService;

        public Frm_Eliminar_Sintoma(long id)
        {
            sintService = new SintomasServicio();
            sint = sintService.GetSintoma(id);
            InitializeComponent();
        }

        private void BtnE_Cancelar_Sintoma_Click(object sender, EventArgs e)
        {
            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
            this.Dispose();
        }

        private void BtnE_Sintoma_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaSintoma();
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

            Form menu_sint = new Fmr_Menu_Sintomatologia();
            menu_sint.Show();
        }

        private void DarBajaSintoma()
        {
            sintService.DarBajaSintoma(sint);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Frm_Eliminar_Sintoma_Load(object sender, EventArgs e)
        {

        }
    }
}
