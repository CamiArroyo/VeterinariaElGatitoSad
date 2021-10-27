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
    class ConsultasServicio
    {
        private ConsultasRepositorio consul_repo;
        public ConsultasServicio() 
        {
            consul_repo = new ConsultasRepositorio();
        }
        public DataSet GetBuscquedaMedicamento(int id)
        {
            var consulta = consul_repo.GetBusquedaMedicamentoBD(id);
            return consulta;
        }

        public bool RegistrarConsulta(Consulta cons)
        {
            if (cons == null)
                throw new ApplicationException("Ingrese su consulta.");
            var filasAfectadas = consul_repo.RegistrarConsulta(cons);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
    }
}
