﻿
namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    partial class Frm_Registrar_Medicamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad_Stock = new System.Windows.Forms.TextBox();
            this.Cb_Id_lab = new System.Windows.Forms.ComboBox();
            this.Date_Fecha_ultimaCompra = new System.Windows.Forms.DateTimePicker();
            this.Btm_Cerrar = new System.Windows.Forms.Button();
            this.Btm_Registrar = new System.Windows.Forms.Button();
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id_Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha última compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad en stock";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(156, 41);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(197, 20);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(156, 70);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(197, 20);
            this.Txt_Descripcion.TabIndex = 6;
            // 
            // Txt_Cantidad_Stock
            // 
            this.Txt_Cantidad_Stock.Location = new System.Drawing.Point(156, 148);
            this.Txt_Cantidad_Stock.Name = "Txt_Cantidad_Stock";
            this.Txt_Cantidad_Stock.Size = new System.Drawing.Size(197, 20);
            this.Txt_Cantidad_Stock.TabIndex = 8;
            // 
            // Cb_Id_lab
            // 
            this.Cb_Id_lab.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lABORATORIOSBindingSource, "id_laboratorio", true));
            this.Cb_Id_lab.DataSource = this.lABORATORIOSBindingSource;
            this.Cb_Id_lab.DisplayMember = "id_laboratorio";
            this.Cb_Id_lab.FormattingEnabled = true;
            this.Cb_Id_lab.Location = new System.Drawing.Point(156, 97);
            this.Cb_Id_lab.Name = "Cb_Id_lab";
            this.Cb_Id_lab.Size = new System.Drawing.Size(197, 21);
            this.Cb_Id_lab.TabIndex = 9;
            this.Cb_Id_lab.ValueMember = "id_laboratorio";
            // 
            // Date_Fecha_ultimaCompra
            // 
            this.Date_Fecha_ultimaCompra.Location = new System.Drawing.Point(156, 122);
            this.Date_Fecha_ultimaCompra.Name = "Date_Fecha_ultimaCompra";
            this.Date_Fecha_ultimaCompra.Size = new System.Drawing.Size(197, 20);
            this.Date_Fecha_ultimaCompra.TabIndex = 10;
            // 
            // Btm_Cerrar
            // 
            this.Btm_Cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Cerrar.Location = new System.Drawing.Point(268, 236);
            this.Btm_Cerrar.Name = "Btm_Cerrar";
            this.Btm_Cerrar.Size = new System.Drawing.Size(85, 44);
            this.Btm_Cerrar.TabIndex = 15;
            this.Btm_Cerrar.Text = "Cerrar";
            this.Btm_Cerrar.UseVisualStyleBackColor = false;
            this.Btm_Cerrar.Click += new System.EventHandler(this.Btm_Cerrar_Click);
            // 
            // Btm_Registrar
            // 
            this.Btm_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Registrar.Location = new System.Drawing.Point(156, 236);
            this.Btm_Registrar.Name = "Btm_Registrar";
            this.Btm_Registrar.Size = new System.Drawing.Size(85, 44);
            this.Btm_Registrar.TabIndex = 14;
            this.Btm_Registrar.Text = "Registrar";
            this.Btm_Registrar.UseVisualStyleBackColor = false;
            this.Btm_Registrar.Click += new System.EventHandler(this.Btm_Registrar_Click);
            // 
            // _PAV_3K2_2021_12DataSet
            // 
            this._PAV_3K2_2021_12DataSet.DataSetName = "_PAV_3K2_2021_12DataSet";
            this._PAV_3K2_2021_12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lABORATORIOSBindingSource
            // 
            this.lABORATORIOSBindingSource.DataMember = "LABORATORIOS";
            this.lABORATORIOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet;
            // 
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Registrar_Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(366, 301);
            this.Controls.Add(this.Btm_Cerrar);
            this.Controls.Add(this.Btm_Registrar);
            this.Controls.Add(this.Date_Fecha_ultimaCompra);
            this.Controls.Add(this.Cb_Id_lab);
            this.Controls.Add(this.Txt_Cantidad_Stock);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Medicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar medicamento";
            this.Load += new System.EventHandler(this.Frm_Registrar_Medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Cantidad_Stock;
        private System.Windows.Forms.ComboBox Cb_Id_lab;
        private System.Windows.Forms.DateTimePicker Date_Fecha_ultimaCompra;
        private System.Windows.Forms.Button Btm_Cerrar;
        private System.Windows.Forms.Button Btm_Registrar;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
    }
}