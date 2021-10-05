
namespace WindowsFormsApp1.Interfaces.Dueños
{
    partial class Frm_Modificar_Dueño
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnM_Cancelar = new System.Windows.Forms.Button();
            this.BtnM_Guardar_Cambios = new System.Windows.Forms.Button();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.Cb_Estado_Dueño = new System.Windows.Forms.ComboBox();
            this.dUEÑOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12Dueños = new WindowsFormsApp1._PAV_3K2_2021_12Dueños();
            this.label4 = new System.Windows.Forms.Label();
            this.dUEÑOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Teléfono:";
            // 
            // BtnM_Cancelar
            // 
            this.BtnM_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Cancelar.Location = new System.Drawing.Point(180, 225);
            this.BtnM_Cancelar.Name = "BtnM_Cancelar";
            this.BtnM_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Cancelar.TabIndex = 64;
            this.BtnM_Cancelar.Text = "Cancelar";
            this.BtnM_Cancelar.UseVisualStyleBackColor = false;
            this.BtnM_Cancelar.Click += new System.EventHandler(this.BtnM_Cancelar_Click);
            // 
            // BtnM_Guardar_Cambios
            // 
            this.BtnM_Guardar_Cambios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Guardar_Cambios.Location = new System.Drawing.Point(39, 225);
            this.BtnM_Guardar_Cambios.Name = "BtnM_Guardar_Cambios";
            this.BtnM_Guardar_Cambios.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Guardar_Cambios.TabIndex = 63;
            this.BtnM_Guardar_Cambios.Text = "Modificar";
            this.BtnM_Guardar_Cambios.UseVisualStyleBackColor = false;
            this.BtnM_Guardar_Cambios.Click += new System.EventHandler(this.BtnM_Guardar_Cambios_Click);
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(109, 80);
            this.Txt_Apellido.MaxLength = 50;
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(196, 20);
            this.Txt_Apellido.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(108, 32);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(196, 20);
            this.Txt_Nombre.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Apellido:";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(109, 127);
            this.Txt_Telefono.MaxLength = 50;
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(196, 20);
            this.Txt_Telefono.TabIndex = 67;
            // 
            // Cb_Estado_Dueño
            // 
            this.Cb_Estado_Dueño.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dUEÑOSBindingSource, "estado", true));
            this.Cb_Estado_Dueño.FormattingEnabled = true;
            this.Cb_Estado_Dueño.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cb_Estado_Dueño.Location = new System.Drawing.Point(109, 175);
            this.Cb_Estado_Dueño.Name = "Cb_Estado_Dueño";
            this.Cb_Estado_Dueño.Size = new System.Drawing.Size(196, 21);
            this.Cb_Estado_Dueño.TabIndex = 68;
            // 
            // dUEÑOSBindingSource
            // 
            this.dUEÑOSBindingSource.DataMember = "DUEÑOS";
            this.dUEÑOSBindingSource.DataSource = this._PAV_3K2_2021_12Dueños;
            // 
            // _PAV_3K2_2021_12Dueños
            // 
            this._PAV_3K2_2021_12Dueños.DataSetName = "_PAV_3K2_2021_12Dueños";
            this._PAV_3K2_2021_12Dueños.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Estado:";
            // 
            // dUEÑOSTableAdapter
            // 
            this.dUEÑOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Modificar_Dueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cb_Estado_Dueño);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnM_Cancelar);
            this.Controls.Add(this.BtnM_Guardar_Cambios);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Dueño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar dueño";
            this.Load += new System.EventHandler(this.Frm_Modificar_Dueño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnM_Cancelar;
        private System.Windows.Forms.Button BtnM_Guardar_Cambios;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.ComboBox Cb_Estado_Dueño;
        private System.Windows.Forms.Label label4;
        private _PAV_3K2_2021_12Dueños _PAV_3K2_2021_12Dueños;
        private System.Windows.Forms.BindingSource dUEÑOSBindingSource;
        private _PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter dUEÑOSTableAdapter;
    }
}