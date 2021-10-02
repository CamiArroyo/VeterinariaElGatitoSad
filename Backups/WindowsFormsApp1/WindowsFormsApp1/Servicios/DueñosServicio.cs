using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class DueñosServicio
    {
        private DueñosRepositorio dueRepo;

        public DueñosServicio()
        {
            dueRepo = new DueñosRepositorio();
        }

        public bool RegistrarDueño(Dueño due)
        {
            if (due == null)
                throw new ApplicationException("Dueño requerido");
            var filasAfectadas = dueRepo.RegistrarDueño(due);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Dueño GetDueño(long id)
        {
            var dueño = dueRepo.GetDueño(id);
            return dueño;
        }
        public void ActualizarDueño(Dueño d)
        {
            var filasAfectadas = dueRepo.ActualizarDueño(d);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaDueño(Dueño d)
        {
            var filasAfectadas = dueRepo.DarBajaDueño(d);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}
