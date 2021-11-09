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
            var sentenciaSql = $"SELECT Det.nro_detalle_calendario AS Nro_Detalle, Vac.nombre AS Nombre_Vacuna, Det.dosis AS Dosis_Vacuna, Det.fecha_prevista AS Fecha_Prevista, Det.fecha_real AS Fecha_Real, (Emp.nombre +' '+ Emp.apellido) AS Nombre_Empleado FROM DETALLE_CALENDARIO_VAC AS Det INNER JOIN VACUNAS AS Vac ON Det.id_vacuna = Vac.id_vacuna INNER JOIN EMPLEADOS AS Emp ON Det.id_empleado = Emp.id_empleado where Det.nro_calendario_vac={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;
        }

        public int RegistrarDetalle(Detalle_calendario_vac detalle)
        {
            var sentenciaSQL = $"INSERT INTO DETALLE_CALENDARIO_VAC(nro_historia_clinica, nro_calendario_vac, id_vacuna, fecha_prevista, fecha_real, dosis, id_empleado, estado) VALUES ({detalle.nro_historia_clinica}, {detalle.nro_calendario_vac}, {detalle.id_vacuna}, '{detalle.fecha_prevista}', '{detalle.fecha_real}', '{detalle.dosis}', {detalle.id_empleado}, 'Creado')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
