using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac;
using WindowsFormsApp1.Interfaces.Mascotas;

namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    public partial class Frm_Consultar_Calendarios_Vac : Form
    {
        public Frm_Consultar_Calendarios_Vac()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Calendarios_Vac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calendariosVac.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.calendariosVac.DataTable1);
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet7.CALENDARIO_VAC' table. You can move, or remove it, as needed.
            this.cALENDARIO_VACTableAdapter.Fill(this._PAV_3K2_2021_12DataSet7.CALENDARIO_VAC);
        }

        //REGISTRAR UN CALENDARIO
        private void Btn_Agregar_Calendario_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Registrar_Calendario_Vac();
            menu.Show();
            this.Dispose();
        }

        //tomar un calendario
        public (int,string) tomarCalendario()
        {
            var nro_hist_clinica = 0;
            var estado = "";
            if (Dgv_Consultar_Calendario_Vac.SelectedRows.Count == 1)
            {
                nro_hist_clinica = Convert.ToInt32(Dgv_Consultar_Calendario_Vac.SelectedRows[0].Cells["nDeHistoriaClínicaDataGridViewTextBoxColumn"].Value);
                estado = Convert.ToString(Dgv_Consultar_Calendario_Vac.SelectedRows[0].Cells["estadoDataGridViewTextBoxColumn"].Value);

                return (nro_hist_clinica, estado);

            }
            else { MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK); }
            return (nro_hist_clinica, estado);
        }

        public (int, int) tomarCalendario2()
        {
            var nro_hist_clinica = 0;
            var nro_calendario = 0;
            if (Dgv_Consultar_Calendario_Vac.SelectedRows.Count == 1)
            {
                nro_hist_clinica = Convert.ToInt32(Dgv_Consultar_Calendario_Vac.SelectedRows[0].Cells["nDeHistoriaClínicaDataGridViewTextBoxColumn"].Value);
                nro_calendario = Convert.ToInt32(Dgv_Consultar_Calendario_Vac.SelectedRows[0].Cells["nDeCalendarioDataGridViewTextBoxColumn"].Value);

                return (nro_hist_clinica, nro_calendario);

            }
            else { MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK); }
            return (nro_hist_clinica, nro_calendario);
        }

        //VER DETALLE DE UN CALENDARIO
        private void Btn_Ver_Detalle_Click(object sender, EventArgs e)
        {
            var (nro_hist_clinica, nro_calendario) = tomarCalendario2();

            if (nro_hist_clinica != 0)
            {
                Form consultas = new Frm_Consultar_Detalle_Calendario_Vac(nro_hist_clinica, nro_calendario);
                consultas.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ningún calendario.", "Error", MessageBoxButtons.OK); }
        }

        //MODIFICAR UN CALENDARIO
        private void Btn_Modificar_Calendario_Click(object sender, EventArgs e)
        {
            var (id_calendario, estado) = tomarCalendario();
            if (id_calendario != 0)
            {
                Form modificar = new Frm_Modificar_Calendario_Vac(id_calendario);
                modificar.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ningún calendario.", "Error", MessageBoxButtons.OK); }
        }

        //PASAR UN CALENDARIO A "INACTIVO"
        private void Btn_Eliminar_Calendario_Click(object sender, EventArgs e)
        {
            var (id_calendario, estado) = tomarCalendario();
            if (id_calendario != 0)
            {
                if (estado == "Inactivo")
                {
                    MessageBox.Show("Este calendario ya está inactivo.", "No se puede desactivar", MessageBoxButtons.OK);
                    return;
                }

                Form modificar = new Frm_Eliminar_Calendario_Vac(id_calendario);
                modificar.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ningún calendario.", "Error", MessageBoxButtons.OK); }
        }

        //PASAR UN CALENDARIO A "ACTIVO"
        private void Btn_Activar_Calendario_Click(object sender, EventArgs e)
        {
            var (id_calendario, estado) = tomarCalendario();
            if (id_calendario != 0)
            {
                if (estado == "Activo")
                {
                    MessageBox.Show("Este calendario ya está activo.", "No se puede activar", MessageBoxButtons.OK);
                    return;
                }

                Form modificar = new Frm_Activar_Calendario_Vac(id_calendario);
                modificar.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ningún calendario.", "Error", MessageBoxButtons.OK); }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Mascota();
            menu.Show();
            this.Dispose();
        }

    }
}
