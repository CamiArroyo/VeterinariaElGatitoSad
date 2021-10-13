using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class RazasServicio
    {
        private RazasRepositorio razas_repositorio;

        public RazasServicio(RazasRepositorio razasRepo)
        {
            razas_repositorio = razasRepo;
        }

        public RazasServicio()
        {
            razas_repositorio = new RazasRepositorio();
        }

        public bool RegistrarRaza(Raza raza)
        {
            if (raza == null)
                throw new ApplicationException("Raza requerida");
            var filasAfectadas = razas_repositorio.RegistrarRaza(raza);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Raza GetRaza(long id)
        {
            var raza = razas_repositorio.GetRaza(id);
            return raza;
        }

        public void ActualizarRaza(Raza raza)
        {
            var filasAfectadas = razas_repositorio.ActualizarRaza(raza);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaRaza(Raza raza)
        {
            var filasAfectadas = razas_repositorio.DarBajaRaza(raza);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}

    
