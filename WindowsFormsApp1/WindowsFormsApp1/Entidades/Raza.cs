using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Raza
    {

        public int id_raza { get; set; }
        public string id_especie { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string peso_medio { get; set; }
        public string altura_media { get; set; }

        public Raza(string especie, string nom, string descri, string peso, string altura)
        {
            id_especie = especie;
            nombre = nom;
            descripcion = descri;
            peso_medio = peso;
            altura_media = altura;

        }

    }

}