using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class DiagnosticosRepositorio
    {
        public int RegistrarDiagnostico(Diagnostico diag)
        {
            var sentenciaSQL = $"INSERT INTO Diagnosticos (nombre, descripcion) VALUES('{diag.nombre}','{diag.descripcion}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarDiagnostico(Diagnostico d)
        {
            var sentenciaSql = $"UPDATE DIAGNOSTICOS SET nombre='{d.nombre}', descripcion='{d.descripcion}' where id_diagnostico={d.id_diagnostico}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Diagnostico GetDiagnostico(long id)
        {
            var diagnostico = new Diagnostico();
            var sentenciaSql = $"Select * from DIAGNOSTICOS where id_diagnostico={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                diagnostico = MapearDiagnostico(fila);
            }
            return diagnostico;
        }

        private Diagnostico MapearDiagnostico(DataRow fila)
        {
            var diagnostico = new Diagnostico();
            diagnostico.id_diagnostico = Convert.ToInt32(fila["id_diagnostico"] is DBNull ? " " : fila["id_diagnostico"]);
            diagnostico.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            diagnostico.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);

            return diagnostico;
        }

        public int DarBajaDiagnostico(Diagnostico diag)
        {
            var sentenciaSql = $"Delete Diagnosticos where id_diagnostico={diag.id_diagnostico}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}