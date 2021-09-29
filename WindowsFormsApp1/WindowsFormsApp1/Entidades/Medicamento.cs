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
        public DateTime fecha_ultima_compra { get; set; }
        public int cantidad_en_stock { get; set; }


        public Medicamento(string descri, DateTime fecha, int cantidad)
        {
            descripcion = descri;
            fecha_ultima_compra = fecha;
            cantidad_en_stock = cantidad;

        }

        public Medicamento()
        {

        }
    }
}
