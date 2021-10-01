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
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!SeRegistraRaza())
                    return;
                RegistrarRaza(raza);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            var descr = Txt_Descripcion.Text;
            var peso = Txt_Peso_Medio.Text;
            var altura = Txt_Altura_Media.Text;

            var raza_ingresada = new Raza(nombre, descr, peso, altura);
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
            Form menu = new FrmMenu_Principal();
            menu.Show();
        }
    }
}
