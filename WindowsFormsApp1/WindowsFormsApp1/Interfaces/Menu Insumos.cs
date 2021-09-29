using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Laboratorios;

namespace WindowsFormsApp1.Interfaces
{
    public partial class Frm_Menu_Insumos : Form
    {
        public Frm_Menu_Insumos()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_prin = new FrmMenu_Principal();
            menu_prin.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Laboratorio_Click(object sender, EventArgs e)
        {
            Form labs = new Registrar_Laboratorio();
            labs.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Laboratorio_Click(object sender, EventArgs e)
        {
            Form Clab = new Consultar_Laboratorio();
            Clab.Show();
            this.Dispose();
        }
    }
}
