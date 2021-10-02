using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Dueño
    {
    
            public int id_dueño { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string telefono { get; set; }
            public string estado { get; set; }

        public Dueño(string name, string surname, string cellphone, string estado)
        {
            nombre = name;
            apellido = surname;
            telefono = cellphone;
            this.estado = estado;
        }

        public Dueño()
        {

        }

    }
    
}
