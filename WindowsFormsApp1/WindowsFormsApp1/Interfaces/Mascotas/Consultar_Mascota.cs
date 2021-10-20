using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Calendarios_Vac;
using WindowsFormsApp1.Interfaces.Consultas;

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
            // TODO: esta línea de código carga datos en la tabla 'test1Datos1.Consultar_Mascotas' Puede moverla o quitarla según sea necesario.
            this.consultar_MascotasTableAdapter.DataSet_Test1_Consultar_Mascotas(this.test1Datos1.Consultar_Mascotas);
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
                var ndh = Convert.ToInt32(Dgv_Consultar_Mascotas.SelectedRows[0].Cells["númeroHistoriaClinicaDataGridViewTextBoxColumn"].Value);
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
                var ndh = Convert.ToInt32(Dgv_Consultar_Mascotas.SelectedRows[0].Cells["númeroHistoriaClinicaDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Mascota(ndh).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void mostrarOffToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mostrarOnToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Mostrar_On_Click(object sender, EventArgs e)
        {
            this.consultar_MascotasTableAdapter.FillBy(this.test1Datos1.Consultar_Mascotas);
            Btm_Eliminar_Mascota.Visible = true;
        }

        private void Btn_Mostrar_off_Click(object sender, EventArgs e)
        {
            this.consultar_MascotasTableAdapter.FillBy1(this.test1Datos1.Consultar_Mascotas);
            Btm_Eliminar_Mascota.Visible = false;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new FrmMenu_Principal();
            menu.Show();
            this.Dispose();
        }

        public int tomarMascota() 
        {
            var id_mascota = 0;
            if (Dgv_Consultar_Mascotas.SelectedRows.Count == 1)
            {
                id_mascota = Convert.ToInt32(Dgv_Consultar_Mascotas.SelectedRows[0].Cells["númeroHistoriaClinicaDataGridViewTextBoxColumn"].Value);
                return id_mascota;
            }
            else { MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK); }
            return id_mascota;

        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            var id_mascota = tomarMascota();
            if (id_mascota != 0)
            {
                Form consultas = new Frm_Consultas_Mascota_Select(id_mascota);
                consultas.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No selecciono ninguna mascota.", "Error", MessageBoxButtons.OK); }
        }

        private void Btn_Ver_Calendarios_Vac_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Calendarios_Vac();
            menu.Show();
            this.Dispose();
        }

        private void Dgv_Consultar_Mascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
