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
    public partial class Frm_Modificar_Medicamento : Form
    {
        private Medicamento med;
        private MedicamentosServicio medService;

        public Frm_Modificar_Medicamento(int id)
        {
            medService = new MedicamentosServicio();
            med = medService.GetMedicamento(id);
            InitializeComponent();
        }

        private void Frm_Modificar_Medicamento_Load(object sender, EventArgs e)
        {
            this.Cmb_Id_Lab.DisplayMember = "razon_social";
            this.Cmb_Id_Lab.ValueMember = "id_laboratorio";

            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet.LABORATORIOS' Puede moverla o quitarla según sea necesario.
            this.lABORATORIOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet.LABORATORIOS);

        }

        private void Btm_Guardar_Cambios_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosMedicamento();
                ActualizarMedicamento();
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

            Form MenuMedicamentos = new Frm_Consultar_Medicamentos();
            MenuMedicamentos.Show();
            this.Dispose();
        }

        private void TomarDatosMedicamento()
        {
            med.nombre = Txt_Nombre.Text;
            med.descripcion = Txt_Descripcion.Text;
            med.id_laboratorio = Convert.ToString(Cmb_Id_Lab.SelectedValue);
            med.fecha_ultima_compra = Dtp_Fecha.Value;
            med.cantidad_en_stock = Txt_Cantidad_Stock.Text;
        }

        private void ActualizarMedicamento()
        {
            medService.ActualizarMedicamento(med);
            MessageBox.Show("Se actualizo el medicamento con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void CargarDatos()
        {
            Txt_Nombre.Text = med.nombre;
            Txt_Descripcion.Text = med.descripcion;
            Cmb_Id_Lab.Text = med.id_laboratorio;
            Dtp_Fecha.Value= med.fecha_ultima_compra;
            Txt_Cantidad_Stock.Text = med.cantidad_en_stock;
        }

        private void Btm_Cancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Consultar_Medicamentos();
            menu.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
