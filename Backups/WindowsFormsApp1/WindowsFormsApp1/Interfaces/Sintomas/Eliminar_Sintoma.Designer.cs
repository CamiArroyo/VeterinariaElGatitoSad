
namespace WindowsFormsApp1.Interfaces.Sintomas
{
    partial class Frm_Eliminar_Sintoma
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
            this.BtnE_Cancelar_Sintoma = new System.Windows.Forms.Button();
            this.BtnE_Sintoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblE_Confirmar_Operacion
            // 
            this.LblE_Confirmar_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_Confirmar_Operacion.Location = new System.Drawing.Point(63, 37);
            this.LblE_Confirmar_Operacion.Name = "LblE_Confirmar_Operacion";
            this.LblE_Confirmar_Operacion.Size = new System.Drawing.Size(203, 56);
            this.LblE_Confirmar_Operacion.TabIndex = 5;
            this.LblE_Confirmar_Operacion.Text = "¿Desea confirmar la operación?";
            this.LblE_Confirmar_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnE_Cancelar_Sintoma
            // 
            this.BtnE_Cancelar_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Cancelar_Sintoma.Location = new System.Drawing.Point(171, 115);
            this.BtnE_Cancelar_Sintoma.Name = "BtnE_Cancelar_Sintoma";
            this.BtnE_Cancelar_Sintoma.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Cancelar_Sintoma.TabIndex = 4;
            this.BtnE_Cancelar_Sintoma.Text = "Cancelar";
            this.BtnE_Cancelar_Sintoma.UseVisualStyleBackColor = false;
            this.BtnE_Cancelar_Sintoma.Click += new System.EventHandler(this.BtnE_Cancelar_Sintoma_Click);
            // 
            // BtnE_Sintoma
            // 
            this.BtnE_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Sintoma.Location = new System.Drawing.Point(25, 115);
            this.BtnE_Sintoma.Name = "BtnE_Sintoma";
            this.BtnE_Sintoma.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Sintoma.TabIndex = 3;
            this.BtnE_Sintoma.Text = "Confirmar";
            this.BtnE_Sintoma.UseVisualStyleBackColor = false;
            this.BtnE_Sintoma.Click += new System.EventHandler(this.BtnE_Sintoma_Click);
            // 
            // Frm_Eliminar_Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 186);
            this.Controls.Add(this.LblE_Confirmar_Operacion);
            this.Controls.Add(this.BtnE_Cancelar_Sintoma);
            this.Controls.Add(this.BtnE_Sintoma);
            this.Name = "Frm_Eliminar_Sintoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar síntoma";
            this.Load += new System.EventHandler(this.Frm_Eliminar_Sintoma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblE_Confirmar_Operacion;
        private System.Windows.Forms.Button BtnE_Cancelar_Sintoma;
        private System.Windows.Forms.Button BtnE_Sintoma;
    }
}