using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class MedicamentosRepositorio
    {
        public int RegistrarMedicamento(Medicamento med)
        {
            var sentenciaSQL = $"INSERT INTO MEDICAMENTOS(nombre, descripcion, id_laboratorio, fecha_ultima_compra, cantidad_en_stock) VALUES('{med.nombre}', '{med.descripcion}', '{med.id_laboratorio}', '{med.fecha_ultima_compra}', '{med.cantidad_en_stock}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
        public int ActualizarMedicamento(Medicamento med)
        {
            var sentenciaSql = $"UPDATE MEDICAMENTOS SET nombre='{med.nombre}', descripcion='{med.descripcion}', id_laboratorio='{med.id_laboratorio}', fecha_ultima_compra='{med.fecha_ultima_compra}', cantidad_en_stock='{med.cantidad_en_stock}' where id_medicamento={med.id_medicamentos}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int ActualizarStockMed(Medicamento med)
        {
            var sentenciaSql = $"UPDATE MEDICAMENTOS SET , cantidad_en_stock='{med.cantidad_en_stock}' where id_medicamento={med.id_medicamentos}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Medicamento GetMedicamento(long id)
        {
            var medicamento = new Medicamento();
            var sentenciaSql = $"Select * from MEDICAMENTOS where id_medicamento={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                medicamento = MapearMedicamento(fila);
            }
            return medicamento;
        }

        public DataSet GetBusquedaMedicamentoBD(string name)
        {
            var data_med = new DataSet();
            var sentenciaSql = $"Select *, b.razon_social from MEDICAMENTOS a, LABORATORIOS b where a.id_laboratorio = b.id_laboratorio and a.nombre LIKE '%{name}%'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;

        }


        private Medicamento MapearMedicamento(DataRow fila)
        {
            var date1 = new DateTime(2022, 01, 01, 01, 01, 01);
            var medicamento = new Medicamento();
            medicamento.id_medicamentos= Convert.ToInt32(fila["id_medicamento"] is DBNull ? " " : fila["id_medicamento"]);
            medicamento.nombre = Convert.ToString(fila["nombre"] is DBNull ? " " : fila["nombre"]);
            medicamento.descripcion = Convert.ToString(fila["descripcion"] is DBNull ? " " : fila["descripcion"]);
            medicamento.id_laboratorio= Convert.ToString(fila["id_laboratorio"] is DBNull ? " " : fila["id_laboratorio"]);
            medicamento.fecha_ultima_compra= Convert.ToDateTime(fila["fecha_ultima_compra"] is DBNull ? date1 : fila["fecha_ultima_compra"]);
            medicamento.cantidad_en_stock = Convert.ToString(fila["cantidad_en_stock"] is DBNull ? date1 : fila["cantidad_en_stock"]);

            return medicamento;
        }

        
        public int DarBajaMedicamento(Medicamento med)
        {
            var sentenciaSql = $"Delete from Medicamentos where id_medicamento={med.id_medicamentos}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        //public List<Medicamento> GetBusquedaMedicamentoBD(string name)
        //{
        //    var medicamento = new List<Medicamento>();
        //    var sentenciaSql = $"Select * from MEDICAMENTOS a where nombre LIKE '%{name}%'";
        //    var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

        //    foreach (DataRow fila in tablaResultado.Rows)
        //    {
        //        var medica = MapearMedicamento(fila);
        //        medicamento.Add(medica);
        //    }
        //    return medicamento;
        //}
    }
}
