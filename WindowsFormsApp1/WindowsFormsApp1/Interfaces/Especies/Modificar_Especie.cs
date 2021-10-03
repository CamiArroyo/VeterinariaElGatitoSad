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
    public partial class Frm_Modificar_Especie : Form
    {
        private Especie esp;
        private EspeciesServicio esp_servicio;

        public Frm_Modificar_Especie(int id)
        {
            esp_servicio = new EspeciesServicio();
            esp = esp_servicio.GetEspecie(id);
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosEspecie();
                ActualizarEspecie();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form consultar_especies = new Frm_Consultar_Especies();
            consultar_especies.Show();
            this.Dispose();
        }

        private void TomarDatosEspecie()
        {
            esp.nombre = Txt_Nombre.Text;
            esp.descripcion = Txt_Descripcion.Text;
            esp.nota_cuidados = Txt_Cuidados.Text;
        }

        private void ActualizarEspecie()
        {
            esp_servicio.ActualizarEspecie(esp);
            MessageBox.Show("¡Se actualizo la especie con éxito!", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void CargarDatos()
        {
            Txt_Nombre.Text = esp.nombre;
            Txt_Descripcion.Text = esp.descripcion;
            Txt_Cuidados.Text = esp.nota_cuidados;
        }

        private void Frm_Modificar_Dueño_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12Dueños.DUEÑOS' Puede moverla o quitarla según sea necesario.
            CargarDatos();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_especie = new Frm_Consultar_Especies();
            consultar_especie.Show();
            this.Dispose();
        }
    }
}
