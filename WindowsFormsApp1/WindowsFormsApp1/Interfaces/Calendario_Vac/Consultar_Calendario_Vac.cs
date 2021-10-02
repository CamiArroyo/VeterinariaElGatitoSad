using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Calendario_Vac
{
    public partial class Consultar_Calendario_Vac : Form
    {
        public Consultar_Calendario_Vac()
        {
            InitializeComponent();
        }

        private void Consultar_Calendario_Vac_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'calendario_Vac.CALENDARIO_VAC' Puede moverla o quitarla según sea necesario.
            this.cALENDARIO_VACTableAdapter.Fill(this.calendario_Vac.CALENDARIO_VAC);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
