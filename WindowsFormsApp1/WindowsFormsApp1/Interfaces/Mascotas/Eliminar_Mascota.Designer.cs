
namespace WindowsFormsApp1.Interfaces.Mascotas
{
    partial class Frm_Eliminar_Mascota
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
            this.Lbl_Confirmar = new System.Windows.Forms.Label();
            this.Btm_Si = new System.Windows.Forms.Button();
            this.Btm_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Confirmar
            // 
            this.Lbl_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmar.Location = new System.Drawing.Point(35, 25);
            this.Lbl_Confirmar.Name = "Lbl_Confirmar";
            this.Lbl_Confirmar.Size = new System.Drawing.Size(203, 56);
            this.Lbl_Confirmar.TabIndex = 9;
            this.Lbl_Confirmar.Text = "¿Desea confirmar la operación?";
            this.Lbl_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btm_Si
            // 
            this.Btm_Si.Location = new System.Drawing.Point(28, 114);
            this.Btm_Si.Name = "Btm_Si";
            this.Btm_Si.Size = new System.Drawing.Size(75, 23);
            this.Btm_Si.TabIndex = 10;
            this.Btm_Si.Text = "Si";
            this.Btm_Si.UseVisualStyleBackColor = true;
            this.Btm_Si.Click += new System.EventHandler(this.Btm_Si_Click);
            // 
            // Btm_No
            // 
            this.Btm_No.Location = new System.Drawing.Point(178, 114);
            this.Btm_No.Name = "Btm_No";
            this.Btm_No.Size = new System.Drawing.Size(75, 23);
            this.Btm_No.TabIndex = 11;
            this.Btm_No.Text = "No";
            this.Btm_No.UseVisualStyleBackColor = true;
            this.Btm_No.Click += new System.EventHandler(this.Btm_No_Click);
            // 
            // Frm_Eliminar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(283, 157);
            this.Controls.Add(this.Btm_No);
            this.Controls.Add(this.Btm_Si);
            this.Controls.Add(this.Lbl_Confirmar);
            this.Name = "Frm_Eliminar_Mascota";
            this.Text = "Eliminar_Mascota";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Confirmar;
        private System.Windows.Forms.Button Btm_Si;
        private System.Windows.Forms.Button Btm_No;
    }
}