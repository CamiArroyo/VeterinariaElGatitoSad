
namespace WindowsFormsApp1.Interfaces.Especies
{
    partial class Frm_Consultar_Especies
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
            this.Dgw_Consultar_Especies = new System.Windows.Forms.DataGridView();
            this.eSPECIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet2 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet2();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.eSPECIESTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet2TableAdapters.ESPECIESTableAdapter();
            this.idespecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notacuidadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Especies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgw_Consultar_Especies
            // 
            this.Dgw_Consultar_Especies.AllowUserToAddRows = false;
            this.Dgw_Consultar_Especies.AutoGenerateColumns = false;
            this.Dgw_Consultar_Especies.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgw_Consultar_Especies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Consultar_Especies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecieDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.notacuidadosDataGridViewTextBoxColumn});
            this.Dgw_Consultar_Especies.DataSource = this.eSPECIESBindingSource;
            this.Dgw_Consultar_Especies.Location = new System.Drawing.Point(25, 29);
            this.Dgw_Consultar_Especies.Name = "Dgw_Consultar_Especies";
            this.Dgw_Consultar_Especies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Consultar_Especies.Size = new System.Drawing.Size(450, 300);
            this.Dgw_Consultar_Especies.TabIndex = 0;
            // 
            // eSPECIESBindingSource
            // 
            this.eSPECIESBindingSource.DataMember = "ESPECIES";
            this.eSPECIESBindingSource.DataSource = this._PAV_3K2_2021_12DataSet2;
            // 
            // _PAV_3K2_2021_12DataSet2
            // 
            this._PAV_3K2_2021_12DataSet2.DataSetName = "_PAV_3K2_2021_12DataSet2";
            this._PAV_3K2_2021_12DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar.Location = new System.Drawing.Point(500, 87);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(145, 40);
            this.Btn_Eliminar.TabIndex = 1;
            this.Btn_Eliminar.Text = "Eliminar especie";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(500, 330);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(500, 29);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(145, 40);
            this.Btn_Modificar.TabIndex = 3;
            this.Btn_Modificar.Text = "Modificar especie";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // eSPECIESTableAdapter
            // 
            this.eSPECIESTableAdapter.ClearBeforeFill = true;
            // 
            // idespecieDataGridViewTextBoxColumn
            // 
            this.idespecieDataGridViewTextBoxColumn.DataPropertyName = "id_especie";
            this.idespecieDataGridViewTextBoxColumn.HeaderText = "ID especie";
            this.idespecieDataGridViewTextBoxColumn.Name = "idespecieDataGridViewTextBoxColumn";
            this.idespecieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // notacuidadosDataGridViewTextBoxColumn
            // 
            this.notacuidadosDataGridViewTextBoxColumn.DataPropertyName = "nota_cuidados";
            this.notacuidadosDataGridViewTextBoxColumn.HeaderText = "Cuidados especiales";
            this.notacuidadosDataGridViewTextBoxColumn.Name = "notacuidadosDataGridViewTextBoxColumn";
            // 
            // Frm_Consultar_Especies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(668, 391);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Dgw_Consultar_Especies);
            this.Name = "Frm_Consultar_Especies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar especies";
            this.Load += new System.EventHandler(this.Frm_Consultar_Especie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Especies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgw_Consultar_Especies;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private _PAV_3K2_2021_12DataSet2 _PAV_3K2_2021_12DataSet2;
        private System.Windows.Forms.BindingSource eSPECIESBindingSource;
        private _PAV_3K2_2021_12DataSet2TableAdapters.ESPECIESTableAdapter eSPECIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notacuidadosDataGridViewTextBoxColumn;
    }
}