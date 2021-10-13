
namespace WindowsFormsApp1.Interfaces.Empleados
{
    partial class Frm_Registrar_Empleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateP_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Matricula = new System.Windows.Forms.TextBox();
            this.DateP_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Repetir_Password = new System.Windows.Forms.TextBox();
            this.Txt_DNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de nacimiento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateP_Fecha_Nacimiento
            // 
            this.DateP_Fecha_Nacimiento.Location = new System.Drawing.Point(147, 143);
            this.DateP_Fecha_Nacimiento.Name = "DateP_Fecha_Nacimiento";
            this.DateP_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.DateP_Fecha_Nacimiento.TabIndex = 4;
            this.DateP_Fecha_Nacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(147, 71);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(147, 106);
            this.Txt_Apellido.MaxLength = 50;
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(200, 20);
            this.Txt_Apellido.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario:";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(147, 254);
            this.Txt_Usuario.MaxLength = 50;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(200, 20);
            this.Txt_Usuario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(147, 290);
            this.Txt_Password.MaxLength = 50;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(200, 20);
            this.Txt_Password.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Matrícula:";
            // 
            // Txt_Matricula
            // 
            this.Txt_Matricula.Location = new System.Drawing.Point(147, 218);
            this.Txt_Matricula.MaxLength = 50;
            this.Txt_Matricula.Name = "Txt_Matricula";
            this.Txt_Matricula.Size = new System.Drawing.Size(200, 20);
            this.Txt_Matricula.TabIndex = 13;
            // 
            // DateP_Fecha_Ingreso
            // 
            this.DateP_Fecha_Ingreso.Location = new System.Drawing.Point(147, 179);
            this.DateP_Fecha_Ingreso.Name = "DateP_Fecha_Ingreso";
            this.DateP_Fecha_Ingreso.Size = new System.Drawing.Size(200, 20);
            this.DateP_Fecha_Ingreso.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(147, 372);
            this.Txt_Email.MaxLength = 50;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(200, 20);
            this.Txt_Email.TabIndex = 17;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(47, 420);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Registrar.TabIndex = 19;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(205, 420);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 20;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Repetir contraseña:";
            // 
            // Txt_Repetir_Password
            // 
            this.Txt_Repetir_Password.Location = new System.Drawing.Point(147, 333);
            this.Txt_Repetir_Password.MaxLength = 50;
            this.Txt_Repetir_Password.Name = "Txt_Repetir_Password";
            this.Txt_Repetir_Password.PasswordChar = '*';
            this.Txt_Repetir_Password.Size = new System.Drawing.Size(200, 20);
            this.Txt_Repetir_Password.TabIndex = 21;
            this.Txt_Repetir_Password.TextChanged += new System.EventHandler(this.Txt_Repetir_Password_TextChanged);
            // 
            // Txt_DNI
            // 
            this.Txt_DNI.Location = new System.Drawing.Point(147, 33);
            this.Txt_DNI.MaxLength = 50;
            this.Txt_DNI.Name = "Txt_DNI";
            this.Txt_DNI.Size = new System.Drawing.Size(200, 20);
            this.Txt_DNI.TabIndex = 23;
            // 
            // Frm_Registrar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(374, 483);
            this.Controls.Add(this.Txt_DNI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Repetir_Password);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.DateP_Fecha_Ingreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Matricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.DateP_Fecha_Nacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar empleado";
            this.Load += new System.EventHandler(this.Frm_Registrar_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateP_Fecha_Nacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Matricula;
        private System.Windows.Forms.DateTimePicker DateP_Fecha_Ingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Repetir_Password;
        private System.Windows.Forms.TextBox Txt_DNI;
    }
}