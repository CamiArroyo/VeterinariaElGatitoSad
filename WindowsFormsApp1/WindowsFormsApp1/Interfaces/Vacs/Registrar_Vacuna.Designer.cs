
namespace WindowsFormsApp1.Interfaces.Vacs
{
    partial class Frm_Registrar_Vacuna
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
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Id_Lab = new System.Windows.Forms.Label();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Cb_id_lab = new System.Windows.Forms.ComboBox();
            this.lABORATORIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet = new WindowsFormsApp1._PAV_3K2_2021_12DataSet();
            this.lABORATORIOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(23, 50);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(112, 13);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Nombre de la vacuna:";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(23, 103);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(131, 13);
            this.Lbl_Descripcion.TabIndex = 1;
            this.Lbl_Descripcion.Text = "Descripción de la vacuna:";
            // 
            // Lbl_Id_Lab
            // 
            this.Lbl_Id_Lab.AutoSize = true;
            this.Lbl_Id_Lab.Location = new System.Drawing.Point(335, 50);
            this.Lbl_Id_Lab.Name = "Lbl_Id_Lab";
            this.Lbl_Id_Lab.Size = new System.Drawing.Size(73, 13);
            this.Lbl_Id_Lab.TabIndex = 2;
            this.Lbl_Id_Lab.Text = "ID laboratorio:";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Confirmar.Location = new System.Drawing.Point(327, 281);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Confirmar.TabIndex = 3;
            this.Btn_Confirmar.Text = "Registrar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(473, 281);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(150, 47);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(165, 20);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // Cb_id_lab
            // 
            this.Cb_id_lab.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lABORATORIOSBindingSource, "id_laboratorio", true));
            this.Cb_id_lab.DataSource = this.lABORATORIOSBindingSource;
            this.Cb_id_lab.DisplayMember = "id_laboratorio";
            this.Cb_id_lab.FormattingEnabled = true;
            this.Cb_id_lab.Location = new System.Drawing.Point(433, 47);
            this.Cb_id_lab.Name = "Cb_id_lab";
            this.Cb_id_lab.Size = new System.Drawing.Size(165, 21);
            this.Cb_id_lab.TabIndex = 7;
            this.Cb_id_lab.ValueMember = "id_laboratorio";
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
            // lABORATORIOSTableAdapter
            // 
            this.lABORATORIOSTableAdapter.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(26, 134);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(572, 115);
            this.Txt_Descripcion.TabIndex = 59;
            // 
            // Frm_Registrar_Vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Cb_id_lab);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Lbl_Id_Lab);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Name = "Frm_Registrar_Vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar vacuna";
            this.Load += new System.EventHandler(this.Frm_Registrar_Vacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lABORATORIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Id_Lab;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.ComboBox Cb_id_lab;
        private _PAV_3K2_2021_12DataSet _PAV_3K2_2021_12DataSet;
        private System.Windows.Forms.BindingSource lABORATORIOSBindingSource;
        private _PAV_3K2_2021_12DataSetTableAdapters.LABORATORIOSTableAdapter lABORATORIOSTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Txt_Descripcion;
    }
}