
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
            this.components = new System.ComponentModel.Container();
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
            this.Cmb_Especie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._PAV_3K2_2021_12DataSet1 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet1();
            this.eSPECIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIESTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet1TableAdapters.ESPECIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(172, 64);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(140, 20);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(30, 67);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Nombre.TabIndex = 1;
            this.Lbl_Nombre.Text = "Nombre de la raza:";
            this.Lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(30, 102);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripción:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(172, 99);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(140, 20);
            this.Txt_Descripcion.TabIndex = 2;
            // 
            // Lbl_Peso_Medio
            // 
            this.Lbl_Peso_Medio.AutoSize = true;
            this.Lbl_Peso_Medio.Location = new System.Drawing.Point(30, 137);
            this.Lbl_Peso_Medio.Name = "Lbl_Peso_Medio";
            this.Lbl_Peso_Medio.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Peso_Medio.TabIndex = 5;
            this.Lbl_Peso_Medio.Text = "Peso medio:";
            // 
            // Txt_Peso_Medio
            // 
            this.Txt_Peso_Medio.Location = new System.Drawing.Point(172, 134);
            this.Txt_Peso_Medio.Name = "Txt_Peso_Medio";
            this.Txt_Peso_Medio.Size = new System.Drawing.Size(140, 20);
            this.Txt_Peso_Medio.TabIndex = 4;
            // 
            // Lbl_Altura_Media
            // 
            this.Lbl_Altura_Media.AutoSize = true;
            this.Lbl_Altura_Media.Location = new System.Drawing.Point(30, 173);
            this.Lbl_Altura_Media.Name = "Lbl_Altura_Media";
            this.Lbl_Altura_Media.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Altura_Media.TabIndex = 7;
            this.Lbl_Altura_Media.Text = "Altura media:";
            // 
            // Txt_Altura_Media
            // 
            this.Txt_Altura_Media.Location = new System.Drawing.Point(172, 170);
            this.Txt_Altura_Media.Name = "Txt_Altura_Media";
            this.Txt_Altura_Media.Size = new System.Drawing.Size(140, 20);
            this.Txt_Altura_Media.TabIndex = 6;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(49, 219);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrar.TabIndex = 8;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(200, 219);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Cmb_Especie
            // 
            this.Cmb_Especie.DataSource = this.eSPECIESBindingSource;
            this.Cmb_Especie.DisplayMember = "id_especie";
            this.Cmb_Especie.FormattingEnabled = true;
            this.Cmb_Especie.Location = new System.Drawing.Point(172, 27);
            this.Cmb_Especie.Name = "Cmb_Especie";
            this.Cmb_Especie.Size = new System.Drawing.Size(140, 21);
            this.Cmb_Especie.TabIndex = 10;
            this.Cmb_Especie.ValueMember = "id_especie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione una especie:";
            // 
            // _PAV_3K2_2021_12DataSet1
            // 
            this._PAV_3K2_2021_12DataSet1.DataSetName = "_PAV_3K2_2021_12DataSet1";
            this._PAV_3K2_2021_12DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSPECIESBindingSource
            // 
            this.eSPECIESBindingSource.DataMember = "ESPECIES";
            this.eSPECIESBindingSource.DataSource = this._PAV_3K2_2021_12DataSet1;
            // 
            // eSPECIESTableAdapter
            // 
            this.eSPECIESTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Registrar_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(353, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Especie);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar raza";
            this.Load += new System.EventHandler(this.Frm_Registrar_Raza_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox Cmb_Especie;
        private System.Windows.Forms.Label label1;
        private _PAV_3K2_2021_12DataSet1 _PAV_3K2_2021_12DataSet1;
        private System.Windows.Forms.BindingSource eSPECIESBindingSource;
        private _PAV_3K2_2021_12DataSet1TableAdapters.ESPECIESTableAdapter eSPECIESTableAdapter;
    }
}