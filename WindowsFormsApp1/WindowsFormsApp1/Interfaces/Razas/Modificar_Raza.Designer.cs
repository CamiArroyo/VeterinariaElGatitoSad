
namespace WindowsFormsApp1.Interfaces.Razas
{
    partial class Frm_Modificar_Raza
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
            this.Lbl_Especie = new System.Windows.Forms.Label();
            this.Cmb_Especie = new System.Windows.Forms.ComboBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Lbl_Altura_Media = new System.Windows.Forms.Label();
            this.Txt_Altura_Media = new System.Windows.Forms.TextBox();
            this.Lbl_Peso_Medio = new System.Windows.Forms.Label();
            this.Txt_Peso_Medio = new System.Windows.Forms.TextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this._PAV_3K2_2021_12DataSet5 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet5();
            this.eSPECIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIESTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet5TableAdapters.ESPECIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Especie
            // 
            this.Lbl_Especie.AutoSize = true;
            this.Lbl_Especie.Location = new System.Drawing.Point(30, 29);
            this.Lbl_Especie.Name = "Lbl_Especie";
            this.Lbl_Especie.Size = new System.Drawing.Size(124, 13);
            this.Lbl_Especie.TabIndex = 23;
            this.Lbl_Especie.Text = "Seleccione una especie:";
            // 
            // Cmb_Especie
            // 
            this.Cmb_Especie.DataSource = this.eSPECIESBindingSource;
            this.Cmb_Especie.DisplayMember = "id_especie";
            this.Cmb_Especie.FormattingEnabled = true;
            this.Cmb_Especie.Location = new System.Drawing.Point(172, 26);
            this.Cmb_Especie.Name = "Cmb_Especie";
            this.Cmb_Especie.Size = new System.Drawing.Size(140, 21);
            this.Cmb_Especie.TabIndex = 22;
            this.Cmb_Especie.ValueMember = "id_especie";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(181, 218);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Cancelar.TabIndex = 21;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(49, 218);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Modificar.TabIndex = 20;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Lbl_Altura_Media
            // 
            this.Lbl_Altura_Media.AutoSize = true;
            this.Lbl_Altura_Media.Location = new System.Drawing.Point(30, 172);
            this.Lbl_Altura_Media.Name = "Lbl_Altura_Media";
            this.Lbl_Altura_Media.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Altura_Media.TabIndex = 19;
            this.Lbl_Altura_Media.Text = "Altura media:";
            // 
            // Txt_Altura_Media
            // 
            this.Txt_Altura_Media.Location = new System.Drawing.Point(172, 169);
            this.Txt_Altura_Media.Name = "Txt_Altura_Media";
            this.Txt_Altura_Media.Size = new System.Drawing.Size(140, 20);
            this.Txt_Altura_Media.TabIndex = 18;
            // 
            // Lbl_Peso_Medio
            // 
            this.Lbl_Peso_Medio.AutoSize = true;
            this.Lbl_Peso_Medio.Location = new System.Drawing.Point(30, 136);
            this.Lbl_Peso_Medio.Name = "Lbl_Peso_Medio";
            this.Lbl_Peso_Medio.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Peso_Medio.TabIndex = 17;
            this.Lbl_Peso_Medio.Text = "Peso medio:";
            // 
            // Txt_Peso_Medio
            // 
            this.Txt_Peso_Medio.Location = new System.Drawing.Point(172, 133);
            this.Txt_Peso_Medio.Name = "Txt_Peso_Medio";
            this.Txt_Peso_Medio.Size = new System.Drawing.Size(140, 20);
            this.Txt_Peso_Medio.TabIndex = 16;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(30, 101);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(66, 13);
            this.Lbl_Descripcion.TabIndex = 15;
            this.Lbl_Descripcion.Text = "Descripción:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(172, 98);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(140, 20);
            this.Txt_Descripcion.TabIndex = 14;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(30, 66);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Nombre.TabIndex = 13;
            this.Lbl_Nombre.Text = "Nombre de la raza:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(172, 63);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(140, 20);
            this.Txt_Nombre.TabIndex = 12;
            // 
            // _PAV_3K2_2021_12DataSet5
            // 
            this._PAV_3K2_2021_12DataSet5.DataSetName = "_PAV_3K2_2021_12DataSet5";
            this._PAV_3K2_2021_12DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSPECIESBindingSource
            // 
            this.eSPECIESBindingSource.DataMember = "ESPECIES";
            this.eSPECIESBindingSource.DataSource = this._PAV_3K2_2021_12DataSet5;
            // 
            // eSPECIESTableAdapter
            // 
            this.eSPECIESTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Modificar_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(349, 282);
            this.Controls.Add(this.Lbl_Especie);
            this.Controls.Add(this.Cmb_Especie);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Lbl_Altura_Media);
            this.Controls.Add(this.Txt_Altura_Media);
            this.Controls.Add(this.Lbl_Peso_Medio);
            this.Controls.Add(this.Txt_Peso_Medio);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "Frm_Modificar_Raza";
            this.Text = "Modificar raza";
            this.Load += new System.EventHandler(this.Frm_Modificar_Raza_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Especie;
        private System.Windows.Forms.ComboBox Cmb_Especie;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label Lbl_Altura_Media;
        private System.Windows.Forms.TextBox Txt_Altura_Media;
        private System.Windows.Forms.Label Lbl_Peso_Medio;
        private System.Windows.Forms.TextBox Txt_Peso_Medio;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private _PAV_3K2_2021_12DataSet5 _PAV_3K2_2021_12DataSet5;
        private System.Windows.Forms.BindingSource eSPECIESBindingSource;
        private _PAV_3K2_2021_12DataSet5TableAdapters.ESPECIESTableAdapter eSPECIESTableAdapter;
    }
}