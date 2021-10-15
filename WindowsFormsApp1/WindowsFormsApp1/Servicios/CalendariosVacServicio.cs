using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class CalendariosVacServicio
    {
        private CalendariosVacRepositorio cal_repo;

        public CalendariosVacServicio(CalendariosVacRepositorio calRepo)
        {
            cal_repo = calRepo;
        }

        public CalendariosVacServicio()
        {
            cal_repo = new CalendariosVacRepositorio();
        }

        public bool RegistrarCalendario(Calendario_Vacunacion cal)
        {
            if (cal == null)
                throw new ApplicationException("Calendario requerido");
            var filasAfectadas = cal_repo.RegistrarCalendario(cal);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

    }

}
