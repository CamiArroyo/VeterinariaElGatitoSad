
namespace WindowsFormsApp1.Interfaces.Especies
{
    partial class Frm_Modificar_Especie
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
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Cuidados = new System.Windows.Forms.TextBox();
            this.Lbl_Cuidados = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(176, 148);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Cancelar.TabIndex = 15;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(46, 148);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Registrar.TabIndex = 14;
            this.Btn_Registrar.Text = "Modificar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(167, 71);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(135, 20);
            this.Txt_Descripcion.TabIndex = 13;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(32, 74);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Lbl_Descripcion.TabIndex = 12;
            this.Lbl_Descripcion.Text = "Descripcion:";
            // 
            // Txt_Cuidados
            // 
            this.Txt_Cuidados.Location = new System.Drawing.Point(167, 107);
            this.Txt_Cuidados.Name = "Txt_Cuidados";
            this.Txt_Cuidados.Size = new System.Drawing.Size(135, 20);
            this.Txt_Cuidados.TabIndex = 11;
            // 
            // Lbl_Cuidados
            // 
            this.Lbl_Cuidados.AutoSize = true;
            this.Lbl_Cuidados.Location = new System.Drawing.Point(32, 110);
            this.Lbl_Cuidados.Name = "Lbl_Cuidados";
            this.Lbl_Cuidados.Size = new System.Drawing.Size(107, 13);
            this.Lbl_Cuidados.TabIndex = 10;
            this.Lbl_Cuidados.Text = "Cuidados especiales:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(167, 34);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(135, 20);
            this.Txt_Nombre.TabIndex = 9;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(32, 37);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(113, 13);
            this.Lbl_Nombre.TabIndex = 8;
            this.Lbl_Nombre.Text = "Nombre de la especie:";
            // 
            // Frm_Modificar_Especie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(336, 223);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Txt_Cuidados);
            this.Controls.Add(this.Lbl_Cuidados);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Nombre);
            this.Name = "Frm_Modificar_Especie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar especie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.TextBox Txt_Cuidados;
        private System.Windows.Forms.Label Lbl_Cuidados;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Nombre;
    }
}