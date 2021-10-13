
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
            this.Btm_Modificar_Mascota = new System.Windows.Forms.Button();
            this.Btm_Eliminar_Mascota = new System.Windows.Forms.Button();
            this.Btm_Registrar_Mascota = new System.Windows.Forms.Button();
            this.Dgv_Consultar_Mascotas = new System.Windows.Forms.DataGridView();
            this.consultarMascotasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.test1Datos1 = new WindowsFormsApp1.Interfaces.Mascotas.Test1Datos();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Mostrar_off = new System.Windows.Forms.Button();
            this.Btn_Mostrar_On = new System.Windows.Forms.Button();
            this.mASCOTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultarMascotasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test1Datos = new WindowsFormsApp1.Interfaces.Mascotas.Test1Datos();
            this.consultarMascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultar_MascotasTableAdapter = new WindowsFormsApp1.Interfaces.Mascotas.Test1DatosTableAdapters.Consultar_MascotasTableAdapter();
            this.mascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Mascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1Datos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btm_Modificar_Mascota
            // 
            this.Btm_Modificar_Mascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Modificar_Mascota.Location = new System.Drawing.Point(787, 79);
            this.Btm_Modificar_Mascota.Name = "Btm_Modificar_Mascota";
            this.Btm_Modificar_Mascota.Size = new System.Drawing.Size(145, 40);
            this.Btm_Modificar_Mascota.TabIndex = 1;
            this.Btm_Modificar_Mascota.Text = "Modificar mascota";
            this.Btm_Modificar_Mascota.UseVisualStyleBackColor = false;
            this.Btm_Modificar_Mascota.Click += new System.EventHandler(this.Btm_Modificar_Mascota_Click);
            // 
            // Btm_Eliminar_Mascota
            // 
            this.Btm_Eliminar_Mascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Eliminar_Mascota.Location = new System.Drawing.Point(787, 136);
            this.Btm_Eliminar_Mascota.Name = "Btm_Eliminar_Mascota";
            this.Btm_Eliminar_Mascota.Size = new System.Drawing.Size(145, 40);
            this.Btm_Eliminar_Mascota.TabIndex = 2;
            this.Btm_Eliminar_Mascota.Text = "Eliminar mascota";
            this.Btm_Eliminar_Mascota.UseVisualStyleBackColor = false;
            this.Btm_Eliminar_Mascota.Click += new System.EventHandler(this.Btm_Eliminar_Mascota_Click);
            // 
            // Btm_Registrar_Mascota
            // 
            this.Btm_Registrar_Mascota.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Registrar_Mascota.Location = new System.Drawing.Point(787, 21);
            this.Btm_Registrar_Mascota.Name = "Btm_Registrar_Mascota";
            this.Btm_Registrar_Mascota.Size = new System.Drawing.Size(145, 40);
            this.Btm_Registrar_Mascota.TabIndex = 3;
            this.Btm_Registrar_Mascota.Text = "Registrar mascota";
            this.Btm_Registrar_Mascota.UseVisualStyleBackColor = false;
            this.Btm_Registrar_Mascota.Click += new System.EventHandler(this.Btm_Registrar_Mascota_Click);
            // 
            // Dgv_Consultar_Mascotas
            // 
            this.Dgv_Consultar_Mascotas.AllowUserToAddRows = false;
            this.Dgv_Consultar_Mascotas.AutoGenerateColumns = false;
            this.Dgv_Consultar_Mascotas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_Consultar_Mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Mascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mascotaDataGridViewTextBoxColumn,
            this.especieDataGridViewTextBoxColumn,
            this.razaDataGridViewTextBoxColumn,
            this.fechaDeNacimientoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.dueñoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Mascotas.DataSource = this.consultarMascotasBindingSource2;
            this.Dgv_Consultar_Mascotas.Location = new System.Drawing.Point(26, 28);
            this.Dgv_Consultar_Mascotas.Name = "Dgv_Consultar_Mascotas";
            this.Dgv_Consultar_Mascotas.ReadOnly = true;
            this.Dgv_Consultar_Mascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Mascotas.Size = new System.Drawing.Size(731, 392);
            this.Dgv_Consultar_Mascotas.TabIndex = 4;
            // 
            // consultarMascotasBindingSource2
            // 
            this.consultarMascotasBindingSource2.DataMember = "Consultar_Mascotas";
            this.consultarMascotasBindingSource2.DataSource = this.test1Datos1;
            // 
            // test1Datos1
            // 
            this.test1Datos1.DataSetName = "Test1Datos";
            this.test1Datos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(787, 380);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Mostrar_off
            // 
            this.Btn_Mostrar_off.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Mostrar_off.Location = new System.Drawing.Point(787, 249);
            this.Btn_Mostrar_off.Name = "Btn_Mostrar_off";
            this.Btn_Mostrar_off.Size = new System.Drawing.Size(145, 40);
            this.Btn_Mostrar_off.TabIndex = 6;
            this.Btn_Mostrar_off.Text = "Mostrar off";
            this.Btn_Mostrar_off.UseVisualStyleBackColor = false;
            this.Btn_Mostrar_off.Click += new System.EventHandler(this.Btn_Mostrar_off_Click);
            // 
            // Btn_Mostrar_On
            // 
            this.Btn_Mostrar_On.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Mostrar_On.Location = new System.Drawing.Point(787, 193);
            this.Btn_Mostrar_On.Name = "Btn_Mostrar_On";
            this.Btn_Mostrar_On.Size = new System.Drawing.Size(145, 40);
            this.Btn_Mostrar_On.TabIndex = 7;
            this.Btn_Mostrar_On.Text = "Mostrar on";
            this.Btn_Mostrar_On.UseVisualStyleBackColor = false;
            this.Btn_Mostrar_On.Click += new System.EventHandler(this.Btn_Mostrar_On_Click);
            // 
            // consultarMascotasBindingSource1
            // 
            this.consultarMascotasBindingSource1.DataMember = "Consultar_Mascotas";
            this.consultarMascotasBindingSource1.DataSource = this.test1Datos;
            // 
            // test1Datos
            // 
            this.test1Datos.DataSetName = "Test1Datos";
            this.test1Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultarMascotasBindingSource
            // 
            this.consultarMascotasBindingSource.DataMember = "Consultar_Mascotas";
            this.consultarMascotasBindingSource.DataSource = this.test1Datos;
            // 
            // consultar_MascotasTableAdapter
            // 
            this.consultar_MascotasTableAdapter.ClearBeforeFill = true;
            // 
            // mascotaDataGridViewTextBoxColumn
            // 
            this.mascotaDataGridViewTextBoxColumn.DataPropertyName = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.HeaderText = "Mascota";
            this.mascotaDataGridViewTextBoxColumn.Name = "mascotaDataGridViewTextBoxColumn";
            this.mascotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especieDataGridViewTextBoxColumn
            // 
            this.especieDataGridViewTextBoxColumn.DataPropertyName = "Especie";
            this.especieDataGridViewTextBoxColumn.HeaderText = "Especie";
            this.especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
            this.especieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razaDataGridViewTextBoxColumn
            // 
            this.razaDataGridViewTextBoxColumn.DataPropertyName = "Raza";
            this.razaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.razaDataGridViewTextBoxColumn.Name = "razaDataGridViewTextBoxColumn";
            this.razaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaDeNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de nacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.Name = "fechaDeNacimientoDataGridViewTextBoxColumn";
            this.fechaDeNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueñoDataGridViewTextBoxColumn
            // 
            this.dueñoDataGridViewTextBoxColumn.DataPropertyName = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.dueñoDataGridViewTextBoxColumn.Name = "dueñoDataGridViewTextBoxColumn";
            this.dueñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // númeroHistoriaClinicaDataGridViewTextBoxColumn
            // 
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.DataPropertyName = "Número_Historia_Clinica";
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.HeaderText = "Número_Historia_Clinica";
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.Name = "númeroHistoriaClinicaDataGridViewTextBoxColumn";
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.númeroHistoriaClinicaDataGridViewTextBoxColumn.Width = 147;
            // 
            // Frm_Consultar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(944, 447);
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Mascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1Datos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarMascotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btm_Modificar_Mascota;
        private System.Windows.Forms.Button Btm_Eliminar_Mascota;
        private System.Windows.Forms.Button Btm_Registrar_Mascota;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Mascotas;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Mostrar_off;
        private System.Windows.Forms.Button Btn_Mostrar_On;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource1;
        private Test1Datos test1Datos;
        private System.Windows.Forms.BindingSource consultarMascotasBindingSource;
        private Test1DatosTableAdapters.Consultar_MascotasTableAdapter consultar_MascotasTableAdapter;
        private System.Windows.Forms.BindingSource consultarMascotasBindingSource1;
        private Test1Datos test1Datos1;
        private System.Windows.Forms.BindingSource consultarMascotasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn númeroHistoriaClinicaDataGridViewTextBoxColumn;
    }
}