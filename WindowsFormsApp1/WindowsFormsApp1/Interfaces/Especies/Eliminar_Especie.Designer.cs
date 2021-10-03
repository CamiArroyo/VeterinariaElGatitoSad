
namespace WindowsFormsApp1.Interfaces.Especies
{
    partial class Frm_Eliminar_Especie
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
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Confirmar
            // 
            this.Lbl_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmar.Location = new System.Drawing.Point(44, 36);
            this.Lbl_Confirmar.Name = "Lbl_Confirmar";
            this.Lbl_Confirmar.Size = new System.Drawing.Size(203, 56);
            this.Lbl_Confirmar.TabIndex = 6;
            this.Lbl_Confirmar.Text = "¿Desea confirmar la operación?";
            this.Lbl_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Confirmar.Location = new System.Drawing.Point(18, 126);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Confirmar.TabIndex = 7;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(145, 126);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_Eliminar_Especie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Lbl_Confirmar);
            this.Name = "Frm_Eliminar_Especie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar especie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Confirmar;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}