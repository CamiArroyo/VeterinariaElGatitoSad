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

namespace WindowsFormsApp1.Interfaces.Empleados
{
    public partial class Modificar_Empleado : Form
    {
        private Empleado emp;
        private EmpleadosServicio emp_Servicios;

        public Modificar_Empleado(int id)
        {
            emp_Servicios = new EmpleadosServicio();
            emp = emp_Servicios.GetEmpleado(id);
            InitializeComponent();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarEmpleado();
                ActualizarEmpleado();
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
        }

        private void ValidarEmpleado()
        {
            var password = TxtM_Password.Text;
            var repassword = TxtM_Repetir_Password.Text;
            if (password != repassword)
            {
                throw new ApplicationException("Las contraseña no coinciden");
            }
            emp.nombre = TxtM_Nombre.Text;
            emp.apellido = TxtM_Apellido.Text;
            emp.password = password;
            emp.email = TxtM_Email.Text;
        }

        private void ActualizarEmpleado()
        {
            emp_Servicios.ActualizarEmpleado(emp);
            MessageBox.Show("Se actualizo el empleado con éxito", "Información", MessageBoxButtons.OK);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.CerrarFormulario();
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Modificar_Empleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            TxtM_DNI.Text = emp.nro_doc_empleado; //NoPermitido
            TxtM_Nombre.Text = emp.nombre;
            TxtM_Apellido.Text = emp.apellido;
            DatePM_Fecha_Nacimiento.Text = emp.fecha_nacimiento.ToString(); //NoPermitido
            DatePM_Fecha_Ingreso.Text = emp.fecha_ingreso.ToString(); //NoPermitido
            TxtM_Matricula.Text = emp.matricula; //NoPermitido
            TxtM_Usuario.Text = emp.usuario; //NoPermitido
            TxtM_Password.Text = emp.password;
            TxtM_Repetir_Password.Text = emp.password;
            TxtM_Email.Text = emp.email;
        }
    }
}
