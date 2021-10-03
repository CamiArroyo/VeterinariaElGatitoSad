using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Diagnosticos
{
    public partial class Frm_Consultar_Diagnosticos : Form
    {
        public Frm_Consultar_Diagnosticos()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Diagnosticos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet3.DIAGNOSTICOS' table. You can move, or remove it, as needed.
            this.dIAGNOSTICOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet3.DIAGNOSTICOS);
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Diagnosticos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Diagnosticos.SelectedRows[0].Cells["iddiagnosticoDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Diagnostico(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Diagnosticos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Diagnosticos.SelectedRows[0].Cells["iddiagnosticoDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Diagnostico(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_principal = new Fmr_Menu_Sintomatologia();
            menu_principal.Show();
            this.Dispose();
        }
    }
}
