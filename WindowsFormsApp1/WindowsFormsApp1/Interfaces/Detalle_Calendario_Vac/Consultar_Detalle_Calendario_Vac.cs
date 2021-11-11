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
using WindowsFormsApp1.Interfaces.Calendarios_Vac;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    public partial class Frm_Consultar_Detalle_Calendario_Vac : Form
    {
        public int nro_hist_clinica_select;
        public int nro_calendario_select;

        private DetalleCalendarioVacServicio consul_service;

        public Frm_Consultar_Detalle_Calendario_Vac(int nro_hist_clinica, int nro_calendario)
        { //id es el nro de calendario
            consul_service = new DetalleCalendarioVacServicio();
            nro_hist_clinica_select = nro_hist_clinica;
            nro_calendario_select = nro_calendario;
            InitializeComponent();
        }

        private void Frm_Consultar_Detalle_Calendario_Vac_Load(object sender, EventArgs e)
        {
           Consulta_Calendario(nro_calendario_select);

        }

        private void Consulta_Calendario(int nro)
        {
            var ds = consul_service.GetBusquedaCalendario(nro);

            Dgv_Consultar_Detalle_Calendario_Vac.Rows.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Dgv_Consultar_Detalle_Calendario_Vac.Rows.Add(row["Nro_Detalle"], row["Id_Vacuna"], row["Nombre_Vacuna"], row["Dosis_Vacuna"], row["Fecha_Prevista"], row["Fecha_Real"], row["Nombre_Empleado"], row["Estado"]);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Calendarios_Vac();
            menu.Show();
            this.Dispose();
        }

        private void Btn_Agregar_Vacunacion_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Registrar_Detalle(nro_hist_clinica_select, nro_calendario_select);
            menu.Show();
            this.Dispose();
        }

        //TOMO UN DETALLE DE CALENDARIO
        public (int,string) tomarDetalleCalendario()
        {
            var nro_detalle = 0;
            var estado = "";
            if (Dgv_Consultar_Detalle_Calendario_Vac.SelectedRows.Count == 1)
            {
                nro_detalle = Convert.ToInt32(Dgv_Consultar_Detalle_Calendario_Vac.SelectedRows[0].Cells["Nro_Detalle"].Value);
                estado = Convert.ToString(Dgv_Consultar_Detalle_Calendario_Vac.SelectedRows[0].Cells["Estado"].Value);
                return (nro_detalle, estado);
            }
            else { MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK); }
            return (nro_detalle, estado);
        }

        //MODIFICAR UNA VACUNACIÓN, DE "PENDIENTE" A "CONFIRMADA"
        private void Btn_Modificar_Vacunacion_Click(object sender, EventArgs e)
        {
            var (nro_detalle, estado) = tomarDetalleCalendario();
            if (nro_detalle != 0)
            {
                if (estado == "Confirmada")
                {
                    MessageBox.Show("Esta vacunación ya está confirmada.", "No se puede confirmar", MessageBoxButtons.OK);
                    return;
                }
                Form modificar = new Frm_Modificar_Detalle(nro_detalle);
                modificar.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ninguna vacunación", "Error", MessageBoxButtons.OK); }
        }

        //ELIMINAR UNA VACUNACIÓN "PENDIENTE"
        private void Btn_Eliminar_Vacunacion_Click(object sender, EventArgs e)
        {
            var (nro_detalle, estado) = tomarDetalleCalendario();
            if (nro_detalle != 0)
            {
                if (estado == "Confirmada")
                {
                    MessageBox.Show("Solo pueden eliminarse vacunaciones pendientes, es decir, que aún no han sido confirmadas.", "No se puede eliminar", MessageBoxButtons.OK);
                    return;
                }
                Form eliminar = new Frm_Eliminar_Detalle(nro_detalle);
                eliminar.Show();
                this.Dispose();
            }
            else { MessageBox.Show("No seleccionó ninguna vacunación", "Error", MessageBoxButtons.OK); }
        }
    }
}
