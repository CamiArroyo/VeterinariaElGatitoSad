using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Laboratorio
    {
        public int id_laboratorio { get; set; }
        public string razon_social { get; set; }
        public string direccion { get; set; }

        public Laboratorio(string razon_social, string direccion) 
        {
            this.razon_social = razon_social;
            this.direccion = direccion;
        }

        public Laboratorio() { }
    }
}
