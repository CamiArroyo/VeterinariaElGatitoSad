using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Calendario_Vacunacion
    {
        public int nro_historia_clinica { get; set; }
        public int nro_calendario_vac { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string descripcion { get; set; }

        public Calendario_Vacunacion(DateTime date, string descri)
        {
            fecha_inicio = date;
            descripcion = descri;
        }

        public Calendario_Vacunacion()
        {

        }

    }

}
