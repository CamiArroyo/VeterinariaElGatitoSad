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
    public partial class Frm_Registrar_Mascota : Form
    {
        private Mascota mas;
        private MascotasServicio mas_serv;
        public Frm_Registrar_Mascota()
        {
            mas_serv = new MascotasServicio();
            InitializeComponent();
        }

        private void Frm_Registrar_Mascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet9.DUEÑOS' Puede moverla o quitarla según sea necesario.
            this.dUEÑOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet9.DUEÑOS);
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet8.RAZAS' Puede moverla o quitarla según sea necesario.
            this.rAZASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet8.RAZAS);

        }

        private void Btm_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsMascotaValida())
                    return;
                RegistrarMascota(mas);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form menu = new Frm_Consultar_Mascota();
            menu.Show();
        }

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsMascotaValida()
        {
            var nombre = Txt_Nombre.Text;
            var fecha_nac = Dtm_Fecha_Nacimiento.Value;
            var id_raza = Cmb_Id_Raza.Text;
            var peso = Txt_Peso.Text;
            var altura = Txt_Altura.Text;
            var id_dueño = Cmb_Id_Dueño.Text;
            var estado = "Activo";

            var mas_ingresada = new Mascota(nombre, fecha_nac,id_raza,peso,altura,id_dueño,estado);
            mas = mas_ingresada;
            return true;
        }

        private void RegistrarMascota(Mascota mas)
        {
            if (!mas_serv.RegistrarMascota(mas))
            {
                MessageBox.Show("Ocurrió un problema al registrar la mascota", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("¡La mascota se registró con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
    
}
