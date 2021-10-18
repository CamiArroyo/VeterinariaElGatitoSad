
namespace WindowsFormsApp1.Interfaces.Empleados
{
    partial class Modificar_Empleado
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
            this.label10 = new System.Windows.Forms.Label();
            this.TxtM_Repetir_Password = new System.Windows.Forms.TextBox();
            this.BtnM_Cancelar = new System.Windows.Forms.Button();
            this.BtnM_Guardar_Cambios = new System.Windows.Forms.Button();
            this.TxtM_Email = new System.Windows.Forms.TextBox();
            this.DatePM_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtM_Matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtM_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtM_Usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtM_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtM_Nombre = new System.Windows.Forms.TextBox();
            this.DatePM_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtM_DNI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cb_Estado_Empleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Repetir contraseña:";
            // 
            // TxtM_Repetir_Password
            // 
            this.TxtM_Repetir_Password.Location = new System.Drawing.Point(146, 319);
            this.TxtM_Repetir_Password.MaxLength = 50;
            this.TxtM_Repetir_Password.Name = "TxtM_Repetir_Password";
            this.TxtM_Repetir_Password.PasswordChar = '*';
            this.TxtM_Repetir_Password.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Repetir_Password.TabIndex = 42;
            // 
            // BtnM_Cancelar
            // 
            this.BtnM_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Cancelar.Location = new System.Drawing.Point(194, 440);
            this.BtnM_Cancelar.Name = "BtnM_Cancelar";
            this.BtnM_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Cancelar.TabIndex = 41;
            this.BtnM_Cancelar.Text = "Cancelar";
            this.BtnM_Cancelar.UseVisualStyleBackColor = false;
            this.BtnM_Cancelar.Click += new System.EventHandler(this.BtnM_Cancelar_Click);
            // 
            // BtnM_Guardar_Cambios
            // 
            this.BtnM_Guardar_Cambios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Guardar_Cambios.Location = new System.Drawing.Point(42, 440);
            this.BtnM_Guardar_Cambios.Name = "BtnM_Guardar_Cambios";
            this.BtnM_Guardar_Cambios.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Guardar_Cambios.TabIndex = 40;
            this.BtnM_Guardar_Cambios.Text = "Modificar";
            this.BtnM_Guardar_Cambios.UseVisualStyleBackColor = false;
            this.BtnM_Guardar_Cambios.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // TxtM_Email
            // 
            this.TxtM_Email.Location = new System.Drawing.Point(146, 358);
            this.TxtM_Email.MaxLength = 50;
            this.TxtM_Email.Name = "TxtM_Email";
            this.TxtM_Email.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Email.TabIndex = 39;
            // 
            // DatePM_Fecha_Ingreso
            // 
            this.DatePM_Fecha_Ingreso.Location = new System.Drawing.Point(146, 168);
            this.DatePM_Fecha_Ingreso.Name = "DatePM_Fecha_Ingreso";
            this.DatePM_Fecha_Ingreso.Size = new System.Drawing.Size(200, 20);
            this.DatePM_Fecha_Ingreso.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Matrícula:";
            // 
            // TxtM_Matricula
            // 
            this.TxtM_Matricula.Location = new System.Drawing.Point(146, 207);
            this.TxtM_Matricula.MaxLength = 50;
            this.TxtM_Matricula.Name = "TxtM_Matricula";
            this.TxtM_Matricula.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Matricula.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Contraseña:";
            // 
            // TxtM_Password
            // 
            this.TxtM_Password.Location = new System.Drawing.Point(146, 281);
            this.TxtM_Password.MaxLength = 50;
            this.TxtM_Password.Name = "TxtM_Password";
            this.TxtM_Password.PasswordChar = '*';
            this.TxtM_Password.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Password.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Usuario:";
            // 
            // TxtM_Usuario
            // 
            this.TxtM_Usuario.Location = new System.Drawing.Point(146, 243);
            this.TxtM_Usuario.MaxLength = 50;
            this.TxtM_Usuario.Name = "TxtM_Usuario";
            this.TxtM_Usuario.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Usuario.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellido:";
            // 
            // TxtM_Apellido
            // 
            this.TxtM_Apellido.Location = new System.Drawing.Point(146, 95);
            this.TxtM_Apellido.MaxLength = 50;
            this.TxtM_Apellido.Name = "TxtM_Apellido";
            this.TxtM_Apellido.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Apellido.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // TxtM_Nombre
            // 
            this.TxtM_Nombre.Location = new System.Drawing.Point(146, 60);
            this.TxtM_Nombre.MaxLength = 50;
            this.TxtM_Nombre.Name = "TxtM_Nombre";
            this.TxtM_Nombre.Size = new System.Drawing.Size(200, 20);
            this.TxtM_Nombre.TabIndex = 27;
            this.TxtM_Nombre.TextChanged += new System.EventHandler(this.TxtM_Nombre_TextChanged);
            // 
            // DatePM_Fecha_Nacimiento
            // 
            this.DatePM_Fecha_Nacimiento.Location = new System.Drawing.Point(146, 132);
            this.DatePM_Fecha_Nacimiento.Name = "DatePM_Fecha_Nacimiento";
            this.DatePM_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.DatePM_Fecha_Nacimiento.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Número de documento:";
            // 
            // TxtM_DNI
            // 
            this.TxtM_DNI.Location = new System.Drawing.Point(146, 25);
            this.TxtM_DNI.MaxLength = 50;
            this.TxtM_DNI.Name = "TxtM_DNI";
            this.TxtM_DNI.Size = new System.Drawing.Size(200, 20);
            this.TxtM_DNI.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Estado:";
            // 
            // Cb_Estado_Empleado
            // 
            this.Cb_Estado_Empleado.FormattingEnabled = true;
            this.Cb_Estado_Empleado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cb_Estado_Empleado.Location = new System.Drawing.Point(146, 396);
            this.Cb_Estado_Empleado.Name = "Cb_Estado_Empleado";
            this.Cb_Estado_Empleado.Size = new System.Drawing.Size(200, 21);
            this.Cb_Estado_Empleado.TabIndex = 47;
            // 
            // Modificar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(374, 499);
            this.Controls.Add(this.Cb_Estado_Empleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtM_DNI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtM_Repetir_Password);
            this.Controls.Add(this.BtnM_Cancelar);
            this.Controls.Add(this.BtnM_Guardar_Cambios);
            this.Controls.Add(this.TxtM_Email);
            this.Controls.Add(this.DatePM_Fecha_Ingreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtM_Matricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtM_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtM_Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtM_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtM_Nombre);
            this.Controls.Add(this.DatePM_Fecha_Nacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar empleado";
            this.Load += new System.EventHandler(this.Modificar_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtM_Repetir_Password;
        private System.Windows.Forms.Button BtnM_Cancelar;
        private System.Windows.Forms.Button BtnM_Guardar_Cambios;
        private System.Windows.Forms.TextBox TxtM_Email;
        private System.Windows.Forms.DateTimePicker DatePM_Fecha_Ingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtM_Matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtM_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtM_Usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtM_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtM_Nombre;
        private System.Windows.Forms.DateTimePicker DatePM_Fecha_Nacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtM_DNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cb_Estado_Empleado;
    }
}