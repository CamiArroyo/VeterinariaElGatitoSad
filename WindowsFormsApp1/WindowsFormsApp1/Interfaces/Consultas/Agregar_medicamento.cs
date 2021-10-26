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

namespace WindowsFormsApp1.Interfaces.Consultas
{
    public partial class Frm_Agregar_Medicamento : Form
    {
        private MedicamentoXConsulta medxcon;
        private MedicamentosXConsultasServicio medxcon_serv;
        private int nro_historia_clinica;
        private int id_consulta;

        public Frm_Agregar_Medicamento(int nro, int consulta)
        {
            this.nro_historia_clinica = nro;
            this.id_consulta = consulta;
            medxcon = new MedicamentoXConsulta();
            medxcon_serv = new MedicamentosXConsultasServicio();
            InitializeComponent();
        }

        private void Frm_Agregar_Medicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicamentos.MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            this.mEDICAMENTOSTableAdapter.Fill(this.medicamentos.MEDICAMENTOS);

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Agregar_Medicamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsMedicamentovalido())
                    return;
                RegistrarMedicamentoXConsulta(medxcon);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Dispose();
        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsMedicamentovalido()
        {
            var id_mascota = nro_historia_clinica;
            var nro_consulta = id_consulta;
            var medicamento = Convert.ToInt32(Cb_Agregar_medicamento.Text);
            var dosis = Txt_Dosis.Text;
            var periodicidad = Txt_Periodicidad.Text;
            var MedicamentoIngresado = new MedicamentoXConsulta(id_mascota, nro_consulta, medicamento, dosis, periodicidad);
            medxcon = MedicamentoIngresado;
            return true;
        }

        private void RegistrarMedicamentoXConsulta(MedicamentoXConsulta medxcon)
        {
            if (!medxcon_serv.RegistrarMedicamentoXConsulta(medxcon))
            {
                MessageBox.Show("Ocurrió un problema al registrar los medicamentos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡Se registraron con exito los medicamentos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

    }
}
