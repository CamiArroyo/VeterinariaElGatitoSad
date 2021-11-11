using System;
using System.Collections.Generic;
using System.Data;
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

        public Calendario_Vacunacion GetCalendario(long ndh)
        {
            var calendario = new Calendario_Vacunacion();
            var sentenciaSql = $"Select * from CALENDARIO_VAC where nro_historia_clinica={ndh}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                calendario = MapearCalendario(fila);
            }
            return calendario;
        }

        private Calendario_Vacunacion MapearCalendario(DataRow fila)
        {
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);
            var calendario = new Calendario_Vacunacion();
            calendario.nro_calendario_vac = Convert.ToInt32(fila["nro_calendario_vac"] is DBNull ? " " : fila["nro_calendario_vac"]);
            calendario.nro_historia_clinica = Convert.ToString(fila["nro_historia_clinica"] is DBNull ? " " : fila["nro_historia_clinica"]);
            calendario.fecha_inicio = Convert.ToDateTime(fila["fecha_inicio"] is DBNull ? date1 : fila["fecha_inicio"]);
            calendario.observaciones = Convert.ToString(fila["observaciones"] is DBNull ? " " : fila["observaciones"]);
            calendario.estado = Convert.ToString(fila["estado"] is DBNull ? " " : fila["estado"]);
            return calendario;
        }

        public int ActualizarCalendario(Calendario_Vacunacion cal)
        {
            var sentenciaSql = $"UPDATE CALENDARIO_VAC SET fecha_inicio='{cal.fecha_inicio}', observaciones='{cal.observaciones}' WHERE nro_calendario_vac={cal.nro_calendario_vac}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaCalendario(Calendario_Vacunacion cal)
        {
            var sentenciaSql = $"UPDATE CALENDARIO_VAC SET estado='Inactivo' WHERE nro_calendario_vac={cal.nro_calendario_vac}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarAltaCalendario(Calendario_Vacunacion cal)
        {
            var sentenciaSql = $"UPDATE CALENDARIO_VAC SET estado='Activo' WHERE nro_calendario_vac={cal.nro_calendario_vac}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int BorrarCalendarioYDetalles(Calendario_Vacunacion cal)
        {
            var sentenciaSql = $"Delete from CALENDARIO_VAC where nro_calendario_vac={cal.nro_calendario_vac}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
