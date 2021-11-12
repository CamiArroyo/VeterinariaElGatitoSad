using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class ReporteConsXEspRepositorio
    {
        public DataTable ObtenerConsultasPorEspecie(ConsXEmpFiltros filtros)
        {
            var sentenciaSQL = $"Select Count (c.id_consulta) as Cantidad, e.nombre as Especie FROM CONSULTAS C JOIN MASCOTAS m ON c.nro_historia_clinica = m.nro_historia_clinica JOIN RAZAS r ON m.id_raza = R.id_raza JOIN ESPECIES e ON r.id_especie = e.id_especie WHERE C.temperatura like '%%' AND C.fecha_entrada >= '{filtros.FechaDesde}' AND C.fecha_entrada <= '{filtros.FechaHasta}' GROUP BY r.id_especie, e.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
    }
}
