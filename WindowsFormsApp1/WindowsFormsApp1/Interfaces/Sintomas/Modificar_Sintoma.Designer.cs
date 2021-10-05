
namespace WindowsFormsApp1.Interfaces.Sintomas
{
    partial class Frm_Modificar_Sintoma
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
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnM_Cancelar = new System.Windows.Forms.Button();
            this.BtnM_Guardar_Cambios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre del síntoma:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(30, 60);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(160, 20);
            this.Txt_Nombre.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Descripción del síntoma:";
            // 
            // BtnM_Cancelar
            // 
            this.BtnM_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Cancelar.Location = new System.Drawing.Point(514, 328);
            this.BtnM_Cancelar.Name = "BtnM_Cancelar";
            this.BtnM_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Cancelar.TabIndex = 50;
            this.BtnM_Cancelar.Text = "Cancelar";
            this.BtnM_Cancelar.UseVisualStyleBackColor = false;
            this.BtnM_Cancelar.Click += new System.EventHandler(this.BtnM_Cancelar_Click);
            // 
            // BtnM_Guardar_Cambios
            // 
            this.BtnM_Guardar_Cambios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Guardar_Cambios.Location = new System.Drawing.Point(358, 328);
            this.BtnM_Guardar_Cambios.Name = "BtnM_Guardar_Cambios";
            this.BtnM_Guardar_Cambios.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Guardar_Cambios.TabIndex = 49;
            this.BtnM_Guardar_Cambios.Text = "Modificar";
            this.BtnM_Guardar_Cambios.UseVisualStyleBackColor = false;
            this.BtnM_Guardar_Cambios.Click += new System.EventHandler(this.BtnM_Guardar_Cambios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Sintomas;
            this.pictureBox1.Location = new System.Drawing.Point(30, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(243, 60);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(414, 254);
            this.Txt_Descripcion.TabIndex = 52;
            // 
            // Frm_Modificar_Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnM_Cancelar);
            this.Controls.Add(this.BtnM_Guardar_Cambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Sintoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar síntoma";
            this.Load += new System.EventHandler(this.Frm_Modificar_Sintoma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnM_Cancelar;
        private System.Windows.Forms.Button BtnM_Guardar_Cambios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Descripcion;
    }
}