
namespace WindowsFormsApp1.Interfaces.Vacs
{
    partial class Frm_Eliminar_Vacuna
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
            this.LblE_Confirmar_Operacion = new System.Windows.Forms.Label();
            this.BtnE_Cancelar_Vacuna = new System.Windows.Forms.Button();
            this.BtnE_Vacuna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblE_Confirmar_Operacion
            // 
            this.LblE_Confirmar_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_Confirmar_Operacion.Location = new System.Drawing.Point(58, 37);
            this.LblE_Confirmar_Operacion.Name = "LblE_Confirmar_Operacion";
            this.LblE_Confirmar_Operacion.Size = new System.Drawing.Size(203, 56);
            this.LblE_Confirmar_Operacion.TabIndex = 8;
            this.LblE_Confirmar_Operacion.Text = "¿Desea confirmar la operación?";
            this.LblE_Confirmar_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnE_Cancelar_Vacuna
            // 
            this.BtnE_Cancelar_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Cancelar_Vacuna.Location = new System.Drawing.Point(173, 115);
            this.BtnE_Cancelar_Vacuna.Name = "BtnE_Cancelar_Vacuna";
            this.BtnE_Cancelar_Vacuna.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Cancelar_Vacuna.TabIndex = 7;
            this.BtnE_Cancelar_Vacuna.Text = "Cancelar";
            this.BtnE_Cancelar_Vacuna.UseVisualStyleBackColor = false;
            this.BtnE_Cancelar_Vacuna.Click += new System.EventHandler(this.BtnE_Cancelar_Vacuna_Click);
            // 
            // BtnE_Vacuna
            // 
            this.BtnE_Vacuna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Vacuna.Location = new System.Drawing.Point(23, 115);
            this.BtnE_Vacuna.Name = "BtnE_Vacuna";
            this.BtnE_Vacuna.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Vacuna.TabIndex = 6;
            this.BtnE_Vacuna.Text = "Confirmar";
            this.BtnE_Vacuna.UseVisualStyleBackColor = false;
            this.BtnE_Vacuna.Click += new System.EventHandler(this.BtnE_Vacuna_Click);
            // 
            // Frm_Eliminar_Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 186);
            this.Controls.Add(this.LblE_Confirmar_Operacion);
            this.Controls.Add(this.BtnE_Cancelar_Vacuna);
            this.Controls.Add(this.BtnE_Vacuna);
            this.Name = "Frm_Eliminar_Vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar vacuna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblE_Confirmar_Operacion;
        private System.Windows.Forms.Button BtnE_Cancelar_Vacuna;
        private System.Windows.Forms.Button BtnE_Vacuna;
    }
}