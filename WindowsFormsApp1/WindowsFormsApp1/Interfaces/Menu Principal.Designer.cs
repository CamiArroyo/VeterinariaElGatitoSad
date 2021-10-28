
namespace WindowsFormsApp1
{
    partial class FrmMenu_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu_Principal));
            this.Bienvenido = new System.Windows.Forms.Label();
            this.BtnMP_Salir = new System.Windows.Forms.Button();
            this.Btn_Insumos = new System.Windows.Forms.Button();
            this.Btn_Empleados = new System.Windows.Forms.Button();
            this.Btn_Sintomatologia = new System.Windows.Forms.Button();
            this.Btn_Animales = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.Btn_Listados = new System.Windows.Forms.Button();
            this.Btn_Menu_Mascotas = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especieDeMascotaMasAtendidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueñosYMascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosYMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticosYConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cantidadEnStockDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bienvenido
            // 
            this.Bienvenido.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(283, 56);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(325, 54);
            this.Bienvenido.TabIndex = 1;
            this.Bienvenido.Text = "¡¡¡Bienvenido!!!";
            this.Bienvenido.Click += new System.EventHandler(this.Bienvenido_Click);
            // 
            // BtnMP_Salir
            // 
            this.BtnMP_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMP_Salir.Location = new System.Drawing.Point(549, 447);
            this.BtnMP_Salir.Name = "BtnMP_Salir";
            this.BtnMP_Salir.Size = new System.Drawing.Size(146, 56);
            this.BtnMP_Salir.TabIndex = 2;
            this.BtnMP_Salir.Text = "Salir";
            this.BtnMP_Salir.UseVisualStyleBackColor = false;
            this.BtnMP_Salir.Click += new System.EventHandler(this.BtnMP_Salir_Click);
            // 
            // Btn_Insumos
            // 
            this.Btn_Insumos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Insumos.Location = new System.Drawing.Point(12, 135);
            this.Btn_Insumos.Name = "Btn_Insumos";
            this.Btn_Insumos.Size = new System.Drawing.Size(146, 56);
            this.Btn_Insumos.TabIndex = 6;
            this.Btn_Insumos.Text = "Insumos";
            this.Btn_Insumos.UseVisualStyleBackColor = false;
            this.Btn_Insumos.Click += new System.EventHandler(this.Btn_Insumos_Click);
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Empleados.Location = new System.Drawing.Point(12, 55);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Size = new System.Drawing.Size(146, 56);
            this.Btn_Empleados.TabIndex = 7;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.UseVisualStyleBackColor = false;
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // Btn_Sintomatologia
            // 
            this.Btn_Sintomatologia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Sintomatologia.Location = new System.Drawing.Point(12, 211);
            this.Btn_Sintomatologia.Name = "Btn_Sintomatologia";
            this.Btn_Sintomatologia.Size = new System.Drawing.Size(146, 56);
            this.Btn_Sintomatologia.TabIndex = 8;
            this.Btn_Sintomatologia.Text = "Sintomatología";
            this.Btn_Sintomatologia.UseVisualStyleBackColor = false;
            this.Btn_Sintomatologia.Click += new System.EventHandler(this.Btn_Sintomatologia_Click);
            // 
            // Btn_Animales
            // 
            this.Btn_Animales.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Animales.Location = new System.Drawing.Point(12, 289);
            this.Btn_Animales.Name = "Btn_Animales";
            this.Btn_Animales.Size = new System.Drawing.Size(146, 56);
            this.Btn_Animales.TabIndex = 9;
            this.Btn_Animales.Text = "Animales";
            this.Btn_Animales.UseVisualStyleBackColor = false;
            this.Btn_Animales.Click += new System.EventHandler(this.Btn_Animales_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Reportes.Location = new System.Drawing.Point(12, 371);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(146, 56);
            this.Btn_Reportes.TabIndex = 10;
            this.Btn_Reportes.Text = "Reportes";
            this.Btn_Reportes.UseVisualStyleBackColor = false;
            // 
            // Btn_Listados
            // 
            this.Btn_Listados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Listados.Location = new System.Drawing.Point(12, 447);
            this.Btn_Listados.Name = "Btn_Listados";
            this.Btn_Listados.Size = new System.Drawing.Size(146, 56);
            this.Btn_Listados.TabIndex = 11;
            this.Btn_Listados.Text = "Listados";
            this.Btn_Listados.UseVisualStyleBackColor = false;
            // 
            // Btn_Menu_Mascotas
            // 
            this.Btn_Menu_Mascotas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Menu_Mascotas.Location = new System.Drawing.Point(290, 147);
            this.Btn_Menu_Mascotas.Name = "Btn_Menu_Mascotas";
            this.Btn_Menu_Mascotas.Size = new System.Drawing.Size(294, 93);
            this.Btn_Menu_Mascotas.TabIndex = 12;
            this.Btn_Menu_Mascotas.Text = "Nuestras mascotas ";
            this.Btn_Menu_Mascotas.UseVisualStyleBackColor = false;
            this.Btn_Menu_Mascotas.Click += new System.EventHandler(this.button7_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.Location = new System.Drawing.Point(290, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(294, 93);
            this.button7.TabIndex = 13;
            this.button7.Text = "Nuestros clientes";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 505);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem,
            this.especieDeMascotaMasAtendidaToolStripMenuItem,
            this.usoDeMedicamentosToolStripMenuItem,
            this.cantidadEnStockDeMedicamentosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem
            // 
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Name = "cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem";
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Text = "Atencion de mascotas por empleado";
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem_Click);
            // 
            // especieDeMascotaMasAtendidaToolStripMenuItem
            // 
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Name = "especieDeMascotaMasAtendidaToolStripMenuItem";
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Text = "Especies de mascotas mas atendidas";
            // 
            // usoDeMedicamentosToolStripMenuItem
            // 
            this.usoDeMedicamentosToolStripMenuItem.Name = "usoDeMedicamentosToolStripMenuItem";
            this.usoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.usoDeMedicamentosToolStripMenuItem.Text = "Frecuencia de uso de medicamentos";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dueñosYMascotasToolStripMenuItem,
            this.laboratoriosYMedicamentosToolStripMenuItem,
            this.diagnosticosYConsultasToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // dueñosYMascotasToolStripMenuItem
            // 
            this.dueñosYMascotasToolStripMenuItem.Name = "dueñosYMascotasToolStripMenuItem";
            this.dueñosYMascotasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.dueñosYMascotasToolStripMenuItem.Text = "Dueños y mascotas";
            // 
            // laboratoriosYMedicamentosToolStripMenuItem
            // 
            this.laboratoriosYMedicamentosToolStripMenuItem.Name = "laboratoriosYMedicamentosToolStripMenuItem";
            this.laboratoriosYMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.laboratoriosYMedicamentosToolStripMenuItem.Text = "Laboratorios y medicamentos";
            // 
            // diagnosticosYConsultasToolStripMenuItem
            // 
            this.diagnosticosYConsultasToolStripMenuItem.Name = "diagnosticosYConsultasToolStripMenuItem";
            this.diagnosticosYConsultasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.diagnosticosYConsultasToolStripMenuItem.Text = "Diagnosticos y consultas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cantidadEnStockDeMedicamentosToolStripMenuItem
            // 
            this.cantidadEnStockDeMedicamentosToolStripMenuItem.Name = "cantidadEnStockDeMedicamentosToolStripMenuItem";
            this.cantidadEnStockDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.cantidadEnStockDeMedicamentosToolStripMenuItem.Text = "Cantidad en stock de medicamentos";
            this.cantidadEnStockDeMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.cantidadEnStockDeMedicamentosToolStripMenuItem_Click);
            // 
            // FrmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(716, 531);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Btn_Menu_Mascotas);
            this.Controls.Add(this.Btn_Listados);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_Animales);
            this.Controls.Add(this.Btn_Sintomatologia);
            this.Controls.Add(this.Btn_Empleados);
            this.Controls.Add(this.Btn_Insumos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnMP_Salir);
            this.Controls.Add(this.Bienvenido);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Button BtnMP_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Insumos;
        private System.Windows.Forms.Button Btn_Empleados;
        private System.Windows.Forms.Button Btn_Sintomatologia;
        private System.Windows.Forms.Button Btn_Animales;
        private System.Windows.Forms.Button Btn_Reportes;
        private System.Windows.Forms.Button Btn_Listados;
        private System.Windows.Forms.Button Btn_Menu_Mascotas;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especieDeMascotaMasAtendidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueñosYMascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosYMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticosYConsultasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cantidadEnStockDeMedicamentosToolStripMenuItem;
    }
}

