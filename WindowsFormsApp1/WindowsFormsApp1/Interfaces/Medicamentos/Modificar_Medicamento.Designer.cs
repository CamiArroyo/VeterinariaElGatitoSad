
namespace WindowsFormsApp1.Interfaces.Medicamentos
{
    partial class Frm_Modificar_Medicamento
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
            this.Txt_Cantidad_Stock = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Id_Lab = new System.Windows.Forms.ComboBox();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.Btm_Guardar_Cambios = new System.Windows.Forms.Button();
            this.Btm_Cancelar = new System.Windows.Forms.Button();
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del medicamento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción del medicamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de última compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad en stock:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(165, 48);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(156, 20);
            this.Txt_Nombre.TabIndex = 5;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // Txt_Cantidad_Stock
            // 
            this.Txt_Cantidad_Stock.Location = new System.Drawing.Point(479, 199);
            this.Txt_Cantidad_Stock.Name = "Txt_Cantidad_Stock";
            this.Txt_Cantidad_Stock.Size = new System.Drawing.Size(184, 20);
            this.Txt_Cantidad_Stock.TabIndex = 7;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(479, 153);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(184, 20);
            this.Dtp_Fecha.TabIndex = 8;
            // 
            // Cmb_Id_Lab
            // 
            this.Cmb_Id_Lab.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lABORATORIOSBindingSource, "id_laboratorio", true));
            this.Cmb_Id_Lab.DataSource = this.lABORATORIOSBindingSource;
            this.Cmb_Id_Lab.DisplayMember = "id_laboratorio";
            this.Cmb_Id_Lab.FormattingEnabled = true;
            this.Cmb_Id_Lab.Location = new System.Drawing.Point(479, 105);
            this.Cmb_Id_Lab.Name = "Cmb_Id_Lab";
            this.Cmb_Id_Lab.Size = new System.Drawing.Size(184, 21);
            this.Cmb_Id_Lab.TabIndex = 9;
            this.Cmb_Id_Lab.ValueMember = "id_laboratorio";
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
            // Btm_Guardar_Cambios
            // 
            this.Btm_Guardar_Cambios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Guardar_Cambios.Location = new System.Drawing.Point(388, 320);
            this.Btm_Guardar_Cambios.Name = "Btm_Guardar_Cambios";
            this.Btm_Guardar_Cambios.Size = new System.Drawing.Size(125, 40);
            this.Btm_Guardar_Cambios.TabIndex = 10;
            this.Btm_Guardar_Cambios.Text = "Modificar";
            this.Btm_Guardar_Cambios.UseVisualStyleBackColor = false;
            this.Btm_Guardar_Cambios.Click += new System.EventHandler(this.Btm_Guardar_Cambios_Click);
            // 
            // Btm_Cancelar
            // 
            this.Btm_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Cancelar.Location = new System.Drawing.Point(538, 320);
            this.Btm_Cancelar.Name = "Btm_Cancelar";
            this.Btm_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Cancelar.TabIndex = 11;
            this.Btm_Cancelar.Text = "Cancelar";
            this.Btm_Cancelar.UseVisualStyleBackColor = false;
            this.Btm_Cancelar.Click += new System.EventHandler(this.Btm_Cancelar_Click);
            // 
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(21, 142);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(300, 154);
            this.Txt_Descripcion.TabIndex = 59;
            // 
            // Frm_Modificar_Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Btm_Cancelar);
            this.Controls.Add(this.Btm_Guardar_Cambios);
            this.Controls.Add(this.Cmb_Id_Lab);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Txt_Cantidad_Stock);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Medicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar medicamento";
            this.Load += new System.EventHandler(this.Frm_Modificar_Medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_Cantidad_Stock;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.ComboBox Cmb_Id_Lab;
        private System.Windows.Forms.Button Btm_Guardar_Cambios;
        private System.Windows.Forms.Button Btm_Cancelar;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
        private System.Windows.Forms.TextBox Txt_Descripcion;
    }
}