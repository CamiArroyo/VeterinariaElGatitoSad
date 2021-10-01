using System;
using System.Collections.Generic;
using System.Data;
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
            var sentenciaSQL = $"INSERT INTO SINTOMAS (descripcion, nombre)" +
                $" VALUES ('{sint.descripcion}','{sint.nombre}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }


        public int ActualizarSintoma(Sintoma sint)
        {
            var sentenciaSql = $"Update Sintomas Set nombre='{sint.nombre}', descripcion='{sint.descripcion}' where id_sintoma={sint.id_sintoma}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Sintoma GetSintoma(long id)
        {
            var sintoma = new Sintoma();
            var sentenciaSql = $"Select * from SINTOMAS where id_sintoma={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                sintoma = MapearSintoma(fila);
            }
            return sintoma;
        }

        private Sintoma MapearSintoma(DataRow fila)
        {

            var sintoma = new Sintoma();
            sintoma.id_sintoma= Convert.ToInt32(fila["id_sintoma"] is DBNull ? " " : fila["id_sintoma"]);
            sintoma.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            sintoma.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);

            return sintoma;
        }

        public int DarBajaSintoma(Sintoma sint)
        {
            //completar
            var sentenciaSql = $"Delete from Sintomas where id_sintoma={sint.id_sintoma}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
