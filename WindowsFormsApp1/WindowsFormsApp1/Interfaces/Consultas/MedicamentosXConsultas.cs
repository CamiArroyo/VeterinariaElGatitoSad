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

namespace WindowsFormsApp1.Interfaces.Consultas
{
    public partial class Frm_MedicamentosXConsultas : Form
    {
        //private MedicamentoXConsulta medxcon;
        //private MedicamentoXConsultaServicio medxcon_serv;
        private int nro_historia_clinica;
        private int id_consulta;

        public Frm_MedicamentosXConsultas(int nro_historia_clinica, int id_consulta)
        {
            this.nro_historia_clinica = nro_historia_clinica;
            this.id_consulta = id_consulta;
            //medxcon = new MedicamentoXConsulta();
            //medxcon_serv = new MedicamentoXConsultaServicio();
            InitializeComponent();
        }

        private void MedicamentosXConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            CargarData(nro_historia_clinica, id_consulta);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarData(int nro_historia_clinica, int id_consulta)
        {
            //var ds = medxcon_serv.GetBuscquedaMedicamentoXConsulta(nro_historia_clinica, id_consulta);

            Dtg_Medicamento_x_Consulta.Rows.Clear();
            //foreach (DataRow row in ds.Tables[0].Rows)
            {
                //Dtg_Medicamento_x_Consulta.Rows.Add(row["Número_Consulta"], row["Nombre"], row["Medicamento"], row["Dosis"], row["Periodicidad"]);
            }
        }

    }
}
