using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class EspeciesServicio
    {
        private EspeciesRepositorio especies_repositorio;

        public EspeciesServicio(EspeciesRepositorio especiesRepo)
        {
            especies_repositorio = especiesRepo;
        }

        public EspeciesServicio()
        {
            especies_repositorio = new EspeciesRepositorio();
        }

        public bool RegistrarEspecie(Especie especie)
        {
            if (especie == null)
                throw new ApplicationException("Especie requerida");
            var filasAfectadas = especies_repositorio.RegistrarEspecie(especie);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
    }
}
