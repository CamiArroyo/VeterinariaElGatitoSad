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
        private string ultima_busqueda;

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
            ultima_busqueda = busqueda;
            DataGrd_Stock_med.Rows.Clear();
            BusquedaStock(busqueda);
                

        }

        private void BusquedaStock(string txt)
        {
            var ds = med_serv.GetBuscquedaMedicamento(txt);

            DataGrd_Stock_med.Rows.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataGrd_Stock_med.Rows.Add(row["id_medicamento"], row["nombre"], row["descripcion"], row["razon_social"], row["fecha_ultima_compra"], row["cantidad_en_stock"]);

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

        private void Btn_Añadir_Click(object sender, EventArgs e)
        {
            
            if (DataGrd_Stock_med.SelectedRows.Count == 1)
            {
                var cantidad = Convert.ToInt32(Txt_Añadir.Text);
                
                var id = Convert.ToInt32(DataGrd_Stock_med.SelectedRows[0].Cells["id_medicamento"].Value);
                var stock = Convert.ToInt32(DataGrd_Stock_med.SelectedRows[0].Cells["cantidad_en_stock"].Value);
                stock = cantidad + stock;
                med.id_medicamentos = id;

                med.cantidad_en_stock = Convert.ToString(stock);
                med_serv.ActualizarStock(med);
                MessageBox.Show("Se actualizo el stock exitosamente", "Información", MessageBoxButtons.OK);
                Txt_Añadir.Clear();
                Txt_Quitar.Clear();
                BusquedaStock(ultima_busqueda);


                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (DataGrd_Stock_med.SelectedRows.Count == 1)
            {
                var cantidad = Convert.ToInt32(Txt_Quitar.Text);

                var id = Convert.ToInt32(DataGrd_Stock_med.SelectedRows[0].Cells["id_medicamento"].Value);
                var stock = Convert.ToInt32(DataGrd_Stock_med.SelectedRows[0].Cells["cantidad_en_stock"].Value);
                stock = stock - cantidad;
                med.id_medicamentos = id;

                if (stock >= 0)
                {
                    med.cantidad_en_stock = Convert.ToString(stock);
                    med_serv.ActualizarStock(med);
                    MessageBox.Show("Se actualizo el stock exitosamente", "Información", MessageBoxButtons.OK);
                    Txt_Añadir.Clear();
                    Txt_Quitar.Clear();
                    BusquedaStock(ultima_busqueda);

                }
                else
                {
                    MessageBox.Show("Esta quitando mas de lo que hay, ingrese nuevamente", "Información", MessageBoxButtons.OK);

                }


                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Buscar_Medicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Añadir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
