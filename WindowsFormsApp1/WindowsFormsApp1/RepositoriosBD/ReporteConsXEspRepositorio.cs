using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.RepositoriosBD
{
    class ReporteConsXEspRepositorio
    {
        public DataTable ObtenerConsultasPorEspecie()
        {
            var sentenciaSQL = "Select Count (c.id_consulta) as Cantidad, e.nombre as Especie FROM CONSULTAS C JOIN MASCOTAS m ON c.nro_historia_clinica = m.nro_historia_clinica JOIN RAZAS r ON m.id_raza = R.id_raza JOIN ESPECIES e ON r.id_especie = e.id_especie GROUP BY r.id_especie, e.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
    }
}
