
namespace WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEspecie
{
    partial class FrmConsultasPorEspecie
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
            this.RwConsultasPorEspecie = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Lbl_Info = new System.Windows.Forms.Label();
            this.Btm_Registrar = new System.Windows.Forms.Button();
            this.Lbl_Fecha_Hasta = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Desde = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Desde = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // RwConsultasPorEspecie
            // 
            this.RwConsultasPorEspecie.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEspecie.ReporteConsultasPorEspec" +
    "ie.rdlc";
            this.RwConsultasPorEspecie.Location = new System.Drawing.Point(0, 141);
            this.RwConsultasPorEspecie.Name = "RwConsultasPorEspecie";
            this.RwConsultasPorEspecie.ServerReport.BearerToken = null;
            this.RwConsultasPorEspecie.Size = new System.Drawing.Size(800, 402);
            this.RwConsultasPorEspecie.TabIndex = 0;
            // 
            // Lbl_Info
            // 
            this.Lbl_Info.AutoSize = true;
            this.Lbl_Info.Location = new System.Drawing.Point(79, 24);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new System.Drawing.Size(617, 13);
            this.Lbl_Info.TabIndex = 20;
            this.Lbl_Info.Text = "INFORMACIÓN: Seleccione a continuación el rango de fechas deseado, correspondient" +
    "e a la fecha de entrada de las consultas.";
            // 
            // Btm_Registrar
            // 
            this.Btm_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Registrar.Location = new System.Drawing.Point(285, 92);
            this.Btm_Registrar.Name = "Btm_Registrar";
            this.Btm_Registrar.Size = new System.Drawing.Size(247, 27);
            this.Btm_Registrar.TabIndex = 19;
            this.Btm_Registrar.Text = "Generar informe";
            this.Btm_Registrar.UseVisualStyleBackColor = false;
            this.Btm_Registrar.Click += new System.EventHandler(this.Btm_Registrar_Click);
            // 
            // Lbl_Fecha_Hasta
            // 
            this.Lbl_Fecha_Hasta.AutoSize = true;
            this.Lbl_Fecha_Hasta.Location = new System.Drawing.Point(428, 63);
            this.Lbl_Fecha_Hasta.Name = "Lbl_Fecha_Hasta";
            this.Lbl_Fecha_Hasta.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Fecha_Hasta.TabIndex = 18;
            this.Lbl_Fecha_Hasta.Text = "Fecha hasta:";
            // 
            // Lbl_Fecha_Desde
            // 
            this.Lbl_Fecha_Desde.AutoSize = true;
            this.Lbl_Fecha_Desde.Location = new System.Drawing.Point(79, 63);
            this.Lbl_Fecha_Desde.Name = "Lbl_Fecha_Desde";
            this.Lbl_Fecha_Desde.Size = new System.Drawing.Size(72, 13);
            this.Lbl_Fecha_Desde.TabIndex = 17;
            this.Lbl_Fecha_Desde.Text = "Fecha desde:";
            // 
            // Dtp_Fecha_Hasta
            // 
            this.Dtp_Fecha_Hasta.Location = new System.Drawing.Point(523, 57);
            this.Dtp_Fecha_Hasta.Name = "Dtp_Fecha_Hasta";
            this.Dtp_Fecha_Hasta.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Hasta.TabIndex = 16;
            // 
            // Dtp_Fecha_Desde
            // 
            this.Dtp_Fecha_Desde.Location = new System.Drawing.Point(173, 57);
            this.Dtp_Fecha_Desde.Name = "Dtp_Fecha_Desde";
            this.Dtp_Fecha_Desde.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Desde.TabIndex = 15;
            // 
            // FrmConsultasPorEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.Lbl_Info);
            this.Controls.Add(this.Btm_Registrar);
            this.Controls.Add(this.Lbl_Fecha_Hasta);
            this.Controls.Add(this.Lbl_Fecha_Desde);
            this.Controls.Add(this.Dtp_Fecha_Hasta);
            this.Controls.Add(this.Dtp_Fecha_Desde);
            this.Controls.Add(this.RwConsultasPorEspecie);
            this.Name = "FrmConsultasPorEspecie";
            this.Text = "Consultas por especie";
            this.Load += new System.EventHandler(this.FrmConsultasPorEspecie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwConsultasPorEspecie;
        private System.Windows.Forms.Label Lbl_Info;
        private System.Windows.Forms.Button Btm_Registrar;
        private System.Windows.Forms.Label Lbl_Fecha_Hasta;
        private System.Windows.Forms.Label Lbl_Fecha_Desde;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Hasta;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Desde;
    }
}