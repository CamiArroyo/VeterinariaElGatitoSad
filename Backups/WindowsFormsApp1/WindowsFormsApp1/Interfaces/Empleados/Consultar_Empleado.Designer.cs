
namespace WindowsFormsApp1.Interfaces.Empleados
{
    partial class Frm_Consultar_Empleado
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
            this.dataGrd_Consultar_Empleado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Consultar_Empleados = new System.Windows.Forms.Button();
            this.Btn_Modificar_Empleado = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Empleado = new System.Windows.Forms.Button();
            this.BtnC_Deshabilitados = new System.Windows.Forms.Button();
            this.BtnC_Salir = new System.Windows.Forms.Button();
            this.Btn_Registrar_Empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrd_Consultar_Empleado
            // 
            this.dataGrd_Consultar_Empleado.AllowUserToAddRows = false;
            this.dataGrd_Consultar_Empleado.AllowUserToDeleteRows = false;
            this.dataGrd_Consultar_Empleado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrd_Consultar_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd_Consultar_Empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Fecha_Nacimiento,
            this.Fecha_Ingreso,
            this.Matricula,
            this.Usuario,
            this.Email,
            this.Estado});
            this.dataGrd_Consultar_Empleado.Location = new System.Drawing.Point(14, 41);
            this.dataGrd_Consultar_Empleado.Name = "dataGrd_Consultar_Empleado";
            this.dataGrd_Consultar_Empleado.ReadOnly = true;
            this.dataGrd_Consultar_Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrd_Consultar_Empleado.Size = new System.Drawing.Size(960, 352);
            this.dataGrd_Consultar_Empleado.TabIndex = 0;
            this.dataGrd_Consultar_Empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.ReadOnly = true;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha Ingreso";
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btn_Consultar_Empleados
            // 
            this.btn_Consultar_Empleados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Consultar_Empleados.Location = new System.Drawing.Point(14, 12);
            this.btn_Consultar_Empleados.Name = "btn_Consultar_Empleados";
            this.btn_Consultar_Empleados.Size = new System.Drawing.Size(111, 23);
            this.btn_Consultar_Empleados.TabIndex = 1;
            this.btn_Consultar_Empleados.Text = "Consultar empleado";
            this.btn_Consultar_Empleados.UseVisualStyleBackColor = false;
            this.btn_Consultar_Empleados.Click += new System.EventHandler(this.btn_Consultar_Empleados_Click);
            // 
            // Btn_Modificar_Empleado
            // 
            this.Btn_Modificar_Empleado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar_Empleado.Location = new System.Drawing.Point(665, 399);
            this.Btn_Modificar_Empleado.Name = "Btn_Modificar_Empleado";
            this.Btn_Modificar_Empleado.Size = new System.Drawing.Size(111, 23);
            this.Btn_Modificar_Empleado.TabIndex = 2;
            this.Btn_Modificar_Empleado.Text = "Modificar empleado";
            this.Btn_Modificar_Empleado.UseVisualStyleBackColor = false;
            this.Btn_Modificar_Empleado.Click += new System.EventHandler(this.Btn_Modificar_Empleado_Click);
            // 
            // Btn_Eliminar_Empleado
            // 
            this.Btn_Eliminar_Empleado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar_Empleado.Location = new System.Drawing.Point(782, 399);
            this.Btn_Eliminar_Empleado.Name = "Btn_Eliminar_Empleado";
            this.Btn_Eliminar_Empleado.Size = new System.Drawing.Size(111, 23);
            this.Btn_Eliminar_Empleado.TabIndex = 3;
            this.Btn_Eliminar_Empleado.Text = "Eliminar empleado";
            this.Btn_Eliminar_Empleado.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Empleado.Click += new System.EventHandler(this.Btn_Eliminar_Empleado_Click);
            // 
            // BtnC_Deshabilitados
            // 
            this.BtnC_Deshabilitados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnC_Deshabilitados.Location = new System.Drawing.Point(14, 399);
            this.BtnC_Deshabilitados.Name = "BtnC_Deshabilitados";
            this.BtnC_Deshabilitados.Size = new System.Drawing.Size(127, 23);
            this.BtnC_Deshabilitados.TabIndex = 4;
            this.BtnC_Deshabilitados.Text = "Mostrar deshabilitados";
            this.BtnC_Deshabilitados.UseVisualStyleBackColor = false;
            this.BtnC_Deshabilitados.Click += new System.EventHandler(this.BtnC_Deshabilitados_Click);
            // 
            // BtnC_Salir
            // 
            this.BtnC_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnC_Salir.Location = new System.Drawing.Point(899, 399);
            this.BtnC_Salir.Name = "BtnC_Salir";
            this.BtnC_Salir.Size = new System.Drawing.Size(75, 23);
            this.BtnC_Salir.TabIndex = 5;
            this.BtnC_Salir.Text = "Salir";
            this.BtnC_Salir.UseVisualStyleBackColor = false;
            this.BtnC_Salir.Click += new System.EventHandler(this.BtnC_Salir_Click);
            // 
            // Btn_Registrar_Empleado
            // 
            this.Btn_Registrar_Empleado.Location = new System.Drawing.Point(151, 12);
            this.Btn_Registrar_Empleado.Name = "Btn_Registrar_Empleado";
            this.Btn_Registrar_Empleado.Size = new System.Drawing.Size(113, 23);
            this.Btn_Registrar_Empleado.TabIndex = 6;
            this.Btn_Registrar_Empleado.Text = "Registrar empleado";
            this.Btn_Registrar_Empleado.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Empleado.Click += new System.EventHandler(this.Btn_Registrar_Empleado_Click);
            // 
            // Frm_Consultar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(986, 434);
            this.Controls.Add(this.Btn_Registrar_Empleado);
            this.Controls.Add(this.BtnC_Salir);
            this.Controls.Add(this.BtnC_Deshabilitados);
            this.Controls.Add(this.Btn_Eliminar_Empleado);
            this.Controls.Add(this.Btn_Modificar_Empleado);
            this.Controls.Add(this.btn_Consultar_Empleados);
            this.Controls.Add(this.dataGrd_Consultar_Empleado);
            this.Name = "Frm_Consultar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd_Consultar_Empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrd_Consultar_Empleado;
        private System.Windows.Forms.Button btn_Consultar_Empleados;
        private System.Windows.Forms.Button Btn_Modificar_Empleado;
        private System.Windows.Forms.Button Btn_Eliminar_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button BtnC_Deshabilitados;
        private System.Windows.Forms.Button BtnC_Salir;
        private System.Windows.Forms.Button Btn_Registrar_Empleado;
    }
}