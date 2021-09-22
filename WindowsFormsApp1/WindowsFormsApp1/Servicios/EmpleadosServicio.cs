using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class EmpleadosServicio
    {
        
        private EmpleadosRepositorio empleadosRepositorio;
        public static Empleado EmpleadoLogueado;

        public EmpleadosServicio(EmpleadosRepositorio empleadosRepo)
        {
            empleadosRepositorio = empleadosRepo;
        }

        public EmpleadosServicio()
        {
            empleadosRepositorio = new EmpleadosRepositorio();
        }

        public Empleado Login(Empleado empleadoIngresado)
        {
            var empleado = empleadosRepositorio.LoginBD(empleadoIngresado);
            EmpleadoLogueado = empleado;
            return empleado;
        }

        public List<Empleado> GetEmpleados()
        {
            return empleadosRepositorio.GetEmpleadosBD();
        }

        public bool RegistrarEmpleado(Empleado emp)
        {
            if (emp == null)
                throw new ApplicationException("Empleado requerido");
            var filasAfectadas = empleadosRepositorio.RegistrarEmpleado(emp);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

    }

}
