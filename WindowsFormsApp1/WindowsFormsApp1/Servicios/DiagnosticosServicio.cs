using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class DiagnosticosServicio
    {
        private DiagnosticosRepositorio diagRepo;

        public DiagnosticosServicio(DiagnosticosRepositorio diagnRepo)
        {
            diagRepo = diagnRepo;
        }

        public DiagnosticosServicio()
        {
            diagRepo = new DiagnosticosRepositorio();
        }

        public bool RegistrarDiagnostico(Diagnostico diag)
        {
            if (diag == null)
                throw new ApplicationException("Diagnóstico requerido");
            var filasAfectadas = diagRepo.RegistrarDiagnostico(diag);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Diagnostico GetDiagnostico(long id)
        {
            var diagnostico = diagRepo.GetDiagnostico(id);
            return diagnostico;
        }

        public void ActualizarDiagnostico(Diagnostico d)
        {
            var filasAfectadas = diagRepo.ActualizarDiagnostico(d);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void DarBajaDiagnostico(Diagnostico diag)
        {
            var filasAfectadas = diagRepo.DarBajaDiagnostico(diag);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}