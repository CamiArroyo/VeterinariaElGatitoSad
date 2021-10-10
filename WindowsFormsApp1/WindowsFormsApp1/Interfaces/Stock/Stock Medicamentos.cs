using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Servicios;


namespace WindowsFormsApp1.Interfaces.Stock
{
    public partial class Frm_Stock_Medicamentos : Form
    {
        private Medicamento med;
        private MedicamentosServicio med_serv;

        public Frm_Stock_Medicamentos()
        {
            med = new Medicamento();
            med_serv = new MedicamentosServicio();
            InitializeComponent();
        }

        private void Frm_Stock_Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet10.MEDICAMENTOS' Puede moverla o quitarla según sea necesario.
            //this.mEDICAMENTOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet10.MEDICAMENTOS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btn_Busqueda_Medicamento_Click(object sender, EventArgs e)
        //{

        //    var busqueda = Txt_Buscar_Medicamento.Text;
        //    DataGrd_Stock_med.Rows.Clear();

        //    if (busqueda != null)
        //    {


        //        var lista_med = med_serv.GetBuscquedaMedicamento(busqueda);


        //        foreach (var med in lista_med)
        //        {


        //            var fila = new String[]
        //                 {
        //                med.id_medicamentos.ToString(),
        //                med.nombre,
        //                med.descripcion,
        //                med.id_laboratorio.ToString(),
        //                med.fecha_ultima_compra.ToString(),
        //                med.cantidad_en_stock.ToString()

        //                 };

        //            DataGrd_Stock_med.Rows.Add(fila);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese el nombre del medicamento", "Falta nombre", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //    }
        //}

        private void btn_Busqueda_Medicamento_Click(object sender, EventArgs e)
        {

            var busqueda = Txt_Buscar_Medicamento.Text;
            DataGrd_Stock_med.Rows.Clear();

                var ds = med_serv.GetBuscquedaMedicamento(busqueda);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataGrd_Stock_med.Rows.Add(row["id_medicamento"], row["nombre"], row["descripcion"], row["razon_social"], row["fecha_ultima_compra"], row["cantidad_en_stock"]);

                //DataGrd_Stock_med.Rows.Add(row["nombre"]);
                //DataGrd_Stock_med.Rows.Add(row["descripcion"]);
                //DataGrd_Stock_med.Rows.Add(row["razon_social"]);
                //DataGrd_Stock_med.Rows.Add(row["fecha_ultima_compra"]);
                //DataGrd_Stock_med.Rows.Add(row["cantidad_en_stock"]);


                //var fila = new String[]
                //     {
                //    med.id_medicamentos.ToString(),
                //    med.nombre,
                //    med.descripcion,
                //    med.id_laboratorio.ToString(),
                //    med.fecha_ultima_compra.ToString(),
                //    med.cantidad_en_stock.ToString()

                //     };

                //DataGrd_Stock_med.Rows.Add(fila);

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }
    }
}
