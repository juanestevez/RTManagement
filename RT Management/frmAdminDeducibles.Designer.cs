namespace RT_Management
{
    partial class frmAdminDeducibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDeducibles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.noProcedentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.incompletosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVer = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.layoutBase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(518, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(213, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(299, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Titular",
            "Grupo/Integrante",
            "VIN",
            "Platinum"});
            this.comboFiltro.Location = new System.Drawing.Point(10, 20);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboFiltro.TabIndex = 0;
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            this.gridDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(3, 68);
            this.gridDatos.MultiSelect = false;
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.Size = new System.Drawing.Size(561, 305);
            this.gridDatos.TabIndex = 0;
            this.gridDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridDatos_CellFormatting);
            // 
            // layoutBase
            // 
            this.layoutBase.ColumnCount = 1;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.Controls.Add(this.gridDatos, 22, 1);
            this.layoutBase.Controls.Add(this.groupBox1, 0, 0);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 25);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 2;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.Size = new System.Drawing.Size(567, 376);
            this.layoutBase.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.comboFiltro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Like",
            "="});
            this.comboTipo.Location = new System.Drawing.Point(138, 20);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(69, 21);
            this.comboTipo.TabIndex = 1;
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todoToolStripMenuItem.Text = "Todo";
            this.todoToolStripMenuItem.Click += new System.EventHandler(this.todoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // noProcedentesToolStripMenuItem
            // 
            this.noProcedentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noProcedentesToolStripMenuItem.Image")));
            this.noProcedentesToolStripMenuItem.Name = "noProcedentesToolStripMenuItem";
            this.noProcedentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noProcedentesToolStripMenuItem.Text = "No procedentes";
            this.noProcedentesToolStripMenuItem.Click += new System.EventHandler(this.noProcedentesToolStripMenuItem_Click);
            // 
            // procedentesToolStripMenuItem
            // 
            this.procedentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procedentesToolStripMenuItem.Image")));
            this.procedentesToolStripMenuItem.Name = "procedentesToolStripMenuItem";
            this.procedentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procedentesToolStripMenuItem.Text = "Procedentes";
            this.procedentesToolStripMenuItem.Click += new System.EventHandler(this.procedentesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // incompletosToolStripMenuItem
            // 
            this.incompletosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incompletosToolStripMenuItem.Image")));
            this.incompletosToolStripMenuItem.Name = "incompletosToolStripMenuItem";
            this.incompletosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incompletosToolStripMenuItem.Text = "Incompletos";
            this.incompletosToolStripMenuItem.Click += new System.EventHandler(this.incompletosToolStripMenuItem_Click);
            // 
            // enProcesoToolStripMenuItem
            // 
            this.enProcesoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enProcesoToolStripMenuItem.Image")));
            this.enProcesoToolStripMenuItem.Name = "enProcesoToolStripMenuItem";
            this.enProcesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enProcesoToolStripMenuItem.Text = "En proceso";
            this.enProcesoToolStripMenuItem.Click += new System.EventHandler(this.enProcesoToolStripMenuItem_Click);
            // 
            // itemVer
            // 
            this.itemVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enProcesoToolStripMenuItem,
            this.incompletosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.procedentesToolStripMenuItem,
            this.noProcedentesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.todoToolStripMenuItem});
            this.itemVer.Image = ((System.Drawing.Image)(resources.GetObject("itemVer.Image")));
            this.itemVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemVer.Name = "itemVer";
            this.itemVer.Size = new System.Drawing.Size(32, 22);
            this.itemVer.Text = "Ver registros";
            this.itemVer.ButtonClick += new System.EventHandler(this.itemVer_ButtonClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(567, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmAdminDeducibles
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 401);
            this.Controls.Add(this.layoutBase);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(583, 439);
            this.Name = "frmAdminDeducibles";
            this.Text = "Administración de expedientes";
            this.Load += new System.EventHandler(this.frmAdminDeducibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.layoutBase.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noProcedentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem incompletosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton itemVer;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}