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

        public Detalle_calendario_vac GetDetalleCalendario(long ndc)
        {
            var det_calendario = det_calendario_repo.GetDetalleCalendario(ndc);
            return det_calendario;
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

        public void ModificarDetalle(Detalle_calendario_vac detalle)
        {
            var filasAfectadas = det_calendario_repo.ModificarDetalle(detalle);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void EliminarDetallePendiente(Detalle_calendario_vac detalle)
        {
            var filasAfectadas = det_calendario_repo.EliminarDetallePendiente(detalle);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }
    }
}
