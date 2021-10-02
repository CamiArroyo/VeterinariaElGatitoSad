using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class DueñosRepositorio
    {
        public int RegistrarDueño(Dueño due)
        {
            var sentenciaSQL = $"INSERT INTO DUEÑOS(nombre,apellido, telefono, estado)" +
                $" VALUES('{due.nombre}', '{due.apellido}', '{due.telefono}', '{due.estado}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public Dueño GetDueño(long id)
        {
            var dueño = new Dueño();
            var sentenciaSql = $"Select * from DUEÑOS where id_dueño={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                dueño = MapearDueño(fila);
            }
            return dueño;
        }
        private Dueño MapearDueño(DataRow fila)
        {

            var dueño = new Dueño();
            dueño.id_dueño = Convert.ToInt32(fila["id_dueño"] is DBNull ? " " : fila["id_dueño"]);
            dueño.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            dueño.apellido = Convert.ToString(fila["apellido"] is DBNull ? " " : fila["apellido"]);
            dueño.telefono = Convert.ToString(fila["telefono"] is DBNull ? " " : fila["telefono"]);
            dueño.estado = Convert.ToString(fila["estado"] is DBNull ? " " : fila["estado"]);

            return dueño;
        }

        public int ActualizarDueño(Dueño d)
        {
            var sentenciaSql = $"Update DUEÑOS Set nombre = '{d.nombre}', apellido = '{d.apellido}', telefono='{d.telefono}', estado = '{d.estado}' where id_dueño={d.id_dueño}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaDueño(Dueño d)
        {
            //completar
            var sentenciaSql = $"UPDATE DUEÑOS SET estado='Inactivo' WHERE id_dueño={d.id_dueño}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
