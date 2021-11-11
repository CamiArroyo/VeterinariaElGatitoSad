
namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    partial class Frm_Consultar_Calendarios_Vac
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
            this.Dgv_Consultar_Calendario_Vac = new System.Windows.Forms.DataGridView();
            this.nDeCalendarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeLaMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDelDueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendariosVac = new WindowsFormsApp1.Interfaces.Calendarios_Vac.CalendariosVac();
            this.cALENDARIOVACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet7 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7();
            this.Btn_Agregar_Calendario = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Calendario = new System.Windows.Forms.Button();
            this.Btn_Modificar_Calendario = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Ver_Detalle = new System.Windows.Forms.Button();
            this._PAV_3K2_2021_12DataSet6 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6();
            this.dIAGNOSTICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIAGNOSTICOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet6TableAdapters.DIAGNOSTICOSTableAdapter();
            this.cALENDARIO_VACTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet7TableAdapters.CALENDARIO_VACTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataTable1TableAdapter = new WindowsFormsApp1.Interfaces.Calendarios_Vac.CalendariosVacTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Calendario_Vac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendariosVac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALENDARIOVACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSTICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Consultar_Calendario_Vac
            // 
            this.Dgv_Consultar_Calendario_Vac.AllowUserToAddRows = false;
            this.Dgv_Consultar_Calendario_Vac.AllowUserToDeleteRows = false;
            this.Dgv_Consultar_Calendario_Vac.AutoGenerateColumns = false;
            this.Dgv_Consultar_Calendario_Vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Calendario_Vac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDeCalendarioDataGridViewTextBoxColumn,
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn,
            this.nombreDeLaMascotaDataGridViewTextBoxColumn,
            this.nombreDelDueñoDataGridViewTextBoxColumn,
            this.fechaDeInicioDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Calendario_Vac.DataSource = this.dataTable1BindingSource;
            this.Dgv_Consultar_Calendario_Vac.Location = new System.Drawing.Point(11, 28);
            this.Dgv_Consultar_Calendario_Vac.Name = "Dgv_Consultar_Calendario_Vac";
            this.Dgv_Consultar_Calendario_Vac.ReadOnly = true;
            this.Dgv_Consultar_Calendario_Vac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Calendario_Vac.Size = new System.Drawing.Size(743, 350);
            this.Dgv_Consultar_Calendario_Vac.TabIndex = 5;
            // 
            // nDeCalendarioDataGridViewTextBoxColumn
            // 
            this.nDeCalendarioDataGridViewTextBoxColumn.DataPropertyName = "N° de calendario";
            this.nDeCalendarioDataGridViewTextBoxColumn.HeaderText = "N° de calendario";
            this.nDeCalendarioDataGridViewTextBoxColumn.Name = "nDeCalendarioDataGridViewTextBoxColumn";
            this.nDeCalendarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDeHistoriaClínicaDataGridViewTextBoxColumn
            // 
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn.DataPropertyName = "N° de historia clínica";
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn.HeaderText = "N° de historia clínica";
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn.Name = "nDeHistoriaClínicaDataGridViewTextBoxColumn";
            this.nDeHistoriaClínicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDeLaMascotaDataGridViewTextBoxColumn
            // 
            this.nombreDeLaMascotaDataGridViewTextBoxColumn.DataPropertyName = "Nombre de la mascota";
            this.nombreDeLaMascotaDataGridViewTextBoxColumn.HeaderText = "Nombre de la mascota";
            this.nombreDeLaMascotaDataGridViewTextBoxColumn.Name = "nombreDeLaMascotaDataGridViewTextBoxColumn";
            this.nombreDeLaMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDelDueñoDataGridViewTextBoxColumn
            // 
            this.nombreDelDueñoDataGridViewTextBoxColumn.DataPropertyName = "Nombre del dueño";
            this.nombreDelDueñoDataGridViewTextBoxColumn.HeaderText = "Nombre del dueño";
            this.nombreDelDueñoDataGridViewTextBoxColumn.Name = "nombreDelDueñoDataGridViewTextBoxColumn";
            this.nombreDelDueñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeInicioDataGridViewTextBoxColumn
            // 
            this.fechaDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.Name = "fechaDeInicioDataGridViewTextBoxColumn";
            this.fechaDeInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.calendariosVac;
            // 
            // calendariosVac
            // 
            this.calendariosVac.DataSetName = "CalendariosVac";
            this.calendariosVac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cALENDARIOVACBindingSource
            // 
            this.cALENDARIOVACBindingSource.DataMember = "CALENDARIO_VAC";
            this.cALENDARIOVACBindingSource.DataSource = this._PAV_3K2_2021_12DataSet7;
            // 
            // _PAV_3K2_2021_12DataSet7
            // 
            this._PAV_3K2_2021_12DataSet7.DataSetName = "_PAV_3K2_2021_12DataSet7";
            this._PAV_3K2_2021_12DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Agregar_Calendario
            // 
            this.Btn_Agregar_Calendario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Agregar_Calendario.Location = new System.Drawing.Point(784, 28);
            this.Btn_Agregar_Calendario.Name = "Btn_Agregar_Calendario";
            this.Btn_Agregar_Calendario.Size = new System.Drawing.Size(145, 40);
            this.Btn_Agregar_Calendario.TabIndex = 9;
            this.Btn_Agregar_Calendario.Text = "Agregar calendario";
            this.Btn_Agregar_Calendario.UseVisualStyleBackColor = false;
            this.Btn_Agregar_Calendario.Click += new System.EventHandler(this.Btn_Agregar_Calendario_Click);
            // 
            // Btn_Eliminar_Calendario
            // 
            this.Btn_Eliminar_Calendario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Calendario.Location = new System.Drawing.Point(784, 144);
            this.Btn_Eliminar_Calendario.Name = "Btn_Eliminar_Calendario";
            this.Btn_Eliminar_Calendario.Size = new System.Drawing.Size(145, 40);
            this.Btn_Eliminar_Calendario.TabIndex = 10;
            this.Btn_Eliminar_Calendario.Text = "Definir calendario como \"Inactivo\"";
            this.Btn_Eliminar_Calendario.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Calendario.Click += new System.EventHandler(this.Btn_Eliminar_Calendario_Click);
            // 
            // Btn_Modificar_Calendario
            // 
            this.Btn_Modificar_Calendario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar_Calendario.Location = new System.Drawing.Point(784, 87);
            this.Btn_Modificar_Calendario.Name = "Btn_Modificar_Calendario";
            this.Btn_Modificar_Calendario.Size = new System.Drawing.Size(145, 40);
            this.Btn_Modificar_Calendario.TabIndex = 11;
            this.Btn_Modificar_Calendario.Text = "Modificar calendario";
            this.Btn_Modificar_Calendario.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Calendario.Click += new System.EventHandler(this.Btn_Modificar_Calendario_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(784, 479);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Ver_Detalle
            // 
            this.Btn_Ver_Detalle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Ver_Detalle.Location = new System.Drawing.Point(784, 254);
            this.Btn_Ver_Detalle.Name = "Btn_Ver_Detalle";
            this.Btn_Ver_Detalle.Size = new System.Drawing.Size(145, 40);
            this.Btn_Ver_Detalle.TabIndex = 8;
            this.Btn_Ver_Detalle.Text = "Ver vacunaciones del calendario";
            this.Btn_Ver_Detalle.UseVisualStyleBackColor = false;
            this.Btn_Ver_Detalle.Click += new System.EventHandler(this.Btn_Ver_Detalle_Click);
            // 
            // _PAV_3K2_2021_12DataSet6
            // 
            this._PAV_3K2_2021_12DataSet6.DataSetName = "_PAV_3K2_2021_12DataSet6";
            this._PAV_3K2_2021_12DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIAGNOSTICOSBindingSource
            // 
            this.dIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS";
            this.dIAGNOSTICOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet6;
            // 
            // dIAGNOSTICOSTableAdapter
            // 
            this.dIAGNOSTICOSTableAdapter.ClearBeforeFill = true;
            // 
            // cALENDARIO_VACTableAdapter
            // 
            this.cALENDARIO_VACTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Pets_Multicolor;
            this.pictureBox2.Location = new System.Drawing.Point(-34, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(788, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(771, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 556);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Consultar_Calendarios_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(944, 542);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Modificar_Calendario);
            this.Controls.Add(this.Btn_Eliminar_Calendario);
            this.Controls.Add(this.Btn_Agregar_Calendario);
            this.Controls.Add(this.Btn_Ver_Detalle);
            this.Controls.Add(this.Dgv_Consultar_Calendario_Vac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Consultar_Calendarios_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar calendarios de vacunación";
            this.Load += new System.EventHandler(this.Frm_Consultar_Calendarios_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Calendario_Vac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendariosVac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALENDARIOVACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSTICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Calendario_Vac;
        private System.Windows.Forms.Button Btn_Agregar_Calendario;
        private System.Windows.Forms.Button Btn_Eliminar_Calendario;
        private System.Windows.Forms.Button Btn_Modificar_Calendario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Ver_Detalle;
        private _PAV_3K2_2021_12DataSet6 _PAV_3K2_2021_12DataSet6;
        private System.Windows.Forms.BindingSource dIAGNOSTICOSBindingSource;
        private _PAV_3K2_2021_12DataSet6TableAdapters.DIAGNOSTICOSTableAdapter dIAGNOSTICOSTableAdapter;
        private _PAV_3K2_2021_12DataSet7 _PAV_3K2_2021_12DataSet7;
        private System.Windows.Forms.BindingSource cALENDARIOVACBindingSource;
        private _PAV_3K2_2021_12DataSet7TableAdapters.CALENDARIO_VACTableAdapter cALENDARIO_VACTableAdapter;
        private CalendariosVac calendariosVac;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private CalendariosVacTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDeCalendarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDeHistoriaClínicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeLaMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDelDueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}