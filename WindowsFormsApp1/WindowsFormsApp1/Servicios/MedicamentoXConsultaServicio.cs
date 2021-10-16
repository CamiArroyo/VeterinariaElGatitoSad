using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class MedicamentoXConsultaServicio
    {
        private MedicamentoXConsultaRepositorio medxconRepo;
        public MedicamentoXConsultaServicio(MedicamentoXConsultaRepositorio medxconRepo1)
        {
            medxconRepo = medxconRepo1;
        }
        public MedicamentoXConsultaServicio()
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
