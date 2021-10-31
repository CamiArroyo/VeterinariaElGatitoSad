
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
            this.SuspendLayout();
            // 
            // RwConsultasPorEmpleado
            // 
            this.RwConsultasPorEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwConsultasPorEmpleado.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEmpleado.ReporteConsultasPorEmpl" +
    "eado.rdlc";
            this.RwConsultasPorEmpleado.Location = new System.Drawing.Point(0, 0);
            this.RwConsultasPorEmpleado.Name = "RwConsultasPorEmpleado";
            this.RwConsultasPorEmpleado.ServerReport.BearerToken = null;
            this.RwConsultasPorEmpleado.Size = new System.Drawing.Size(800, 450);
            this.RwConsultasPorEmpleado.TabIndex = 0;
            // 
            // FrmConsultasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RwConsultasPorEmpleado);
            this.Name = "FrmConsultasPorEmpleado";
            this.Text = "Consultas por empleado";
            this.Load += new System.EventHandler(this.FrmConsultasPorEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwConsultasPorEmpleado;
    }
}