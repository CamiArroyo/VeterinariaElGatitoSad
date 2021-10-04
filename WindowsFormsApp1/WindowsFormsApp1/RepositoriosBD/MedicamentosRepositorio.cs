using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class MedicamentosRepositorio
    {
        public int RegistrarMedicamento(Medicamento med)
        {
            var sentenciaSQL = $"INSERT INTO MEDICAMENTOS(nombre, descripcion, id_laboratorio, fecha_ultima_compra, cantidad_en_stock)" +
                $" VALUES('{med.nombre}', '{med.descripcion}', '{med.id_laboratorio}', '{med.fecha_ultima_compra}', '{med.cantidad_en_stock}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
