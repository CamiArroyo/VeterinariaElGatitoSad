
namespace WindowsFormsApp1.Interfaces.Consultas
{
    partial class Frm_MedicamentosXConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Dtg_Medicamento_x_Consulta = new System.Windows.Forms.DataGridView();
            this.nroconsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Medicamento_x_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(703, 388);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(85, 50);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Dtg_Medicamento_x_Consulta
            // 
            this.Dtg_Medicamento_x_Consulta.AllowUserToAddRows = false;
            this.Dtg_Medicamento_x_Consulta.AllowUserToDeleteRows = false;
            this.Dtg_Medicamento_x_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Medicamento_x_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroconsulta,
            this.nombre,
            this.medicamento,
            this.dosis,
            this.periodicidad});
            this.Dtg_Medicamento_x_Consulta.Location = new System.Drawing.Point(12, 12);
            this.Dtg_Medicamento_x_Consulta.Name = "Dtg_Medicamento_x_Consulta";
            this.Dtg_Medicamento_x_Consulta.ReadOnly = true;
            this.Dtg_Medicamento_x_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Medicamento_x_Consulta.Size = new System.Drawing.Size(544, 426);
            this.Dtg_Medicamento_x_Consulta.TabIndex = 1;
            // 
            // nroconsulta
            // 
            this.nroconsulta.HeaderText = "Número Consulta";
            this.nroconsulta.Name = "nroconsulta";
            this.nroconsulta.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // medicamento
            // 
            this.medicamento.HeaderText = "Medicamento";
            this.medicamento.Name = "medicamento";
            this.medicamento.ReadOnly = true;
            // 
            // dosis
            // 
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            this.dosis.ReadOnly = true;
            // 
            // periodicidad
            // 
            this.periodicidad.HeaderText = "Periodicidad";
            this.periodicidad.Name = "periodicidad";
            this.periodicidad.ReadOnly = true;
            // 
            // Frm_MedicamentosXConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dtg_Medicamento_x_Consulta);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "Frm_MedicamentosXConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicamentosXConsultas";
            this.Load += new System.EventHandler(this.MedicamentosXConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Medicamento_x_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView Dtg_Medicamento_x_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroconsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicidad;
    }
}