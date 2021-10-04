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

        public Especie GetEspecie(long id)
        {
            var especie = especies_repositorio.GetEspecie(id);
            return especie;
        }

        public void ActualizarEspecie(Especie e)
        {
            var filasAfectadas = especies_repositorio.ActualizarEspecie(e);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaEspecie(Especie esp)
        {
            var filasAfectadas = especies_repositorio.DarBajaEspecie(esp);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}
