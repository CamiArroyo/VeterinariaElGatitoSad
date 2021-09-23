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
    public partial class Eliminar_Empleado : Form
    {
        private Empleado emp;
        private EmpleadosServicio emp_Servicios;
        public Eliminar_Empleado(long id)
        {
            emp_Servicios = new EmpleadosServicio();
            emp = emp_Servicios.GetEmpleado(id);
            InitializeComponent();
        }

        private void Eliminar_Empleado_Load(object sender, EventArgs e)
        {
        }

        private void BtnE_Empleado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                DarBajaEmpleado();
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

        private void DarBajaEmpleado()
        {
            emp_Servicios.DarBajaEmpleado(emp);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }
        public void CerrarFormulario()
        {
            this.Dispose();
        }
    }
}
