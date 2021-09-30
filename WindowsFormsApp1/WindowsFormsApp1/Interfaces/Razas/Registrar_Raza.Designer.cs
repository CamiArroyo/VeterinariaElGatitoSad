
namespace WindowsFormsApp1.Interfaces.Razas
{
    partial class Frm_Registrar_Raza
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
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Peso_Medio = new System.Windows.Forms.Label();
            this.Txt_Peso_Medio = new System.Windows.Forms.TextBox();
            this.Lbl_Altura_Media = new System.Windows.Forms.Label();
            this.Txt_Altura_Media = new System.Windows.Forms.TextBox();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(154, 30);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(140, 20);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(30, 33);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Nombre.TabIndex = 1;
            this.Lbl_Nombre.Text = "Nombre de la raza:";
            this.Lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(30, 68);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripción:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(154, 65);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(140, 20);
            this.Txt_Descripcion.TabIndex = 2;
            // 
            // Lbl_Peso_Medio
            // 
            this.Lbl_Peso_Medio.AutoSize = true;
            this.Lbl_Peso_Medio.Location = new System.Drawing.Point(30, 103);
            this.Lbl_Peso_Medio.Name = "Lbl_Peso_Medio";
            this.Lbl_Peso_Medio.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Peso_Medio.TabIndex = 5;
            this.Lbl_Peso_Medio.Text = "Peso medio:";
            // 
            // Txt_Peso_Medio
            // 
            this.Txt_Peso_Medio.Location = new System.Drawing.Point(154, 100);
            this.Txt_Peso_Medio.Name = "Txt_Peso_Medio";
            this.Txt_Peso_Medio.Size = new System.Drawing.Size(140, 20);
            this.Txt_Peso_Medio.TabIndex = 4;
            // 
            // Lbl_Altura_Media
            // 
            this.Lbl_Altura_Media.AutoSize = true;
            this.Lbl_Altura_Media.Location = new System.Drawing.Point(30, 139);
            this.Lbl_Altura_Media.Name = "Lbl_Altura_Media";
            this.Lbl_Altura_Media.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Altura_Media.TabIndex = 7;
            this.Lbl_Altura_Media.Text = "Altura media:";
            // 
            // Txt_Altura_Media
            // 
            this.Txt_Altura_Media.Location = new System.Drawing.Point(154, 136);
            this.Txt_Altura_Media.Name = "Txt_Altura_Media";
            this.Txt_Altura_Media.Size = new System.Drawing.Size(140, 20);
            this.Txt_Altura_Media.TabIndex = 6;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(51, 178);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrar.TabIndex = 8;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(173, 178);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_Registrar_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(330, 235);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Lbl_Altura_Media);
            this.Controls.Add(this.Txt_Altura_Media);
            this.Controls.Add(this.Lbl_Peso_Medio);
            this.Controls.Add(this.Txt_Peso_Medio);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "Frm_Registrar_Raza";
            this.Text = "Registrar razas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Peso_Medio;
        private System.Windows.Forms.TextBox Txt_Peso_Medio;
        private System.Windows.Forms.Label Lbl_Altura_Media;
        private System.Windows.Forms.TextBox Txt_Altura_Media;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}