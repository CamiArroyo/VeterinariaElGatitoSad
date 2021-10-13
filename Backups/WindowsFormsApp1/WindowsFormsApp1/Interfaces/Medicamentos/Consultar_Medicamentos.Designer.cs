
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
            this.Dgv_Consultar_Medicamentos = new System.Windows.Forms.DataGridView();
            this.mEDICAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentos = new WindowsFormsApp1.Medicamentos();
            this.mEDICAMENTOSTableAdapter = new WindowsFormsApp1.MedicamentosTableAdapters.MEDICAMENTOSTableAdapter();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Registrar_Sintoma = new System.Windows.Forms.Button();
            this.Frm_Eliminar_Medicamento = new System.Windows.Forms.Button();
            this.idmedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaultimacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadenstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Consultar_Medicamentos
            // 
            this.Dgv_Consultar_Medicamentos.AllowUserToAddRows = false;
            this.Dgv_Consultar_Medicamentos.AutoGenerateColumns = false;
            this.Dgv_Consultar_Medicamentos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_Consultar_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Medicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedicamentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idlaboratorioDataGridViewTextBoxColumn,
            this.fechaultimacompraDataGridViewTextBoxColumn,
            this.cantidadenstockDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Medicamentos.DataSource = this.mEDICAMENTOSBindingSource;
            this.Dgv_Consultar_Medicamentos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_Consultar_Medicamentos.Location = new System.Drawing.Point(26, 28);
            this.Dgv_Consultar_Medicamentos.Name = "Dgv_Consultar_Medicamentos";
            this.Dgv_Consultar_Medicamentos.ReadOnly = true;
            this.Dgv_Consultar_Medicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Medicamentos.Size = new System.Drawing.Size(450, 300);
            this.Dgv_Consultar_Medicamentos.TabIndex = 0;
            this.Dgv_Consultar_Medicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(500, 328);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Registrar_Sintoma
            // 
            this.Btn_Registrar_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Sintoma.Location = new System.Drawing.Point(500, 28);
            this.Btn_Registrar_Sintoma.Name = "Btn_Registrar_Sintoma";
            this.Btn_Registrar_Sintoma.Size = new System.Drawing.Size(145, 40);
            this.Btn_Registrar_Sintoma.TabIndex = 3;
            this.Btn_Registrar_Sintoma.Text = "Modificar medicamento";
            this.Btn_Registrar_Sintoma.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Sintoma.Click += new System.EventHandler(this.Btn_Registrar_Sintoma_Click);
            // 
            // Frm_Eliminar_Medicamento
            // 
            this.Frm_Eliminar_Medicamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Frm_Eliminar_Medicamento.Location = new System.Drawing.Point(500, 85);
            this.Frm_Eliminar_Medicamento.Name = "Frm_Eliminar_Medicamento";
            this.Frm_Eliminar_Medicamento.Size = new System.Drawing.Size(145, 40);
            this.Frm_Eliminar_Medicamento.TabIndex = 4;
            this.Frm_Eliminar_Medicamento.Text = "Eliminar medicamento";
            this.Frm_Eliminar_Medicamento.UseVisualStyleBackColor = false;
            this.Frm_Eliminar_Medicamento.Click += new System.EventHandler(this.Frm_Eliminar_Medicamento_Click);
            // 
            // idmedicamentoDataGridViewTextBoxColumn
            // 
            this.idmedicamentoDataGridViewTextBoxColumn.DataPropertyName = "id_medicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.HeaderText = "ID medicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.Name = "idmedicamentoDataGridViewTextBoxColumn";
            this.idmedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idlaboratorioDataGridViewTextBoxColumn
            // 
            this.idlaboratorioDataGridViewTextBoxColumn.DataPropertyName = "id_laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.HeaderText = "ID laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.Name = "idlaboratorioDataGridViewTextBoxColumn";
            this.idlaboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaultimacompraDataGridViewTextBoxColumn
            // 
            this.fechaultimacompraDataGridViewTextBoxColumn.DataPropertyName = "fecha_ultima_compra";
            this.fechaultimacompraDataGridViewTextBoxColumn.HeaderText = "Fecha de última compra";
            this.fechaultimacompraDataGridViewTextBoxColumn.Name = "fechaultimacompraDataGridViewTextBoxColumn";
            this.fechaultimacompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadenstockDataGridViewTextBoxColumn
            // 
            this.cantidadenstockDataGridViewTextBoxColumn.DataPropertyName = "cantidad_en_stock";
            this.cantidadenstockDataGridViewTextBoxColumn.HeaderText = "Cantidad en stock";
            this.cantidadenstockDataGridViewTextBoxColumn.Name = "cantidadenstockDataGridViewTextBoxColumn";
            this.cantidadenstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Consultar_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.Frm_Eliminar_Medicamento);
            this.Controls.Add(this.Btn_Registrar_Sintoma);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Dgv_Consultar_Medicamentos);
            this.Name = "Frm_Consultar_Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar medicamentos";
            this.Load += new System.EventHandler(this.Frm_Consultar_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Consultar_Medicamentos;
        private WindowsFormsApp1.Medicamentos medicamentos;
        private System.Windows.Forms.BindingSource mEDICAMENTOSBindingSource;
        private MedicamentosTableAdapters.MEDICAMENTOSTableAdapter mEDICAMENTOSTableAdapter;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Registrar_Sintoma;
        private System.Windows.Forms.Button Frm_Eliminar_Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaultimacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadenstockDataGridViewTextBoxColumn;
    }
}