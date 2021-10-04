using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{

    class MedicamentosServicio
    {
        private MedicamentosRepositorio medRepo;

        public MedicamentosServicio()
        {
            medRepo = new MedicamentosRepositorio();
        }
        public bool RegistrarMedicamento(Medicamento med)
        {
            if (med == null)
                throw new ApplicationException("Medicamento requerido");
            var filasAfectadas = medRepo.RegistrarMedicamento(med);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
    }
}
