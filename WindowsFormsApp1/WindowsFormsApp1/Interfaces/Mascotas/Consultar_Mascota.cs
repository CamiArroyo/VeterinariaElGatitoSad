using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Mascotas
{
    public partial class Frm_Consultar_Mascota : Form
    {
        public Frm_Consultar_Mascota()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Mascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet7.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter1.Fill(this._PAV_3K2_2021_12DataSet7.MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet6.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet6.MASCOTAS);

        }

        private void Btm_Registrar_Mascota_Click(object sender, EventArgs e)
        {
            Form registrar_mas = new Frm_Registrar_Mascota();
            registrar_mas.Show();
            Visible = false;
        }

        private void Btm_Modificar_Mascota_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Mascotas.SelectedRows.Count == 1)
            {
                var ndh = Convert.ToInt32(Dgv_Consultar_Mascotas.SelectedRows[0].Cells["nrohistoriaclinicaDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Mascota(ndh).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btm_Eliminar_Mascota_Click(object sender, EventArgs e)
        {
            if (Dgv_Consultar_Mascotas.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var ndh = Convert.ToInt32(Dgv_Consultar_Mascotas.SelectedRows[0].Cells["nrohistoriaclinicaDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Mascota(ndh).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }
    }
}
