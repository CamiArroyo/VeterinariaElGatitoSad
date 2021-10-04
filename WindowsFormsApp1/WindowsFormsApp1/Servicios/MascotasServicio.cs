using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class MascotasServicio
    {
        private MascotasRepositorio masRepo;

        public MascotasServicio(MascotasRepositorio mascRepo)
        {
            masRepo = mascRepo;
        }

        public MascotasServicio()
        {
            masRepo = new MascotasRepositorio();
        }

        public bool RegistrarMascota(Mascota mas)
        {
            if (mas == null)
                throw new ApplicationException("Mascota requerida");
            var filasAfectadas = masRepo.RegistrarMascota(mas);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Mascota GetMascota(long ndh)
        {
            var mascota = masRepo.GetMascota(ndh);
            return mascota;
        }

        public void ActualizarMascota(Mascota mas)
        {
            var filasAfectadas = masRepo.ActualizarMascota(mas);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaMascota(Mascota mas)
        {
            var filasAfectadas = masRepo.DarBajaMascota(mas);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}