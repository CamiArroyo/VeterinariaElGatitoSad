
namespace WindowsFormsApp1.Interfaces.Diagnosticos
{
    partial class Frm_Consultar_Diagnosticos
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
            this.Dgv_Consultar_Diagnosticos = new System.Windows.Forms.DataGridView();
            this.iddiagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAGNOSTICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet3 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet3();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.dIAGNOSTICOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet3TableAdapters.DIAGNOSTICOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Diagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSTICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Consultar_Diagnosticos
            // 
            this.Dgv_Consultar_Diagnosticos.AllowUserToAddRows = false;
            this.Dgv_Consultar_Diagnosticos.AutoGenerateColumns = false;
            this.Dgv_Consultar_Diagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Diagnosticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddiagnosticoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.Dgv_Consultar_Diagnosticos.DataSource = this.dIAGNOSTICOSBindingSource;
            this.Dgv_Consultar_Diagnosticos.Location = new System.Drawing.Point(27, 33);
            this.Dgv_Consultar_Diagnosticos.Name = "Dgv_Consultar_Diagnosticos";
            this.Dgv_Consultar_Diagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Diagnosticos.Size = new System.Drawing.Size(441, 283);
            this.Dgv_Consultar_Diagnosticos.TabIndex = 0;
            // 
            // iddiagnosticoDataGridViewTextBoxColumn
            // 
            this.iddiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "id_diagnostico";
            this.iddiagnosticoDataGridViewTextBoxColumn.HeaderText = "id_diagnostico";
            this.iddiagnosticoDataGridViewTextBoxColumn.Name = "iddiagnosticoDataGridViewTextBoxColumn";
            this.iddiagnosticoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // dIAGNOSTICOSBindingSource
            // 
            this.dIAGNOSTICOSBindingSource.DataMember = "DIAGNOSTICOS";
            this.dIAGNOSTICOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet3;
            // 
            // _PAV_3K2_2021_12DataSet3
            // 
            this._PAV_3K2_2021_12DataSet3.DataSetName = "_PAV_3K2_2021_12DataSet3";
            this._PAV_3K2_2021_12DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(493, 33);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Modificar.TabIndex = 6;
            this.Btn_Modificar.Text = "Modificar diagnóstico";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(493, 334);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(115, 44);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Eliminar.Location = new System.Drawing.Point(493, 96);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(115, 44);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.Text = "Eliminar diagnóstico";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // dIAGNOSTICOSTableAdapter
            // 
            this.dIAGNOSTICOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Consultar_Diagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(635, 396);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Dgv_Consultar_Diagnosticos);
            this.Name = "Frm_Consultar_Diagnosticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar diagnosticos";
            this.Load += new System.EventHandler(this.Frm_Consultar_Diagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Diagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSTICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Consultar_Diagnosticos;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Eliminar;
        private _PAV_3K2_2021_12DataSet3 _PAV_3K2_2021_12DataSet3;
        private System.Windows.Forms.BindingSource dIAGNOSTICOSBindingSource;
        private _PAV_3K2_2021_12DataSet3TableAdapters.DIAGNOSTICOSTableAdapter dIAGNOSTICOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}