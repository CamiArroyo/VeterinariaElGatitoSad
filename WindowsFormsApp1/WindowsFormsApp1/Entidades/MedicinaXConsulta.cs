using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class MedicamXConsulta
    {
        public int nro_historia_clinica { get; set; }
        public int id_consulta { get; set; }
        public int id_medicamento { get; set; }
        public string dosis { get; set; }
        public string periodicidad { get; set; }

    }
}
