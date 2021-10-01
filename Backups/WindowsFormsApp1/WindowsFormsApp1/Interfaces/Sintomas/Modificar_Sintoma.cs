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

namespace WindowsFormsApp1.Interfaces.Sintomas
{
    public partial class Frm_Modificar_Sintoma : Form
    {
        private Sintoma sint;
        private SintomasServicio sintService;

        public Frm_Modificar_Sintoma(int id)
        {
            sintService = new SintomasServicio();
            sint = sintService.GetSintoma(id);
            InitializeComponent();
        }

        private void BtnM_Guardar_Cambios_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosSintoma();
                ActualizarSintoma();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
            this.Dispose();
        }

        private void TomarDatosSintoma()
        {
            sint.nombre = Txt_Nombre.Text;
            sint.descripcion = Txt_Descripcion.Text;
        }

        private void ActualizarSintoma()
        {
            sintService.ActualizarSintoma(sint);
            MessageBox.Show("Se actualizo el empleado con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Frm_Modificar_Sintoma_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Txt_Nombre.Text = sint.nombre;
            Txt_Descripcion.Text = sint.descripcion;
        }

        private void BtnM_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Fmr_Menu_Sintomatologia();
            menu.Show();
            this.Dispose();
        }
    }
}
