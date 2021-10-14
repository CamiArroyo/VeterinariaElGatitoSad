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
using WindowsFormsApp1.Interfaces.Mascotas;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Consultas
{
    public partial class Frm_Consultas_Mascota_Select : Form
    {
        public int id_mascota_select;

        private Consulta cons;
        private ConsultasServicio consul_service;

        public Frm_Consultas_Mascota_Select(int id)
        {
            cons = new Consulta();
            consul_service = new ConsultasServicio();
            id_mascota_select = id;
            InitializeComponent();
        }

        public Frm_Consultas_Mascota_Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form salir = new Frm_Consultar_Mascota();
            salir.Show();
            this.Dispose();
        }

        private void Frm_Consultas_Mascota_Select_Load(object sender, EventArgs e)
        {
            ConsultaMascota(id_mascota_select);
        }

        private void ConsultaMascota(int id)
        {
            var ds = consul_service.GetBuscquedaMedicamento(id);

            DataGrd_Consultas_Mascota.Rows.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataGrd_Consultas_Mascota.Rows.Add(row["Número_Historia_Clinica"], row["Número_Consulta"], row["Fecha_Ingreso"], row["FechaEgreso"], row["Temperatura"], row["Observaciones"],
                    row["Tratamiento"], row["Nombre"], row["Dueño"], row["Número_Empleado"], row["Empleado"]);

            }
        }

        private void DataGrd_Consultas_Mascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
