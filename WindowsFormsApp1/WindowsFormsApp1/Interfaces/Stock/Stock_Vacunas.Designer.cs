namespace WindowsFormsApp1.Interfaces.Stock
{
    partial class Stock_Vacunas
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
            this.btn_Busqueda_Vacuna = new System.Windows.Forms.Button();
            this.Txt_Quitar = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Txt_Añadir = new System.Windows.Forms.TextBox();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Btn_Añadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Buscar_Vacuna = new System.Windows.Forms.TextBox();
            this._PAV_3K2_2021_12DataSetVacunas = new WindowsFormsApp1._PAV_3K2_2021_12DataSetVacunas();
            this.vACUNASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vACUNASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetVacunasTableAdapters.VACUNASTableAdapter();
            this.DataGrd_Stock_Vac = new System.Windows.Forms.DataGridView();
            this.id_vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_en_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSetVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Stock_Vac)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Busqueda_Vacuna
            // 
            this.btn_Busqueda_Vacuna.Location = new System.Drawing.Point(312, 30);
            this.btn_Busqueda_Vacuna.Name = "btn_Busqueda_Vacuna";
            this.btn_Busqueda_Vacuna.Size = new System.Drawing.Size(75, 23);
            this.btn_Busqueda_Vacuna.TabIndex = 30;
            this.btn_Busqueda_Vacuna.Text = "Buscar";
            this.btn_Busqueda_Vacuna.UseVisualStyleBackColor = true;
            this.btn_Busqueda_Vacuna.Click += new System.EventHandler(this.btn_Busqueda_Vacuna_Click);
            // 
            // Txt_Quitar
            // 
            this.Txt_Quitar.Location = new System.Drawing.Point(641, 278);
            this.Txt_Quitar.Name = "Txt_Quitar";
            this.Txt_Quitar.Size = new System.Drawing.Size(100, 20);
            this.Txt_Quitar.TabIndex = 29;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(617, 381);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 27;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // Txt_Añadir
            // 
            this.Txt_Añadir.Location = new System.Drawing.Point(641, 137);
            this.Txt_Añadir.Name = "Txt_Añadir";
            this.Txt_Añadir.Size = new System.Drawing.Size(100, 20);
            this.Txt_Añadir.TabIndex = 26;
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.Location = new System.Drawing.Point(617, 218);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(145, 40);
            this.Btn_Quitar.TabIndex = 25;
            this.Btn_Quitar.Text = "Quitar del Stock";
            this.Btn_Quitar.UseVisualStyleBackColor = true;
            this.Btn_Quitar.Click += new System.EventHandler(this.Btn_Quitar_Click);
            // 
            // Btn_Añadir
            // 
            this.Btn_Añadir.Location = new System.Drawing.Point(617, 91);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Añadir.TabIndex = 24;
            this.Btn_Añadir.Text = "Añadir al Stock";
            this.Btn_Añadir.UseVisualStyleBackColor = true;
            this.Btn_Añadir.Click += new System.EventHandler(this.Btn_Añadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar por nombre";
            // 
            // Txt_Buscar_Vacuna
            // 
            this.Txt_Buscar_Vacuna.Location = new System.Drawing.Point(183, 32);
            this.Txt_Buscar_Vacuna.Name = "Txt_Buscar_Vacuna";
            this.Txt_Buscar_Vacuna.Size = new System.Drawing.Size(100, 20);
            this.Txt_Buscar_Vacuna.TabIndex = 22;
            // 
            // _PAV_3K2_2021_12DataSetVacunas
            // 
            this._PAV_3K2_2021_12DataSetVacunas.DataSetName = "_PAV_3K2_2021_12DataSetVacunas";
            this._PAV_3K2_2021_12DataSetVacunas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASBindingSource
            // 
            this.vACUNASBindingSource.DataMember = "VACUNAS";
            this.vACUNASBindingSource.DataSource = this._PAV_3K2_2021_12DataSetVacunas;
            // 
            // vACUNASTableAdapter
            // 
            this.vACUNASTableAdapter.ClearBeforeFill = true;
            // 
            // DataGrd_Stock_Vac
            // 
            this.DataGrd_Stock_Vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrd_Stock_Vac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vacuna,
            this.descripcion,
            this.id_laboratorio,
            this.nombre,
            this.cantidad_en_stock});
            this.DataGrd_Stock_Vac.Location = new System.Drawing.Point(13, 91);
            this.DataGrd_Stock_Vac.Name = "DataGrd_Stock_Vac";
            this.DataGrd_Stock_Vac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrd_Stock_Vac.Size = new System.Drawing.Size(544, 330);
            this.DataGrd_Stock_Vac.TabIndex = 31;
            // 
            // id_vacuna
            // 
            this.id_vacuna.Frozen = true;
            this.id_vacuna.HeaderText = "Id Vacuna";
            this.id_vacuna.Name = "id_vacuna";
            this.id_vacuna.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.Frozen = true;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_laboratorio
            // 
            this.id_laboratorio.Frozen = true;
            this.id_laboratorio.HeaderText = "Laboratorio";
            this.id_laboratorio.Name = "id_laboratorio";
            this.id_laboratorio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad_en_stock
            // 
            this.cantidad_en_stock.Frozen = true;
            this.cantidad_en_stock.HeaderText = "Cantidad en stock";
            this.cantidad_en_stock.Name = "cantidad_en_stock";
            this.cantidad_en_stock.ReadOnly = true;
            // 
            // Stock_Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrd_Stock_Vac);
            this.Controls.Add(this.btn_Busqueda_Vacuna);
            this.Controls.Add(this.Txt_Quitar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txt_Añadir);
            this.Controls.Add(this.Btn_Quitar);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Buscar_Vacuna);
            this.Name = "Stock_Vacunas";
            this.Text = "Stock_Vacunas";
            this.Load += new System.EventHandler(this.Stock_Vacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSetVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Stock_Vac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Busqueda_Vacuna;
        private System.Windows.Forms.TextBox Txt_Quitar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_Añadir;
        private System.Windows.Forms.Button Btn_Quitar;
        private System.Windows.Forms.Button Btn_Añadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Buscar_Vacuna;
        private _PAV_3K2_2021_12DataSetVacunas _PAV_3K2_2021_12DataSetVacunas;
        private System.Windows.Forms.BindingSource vACUNASBindingSource;
        private _PAV_3K2_2021_12DataSetVacunasTableAdapters.VACUNASTableAdapter vACUNASTableAdapter;
        private System.Windows.Forms.DataGridView DataGrd_Stock_Vac;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_en_stock;
    }
}