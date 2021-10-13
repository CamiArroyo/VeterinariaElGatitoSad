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
    public partial class Frm_Modificar_Raza : Form
    {
        private Raza raza;
        private RazasServicio raza_servicio;

        public Frm_Modificar_Raza(int id)
        {
            raza_servicio = new RazasServicio();
            raza = raza_servicio.GetRaza(id);
            InitializeComponent();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosRaza();
                ActualizarRaza();
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

            Form consultar_especies = new Frm_Consultar_Raza();
            consultar_especies.Show();
            this.Dispose();
        }

        private void TomarDatosRaza()
        {
            raza.nombre = Txt_Nombre.Text;
            raza.id_especie = Cmb_Especie.Text;
            raza.descripcion = Txt_Descripcion.Text;
            raza.peso_medio = Txt_Peso_Medio.Text;
            raza.altura_media = Txt_Altura_Media.Text;
        }

        private void ActualizarRaza()
        {
            raza_servicio.ActualizarRaza(raza);
            MessageBox.Show("¡Se actualizo la raza con éxito!", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_razas = new Frm_Consultar_Raza();
            consultar_razas.Show();
            this.Dispose();
        }

        private void Frm_Modificar_Raza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PAV_3K2_2021_12DataSet5.ESPECIES' table. You can move, or remove it, as needed.
            this.eSPECIESTableAdapter.Fill(this._PAV_3K2_2021_12DataSet5.ESPECIES);

        }
    }
}
