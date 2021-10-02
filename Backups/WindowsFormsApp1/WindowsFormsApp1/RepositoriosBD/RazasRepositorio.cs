using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class RazasRepositorio
    {
        public int RegistrarRaza(Raza raza)
        {
            var sentenciaSQL = $"INSERT INTO Razas (nombre, id_especie, descripcion, peso_medio, altura_media) VALUES('{raza.nombre}', '{raza.id_especie}', '{raza.descripcion}', '{raza.peso_medio}', '{raza.altura_media}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

    }
}
