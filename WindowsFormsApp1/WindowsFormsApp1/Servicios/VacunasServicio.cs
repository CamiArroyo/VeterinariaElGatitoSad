using System;
using System.Collections.Generic;
using System.Data;
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
        public DataSet GetBusquedaVacuna(string name)
        {
            var vacuna = vacRepo.GetBusquedaVacunaBD(name);
            return vacuna;
        }
        public Vacuna GetVacuna(long id)
        {
            var vacuna = vacRepo.GetVacuna(id);
            return vacuna;
        }

        public void ActualizarVacuna(Vacuna v)
        {
            var filasAfectadas = vacRepo.ActualizarVacuna(v);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        
        public void ActualizarStock(Vacuna vac)
        {
            var filasAfectadas = vacRepo.ActualizarStockVac(vac);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaVacuna(Vacuna vac)
        {
            var filasAfectadas = vacRepo.DarBajaVacuna(vac);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }

    }
}
