using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Medicamento
    {
        public int id_medicamentos { get; set; }
        public string descripcion { get; set; }
        public int id_laboratorio { get; set; }
        public string fecha_ultima_compra { get; set; }
        public int cantidad_en_stock { get; set; }

    }
}
