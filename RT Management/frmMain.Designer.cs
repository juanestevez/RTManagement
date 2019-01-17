namespace RT_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduciblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correccionesSolicitadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.extensionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deduciblesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verModificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.respaldoBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBackupInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.enCascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apiladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.menuAdmin,
            this.menuVentana,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MdiWindowListItem = this.menuVentana;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deduciblesToolStripMenuItem,
            this.correccionesSolicitadasToolStripMenuItem,
            this.toolStripMenuItem5,
            this.pendientesToolStripMenuItem,
            this.telefonosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.extensionesToolStripMenuItem,
            this.toolStripSeparator1,
            this.estadísticasToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modulosToolStripMenuItem.Text = "&Módulos";
            // 
            // deduciblesToolStripMenuItem
            // 
            this.deduciblesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deduciblesToolStripMenuItem.Image")));
            this.deduciblesToolStripMenuItem.Name = "deduciblesToolStripMenuItem";
            this.deduciblesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deduciblesToolStripMenuItem.Text = "Deducibles";
            this.deduciblesToolStripMenuItem.Click += new System.EventHandler(this.deduciblesToolStripMenuItem_Click);
            // 
            // correccionesSolicitadasToolStripMenuItem
            // 
            this.correccionesSolicitadasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("correccionesSolicitadasToolStripMenuItem.Image")));
            this.correccionesSolicitadasToolStripMenuItem.Name = "correccionesSolicitadasToolStripMenuItem";
            this.correccionesSolicitadasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.correccionesSolicitadasToolStripMenuItem.Text = "Correcciones solicitadas";
            this.correccionesSolicitadasToolStripMenuItem.Click += new System.EventHandler(this.correccionesSolicitadasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(198, 6);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pendientesToolStripMenuItem.Image")));
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.pendientesToolStripMenuItem.Text = "Lista de pendientes";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // telefonosToolStripMenuItem
            // 
            this.telefonosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("telefonosToolStripMenuItem.Image")));
            this.telefonosToolStripMenuItem.Name = "telefonosToolStripMenuItem";
            this.telefonosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.telefonosToolStripMenuItem.Text = "Solicitud de teléfonos";
            this.telefonosToolStripMenuItem.Visible = false;
            this.telefonosToolStripMenuItem.Click += new System.EventHandler(this.telefonosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            this.toolStripMenuItem2.Visible = false;
            // 
            // extensionesToolStripMenuItem
            // 
            this.extensionesToolStripMenuItem.Name = "extensionesToolStripMenuItem";
            this.extensionesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.extensionesToolStripMenuItem.Text = "Directorio";
            this.extensionesToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estadísticasToolStripMenuItem.Image")));
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            this.estadísticasToolStripMenuItem.Click += new System.EventHandler(this.estadísticasToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deduciblesToolStripMenuItem1,
            this.verModificacionesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.respaldoBDToolStripMenuItem});
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(95, 20);
            this.menuAdmin.Text = "A&dministrador";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // deduciblesToolStripMenuItem1
            // 
            this.deduciblesToolStripMenuItem1.Name = "deduciblesToolStripMenuItem1";
            this.deduciblesToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.deduciblesToolStripMenuItem1.Text = "Deducibles";
            this.deduciblesToolStripMenuItem1.Click += new System.EventHandler(this.deduciblesToolStripMenuItem1_Click);
            // 
            // verModificacionesToolStripMenuItem
            // 
            this.verModificacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verModificacionesToolStripMenuItem.Image")));
            this.verModificacionesToolStripMenuItem.Name = "verModificacionesToolStripMenuItem";
            this.verModificacionesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.verModificacionesToolStripMenuItem.Text = "Ver modificaciones";
            this.verModificacionesToolStripMenuItem.Click += new System.EventHandler(this.verModificacionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 6);
            // 
            // respaldoBDToolStripMenuItem
            // 
            this.respaldoBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBackupInfo});
            this.respaldoBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("respaldoBDToolStripMenuItem.Image")));
            this.respaldoBDToolStripMenuItem.Name = "respaldoBDToolStripMenuItem";
            this.respaldoBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.respaldoBDToolStripMenuItem.Text = "Respaldo BD";
            // 
            // menuBackupInfo
            // 
            this.menuBackupInfo.Image = ((System.Drawing.Image)(resources.GetObject("menuBackupInfo.Image")));
            this.menuBackupInfo.Name = "menuBackupInfo";
            this.menuBackupInfo.Size = new System.Drawing.Size(142, 22);
            this.menuBackupInfo.Text = "Información";
            this.menuBackupInfo.Click += new System.EventHandler(this.menuBackupInfo_Click);
            // 
            // menuVentana
            // 
            this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enCascadaToolStripMenuItem,
            this.apiladasToolStripMenuItem,
            this.enParaleloToolStripMenuItem});
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(61, 20);
            this.menuVentana.Text = "&Ventana";
            // 
            // enCascadaToolStripMenuItem
            // 
            this.enCascadaToolStripMenuItem.Name = "enCascadaToolStripMenuItem";
            this.enCascadaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.enCascadaToolStripMenuItem.Text = "En cascada";
            this.enCascadaToolStripMenuItem.Click += new System.EventHandler(this.enCascadaToolStripMenuItem_Click);
            // 
            // apiladasToolStripMenuItem
            // 
            this.apiladasToolStripMenuItem.Name = "apiladasToolStripMenuItem";
            this.apiladasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.apiladasToolStripMenuItem.Text = "Apiladas";
            this.apiladasToolStripMenuItem.Click += new System.EventHandler(this.apiladasToolStripMenuItem_Click);
            // 
            // enParaleloToolStripMenuItem
            // 
            this.enParaleloToolStripMenuItem.Name = "enParaleloToolStripMenuItem";
            this.enParaleloToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.enParaleloToolStripMenuItem.Text = "En paralelo";
            this.enParaleloToolStripMenuItem.Click += new System.EventHandler(this.enParaleloToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // barraEstado
            // 
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser});
            this.barraEstado.Location = new System.Drawing.Point(0, 540);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(784, 22);
            this.barraEstado.SizingGrip = false;
            this.barraEstado.TabIndex = 1;
            this.barraEstado.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 17);
            this.lblUser.Text = "Usuario.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduciblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVentana;
        private System.Windows.Forms.ToolStripMenuItem enCascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apiladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem extensionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deduciblesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verModificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem respaldoBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBackupInfo;
        private System.Windows.Forms.ToolStripMenuItem correccionesSolicitadasToolStripMenuItem;
    }
}