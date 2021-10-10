using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{

    class MedicamentosServicio
    {
        private MedicamentosRepositorio medRepo;
        public MedicamentosServicio(MedicamentosRepositorio mediRepo)
        {
            medRepo = mediRepo;
        }
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

        public Medicamento GetMedicamento(long id)
        {
            var medicamento = medRepo.GetMedicamento(id);
            return medicamento;
        }
        public DataSet GetBuscquedaMedicamento(string name)
        {
            var medicamento = medRepo.GetBusquedaMedicamentoBD(name);
            return medicamento;
        }

        public void ActualizarMedicamento(Medicamento med)
        {
            var filasAfectadas = medRepo.ActualizarMedicamento(med);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaMedicamento(Medicamento med)
        {
            var filasAfectadas = medRepo.DarBajaMedicamento(med);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");


        }
    }
}

