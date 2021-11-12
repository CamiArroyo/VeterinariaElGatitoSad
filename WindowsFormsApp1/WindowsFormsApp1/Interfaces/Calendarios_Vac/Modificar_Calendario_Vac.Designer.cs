
namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    partial class Frm_Modificar_Calendario_Vac
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
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMascotas = new WindowsFormsApp1.DSMascotas();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Nro_Historia_Clinica = new System.Windows.Forms.Label();
            this.mASCOTASTableAdapter = new WindowsFormsApp1.DSMascotasTableAdapters.MASCOTASTableAdapter();
            this.Lbl_Nro_Historia_Clinica_Selecc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(415, 288);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 65;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(250, 288);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Modificar.TabIndex = 64;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(209, 110);
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(356, 154);
            this.Txt_Observaciones.TabIndex = 63;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(209, 66);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Inicio.TabIndex = 61;
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource.DataSource = this.dSMascotas;
            // 
            // dSMascotas
            // 
            this.dSMascotas.DataSetName = "DSMascotas";
            this.dSMascotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Location = new System.Drawing.Point(32, 113);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Observaciones.TabIndex = 59;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(32, 73);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(151, 13);
            this.Lbl_Fecha_Inicio.TabIndex = 58;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio del calendario:";
            // 
            // Lbl_Nro_Historia_Clinica
            // 
            this.Lbl_Nro_Historia_Clinica.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica.Location = new System.Drawing.Point(32, 32);
            this.Lbl_Nro_Historia_Clinica.Name = "Lbl_Nro_Historia_Clinica";
            this.Lbl_Nro_Historia_Clinica.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Nro_Historia_Clinica.TabIndex = 57;
            this.Lbl_Nro_Historia_Clinica.Text = "Número de historia clínica:";
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // Lbl_Nro_Historia_Clinica_Selecc
            // 
            this.Lbl_Nro_Historia_Clinica_Selecc.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica_Selecc.Location = new System.Drawing.Point(209, 30);
            this.Lbl_Nro_Historia_Clinica_Selecc.Name = "Lbl_Nro_Historia_Clinica_Selecc";
            this.Lbl_Nro_Historia_Clinica_Selecc.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_Historia_Clinica_Selecc.TabIndex = 68;
            // 
            // Frm_Modificar_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(604, 348);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica_Selecc);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica);
            this.Name = "Frm_Modificar_Calendario_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar calendario de vacunación";
            this.Load += new System.EventHandler(this.Frm_Modificar_Calendario_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica;
        private DSMascotas dSMascotas;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private DSMascotasTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica_Selecc;
    }
}