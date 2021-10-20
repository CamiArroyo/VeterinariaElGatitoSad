
namespace WindowsFormsApp1.Interfaces.Vacs
{
    partial class Frm_Modificar_Vacuna
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
            this.BtnM_Cancelar = new System.Windows.Forms.Button();
            this.BtnM_Guardar_Cambios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Id_Laboratorio = new System.Windows.Forms.ComboBox();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnM_Cancelar
            // 
            this.BtnM_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Cancelar.Location = new System.Drawing.Point(476, 280);
            this.BtnM_Cancelar.Name = "BtnM_Cancelar";
            this.BtnM_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Cancelar.TabIndex = 56;
            this.BtnM_Cancelar.Text = "Cancelar";
            this.BtnM_Cancelar.UseVisualStyleBackColor = false;
            this.BtnM_Cancelar.Click += new System.EventHandler(this.BtnM_Cancelar_Click);
            // 
            // BtnM_Guardar_Cambios
            // 
            this.BtnM_Guardar_Cambios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnM_Guardar_Cambios.Location = new System.Drawing.Point(325, 280);
            this.BtnM_Guardar_Cambios.Name = "BtnM_Guardar_Cambios";
            this.BtnM_Guardar_Cambios.Size = new System.Drawing.Size(125, 40);
            this.BtnM_Guardar_Cambios.TabIndex = 55;
            this.BtnM_Guardar_Cambios.Text = "Modificar";
            this.BtnM_Guardar_Cambios.UseVisualStyleBackColor = false;
            this.BtnM_Guardar_Cambios.Click += new System.EventHandler(this.BtnM_Guardar_Cambios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre de la vacuna:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(154, 48);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(165, 20);
            this.Txt_Nombre.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Descripción de la vacuna:";
            // 
            // Cb_Id_Laboratorio
            // 
            this.Cb_Id_Laboratorio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lABORATORIOSBindingSource, "id_laboratorio", true));
            this.Cb_Id_Laboratorio.DataSource = this.lABORATORIOSBindingSource;
            this.Cb_Id_Laboratorio.DisplayMember = "id_laboratorio";
            this.Cb_Id_Laboratorio.FormattingEnabled = true;
            this.Cb_Id_Laboratorio.Location = new System.Drawing.Point(436, 47);
            this.Cb_Id_Laboratorio.Name = "Cb_Id_Laboratorio";
            this.Cb_Id_Laboratorio.Size = new System.Drawing.Size(165, 21);
            this.Cb_Id_Laboratorio.TabIndex = 57;
            this.Cb_Id_Laboratorio.ValueMember = "id_laboratorio";
            // 
            // lABORATORIOSBindingSource
            // 
            this.lABORATORIOSBindingSource.DataMember = "LABORATORIOS";
            this.lABORATORIOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet;
            // 
            // _PAV_3K2_2021_12DataSet
            // 
            this._PAV_3K2_2021_12DataSet.DataSetName = "_PAV_3K2_2021_12DataSet";
            this._PAV_3K2_2021_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID laboratorio:";
            // 
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(29, 138);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(572, 115);
            this.Txt_Descripcion.TabIndex = 60;
            // 
            // Frm_Modificar_Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Id_Laboratorio);
            this.Controls.Add(this.BtnM_Cancelar);
            this.Controls.Add(this.BtnM_Guardar_Cambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar vacuna";
            this.Load += new System.EventHandler(this.Frm_Modificar_Vacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnM_Cancelar;
        private System.Windows.Forms.Button BtnM_Guardar_Cambios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Id_Laboratorio;
        private System.Windows.Forms.Label label2;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
        private System.Windows.Forms.TextBox Txt_Descripcion;
    }
}