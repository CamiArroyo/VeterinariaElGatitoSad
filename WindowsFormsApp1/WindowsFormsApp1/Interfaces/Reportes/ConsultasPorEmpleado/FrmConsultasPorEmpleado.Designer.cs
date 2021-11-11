
namespace WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEmpleado
{
    partial class FrmConsultasPorEmpleado
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
            this.RwConsultasPorEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dtp_Fecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Desde = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Hasta = new System.Windows.Forms.Label();
            this.Btm_Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RwConsultasPorEmpleado
            // 
            this.RwConsultasPorEmpleado.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEmpleado.ReporteConsultasPorEmpl" +
    "eado.rdlc";
            this.RwConsultasPorEmpleado.Location = new System.Drawing.Point(0, 140);
            this.RwConsultasPorEmpleado.Name = "RwConsultasPorEmpleado";
            this.RwConsultasPorEmpleado.ServerReport.BearerToken = null;
            this.RwConsultasPorEmpleado.Size = new System.Drawing.Size(800, 402);
            this.RwConsultasPorEmpleado.TabIndex = 0;
            // 
            // Dtp_Fecha_Desde
            // 
            this.Dtp_Fecha_Desde.Location = new System.Drawing.Point(164, 58);
            this.Dtp_Fecha_Desde.Name = "Dtp_Fecha_Desde";
            this.Dtp_Fecha_Desde.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Desde.TabIndex = 1;
            // 
            // Dtp_Fecha_Hasta
            // 
            this.Dtp_Fecha_Hasta.Location = new System.Drawing.Point(514, 58);
            this.Dtp_Fecha_Hasta.Name = "Dtp_Fecha_Hasta";
            this.Dtp_Fecha_Hasta.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Hasta.TabIndex = 2;
            // 
            // Lbl_Fecha_Desde
            // 
            this.Lbl_Fecha_Desde.AutoSize = true;
            this.Lbl_Fecha_Desde.Location = new System.Drawing.Point(70, 64);
            this.Lbl_Fecha_Desde.Name = "Lbl_Fecha_Desde";
            this.Lbl_Fecha_Desde.Size = new System.Drawing.Size(72, 13);
            this.Lbl_Fecha_Desde.TabIndex = 3;
            this.Lbl_Fecha_Desde.Text = "Fecha desde:";
            // 
            // Lbl_Fecha_Hasta
            // 
            this.Lbl_Fecha_Hasta.AutoSize = true;
            this.Lbl_Fecha_Hasta.Location = new System.Drawing.Point(419, 64);
            this.Lbl_Fecha_Hasta.Name = "Lbl_Fecha_Hasta";
            this.Lbl_Fecha_Hasta.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Fecha_Hasta.TabIndex = 4;
            this.Lbl_Fecha_Hasta.Text = "Fecha hasta:";
            // 
            // Btm_Registrar
            // 
            this.Btm_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Registrar.Location = new System.Drawing.Point(276, 93);
            this.Btm_Registrar.Name = "Btm_Registrar";
            this.Btm_Registrar.Size = new System.Drawing.Size(247, 27);
            this.Btm_Registrar.TabIndex = 13;
            this.Btm_Registrar.Text = "Generar informe";
            this.Btm_Registrar.UseVisualStyleBackColor = false;
            this.Btm_Registrar.Click += new System.EventHandler(this.Btm_Registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "INFORMACIÓN: Seleccione a continuación el rango de fechas deseado, correspondient" +
    "e a la fecha de entrada de las consultas.";
            // 
            // FrmConsultasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btm_Registrar);
            this.Controls.Add(this.Lbl_Fecha_Hasta);
            this.Controls.Add(this.Lbl_Fecha_Desde);
            this.Controls.Add(this.Dtp_Fecha_Hasta);
            this.Controls.Add(this.Dtp_Fecha_Desde);
            this.Controls.Add(this.RwConsultasPorEmpleado);
            this.Name = "FrmConsultasPorEmpleado";
            this.Text = "Consultas por empleado";
            this.Load += new System.EventHandler(this.FrmConsultasPorEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwConsultasPorEmpleado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Desde;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Hasta;
        private System.Windows.Forms.Label Lbl_Fecha_Desde;
        private System.Windows.Forms.Label Lbl_Fecha_Hasta;
        private System.Windows.Forms.Button Btm_Registrar;
        private System.Windows.Forms.Label label1;
    }
}