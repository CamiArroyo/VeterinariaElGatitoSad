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


namespace WindowsFormsApp1.Interfaces.Mascotas
{

    public partial class Frm_Modificar_Mascota : Form
    {
        private Mascota mas;
        private MascotasServicio mas_Servicios;

        public Frm_Modificar_Mascota(int ndh)
        {
            mas_Servicios = new MascotasServicio();
            mas = mas_Servicios.GetMascota(ndh);
            InitializeComponent();
        }

        private void Frm_Modificar_Mascota_Load(object sender, EventArgs e)
        {
            this.Cmb_Id_Raza.DisplayMember = "nombre";
            this.Cmb_Id_Raza.ValueMember = "id_raza";

            this.Cmb_Id_Dueño.DisplayMember = "nombre";
            this.Cmb_Id_Dueño.ValueMember = "id_dueño";

            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12Dueños.DUEÑOS' Puede moverla o quitarla según sea necesario.
            this.dUEÑOSTableAdapter.Fill(this._PAV_3K2_2021_12Dueños.DUEÑOS);
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet4.RAZAS' Puede moverla o quitarla según sea necesario.
            this.rAZASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet4.RAZAS);
            CargarDatos();
        }

        private void Btm_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                TomarDatosMascota();
                ActualizarMascota();
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

            Form consultar_mascotas= new Frm_Consultar_Mascota();
            consultar_mascotas.Show();
            this.Dispose();
        }

        private void TomarDatosMascota()
        {
            mas.nombre = Txt_Nombre.Text;
            mas.fecha_nacimiento = Dtm_Fecha_Nacimiento.Value;
            mas.id_raza = Convert.ToString(Cmb_Id_Raza.SelectedValue);
            mas.peso = Txt_Peso.Text;
            mas.id_dueño = Convert.ToString(Cmb_Id_Dueño.SelectedValue);
            mas.altura = Txt_Altura.Text;
            mas.estado = Cmb_Estado.Text;
        }

        private void ActualizarMascota()
        {
            mas_Servicios.ActualizarMascota(mas);
            MessageBox.Show("Se actualizo la mascota con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }
       
        private void CargarDatos()
        {
            Txt_Nombre.Text = mas.nombre;
            Dtm_Fecha_Nacimiento.Value = mas.fecha_nacimiento;
            Cmb_Id_Dueño.Text = Cmb_Id_Dueño.Text;
            Cmb_Id_Raza.Text = Cmb_Id_Raza.Text;
            Txt_Peso.Text = mas.peso;
            Txt_Altura.Text = mas.altura;
            Cmb_Estado.Text = mas.estado;
        }

        private void Btm_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_mascota = new Frm_Consultar_Mascota();
            consultar_mascota.Show();
            this.Dispose();
        }

        private void Cmb_Id_Raza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
