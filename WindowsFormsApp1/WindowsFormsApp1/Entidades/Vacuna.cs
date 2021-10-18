using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Vacuna
    {
        public int id_vacuna { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
        public string id_laboratorio { get; set; }
        public string cantidad_en_stock { get; set; }

        public Vacuna(string descri, string name, string id, string canti)

        {
            descripcion = descri;
            nombre = name;
            id_laboratorio = id;
            cantidad_en_stock = canti;
 

        }
        public Vacuna()
        {

        }



    }
}
