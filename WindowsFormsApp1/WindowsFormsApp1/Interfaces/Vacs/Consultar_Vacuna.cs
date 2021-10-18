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

namespace WindowsFormsApp1.Interfaces.Vacs
{
    public partial class Frm_Consultar_Vacuna : Form
    {
        private VacunasServicio vacService;
        private Vacuna vac;

        public Frm_Consultar_Vacuna()
        {
            vac = new Vacuna();
            vacService = new VacunasServicio();
            InitializeComponent();
        }

        

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Detalle_Click(object sender, EventArgs e)
        {
            Form detalle = new Frm_Ver_Detalle();
            detalle.Show();
            this.Dispose();
        }

        private void Btn_Editar_Vacuna_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Vacuna.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(Dgw_Consultar_Vacuna.SelectedRows[0].Cells["idvacunaDataGridViewTextBoxColumn"].Value);
                new Frm_Modificar_Vacuna(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Eliminar_Vacuna_Click(object sender, EventArgs e)
        {
            if (Dgw_Consultar_Vacuna.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(Dgw_Consultar_Vacuna.SelectedRows[0].Cells["idvacunaDataGridViewTextBoxColumn"].Value);
                new Frm_Eliminar_Vacuna(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Dgw_Consultar_Vacuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Consultar_Vacuna_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet11.VACUNAS' Puede moverla o quitarla según sea necesario.
            this.vACUNASTableAdapter3.Fill(this._PAV_3K2_2021_12DataSet11.VACUNAS);

        }
    }
}
