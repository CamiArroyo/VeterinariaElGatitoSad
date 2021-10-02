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

namespace WindowsFormsApp1.Interfaces.Dueños
{
    public partial class Frm_Consultar_Dueños : Form
    {
        private Dueño due;
        private DueñosServicio dueService;
        public Frm_Consultar_Dueños()
        {
            due = new Dueño();
            dueService = new DueñosServicio();
            InitializeComponent();
        }

        private void Frm_Consultar_Dueños_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12Dueños.DUEÑOS' Puede moverla o quitarla según sea necesario.
            this.dUEÑOSTableAdapter.FillBy(this._PAV_3K2_2021_12Dueños.DUEÑOS);

        }

        private void Btn_Registrar_Dueños_Click(object sender, EventArgs e)
        {
            Form Rdueños = new Frm_Registrar_Dueños();
            Rdueños.Show();
            this.Dispose();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menuP = new FrmMenu_Principal();
            menuP.Show();
            this.Dispose();
        }

        private void Btn_Modificar_Dueños_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Dueños.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(Dgw_Consultar_Dueños.SelectedRows[0].Cells["iddueñoDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Dueño(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Dgw_Consultar_Dueños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dUEÑOSTableAdapter.FillBy(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.dUEÑOSTableAdapter.FillBy(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Eliminar_Dueño_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Dueños.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(Dgw_Consultar_Dueños.SelectedRows[0].Cells["iddueñoDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Dueño(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Mostrar_off_Click(object sender, EventArgs e)
        {
            this.dUEÑOSTableAdapter.FillBy1(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            Btn_Eliminar_Dueño.Visible = false;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dUEÑOSTableAdapter.FillBy1(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Btn_Mostrar_On_Click(object sender, EventArgs e)
        {
            this.dUEÑOSTableAdapter.FillBy(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            Btn_Eliminar_Dueño.Visible = true;
        }
    }
}
