
namespace WindowsFormsApp1.Interfaces.Calendario_Vac
{
    partial class Consultar_Calendario_Vac
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrohistoriaclinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocalendariovacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALENDARIOVACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendario_Vac = new WindowsFormsApp1.Calendario_Vac();
            this.cALENDARIO_VACTableAdapter = new WindowsFormsApp1.Calendario_VacTableAdapters.CALENDARIO_VACTableAdapter();
            this.Btn_Consultar_Detalle_Seleccionado = new System.Windows.Forms.Button();
            this.Btn_Registrar_Calendario_Vac = new System.Windows.Forms.Button();
            this.Btn_Registrar_Detalle_Calendario_Vac = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Menu_Mascotas = new System.Windows.Forms.Button();
            this.Btn_Menu_Principal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALENDARIOVACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario_Vac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrohistoriaclinicaDataGridViewTextBoxColumn,
            this.nrocalendariovacDataGridViewTextBoxColumn,
            this.fechainicioDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cALENDARIOVACBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nrohistoriaclinicaDataGridViewTextBoxColumn
            // 
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.DataPropertyName = "nro_historia_clinica";
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.HeaderText = "nro_historia_clinica";
            this.nrohistoriaclinicaDataGridViewTextBoxColumn.Name = "nrohistoriaclinicaDataGridViewTextBoxColumn";
            // 
            // nrocalendariovacDataGridViewTextBoxColumn
            // 
            this.nrocalendariovacDataGridViewTextBoxColumn.DataPropertyName = "nro_calendario_vac";
            this.nrocalendariovacDataGridViewTextBoxColumn.HeaderText = "nro_calendario_vac";
            this.nrocalendariovacDataGridViewTextBoxColumn.Name = "nrocalendariovacDataGridViewTextBoxColumn";
            this.nrocalendariovacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // cALENDARIOVACBindingSource
            // 
            this.cALENDARIOVACBindingSource.DataMember = "CALENDARIO_VAC";
            this.cALENDARIOVACBindingSource.DataSource = this.calendario_Vac;
            // 
            // calendario_Vac
            // 
            this.calendario_Vac.DataSetName = "Calendario_Vac";
            this.calendario_Vac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cALENDARIO_VACTableAdapter
            // 
            this.cALENDARIO_VACTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Consultar_Detalle_Seleccionado
            // 
            this.Btn_Consultar_Detalle_Seleccionado.Location = new System.Drawing.Point(448, 40);
            this.Btn_Consultar_Detalle_Seleccionado.Name = "Btn_Consultar_Detalle_Seleccionado";
            this.Btn_Consultar_Detalle_Seleccionado.Size = new System.Drawing.Size(162, 34);
            this.Btn_Consultar_Detalle_Seleccionado.TabIndex = 2;
            this.Btn_Consultar_Detalle_Seleccionado.Text = "Ver vacunas";
            this.Btn_Consultar_Detalle_Seleccionado.UseVisualStyleBackColor = true;
            // 
            // Btn_Registrar_Calendario_Vac
            // 
            this.Btn_Registrar_Calendario_Vac.Location = new System.Drawing.Point(448, 147);
            this.Btn_Registrar_Calendario_Vac.Name = "Btn_Registrar_Calendario_Vac";
            this.Btn_Registrar_Calendario_Vac.Size = new System.Drawing.Size(162, 34);
            this.Btn_Registrar_Calendario_Vac.TabIndex = 3;
            this.Btn_Registrar_Calendario_Vac.Text = "Nuevo calendario";
            this.Btn_Registrar_Calendario_Vac.UseVisualStyleBackColor = true;
            // 
            // Btn_Registrar_Detalle_Calendario_Vac
            // 
            this.Btn_Registrar_Detalle_Calendario_Vac.Location = new System.Drawing.Point(448, 93);
            this.Btn_Registrar_Detalle_Calendario_Vac.Name = "Btn_Registrar_Detalle_Calendario_Vac";
            this.Btn_Registrar_Detalle_Calendario_Vac.Size = new System.Drawing.Size(162, 34);
            this.Btn_Registrar_Detalle_Calendario_Vac.TabIndex = 4;
            this.Btn_Registrar_Detalle_Calendario_Vac.Text = "Agregar Vacunacion";
            this.Btn_Registrar_Detalle_Calendario_Vac.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Vacuna;
            this.pictureBox2.Location = new System.Drawing.Point(1, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(439, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 449);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Menu_Mascotas
            // 
            this.Btn_Menu_Mascotas.Location = new System.Drawing.Point(448, 342);
            this.Btn_Menu_Mascotas.Name = "Btn_Menu_Mascotas";
            this.Btn_Menu_Mascotas.Size = new System.Drawing.Size(162, 34);
            this.Btn_Menu_Mascotas.TabIndex = 6;
            this.Btn_Menu_Mascotas.Text = "Volver a mascotas";
            this.Btn_Menu_Mascotas.UseVisualStyleBackColor = true;
            // 
            // Btn_Menu_Principal
            // 
            this.Btn_Menu_Principal.Location = new System.Drawing.Point(448, 391);
            this.Btn_Menu_Principal.Name = "Btn_Menu_Principal";
            this.Btn_Menu_Principal.Size = new System.Drawing.Size(162, 34);
            this.Btn_Menu_Principal.TabIndex = 7;
            this.Btn_Menu_Principal.Text = "Volver al menu";
            this.Btn_Menu_Principal.UseVisualStyleBackColor = true;
            // 
            // Consultar_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.Btn_Menu_Principal);
            this.Controls.Add(this.Btn_Menu_Mascotas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Registrar_Detalle_Calendario_Vac);
            this.Controls.Add(this.Btn_Registrar_Calendario_Vac);
            this.Controls.Add(this.Btn_Consultar_Detalle_Seleccionado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultar_Calendario_Vac";
            this.Text = "Consultar_Calendario_Vac";
            this.Load += new System.EventHandler(this.Consultar_Calendario_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cALENDARIOVACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario_Vac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApp1.Calendario_Vac calendario_Vac;
        private System.Windows.Forms.BindingSource cALENDARIOVACBindingSource;
        private Calendario_VacTableAdapters.CALENDARIO_VACTableAdapter cALENDARIO_VACTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrohistoriaclinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocalendariovacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Consultar_Detalle_Seleccionado;
        private System.Windows.Forms.Button Btn_Registrar_Calendario_Vac;
        private System.Windows.Forms.Button Btn_Registrar_Detalle_Calendario_Vac;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Menu_Mascotas;
        private System.Windows.Forms.Button Btn_Menu_Principal;
    }
}