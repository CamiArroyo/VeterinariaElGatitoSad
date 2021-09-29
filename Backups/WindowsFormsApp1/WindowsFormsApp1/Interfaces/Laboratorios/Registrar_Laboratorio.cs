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

namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    public partial class Registrar_Laboratorio : Form
    {
        private Laboratorio lab;
        private LaboratoriosServicio labService;


        public Registrar_Laboratorio()
        {
            labService = new LaboratoriosServicio();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRL_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }

        private void BtnRL_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsLaboratorioValido())
                    return;
                RegistrarLaboratorio(lab);
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

            Form menu = new Frm_Menu_Insumos();
            menu.Show();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsLaboratorioValido()
        {
            var razon_social = TxtRL_Razon_Social.Text;
            var direccion = TxtRL_Direccion.Text;

            var labIngresado = new Laboratorio(razon_social, direccion);
            lab = labIngresado;
            return true;
        }

        private void RegistrarLaboratorio(Laboratorio lab)
        {
            if (!labService.RegistrarLaboratorio(lab))
            {
                MessageBox.Show("Ocurrió un problema al registrar el empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El laboratorio se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
