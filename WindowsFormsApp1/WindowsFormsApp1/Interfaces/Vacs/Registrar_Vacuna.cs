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
    public partial class Frm_Registrar_Vacuna : Form
    {
        private Vacuna vac;
        private VacunasServicio vacService;
        public Frm_Registrar_Vacuna()
        {
            vacService = new VacunasServicio();
            InitializeComponent();
        }

        private void Frm_Registrar_Vacuna_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet.LABORATORIOS' Puede moverla o quitarla según sea necesario.
            this.lABORATORIOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet.LABORATORIOS);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!RegistrarVacuna())
                    return;
                RegistrarVacuna(vac);
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

            Form menuC = new Frm_Menu_Insumos();
            menuC.Show();
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }


        private bool RegistrarVacuna()
        {
            var nombre = Txt_Nombre.Text;
            var descripcion = Txt_Descripcion.Text;
            var id_lab = Cb_id_lab.Text;

            var vacs = new Vacuna(descripcion, nombre, id_lab);
            vac = vacs;
            return true;
        }

        private void RegistrarVacuna(Vacuna vac)
        {
            if (!vacService.RegistrarVacuna(vac))
            {
                MessageBox.Show("Ocurrió un problema al registrar La vacuna", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("La Vacuna se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
