using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class DiagnosticoXConsulta
    {
        public int nro_historia_clinica { get; set; }
        public int id_consulta { get; set; }
        public int id_diagnostico { get; set; }

        public DiagnosticoXConsulta(int nro_historia_clinica, int id_consulta, int id_diagnostico)
        {
            this.nro_historia_clinica = nro_historia_clinica;
            this.id_consulta = id_consulta;
            this.id_diagnostico = id_diagnostico;
        }
    }
}
