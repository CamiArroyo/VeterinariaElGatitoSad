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
    class DetalleCalendarioVacServicio
    {
        private DetalleCalendarioVacRepositorio det_calendario_repo;

        public DetalleCalendarioVacServicio()
        {
            det_calendario_repo = new DetalleCalendarioVacRepositorio();
        }

        public DataSet GetBusquedaCalendario(int id)
        {
            var consulta = det_calendario_repo.GetBusquedaCalendarioBD(id);
            return consulta;
        }

        public bool RegistrarDetalle(Detalle_calendario_vac detalle)
        {
            if (detalle == null)
                throw new ApplicationException("Ingrese su vacunación.");
            var filasAfectadas = det_calendario_repo.RegistrarDetalle(detalle);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
    }
}
