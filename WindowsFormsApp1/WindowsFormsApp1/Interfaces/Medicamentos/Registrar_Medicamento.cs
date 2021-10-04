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

namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    public partial class Frm_Registrar_Medicamento : Form
    {
        private Medicamento med;
        private MedicamentosServicio medService;

        public Frm_Registrar_Medicamento()
        {
            medService = new MedicamentosServicio();
            InitializeComponent();
        }

        private void Btm_Cerrar_Click(object sender, EventArgs e)
        {
            Form MenuMed = new Frm_Menu_Insumos();
            MenuMed.Show();
            this.Dispose();
        }

        private void Frm_Registrar_Medicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet.LABORATORIOS' Puede moverla o quitarla según sea necesario.
            this.lABORATORIOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet.LABORATORIOS);

        }

        private void Btm_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!TomarDatosMedicamento())
                    return;
                RegistrarMedicamento(med);
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

            Form menuInsumos = new Frm_Menu_Insumos();
            menuInsumos.Show();
            this.Dispose();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool TomarDatosMedicamento()
        {
            var nombre = Txt_Nombre.Text;
            var descripcion = Txt_Descripcion.Text;
            var id_lab = Cb_Id_lab.Text;
            var fecha = Date_Fecha_ultimaCompra.Value;
            var cantidadStock = Txt_Cantidad_Stock.Text;

            var medIngresado = new Medicamento(nombre, descripcion, id_lab, fecha, cantidadStock);
            med = medIngresado;
            return true;
        }

        private void RegistrarMedicamento(Medicamento med)
        {
            if (!medService.RegistrarMedicamento(med))
            {
                MessageBox.Show("Ocurrió un problema al registrar el medicamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El medicamento se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
