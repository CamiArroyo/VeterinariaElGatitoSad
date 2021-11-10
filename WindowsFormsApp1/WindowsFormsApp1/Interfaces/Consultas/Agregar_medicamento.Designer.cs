
namespace WindowsFormsApp1.Interfaces.Consultas
{
    partial class Frm_Agregar_Medicamento
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
            this.Btn_Agregar_Medicamento = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Cb_Agregar_medicamento = new System.Windows.Forms.ComboBox();
            this.mEDICAMENTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentos = new WindowsFormsApp1.Medicamentos();
            this.Txt_Dosis = new System.Windows.Forms.TextBox();
            this.Txt_Periodicidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mEDICAMENTOSTableAdapter = new WindowsFormsApp1.MedicamentosTableAdapters.MEDICAMENTOSTableAdapter();
            this._PAV_3K2_2021_12DataSetAgregarMedicamentos = new WindowsFormsApp1._PAV_3K2_2021_12DataSetAgregarMedicamentos();
            this.mEDICAMENTOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAMENTOSTableAdapter1 = new WindowsFormsApp1._PAV_3K2_2021_12DataSetAgregarMedicamentosTableAdapters.MEDICAMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSetAgregarMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Agregar_Medicamento
            // 
            this.Btn_Agregar_Medicamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Agregar_Medicamento.Location = new System.Drawing.Point(225, 130);
            this.Btn_Agregar_Medicamento.Name = "Btn_Agregar_Medicamento";
            this.Btn_Agregar_Medicamento.Size = new System.Drawing.Size(85, 50);
            this.Btn_Agregar_Medicamento.TabIndex = 0;
            this.Btn_Agregar_Medicamento.Text = "Agregar";
            this.Btn_Agregar_Medicamento.UseVisualStyleBackColor = false;
            this.Btn_Agregar_Medicamento.Click += new System.EventHandler(this.Btn_Agregar_Medicamento_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(322, 130);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(85, 50);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Cb_Agregar_medicamento
            // 
            this.Cb_Agregar_medicamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mEDICAMENTOSBindingSource1, "id_medicamento", true));
            this.Cb_Agregar_medicamento.DataSource = this.mEDICAMENTOSBindingSource2;
            this.Cb_Agregar_medicamento.DisplayMember = "id_medicamento";
            this.Cb_Agregar_medicamento.FormattingEnabled = true;
            this.Cb_Agregar_medicamento.Location = new System.Drawing.Point(196, 12);
            this.Cb_Agregar_medicamento.Name = "Cb_Agregar_medicamento";
            this.Cb_Agregar_medicamento.Size = new System.Drawing.Size(211, 21);
            this.Cb_Agregar_medicamento.TabIndex = 2;
            this.Cb_Agregar_medicamento.ValueMember = "id_medicamento";
            this.Cb_Agregar_medicamento.SelectedIndexChanged += new System.EventHandler(this.Cb_Agregar_medicamento_SelectedIndexChanged);
            // 
            // mEDICAMENTOSBindingSource1
            // 
            this.mEDICAMENTOSBindingSource1.DataMember = "MEDICAMENTOS";
            this.mEDICAMENTOSBindingSource1.DataSource = this.medicamentosBindingSource;
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataSource = this.medicamentos;
            this.medicamentosBindingSource.Position = 0;
            // 
            // medicamentos
            // 
            this.medicamentos.DataSetName = "Medicamentos";
            this.medicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Dosis
            // 
            this.Txt_Dosis.Location = new System.Drawing.Point(196, 40);
            this.Txt_Dosis.Name = "Txt_Dosis";
            this.Txt_Dosis.Size = new System.Drawing.Size(211, 20);
            this.Txt_Dosis.TabIndex = 3;
            // 
            // Txt_Periodicidad
            // 
            this.Txt_Periodicidad.Location = new System.Drawing.Point(196, 67);
            this.Txt_Periodicidad.Multiline = true;
            this.Txt_Periodicidad.Name = "Txt_Periodicidad";
            this.Txt_Periodicidad.Size = new System.Drawing.Size(211, 57);
            this.Txt_Periodicidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dosis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodicidad";
            // 
            // mEDICAMENTOSTableAdapter
            // 
            this.mEDICAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // _PAV_3K2_2021_12DataSetAgregarMedicamentos
            // 
            this._PAV_3K2_2021_12DataSetAgregarMedicamentos.DataSetName = "_PAV_3K2_2021_12DataSetAgregarMedicamentos";
            this._PAV_3K2_2021_12DataSetAgregarMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICAMENTOSBindingSource2
            // 
            this.mEDICAMENTOSBindingSource2.DataMember = "MEDICAMENTOS";
            this.mEDICAMENTOSBindingSource2.DataSource = this._PAV_3K2_2021_12DataSetAgregarMedicamentos;
            // 
            // mEDICAMENTOSTableAdapter1
            // 
            this.mEDICAMENTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Agregar_Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(419, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Periodicidad);
            this.Controls.Add(this.Txt_Dosis);
            this.Controls.Add(this.Cb_Agregar_medicamento);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Agregar_Medicamento);
            this.Name = "Frm_Agregar_Medicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Frm_Agregar_Medicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSetAgregarMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Agregar_Medicamento;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ComboBox Cb_Agregar_medicamento;
        private System.Windows.Forms.TextBox Txt_Dosis;
        private System.Windows.Forms.TextBox Txt_Periodicidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private WindowsFormsApp1.Medicamentos medicamentos;
        private System.Windows.Forms.BindingSource mEDICAMENTOSBindingSource1;
        private MedicamentosTableAdapters.MEDICAMENTOSTableAdapter mEDICAMENTOSTableAdapter;
        private _PAV_3K2_2021_12DataSetAgregarMedicamentos _PAV_3K2_2021_12DataSetAgregarMedicamentos;
        private System.Windows.Forms.BindingSource mEDICAMENTOSBindingSource2;
        private _PAV_3K2_2021_12DataSetAgregarMedicamentosTableAdapters.MEDICAMENTOSTableAdapter mEDICAMENTOSTableAdapter1;
    }
}