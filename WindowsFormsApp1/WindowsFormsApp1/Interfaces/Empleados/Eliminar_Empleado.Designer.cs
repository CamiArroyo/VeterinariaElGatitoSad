
namespace WindowsFormsApp1.Interfaces.Empleados
{
    partial class Eliminar_Empleado
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
            this.BtnE_Empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnE_Empleado
            // 
            this.BtnE_Empleado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Empleado.Location = new System.Drawing.Point(41, 40);
            this.BtnE_Empleado.Name = "BtnE_Empleado";
            this.BtnE_Empleado.Size = new System.Drawing.Size(171, 80);
            this.BtnE_Empleado.TabIndex = 0;
            this.BtnE_Empleado.Text = "Confirmar";
            this.BtnE_Empleado.UseVisualStyleBackColor = false;
            this.BtnE_Empleado.Click += new System.EventHandler(this.BtnE_Empleado_Click);
            // 
            // Eliminar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(249, 155);
            this.Controls.Add(this.BtnE_Empleado);
            this.Name = "Eliminar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_Empleado";
            this.Load += new System.EventHandler(this.Eliminar_Empleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnE_Empleado;
    }
}