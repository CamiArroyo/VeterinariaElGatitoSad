using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;



namespace WindowsFormsApp1.Servicios
{
    class SintomasServicio
    {

        private SintomasRepositorio sint_Repositorio;
        public SintomasServicio()
        {
            sint_Repositorio = new SintomasRepositorio();
        }

        public bool RegistrarSintomaSR(Sintoma sint)
        {
            if (sint == null)
                throw new ApplicationException("Sintoma requerido");
            var filasAfectadas = sint_Repositorio.RegistrarSintomaBD(sint);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Sintoma GetSintoma(long id)
        {
            var sintoma = sint_Repositorio.GetSintoma(id);
            return sintoma;
        }

        public void ActualizarSintoma(Sintoma s)
        {
            var filasAfectadas = sint_Repositorio.ActualizarSintoma(s);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaSintoma(Sintoma sint)
        {
            var filasAfectadas = sint_Repositorio.DarBajaSintoma(sint);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}
