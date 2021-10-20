using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Calendario_Vacunacion
    {
        public string nro_historia_clinica { get; set; } //PK y FK
        public int nro_calendario_vac { get; set; } //PK

        public DateTime fecha_inicio { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }

        public Calendario_Vacunacion(string nro_hist, DateTime date, string obs, string est)
        {
            this.nro_historia_clinica = nro_hist;
            this.fecha_inicio = date;
            this.observaciones = obs;
            this.estado = est;
        }

        public Calendario_Vacunacion()
        {

        }

    }

}
