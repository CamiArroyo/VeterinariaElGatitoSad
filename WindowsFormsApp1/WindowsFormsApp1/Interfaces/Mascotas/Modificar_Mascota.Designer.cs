
namespace WindowsFormsApp1.Interfaces.Mascotas
{
    partial class Frm_Modificar_Mascota
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
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Btm_Guardar = new System.Windows.Forms.Button();
            this.Btm_Cancelar = new System.Windows.Forms.Button();
            this.Dtm_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Id_Dueño = new System.Windows.Forms.ComboBox();
            this.dUEÑOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12Dueños = new WindowsFormsApp1._PAV_3K2_2021_12Dueños();
            this.Cmb_Id_Raza = new System.Windows.Forms.ComboBox();
            this.rAZASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet4 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet4();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rAZASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet4TableAdapters.RAZASTableAdapter();
            this.dUEÑOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter();
            this.rAZASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(160, 33);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nombre.TabIndex = 4;
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(160, 151);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Peso.TabIndex = 5;
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(160, 192);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(200, 20);
            this.Txt_Altura.TabIndex = 6;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cmb_Estado.Location = new System.Drawing.Point(160, 270);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Estado.TabIndex = 7;
            // 
            // Btm_Guardar
            // 
            this.Btm_Guardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Guardar.Location = new System.Drawing.Point(55, 309);
            this.Btm_Guardar.Name = "Btm_Guardar";
            this.Btm_Guardar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Guardar.TabIndex = 8;
            this.Btm_Guardar.Text = "Modificar";
            this.Btm_Guardar.UseVisualStyleBackColor = false;
            this.Btm_Guardar.Click += new System.EventHandler(this.Btm_Guardar_Click);
            // 
            // Btm_Cancelar
            // 
            this.Btm_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Cancelar.Location = new System.Drawing.Point(205, 309);
            this.Btm_Cancelar.Name = "Btm_Cancelar";
            this.Btm_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Cancelar.TabIndex = 9;
            this.Btm_Cancelar.Text = "Cancelar";
            this.Btm_Cancelar.UseVisualStyleBackColor = false;
            this.Btm_Cancelar.Click += new System.EventHandler(this.Btm_Cancelar_Click);
            // 
            // Dtm_Fecha_Nacimiento
            // 
            this.Dtm_Fecha_Nacimiento.Location = new System.Drawing.Point(160, 69);
            this.Dtm_Fecha_Nacimiento.Name = "Dtm_Fecha_Nacimiento";
            this.Dtm_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtm_Fecha_Nacimiento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // Cmb_Id_Dueño
            // 
            this.Cmb_Id_Dueño.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dUEÑOSBindingSource, "id_dueño", true));
            this.Cmb_Id_Dueño.DataSource = this.dUEÑOSBindingSource;
            this.Cmb_Id_Dueño.DisplayMember = "id_dueño";
            this.Cmb_Id_Dueño.FormattingEnabled = true;
            this.Cmb_Id_Dueño.Location = new System.Drawing.Point(160, 233);
            this.Cmb_Id_Dueño.Name = "Cmb_Id_Dueño";
            this.Cmb_Id_Dueño.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Id_Dueño.TabIndex = 17;
            this.Cmb_Id_Dueño.ValueMember = "id_dueño";
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
            // Cmb_Id_Raza
            // 
            this.Cmb_Id_Raza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rAZASBindingSource, "id_raza", true));
            this.Cmb_Id_Raza.DataSource = this.rAZASBindingSource;
            this.Cmb_Id_Raza.DisplayMember = "id_raza";
            this.Cmb_Id_Raza.FormattingEnabled = true;
            this.Cmb_Id_Raza.Location = new System.Drawing.Point(160, 110);
            this.Cmb_Id_Raza.Name = "Cmb_Id_Raza";
            this.Cmb_Id_Raza.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Id_Raza.TabIndex = 16;
            this.Cmb_Id_Raza.ValueMember = "id_raza";
            this.Cmb_Id_Raza.SelectedIndexChanged += new System.EventHandler(this.Cmb_Id_Raza_SelectedIndexChanged);
            // 
            // rAZASBindingSource
            // 
            this.rAZASBindingSource.DataMember = "RAZAS";
            this.rAZASBindingSource.DataSource = this._PAV_3K2_2021_12DataSet4;
            // 
            // _PAV_3K2_2021_12DataSet4
            // 
            this._PAV_3K2_2021_12DataSet4.DataSetName = "_PAV_3K2_2021_12DataSet4";
            this._PAV_3K2_2021_12DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dueño:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Raza:";
            // 
            // rAZASTableAdapter
            // 
            this.rAZASTableAdapter.ClearBeforeFill = true;
            // 
            // dUEÑOSTableAdapter
            // 
            this.dUEÑOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Modificar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 365);
            this.Controls.Add(this.Cmb_Id_Dueño);
            this.Controls.Add(this.Cmb_Id_Raza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dtm_Fecha_Nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btm_Cancelar);
            this.Controls.Add(this.Btm_Guardar);
            this.Controls.Add(this.Cmb_Estado);
            this.Controls.Add(this.Txt_Altura);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar mascota";
            this.Load += new System.EventHandler(this.Frm_Modificar_Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12Dueños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Button Btm_Guardar;
        private System.Windows.Forms.Button Btm_Cancelar;
        private System.Windows.Forms.DateTimePicker Dtm_Fecha_Nacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_Id_Dueño;
        private System.Windows.Forms.ComboBox Cmb_Id_Raza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private _PAV_3K2_2021_12DataSet4 _PAV_3K2_2021_12DataSet4;
        private System.Windows.Forms.BindingSource rAZASBindingSource;
        private _PAV_3K2_2021_12DataSet4TableAdapters.RAZASTableAdapter rAZASTableAdapter;
        private _PAV_3K2_2021_12Dueños _PAV_3K2_2021_12Dueños;
        private System.Windows.Forms.BindingSource dUEÑOSBindingSource;
        private _PAV_3K2_2021_12DueñosTableAdapters.DUEÑOSTableAdapter dUEÑOSTableAdapter;
        private System.Windows.Forms.BindingSource rAZASBindingSource1;

    }
}