
namespace WindowsFormsApp1.Interfaces.Sintomas
{
    partial class Frm_Registrar_Sintoma
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
            this.Txt_Registrar_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Registrar_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Registrar_Nombre
            // 
            this.Txt_Registrar_Nombre.Location = new System.Drawing.Point(31, 109);
            this.Txt_Registrar_Nombre.Name = "Txt_Registrar_Nombre";
            this.Txt_Registrar_Nombre.Size = new System.Drawing.Size(163, 20);
            this.Txt_Registrar_Nombre.TabIndex = 0;
            // 
            // Txt_Registrar_Descripcion
            // 
            this.Txt_Registrar_Descripcion.Location = new System.Drawing.Point(221, 109);
            this.Txt_Registrar_Descripcion.Multiline = true;
            this.Txt_Registrar_Descripcion.Name = "Txt_Registrar_Descripcion";
            this.Txt_Registrar_Descripcion.Size = new System.Drawing.Size(414, 254);
            this.Txt_Registrar_Descripcion.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 90);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(221, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion del sintoma";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Sintomas;
            this.pictureBox1.Location = new System.Drawing.Point(34, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Registrar_Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.Txt_Registrar_Descripcion);
            this.Controls.Add(this.Txt_Registrar_Nombre);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Frm_Registrar_Sintoma";
            this.Text = "Nuevo Sintoma";
            this.Load += new System.EventHandler(this.Registrar_Sintoma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Registrar_Nombre;
        private System.Windows.Forms.TextBox Txt_Registrar_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}