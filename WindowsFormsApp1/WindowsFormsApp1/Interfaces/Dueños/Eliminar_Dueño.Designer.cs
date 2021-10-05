
namespace WindowsFormsApp1.Interfaces.Dueños
{
    partial class Frm_Eliminar_Dueño
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
            this.BtnE_Dueño = new System.Windows.Forms.Button();
            this.BtnE_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblE_Confirmar_Operacion
            // 
            this.LblE_Confirmar_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_Confirmar_Operacion.Location = new System.Drawing.Point(61, 35);
            this.LblE_Confirmar_Operacion.Name = "LblE_Confirmar_Operacion";
            this.LblE_Confirmar_Operacion.Size = new System.Drawing.Size(203, 56);
            this.LblE_Confirmar_Operacion.TabIndex = 5;
            this.LblE_Confirmar_Operacion.Text = "¿Desea confirmar la operación?";
            this.LblE_Confirmar_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnE_Dueño
            // 
            this.BtnE_Dueño.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Dueño.Location = new System.Drawing.Point(28, 112);
            this.BtnE_Dueño.Name = "BtnE_Dueño";
            this.BtnE_Dueño.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Dueño.TabIndex = 3;
            this.BtnE_Dueño.Text = "Confirmar";
            this.BtnE_Dueño.UseVisualStyleBackColor = false;
            this.BtnE_Dueño.Click += new System.EventHandler(this.BtnE_Dueño_Click);
            // 
            // BtnE_Cancelar
            // 
            this.BtnE_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Cancelar.Location = new System.Drawing.Point(175, 112);
            this.BtnE_Cancelar.Name = "BtnE_Cancelar";
            this.BtnE_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Cancelar.TabIndex = 4;
            this.BtnE_Cancelar.Text = "Cancelar";
            this.BtnE_Cancelar.UseVisualStyleBackColor = false;
            this.BtnE_Cancelar.Click += new System.EventHandler(this.BtnE_Cancelar_Click);
            // 
            // Frm_Eliminar_Dueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 186);
            this.Controls.Add(this.LblE_Confirmar_Operacion);
            this.Controls.Add(this.BtnE_Cancelar);
            this.Controls.Add(this.BtnE_Dueño);
            this.Name = "Frm_Eliminar_Dueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar dueño";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblE_Confirmar_Operacion;
        private System.Windows.Forms.Button BtnE_Dueño;
        private System.Windows.Forms.Button BtnE_Cancelar;
    }
}