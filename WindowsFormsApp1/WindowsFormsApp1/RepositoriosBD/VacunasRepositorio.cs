using System;
using System.Collections.Generic;
using System.Data;
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

        public int ActualizarVacuna(Vacuna vac)
        {
            var sentenciaSql = $"Update VACUNAS Set nombre = '{vac.nombre}', descripcion = '{vac.descripcion}', id_laboratorio={vac.id_laboratorio} where id_vacuna={vac.id_vacuna}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Vacuna GetVacuna(long id)
        {
            var vacuna = new Vacuna();
            var sentenciaSql = $"Select * from VACUNAS where id_vacuna={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                vacuna = MapearVacuna(fila);
            }
            return vacuna;
        }

        private Vacuna MapearVacuna(DataRow fila)
        {
            var vacuna = new Vacuna();
            vacuna.id_vacuna = Convert.ToInt32(fila["id_vacuna"] is DBNull ? " " : fila["id_vacuna"]);
            vacuna.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            vacuna.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            vacuna.id_laboratorio= Convert.ToString(fila["id_laboratorio"] is DBNull ? " " : fila["id_laboratorio"]);

            return vacuna;
        }

        public int DarBajaVacuna(Vacuna vac)
        {
            var sentenciaSql = $"Delete from VACUNAS where id_vacuna={vac.id_vacuna}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
