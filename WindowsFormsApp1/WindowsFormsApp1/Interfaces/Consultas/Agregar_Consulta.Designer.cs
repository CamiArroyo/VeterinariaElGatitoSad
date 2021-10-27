
namespace WindowsFormsApp1.Interfaces.Consultas
{
    partial class Frm_Agregar_Consulta
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
            this.Dtm_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.Dtm_Fecha_Egreso = new System.Windows.Forms.DateTimePicker();
            this.Cb_Empleados = new System.Windows.Forms.ComboBox();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleados = new WindowsFormsApp1.Empleados();
            this.Txt_Temperatura = new System.Windows.Forms.TextBox();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Txt_Tratamiento = new System.Windows.Forms.TextBox();
            this.Lbl_temperatura = new System.Windows.Forms.Label();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Tratamiento = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Salida = new System.Windows.Forms.Label();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.eMPLEADOSTableAdapter = new WindowsFormsApp1.EmpleadosTableAdapters.EMPLEADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(743, 452);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Dtm_Fecha_Ingreso
            // 
            this.Dtm_Fecha_Ingreso.Location = new System.Drawing.Point(681, 12);
            this.Dtm_Fecha_Ingreso.Name = "Dtm_Fecha_Ingreso";
            this.Dtm_Fecha_Ingreso.Size = new System.Drawing.Size(207, 20);
            this.Dtm_Fecha_Ingreso.TabIndex = 2;
            // 
            // Dtm_Fecha_Egreso
            // 
            this.Dtm_Fecha_Egreso.Location = new System.Drawing.Point(681, 38);
            this.Dtm_Fecha_Egreso.Name = "Dtm_Fecha_Egreso";
            this.Dtm_Fecha_Egreso.Size = new System.Drawing.Size(207, 20);
            this.Dtm_Fecha_Egreso.TabIndex = 3;
            // 
            // Cb_Empleados
            // 
            this.Cb_Empleados.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLEADOSBindingSource, "id_empleado", true));
            this.Cb_Empleados.DataSource = this.eMPLEADOSBindingSource;
            this.Cb_Empleados.DisplayMember = "id_empleado";
            this.Cb_Empleados.FormattingEnabled = true;
            this.Cb_Empleados.Location = new System.Drawing.Point(142, 41);
            this.Cb_Empleados.Name = "Cb_Empleados";
            this.Cb_Empleados.Size = new System.Drawing.Size(207, 21);
            this.Cb_Empleados.TabIndex = 4;
            this.Cb_Empleados.ValueMember = "id_empleado";
            this.Cb_Empleados.SelectedIndexChanged += new System.EventHandler(this.Cb_Empleados_SelectedIndexChanged);
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.empleados;
            // 
            // empleados
            // 
            this.empleados.DataSetName = "Empleados";
            this.empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Temperatura
            // 
            this.Txt_Temperatura.Location = new System.Drawing.Point(142, 12);
            this.Txt_Temperatura.Name = "Txt_Temperatura";
            this.Txt_Temperatura.Size = new System.Drawing.Size(207, 20);
            this.Txt_Temperatura.TabIndex = 5;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(142, 105);
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(746, 151);
            this.Txt_Observaciones.TabIndex = 6;
            // 
            // Txt_Tratamiento
            // 
            this.Txt_Tratamiento.Location = new System.Drawing.Point(142, 279);
            this.Txt_Tratamiento.Multiline = true;
            this.Txt_Tratamiento.Name = "Txt_Tratamiento";
            this.Txt_Tratamiento.Size = new System.Drawing.Size(746, 151);
            this.Txt_Tratamiento.TabIndex = 7;
            // 
            // Lbl_temperatura
            // 
            this.Lbl_temperatura.AutoSize = true;
            this.Lbl_temperatura.Location = new System.Drawing.Point(13, 18);
            this.Lbl_temperatura.Name = "Lbl_temperatura";
            this.Lbl_temperatura.Size = new System.Drawing.Size(67, 13);
            this.Lbl_temperatura.TabIndex = 9;
            this.Lbl_temperatura.Text = "Temperatura";
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Location = new System.Drawing.Point(13, 108);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Observaciones.TabIndex = 10;
            this.Lbl_Observaciones.Text = "Observaciones";
            // 
            // Lbl_Tratamiento
            // 
            this.Lbl_Tratamiento.AutoSize = true;
            this.Lbl_Tratamiento.Location = new System.Drawing.Point(12, 282);
            this.Lbl_Tratamiento.Name = "Lbl_Tratamiento";
            this.Lbl_Tratamiento.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Tratamiento.TabIndex = 11;
            this.Lbl_Tratamiento.Text = "Tratamiento";
            // 
            // Lbl_Fecha_Entrada
            // 
            this.Lbl_Fecha_Entrada.AutoSize = true;
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(545, 15);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Fecha_Entrada.TabIndex = 12;
            this.Lbl_Fecha_Entrada.Text = "Fecha de ingreso";
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(545, 44);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(87, 13);
            this.Lbl_Fecha_Salida.TabIndex = 13;
            this.Lbl_Fecha_Salida.Text = "Fecha de egreso";
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(13, 49);
            this.Lbl_Id_Empleado.Name = "Lbl_Id_Empleado";
            this.Lbl_Id_Empleado.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Id_Empleado.TabIndex = 14;
            this.Lbl_Id_Empleado.Text = "Empleado";
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(592, 452);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(145, 40);
            this.Btn_Registrar.TabIndex = 15;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Agregar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(908, 512);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.Lbl_Fecha_Salida);
            this.Controls.Add(this.Lbl_Fecha_Entrada);
            this.Controls.Add(this.Lbl_Tratamiento);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_temperatura);
            this.Controls.Add(this.Txt_Tratamiento);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Txt_Temperatura);
            this.Controls.Add(this.Cb_Empleados);
            this.Controls.Add(this.Dtm_Fecha_Egreso);
            this.Controls.Add(this.Dtm_Fecha_Ingreso);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "Frm_Agregar_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Consulta";
            this.Load += new System.EventHandler(this.Frm_Agregar_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DateTimePicker Dtm_Fecha_Ingreso;
        private System.Windows.Forms.DateTimePicker Dtm_Fecha_Egreso;
        private System.Windows.Forms.ComboBox Cb_Empleados;
        private System.Windows.Forms.TextBox Txt_Temperatura;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.TextBox Txt_Tratamiento;
        private System.Windows.Forms.Label Lbl_temperatura;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_Tratamiento;
        private System.Windows.Forms.Label Lbl_Fecha_Entrada;
        private System.Windows.Forms.Label Lbl_Fecha_Salida;
        private System.Windows.Forms.Label Lbl_Id_Empleado;
        private System.Windows.Forms.Button Btn_Registrar;
        private WindowsFormsApp1.Empleados empleados;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private EmpleadosTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
    }
}