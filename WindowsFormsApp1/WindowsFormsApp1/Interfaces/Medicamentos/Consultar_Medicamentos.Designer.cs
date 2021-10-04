
namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    partial class Frm_Consultar_Medicamentos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaultimacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadenstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentos = new WindowsFormsApp1.Medicamentos();
            this.mEDICAMENTOSTableAdapter = new WindowsFormsApp1.MedicamentosTableAdapters.MEDICAMENTOSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Registrar_Sintoma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedicamentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idlaboratorioDataGridViewTextBoxColumn,
            this.fechaultimacompraDataGridViewTextBoxColumn,
            this.cantidadenstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEDICAMENTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idmedicamentoDataGridViewTextBoxColumn
            // 
            this.idmedicamentoDataGridViewTextBoxColumn.DataPropertyName = "id_medicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.HeaderText = "id_medicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.Name = "idmedicamentoDataGridViewTextBoxColumn";
            this.idmedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idlaboratorioDataGridViewTextBoxColumn
            // 
            this.idlaboratorioDataGridViewTextBoxColumn.DataPropertyName = "id_laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.HeaderText = "id_laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.Name = "idlaboratorioDataGridViewTextBoxColumn";
            // 
            // fechaultimacompraDataGridViewTextBoxColumn
            // 
            this.fechaultimacompraDataGridViewTextBoxColumn.DataPropertyName = "fecha_ultima_compra";
            this.fechaultimacompraDataGridViewTextBoxColumn.HeaderText = "fecha_ultima_compra";
            this.fechaultimacompraDataGridViewTextBoxColumn.Name = "fechaultimacompraDataGridViewTextBoxColumn";
            // 
            // cantidadenstockDataGridViewTextBoxColumn
            // 
            this.cantidadenstockDataGridViewTextBoxColumn.DataPropertyName = "cantidad_en_stock";
            this.cantidadenstockDataGridViewTextBoxColumn.HeaderText = "cantidad_en_stock";
            this.cantidadenstockDataGridViewTextBoxColumn.Name = "cantidadenstockDataGridViewTextBoxColumn";
            // 
            // mEDICAMENTOSBindingSource
            // 
            this.mEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS";
            this.mEDICAMENTOSBindingSource.DataSource = this.medicamentos;
            // 
            // medicamentos
            // 
            this.medicamentos.DataSetName = "Medicamentos";
            this.medicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICAMENTOSTableAdapter
            // 
            this.mEDICAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.favpng_medicine_health_care_clinic;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(495, 410);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(108, 45);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Registrar_Sintoma
            // 
            this.Btn_Registrar_Sintoma.Location = new System.Drawing.Point(12, 410);
            this.Btn_Registrar_Sintoma.Name = "Btn_Registrar_Sintoma";
            this.Btn_Registrar_Sintoma.Size = new System.Drawing.Size(124, 45);
            this.Btn_Registrar_Sintoma.TabIndex = 3;
            this.Btn_Registrar_Sintoma.Text = "Nuevo Medicamento";
            this.Btn_Registrar_Sintoma.UseVisualStyleBackColor = true;
            // 
            // Frm_Consultar_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(641, 482);
            this.Controls.Add(this.Btn_Registrar_Sintoma);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Consultar_Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Frm_Consultar_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApp1.Medicamentos medicamentos;
        private System.Windows.Forms.BindingSource mEDICAMENTOSBindingSource;
        private MedicamentosTableAdapters.MEDICAMENTOSTableAdapter mEDICAMENTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaultimacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadenstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Registrar_Sintoma;
    }
}