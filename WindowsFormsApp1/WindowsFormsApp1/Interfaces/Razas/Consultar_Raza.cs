using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Razas
{
    public partial class Frm_Consultar_Raza : Form
    {
        public Frm_Consultar_Raza()
        {
            InitializeComponent();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Razas.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Razas.SelectedRows[0].Cells["idrazaDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Raza(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Razas.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(Dgv_Consultar_Razas.SelectedRows[0].Cells["idrazaDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Raza(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_registrar_especie = new Frm_Menu_Animales();
            menu_registrar_especie.Show();
            this.Dispose();
        }

        private void Frm_Consultar_Raza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet4.RAZAS' table. You can move, or remove it, as needed.
            this.rAZASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet4.RAZAS);

        }
    }
}
