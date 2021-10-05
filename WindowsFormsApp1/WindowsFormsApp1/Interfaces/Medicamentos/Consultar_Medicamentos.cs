using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    public partial class Frm_Consultar_Medicamentos : Form
    {
        public Frm_Consultar_Medicamentos()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicamentos.MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            this.mEDICAMENTOSTableAdapter.Fill(this.medicamentos.MEDICAMENTOS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Sintoma_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Medicamentos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Medicamentos.SelectedRows[0].Cells["idmedicamentoDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Medicamento(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Frm_Eliminar_Medicamento_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Medicamentos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Medicamentos.SelectedRows[0].Cells["idmedicamentoDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Medicamento(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }
    }
}
