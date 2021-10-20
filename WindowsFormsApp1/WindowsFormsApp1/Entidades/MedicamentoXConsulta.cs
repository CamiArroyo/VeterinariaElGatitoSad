using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class MedicamentoXConsulta
    {
        public int nro_consulta { get; set; }
        public int id_consulta { get; set; }
        public int id_medicamento { get; set; }
        public string dosis { get; set; }
        public string periodicidad { get; set; }

        public MedicamentoXConsulta(int nro_consulta, int id_consulta, int id_medicamento, string dosis, string periodicidad)
        {
            this.nro_consulta = nro_consulta;
            this.id_consulta = id_consulta;
            this.id_medicamento = id_medicamento;
            this.dosis = dosis;
            this.periodicidad = periodicidad;
        }

        public MedicamentoXConsulta()
        {
        }
    }
}
