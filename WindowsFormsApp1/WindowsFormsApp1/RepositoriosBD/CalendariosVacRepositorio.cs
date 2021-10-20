using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class CalendariosVacRepositorio
    {
        public int RegistrarCalendario(Calendario_Vacunacion cal)
        {
            var sentenciaSQL = $"INSERT INTO CALENDARIO_VAC (nro_historia_clinica, fecha_inicio, observaciones, estado) VALUES ('{cal.nro_historia_clinica}', '{cal.fecha_inicio}', '{cal.observaciones}', 'Activo')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
