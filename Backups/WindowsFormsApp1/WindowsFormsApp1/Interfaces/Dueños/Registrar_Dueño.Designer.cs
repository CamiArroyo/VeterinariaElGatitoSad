
namespace WindowsFormsApp1.Interfaces.Dueños
{
    partial class Frm_Registrar_Dueños
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(138, 27);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(210, 20);
            this.Txt_Nombre.TabIndex = 3;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(138, 55);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(210, 20);
            this.Txt_Apellido.TabIndex = 4;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(138, 82);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(210, 20);
            this.Txt_Telefono.TabIndex = 5;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(273, 160);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 37);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Confirmar.Location = new System.Drawing.Point(138, 160);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 37);
            this.Btn_Confirmar.TabIndex = 7;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Frm_Registrar_Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(360, 209);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar dueños";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Confirmar;
    }
}