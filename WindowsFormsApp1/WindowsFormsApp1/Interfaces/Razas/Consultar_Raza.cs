using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Interfaces.Razas
{
    public partial class Frm_Consultar_Raza : Form
    {
        public Frm_Consultar_Raza()
        {
            InitializeComponent();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Form menu_registrar_especie = new Frm_Eliminar_Raza();
            menu_registrar_especie.Show();
            this.Dispose();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Form menu_registrar_especie = new Frm_Modificar_Raza();
            menu_registrar_especie.Show();
            this.Dispose();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu_registrar_especie = new Frm_Menu_Animales();
            menu_registrar_especie.Show();
            this.Dispose();
        }
    }
}
