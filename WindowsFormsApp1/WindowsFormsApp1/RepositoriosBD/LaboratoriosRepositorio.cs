using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class LaboratoriosRepositorio
    {
        public int RegistrarLaboratorio(Laboratorio lab)
        {
            var sentenciaSQL = $"INSERT INTO Laboratorios (razon_social, direccion)" +
                $" VALUES('{lab.razon_social}', '{lab.direccion}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
        public int ActualizarLaboratorio(Laboratorio lab)
        {
            var sentenciaSql = $"UPDATE LABORATORIOS SET razon_social='{lab.razon_social}',direccion='{lab.direccion}' where id_laboratorio={lab.id_laboratorio}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        

        public Laboratorio GetLaboratorio(long id)
        {
            var laboratorio = new Laboratorio();
            var sentenciaSql = $"Select * from LABORATORIOS where id_laboratorio={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                laboratorio = MapearLaboratorio(fila);
            }
            return laboratorio;
        }

        private Laboratorio MapearLaboratorio(DataRow fila)
        {
            var laboratorio = new Laboratorio();
            laboratorio.id_laboratorio = Convert.ToInt32(fila["id_laboratorio"] is DBNull ? " " : fila["id_laboratorio"]);
            laboratorio.razon_social = Convert.ToString(fila["razon_social"] is DBNull ? " " : fila["razon_social"]);
            laboratorio.direccion = Convert.ToString(fila["direccion"] is DBNull ? " " : fila["direccion"]);

            return laboratorio;
        }

        public int DarBajaLaboratorio(Laboratorio lab)
        {
            var sentenciaSql = $"Delete from Laboratorios where id_laboratorio={lab.id_laboratorio}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}

        

