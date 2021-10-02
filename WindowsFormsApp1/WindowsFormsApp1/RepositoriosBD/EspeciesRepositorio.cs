using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class EspeciesRepositorio
    {
        public int RegistrarEspecie(Especie especie)
        {
            var sentenciaSQL = $"INSERT INTO Especies (nombre, descripcion, nota_cuidados) VALUES('{especie.nombre}', '{especie.descripcion}', '{especie.nota_cuidados}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
