using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nro_doc_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string matricula { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string estado { get; set; }

        public Empleado(string dni, string name, string surname, DateTime fecha_nac, DateTime fecha_ing, string matri, string user, string pass, string mail, string estado)
        {
            nro_doc_empleado = dni;
            nombre = name;
            apellido = surname;
            fecha_nacimiento = fecha_nac;
            fecha_ingreso = fecha_ing;
            matricula = matri;
            usuario = user;
            password = pass;
            email = mail;
            this.estado = estado;
        }

        public Empleado()
        {

        }


    }
}
