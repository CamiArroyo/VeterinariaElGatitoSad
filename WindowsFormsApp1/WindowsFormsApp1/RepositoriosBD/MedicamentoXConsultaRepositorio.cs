using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.RepositoriosBD
{
    class MedicamentoXConsultaRepositorio
    {
        private MedicamentoXConsulta medxcon;
        public DataSet GetBusquedaMedicamentoXConsultaBD(int nro_historia_clinica, int id_consulta)
        {
            var data_med = new DataSet();
            var sentenciaSql = $"SELECT C.id_consulta as Número_Consulta, MA.nombre as Nombre, Me.nombre as Medicamento, MXC.dosis as Dosis, MXC.periodicidad as Periodicidad FROM MEDICAMENTOS ME, CONSULTAS C, MASCOTAS MA, MEDICAMxCONSULTA MXC  WHERE C.id_consulta = MXC.id_consulta AND C.nro_historia_clinica = MXC.nro_historia_clinica AND C.nro_historia_clinica = MA.nro_historia_clinica AND MXC.id_medicamento = ME.id_medicamento AND MA.nro_historia_clinica={nro_historia_clinica} AND C.id_consulta={id_consulta}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            data_med.Tables.Add(tablaResultado);

            return data_med;

        }

        public int RegistrarMedicamentoXConsulta(MedicamentoXConsulta medxcon)
        {
            var sentenciaSQL = $"INSERT INTO MEDICAMxCONSULTA(nro_historia_clinica, id_consulta, id_medicamento, dosis, periodicidad) values({medxcon.nro_consulta}, {medxcon.id_consulta}, {medxcon.id_medicamento}, '{medxcon.dosis}', '{medxcon.periodicidad}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

    }
}
