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
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string id_laboratorio { get; set; }
        public DateTime fecha_ultima_compra { get; set; }
        public string cantidad_en_stock { get; set; }


        public Medicamento(string nombre, string descri, string id_lab, DateTime fecha, string cantidad)
        {
            this.nombre = nombre;
            descripcion = descri;
            id_laboratorio = id_lab;
            fecha_ultima_compra = fecha;
            cantidad_en_stock = cantidad;

        }

        public Medicamento()
        {

        }
    }
}
