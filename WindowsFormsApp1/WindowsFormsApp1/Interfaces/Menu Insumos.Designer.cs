
namespace WindowsFormsApp1.Interfaces
{
    partial class Frm_Menu_Insumos
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
            this.Lbl_Seleccion = new System.Windows.Forms.Label();
            this.Lbl_Laboratorio = new System.Windows.Forms.Label();
            this.Lbl_Medicamentos = new System.Windows.Forms.Label();
            this.Lbl_Vacunas = new System.Windows.Forms.Label();
            this.Btn_Registrar_Laboratorio = new System.Windows.Forms.Button();
            this.Btn_Consultar_Laboratorio = new System.Windows.Forms.Button();
            this.Btn_Registrar_Medicamento = new System.Windows.Forms.Button();
            this.Btn_Consultar_Medicamento = new System.Windows.Forms.Button();
            this.Btn_Registrar_Vacuna = new System.Windows.Forms.Button();
            this.Btn_Consultar_Vacuna = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Seleccion
            // 
            this.Lbl_Seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seleccion.Location = new System.Drawing.Point(230, 28);
            this.Lbl_Seleccion.Name = "Lbl_Seleccion";
            this.Lbl_Seleccion.Size = new System.Drawing.Size(257, 44);
            this.Lbl_Seleccion.TabIndex = 3;
            this.Lbl_Seleccion.Text = "Seleccione una opción";
            // 
            // Lbl_Laboratorio
            // 
            this.Lbl_Laboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Laboratorio.Location = new System.Drawing.Point(87, 101);
            this.Lbl_Laboratorio.Name = "Lbl_Laboratorio";
            this.Lbl_Laboratorio.Size = new System.Drawing.Size(124, 32);
            this.Lbl_Laboratorio.TabIndex = 4;
            this.Lbl_Laboratorio.Text = "Laboratorios";
            this.Lbl_Laboratorio.Click += new System.EventHandler(this.Lbl_Laboratorio_Click);
            // 
            // Lbl_Medicamentos
            // 
            this.Lbl_Medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Medicamentos.Location = new System.Drawing.Point(293, 101);
            this.Lbl_Medicamentos.Name = "Lbl_Medicamentos";
            this.Lbl_Medicamentos.Size = new System.Drawing.Size(131, 32);
            this.Lbl_Medicamentos.TabIndex = 5;
            this.Lbl_Medicamentos.Text = "Medicamentos";
            // 
            // Lbl_Vacunas
            // 
            this.Lbl_Vacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vacunas.Location = new System.Drawing.Point(526, 101);
            this.Lbl_Vacunas.Name = "Lbl_Vacunas";
            this.Lbl_Vacunas.Size = new System.Drawing.Size(85, 32);
            this.Lbl_Vacunas.TabIndex = 6;
            this.Lbl_Vacunas.Text = "Vacunas";
            // 
            // Btn_Registrar_Laboratorio
            // 
            this.Btn_Registrar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Laboratorio.Location = new System.Drawing.Point(66, 149);
            this.Btn_Registrar_Laboratorio.Name = "Btn_Registrar_Laboratorio";
            this.Btn_Registrar_Laboratorio.Size = new System.Drawing.Size(145, 40);
            this.Btn_Registrar_Laboratorio.TabIndex = 7;
            this.Btn_Registrar_Laboratorio.Text = "Registrar laboratorio";
            this.Btn_Registrar_Laboratorio.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Laboratorio.Click += new System.EventHandler(this.Btn_Registrar_Laboratorio_Click);
            // 
            // Btn_Consultar_Laboratorio
            // 
            this.Btn_Consultar_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Laboratorio.Location = new System.Drawing.Point(66, 216);
            this.Btn_Consultar_Laboratorio.Name = "Btn_Consultar_Laboratorio";
            this.Btn_Consultar_Laboratorio.Size = new System.Drawing.Size(145, 40);
            this.Btn_Consultar_Laboratorio.TabIndex = 8;
            this.Btn_Consultar_Laboratorio.Text = "Consultar laboratorios";
            this.Btn_Consultar_Laboratorio.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Laboratorio.Click += new System.EventHandler(this.Btn_Consultar_Laboratorio_Click);
            // 
            // Btn_Registrar_Medicamento
            // 
            this.Btn_Registrar_Medicamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Medicamento.Location = new System.Drawing.Point(279, 149);
            this.Btn_Registrar_Medicamento.Name = "Btn_Registrar_Medicamento";
            this.Btn_Registrar_Medicamento.Size = new System.Drawing.Size(145, 40);
            this.Btn_Registrar_Medicamento.TabIndex = 9;
            this.Btn_Registrar_Medicamento.Text = "Registrar medicamento";
            this.Btn_Registrar_Medicamento.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Medicamento.Click += new System.EventHandler(this.Btn_Registrar_Medicamento_Click);
            // 
            // Btn_Consultar_Medicamento
            // 
            this.Btn_Consultar_Medicamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Medicamento.Location = new System.Drawing.Point(279, 216);
            this.Btn_Consultar_Medicamento.Name = "Btn_Consultar_Medicamento";
            this.Btn_Consultar_Medicamento.Size = new System.Drawing.Size(145, 40);
            this.Btn_Consultar_Medicamento.TabIndex = 10;
            this.Btn_Consultar_Medicamento.Text = "Consultar medicamentos";
            this.Btn_Consultar_Medicamento.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Medicamento.Click += new System.EventHandler(this.Btn_Consultar_Medicamento_Click);
            // 
            // Btn_Registrar_Vacuna
            // 
            this.Btn_Registrar_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Vacuna.Location = new System.Drawing.Point(497, 149);
            this.Btn_Registrar_Vacuna.Name = "Btn_Registrar_Vacuna";
            this.Btn_Registrar_Vacuna.Size = new System.Drawing.Size(145, 40);
            this.Btn_Registrar_Vacuna.TabIndex = 11;
            this.Btn_Registrar_Vacuna.Text = "Registrar vacuna";
            this.Btn_Registrar_Vacuna.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Vacuna.Click += new System.EventHandler(this.Btn_Registrar_Vacuna_Click);
            // 
            // Btn_Consultar_Vacuna
            // 
            this.Btn_Consultar_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Vacuna.Location = new System.Drawing.Point(497, 216);
            this.Btn_Consultar_Vacuna.Name = "Btn_Consultar_Vacuna";
            this.Btn_Consultar_Vacuna.Size = new System.Drawing.Size(145, 40);
            this.Btn_Consultar_Vacuna.TabIndex = 12;
            this.Btn_Consultar_Vacuna.Text = "Consultar vacunas";
            this.Btn_Consultar_Vacuna.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Vacuna.Click += new System.EventHandler(this.Btn_Consultar_Vacuna_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(279, 308);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Menu_Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(726, 377);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Consultar_Vacuna);
            this.Controls.Add(this.Btn_Registrar_Vacuna);
            this.Controls.Add(this.Btn_Consultar_Medicamento);
            this.Controls.Add(this.Btn_Registrar_Medicamento);
            this.Controls.Add(this.Btn_Consultar_Laboratorio);
            this.Controls.Add(this.Btn_Registrar_Laboratorio);
            this.Controls.Add(this.Lbl_Vacunas);
            this.Controls.Add(this.Lbl_Medicamentos);
            this.Controls.Add(this.Lbl_Laboratorio);
            this.Controls.Add(this.Lbl_Seleccion);
            this.Name = "Frm_Menu_Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu insumos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Seleccion;
        private System.Windows.Forms.Label Lbl_Laboratorio;
        private System.Windows.Forms.Label Lbl_Medicamentos;
        private System.Windows.Forms.Label Lbl_Vacunas;
        private System.Windows.Forms.Button Btn_Registrar_Laboratorio;
        private System.Windows.Forms.Button Btn_Consultar_Laboratorio;
        private System.Windows.Forms.Button Btn_Registrar_Medicamento;
        private System.Windows.Forms.Button Btn_Consultar_Medicamento;
        private System.Windows.Forms.Button Btn_Registrar_Vacuna;
        private System.Windows.Forms.Button Btn_Consultar_Vacuna;
        private System.Windows.Forms.Button Btn_Salir;
    }
}