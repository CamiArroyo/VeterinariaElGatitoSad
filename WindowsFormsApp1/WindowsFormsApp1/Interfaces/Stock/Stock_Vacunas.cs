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
    public partial class Stock_Vacunas : Form
    {
        private Vacuna vac;
        private VacunasServicio vac_serv;
        private string ultima_busqueda;

        public Stock_Vacunas()
        {
            vac = new Vacuna();
            vac_serv = new VacunasServicio();
            InitializeComponent();

        }

        private void Stock_Vacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet12.VACUNAS' Puede moverla o quitarla según sea necesario.
           // this.vACUNASTableAdapter.Fill(this._PAV_3K2_2021_12DataSet12.VACUNAS);

        }

        private void Btn_Añadir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Busqueda_Vacuna_Click(object sender, EventArgs e)
        {
            var busqueda = Txt_Buscar_Vacuna.Text;
            ultima_busqueda = busqueda;
            DataGrd_Stock_Vac.Rows.Clear();
            BusquedaStock(busqueda);         
        }
        private void BusquedaStock(string txt)
        {

            var ds = vac_serv.GetBusquedaVacuna(txt);
            DataGrd_Stock_Vac.Rows.Clear();
            //DataGrd_Stock_Vac.Rows.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DataGrd_Stock_Vac.Rows.Add(row["id_vacuna"], row["nombre"], row["descripcion"], row["id_laboratorio"], row["cantidad_en_stock"]);

            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }

        

        private void Btn_Añadir_Click_1(object sender, EventArgs e)
        {
            if (DataGrd_Stock_Vac.SelectedRows.Count == 1)
            {
                var cantidad = Convert.ToInt32(Txt_Añadir.Text);

                var id = Convert.ToInt32(DataGrd_Stock_Vac.SelectedRows[0].Cells["id_vacuna"].Value);
                var stock = Convert.ToInt32(DataGrd_Stock_Vac.SelectedRows[0].Cells["cantidad_en_stock"].Value);
                stock = cantidad + stock;
                vac.id_vacuna = id;

                vac.cantidad_en_stock = Convert.ToString(stock);
                vac_serv.ActualizarStock(vac);
                MessageBox.Show("Se actualizo el stock exitosamente", "Información", MessageBoxButtons.OK);
                Txt_Añadir.Clear();
                Txt_Quitar.Clear();
                


                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void Btn_Quitar_Click_1(object sender, EventArgs e)
        {
            if (DataGrd_Stock_Vac.SelectedRows.Count == 1)
            {
                var cantidad = Convert.ToInt32(Txt_Quitar.Text);

                var id = Convert.ToInt32(DataGrd_Stock_Vac.SelectedRows[0].Cells["id_vacuna"].Value);
                var stock = Convert.ToInt32(DataGrd_Stock_Vac.SelectedRows[0].Cells["cantidad_en_stock"].Value);
                stock = stock - cantidad;
                vac.id_vacuna = id;

                if (stock >= 0)
                {
                    vac.cantidad_en_stock = Convert.ToString(stock);
                    vac_serv.ActualizarStock(vac);
                    MessageBox.Show("Se actualizo el stock exitosamente", "Información", MessageBoxButtons.OK);
                    Txt_Añadir.Clear();
                    Txt_Quitar.Clear();
                   

                }
                else
                {
                    MessageBox.Show("Esta quitando mas de lo que hay, ingrese nuevamente", "Información", MessageBoxButtons.OK);

                }


                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void btn_Busqueda_Vacuna_Click_1(object sender, EventArgs e)
        {

            var busqueda = Txt_Buscar_Vacuna.Text;
            ultima_busqueda = busqueda;
            DataGrd_Stock_Vac.Rows.Clear();
            BusquedaStock(busqueda);

        }
    }
}
