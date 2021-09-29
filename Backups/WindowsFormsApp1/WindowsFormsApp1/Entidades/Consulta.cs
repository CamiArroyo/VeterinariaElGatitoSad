using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Consulta
    {
        public int nro_historia_clinica { get; set; }
        public int id_consuylta { get; set; }
        public int id_empleado { get; set; }

        public string fecha_entrada { get; set; }
        public string fecha_salida { get; set; }
    }
}
