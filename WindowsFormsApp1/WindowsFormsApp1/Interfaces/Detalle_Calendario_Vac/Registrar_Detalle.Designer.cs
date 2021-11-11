
namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    partial class Frm_Registrar_Detalle
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
            this.Lbl_Nro_Calendario_Vac = new System.Windows.Forms.Label();
            this.Lbl_Vacuna = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Prevista = new System.Windows.Forms.Label();
            this.Lbl_Dosis = new System.Windows.Forms.Label();
            this.Cmb_Vacuna = new System.Windows.Forms.ComboBox();
            this.vACUNASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVacunasConStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVacunasConStock = new WindowsFormsApp1.DSVacunasConStock();
            this.eMPLEADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleados = new WindowsFormsApp1.Empleados();
            this.Dtp_Fecha_Prevista = new System.Windows.Forms.DateTimePicker();
            this.Txt_Dosis = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Lbl_Nro_HC = new System.Windows.Forms.Label();
            this.Lbl_Nro_CV = new System.Windows.Forms.Label();
            this.Lbl_Informacion = new System.Windows.Forms.Label();
            this.eMPLEADOSTableAdapter = new WindowsFormsApp1.EmpleadosTableAdapters.EMPLEADOSTableAdapter();
            this.vACUNASTableAdapter = new WindowsFormsApp1.DSVacunasConStockTableAdapters.VACUNASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVacunasConStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVacunasConStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nro_Historia_Clinica
            // 
            this.Lbl_Nro_Historia_Clinica.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica.Location = new System.Drawing.Point(28, 68);
            this.Lbl_Nro_Historia_Clinica.Name = "Lbl_Nro_Historia_Clinica";
            this.Lbl_Nro_Historia_Clinica.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Nro_Historia_Clinica.TabIndex = 0;
            this.Lbl_Nro_Historia_Clinica.Text = "Número de historia clínica:";
            // 
            // Lbl_Nro_Calendario_Vac
            // 
            this.Lbl_Nro_Calendario_Vac.AutoSize = true;
            this.Lbl_Nro_Calendario_Vac.Location = new System.Drawing.Point(28, 105);
            this.Lbl_Nro_Calendario_Vac.Name = "Lbl_Nro_Calendario_Vac";
            this.Lbl_Nro_Calendario_Vac.Size = new System.Drawing.Size(188, 13);
            this.Lbl_Nro_Calendario_Vac.TabIndex = 1;
            this.Lbl_Nro_Calendario_Vac.Text = "Número de calendario de vacunación:";
            // 
            // Lbl_Vacuna
            // 
            this.Lbl_Vacuna.AutoSize = true;
            this.Lbl_Vacuna.Location = new System.Drawing.Point(28, 144);
            this.Lbl_Vacuna.Name = "Lbl_Vacuna";
            this.Lbl_Vacuna.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Vacuna.TabIndex = 2;
            this.Lbl_Vacuna.Text = "Vacuna:";
            // 
            // Lbl_Fecha_Prevista
            // 
            this.Lbl_Fecha_Prevista.AutoSize = true;
            this.Lbl_Fecha_Prevista.Location = new System.Drawing.Point(28, 215);
            this.Lbl_Fecha_Prevista.Name = "Lbl_Fecha_Prevista";
            this.Lbl_Fecha_Prevista.Size = new System.Drawing.Size(80, 13);
            this.Lbl_Fecha_Prevista.TabIndex = 4;
            this.Lbl_Fecha_Prevista.Text = "Fecha prevista:";
            // 
            // Lbl_Dosis
            // 
            this.Lbl_Dosis.AutoSize = true;
            this.Lbl_Dosis.Location = new System.Drawing.Point(28, 181);
            this.Lbl_Dosis.Name = "Lbl_Dosis";
            this.Lbl_Dosis.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Dosis.TabIndex = 6;
            this.Lbl_Dosis.Text = "Dosis:";
            this.Lbl_Dosis.Click += new System.EventHandler(this.Lbl_Dosis_Click);
            // 
            // Cmb_Vacuna
            // 
            this.Cmb_Vacuna.DataSource = this.vACUNASBindingSource;
            this.Cmb_Vacuna.DisplayMember = "id_vacuna";
            this.Cmb_Vacuna.FormattingEnabled = true;
            this.Cmb_Vacuna.Location = new System.Drawing.Point(241, 141);
            this.Cmb_Vacuna.Name = "Cmb_Vacuna";
            this.Cmb_Vacuna.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Vacuna.TabIndex = 7;
            this.Cmb_Vacuna.ValueMember = "id_vacuna";
            // 
            // vACUNASBindingSource
            // 
            this.vACUNASBindingSource.DataMember = "VACUNAS";
            this.vACUNASBindingSource.DataSource = this.dSVacunasConStockBindingSource;
            // 
            // dSVacunasConStockBindingSource
            // 
            this.dSVacunasConStockBindingSource.DataSource = this.dSVacunasConStock;
            this.dSVacunasConStockBindingSource.Position = 0;
            // 
            // dSVacunasConStock
            // 
            this.dSVacunasConStock.DataSetName = "DSVacunasConStock";
            this.dSVacunasConStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLEADOSBindingSource
            // 
            this.eMPLEADOSBindingSource.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource.DataSource = this.empleados;
            // 
            // empleados
            // 
            this.empleados.DataSetName = "Empleados";
            this.empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dtp_Fecha_Prevista
            // 
            this.Dtp_Fecha_Prevista.Location = new System.Drawing.Point(241, 215);
            this.Dtp_Fecha_Prevista.Name = "Dtp_Fecha_Prevista";
            this.Dtp_Fecha_Prevista.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Prevista.TabIndex = 9;
            // 
            // Txt_Dosis
            // 
            this.Txt_Dosis.Location = new System.Drawing.Point(241, 178);
            this.Txt_Dosis.Name = "Txt_Dosis";
            this.Txt_Dosis.Size = new System.Drawing.Size(200, 20);
            this.Txt_Dosis.TabIndex = 11;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(256, 259);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 58;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(91, 259);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Registrar.TabIndex = 57;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Lbl_Nro_HC
            // 
            this.Lbl_Nro_HC.AutoSize = true;
            this.Lbl_Nro_HC.Location = new System.Drawing.Point(243, 68);
            this.Lbl_Nro_HC.Name = "Lbl_Nro_HC";
            this.Lbl_Nro_HC.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_HC.TabIndex = 59;
            // 
            // Lbl_Nro_CV
            // 
            this.Lbl_Nro_CV.AutoSize = true;
            this.Lbl_Nro_CV.Location = new System.Drawing.Point(243, 105);
            this.Lbl_Nro_CV.Name = "Lbl_Nro_CV";
            this.Lbl_Nro_CV.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_CV.TabIndex = 60;
            // 
            // Lbl_Informacion
            // 
            this.Lbl_Informacion.AutoSize = true;
            this.Lbl_Informacion.Location = new System.Drawing.Point(29, 27);
            this.Lbl_Informacion.Name = "Lbl_Informacion";
            this.Lbl_Informacion.Size = new System.Drawing.Size(402, 13);
            this.Lbl_Informacion.TabIndex = 61;
            this.Lbl_Informacion.Text = "INFORMACIÓN: Solo se muestran las vacunas para las cuales hay stock disponible";
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // vACUNASTableAdapter
            // 
            this.vACUNASTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Registrar_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(485, 321);
            this.Controls.Add(this.Lbl_Informacion);
            this.Controls.Add(this.Lbl_Nro_CV);
            this.Controls.Add(this.Lbl_Nro_HC);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Txt_Dosis);
            this.Controls.Add(this.Dtp_Fecha_Prevista);
            this.Controls.Add(this.Cmb_Vacuna);
            this.Controls.Add(this.Lbl_Dosis);
            this.Controls.Add(this.Lbl_Fecha_Prevista);
            this.Controls.Add(this.Lbl_Vacuna);
            this.Controls.Add(this.Lbl_Nro_Calendario_Vac);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica);
            this.Name = "Frm_Registrar_Detalle";
            this.Text = "Registrar vacunación pendiente";
            this.Load += new System.EventHandler(this.Frm_Registrar_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVacunasConStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVacunasConStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica;
        private System.Windows.Forms.Label Lbl_Nro_Calendario_Vac;
        private System.Windows.Forms.Label Lbl_Vacuna;
        private System.Windows.Forms.Label Lbl_Fecha_Prevista;
        private System.Windows.Forms.Label Lbl_Dosis;
        private System.Windows.Forms.ComboBox Cmb_Vacuna;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Prevista;
        private System.Windows.Forms.TextBox Txt_Dosis;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Label Lbl_Nro_HC;
        private System.Windows.Forms.Label Lbl_Nro_CV;
        private System.Windows.Forms.Label Lbl_Informacion;
        private WindowsFormsApp1.Empleados empleados;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource;
        private EmpleadosTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private System.Windows.Forms.BindingSource dSVacunasConStockBindingSource;
        private DSVacunasConStock dSVacunasConStock;
        private System.Windows.Forms.BindingSource vACUNASBindingSource;
        private DSVacunasConStockTableAdapters.VACUNASTableAdapter vACUNASTableAdapter;
    }
}