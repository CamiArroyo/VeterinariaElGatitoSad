
namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    partial class Eliminar_Laboratorio
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
            this.LblL_Confirmar_Operacion = new System.Windows.Forms.Label();
            this.BtnEL_Cancelar = new System.Windows.Forms.Button();
            this.BtnE_Laboratorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblL_Confirmar_Operacion
            // 
            this.LblL_Confirmar_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblL_Confirmar_Operacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblL_Confirmar_Operacion.Location = new System.Drawing.Point(56, 38);
            this.LblL_Confirmar_Operacion.Name = "LblL_Confirmar_Operacion";
            this.LblL_Confirmar_Operacion.Size = new System.Drawing.Size(203, 56);
            this.LblL_Confirmar_Operacion.TabIndex = 5;
            this.LblL_Confirmar_Operacion.Text = "¿Desea confirmar la operación?";
            this.LblL_Confirmar_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEL_Cancelar
            // 
            this.BtnEL_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEL_Cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEL_Cancelar.Location = new System.Drawing.Point(171, 117);
            this.BtnEL_Cancelar.Name = "BtnEL_Cancelar";
            this.BtnEL_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnEL_Cancelar.TabIndex = 4;
            this.BtnEL_Cancelar.Text = "Cancelar";
            this.BtnEL_Cancelar.UseVisualStyleBackColor = false;
            this.BtnEL_Cancelar.Click += new System.EventHandler(this.BtnEL_Cancelar_Click);
            // 
            // BtnE_Laboratorio
            // 
            this.BtnE_Laboratorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Laboratorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnE_Laboratorio.Location = new System.Drawing.Point(25, 117);
            this.BtnE_Laboratorio.Name = "BtnE_Laboratorio";
            this.BtnE_Laboratorio.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Laboratorio.TabIndex = 3;
            this.BtnE_Laboratorio.Text = "Confirmar";
            this.BtnE_Laboratorio.UseVisualStyleBackColor = false;
            this.BtnE_Laboratorio.Click += new System.EventHandler(this.BtnE_Laboratorio_Click);
            // 
            // Eliminar_Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 186);
            this.Controls.Add(this.LblL_Confirmar_Operacion);
            this.Controls.Add(this.BtnEL_Cancelar);
            this.Controls.Add(this.BtnE_Laboratorio);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Eliminar_Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar laboratorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblL_Confirmar_Operacion;
        private System.Windows.Forms.Button BtnEL_Cancelar;
        private System.Windows.Forms.Button BtnE_Laboratorio;
    }
}