
namespace WindowsFormsApp1.Interfaces.Sintomas
{
    partial class Frm_Consultar_Sintoma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vacunas = new WindowsFormsApp1.Vacunas();
            this.vACUNASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vACUNASTableAdapter = new WindowsFormsApp1.VacunasTableAdapters.VACUNASTableAdapter();
            this.sintomas = new WindowsFormsApp1.Sintomas();
            this.sINTOMASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINTOMASTableAdapter = new WindowsFormsApp1.SintomasTableAdapters.SINTOMASTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Modificar_Sintoma = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sintomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINTOMASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vacunas
            // 
            this.vacunas.DataSetName = "Vacunas";
            this.vacunas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vACUNASBindingSource
            // 
            this.vACUNASBindingSource.DataMember = "VACUNAS";
            this.vACUNASBindingSource.DataSource = this.vacunas;
            // 
            // vACUNASTableAdapter
            // 
            this.vACUNASTableAdapter.ClearBeforeFill = true;
            // 
            // sintomas
            // 
            this.sintomas.DataSetName = "Sintomas";
            this.sintomas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINTOMASBindingSource
            // 
            this.sINTOMASBindingSource.DataMember = "SINTOMAS";
            this.sINTOMASBindingSource.DataSource = this.sintomas;
            // 
            // sINTOMASTableAdapter
            // 
            this.sINTOMASTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sINTOMASBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 400F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 300;
            // 
            // Btn_Modificar_Sintoma
            // 
            this.Btn_Modificar_Sintoma.Location = new System.Drawing.Point(25, 370);
            this.Btn_Modificar_Sintoma.Name = "Btn_Modificar_Sintoma";
            this.Btn_Modificar_Sintoma.Size = new System.Drawing.Size(121, 42);
            this.Btn_Modificar_Sintoma.TabIndex = 1;
            this.Btn_Modificar_Sintoma.Text = "Editar Sintoma";
            this.Btn_Modificar_Sintoma.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(345, 373);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(121, 39);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Consultar_Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(497, 453);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar_Sintoma);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_Consultar_Sintoma";
            this.Text = "Sintomas";
            this.Load += new System.EventHandler(this.Frm_Consultar_Sintoma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vACUNASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sintomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINTOMASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Vacunas vacunas;
        private System.Windows.Forms.BindingSource vACUNASBindingSource;
        private VacunasTableAdapters.VACUNASTableAdapter vACUNASTableAdapter;
        private WindowsFormsApp1.Sintomas sintomas;
        private System.Windows.Forms.BindingSource sINTOMASBindingSource;
        private SintomasTableAdapters.SINTOMASTableAdapter sINTOMASTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_Modificar_Sintoma;
        private System.Windows.Forms.Button Btn_Salir;
    }
}