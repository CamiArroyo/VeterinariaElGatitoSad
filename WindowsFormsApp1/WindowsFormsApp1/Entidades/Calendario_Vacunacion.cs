using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Calendario_Vacunacion
    {
        public int nro_historia_clinica { get; set; } //PK y FK
        public int nro_calendario_vac { get; set; } //PK

        public DateTime fecha_inicio { get; set; }
        public string descripcion { get; set; }

        public Calendario_Vacunacion(int nro_hist, int nro_cal, DateTime date, string descri)
        {
            nro_historia_clinica = nro_hist;
            nro_calendario_vac = nro_cal;
            fecha_inicio = date;
            descripcion = descri;
        }

        public Calendario_Vacunacion()
        {

        }

    }

}
