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
    }
}

    
