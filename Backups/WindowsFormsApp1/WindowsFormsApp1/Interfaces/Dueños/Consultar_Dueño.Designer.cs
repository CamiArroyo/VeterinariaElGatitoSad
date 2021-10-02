
namespace WindowsFormsApp1.Interfaces.Dueños
{
    partial class Frm_Consultar_Dueños
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Registrar_Dueños = new System.Windows.Forms.Button();
            this.Btn_Modificar_Dueños = new System.Windows.Forms.Button();
            this.Dgw_Consultar_Dueños = new System.Windows.Forms.DataGridView();
            this.Btn_Eliminar_Dueño = new System.Windows.Forms.Button();
            this.Btn_Mostrar_off = new System.Windows.Forms.Button();
            this.iddueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUEÑOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12Dueños = new WindowsFormsApp1._PAV_3K2_2021_12Dueños();
            this.dUEÑOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter();
            this.Btn_Mostrar_On = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Dueños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(659, 394);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(88, 44);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Registrar_Dueños
            // 
            this.Btn_Registrar_Dueños.Location = new System.Drawing.Point(632, 12);
            this.Btn_Registrar_Dueños.Name = "Btn_Registrar_Dueños";
            this.Btn_Registrar_Dueños.Size = new System.Drawing.Size(115, 44);
            this.Btn_Registrar_Dueños.TabIndex = 2;
            this.Btn_Registrar_Dueños.Text = "Registrar dueños";
            this.Btn_Registrar_Dueños.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Dueños.Click += new System.EventHandler(this.Btn_Registrar_Dueños_Click);
            // 
            // Btn_Modificar_Dueños
            // 
            this.Btn_Modificar_Dueños.Location = new System.Drawing.Point(632, 74);
            this.Btn_Modificar_Dueños.Name = "Btn_Modificar_Dueños";
            this.Btn_Modificar_Dueños.Size = new System.Drawing.Size(115, 44);
            this.Btn_Modificar_Dueños.TabIndex = 3;
            this.Btn_Modificar_Dueños.Text = "Modificar dueños";
            this.Btn_Modificar_Dueños.UseVisualStyleBackColor = true;
            this.Btn_Modificar_Dueños.Click += new System.EventHandler(this.Btn_Modificar_Dueños_Click);
            // 
            // Dgw_Consultar_Dueños
            // 
            this.Dgw_Consultar_Dueños.AllowUserToAddRows = false;
            this.Dgw_Consultar_Dueños.AutoGenerateColumns = false;
            this.Dgw_Consultar_Dueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Consultar_Dueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddueñoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.Dgw_Consultar_Dueños.DataSource = this.dUEÑOSBindingSource;
            this.Dgw_Consultar_Dueños.Location = new System.Drawing.Point(12, 12);
            this.Dgw_Consultar_Dueños.MultiSelect = false;
            this.Dgw_Consultar_Dueños.Name = "Dgw_Consultar_Dueños";
            this.Dgw_Consultar_Dueños.ReadOnly = true;
            this.Dgw_Consultar_Dueños.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Consultar_Dueños.Size = new System.Drawing.Size(543, 426);
            this.Dgw_Consultar_Dueños.TabIndex = 0;
            this.Dgw_Consultar_Dueños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgw_Consultar_Dueños_CellContentClick);
            // 
            // Btn_Eliminar_Dueño
            // 
            this.Btn_Eliminar_Dueño.Location = new System.Drawing.Point(632, 144);
            this.Btn_Eliminar_Dueño.Name = "Btn_Eliminar_Dueño";
            this.Btn_Eliminar_Dueño.Size = new System.Drawing.Size(115, 44);
            this.Btn_Eliminar_Dueño.TabIndex = 4;
            this.Btn_Eliminar_Dueño.Text = "Eliminar dueños";
            this.Btn_Eliminar_Dueño.UseVisualStyleBackColor = true;
            this.Btn_Eliminar_Dueño.Click += new System.EventHandler(this.Btn_Eliminar_Dueño_Click);
            // 
            // Btn_Mostrar_off
            // 
            this.Btn_Mostrar_off.Location = new System.Drawing.Point(632, 206);
            this.Btn_Mostrar_off.Name = "Btn_Mostrar_off";
            this.Btn_Mostrar_off.Size = new System.Drawing.Size(115, 44);
            this.Btn_Mostrar_off.TabIndex = 5;
            this.Btn_Mostrar_off.Text = "Mostrar off";
            this.Btn_Mostrar_off.UseVisualStyleBackColor = true;
            this.Btn_Mostrar_off.Click += new System.EventHandler(this.Btn_Mostrar_off_Click);
            // 
            // iddueñoDataGridViewTextBoxColumn
            // 
            this.iddueñoDataGridViewTextBoxColumn.DataPropertyName = "id_dueño";
            this.iddueñoDataGridViewTextBoxColumn.HeaderText = "id_dueño";
            this.iddueñoDataGridViewTextBoxColumn.Name = "iddueñoDataGridViewTextBoxColumn";
            this.iddueñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dUEÑOSBindingSource
            // 
            this.dUEÑOSBindingSource.DataMember = "DUEÑOS";
            this.dUEÑOSBindingSource.DataSource = this._PAV_3K2_2021_12Dueños;
            // 
            // _PAV_3K2_2021_12Dueños
            // 
            this._PAV_3K2_2021_12Dueños.DataSetName = "_PAV_3K2_2021_12Dueños";
            this._PAV_3K2_2021_12Dueños.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dUEÑOSTableAdapter
            // 
            this.dUEÑOSTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Mostrar_On
            // 
            this.Btn_Mostrar_On.Location = new System.Drawing.Point(632, 266);
            this.Btn_Mostrar_On.Name = "Btn_Mostrar_On";
            this.Btn_Mostrar_On.Size = new System.Drawing.Size(115, 44);
            this.Btn_Mostrar_On.TabIndex = 6;
            this.Btn_Mostrar_On.Text = "Mostrar on";
            this.Btn_Mostrar_On.UseVisualStyleBackColor = true;
            this.Btn_Mostrar_On.Click += new System.EventHandler(this.Btn_Mostrar_On_Click);
            // 
            // Frm_Consultar_Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(767, 458);
            this.Controls.Add(this.Btn_Mostrar_On);
            this.Controls.Add(this.Btn_Mostrar_off);
            this.Controls.Add(this.Btn_Eliminar_Dueño);
            this.Controls.Add(this.Btn_Modificar_Dueños);
            this.Controls.Add(this.Btn_Registrar_Dueños);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Dgw_Consultar_Dueños);
            this.Name = "Frm_Consultar_Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dueños";
            this.Load += new System.EventHandler(this.Frm_Consultar_Dueños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Consultar_Dueños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _PAV_3K2_2021_12Dueños _PAV_3K2_2021_12Dueños;
        private System.Windows.Forms.BindingSource dUEÑOSBindingSource;
        private _PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter dUEÑOSTableAdapter;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Registrar_Dueños;
        private System.Windows.Forms.Button Btn_Modificar_Dueños;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Dgw_Consultar_Dueños;
        private System.Windows.Forms.Button Btn_Eliminar_Dueño;
        private System.Windows.Forms.Button Btn_Mostrar_off;
        private System.Windows.Forms.Button Btn_Mostrar_On;
    }
}