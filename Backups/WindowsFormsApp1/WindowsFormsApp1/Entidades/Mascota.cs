using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Mascota
    {
        public int nro_historia_clinica { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int id_especie { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public int id_dueño { get; set; }


        public Mascota(string name, DateTime fecha, string weigth, string height) 
        {
            nombre = name;
            fecha_nacimiento = fecha;
            peso = weigth;
            altura = height;
        }

        public Mascota() {
        }

    }
   


}
