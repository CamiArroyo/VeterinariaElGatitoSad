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
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Interfaces.Empleados
{
    public partial class Frm_Registrar_Empleado : Form
    {
        private Empleado emp;
        private EmpleadosServicio emp_serv;
        public Frm_Registrar_Empleado()
        {
            emp_serv = new EmpleadosServicio();
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Registrar_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!EsOperacionConfirmada())
                    return;
                if (!EsEmpleadoValido())
                    return;
                RegistrarEmpleado(emp);
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

        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsEmpleadoValido()
        {
            var DNI = Txt_DNI.Text;
            if (validarDNIEmpleado(DNI)){
                return false;
            };
            var nombre = Txt_Nombre.Text;
            var apellido = Txt_Apellido.Text;
            var fecha_nac = DateP_Fecha_Nacimiento.Value;
            var fecha_ing = DateP_Fecha_Ingreso.Value;
            var matricula = Txt_Matricula.Text;
            var user = Txt_Usuario.Text;
            var password_1 = Txt_Password.Text;
            var password_2 = Txt_Repetir_Password.Text;
            var email = Txt_Email.Text;
            var estado = "Activo";

            if (password_1 != password_2)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error: Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var emp_ingresado = new Empleado(DNI, nombre, apellido, fecha_nac, fecha_ing, matricula, user, password_1, email, estado);
            emp = emp_ingresado;
            return true;
            

        }

        private void RegistrarEmpleado(Empleado emp)
        {
            if(!emp_serv.RegistrarEmpleado(emp)) 
            {
                MessageBox.Show("Ocurrió un problema al registrar el empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El empleado se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void Txt_Repetir_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form menu = new Frm_Consultar_Empleado();
            menu.Show();
        }

        private Boolean validarDNIEmpleado(String dni) {
            var lista_emp = emp_serv.GetEmpleados();
            for (int i = 0; i < lista_emp.Count; i++) {

                if (lista_emp[i].nro_doc_empleado.Equals(dni))
                {
                    MessageBox.Show("El DNI Ingresado ya está registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
    }
}