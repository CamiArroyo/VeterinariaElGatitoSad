
namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    partial class Registrar_Laboratorio
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
            this.BtnRL_Registrar = new System.Windows.Forms.Button();
            this.BtnRL_Cancelar = new System.Windows.Forms.Button();
            this.TxtRL_Razon_Social = new System.Windows.Forms.TextBox();
            this.TxtRL_Direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            // 
            // BtnRL_Registrar
            // 
            this.BtnRL_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRL_Registrar.Location = new System.Drawing.Point(77, 131);
            this.BtnRL_Registrar.Name = "BtnRL_Registrar";
            this.BtnRL_Registrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRL_Registrar.TabIndex = 1;
            this.BtnRL_Registrar.Text = "Registrar";
            this.BtnRL_Registrar.UseVisualStyleBackColor = false;
            this.BtnRL_Registrar.Click += new System.EventHandler(this.BtnRL_Registrar_Click);
            // 
            // BtnRL_Cancelar
            // 
            this.BtnRL_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRL_Cancelar.Location = new System.Drawing.Point(184, 131);
            this.BtnRL_Cancelar.Name = "BtnRL_Cancelar";
            this.BtnRL_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnRL_Cancelar.TabIndex = 2;
            this.BtnRL_Cancelar.Text = "Cancelar";
            this.BtnRL_Cancelar.UseVisualStyleBackColor = false;
            this.BtnRL_Cancelar.Click += new System.EventHandler(this.BtnRL_Cancelar_Click);
            // 
            // TxtRL_Razon_Social
            // 
            this.TxtRL_Razon_Social.Location = new System.Drawing.Point(103, 36);
            this.TxtRL_Razon_Social.Name = "TxtRL_Razon_Social";
            this.TxtRL_Razon_Social.Size = new System.Drawing.Size(153, 20);
            this.TxtRL_Razon_Social.TabIndex = 3;
            // 
            // TxtRL_Direccion
            // 
            this.TxtRL_Direccion.Location = new System.Drawing.Point(103, 77);
            this.TxtRL_Direccion.Name = "TxtRL_Direccion";
            this.TxtRL_Direccion.Size = new System.Drawing.Size(153, 20);
            this.TxtRL_Direccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Registrar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(271, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRL_Direccion);
            this.Controls.Add(this.TxtRL_Razon_Social);
            this.Controls.Add(this.BtnRL_Cancelar);
            this.Controls.Add(this.BtnRL_Registrar);
            this.Controls.Add(this.label1);
            this.Name = "Registrar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRL_Registrar;
        private System.Windows.Forms.Button BtnRL_Cancelar;
        private System.Windows.Forms.TextBox TxtRL_Razon_Social;
        private System.Windows.Forms.TextBox TxtRL_Direccion;
        private System.Windows.Forms.Label label2;
    }
}