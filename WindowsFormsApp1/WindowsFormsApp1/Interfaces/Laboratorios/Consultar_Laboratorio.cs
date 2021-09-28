using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Empleados;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    public partial class Consultar_Laboratorio : Form
    {
        private LaboratoriosServicio labService;

        public Consultar_Laboratorio()
        {
            labService = new LaboratoriosServicio();
            InitializeComponent();
        }

        private void Consultar_Laboratorio_Load(object sender, EventArgs e)
        {

        }

        private void BtnCL_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new FrmMenu_Principal();
            menu.Show();
            this.Dispose();
        }

        private void btn_Consultar_Laboratorio_Click(object sender, EventArgs e)
        {
            ConsultarLaboratorios();
        }

        private void ConsultarLaboratorios()
        {
            var lista_lab = labService.GetLaboratorios();
            dataGrd_Consultar_Laboratorio.Rows.Clear();
            foreach (var lab in lista_lab)
            {
                {
                    var fila = new String[]
                    {
                    lab.id_laboratorio.ToString(),
                    lab.razon_social,
                    lab.direccion
                    };
                    dataGrd_Consultar_Laboratorio.Rows.Add(fila);
                }
            }
        }

        private void Btn_Eliminar_Laboratorio_Click(object sender, EventArgs e)
        {
            if (dataGrd_Consultar_Laboratorio.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(dataGrd_Consultar_Laboratorio.SelectedRows[0].Cells["Id"].Value);
                new Eliminar_Laboratorio(id).Show();
                Visible = false;
                ConsultarLaboratorios();
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }
    }
}
