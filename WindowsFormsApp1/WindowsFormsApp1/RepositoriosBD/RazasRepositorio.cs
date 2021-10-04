using System;
using System.Collections.Generic;
using System.Data;
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
            var sentenciaSQL = $"INSERT INTO Razas (nombre, id_especie, descripcion, peso_medio, altura_media) VALUES('{raza.nombre}', {raza.id_especie}, '{raza.descripcion}', '{raza.peso_medio}', '{raza.altura_media}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public Raza GetRaza(long id)
        {
            var raza = new Raza();
            var sentenciaSql = $"Select * from RAZAS where id_raza={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                raza = MapearRaza(fila);
            }
            return raza;
        }

        private Raza MapearRaza(DataRow fila)
        {
            var raza = new Raza();
            raza.id_raza = Convert.ToInt32(fila["id_raza"] is DBNull ? " " : fila["id_raza"]);
            raza.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            raza.id_especie = Convert.ToString(fila["id_especie"] is DBNull ? " " : fila["id_especie"]);
            raza.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            raza.peso_medio = Convert.ToString(fila["peso_medio"] is DBNull ? " " : fila["peso_medio"]);
            raza.altura_media = Convert.ToString(fila["altura_media"] is DBNull ? " " : fila["altura_media"]);

            return raza;
        }

        public int ActualizarRaza(Raza raza)
        {
            var sentenciaSql = $"Update RAZAS Set nombre='{raza.nombre}', id_especie={raza.id_especie}, descripcion='{raza.descripcion}', peso_medio='{raza.peso_medio}', altura_media='{raza.altura_media}' where id_raza={raza.id_raza}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaRaza(Raza raza)
        {
            var sentenciaSql = $"Delete from RAZAS where id_raza={raza.id_raza}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

    }
}
