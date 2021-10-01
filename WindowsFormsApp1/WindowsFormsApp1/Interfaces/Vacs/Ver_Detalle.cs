using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Vacs
{
    public partial class Frm_Ver_Detalle : Form
    {
        public Frm_Ver_Detalle()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form consultar = new Frm_Consultar_Vacuna();
            consultar.Show();
            this.Dispose();
        }
    }
}
