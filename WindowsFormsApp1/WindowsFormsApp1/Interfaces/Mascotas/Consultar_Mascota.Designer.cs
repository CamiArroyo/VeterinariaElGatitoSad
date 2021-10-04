
namespace WindowsFormsApp1.Interfaces.Mascotas
{
    partial class Frm_Consultar_Mascota
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
            this._PAV_3K2_2021_12DataSet6 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6();
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6TableAdapters.MASCOTASTableAdapter();
            this.Btm_Modificar_Mascota = new System.Windows.Forms.Button();
            this.Btm_Eliminar_Mascota = new System.Windows.Forms.Button();
            this.Btm_Registrar_Mascota = new System.Windows.Forms.Button();
            this.Dgv_Consultar_Mascotas = new System.Windows.Forms.DataGridView();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.nrohistoriaclinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASCOTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet7 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7();
            this.mASCOTASTableAdapter1 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7TableAdapters.MASCOTASTableAdapter();
            this.Btn_Mostrar_off = new System.Windows.Forms.Button();
            this.Btn_Mostrar_On = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Mascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // _PAV_3K2_2021_12DataSet6
            // 
            this._PAV_3K2_2021_12DataSet6.DataSetName = "_PAV_3K2_2021_12DataSet6";
            this._PAV_3K2_2021_12DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource.DataSource = this._PAV_3K2_2021_12DataSet6;
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // Btm_Modificar_Mascota
            // 
            this.Btm_Modificar_Mascota.Location = new System.Drawing.Point(106, 394);
            this.Btm_Modificar_Mascota.Name = "Btm_Modificar_Mascota";
            this.Btm_Modificar_Mascota.Size = new System.Drawing.Size(88, 44);
            this.Btm_Modificar_Mascota.TabIndex = 1;
            this.Btm_Modificar_Mascota.Text = "Modificar mascota";
            this.Btm_Modificar_Mascota.UseVisualStyleBackColor = true;
            this.Btm_Modificar_Mascota.Click += new System.EventHandler(this.Btm_Modificar_Mascota_Click);
            // 
            // Btm_Eliminar_Mascota
            // 
            this.Btm_Eliminar_Mascota.Location = new System.Drawing.Point(200, 394);
            this.Btm_Eliminar_Mascota.Name = "Btm_Eliminar_Mascota";
            this.Btm_Eliminar_Mascota.Size = new System.Drawing.Size(88, 44);
            this.Btm_Eliminar_Mascota.TabIndex = 2;
            this.Btm_Eliminar_Mascota.Text = "Eliminar mascota";
            this.Btm_Eliminar_Mascota.UseVisualStyleBackColor = true;
            this.Btm_Eliminar_Mascota.Click += new System.EventHandler(this.Btm_Eliminar_Mascota_Click);
            // 
            // Btm_Registrar_Mascota
            // 
            this.Btm_Registrar_Mascota.Location = new System.Drawing.Point(12, 394);
            this.Btm_Registrar_Mascota.Name = "Btm_Registrar_Mascota";
            this.Btm_Registrar_Mascota.Size = new System.Drawing.Size(88, 44);
            this.Btm_Registrar_Mascota.TabIndex = 3;
            this.Btm_Registrar_Mascota.Text = "Registrar mascota";
            this.Btm_Registrar_Mascota.UseVisualStyleBackColor = true;
            this.Btm_Registrar_Mascota.Click += new System.EventHandler(this.Btm_Registrar_Mascota_Click);
            // 
            // Dgv_Consultar_Mascotas
            // 
            this.Dgv_Consultar_Mascotas.AllowUserToAddRows = false;
            this.Dgv_Consultar_Mascotas.AutoGenerateColumns = false;
            this.Dgv_Consultar_Mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Mascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrohistoriaclinicaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.idrazaDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.iddueñoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Mascotas.DataSource = this.mASCOTASBindingSource1;
            this.Dgv_Consultar_Mascotas.Location = new System.Drawing.Point(13, 13);
            this.Dgv_Consultar_Mascotas.Name = "Dgv_Consultar_Mascotas";
            this.Dgv_Consultar_Mascotas.ReadOnly = true;
            this.Dgv_Consultar_Mascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Mascotas.Size = new System.Drawing.Size(843, 355);
            this.Dgv_Consultar_Mascotas.TabIndex = 4;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(768, 394);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(88, 44);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // nrohistoriaclinicaDataGridViewTextBoxColumn
            // 
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.DataPropertyName = "nro_historia_clinica";
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.HeaderText = "nro_historia_clinica";
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.Name = "nrohistoriaclinicaDataGridViewTextBoxColumn";
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // idrazaDataGridViewTextBoxColumn
            // 
            this.idrazaDataGridViewTextBoxColumn.DataPropertyName = "id_raza";
            this.idrazaDataGridViewTextBoxColumn.HeaderText = "id_raza";
            this.idrazaDataGridViewTextBoxColumn.Name = "idrazaDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            // 
            // iddueñoDataGridViewTextBoxColumn
            // 
            this.iddueñoDataGridViewTextBoxColumn.DataPropertyName = "id_dueño";
            this.iddueñoDataGridViewTextBoxColumn.HeaderText = "id_dueño";
            this.iddueñoDataGridViewTextBoxColumn.Name = "iddueñoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // mASCOTASBindingSource1
            // 
            this.mASCOTASBindingSource1.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource1.DataSource = this._PAV_3K2_2021_12DataSet7;
            // 
            // _PAV_3K2_2021_12DataSet7
            // 
            this._PAV_3K2_2021_12DataSet7.DataSetName = "_PAV_3K2_2021_12DataSet7";
            this._PAV_3K2_2021_12DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASCOTASTableAdapter1
            // 
            this.mASCOTASTableAdapter1.ClearBeforeFill = true;
            // 
            // Btn_Mostrar_off
            // 
            this.Btn_Mostrar_off.Location = new System.Drawing.Point(435, 394);
            this.Btn_Mostrar_off.Name = "Btn_Mostrar_off";
            this.Btn_Mostrar_off.Size = new System.Drawing.Size(115, 44);
            this.Btn_Mostrar_off.TabIndex = 6;
            this.Btn_Mostrar_off.Text = "Mostrar off";
            this.Btn_Mostrar_off.UseVisualStyleBackColor = true;
            this.Btn_Mostrar_off.Click += new System.EventHandler(this.Btn_Mostrar_off_Click);
            // 
            // Btn_Mostrar_On
            // 
            this.Btn_Mostrar_On.Location = new System.Drawing.Point(556, 394);
            this.Btn_Mostrar_On.Name = "Btn_Mostrar_On";
            this.Btn_Mostrar_On.Size = new System.Drawing.Size(115, 44);
            this.Btn_Mostrar_On.TabIndex = 7;
            this.Btn_Mostrar_On.Text = "Mostrar on";
            this.Btn_Mostrar_On.UseVisualStyleBackColor = true;
            this.Btn_Mostrar_On.Click += new System.EventHandler(this.Btn_Mostrar_On_Click);
            // 
            // Frm_Consultar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(885, 458);
            this.Controls.Add(this.Btn_Mostrar_On);
            this.Controls.Add(this.Btn_Mostrar_off);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Dgv_Consultar_Mascotas);
            this.Controls.Add(this.Btm_Registrar_Mascota);
            this.Controls.Add(this.Btm_Eliminar_Mascota);
            this.Controls.Add(this.Btm_Modificar_Mascota);
            this.Name = "Frm_Consultar_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_Mascota";
            this.Load += new System.EventHandler(this.Frm_Consultar_Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Mascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _PAV_3K2_2021_12DataSet6 _PAV_3K2_2021_12DataSet6;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private _PAV_3K2_2021_12DataSet6TableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.Button Btm_Modificar_Mascota;
        private System.Windows.Forms.Button Btm_Eliminar_Mascota;
        private System.Windows.Forms.Button Btm_Registrar_Mascota;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Mascotas;
        private _PAV_3K2_2021_12DataSet7 _PAV_3K2_2021_12DataSet7;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource1;
        private _PAV_3K2_2021_12DataSet7TableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrohistoriaclinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Mostrar_off;
        private System.Windows.Forms.Button Btn_Mostrar_On;
    }
}