
namespace WindowsFormsApp1.Interfaces
{
    partial class FrmIniciar_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciar_sesion));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Usuario = new System.Windows.Forms.TextBox();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Ingresar.Location = new System.Drawing.Point(129, 303);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 34);
            this.btn_Ingresar.TabIndex = 0;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(235, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtbox_Usuario
            // 
            this.txtbox_Usuario.Location = new System.Drawing.Point(129, 217);
            this.txtbox_Usuario.MaxLength = 50;
            this.txtbox_Usuario.Name = "txtbox_Usuario";
            this.txtbox_Usuario.Size = new System.Drawing.Size(181, 20);
            this.txtbox_Usuario.TabIndex = 4;
            this.txtbox_Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Location = new System.Drawing.Point(129, 262);
            this.txtbox_Password.MaxLength = 50;
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.PasswordChar = '*';
            this.txtbox_Password.Size = new System.Drawing.Size(181, 20);
            this.txtbox_Password.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIniciar_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(432, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_Password);
            this.Controls.Add(this.txtbox_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Ingresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIniciar_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar_sesion";
            this.Load += new System.EventHandler(this.FrmIniciar_sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.TextBox txtbox_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}