using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class ReporteConsXEmpRepositorio
    {
        public DataTable ObtenerConsultasPorEmpleado(ConsXEmpFiltros filtros)
        {
            var sentenciaSQL = $"SELECT Count(C.id_consulta) as Cantidad, e.nombre + ' ' + e.apellido as Empleado FROM CONSULTAS C JOIN EMPLEADOS E ON C.id_empleado = E.id_empleado WHERE C.temperatura like '%%' AND C.fecha_entrada >= '{filtros.FechaDesde}' AND C.fecha_entrada <= '{filtros.FechaHasta}' GROUP BY c.id_empleado, e.nombre + ' ' + e.apellido ";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
    }
}
