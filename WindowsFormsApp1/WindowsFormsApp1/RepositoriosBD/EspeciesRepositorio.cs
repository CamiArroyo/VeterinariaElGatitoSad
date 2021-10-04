using System;
using System.Collections.Generic;
using System.Data;
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

        public Especie GetEspecie(long id)
        {
            var especie = new Especie();
            var sentenciaSql = $"Select * from ESPECIES where id_especie={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                especie = MapearEspecie(fila);
            }
            return especie;
        }

        private Especie MapearEspecie(DataRow fila)
        {
            var especie = new Especie();
            especie.id_especie = Convert.ToInt32(fila["id_especie"] is DBNull ? " " : fila["id_especie"]);
            especie.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            especie.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            especie.nota_cuidados = Convert.ToString(fila["nota_cuidados"] is DBNull ? " " : fila["nota_cuidados"]);

            return especie;
        }

        public int ActualizarEspecie(Especie e)
        {
            var sentenciaSql = $"Update ESPECIES Set nombre = '{e.nombre}', descripcion = '{e.descripcion}', nota_cuidados='{e.nota_cuidados}' where id_especie={e.id_especie}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaEspecie(Especie e)
        {
            var sentenciaSql = $"Delete from Especies where id_especie={e.id_especie}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
