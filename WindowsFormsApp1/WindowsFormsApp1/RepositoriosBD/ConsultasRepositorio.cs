using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class ConsultasRepositorio
    {
        public DataSet GetBusquedaMedicamentoBD(int id)
        {
            var data_med = new DataSet();
            var sentenciaSql = $"SELECT CONSULTAS.nro_historia_clinica AS Número_Historia_Clinica, CONSULTAS.id_consulta AS Número_Consulta, CONSULTAS.fecha_entrada AS Fecha_Ingreso, CONSULTAS.fecha_salida AS FechaEgreso, CONSULTAS.temperatura AS Temperatura, CONSULTAS.observaciones AS Observaciones, CONSULTAS.tratamiento AS Tratamiento, MASCOTAS.nombre AS Nombre, DUEÑOS.nombre + ' ' + DUEÑOS.apellido AS Dueño, CONSULTAS.id_empleado AS Número_Empleado, (EMPLEADOS.nombre +' '+ EMPLEADOS.apellido) AS Empleado FROM CONSULTAS INNER JOIN  EMPLEADOS ON CONSULTAS.id_empleado = EMPLEADOS.id_empleado INNER JOIN MASCOTAS ON CONSULTAS.nro_historia_clinica = MASCOTAS.nro_historia_clinica INNER JOIN DUEÑOS ON MASCOTAS.id_dueño = DUEÑOS.id_dueño where CONSULTAS.nro_historia_clinica={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;

        }

        public int RegistrarConsulta(Consulta cons)
        {
            var sentenciaSQL = $"INSERT INTO CONSULTAS(nro_historia_clinica, fecha_entrada, fecha_salida, id_empleado, temperatura, observaciones, tratamiento) VALUES({cons.nro_historia_clinica}, '{cons.fecha_entrada}', '{cons.fecha_salida}',{cons.id_empleado}, '{cons.temperatura}', '{cons.observaciones}', '{cons.tratamiento}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
    }
}
