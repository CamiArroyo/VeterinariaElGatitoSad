using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Especies
{
    public partial class Frm_Consultar_Especies : Form
    {
        public Frm_Consultar_Especies()
        {
            InitializeComponent();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Especies.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgw_Consultar_Especies.SelectedRows[0].Cells["idespecieDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Especie(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Especies.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgw_Consultar_Especies.SelectedRows[0].Cells["idespecieDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Especie(id).Show(); 
                 Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_principal = new Frm_Menu_Animales();
            menu_principal.Show();
            this.Dispose();
        }

        private void Frm_Consultar_Especie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet2.ESPECIES' table. You can move, or remove it, as needed.
            this.eSPECIESTableAdapter.Fill(this._PAV_3K2_2021_12DataSet2.ESPECIES);
        }
    }
}
