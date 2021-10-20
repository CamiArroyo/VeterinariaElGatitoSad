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
        public int nro_calendario_select;
        private Detalle_calendario_vac detalle;
        private DetalleCalendarioVacServicio consul_service;

        public Frm_Consultar_Detalle_Calendario_Vac(int id)
        {
            detalle = new Detalle_calendario_vac();
            consul_service = new DetalleCalendarioVacServicio();
            nro_calendario_select = id;
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
                Dgv_Consultar_Detalle_Calendario_Vac.Rows.Add(row["Nro_Detalle"], row["Nombre_Vacuna"], row["Dosis_Vacuna"], row["Fecha_Prevista"], row["Fecha_Real"], row["Nombre_Empleado"]);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Calendarios_Vac();
            menu.Show();
            this.Dispose();
        }
    }
}
