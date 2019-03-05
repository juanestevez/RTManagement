namespace RT_Management
{
    partial class frmUsuariosPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosPortal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolAgregarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.activosToolStripMenuItemActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItemVerTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtEstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.LayoutPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregarUsuario,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolAgregarUsuario
            // 
            this.toolAgregarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolAgregarUsuario.Image")));
            this.toolAgregarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAgregarUsuario.Name = "toolAgregarUsuario";
            this.toolAgregarUsuario.Size = new System.Drawing.Size(23, 22);
            this.toolAgregarUsuario.Text = "Agregar usuario";
            this.toolAgregarUsuario.Click += new System.EventHandler(this.ToolAgregarUsuario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItemActivos,
            this.verTodoToolStripMenuItemVerTodo});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Listado de usuarios";
            // 
            // activosToolStripMenuItemActivos
            // 
            this.activosToolStripMenuItemActivos.Name = "activosToolStripMenuItemActivos";
            this.activosToolStripMenuItemActivos.Size = new System.Drawing.Size(180, 22);
            this.activosToolStripMenuItemActivos.Text = "Activos";
            this.activosToolStripMenuItemActivos.Click += new System.EventHandler(this.ActivosToolStripMenuItemActivos_Click);
            // 
            // verTodoToolStripMenuItemVerTodo
            // 
            this.verTodoToolStripMenuItemVerTodo.Name = "verTodoToolStripMenuItemVerTodo";
            this.verTodoToolStripMenuItemVerTodo.Size = new System.Drawing.Size(180, 22);
            this.verTodoToolStripMenuItemVerTodo.Text = "Ver todo";
            this.verTodoToolStripMenuItemVerTodo.Click += new System.EventHandler(this.VerTodoToolStripMenuItemVerTodo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtEstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(44, 17);
            this.txtEstatus.Text = "Estatus";
            // 
            // LayoutPrincipal
            // 
            this.LayoutPrincipal.ColumnCount = 1;
            this.LayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPrincipal.Controls.Add(this.gridUsuarios, 0, 1);
            this.LayoutPrincipal.Controls.Add(this.groupBox1, 0, 0);
            this.LayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPrincipal.Location = new System.Drawing.Point(0, 25);
            this.LayoutPrincipal.Name = "LayoutPrincipal";
            this.LayoutPrincipal.RowCount = 2;
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.LayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPrincipal.Size = new System.Drawing.Size(684, 342);
            this.LayoutPrincipal.TabIndex = 2;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.AllowUserToOrderColumns = true;
            this.gridUsuarios.AllowUserToResizeRows = false;
            this.gridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsuarios.Location = new System.Drawing.Point(3, 53);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowHeadersVisible = false;
            this.gridUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridUsuarios.Size = new System.Drawing.Size(678, 286);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarNombre);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(373, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(60, 17);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(306, 20);
            this.txtBuscarNombre.TabIndex = 0;
            // 
            // frmUsuariosPortal
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.LayoutPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuariosPortal";
            this.Text = "Usuarios portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.LayoutPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolAgregarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtEstatus;
        private System.Windows.Forms.TableLayoutPanel LayoutPrincipal;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItemActivos;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItemVerTodo;
        private System.Windows.Forms.Button btnBuscar;
    }
}