
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
            this.BtnCL_Salir = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Laboratorio = new System.Windows.Forms.Button();
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrd_Consultar_Laboratorio
            // 
            this.dataGrd_Consultar_Laboratorio.AllowUserToAddRows = false;
            this.dataGrd_Consultar_Laboratorio.AllowUserToDeleteRows = false;
            this.dataGrd_Consultar_Laboratorio.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrd_Consultar_Laboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd_Consultar_Laboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Razon_Social,
            this.Direccion});
            this.dataGrd_Consultar_Laboratorio.Location = new System.Drawing.Point(23, 33);
            this.dataGrd_Consultar_Laboratorio.Name = "dataGrd_Consultar_Laboratorio";
            this.dataGrd_Consultar_Laboratorio.ReadOnly = true;
            this.dataGrd_Consultar_Laboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrd_Consultar_Laboratorio.Size = new System.Drawing.Size(450, 300);
            this.dataGrd_Consultar_Laboratorio.TabIndex = 0;
            this.dataGrd_Consultar_Laboratorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrd_Consultar_Laboratorio_CellContentClick);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(498, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar laboratorio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID laboratorio";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Razon_Social
            // 
            this.Razon_Social.HeaderText = "Razón social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Consultar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Eliminar_Laboratorio);
            this.Controls.Add(this.BtnCL_Salir);
            this.Controls.Add(this.dataGrd_Consultar_Laboratorio);
            this.Name = "Consultar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar laboratorios";
            this.Load += new System.EventHandler(this.Consultar_Laboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Laboratorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrd_Consultar_Laboratorio;
        private System.Windows.Forms.Button BtnCL_Salir;
        private System.Windows.Forms.Button Btn_Eliminar_Laboratorio;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}