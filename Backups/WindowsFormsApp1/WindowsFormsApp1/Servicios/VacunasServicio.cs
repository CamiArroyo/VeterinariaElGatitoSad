using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class VacunasServicio
    {
        private VacunasRepositorio vacRepo;

        public VacunasServicio()
        {
            vacRepo = new VacunasRepositorio();
        }

        public bool RegistrarVacuna(Vacuna vac)
        {
            if (vac == null)
                throw new ApplicationException("Vacuna requerido");
            var filasAfectadas = vacRepo.RegistrarVacuna(vac);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

    }
}
