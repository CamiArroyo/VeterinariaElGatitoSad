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

namespace WindowsFormsApp1.Interfaces.Vacs
{
    public partial class Frm_Modificar_Vacuna : Form
    {
        private Vacuna vac;
        private VacunasServicio vacService;

        public Frm_Modificar_Vacuna(int id)
        {
            vacService = new VacunasServicio();
            vac = vacService.GetVacuna(id);
            InitializeComponent();
        }

        private void Frm_Modificar_Vacuna_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet.LABORATORIOS' Puede moverla o quitarla según sea necesario.
            this.lABORATORIOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet.LABORATORIOS);
            CargarDatos();
        }

        private void BtnM_Guardar_Cambios_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosVacuna();
                ActualizarVacuna();
                CerrarFormulario();
            /*}
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            Form menu = new Frm_Consultar_Vacuna();
            menu.Show();
            this.Dispose();
        }

        private void TomarDatosVacuna()
        {
            vac.nombre = Txt_Nombre.Text;
            vac.descripcion = Txt_Descripcion.Text;
            vac.id_laboratorio = Cb_Id_Laboratorio.Text;
            vac.cantidad_en_stock = Txt_Cantidad_Stock.Text;
        }

        private void ActualizarVacuna()
        {
            vacService.ActualizarVacuna(vac);
            MessageBox.Show("Se actualizo la vacuna con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void CargarDatos()
        {
            Txt_Nombre.Text = vac.nombre;
            Txt_Descripcion.Text = vac.descripcion;
            Cb_Id_Laboratorio.Text = vac.id_laboratorio;
        }

        private void BtnM_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar = new Frm_Consultar_Vacuna();
            consultar.Show();
            this.Dispose();
        }
    }
}
