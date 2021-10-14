using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Consulta
    {
        public int nro_historia_clinica { get; set; }
        public int id_consulta { get; set; }
        public int id_empleado { get; set; }

        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public string temperatura { get; set; }
        public string observaciones { get; set; }
        public string tratamiento { get; set; }


        public Consulta(int nro, int id_con, int id_emp, DateTime fecha_en, DateTime fecha_sa, string temp, string obs, string trat)
        {
            nro_historia_clinica = nro;
            id_consulta = id_con;
            id_empleado = id_emp;
            fecha_entrada = fecha_en;
            fecha_salida = fecha_sa;
            temperatura = temp;
            observaciones = obs;
            tratamiento = trat;
        }

        public Consulta()
        {

        }
    }
}
