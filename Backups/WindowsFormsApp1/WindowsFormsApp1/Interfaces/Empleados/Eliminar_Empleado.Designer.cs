
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
            this.BtnE_Cancelar = new System.Windows.Forms.Button();
            this.LblE_Confirmar_Operacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnE_Empleado
            // 
            this.BtnE_Empleado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Empleado.Location = new System.Drawing.Point(23, 117);
            this.BtnE_Empleado.Name = "BtnE_Empleado";
            this.BtnE_Empleado.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Empleado.TabIndex = 0;
            this.BtnE_Empleado.Text = "Confirmar";
            this.BtnE_Empleado.UseVisualStyleBackColor = false;
            this.BtnE_Empleado.Click += new System.EventHandler(this.BtnE_Empleado_Click);
            // 
            // BtnE_Cancelar
            // 
            this.BtnE_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnE_Cancelar.Location = new System.Drawing.Point(174, 117);
            this.BtnE_Cancelar.Name = "BtnE_Cancelar";
            this.BtnE_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnE_Cancelar.TabIndex = 1;
            this.BtnE_Cancelar.Text = "Cancelar";
            this.BtnE_Cancelar.UseVisualStyleBackColor = false;
            this.BtnE_Cancelar.Click += new System.EventHandler(this.BtnE_Cancelar_Click);
            // 
            // LblE_Confirmar_Operacion
            // 
            this.LblE_Confirmar_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_Confirmar_Operacion.Location = new System.Drawing.Point(62, 36);
            this.LblE_Confirmar_Operacion.Name = "LblE_Confirmar_Operacion";
            this.LblE_Confirmar_Operacion.Size = new System.Drawing.Size(203, 56);
            this.LblE_Confirmar_Operacion.TabIndex = 2;
            this.LblE_Confirmar_Operacion.Text = "¿Desea confirmar la operación?";
            this.LblE_Confirmar_Operacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblE_Confirmar_Operacion.Click += new System.EventHandler(this.LblE_Confirmar_Operacion_Click);
            // 
            // Eliminar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 186);
            this.Controls.Add(this.LblE_Confirmar_Operacion);
            this.Controls.Add(this.BtnE_Cancelar);
            this.Controls.Add(this.BtnE_Empleado);
            this.Name = "Eliminar_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar empleado";
            this.Load += new System.EventHandler(this.Eliminar_Empleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnE_Empleado;
        private System.Windows.Forms.Button BtnE_Cancelar;
        private System.Windows.Forms.Label LblE_Confirmar_Operacion;
    }
}