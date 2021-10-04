using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class MascotasRepositorio
    {
        public int RegistrarMascota(Mascota mas)
        {
            var sentenciaSQL = $"INSERT INTO Mascotas (nombre, fecha_nacimiento,id_raza,peso,altura,id_dueño,estado) VALUES('{mas.nombre}','{mas.fecha_nacimiento}'" +
                $",'{mas.id_raza}','{mas.peso}','{mas.altura}','{mas.id_dueño}','{mas.estado}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public int ActualizarMascota(Mascota mas)
        {
            var sentenciaSql = $"UPDATE MASCOTAS SET nombre='{mas.nombre}', peso='{mas.peso}', altura='{mas.altura}', estado='{mas.estado}' where nro_historia_clinica={mas.nro_historia_clinica}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Mascota GetMascota(long ndh)
        {
            var mascota = new Mascota();
            var sentenciaSql = $"Select * from MASCOTAS where nro_historia_clinica={ndh}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                mascota = MapearMascota(fila);
            }
            return mascota;
        }

        private Mascota MapearMascota(DataRow fila)
        {
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);
            var mascota = new Mascota();
            mascota.nro_historia_clinica = Convert.ToInt32(fila["nro_historia_clinica"] is DBNull ? " " : fila["nro_historia_clinica"]);
            mascota.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            mascota.fecha_nacimiento = Convert.ToDateTime(fila["fecha_nacimiento"] is DBNull ? date1 : fila["fecha_nacimiento"]);
            mascota.id_raza = Convert.ToString(fila["id_raza"] is DBNull ? " " : fila["id_raza"]);
            mascota.peso = Convert.ToString(fila["peso"] is DBNull ? " " : fila["peso"]);
            mascota.id_dueño = Convert.ToString(fila["id_dueño"] is DBNull ? " " : fila["id_dueño"]);
            mascota.estado = Convert.ToString(fila["estado"] is DBNull ? " " : fila["estado"]);
            return mascota;
        }

        public int DarBajaMascota(Mascota mas)
        {
            var sentenciaSql = $"UPDATE MASCOTAS SET estado='Inactivo' WHERE nro_historia_clinica={mas.nro_historia_clinica}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}