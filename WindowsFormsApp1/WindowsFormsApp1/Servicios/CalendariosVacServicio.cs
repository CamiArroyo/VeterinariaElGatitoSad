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

        public Calendario_Vacunacion GetCalendario(long ndh)
        {
            var calendario = cal_repo.GetCalendario(ndh);
            return calendario;
        }

        public Calendario_Vacunacion GetCalendarioXNumCal(long nro)
        {
            var calendario = cal_repo.GetCalendarioXNumCal(nro);
            return calendario;
        }

        public void ActualizarCalendario(Calendario_Vacunacion cal)
        {
            var filasAfectadas = cal_repo.ActualizarCalendario(cal);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaCalendario(Calendario_Vacunacion cal)
        {
            var filasAfectadas = cal_repo.DarBajaCalendario(cal);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }

}
