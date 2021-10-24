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
    public partial class Frm_Agregar_Consulta : Form
    {
        private int nro_historia_clinica;
        public Frm_Agregar_Consulta()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form consultas = new Frm_Consultar_Mascota();
            consultas.Show();
            this.Dispose();
        }

        private void Frm_Agregar_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleados.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            this.eMPLEADOSTableAdapter.Fill(this.empleados.EMPLEADOS);

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {

        }
    }
}
