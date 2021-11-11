
namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    partial class Frm_Modificar_Detalle
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
            this.Lbl_Nro_CV = new System.Windows.Forms.Label();
            this.Lbl_Nro_HC = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Txt_Dosis = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Real = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empleados = new WindowsFormsApp1.Empleados();
            this.Lbl_Dosis = new System.Windows.Forms.Label();
            this.LBL_Empleado = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Prevista = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Real = new System.Windows.Forms.Label();
            this.Lbl_Vacuna = new System.Windows.Forms.Label();
            this.Lbl_Nro_Calendario_Vac = new System.Windows.Forms.Label();
            this.Lbl_Nro_Historia_Clinica = new System.Windows.Forms.Label();
            this.Lbl_Nro_Detalle = new System.Windows.Forms.Label();
            this.Lbl_Nro_Det = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Prev = new System.Windows.Forms.Label();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOSTableAdapter = new WindowsFormsApp1.EmpleadosTableAdapters.EMPLEADOSTableAdapter();
            this.Lbl_ID_Vac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nro_CV
            // 
            this.Lbl_Nro_CV.AutoSize = true;
            this.Lbl_Nro_CV.Location = new System.Drawing.Point(242, 70);
            this.Lbl_Nro_CV.Name = "Lbl_Nro_CV";
            this.Lbl_Nro_CV.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_CV.TabIndex = 77;
            // 
            // Lbl_Nro_HC
            // 
            this.Lbl_Nro_HC.AutoSize = true;
            this.Lbl_Nro_HC.Location = new System.Drawing.Point(242, 33);
            this.Lbl_Nro_HC.Name = "Lbl_Nro_HC";
            this.Lbl_Nro_HC.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_HC.TabIndex = 76;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(260, 340);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 75;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar.Location = new System.Drawing.Point(95, 340);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Registrar.TabIndex = 74;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Txt_Dosis
            // 
            this.Txt_Dosis.Location = new System.Drawing.Point(240, 181);
            this.Txt_Dosis.Name = "Txt_Dosis";
            this.Txt_Dosis.Size = new System.Drawing.Size(200, 20);
            this.Txt_Dosis.TabIndex = 73;
            // 
            // Dtp_Fecha_Real
            // 
            this.Dtp_Fecha_Real.Location = new System.Drawing.Point(240, 256);
            this.Dtp_Fecha_Real.Name = "Dtp_Fecha_Real";
            this.Dtp_Fecha_Real.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Real.TabIndex = 72;
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.DataSource = this.eMPLEADOSBindingSource1;
            this.Cmb_Empleado.DisplayMember = "id_empleado";
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(240, 292);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Empleado.TabIndex = 70;
            this.Cmb_Empleado.ValueMember = "id_empleado";
            // 
            // empleadosBindingSource2
            // 
            this.empleadosBindingSource2.DataSource = this.empleados;
            this.empleadosBindingSource2.Position = 0;
            // 
            // empleados
            // 
            this.empleados.DataSetName = "Empleados";
            this.empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Lbl_Dosis
            // 
            this.Lbl_Dosis.AutoSize = true;
            this.Lbl_Dosis.Location = new System.Drawing.Point(27, 184);
            this.Lbl_Dosis.Name = "Lbl_Dosis";
            this.Lbl_Dosis.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Dosis.TabIndex = 68;
            this.Lbl_Dosis.Text = "Dosis:";
            // 
            // LBL_Empleado
            // 
            this.LBL_Empleado.AutoSize = true;
            this.LBL_Empleado.Location = new System.Drawing.Point(27, 295);
            this.LBL_Empleado.Name = "LBL_Empleado";
            this.LBL_Empleado.Size = new System.Drawing.Size(163, 13);
            this.LBL_Empleado.TabIndex = 67;
            this.LBL_Empleado.Text = "Empleado que colocó la vacuna:";
            // 
            // Lbl_Fecha_Prevista
            // 
            this.Lbl_Fecha_Prevista.AutoSize = true;
            this.Lbl_Fecha_Prevista.Location = new System.Drawing.Point(27, 218);
            this.Lbl_Fecha_Prevista.Name = "Lbl_Fecha_Prevista";
            this.Lbl_Fecha_Prevista.Size = new System.Drawing.Size(80, 13);
            this.Lbl_Fecha_Prevista.TabIndex = 66;
            this.Lbl_Fecha_Prevista.Text = "Fecha prevista:";
            // 
            // Lbl_Fecha_Real
            // 
            this.Lbl_Fecha_Real.AutoSize = true;
            this.Lbl_Fecha_Real.Location = new System.Drawing.Point(27, 256);
            this.Lbl_Fecha_Real.Name = "Lbl_Fecha_Real";
            this.Lbl_Fecha_Real.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Fecha_Real.TabIndex = 65;
            this.Lbl_Fecha_Real.Text = "Fecha real:";
            // 
            // Lbl_Vacuna
            // 
            this.Lbl_Vacuna.AutoSize = true;
            this.Lbl_Vacuna.Location = new System.Drawing.Point(27, 147);
            this.Lbl_Vacuna.Name = "Lbl_Vacuna";
            this.Lbl_Vacuna.Size = new System.Drawing.Size(86, 13);
            this.Lbl_Vacuna.TabIndex = 64;
            this.Lbl_Vacuna.Text = "ID de la vacuna:";
            // 
            // Lbl_Nro_Calendario_Vac
            // 
            this.Lbl_Nro_Calendario_Vac.AutoSize = true;
            this.Lbl_Nro_Calendario_Vac.Location = new System.Drawing.Point(27, 70);
            this.Lbl_Nro_Calendario_Vac.Name = "Lbl_Nro_Calendario_Vac";
            this.Lbl_Nro_Calendario_Vac.Size = new System.Drawing.Size(188, 13);
            this.Lbl_Nro_Calendario_Vac.TabIndex = 63;
            this.Lbl_Nro_Calendario_Vac.Text = "Número de calendario de vacunación:";
            // 
            // Lbl_Nro_Historia_Clinica
            // 
            this.Lbl_Nro_Historia_Clinica.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica.Location = new System.Drawing.Point(27, 33);
            this.Lbl_Nro_Historia_Clinica.Name = "Lbl_Nro_Historia_Clinica";
            this.Lbl_Nro_Historia_Clinica.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Nro_Historia_Clinica.TabIndex = 62;
            this.Lbl_Nro_Historia_Clinica.Text = "Número de historia clínica:";
            // 
            // Lbl_Nro_Detalle
            // 
            this.Lbl_Nro_Detalle.AutoSize = true;
            this.Lbl_Nro_Detalle.Location = new System.Drawing.Point(27, 108);
            this.Lbl_Nro_Detalle.Name = "Lbl_Nro_Detalle";
            this.Lbl_Nro_Detalle.Size = new System.Drawing.Size(121, 13);
            this.Lbl_Nro_Detalle.TabIndex = 80;
            this.Lbl_Nro_Detalle.Text = "Número de vacunación:";
            // 
            // Lbl_Nro_Det
            // 
            this.Lbl_Nro_Det.AutoSize = true;
            this.Lbl_Nro_Det.Location = new System.Drawing.Point(242, 108);
            this.Lbl_Nro_Det.Name = "Lbl_Nro_Det";
            this.Lbl_Nro_Det.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Nro_Det.TabIndex = 81;
            // 
            // Lbl_Fecha_Prev
            // 
            this.Lbl_Fecha_Prev.AutoSize = true;
            this.Lbl_Fecha_Prev.Location = new System.Drawing.Point(242, 218);
            this.Lbl_Fecha_Prev.Name = "Lbl_Fecha_Prev";
            this.Lbl_Fecha_Prev.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Fecha_Prev.TabIndex = 82;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = this.empleados;
            this.empleadosBindingSource.Position = 0;
            // 
            // eMPLEADOSBindingSource1
            // 
            this.eMPLEADOSBindingSource1.DataMember = "EMPLEADOS";
            this.eMPLEADOSBindingSource1.DataSource = this.empleadosBindingSource;
            // 
            // eMPLEADOSTableAdapter
            // 
            this.eMPLEADOSTableAdapter.ClearBeforeFill = true;
            // 
            // Lbl_ID_Vac
            // 
            this.Lbl_ID_Vac.AutoSize = true;
            this.Lbl_ID_Vac.Location = new System.Drawing.Point(242, 147);
            this.Lbl_ID_Vac.Name = "Lbl_ID_Vac";
            this.Lbl_ID_Vac.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ID_Vac.TabIndex = 83;
            // 
            // Frm_Modificar_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.Lbl_ID_Vac);
            this.Controls.Add(this.Lbl_Fecha_Prev);
            this.Controls.Add(this.Lbl_Nro_Det);
            this.Controls.Add(this.Lbl_Nro_Detalle);
            this.Controls.Add(this.Lbl_Nro_CV);
            this.Controls.Add(this.Lbl_Nro_HC);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Txt_Dosis);
            this.Controls.Add(this.Dtp_Fecha_Real);
            this.Controls.Add(this.Cmb_Empleado);
            this.Controls.Add(this.Lbl_Dosis);
            this.Controls.Add(this.LBL_Empleado);
            this.Controls.Add(this.Lbl_Fecha_Prevista);
            this.Controls.Add(this.Lbl_Fecha_Real);
            this.Controls.Add(this.Lbl_Vacuna);
            this.Controls.Add(this.Lbl_Nro_Calendario_Vac);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica);
            this.Name = "Frm_Modificar_Detalle";
            this.Text = "Registrar vacunación confirmada";
            this.Load += new System.EventHandler(this.Frm_Modificar_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Nro_CV;
        private System.Windows.Forms.Label Lbl_Nro_HC;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.TextBox Txt_Dosis;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Real;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.Label Lbl_Dosis;
        private System.Windows.Forms.Label LBL_Empleado;
        private System.Windows.Forms.Label Lbl_Fecha_Prevista;
        private System.Windows.Forms.Label Lbl_Fecha_Real;
        private System.Windows.Forms.Label Lbl_Vacuna;
        private System.Windows.Forms.Label Lbl_Nro_Calendario_Vac;
        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica;
        private System.Windows.Forms.Label Lbl_Nro_Detalle;
        private System.Windows.Forms.Label Lbl_Nro_Det;
        private System.Windows.Forms.Label Lbl_Fecha_Prev;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private WindowsFormsApp1.Empleados empleados;
        private System.Windows.Forms.BindingSource eMPLEADOSBindingSource1;
        private EmpleadosTableAdapters.EMPLEADOSTableAdapter eMPLEADOSTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource2;
        private System.Windows.Forms.Label Lbl_ID_Vac;
    }
}