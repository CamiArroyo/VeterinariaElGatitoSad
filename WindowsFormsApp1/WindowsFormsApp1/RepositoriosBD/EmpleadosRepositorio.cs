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
            var sentenciaSQL = $"INSERT INTO Empleados (nro_doc_emp, nombre, apellido, fecha_nacimiento, fecha_ingreso, matricula,usuario,password,email)" +
                $" VALUES({emp.nro_doc_empleado},'{emp.nombre}','{emp.apellido}','{emp.fecha_nacimiento}','{emp.fecha_ingreso}','{emp.matricula}','{emp.usuario}','{emp.password}','{emp.email}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
        /*public int ActualizarEmpleado(Empleado emp)
        {
            var sentenciaSql = $"UPDATE Empleados SET id_perfil='{u.Perfil.Id}', password='{u.Contrasenia}', email='{u.Email}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        */
        public int DarBajaEmpleado(Empleado emp)
        {
            var estado = emp.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Empleados D estado='{estado}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public List<Empleado> GetEmpleadosBD()
        {
            var lista_empleados = new List<Empleado>();
            var sentenciaSql = $"SELECT * FROM EMPLEADOS";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var emp = new Empleado();
                emp.id_empleado = Convert.ToInt32(fila["id_empleado"] is DBNull ? " " : fila["id_empleado"]);
                emp.nro_doc_empleado = Convert.ToString(fila["nro_doc_emp"] is DBNull ? " " : fila["nro_doc_emp"]);
                emp.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
                emp.apellido = Convert.ToString(fila["apellido"] is DBNull ? " " : fila["apellido"]);
                emp.fecha_nacimiento = Convert.ToDateTime(fila["fecha_nacimiento"] is DBNull ? date1 : fila["fecha_nacimiento"]);
                emp.fecha_ingreso = Convert.ToDateTime(fila["fecha_ingreso"] is DBNull ? date1 : fila["fecha_ingreso"]);
                emp.matricula = Convert.ToString(fila["matricula"] is DBNull ? " " : fila["matricula"]);
                emp.usuario = Convert.ToString(fila["usuario"] is DBNull ? " " : fila["usuario"]);
                emp.email = Convert.ToString(fila["email"] is DBNull ? " " : fila["email"]);

                lista_empleados.Add(emp);
            }
            return lista_empleados;
        }
    }

}  