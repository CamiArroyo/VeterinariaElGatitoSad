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

namespace WindowsFormsApp1.Interfaces
{
    public partial class FrmIniciar_sesion : Form
    {
        private EmpleadosServicio empleadosServicio;

        public FrmIniciar_sesion()
        {
            InitializeComponent();
            empleadosServicio = new EmpleadosServicio();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
            {
                var empleadoIngresado = txtbox_Usuario.Text;

                Empleado empleado = new Empleado();
                empleado.usuario = empleadoIngresado;
                empleado.password = txtbox_Password.Text;

             
          
                var empleadoLogueado = empleadosServicio.Login(empleado);
                if (empleadoLogueado == null)
                {
                    MessageBox.Show("Usuario/contraseña inválida", "Información", MessageBoxButtons.OK);
                }
                else
                {
                    this.Visible = false;
                    Form menu = new FrmMenu_Principal();
                    menu.Show();
                }

            
            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIniciar_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
