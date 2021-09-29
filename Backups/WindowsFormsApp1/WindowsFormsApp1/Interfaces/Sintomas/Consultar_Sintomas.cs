using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Sintomas
{
    public partial class Frm_Consultar_Sintoma : Form
    {
        public Frm_Consultar_Sintoma()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Sintoma_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sintomas.SINTOMAS' Puede moverla o quitarla según sea necesario.
            this.sINTOMASTableAdapter.Fill(this.sintomas.SINTOMAS);
            // TODO: esta línea de código carga datos en la tabla 'vacunas.VACUNAS' Puede moverla o quitarla según sea necesario.
            this.vACUNASTableAdapter.Fill(this.vacunas.VACUNAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
            this.Dispose();
        }
    }
}
