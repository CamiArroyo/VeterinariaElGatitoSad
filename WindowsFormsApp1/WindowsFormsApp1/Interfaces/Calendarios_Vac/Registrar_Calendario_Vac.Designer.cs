
namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    partial class Frm_Registrar_Calendario_Vac
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
            this.Lbl_Nro_Historia_Clinica = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Cmb_Nro_Historia_Clinica = new System.Windows.Forms.ComboBox();
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet13 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet13();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Btn_Ver_Mascotas = new System.Windows.Forms.Button();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.mASCOTASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet13TableAdapters.MASCOTASTableAdapter();
            this.dSMascotasSinCalendario = new WindowsFormsApp1.DSMascotasSinCalendario();
            this.dSMascotasSinCalendarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter1 = new WindowsFormsApp1.DSMascotasSinCalendarioTableAdapters.MASCOTASTableAdapter();
            this.Lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasSinCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasSinCalendarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nro_Historia_Clinica
            // 
            this.Lbl_Nro_Historia_Clinica.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica.Location = new System.Drawing.Point(31, 66);
            this.Lbl_Nro_Historia_Clinica.Name = "Lbl_Nro_Historia_Clinica";
            this.Lbl_Nro_Historia_Clinica.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Nro_Historia_Clinica.TabIndex = 0;
            this.Lbl_Nro_Historia_Clinica.Text = "Número de historia clínica:";
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(31, 114);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(151, 13);
            this.Lbl_Fecha_Inicio.TabIndex = 2;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio del calendario:";
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Location = new System.Drawing.Point(31, 154);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Observaciones.TabIndex = 3;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Cmb_Nro_Historia_Clinica
            // 
            this.Cmb_Nro_Historia_Clinica.DataSource = this.mASCOTASBindingSource1;
            this.Cmb_Nro_Historia_Clinica.DisplayMember = "nro_historia_clinica";
            this.Cmb_Nro_Historia_Clinica.FormattingEnabled = true;
            this.Cmb_Nro_Historia_Clinica.Location = new System.Drawing.Point(208, 58);
            this.Cmb_Nro_Historia_Clinica.Name = "Cmb_Nro_Historia_Clinica";
            this.Cmb_Nro_Historia_Clinica.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Nro_Historia_Clinica.TabIndex = 4;
            this.Cmb_Nro_Historia_Clinica.ValueMember = "nro_historia_clinica";
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource.DataSource = this._PAV_3K2_2021_12DataSet13;
            // 
            // _PAV_3K2_2021_12DataSet13
            // 
            this._PAV_3K2_2021_12DataSet13.DataSetName = "_PAV_3K2_2021_12DataSet13";
            this._PAV_3K2_2021_12DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(208, 107);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Inicio.TabIndex = 5;
            // 
            // Btn_Ver_Mascotas
            // 
            this.Btn_Ver_Mascotas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Ver_Mascotas.Location = new System.Drawing.Point(439, 58);
            this.Btn_Ver_Mascotas.Name = "Btn_Ver_Mascotas";
            this.Btn_Ver_Mascotas.Size = new System.Drawing.Size(125, 40);
            this.Btn_Ver_Mascotas.TabIndex = 6;
            this.Btn_Ver_Mascotas.Text = "Ver mascotas";
            this.Btn_Ver_Mascotas.UseVisualStyleBackColor = false;
            this.Btn_Ver_Mascotas.Click += new System.EventHandler(this.Btn_Ver_Mascotas_Click);
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(208, 151);
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(356, 154);
            this.Txt_Observaciones.TabIndex = 54;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(405, 327);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 56;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(240, 327);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Registrar.TabIndex = 55;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // dSMascotasSinCalendario
            // 
            this.dSMascotasSinCalendario.DataSetName = "DSMascotasSinCalendario";
            this.dSMascotasSinCalendario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSMascotasSinCalendarioBindingSource
            // 
            this.dSMascotasSinCalendarioBindingSource.DataSource = this.dSMascotasSinCalendario;
            this.dSMascotasSinCalendarioBindingSource.Position = 0;
            // 
            // mASCOTASBindingSource1
            // 
            this.mASCOTASBindingSource1.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource1.DataSource = this.dSMascotasSinCalendarioBindingSource;
            // 
            // mASCOTASTableAdapter1
            // 
            this.mASCOTASTableAdapter1.ClearBeforeFill = true;
            // 
            // Lbl_Info
            // 
            this.Lbl_Info.AutoSize = true;
            this.Lbl_Info.Location = new System.Drawing.Point(31, 27);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new System.Drawing.Size(506, 13);
            this.Lbl_Info.TabIndex = 57;
            this.Lbl_Info.Text = "INFORMACIÓN: Se muestra solo las mascotas que aún no tienen asignado un calendari" +
    "o de vacunación.";
            // 
            // Frm_Registrar_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(604, 386);
            this.Controls.Add(this.Lbl_Info);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Btn_Ver_Mascotas);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Cmb_Nro_Historia_Clinica);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica);
            this.Name = "Frm_Registrar_Calendario_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar calendario de vacunación";
            this.Load += new System.EventHandler(this.Frm_Registrar_Calendario_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasSinCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotasSinCalendarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.ComboBox Cmb_Nro_Historia_Clinica;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Button Btn_Ver_Mascotas;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Registrar;
        private _PAV_3K2_2021_12DataSet13 _PAV_3K2_2021_12DataSet13;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private _PAV_3K2_2021_12DataSet13TableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.BindingSource dSMascotasSinCalendarioBindingSource;
        private DSMascotasSinCalendario dSMascotasSinCalendario;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource1;
        private DSMascotasSinCalendarioTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter1;
        private System.Windows.Forms.Label Lbl_Info;
    }
}