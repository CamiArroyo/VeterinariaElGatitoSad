using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Validador
    {
        public string atributo { get; set; }
        
        public Validador(string parametro_1)
        {
            atributo = parametro_1;
        }

        /* public void ValidarCantidad()
         {
             if (string.IsNullOrEmpty(this.atributo))
                 throw new ApplicationException("El atributo es "+ atributo +" requerido");
             if (this.atributo.Length > 5)
                 throw new ApplicationException("El atributo "+ atributo + "  no debe superar los 50 caracteres");
         }

         */
        public bool ValidarCantidad50()
        {
            if (string.IsNullOrEmpty(this.atributo))
                return true;
            if (this.atributo.Length > 5)
                return true;
            return false;
        }

        public bool ValidarCantidad250()
        {
            if (string.IsNullOrEmpty(this.atributo))
                return true;
            if (this.atributo.Length > 250)
                return true;
            return false;
        }


        public Validador()
        {

        }
    }
}
