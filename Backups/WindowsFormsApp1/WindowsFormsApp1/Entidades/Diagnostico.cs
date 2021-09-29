using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{

    public class Diagnostico
    {
        public int id_diagnostico { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public Diagnostico(string descri, string name)

        {
            descripcion = descri;
            nombre = name;

        }
        public Diagnostico()
        {

        }
    }

}