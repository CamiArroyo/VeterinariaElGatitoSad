
namespace WindowsFormsApp1.Interfaces.Mascotas
{
    partial class Frm_Modificar_Mascota
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
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Btm_Guardar = new System.Windows.Forms.Button();
            this.Btm_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(160, 33);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nombre.TabIndex = 4;
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(160, 75);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Peso.TabIndex = 5;
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(160, 116);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(200, 20);
            this.Txt_Altura.TabIndex = 6;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cmb_Estado.Location = new System.Drawing.Point(160, 160);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Estado.TabIndex = 7;
            // 
            // Btm_Guardar
            // 
            this.Btm_Guardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Guardar.Location = new System.Drawing.Point(55, 212);
            this.Btm_Guardar.Name = "Btm_Guardar";
            this.Btm_Guardar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Guardar.TabIndex = 8;
            this.Btm_Guardar.Text = "Modificar";
            this.Btm_Guardar.UseVisualStyleBackColor = false;
            this.Btm_Guardar.Click += new System.EventHandler(this.Btm_Guardar_Click);
            // 
            // Btm_Cancelar
            // 
            this.Btm_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Cancelar.Location = new System.Drawing.Point(205, 212);
            this.Btm_Cancelar.Name = "Btm_Cancelar";
            this.Btm_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Cancelar.TabIndex = 9;
            this.Btm_Cancelar.Text = "Cancelar";
            this.Btm_Cancelar.UseVisualStyleBackColor = false;
            this.Btm_Cancelar.Click += new System.EventHandler(this.Btm_Cancelar_Click);
            // 
            // Frm_Modificar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.Btm_Cancelar);
            this.Controls.Add(this.Btm_Guardar);
            this.Controls.Add(this.Cmb_Estado);
            this.Controls.Add(this.Txt_Altura);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar mascota";
            this.Load += new System.EventHandler(this.Frm_Modificar_Mascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Button Btm_Guardar;
        private System.Windows.Forms.Button Btm_Cancelar;
    }
}