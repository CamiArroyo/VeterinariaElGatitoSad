
namespace WindowsFormsApp1.Interfaces.Vacs
{
    partial class Frm_Consultar_Vacuna
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
            this.vACUNASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet6 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6();
            this.vACUNASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunas = new WindowsFormsApp1.Vacunas();
            this.vACUNASTableAdapter = new WindowsFormsApp1.VacunasTableAdapters.VACUNASTableAdapter();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Consultar_Detalle = new System.Windows.Forms.Button();
            this.Btn_Editar_Vacuna = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Vacuna = new System.Windows.Forms.Button();
            this.vACUNASTableAdapter1 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6TableAdapters.VACUNASTableAdapter();
            this.vACUNASBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet7 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7();
            this.vACUNASTableAdapter2 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7TableAdapters.VACUNASTableAdapter();
            this.Dgw_Consultar_Vacuna = new System.Windows.Forms.DataGridView();
            this.idvacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadenstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACUNASBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet11 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet11();
            this.vACUNASTableAdapter3 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet11TableAdapters.VACUNASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Vacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // vACUNASBindingSource2
            // 
            this.vACUNASBindingSource2.DataMember = "VACUNAS";
            this.vACUNASBindingSource2.DataSource = this._PAV_3K2_2021_12DataSet6;
            // 
            // _PAV_3K2_2021_12DataSet6
            // 
            this._PAV_3K2_2021_12DataSet6.DataSetName = "_PAV_3K2_2021_12DataSet6";
            this._PAV_3K2_2021_12DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASBindingSource1
            // 
            this.vACUNASBindingSource1.DataMember = "VACUNAS";
            this.vACUNASBindingSource1.DataSource = this.vacunasBindingSource;
            // 
            // vacunasBindingSource
            // 
            this.vacunasBindingSource.DataSource = this.vacunas;
            this.vacunasBindingSource.Position = 0;
            // 
            // vacunas
            // 
            this.vacunas.DataSetName = "Vacunas";
            this.vacunas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASTableAdapter
            // 
            this.vACUNASTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Salir.Location = new System.Drawing.Point(580, 331);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Consultar_Detalle
            // 
            this.Btn_Consultar_Detalle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Detalle.Location = new System.Drawing.Point(580, 33);
            this.Btn_Consultar_Detalle.Name = "Btn_Consultar_Detalle";
            this.Btn_Consultar_Detalle.Size = new System.Drawing.Size(145, 40);
            this.Btn_Consultar_Detalle.TabIndex = 2;
            this.Btn_Consultar_Detalle.Text = "Ver detalle";
            this.Btn_Consultar_Detalle.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Detalle.Click += new System.EventHandler(this.Btn_Consultar_Detalle_Click);
            // 
            // Btn_Editar_Vacuna
            // 
            this.Btn_Editar_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Editar_Vacuna.Location = new System.Drawing.Point(580, 88);
            this.Btn_Editar_Vacuna.Name = "Btn_Editar_Vacuna";
            this.Btn_Editar_Vacuna.Size = new System.Drawing.Size(145, 40);
            this.Btn_Editar_Vacuna.TabIndex = 3;
            this.Btn_Editar_Vacuna.Text = "Modificar vacuna";
            this.Btn_Editar_Vacuna.UseVisualStyleBackColor = false;
            this.Btn_Editar_Vacuna.Click += new System.EventHandler(this.Btn_Editar_Vacuna_Click);
            // 
            // Btn_Eliminar_Vacuna
            // 
            this.Btn_Eliminar_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Vacuna.Location = new System.Drawing.Point(580, 145);
            this.Btn_Eliminar_Vacuna.Name = "Btn_Eliminar_Vacuna";
            this.Btn_Eliminar_Vacuna.Size = new System.Drawing.Size(145, 40);
            this.Btn_Eliminar_Vacuna.TabIndex = 4;
            this.Btn_Eliminar_Vacuna.Text = "Eliminar vacuna";
            this.Btn_Eliminar_Vacuna.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Vacuna.Click += new System.EventHandler(this.Btn_Eliminar_Vacuna_Click);
            // 
            // vACUNASTableAdapter1
            // 
            this.vACUNASTableAdapter1.ClearBeforeFill = true;
            // 
            // vACUNASBindingSource3
            // 
            this.vACUNASBindingSource3.DataMember = "VACUNAS";
            this.vACUNASBindingSource3.DataSource = this._PAV_3K2_2021_12DataSet7;
            // 
            // _PAV_3K2_2021_12DataSet7
            // 
            this._PAV_3K2_2021_12DataSet7.DataSetName = "_PAV_3K2_2021_12DataSet7";
            this._PAV_3K2_2021_12DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASTableAdapter2
            // 
            this.vACUNASTableAdapter2.ClearBeforeFill = true;
            // 
            // Dgw_Consultar_Vacuna
            // 
            this.Dgw_Consultar_Vacuna.AutoGenerateColumns = false;
            this.Dgw_Consultar_Vacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Consultar_Vacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvacunaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idlaboratorioDataGridViewTextBoxColumn,
            this.cantidadenstockDataGridViewTextBoxColumn});
            this.Dgw_Consultar_Vacuna.DataSource = this.vACUNASBindingSource4;
            this.Dgw_Consultar_Vacuna.Location = new System.Drawing.Point(12, 33);
            this.Dgw_Consultar_Vacuna.Name = "Dgw_Consultar_Vacuna";
            this.Dgw_Consultar_Vacuna.Size = new System.Drawing.Size(542, 338);
            this.Dgw_Consultar_Vacuna.TabIndex = 5;
            // 
            // idvacunaDataGridViewTextBoxColumn
            // 
            this.idvacunaDataGridViewTextBoxColumn.DataPropertyName = "id_vacuna";
            this.idvacunaDataGridViewTextBoxColumn.HeaderText = "id_vacuna";
            this.idvacunaDataGridViewTextBoxColumn.Name = "idvacunaDataGridViewTextBoxColumn";
            this.idvacunaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cantidadenstockDataGridViewTextBoxColumn
            // 
            this.cantidadenstockDataGridViewTextBoxColumn.DataPropertyName = "cantidad_en_stock";
            this.cantidadenstockDataGridViewTextBoxColumn.HeaderText = "cantidad_en_stock";
            this.cantidadenstockDataGridViewTextBoxColumn.Name = "cantidadenstockDataGridViewTextBoxColumn";
            // 
            // vACUNASBindingSource4
            // 
            this.vACUNASBindingSource4.DataMember = "VACUNAS";
            this.vACUNASBindingSource4.DataSource = this._PAV_3K2_2021_12DataSet11;
            // 
            // _PAV_3K2_2021_12DataSet11
            // 
            this._PAV_3K2_2021_12DataSet11.DataSetName = "_PAV_3K2_2021_12DataSet11";
            this._PAV_3K2_2021_12DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASTableAdapter3
            // 
            this.vACUNASTableAdapter3.ClearBeforeFill = true;
            // 
            // Frm_Consultar_Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(744, 391);
            this.Controls.Add(this.Dgw_Consultar_Vacuna);
            this.Controls.Add(this.Btn_Eliminar_Vacuna);
            this.Controls.Add(this.Btn_Editar_Vacuna);
            this.Controls.Add(this.Btn_Consultar_Detalle);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "Frm_Consultar_Vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar vacunas";
            this.Load += new System.EventHandler(this.Frm_Consultar_Vacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Vacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vacunasBindingSource;
        private Vacunas vacunas;
        private System.Windows.Forms.BindingSource vACUNASBindingSource1;
        private VacunasTableAdapters.VACUNASTableAdapter vACUNASTableAdapter;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Consultar_Detalle;
        private System.Windows.Forms.Button Btn_Editar_Vacuna;
        private System.Windows.Forms.Button Btn_Eliminar_Vacuna;
        private _PAV_3K2_2021_12DataSet6 _PAV_3K2_2021_12DataSet6;
        private System.Windows.Forms.BindingSource vACUNASBindingSource2;
        private _PAV_3K2_2021_12DataSet6TableAdapters.VACUNASTableAdapter vACUNASTableAdapter1;
        private _PAV_3K2_2021_12DataSet7 _PAV_3K2_2021_12DataSet7;
        private System.Windows.Forms.BindingSource vACUNASBindingSource3;
        private _PAV_3K2_2021_12DataSet7TableAdapters.VACUNASTableAdapter vACUNASTableAdapter2;
        private System.Windows.Forms.DataGridView Dgw_Consultar_Vacuna;
        private _PAV_3K2_2021_12DataSet11 _PAV_3K2_2021_12DataSet11;
        private System.Windows.Forms.BindingSource vACUNASBindingSource4;
        private _PAV_3K2_2021_12DataSet11TableAdapters.VACUNASTableAdapter vACUNASTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlaboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadenstockDataGridViewTextBoxColumn;
    }
}