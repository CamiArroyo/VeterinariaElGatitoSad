
namespace WindowsFormsApp1.Interfaces
{
    partial class FrmReportesYListados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReporte_ConsXEmp = new System.Windows.Forms.Button();
            this.BtnReporte_StockMedYVac = new System.Windows.Forms.Button();
            this.BtnReporte_ConsXEsp = new System.Windows.Forms.Button();
            this.Lbl_Reportes = new System.Windows.Forms.Label();
            this.Btn_Animales_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(2, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 326);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReporte_ConsXEmp
            // 
            this.BtnReporte_ConsXEmp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnReporte_ConsXEmp.Location = new System.Drawing.Point(183, 29);
            this.BtnReporte_ConsXEmp.Name = "BtnReporte_ConsXEmp";
            this.BtnReporte_ConsXEmp.Size = new System.Drawing.Size(321, 40);
            this.BtnReporte_ConsXEmp.TabIndex = 18;
            this.BtnReporte_ConsXEmp.Text = "Cantidad de consultas atendidas por empleado";
            this.BtnReporte_ConsXEmp.UseVisualStyleBackColor = false;
            this.BtnReporte_ConsXEmp.Click += new System.EventHandler(this.BtnReporte_ConsXEmp_Click);
            // 
            // BtnReporte_StockMedYVac
            // 
            this.BtnReporte_StockMedYVac.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnReporte_StockMedYVac.Location = new System.Drawing.Point(183, 150);
            this.BtnReporte_StockMedYVac.Name = "BtnReporte_StockMedYVac";
            this.BtnReporte_StockMedYVac.Size = new System.Drawing.Size(321, 40);
            this.BtnReporte_StockMedYVac.TabIndex = 19;
            this.BtnReporte_StockMedYVac.Text = "Cantidad en stock de medicamentos y vacunas";
            this.BtnReporte_StockMedYVac.UseVisualStyleBackColor = false;
            this.BtnReporte_StockMedYVac.Click += new System.EventHandler(this.BtnReporte_StockMedYVac_Click);
            // 
            // BtnReporte_ConsXEsp
            // 
            this.BtnReporte_ConsXEsp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnReporte_ConsXEsp.Location = new System.Drawing.Point(183, 90);
            this.BtnReporte_ConsXEsp.Name = "BtnReporte_ConsXEsp";
            this.BtnReporte_ConsXEsp.Size = new System.Drawing.Size(321, 40);
            this.BtnReporte_ConsXEsp.TabIndex = 20;
            this.BtnReporte_ConsXEsp.Text = "Cantidad de consultas atendidas por especie de animales";
            this.BtnReporte_ConsXEsp.UseVisualStyleBackColor = false;
            this.BtnReporte_ConsXEsp.Click += new System.EventHandler(this.BtnReporte_ConsXEsp_Click);
            // 
            // Lbl_Reportes
            // 
            this.Lbl_Reportes.BackColor = System.Drawing.Color.SeaGreen;
            this.Lbl_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Reportes.Location = new System.Drawing.Point(26, 29);
            this.Lbl_Reportes.Name = "Lbl_Reportes";
            this.Lbl_Reportes.Size = new System.Drawing.Size(107, 32);
            this.Lbl_Reportes.TabIndex = 21;
            this.Lbl_Reportes.Text = "Reportes";
            this.Lbl_Reportes.Click += new System.EventHandler(this.Lbl_Reportes_Click);
            // 
            // Btn_Animales_Salir
            // 
            this.Btn_Animales_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Animales_Salir.Location = new System.Drawing.Point(382, 218);
            this.Btn_Animales_Salir.Name = "Btn_Animales_Salir";
            this.Btn_Animales_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Animales_Salir.TabIndex = 23;
            this.Btn_Animales_Salir.Text = "Salir";
            this.Btn_Animales_Salir.UseVisualStyleBackColor = false;
            this.Btn_Animales_Salir.Click += new System.EventHandler(this.Btn_Animales_Salir_Click);
            // 
            // FrmReportesYListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(539, 285);
            this.Controls.Add(this.Btn_Animales_Salir);
            this.Controls.Add(this.Lbl_Reportes);
            this.Controls.Add(this.BtnReporte_ConsXEsp);
            this.Controls.Add(this.BtnReporte_StockMedYVac);
            this.Controls.Add(this.BtnReporte_ConsXEmp);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmReportesYListados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes y listados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReporte_ConsXEmp;
        private System.Windows.Forms.Button BtnReporte_StockMedYVac;
        private System.Windows.Forms.Button BtnReporte_ConsXEsp;
        private System.Windows.Forms.Label Lbl_Reportes;
        private System.Windows.Forms.Button Btn_Animales_Salir;
    }
}