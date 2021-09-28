
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Consultar_Laboratorio = new System.Windows.Forms.Button();
            this.BtnCL_Salir = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Laboratorio = new System.Windows.Forms.Button();
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrd_Consultar_Laboratorio
            // 
            this.dataGrd_Consultar_Laboratorio.AllowUserToAddRows = false;
            this.dataGrd_Consultar_Laboratorio.AllowUserToDeleteRows = false;
            this.dataGrd_Consultar_Laboratorio.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrd_Consultar_Laboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd_Consultar_Laboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Razon_Social,
            this.Direccion});
            this.dataGrd_Consultar_Laboratorio.Location = new System.Drawing.Point(12, 76);
            this.dataGrd_Consultar_Laboratorio.Name = "dataGrd_Consultar_Laboratorio";
            this.dataGrd_Consultar_Laboratorio.ReadOnly = true;
            this.dataGrd_Consultar_Laboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrd_Consultar_Laboratorio.Size = new System.Drawing.Size(344, 352);
            this.dataGrd_Consultar_Laboratorio.TabIndex = 0;
            this.dataGrd_Consultar_Laboratorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrd_Consultar_Laboratorio_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Razon_Social
            // 
            this.Razon_Social.HeaderText = "Razon_Social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // btn_Consultar_Laboratorio
            // 
            this.btn_Consultar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Consultar_Laboratorio.Location = new System.Drawing.Point(12, 12);
            this.btn_Consultar_Laboratorio.Name = "btn_Consultar_Laboratorio";
            this.btn_Consultar_Laboratorio.Size = new System.Drawing.Size(128, 47);
            this.btn_Consultar_Laboratorio.TabIndex = 1;
            this.btn_Consultar_Laboratorio.Text = "Consultar Laboratorios";
            this.btn_Consultar_Laboratorio.UseVisualStyleBackColor = false;
            this.btn_Consultar_Laboratorio.Click += new System.EventHandler(this.btn_Consultar_Laboratorio_Click);
            // 
            // BtnCL_Salir
            // 
            this.BtnCL_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCL_Salir.Location = new System.Drawing.Point(266, 448);
            this.BtnCL_Salir.Name = "BtnCL_Salir";
            this.BtnCL_Salir.Size = new System.Drawing.Size(90, 41);
            this.BtnCL_Salir.TabIndex = 2;
            this.BtnCL_Salir.Text = "Salir";
            this.BtnCL_Salir.UseVisualStyleBackColor = false;
            this.BtnCL_Salir.Click += new System.EventHandler(this.BtnCL_Salir_Click);
            // 
            // Btn_Eliminar_Laboratorio
            // 
            this.Btn_Eliminar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Laboratorio.Location = new System.Drawing.Point(12, 448);
            this.Btn_Eliminar_Laboratorio.Name = "Btn_Eliminar_Laboratorio";
            this.Btn_Eliminar_Laboratorio.Size = new System.Drawing.Size(112, 41);
            this.Btn_Eliminar_Laboratorio.TabIndex = 3;
            this.Btn_Eliminar_Laboratorio.Text = "Eliminar Laboratorio";
            this.Btn_Eliminar_Laboratorio.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Laboratorio.Click += new System.EventHandler(this.Btn_Eliminar_Laboratorio_Click);
            // 
            // _PAV_3K2_2021_12DataSet
            // 
            this._PAV_3K2_2021_12DataSet.DataSetName = "_PAV_3K2_2021_12DataSet";
            this._PAV_3K2_2021_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lABORATORIOSBindingSource
            // 
            this.lABORATORIOSBindingSource.DataMember = "LABORATORIOS";
            this.lABORATORIOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet;
            // 
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Consultar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(372, 501);
            this.Controls.Add(this.Btn_Eliminar_Laboratorio);
            this.Controls.Add(this.BtnCL_Salir);
            this.Controls.Add(this.btn_Consultar_Laboratorio);
            this.Controls.Add(this.dataGrd_Consultar_Laboratorio);
            this.Name = "Consultar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorios";
            this.Load += new System.EventHandler(this.Consultar_Laboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrd_Consultar_Laboratorio;
        private System.Windows.Forms.Button btn_Consultar_Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button BtnCL_Salir;
        private System.Windows.Forms.Button Btn_Eliminar_Laboratorio;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
    }
}