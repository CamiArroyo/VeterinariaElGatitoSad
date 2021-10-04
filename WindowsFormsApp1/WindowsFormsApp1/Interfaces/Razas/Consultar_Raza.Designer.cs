
namespace WindowsFormsApp1.Interfaces.Razas
{
    partial class Frm_Consultar_Raza
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
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Dgv_Consultar_Razas = new System.Windows.Forms.DataGridView();
            this.idrazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesomedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturamediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet4 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet4();
            this.rAZASTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet4TableAdapters.RAZASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Razas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(493, 31);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Modificar.TabIndex = 7;
            this.Btn_Modificar.Text = "Modificar raza";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(493, 335);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(115, 44);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar.Location = new System.Drawing.Point(493, 94);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar raza";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Dgv_Consultar_Razas
            // 
            this.Dgv_Consultar_Razas.AllowUserToAddRows = false;
            this.Dgv_Consultar_Razas.AutoGenerateColumns = false;
            this.Dgv_Consultar_Razas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Razas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrazaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idespecieDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.pesomedioDataGridViewTextBoxColumn,
            this.alturamediaDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Razas.DataSource = this.rAZASBindingSource;
            this.Dgv_Consultar_Razas.Location = new System.Drawing.Point(23, 31);
            this.Dgv_Consultar_Razas.Name = "Dgv_Consultar_Razas";
            this.Dgv_Consultar_Razas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Razas.Size = new System.Drawing.Size(441, 283);
            this.Dgv_Consultar_Razas.TabIndex = 4;
            // 
            // idrazaDataGridViewTextBoxColumn
            // 
            this.idrazaDataGridViewTextBoxColumn.DataPropertyName = "id_raza";
            this.idrazaDataGridViewTextBoxColumn.HeaderText = "id_raza";
            this.idrazaDataGridViewTextBoxColumn.Name = "idrazaDataGridViewTextBoxColumn";
            this.idrazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // idespecieDataGridViewTextBoxColumn
            // 
            this.idespecieDataGridViewTextBoxColumn.DataPropertyName = "id_especie";
            this.idespecieDataGridViewTextBoxColumn.HeaderText = "id_especie";
            this.idespecieDataGridViewTextBoxColumn.Name = "idespecieDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // pesomedioDataGridViewTextBoxColumn
            // 
            this.pesomedioDataGridViewTextBoxColumn.DataPropertyName = "peso_medio";
            this.pesomedioDataGridViewTextBoxColumn.HeaderText = "peso_medio";
            this.pesomedioDataGridViewTextBoxColumn.Name = "pesomedioDataGridViewTextBoxColumn";
            // 
            // alturamediaDataGridViewTextBoxColumn
            // 
            this.alturamediaDataGridViewTextBoxColumn.DataPropertyName = "altura_media";
            this.alturamediaDataGridViewTextBoxColumn.HeaderText = "altura_media";
            this.alturamediaDataGridViewTextBoxColumn.Name = "alturamediaDataGridViewTextBoxColumn";
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
            // rAZASTableAdapter
            // 
            this.rAZASTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Consultar_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Dgv_Consultar_Razas);
            this.Name = "Frm_Consultar_Raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar razas";
            this.Load += new System.EventHandler(this.Frm_Consultar_Raza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Razas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAZASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Razas;
        private _PAV_3K2_2021_12DataSet4 _PAV_3K2_2021_12DataSet4;
        private System.Windows.Forms.BindingSource rAZASBindingSource;
        private _PAV_3K2_2021_12DataSet4TableAdapters.RAZASTableAdapter rAZASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesomedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alturamediaDataGridViewTextBoxColumn;
    }
}