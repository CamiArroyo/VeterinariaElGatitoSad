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
        private Empleado emp;
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
                if (emp.estado != "Inactivo" && emp.usuario != "admin")
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
                    emp.email,
                    emp.estado
                    };

                    dataGrd_Consultar_Empleado.Rows.Add(fila);
                }
            }
        }

        private void Btn_Modificar_Empleado_Click(object sender, EventArgs e)
        {
            if (dataGrd_Consultar_Empleado.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(dataGrd_Consultar_Empleado.SelectedRows[0].Cells["Id"].Value);
                new Modificar_Empleado(id).Show();
                Visible = false;
                ConsultarEmpleados();
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Eliminar_Empleado_Click(object sender, EventArgs e)
        {
            if (dataGrd_Consultar_Empleado.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(dataGrd_Consultar_Empleado.SelectedRows[0].Cells["Id"].Value);
                new Eliminar_Empleado(id).Show();
                Visible = false;
                ConsultarEmpleados();
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void BtnC_Deshabilitados_Click(object sender, EventArgs e)
        {
            MostrarDeshabilitados();
        }

        private void MostrarDeshabilitados() 
        {
            var lista_emp = emp_serv.GetEmpleados();
            dataGrd_Consultar_Empleado.Rows.Clear();
            foreach (var emp in lista_emp)
            {
                if (emp.estado == "Inactivo")
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
                    emp.email,
                    emp.estado
                    };

                    dataGrd_Consultar_Empleado.Rows.Add(fila);
                }
            }
        }

        private void BtnC_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menu = new FrmMenu_Principal();
            menu.Show();
        }
    }
}
