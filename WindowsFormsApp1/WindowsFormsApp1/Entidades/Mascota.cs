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
        public string id_raza { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public string id_dueño { get; set; }
        public string estado { get; set; }


        public Mascota(string nombre, DateTime fecha, string id_raza,string peso, string altura,string id_dueño, string estado) 
        {
            this.nombre = nombre;
            fecha_nacimiento = fecha;
            this.id_raza = id_raza;
            this.peso = peso;
            this.altura = altura;
            this.id_dueño = id_dueño;
            this.estado = estado;
        }

        public Mascota() {
        }

    }
   


}
