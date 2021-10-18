using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DataSet GetConsultasMascotas(int id)
        {
            var consulta = consul_repo.GetConsultasMascotasBD(id);
            return consulta;
        }
    }
}
