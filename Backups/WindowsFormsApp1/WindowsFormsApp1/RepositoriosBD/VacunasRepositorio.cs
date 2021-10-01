using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class VacunasRepositorio
    {
        public int RegistrarVacuna(Vacuna vac)
        {
            var sentenciaSQL = $"INSERT INTO VACUNAS (nombre,descripcion, id_laboratorio)" +
                $" VALUES('{vac.nombre}', '{vac.descripcion}', '{vac.id_laboratorio}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
