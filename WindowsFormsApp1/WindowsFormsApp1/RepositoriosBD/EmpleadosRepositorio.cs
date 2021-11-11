using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Interfaces.Empleados;
using System.Data;

namespace WindowsFormsApp1.RepositoriosBD
{
    class EmpleadosRepositorio
    {
        public Empleado LoginBD(Empleado EmpleadoIngresado)
        {
            Empleado EmpleadoResultado = null;
            var sentenciaSql = $"SELECT * FROM EMPLEADOS WHERE usuario='{EmpleadoIngresado.usuario}' AND password='{EmpleadoIngresado.password}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                EmpleadoResultado = new Empleado();
                EmpleadoResultado.usuario = row["usuario"].ToString();
                EmpleadoResultado.id_empleado = Convert.ToInt32(row["id_empleado"]);
            }
            return EmpleadoResultado;
        }

        public int RegistrarEmpleado(Empleado emp)
        {
            var sentenciaSQL = $"INSERT INTO Empleados (nro_doc_emp, nombre, apellido, fecha_nacimiento, fecha_ingreso, matricula,usuario,password,email,estado)" +
                $" VALUES({emp.nro_doc_empleado},'{emp.nombre}','{emp.apellido}','{emp.fecha_nacimiento}','{emp.fecha_ingreso}','{emp.matricula}','{emp.usuario}','{emp.password}','{emp.email}', '{emp.estado}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarEmpleado(Empleado e)
        {
            var sentenciaSql = $"UPDATE EMPLEADOS SET nombre='{e.nombre}', apellido='{e.apellido}', password='{e.password}',email='{e.email}', estado='{e.estado}' where id_empleado={e.id_empleado}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public List<Empleado> GetEmpleadosBD()
        {
            var lista_empleados = new List<Empleado>();
            var sentenciaSql = $"SELECT * FROM EMPLEADOS";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var emp = MapearEmpleado(fila);
                lista_empleados.Add(emp);
            }
            return lista_empleados;
        }

        public Empleado GetEmpleado(long id)
        {
            var empleado = new Empleado();
            var sentenciaSql = $"Select * from EMPLEADOS where id_empleado={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                empleado = MapearEmpleado(fila);
            }
            return empleado;
        }

        private Empleado MapearEmpleado(DataRow fila)
        {
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);

            var empleado = new Empleado();
            empleado.id_empleado = Convert.ToInt32(fila["id_empleado"] is DBNull ? " " : fila["id_empleado"]);
            empleado.nro_doc_empleado = Convert.ToString(fila["nro_doc_emp"] is DBNull ? " " : fila["nro_doc_emp"]);
            empleado.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            empleado.apellido = Convert.ToString(fila["apellido"] is DBNull ? " " : fila["apellido"]);
            empleado.fecha_nacimiento = Convert.ToDateTime(fila["fecha_nacimiento"] is DBNull ? date1 : fila["fecha_nacimiento"]);
            empleado.fecha_ingreso = Convert.ToDateTime(fila["fecha_ingreso"] is DBNull ? date1 : fila["fecha_ingreso"]);
            empleado.matricula = Convert.ToString(fila["matricula"] is DBNull ? " " : fila["matricula"]);
            empleado.usuario = Convert.ToString(fila["usuario"] is DBNull ? " " : fila["usuario"]);
            empleado.email = Convert.ToString(fila["email"] is DBNull ? " " : fila["email"]);
            empleado.estado = Convert.ToString(fila["estado"] is DBNull ? "Inactivo" : fila["estado"]);

            return empleado;
        }

        public int DarBajaEmpleado(Empleado e)
        {
            //completar
            var sentenciaSql = $"UPDATE Empleados SET estado='Inactivo' WHERE id_empleado={e.id_empleado}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int validarDNI() {
            var sentenciaSql = $"SELECT nro_doc_emp from EMPLEADOS ";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}  