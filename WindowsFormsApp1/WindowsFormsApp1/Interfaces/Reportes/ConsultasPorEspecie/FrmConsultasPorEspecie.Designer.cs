
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
            this.SuspendLayout();
            // 
            // RwConsultasPorEspecie
            // 
            this.RwConsultasPorEspecie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwConsultasPorEspecie.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Interfaces.Reportes.ConsultasPorEspecie.ReporteConsultasPorEspec" +
    "ie.rdlc";
            this.RwConsultasPorEspecie.Location = new System.Drawing.Point(0, 0);
            this.RwConsultasPorEspecie.Name = "RwConsultasPorEspecie";
            this.RwConsultasPorEspecie.ServerReport.BearerToken = null;
            this.RwConsultasPorEspecie.Size = new System.Drawing.Size(800, 450);
            this.RwConsultasPorEspecie.TabIndex = 0;
            // 
            // FrmConsultasPorEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RwConsultasPorEspecie);
            this.Name = "FrmConsultasPorEspecie";
            this.Text = "Consultas por especie";
            this.Load += new System.EventHandler(this.FrmConsultasPorEspecie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwConsultasPorEspecie;
    }
}