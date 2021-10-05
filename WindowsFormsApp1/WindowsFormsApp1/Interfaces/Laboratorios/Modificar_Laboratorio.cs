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

    public partial class Modificar_Laboratorio : Form
    {
        private Laboratorio lab;
        private LaboratoriosServicio lab_Servicios;
        public Modificar_Laboratorio(int id)
        {
            lab_Servicios = new LaboratoriosServicio();
            lab = lab_Servicios.GetLaboratorio(id);
            InitializeComponent();
        }

        private void TomarDatosLaboratorio()
        {
            lab.direccion = Txt_Direccion.Text;
            lab.razon_social = Txt_Razon_Social.Text;
        }

        private void ActualizarLaboratorio()
        {
            lab_Servicios.ActualizarLaboratorio(lab);
            MessageBox.Show("Se actualizo el laboratorio con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }


        private void CargarDatos()
        {
            Txt_Direccion.Text = lab.direccion;
            Txt_Razon_Social.Text = lab.razon_social;
        }

        

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosLaboratorio();
                ActualizarLaboratorio();
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
            
            Form consultar_laboratorios = new Consultar_Laboratorio();
            consultar_laboratorios.Show();
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_laboratorio = new Consultar_Laboratorio();
            consultar_laboratorio.Show();
            this.Dispose();
        }
    }
}
