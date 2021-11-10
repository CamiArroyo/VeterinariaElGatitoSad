
namespace WindowsFormsApp1.Interfaces.Mascotas
{
    partial class Frm_Registrar_Mascota
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
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            this.Cmb_Id_Raza = new System.Windows.Forms.ComboBox();
            this.rAZASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet8 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet8();
            this.Cmb_Id_Dueño = new System.Windows.Forms.ComboBox();
            this.dUEÑOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet9 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet9();
            this.Dtm_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Btm_Registrar = new System.Windows.Forms.Button();
            this.Btm_Cerrar = new System.Windows.Forms.Button();
            this.rAZASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet8TableAdapters.RAZASTableAdapter();
            this.dUEÑOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet9TableAdapters.DUEÑOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la mascota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dueño:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(153, 28);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nombre.TabIndex = 6;
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(153, 153);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(200, 20);
            this.Txt_Peso.TabIndex = 7;
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(153, 194);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(200, 20);
            this.Txt_Altura.TabIndex = 8;
            // 
            // Cmb_Id_Raza
            // 
            this.Cmb_Id_Raza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rAZASBindingSource, "id_raza", true));
            this.Cmb_Id_Raza.DataSource = this.rAZASBindingSource;
            this.Cmb_Id_Raza.DisplayMember = "id_raza";
            this.Cmb_Id_Raza.FormattingEnabled = true;
            this.Cmb_Id_Raza.Location = new System.Drawing.Point(153, 111);
            this.Cmb_Id_Raza.Name = "Cmb_Id_Raza";
            this.Cmb_Id_Raza.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Id_Raza.TabIndex = 9;
            this.Cmb_Id_Raza.ValueMember = "id_raza";
            this.Cmb_Id_Raza.SelectedIndexChanged += new System.EventHandler(this.Cmb_Id_Raza_SelectedIndexChanged);
            // 
            // rAZASBindingSource
            // 
            this.rAZASBindingSource.DataMember = "RAZAS";
            this.rAZASBindingSource.DataSource = this._PAV_3K2_2021_12DataSet8;
            // 
            // _PAV_3K2_2021_12DataSet8
            // 
            this._PAV_3K2_2021_12DataSet8.DataSetName = "_PAV_3K2_2021_12DataSet8";
            this._PAV_3K2_2021_12DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cmb_Id_Dueño
            // 
            this.Cmb_Id_Dueño.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dUEÑOSBindingSource, "id_dueño", true));
            this.Cmb_Id_Dueño.DataSource = this.dUEÑOSBindingSource;
            this.Cmb_Id_Dueño.DisplayMember = "id_dueño";
            this.Cmb_Id_Dueño.FormattingEnabled = true;
            this.Cmb_Id_Dueño.Location = new System.Drawing.Point(153, 234);
            this.Cmb_Id_Dueño.Name = "Cmb_Id_Dueño";
            this.Cmb_Id_Dueño.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Id_Dueño.TabIndex = 10;
            this.Cmb_Id_Dueño.ValueMember = "id_dueño";
            // 
            // dUEÑOSBindingSource
            // 
            this.dUEÑOSBindingSource.DataMember = "DUEÑOS";
            this.dUEÑOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet9;
            // 
            // _PAV_3K2_2021_12DataSet9
            // 
            this._PAV_3K2_2021_12DataSet9.DataSetName = "_PAV_3K2_2021_12DataSet9";
            this._PAV_3K2_2021_12DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dtm_Fecha_Nacimiento
            // 
            this.Dtm_Fecha_Nacimiento.Location = new System.Drawing.Point(153, 70);
            this.Dtm_Fecha_Nacimiento.Name = "Dtm_Fecha_Nacimiento";
            this.Dtm_Fecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.Dtm_Fecha_Nacimiento.TabIndex = 11;
            // 
            // Btm_Registrar
            // 
            this.Btm_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Registrar.Location = new System.Drawing.Point(52, 277);
            this.Btm_Registrar.Name = "Btm_Registrar";
            this.Btm_Registrar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Registrar.TabIndex = 12;
            this.Btm_Registrar.Text = "Registrar";
            this.Btm_Registrar.UseVisualStyleBackColor = false;
            this.Btm_Registrar.Click += new System.EventHandler(this.Btm_Registrar_Click);
            // 
            // Btm_Cerrar
            // 
            this.Btm_Cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btm_Cerrar.Location = new System.Drawing.Point(211, 277);
            this.Btm_Cerrar.Name = "Btm_Cerrar";
            this.Btm_Cerrar.Size = new System.Drawing.Size(125, 40);
            this.Btm_Cerrar.TabIndex = 13;
            this.Btm_Cerrar.Text = "Cancelar";
            this.Btm_Cerrar.UseVisualStyleBackColor = false;
            this.Btm_Cerrar.Click += new System.EventHandler(this.Btm_Cerrar_Click);
            // 
            // rAZASTableAdapter
            // 
            this.rAZASTableAdapter.ClearBeforeFill = true;
            // 
            // dUEÑOSTableAdapter
            // 
            this.dUEÑOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Registrar_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.Btm_Cerrar);
            this.Controls.Add(this.Btm_Registrar);
            this.Controls.Add(this.Dtm_Fecha_Nacimiento);
            this.Controls.Add(this.Cmb_Id_Dueño);
            this.Controls.Add(this.Cmb_Id_Raza);
            this.Controls.Add(this.Txt_Altura);
            this.Controls.Add(this.Txt_Peso);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar mascota";
            this.Load += new System.EventHandler(this.Frm_Registrar_Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUEÑOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.ComboBox Cmb_Id_Raza;
        private System.Windows.Forms.ComboBox Cmb_Id_Dueño;
        private System.Windows.Forms.DateTimePicker Dtm_Fecha_Nacimiento;
        private System.Windows.Forms.Button Btm_Registrar;
        private System.Windows.Forms.Button Btm_Cerrar;
        private _PAV_3K2_2021_12DataSet8 _PAV_3K2_2021_12DataSet8;
        private System.Windows.Forms.BindingSource rAZASBindingSource;
        private _PAV_3K2_2021_12DataSet8TableAdapters.RAZASTableAdapter rAZASTableAdapter;
        private _PAV_3K2_2021_12DataSet9 _PAV_3K2_2021_12DataSet9;
        private System.Windows.Forms.BindingSource dUEÑOSBindingSource;
        private _PAV_3K2_2021_12DataSet9TableAdapters.DUEÑOSTableAdapter dUEÑOSTableAdapter;
    }
}