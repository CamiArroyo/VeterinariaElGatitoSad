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
            var sentenciaSQL = $"INSERT INTO VACUNAS (nombre,descripcion, id_laboratorio,cantidad_en_stock)" +
                $" VALUES('{vac.nombre}', '{vac.descripcion}', '{vac.id_laboratorio}', '{vac.cantidad_en_stock}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarVacuna(Vacuna vac)
        {
            var sentenciaSql = $"Update VACUNAS Set nombre = '{vac.nombre}', descripcion = '{vac.descripcion}', id_laboratorio='{vac.id_laboratorio}',cantidad_en_stock='{vac.cantidad_en_stock}' where id_vacuna={vac.id_vacuna}";
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
        public int ActualizarStockVac(Vacuna vac)
        {
            var sentenciaSql = $"UPDATE VACUNAS SET  cantidad_en_stock='{vac.cantidad_en_stock}' where id_vacuna={vac.id_vacuna}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public DataSet GetBusquedaVacunaBD(string name)
        {
            var data_vac = new DataSet();
            var sentenciaSql = $"Select *, b.id_laboratorio from VACUNAS a, LABORATORIOS b where a.id_laboratorio = b.id_laboratorio and a.nombre LIKE '%{name}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_vac.Tables.Add(tablaResultado);

            return data_vac;

        }
        public DataSet GetBusquedaMedicamentoBD(string name)
        {
            var data_med = new DataSet();
            var sentenciaSql = $"Select *, b.razon_social from MEDICAMENTOS a, LABORATORIOS b where a.id_laboratorio = b.id_laboratorio and a.nombre LIKE '%{name}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;

        }
        private Vacuna MapearVacuna(DataRow fila)
        {
            var vacuna = new Vacuna();
            vacuna.id_vacuna = Convert.ToInt32(fila["id_vacuna"] is DBNull ? " " : fila["id_vacuna"]);
            vacuna.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            vacuna.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            vacuna.id_laboratorio = Convert.ToString(fila["id_laboratorio"] is DBNull ? " " : fila["id_laboratorio"]);
            vacuna.cantidad_en_stock = Convert.ToString(fila["cantidad_en_stock"] is DBNull ? " " : fila["cantidad_en_stock"]);

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
