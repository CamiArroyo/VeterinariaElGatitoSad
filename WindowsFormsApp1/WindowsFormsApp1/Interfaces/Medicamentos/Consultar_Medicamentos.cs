﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    public partial class Frm_Consultar_Medicamentos : Form
    {
        public Frm_Consultar_Medicamentos()
        {
            InitializeComponent();
        }

        private void Frm_Consultar_Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'medicamentos.MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            this.mEDICAMENTOSTableAdapter.Fill(this.medicamentos.MEDICAMENTOS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}