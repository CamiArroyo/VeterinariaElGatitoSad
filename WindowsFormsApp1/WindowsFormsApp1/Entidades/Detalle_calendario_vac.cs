using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Detalle_calendario_vac
    {
        public int nro_historia_clinica { get; set; }
        public int nro_calendario_vac { get; set; }
        public int nro_detalle_calendario { get; set; }
        public int id_vacuna { get; set; }

        public DateTime fecha_prevista { get; set; }
        public DateTime fecha_real { get; set; }
        public string dosis { get; set; }
        public int id_empleado { get; set; }
        public string estado { get; set; }

        public Detalle_calendario_vac(int nro_hist, int nro_cal, int id_vac, DateTime fecha_pre, DateTime fecha_re, string dosi, int id_emp, string est)
        {
            nro_historia_clinica = nro_hist;
            nro_calendario_vac = nro_cal;
            id_vacuna = id_vac;
            fecha_prevista = fecha_pre;
            fecha_real = fecha_re;
            dosis = dosi;
            id_empleado = id_emp;
            estado = est;
        }

        public Detalle_calendario_vac()
        {

        }
    }
}
