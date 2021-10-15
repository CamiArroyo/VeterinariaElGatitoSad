
namespace WindowsFormsApp1.Interfaces.Detalle_Calendario_Vac
{
    partial class Frm_Consultar_Detalle_Calendario_Vac
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
            this.Dgv_Consultar_Detalle_Calendario_Vac = new System.Windows.Forms.DataGridView();
            this.dETALLECALENDARIOVACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PAV_3K2_2021_12DataSet12 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet12();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dETALLE_CALENDARIO_VACTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet12TableAdapters.DETALLE_CALENDARIO_VACTableAdapter();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Detalle_Calendario_Vac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLECALENDARIOVACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Consultar_Detalle_Calendario_Vac
            // 
            this.Dgv_Consultar_Detalle_Calendario_Vac.AllowUserToAddRows = false;
            this.Dgv_Consultar_Detalle_Calendario_Vac.AllowUserToDeleteRows = false;
            this.Dgv_Consultar_Detalle_Calendario_Vac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consultar_Detalle_Calendario_Vac.Location = new System.Drawing.Point(26, 34);
            this.Dgv_Consultar_Detalle_Calendario_Vac.Name = "Dgv_Consultar_Detalle_Calendario_Vac";
            this.Dgv_Consultar_Detalle_Calendario_Vac.ReadOnly = true;
            this.Dgv_Consultar_Detalle_Calendario_Vac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Consultar_Detalle_Calendario_Vac.Size = new System.Drawing.Size(695, 350);
            this.Dgv_Consultar_Detalle_Calendario_Vac.TabIndex = 14;
            // 
            // dETALLECALENDARIOVACBindingSource
            // 
            this.dETALLECALENDARIOVACBindingSource.DataMember = "DETALLE_CALENDARIO_VAC";
            this.dETALLECALENDARIOVACBindingSource.DataSource = this._PAV_3K2_2021_12DataSet12;
            // 
            // _PAV_3K2_2021_12DataSet12
            // 
            this._PAV_3K2_2021_12DataSet12.DataSetName = "_PAV_3K2_2021_12DataSet12";
            this._PAV_3K2_2021_12DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Pets_Multicolor;
            this.pictureBox2.Location = new System.Drawing.Point(-30, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(788, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(775, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 556);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dETALLE_CALENDARIO_VACTableAdapter
            // 
            this.dETALLE_CALENDARIO_VACTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(787, 476);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Consultar_Detalle_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(944, 542);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Dgv_Consultar_Detalle_Calendario_Vac);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Consultar_Detalle_Calendario_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar detalle de calendario de vacunación";
            this.Load += new System.EventHandler(this.Frm_Consultar_Detalle_Calendario_Vac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consultar_Detalle_Calendario_Vac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dETALLECALENDARIOVACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv_Consultar_Detalle_Calendario_Vac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _PAV_3K2_2021_12DataSet12 _PAV_3K2_2021_12DataSet12;
        private System.Windows.Forms.BindingSource dETALLECALENDARIOVACBindingSource;
        private _PAV_3K2_2021_12DataSet12TableAdapters.DETALLE_CALENDARIO_VACTableAdapter dETALLE_CALENDARIO_VACTableAdapter;
        private System.Windows.Forms.Button Btn_Salir;
    }
}