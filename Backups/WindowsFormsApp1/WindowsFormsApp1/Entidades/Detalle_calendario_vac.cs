using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Detalle_calendario_vac
    {
        public int nro_historia_clinica { get; set; }
        public int nro_calendario_vac { get; set; }
        public int nro_detalle_calendario { get; set; }
        public int id_vacuna { get; set; }
        public string fecha_prevista { get; set; }
        public string fecha_real { get; set; }
        public string dosis { get; set; }
        public int id_empleado { get; set; }

    }
}
