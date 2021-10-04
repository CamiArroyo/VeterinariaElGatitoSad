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

namespace WindowsFormsApp1.Interfaces.Razas
{
    public partial class Frm_Registrar_Raza : Form
    {

        private Raza raza;
        private RazasServicio raza_servicio;

        public Frm_Registrar_Raza()
        {
            raza_servicio = new RazasServicio();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {

                if (!EsOperacionConfirmada())
                    return;
                if (!SeRegistraRaza())
                    return;
                RegistrarRaza(raza);


            Form menu = new Frm_Menu_Animales();
            menu.Show();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool SeRegistraRaza()
        {
            var nombre = Txt_Nombre.Text;
            var id_especie = Cmb_Especie.Text;
            var descr = Txt_Descripcion.Text;
            var peso = Txt_Peso_Medio.Text;
            var altura = Txt_Altura_Media.Text;

            var raza_ingresada = new Raza(nombre, id_especie, descr, peso, altura);
            raza = raza_ingresada;
            return true;
        }
        
        private void RegistrarRaza(Raza raza)
        {
            if (!raza_servicio.RegistrarRaza(raza))
            {
                MessageBox.Show("Ocurrió un problema al registrar la raza", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡La raza se registró con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form menu = new Frm_Menu_Animales();
            menu.Show();
        }

        private void Frm_Registrar_Raza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet1.ESPECIES' table. You can move, or remove it, as needed.
            this.eSPECIESTableAdapter.Fill(this._PAV_3K2_2021_12DataSet1.ESPECIES);

        }
    }
}
