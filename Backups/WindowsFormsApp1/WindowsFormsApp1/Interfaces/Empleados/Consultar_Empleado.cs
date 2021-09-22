using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Servicios;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Interfaces.Empleados
{
    public partial class Frm_Consultar_Empleado : Form
    {
        private EmpleadosServicio emp_serv;
        public Frm_Consultar_Empleado()
        {
            emp_serv = new EmpleadosServicio();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Consultar_Empleados_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados();
            
        }
        private void ConsultarEmpleados()
        {
            var lista_emp = emp_serv.GetEmpleados();
            dataGrd_Consultar_Empleado.Rows.Clear();
            foreach (var emp in lista_emp)
            {
                var fila = new String[]
                {
                    emp.id_empleado.ToString(),
                    emp.nro_doc_empleado,
                    emp.nombre,
                    emp.apellido,
                    emp.fecha_nacimiento.ToString(),
                    emp.fecha_ingreso.ToString(),
                    emp.matricula,
                    emp.usuario,
                    emp.email
                };

                dataGrd_Consultar_Empleado.Rows.Add(fila);
            }
        }
    }
}
