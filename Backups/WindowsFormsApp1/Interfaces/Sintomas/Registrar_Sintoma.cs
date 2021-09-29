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
using WindowsFormsApp1.RepositoriosBD;
using WindowsFormsApp1.Servicios;


namespace WindowsFormsApp1.Interfaces.Sintomas
{
    public partial class Frm_Registrar_Sintoma : Form
    {
        private Sintoma sint;
        private SintomasServicio sint_serv;
        public Frm_Registrar_Sintoma()
        {
            InitializeComponent();
        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        private void Registrar_Sintoma_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
        }

        private void RegistrarSintoma(Sintoma sint)
        {
            if (!sint_serv.RegistrarSintomaSR(sint))
            {
                MessageBox.Show("Ocurrió un problema al registrar el sintoma", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El empleado se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Registrar_Sintoma_Click(object sender, EventArgs e)
        {

            try
            {
                if (!EsOperacionConfirmada())
                    return;
                RegistrarSintoma(sint);
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
        }
    }
}
