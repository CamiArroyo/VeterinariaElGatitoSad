using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Sintomas;

namespace WindowsFormsApp1.Interfaces
{
    public partial class Fmr_Menu_Sintomatologia : Form
    {
        public Fmr_Menu_Sintomatologia()
        {
            InitializeComponent();
        }

        private void Btn_Sintomatologia_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new FrmMenu_Principal();
            menu.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Sintoma_Click(object sender, EventArgs e)
        {
            Form reg_sint = new Frm_Registrar_Sintoma();
            reg_sint.Show();
            this.Dispose();
        }

        private void Btn_Consultar_Sintoma_Click(object sender, EventArgs e)
        {
            Form consultar_sint = new Frm_Consultar_Sintoma();
            consultar_sint.Show();
            this.Dispose();
        }
    }
}
