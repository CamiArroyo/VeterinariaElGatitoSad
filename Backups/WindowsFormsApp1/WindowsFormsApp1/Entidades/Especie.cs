using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Especie
    {
        public int id_especie { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string nota_cuidados { get; set; }

        public Especie(string name, string descri, string notas)
        {
            nombre = name;
            descripcion = descri;
            nota_cuidados = notas;
        }

        public Especie()
        {

        }
    }

    
    }
