using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class DetalleCalendarioVacRepositorio
    {
        public DataSet GetBusquedaCalendarioBD(int id)
        {
            var data_med = new DataSet();
            var sentenciaSql = $"SELECT Det.nro_detalle_calendario AS Nro_Detalle, Vac.nombre AS Nombre_Vacuna, Det.dosis AS Dosis_Vacuna, Det.fecha_prevista AS Fecha_Prevista, Det.fecha_real AS Fecha_Real, (Emp.nombre +' '+ Emp.apellido) AS Nombre_Empleado, Det.estado AS Estado FROM DETALLE_CALENDARIO_VAC AS Det INNER JOIN VACUNAS AS Vac ON Det.id_vacuna = Vac.id_vacuna INNER JOIN EMPLEADOS AS Emp ON Det.id_empleado = Emp.id_empleado where Det.nro_calendario_vac={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;
        }

        public Detalle_calendario_vac GetDetalleCalendario(long ndc)
        {
            var det_calendario = new Detalle_calendario_vac();
            var sentenciaSql = $"Select * from DETALLE_CALENDARIO_VAC where nro_detalle_calendario={ndc}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                det_calendario = MapearDetalleCalendario(fila);
            }
            return det_calendario;
        }

        private Detalle_calendario_vac MapearDetalleCalendario(DataRow fila)
        {
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);
            var det_calendario = new Detalle_calendario_vac();
            det_calendario.nro_historia_clinica = Convert.ToInt32(fila["nro_historia_clinica"] is DBNull ? " " : fila["nro_historia_clinica"]);
            det_calendario.nro_calendario_vac = Convert.ToInt32(fila["nro_calendario_vac"] is DBNull ? " " : fila["nro_calendario_vac"]);
            det_calendario.nro_detalle_calendario = Convert.ToInt32(fila["nro_detalle_calendario"] is DBNull ? " " : fila["nro_detalle_calendario"]);
            det_calendario.id_vacuna = Convert.ToInt32(fila["id_vacuna"] is DBNull ? " " : fila["id_vacuna"]);
            det_calendario.fecha_prevista = Convert.ToDateTime(fila["fecha_prevista"] is DBNull ? date1 : fila["fecha_prevista"]);
            det_calendario.fecha_real = Convert.ToDateTime(fila["fecha_real"] is DBNull ? date1 : fila["fecha_real"]);
            det_calendario.dosis = Convert.ToString(fila["dosis"] is DBNull ? " " : fila["dosis"]);
            det_calendario.id_empleado = Convert.ToInt32(fila["id_empleado"] is DBNull ? " " : fila["id_empleado"]);
            det_calendario.estado = Convert.ToString(fila["estado"] is DBNull ? " " : fila["estado"]);
            return det_calendario;
        }

        public int RegistrarDetalle(Detalle_calendario_vac detalle)
        {
            var sentenciaSQL = $"INSERT INTO DETALLE_CALENDARIO_VAC(nro_historia_clinica, nro_calendario_vac, id_vacuna, fecha_prevista, fecha_real, dosis, id_empleado, estado) VALUES ({detalle.nro_historia_clinica}, {detalle.nro_calendario_vac}, {detalle.id_vacuna}, '{detalle.fecha_prevista}', '9/9/9999', '{detalle.dosis}', 2, 'Pendiente')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ModificarDetalle(Detalle_calendario_vac det)
        {
            var sentenciaSql = $"UPDATE DETALLE_CALENDARIO_VAC SET fecha_real='{det.fecha_real}', dosis='{det.dosis}', id_empleado={det.id_empleado}, estado='Confirmada' WHERE nro_detalle_calendario={det.nro_detalle_calendario}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int EliminarDetallePendiente(Detalle_calendario_vac detalle)
        {
            var sentenciaSql = $"Delete from DETALLE_CALENDARIO_VAC where nro_detalle_calendario={detalle.nro_detalle_calendario}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
