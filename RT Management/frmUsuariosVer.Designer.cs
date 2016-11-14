namespace RT_Management
{
    partial class frmUsuariosVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosVer));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolsGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolsEditar = new System.Windows.Forms.ToolStripButton();
            this.toolsCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsGuardar,
            this.toolsEditar,
            this.toolsCancelar,
            this.toolStripSeparator1,
            this.toolsSalir});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(190, 25);
            this.tools.TabIndex = 7;
            this.tools.Text = "toolStrip1";
            // 
            // toolsGuardar
            // 
            this.toolsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsGuardar.Enabled = false;
            this.toolsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolsGuardar.Image")));
            this.toolsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsGuardar.Name = "toolsGuardar";
            this.toolsGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolsGuardar.Text = "Guardar";
            this.toolsGuardar.Click += new System.EventHandler(this.toolsGuardar_Click);
            // 
            // toolsEditar
            // 
            this.toolsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolsEditar.Image")));
            this.toolsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsEditar.Name = "toolsEditar";
            this.toolsEditar.Size = new System.Drawing.Size(23, 22);
            this.toolsEditar.Text = "Editar";
            this.toolsEditar.Click += new System.EventHandler(this.toolsEditar_Click);
            // 
            // toolsCancelar
            // 
            this.toolsCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsCancelar.Enabled = false;
            this.toolsCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolsCancelar.Image")));
            this.toolsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsCancelar.Name = "toolsCancelar";
            this.toolsCancelar.Size = new System.Drawing.Size(23, 22);
            this.toolsCancelar.Text = "Cancelar";
            this.toolsCancelar.Click += new System.EventHandler(this.toolsCancelar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsSalir
            // 
            this.toolsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolsSalir.Image")));
            this.toolsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsSalir.Name = "toolsSalir";
            this.toolsSalir.Size = new System.Drawing.Size(23, 22);
            this.toolsSalir.Text = "Salir";
            this.toolsSalir.Click += new System.EventHandler(this.toolsSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(70, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(70, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(70, 90);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.Enabled = false;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboNivel.Location = new System.Drawing.Point(70, 116);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(100, 21);
            this.comboNivel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nivel:";
            // 
            // frmUsuariosVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 158);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuariosVer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vista individual";
            this.Load += new System.EventHandler(this.frmUsuariosVer_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolsGuardar;
        private System.Windows.Forms.ToolStripButton toolsEditar;
        private System.Windows.Forms.ToolStripButton toolsCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolsSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Label label4;
    }
}