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

namespace WindowsFormsApp1.Interfaces.Especies
{
    public partial class Frm_Registrar_Especie : Form
    {
        private Especie especie;
        private EspeciesServicio especie_servicio;

        public Frm_Registrar_Especie()
        {
            especie_servicio = new EspeciesServicio();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!SeRegistraEspecie())
                    return;
                RegistrarEspecie(especie);
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

        private bool SeRegistraEspecie()
        {
            var nombre = Txt_Nombre.Text;
            var descripcion = Txt_Descripcion.Text;
            var cuidados = Txt_Cuidados.Text;

            var especie_ingresada = new Especie(nombre, descripcion, cuidados);
            especie = especie_ingresada;
            return true;
        }

        private void RegistrarEspecie(Especie especie)
        {
            if (!especie_servicio.RegistrarEspecie(especie))
            {
                MessageBox.Show("Ocurrió un problema al registrar la especie", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡La especie se registró con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
