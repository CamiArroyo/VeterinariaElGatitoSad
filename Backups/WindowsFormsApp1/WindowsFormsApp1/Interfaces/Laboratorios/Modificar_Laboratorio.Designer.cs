
namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    partial class Modificar_Laboratorio
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
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Txt_Razon_Social = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Lbl_Razon_Social = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Location = new System.Drawing.Point(54, 95);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Direccion.TabIndex = 11;
            this.Lbl_Direccion.Text = "Dirección:";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(159, 92);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(178, 20);
            this.Txt_Direccion.TabIndex = 10;
            // 
            // Txt_Razon_Social
            // 
            this.Txt_Razon_Social.Location = new System.Drawing.Point(159, 48);
            this.Txt_Razon_Social.Name = "Txt_Razon_Social";
            this.Txt_Razon_Social.Size = new System.Drawing.Size(178, 20);
            this.Txt_Razon_Social.TabIndex = 9;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(212, 149);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(57, 149);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Modificar.TabIndex = 7;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Lbl_Razon_Social
            // 
            this.Lbl_Razon_Social.AutoSize = true;
            this.Lbl_Razon_Social.Location = new System.Drawing.Point(54, 51);
            this.Lbl_Razon_Social.Name = "Lbl_Razon_Social";
            this.Lbl_Razon_Social.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Razon_Social.TabIndex = 6;
            this.Lbl_Razon_Social.Text = "Razón social:";
            // 
            // Modificar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(391, 236);
            this.Controls.Add(this.Lbl_Direccion);
            this.Controls.Add(this.Txt_Direccion);
            this.Controls.Add(this.Txt_Razon_Social);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Lbl_Razon_Social);
            this.Name = "Modificar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.TextBox Txt_Razon_Social;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label Lbl_Razon_Social;
    }
}