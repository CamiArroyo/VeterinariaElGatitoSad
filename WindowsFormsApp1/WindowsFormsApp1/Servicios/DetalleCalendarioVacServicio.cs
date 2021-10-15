using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class DetalleCalendarioVacServicio
    {
        private DetalleCalendarioVacRepositorio calendario_repo;

        public DetalleCalendarioVacServicio()
        {
            calendario_repo = new DetalleCalendarioVacRepositorio();
        }

        public DataSet GetBusquedaCalendario(int id)
        {
            var consulta = calendario_repo.GetBusquedaCalendarioBD(id);
            return consulta;
        }
    }
}
