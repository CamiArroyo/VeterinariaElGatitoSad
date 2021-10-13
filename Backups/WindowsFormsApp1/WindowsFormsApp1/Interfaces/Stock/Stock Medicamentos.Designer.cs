
namespace WindowsFormsApp1.Interfaces.Stock
{
    partial class Frm_Stock_Medicamentos
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
            this.DataGrd_Stock_med = new System.Windows.Forms.DataGridView();
            this._PAV_3K2_2021_12DataSet10 = new WindowsFormsApp1._PAV_3K2_2021_12DataSet10();
            this.mEDICAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAMENTOSTableAdapter = new WindowsFormsApp1._PAV_3K2_2021_12DataSet10TableAdapters.MEDICAMENTOSTableAdapter();
            this.Txt_Buscar_Medicamento = new System.Windows.Forms.TextBox();
            this.btn_Busqueda_Medicamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ultima_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_en_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Añadir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Txt_Añadir = new System.Windows.Forms.TextBox();
            this.Txt_Quitar = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Stock_med)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrd_Stock_med
            // 
            this.DataGrd_Stock_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrd_Stock_med.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_medicamento,
            this.nombre,
            this.descripcion,
            this.id_laboratorio,
            this.fecha_ultima_compra,
            this.cantidad_en_stock});
            this.DataGrd_Stock_med.Location = new System.Drawing.Point(-2, 87);
            this.DataGrd_Stock_med.MultiSelect = false;
            this.DataGrd_Stock_med.Name = "DataGrd_Stock_med";
            this.DataGrd_Stock_med.Size = new System.Drawing.Size(644, 264);
            this.DataGrd_Stock_med.TabIndex = 0;
            this.DataGrd_Stock_med.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _PAV_3K2_2021_12DataSet10
            // 
            this._PAV_3K2_2021_12DataSet10.DataSetName = "_PAV_3K2_2021_12DataSet10";
            this._PAV_3K2_2021_12DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICAMENTOSBindingSource
            // 
            this.mEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS";
            this.mEDICAMENTOSBindingSource.DataSource = this._PAV_3K2_2021_12DataSet10;
            // 
            // mEDICAMENTOSTableAdapter
            // 
            this.mEDICAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_Buscar_Medicamento
            // 
            this.Txt_Buscar_Medicamento.Location = new System.Drawing.Point(139, 38);
            this.Txt_Buscar_Medicamento.Name = "Txt_Buscar_Medicamento";
            this.Txt_Buscar_Medicamento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Buscar_Medicamento.TabIndex = 1;
            // 
            // btn_Busqueda_Medicamento
            // 
            this.btn_Busqueda_Medicamento.Location = new System.Drawing.Point(255, 36);
            this.btn_Busqueda_Medicamento.Name = "btn_Busqueda_Medicamento";
            this.btn_Busqueda_Medicamento.Size = new System.Drawing.Size(75, 23);
            this.btn_Busqueda_Medicamento.TabIndex = 2;
            this.btn_Busqueda_Medicamento.Text = "Buscar";
            this.btn_Busqueda_Medicamento.UseVisualStyleBackColor = true;
            this.btn_Busqueda_Medicamento.Click += new System.EventHandler(this.btn_Busqueda_Medicamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id_medicamento
            // 
            this.id_medicamento.HeaderText = "ID medicamento";
            this.id_medicamento.Name = "id_medicamento";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // id_laboratorio
            // 
            this.id_laboratorio.HeaderText = "Laboratorio";
            this.id_laboratorio.Name = "id_laboratorio";
            // 
            // fecha_ultima_compra
            // 
            this.fecha_ultima_compra.HeaderText = "Fecha Ultima Compra";
            this.fecha_ultima_compra.Name = "fecha_ultima_compra";
            // 
            // cantidad_en_stock
            // 
            this.cantidad_en_stock.HeaderText = "stock";
            this.cantidad_en_stock.Name = "cantidad_en_stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(640, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 476);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_Añadir
            // 
            this.Btn_Añadir.Location = new System.Drawing.Point(648, 97);
            this.Btn_Añadir.Name = "Btn_Añadir";
            this.Btn_Añadir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Añadir.TabIndex = 5;
            this.Btn_Añadir.Text = "Añadir al Stock";
            this.Btn_Añadir.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.favpng_medicine_health_care_clinic;
            this.pictureBox2.InitialImage = global::WindowsFormsApp1.Properties.Resources.favpng_medicine_health_care_clinic;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(658, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.Location = new System.Drawing.Point(648, 224);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(145, 40);
            this.Btn_Quitar.TabIndex = 7;
            this.Btn_Quitar.Text = "Quitar del Stock";
            this.Btn_Quitar.UseVisualStyleBackColor = true;
            // 
            // Txt_Añadir
            // 
            this.Txt_Añadir.Location = new System.Drawing.Point(672, 143);
            this.Txt_Añadir.Name = "Txt_Añadir";
            this.Txt_Añadir.Size = new System.Drawing.Size(100, 20);
            this.Txt_Añadir.TabIndex = 8;
            // 
            // Txt_Quitar
            // 
            this.Txt_Quitar.Location = new System.Drawing.Point(672, 270);
            this.Txt_Quitar.Name = "Txt_Quitar";
            this.Txt_Quitar.Size = new System.Drawing.Size(100, 20);
            this.Txt_Quitar.TabIndex = 9;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(648, 387);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 10;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Stock_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txt_Quitar);
            this.Controls.Add(this.Txt_Añadir);
            this.Controls.Add(this.Btn_Quitar);
            this.Controls.Add(this.Btn_Añadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Busqueda_Medicamento);
            this.Controls.Add(this.Txt_Buscar_Medicamento);
            this.Controls.Add(this.DataGrd_Stock_med);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Frm_Stock_Medicamentos";
            this.Text = "Stock Medicamento";
            this.Load += new System.EventHandler(this.Frm_Stock_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Stock_med)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PAV_3K2_2021_12DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrd_Stock_med;
        private _PAV_3K2_2021_12DataSet10 _PAV_3K2_2021_12DataSet10;
        private System.Windows.Forms.BindingSource mEDICAMENTOSBindingSource;
        private _PAV_3K2_2021_12DataSet10TableAdapters.MEDICAMENTOSTableAdapter mEDICAMENTOSTableAdapter;
        private System.Windows.Forms.TextBox Txt_Buscar_Medicamento;
        private System.Windows.Forms.Button btn_Busqueda_Medicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ultima_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_en_stock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Añadir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Quitar;
        private System.Windows.Forms.TextBox Txt_Añadir;
        private System.Windows.Forms.TextBox Txt_Quitar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}