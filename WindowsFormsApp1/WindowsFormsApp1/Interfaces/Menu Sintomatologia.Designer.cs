
namespace WindowsFormsApp1.Interfaces
{
    partial class Fmr_Menu_Sintomatologia
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
            this.Lbl_Diagnostico = new System.Windows.Forms.Label();
            this.Lbl_Sintomas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Registar_Diagnostico = new System.Windows.Forms.Button();
            this.Btn_Consultar_Diagnostico = new System.Windows.Forms.Button();
            this.Btn_Registrar_Sintoma = new System.Windows.Forms.Button();
            this.Btn_Consultar_Sintoma = new System.Windows.Forms.Button();
            this.Btn_Sintomatologia_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Diagnostico
            // 
            this.Lbl_Diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Diagnostico.Location = new System.Drawing.Point(12, 78);
            this.Lbl_Diagnostico.Name = "Lbl_Diagnostico";
            this.Lbl_Diagnostico.Size = new System.Drawing.Size(107, 32);
            this.Lbl_Diagnostico.TabIndex = 0;
            this.Lbl_Diagnostico.Text = "Diagnostico";
            // 
            // Lbl_Sintomas
            // 
            this.Lbl_Sintomas.AutoSize = true;
            this.Lbl_Sintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sintomas.Location = new System.Drawing.Point(190, 78);
            this.Lbl_Sintomas.Name = "Lbl_Sintomas";
            this.Lbl_Sintomas.Size = new System.Drawing.Size(84, 20);
            this.Lbl_Sintomas.TabIndex = 1;
            this.Lbl_Sintomas.Text = "Sintomas";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una opción";
            // 
            // Btn_Registar_Diagnostico
            // 
            this.Btn_Registar_Diagnostico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registar_Diagnostico.Location = new System.Drawing.Point(12, 123);
            this.Btn_Registar_Diagnostico.Name = "Btn_Registar_Diagnostico";
            this.Btn_Registar_Diagnostico.Size = new System.Drawing.Size(120, 37);
            this.Btn_Registar_Diagnostico.TabIndex = 3;
            this.Btn_Registar_Diagnostico.Text = "Registrar diagnostico";
            this.Btn_Registar_Diagnostico.UseVisualStyleBackColor = false;
            this.Btn_Registar_Diagnostico.Click += new System.EventHandler(this.Btn_Registar_Diagnostico_Click);
            // 
            // Btn_Consultar_Diagnostico
            // 
            this.Btn_Consultar_Diagnostico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Diagnostico.Location = new System.Drawing.Point(12, 183);
            this.Btn_Consultar_Diagnostico.Name = "Btn_Consultar_Diagnostico";
            this.Btn_Consultar_Diagnostico.Size = new System.Drawing.Size(120, 37);
            this.Btn_Consultar_Diagnostico.TabIndex = 4;
            this.Btn_Consultar_Diagnostico.Text = "Consultar diagnostico";
            this.Btn_Consultar_Diagnostico.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Diagnostico.Click += new System.EventHandler(this.Btn_Consultar_Diagnostico_Click);
            // 
            // Btn_Registrar_Sintoma
            // 
            this.Btn_Registrar_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Sintoma.Location = new System.Drawing.Point(194, 123);
            this.Btn_Registrar_Sintoma.Name = "Btn_Registrar_Sintoma";
            this.Btn_Registrar_Sintoma.Size = new System.Drawing.Size(120, 37);
            this.Btn_Registrar_Sintoma.TabIndex = 7;
            this.Btn_Registrar_Sintoma.Text = "Registar sintoma";
            this.Btn_Registrar_Sintoma.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Sintoma.Click += new System.EventHandler(this.Btn_Registrar_Sintoma_Click);
            // 
            // Btn_Consultar_Sintoma
            // 
            this.Btn_Consultar_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Consultar_Sintoma.Location = new System.Drawing.Point(194, 183);
            this.Btn_Consultar_Sintoma.Name = "Btn_Consultar_Sintoma";
            this.Btn_Consultar_Sintoma.Size = new System.Drawing.Size(120, 37);
            this.Btn_Consultar_Sintoma.TabIndex = 8;
            this.Btn_Consultar_Sintoma.Text = "Consultar sintoma";
            this.Btn_Consultar_Sintoma.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Sintoma.Click += new System.EventHandler(this.Btn_Consultar_Sintoma_Click);
            // 
            // Btn_Sintomatologia_Salir
            // 
            this.Btn_Sintomatologia_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Sintomatologia_Salir.Location = new System.Drawing.Point(105, 252);
            this.Btn_Sintomatologia_Salir.Name = "Btn_Sintomatologia_Salir";
            this.Btn_Sintomatologia_Salir.Size = new System.Drawing.Size(103, 37);
            this.Btn_Sintomatologia_Salir.TabIndex = 11;
            this.Btn_Sintomatologia_Salir.Text = "Salir";
            this.Btn_Sintomatologia_Salir.UseVisualStyleBackColor = false;
            this.Btn_Sintomatologia_Salir.Click += new System.EventHandler(this.Btn_Sintomatologia_Salir_Click);
            // 
            // Fmr_Menu_Sintomatologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(324, 301);
            this.Controls.Add(this.Btn_Sintomatologia_Salir);
            this.Controls.Add(this.Btn_Consultar_Sintoma);
            this.Controls.Add(this.Btn_Registrar_Sintoma);
            this.Controls.Add(this.Btn_Consultar_Diagnostico);
            this.Controls.Add(this.Btn_Registar_Diagnostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Sintomas);
            this.Controls.Add(this.Lbl_Diagnostico);
            this.Name = "Fmr_Menu_Sintomatologia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Sintomatologia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Diagnostico;
        private System.Windows.Forms.Label Lbl_Sintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Registar_Diagnostico;
        private System.Windows.Forms.Button Btn_Consultar_Diagnostico;
        private System.Windows.Forms.Button Btn_Registrar_Sintoma;
        private System.Windows.Forms.Button Btn_Consultar_Sintoma;
        private System.Windows.Forms.Button Btn_Sintomatologia_Salir;
    }
}