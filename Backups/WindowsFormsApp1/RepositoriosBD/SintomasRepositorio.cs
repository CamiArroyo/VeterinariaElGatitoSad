using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class SintomasRepositorio
    {
        public int RegistrarSintomaBD(Sintoma sint)
        {
            var sentenciaSQL = $"INSERT INTO SINTOMAS (nombre, descripcion)" +
                $" VALUES({sint.nombre},'{sint.descripcion}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarEmpleadoBD(Sintoma sint)
        {
            var sentenciaSql = $"UPDATE SINTOMAS SET nombre='{sint.nombre}', descripcion='{sint.descripcion}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

    }
}
