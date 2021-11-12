
namespace WindowsFormsApp1.Interfaces.Reportes.CantidadPorMedicamento
{
    partial class FrmCantidadPorMedicamento
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
            this.RwCantidadPorMedicamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RwCantidadPorMedicamento
            // 
            this.RwCantidadPorMedicamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwCantidadPorMedicamento.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Interfaces.Reportes.CantidadPorMedicamento.ReporteCantidadPorMed" +
    "icamento.rdlc";
            this.RwCantidadPorMedicamento.Location = new System.Drawing.Point(0, 0);
            this.RwCantidadPorMedicamento.Name = "RwCantidadPorMedicamento";
            this.RwCantidadPorMedicamento.ServerReport.BearerToken = null;
            this.RwCantidadPorMedicamento.Size = new System.Drawing.Size(846, 450);
            this.RwCantidadPorMedicamento.TabIndex = 0;
            // 
            // FrmCantidadPorMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.RwCantidadPorMedicamento);
            this.Name = "FrmCantidadPorMedicamento";
            this.Text = "Cantidad de medicamentos en stock";
            this.Load += new System.EventHandler(this.FrmCantidadPorMedicamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwCantidadPorMedicamento;
    }
}