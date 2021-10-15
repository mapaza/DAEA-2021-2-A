
namespace Lab02_01
{
    partial class PrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalirDelSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcRegistrarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcRegistrarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteDeVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteDeCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnumnuRepReporteDeUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalirDelSistema});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSisSalirDelSistema
            // 
            this.mnuSisSalirDelSistema.DoubleClickEnabled = true;
            this.mnuSisSalirDelSistema.Name = "mnuSisSalirDelSistema";
            this.mnuSisSalirDelSistema.Size = new System.Drawing.Size(202, 26);
            this.mnuSisSalirDelSistema.Text = "Salir del Sistema";
            this.mnuSisSalirDelSistema.Click += new System.EventHandler(this.mnuSisSalirDelSistema_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes,
            this.cargosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorías";
            this.mnuManCategorias.Click += new System.EventHandler(this.mnuManCategorias_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcRegistrarVentas,
            this.mnuProcRegistrarCompras});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProcRegistrarVentas
            // 
            this.mnuProcRegistrarVentas.Name = "mnuProcRegistrarVentas";
            this.mnuProcRegistrarVentas.Size = new System.Drawing.Size(214, 26);
            this.mnuProcRegistrarVentas.Text = "Registrar Ventas";
            // 
            // mnuProcRegistrarCompras
            // 
            this.mnuProcRegistrarCompras.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuProcRegistrarCompras.Name = "mnuProcRegistrarCompras";
            this.mnuProcRegistrarCompras.Size = new System.Drawing.Size(214, 26);
            this.mnuProcRegistrarCompras.Text = "Registrar Compras";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReporteDeVentas,
            this.mnuRepReporteDeCompras,
            this.mnuRepInventarioDeProductos,
            this.mnuRepReporteDeUsuarios,
            this.mnumnuRepReporteDeUsuarios,
            this.mnuRepReporteDeClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepReporteDeVentas
            // 
            this.mnuRepReporteDeVentas.Name = "mnuRepReporteDeVentas";
            this.mnuRepReporteDeVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteDeVentas.Text = "Reporte de Ventas";
            // 
            // mnuRepReporteDeCompras
            // 
            this.mnuRepReporteDeCompras.Name = "mnuRepReporteDeCompras";
            this.mnuRepReporteDeCompras.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteDeCompras.Text = "Reporte de Compras";
            // 
            // mnuRepInventarioDeProductos
            // 
            this.mnuRepInventarioDeProductos.Name = "mnuRepInventarioDeProductos";
            this.mnuRepInventarioDeProductos.Size = new System.Drawing.Size(252, 26);
            this.mnuRepInventarioDeProductos.Text = "Inventario de Productos";
            // 
            // mnuRepReporteDeUsuarios
            // 
            this.mnuRepReporteDeUsuarios.Name = "mnuRepReporteDeUsuarios";
            this.mnuRepReporteDeUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteDeUsuarios.Text = "Reporte de Proveedores";
            // 
            // mnumnuRepReporteDeUsuarios
            // 
            this.mnumnuRepReporteDeUsuarios.Name = "mnumnuRepReporteDeUsuarios";
            this.mnumnuRepReporteDeUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnumnuRepReporteDeUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuRepReporteDeClientes
            // 
            this.mnuRepReporteDeClientes.Name = "mnuRepReporteDeClientes";
            this.mnuRepReporteDeClientes.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteDeClientes.Text = "Reporte de Clientes";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(992, 694);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.PrincipalMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalirDelSistema;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcRegistrarVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuProcRegistrarCompras;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteDeVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteDeCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioDeProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnumnuRepReporteDeUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteDeClientes;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
    }
}