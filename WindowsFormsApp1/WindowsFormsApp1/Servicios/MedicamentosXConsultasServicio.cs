using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class MedicamentosXConsultasServicio
    {
        private MedicamentoXConsultaRepositorio medxconRepo;
        public MedicamentosXConsultasServicio(MedicamentoXConsultaRepositorio medxconRepo1)
        {
            medxconRepo = medxconRepo1;
        }
        public MedicamentosXConsultasServicio()
        {
            medxconRepo = new MedicamentoXConsultaRepositorio();
        }
        public DataSet GetBuscquedaMedicamentoXConsulta(int nro_historia_clinica, int id_consulta)
        {
            var medicamentoxconsulta = medxconRepo.GetBusquedaMedicamentoXConsultaBD(nro_historia_clinica, id_consulta);
            return medicamentoxconsulta;
        }
    }
}
