using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.RepositoriosBD
{
    class ReporteCantXMedRepositorio
    {

        public DataTable ObtenerCantidadPorMedicamento()
        {
            var sentenciaSQL = "SELECT TRY_CAST(MEDICAMENTOS.cantidad_en_stock AS INT) as Cantidad, MEDICAMENTOS.nombre as Medicamento from MEDICAMENTOS";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }

        public DataTable ObtenerCantidadPorVacuna()
        {
            var sentenciaSQL = "SELECT TRY_CAST(VACUNAS.cantidad_en_stock AS INT) as Cantidad, VACUNAS.nombre as Vacuna from VACUNAS";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
    }
}
