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

namespace WindowsFormsApp1.Interfaces.Diagnosticos
{
    public partial class Frm_Registrar_Diagnostico : Form
    {
        private Diagnostico diag;
        private DiagnosticosServicio diag_serv;

        public Frm_Registrar_Diagnostico()
        {
            diag_serv = new DiagnosticosServicio();
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsDiagnosticoValido())
                    return;
                RegistrarDiagnostico(diag);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsDiagnosticoValido()
        {
            var nombre = Txt_Nombre.Text;
            var descripcion = Txt_Descripcion.Text;

            var diag_ingresado = new Diagnostico(nombre, descripcion);
            diag = diag_ingresado;
            return true;
        }

        private void RegistrarDiagnostico(Diagnostico diag)
        {
            if (!diag_serv.RegistrarDiagnostico(diag))
            {
                MessageBox.Show("Ocurrió un problema al registrar el diagnóstico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡El diagnóstico se registró con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
        }
    }
}

