
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lbl_id_Consulta = new System.Windows.Forms.Label();
            this.Lbl_temperatura = new System.Windows.Forms.Label();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Tratamiento = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Entrada = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Salida = new System.Windows.Forms.Label();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.empleados = new WindowsFormsApp1.Empleados();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSTableAdapter = new WindowsFormsApp1.EmpleadosTableAdapters.EMPLEADOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(681, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(681, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLEADOSBindingSource, "id_empleado", true));
            this.comboBox1.DataSource = this.eMPLEADOSBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id_empleado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 105);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(746, 151);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 279);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(746, 151);
            this.textBox4.TabIndex = 7;
            // 
            // Lbl_id_Consulta
            // 
            this.Lbl_id_Consulta.AutoSize = true;
            this.Lbl_id_Consulta.Location = new System.Drawing.Point(13, 18);
            this.Lbl_id_Consulta.Name = "Lbl_id_Consulta";
            this.Lbl_id_Consulta.Size = new System.Drawing.Size(60, 13);
            this.Lbl_id_Consulta.TabIndex = 8;
            this.Lbl_id_Consulta.Text = "Id Consulta";
            // 
            // Lbl_temperatura
            // 
            this.Lbl_temperatura.AutoSize = true;
            this.Lbl_temperatura.Location = new System.Drawing.Point(13, 48);
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
            this.Lbl_Fecha_Entrada.Location = new System.Drawing.Point(545, 19);
            this.Lbl_Fecha_Entrada.Name = "Lbl_Fecha_Entrada";
            this.Lbl_Fecha_Entrada.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Fecha_Entrada.TabIndex = 12;
            this.Lbl_Fecha_Entrada.Text = "Fecha de ingreso";
            // 
            // Lbl_Fecha_Salida
            // 
            this.Lbl_Fecha_Salida.AutoSize = true;
            this.Lbl_Fecha_Salida.Location = new System.Drawing.Point(547, 44);
            this.Lbl_Fecha_Salida.Name = "Lbl_Fecha_Salida";
            this.Lbl_Fecha_Salida.Size = new System.Drawing.Size(87, 13);
            this.Lbl_Fecha_Salida.TabIndex = 13;
            this.Lbl_Fecha_Salida.Text = "Fecha de egreso";
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(547, 72);
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
            // empleados
            // 
            this.empleados.DataSetName = "Empleados";
            this.empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.empleados;
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
            this.ClientSize = new System.Drawing.Size(900, 504);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.Lbl_Fecha_Salida);
            this.Controls.Add(this.Lbl_Fecha_Entrada);
            this.Controls.Add(this.Lbl_Tratamiento);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_temperatura);
            this.Controls.Add(this.Lbl_id_Consulta);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "Frm_Agregar_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Consulta";
            this.Load += new System.EventHandler(this.Frm_Agregar_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_id_Consulta;
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