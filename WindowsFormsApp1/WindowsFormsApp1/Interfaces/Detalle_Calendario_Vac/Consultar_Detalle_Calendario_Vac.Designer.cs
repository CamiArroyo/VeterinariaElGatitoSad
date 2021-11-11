
namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    partial class Frm_Consultar_Detalle_Calendario_Vac
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
            this.Dgv_Consultar_Detalle_Calendario_Vac = new System.Windows.Forms.DataGridView();
            this.Nro_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis_Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dETALLECALENDARIOVACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet12 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet12();
            this.dETALLE_CALENDARIO_VACTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet12TableAdapters.DETALLE_CALENDARIO_VACTableAdapter();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Agregar_Vacunacion = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Vacunacion = new System.Windows.Forms.Button();
            this.Btn_Modificar_Vacunacion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Detalle_Calendario_Vac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLECALENDARIOVACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Consultar_Detalle_Calendario_Vac
            // 
            this.Dgv_Consultar_Detalle_Calendario_Vac.AllowUserToAddRows = false;
            this.Dgv_Consultar_Detalle_Calendario_Vac.AllowUserToDeleteRows = false;
            this.Dgv_Consultar_Detalle_Calendario_Vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Detalle_Calendario_Vac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Detalle,
            this.Nombre_Vacuna,
            this.Dosis_Vacuna,
            this.Fecha_Prevista,
            this.Fecha_Real,
            this.Nombre_Empleado,
            this.Estado});
            this.Dgv_Consultar_Detalle_Calendario_Vac.Location = new System.Drawing.Point(19, 34);
            this.Dgv_Consultar_Detalle_Calendario_Vac.Name = "Dgv_Consultar_Detalle_Calendario_Vac";
            this.Dgv_Consultar_Detalle_Calendario_Vac.ReadOnly = true;
            this.Dgv_Consultar_Detalle_Calendario_Vac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Detalle_Calendario_Vac.Size = new System.Drawing.Size(745, 350);
            this.Dgv_Consultar_Detalle_Calendario_Vac.TabIndex = 14;
            // 
            // Nro_Detalle
            // 
            this.Nro_Detalle.HeaderText = "Nro de detalle";
            this.Nro_Detalle.Name = "Nro_Detalle";
            this.Nro_Detalle.ReadOnly = true;
            // 
            // Nombre_Vacuna
            // 
            this.Nombre_Vacuna.HeaderText = "Nombre de la vacuna";
            this.Nombre_Vacuna.Name = "Nombre_Vacuna";
            this.Nombre_Vacuna.ReadOnly = true;
            // 
            // Dosis_Vacuna
            // 
            this.Dosis_Vacuna.HeaderText = "Dosis de la vacuna";
            this.Dosis_Vacuna.Name = "Dosis_Vacuna";
            this.Dosis_Vacuna.ReadOnly = true;
            // 
            // Fecha_Prevista
            // 
            this.Fecha_Prevista.HeaderText = "Fecha prevista";
            this.Fecha_Prevista.Name = "Fecha_Prevista";
            this.Fecha_Prevista.ReadOnly = true;
            // 
            // Fecha_Real
            // 
            this.Fecha_Real.HeaderText = "Fecha real";
            this.Fecha_Real.Name = "Fecha_Real";
            this.Fecha_Real.ReadOnly = true;
            // 
            // Nombre_Empleado
            // 
            this.Nombre_Empleado.HeaderText = "Nombre del empleado";
            this.Nombre_Empleado.Name = "Nombre_Empleado";
            this.Nombre_Empleado.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // dETALLECALENDARIOVACBindingSource
            // 
            this.dETALLECALENDARIOVACBindingSource.DataMember = "DETALLE_CALENDARIO_VAC";
            this.dETALLECALENDARIOVACBindingSource.DataSource = this._PAV_3K2_2021_12DataSet12;
            // 
            // _PAV_3K2_2021_12DataSet12
            // 
            this._PAV_3K2_2021_12DataSet12.DataSetName = "_PAV_3K2_2021_12DataSet12";
            this._PAV_3K2_2021_12DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dETALLE_CALENDARIO_VACTableAdapter
            // 
            this.dETALLE_CALENDARIO_VACTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(805, 472);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Agregar_Vacunacion
            // 
            this.Btn_Agregar_Vacunacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Agregar_Vacunacion.Location = new System.Drawing.Point(805, 34);
            this.Btn_Agregar_Vacunacion.Name = "Btn_Agregar_Vacunacion";
            this.Btn_Agregar_Vacunacion.Size = new System.Drawing.Size(145, 40);
            this.Btn_Agregar_Vacunacion.TabIndex = 17;
            this.Btn_Agregar_Vacunacion.Text = "Registrar vacunación pendiente";
            this.Btn_Agregar_Vacunacion.UseVisualStyleBackColor = false;
            this.Btn_Agregar_Vacunacion.Click += new System.EventHandler(this.Btn_Agregar_Vacunacion_Click);
            // 
            // Btn_Eliminar_Vacunacion
            // 
            this.Btn_Eliminar_Vacunacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Vacunacion.Location = new System.Drawing.Point(805, 147);
            this.Btn_Eliminar_Vacunacion.Name = "Btn_Eliminar_Vacunacion";
            this.Btn_Eliminar_Vacunacion.Size = new System.Drawing.Size(145, 40);
            this.Btn_Eliminar_Vacunacion.TabIndex = 18;
            this.Btn_Eliminar_Vacunacion.Text = "Eliminar vacunación pendiente";
            this.Btn_Eliminar_Vacunacion.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Vacunacion.Click += new System.EventHandler(this.Btn_Eliminar_Vacunacion_Click);
            // 
            // Btn_Modificar_Vacunacion
            // 
            this.Btn_Modificar_Vacunacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar_Vacunacion.Location = new System.Drawing.Point(805, 92);
            this.Btn_Modificar_Vacunacion.Name = "Btn_Modificar_Vacunacion";
            this.Btn_Modificar_Vacunacion.Size = new System.Drawing.Size(145, 40);
            this.Btn_Modificar_Vacunacion.TabIndex = 19;
            this.Btn_Modificar_Vacunacion.Text = "Confirmar vacunación";
            this.Btn_Modificar_Vacunacion.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Vacunacion.Click += new System.EventHandler(this.Btn_Modificar_Vacunacion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Pets_Multicolor;
            this.pictureBox2.Location = new System.Drawing.Point(-17, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(788, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(791, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 556);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Consultar_Detalle_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(969, 542);
            this.Controls.Add(this.Btn_Modificar_Vacunacion);
            this.Controls.Add(this.Btn_Eliminar_Vacunacion);
            this.Controls.Add(this.Btn_Agregar_Vacunacion);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dgv_Consultar_Detalle_Calendario_Vac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Consultar_Detalle_Calendario_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar todos los detalles del calendario de vacunación";
            this.Load += new System.EventHandler(this.Frm_Consultar_Detalle_Calendario_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Detalle_Calendario_Vac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLECALENDARIOVACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Detalle_Calendario_Vac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _PAV_3K2_2021_12DataSet12 _PAV_3K2_2021_12DataSet12;
        private System.Windows.Forms.BindingSource dETALLECALENDARIOVACBindingSource;
        private _PAV_3K2_2021_12DataSet12TableAdapters.DETALLE_CALENDARIO_VACTableAdapter dETALLE_CALENDARIO_VACTableAdapter;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Agregar_Vacunacion;
        private System.Windows.Forms.Button Btn_Eliminar_Vacunacion;
        private System.Windows.Forms.Button Btn_Modificar_Vacunacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis_Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Real;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}