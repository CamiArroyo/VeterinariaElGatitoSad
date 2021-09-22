using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Usuario
    {
        // Propiedades abrevidadas
        public int IdUsuario { get; set; }
        public string Password { get; set; }
       

        // Propiedades no abrevidadas
        private string nombreUsuario;
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }

}
