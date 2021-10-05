
namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    partial class Consultar_Laboratorio
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
            this.dataGrd_Consultar_Laboratorio = new System.Windows.Forms.DataGridView();
            this.idlaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.BtnCL_Salir = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Laboratorio = new System.Windows.Forms.Button();
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            this.Btn_Modificar_Laboratorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrd_Consultar_Laboratorio
            // 
            this.dataGrd_Consultar_Laboratorio.AllowUserToAddRows = false;
            this.dataGrd_Consultar_Laboratorio.AllowUserToDeleteRows = false;
            this.dataGrd_Consultar_Laboratorio.AutoGenerateColumns = false;
            this.dataGrd_Consultar_Laboratorio.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrd_Consultar_Laboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd_Consultar_Laboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlaboratorioDataGridViewTextBoxColumn,
            this.razonsocialDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGrd_Consultar_Laboratorio.DataSource = this.lABORATORIOSBindingSource;
            this.dataGrd_Consultar_Laboratorio.Location = new System.Drawing.Point(23, 33);
            this.dataGrd_Consultar_Laboratorio.Name = "dataGrd_Consultar_Laboratorio";
            this.dataGrd_Consultar_Laboratorio.ReadOnly = true;
            this.dataGrd_Consultar_Laboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrd_Consultar_Laboratorio.Size = new System.Drawing.Size(450, 300);
            this.dataGrd_Consultar_Laboratorio.TabIndex = 0;
            this.dataGrd_Consultar_Laboratorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrd_Consultar_Laboratorio_CellContentClick);
            // 
            // idlaboratorioDataGridViewTextBoxColumn
            // 
            this.idlaboratorioDataGridViewTextBoxColumn.DataPropertyName = "id_laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.HeaderText = "id_laboratorio";
            this.idlaboratorioDataGridViewTextBoxColumn.Name = "idlaboratorioDataGridViewTextBoxColumn";
            this.idlaboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonsocialDataGridViewTextBoxColumn
            // 
            this.razonsocialDataGridViewTextBoxColumn.DataPropertyName = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.HeaderText = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.Name = "razonsocialDataGridViewTextBoxColumn";
            this.razonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lABORATORIOSBindingSource
            // 
            this.lABORATORIOSBindingSource.DataMember = "LABORATORIOS";
            this.lABORATORIOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet;
            // 
            // _PAV_3K2_2021_12DataSet
            // 
            this._PAV_3K2_2021_12DataSet.DataSetName = "_PAV_3K2_2021_12DataSet";
            this._PAV_3K2_2021_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnCL_Salir
            // 
            this.BtnCL_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCL_Salir.Location = new System.Drawing.Point(498, 331);
            this.BtnCL_Salir.Name = "BtnCL_Salir";
            this.BtnCL_Salir.Size = new System.Drawing.Size(145, 40);
            this.BtnCL_Salir.TabIndex = 2;
            this.BtnCL_Salir.Text = "Salir";
            this.BtnCL_Salir.UseVisualStyleBackColor = false;
            this.BtnCL_Salir.Click += new System.EventHandler(this.BtnCL_Salir_Click);
            // 
            // Btn_Eliminar_Laboratorio
            // 
            this.Btn_Eliminar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Laboratorio.Location = new System.Drawing.Point(498, 93);
            this.Btn_Eliminar_Laboratorio.Name = "Btn_Eliminar_Laboratorio";
            this.Btn_Eliminar_Laboratorio.Size = new System.Drawing.Size(145, 40);
            this.Btn_Eliminar_Laboratorio.TabIndex = 3;
            this.Btn_Eliminar_Laboratorio.Text = "Eliminar laboratorio";
            this.Btn_Eliminar_Laboratorio.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Laboratorio.Click += new System.EventHandler(this.Btn_Eliminar_Laboratorio_Click);
            // 
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Modificar_Laboratorio
            // 
            this.Btn_Modificar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar_Laboratorio.Location = new System.Drawing.Point(498, 33);
            this.Btn_Modificar_Laboratorio.Name = "Btn_Modificar_Laboratorio";
            this.Btn_Modificar_Laboratorio.Size = new System.Drawing.Size(145, 40);
            this.Btn_Modificar_Laboratorio.TabIndex = 4;
            this.Btn_Modificar_Laboratorio.Text = "Modificar laboratorio";
            this.Btn_Modificar_Laboratorio.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Laboratorio.Click += new System.EventHandler(this.Btn_Modificar_Laboratorio_Click);
            // 
            // Consultar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.Btn_Modificar_Laboratorio);
            this.Controls.Add(this.Btn_Eliminar_Laboratorio);
            this.Controls.Add(this.BtnCL_Salir);
            this.Controls.Add(this.dataGrd_Consultar_Laboratorio);
            this.Name = "Consultar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar laboratorios";
            this.Load += new System.EventHandler(this.Consultar_Laboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrd_Consultar_Laboratorio;
        private System.Windows.Forms.Button BtnCL_Salir;
        private System.Windows.Forms.Button Btn_Eliminar_Laboratorio;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
        private System.Windows.Forms.Button Btn_Modificar_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}