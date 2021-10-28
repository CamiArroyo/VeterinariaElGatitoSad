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
            var sentenciaSQL = "SELECT TRY_CAST(MEDICAMENTOS.cantidad_en_stock AS INT) as cantidad_en_stock, MEDICAMENTOS.nombre from MEDICAMENTOS";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
    }
}
