namespace RT_Management
{
    partial class frmPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendientes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupLista = new System.Windows.Forms.GroupBox();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.txtPlatinum = new System.Windows.Forms.MaskedTextBox();
            this.txtGrupo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.herramientasMod = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRealizada = new System.Windows.Forms.ToolStripButton();
            this.barraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnNuevaTarea = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.herramientasMod.SuspendLayout();
            this.barraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupLista, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.barraHerramientas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupLista
            // 
            this.groupLista.Controls.Add(this.gridDatos);
            this.groupLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLista.Location = new System.Drawing.Point(3, 28);
            this.groupLista.Name = "groupLista";
            this.groupLista.Size = new System.Drawing.Size(748, 306);
            this.groupLista.TabIndex = 0;
            this.groupLista.TabStop = false;
            this.groupLista.Text = "Pendientes para el día 00/00/0000";
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(3, 16);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridDatos.Size = new System.Drawing.Size(742, 287);
            this.gridDatos.TabIndex = 0;
            this.gridDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellEnter);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.txtPlatinum);
            this.groupInfo.Controls.Add(this.txtGrupo);
            this.groupInfo.Controls.Add(this.label6);
            this.groupInfo.Controls.Add(this.txtComentarios);
            this.groupInfo.Controls.Add(this.txtSolicitante);
            this.groupInfo.Controls.Add(this.txtVin);
            this.groupInfo.Controls.Add(this.txtTitular);
            this.groupInfo.Controls.Add(this.label5);
            this.groupInfo.Controls.Add(this.label4);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.herramientasMod);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Location = new System.Drawing.Point(3, 340);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(748, 128);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.TabStop = false;
            // 
            // txtPlatinum
            // 
            this.txtPlatinum.Enabled = false;
            this.txtPlatinum.Location = new System.Drawing.Point(79, 107);
            this.txtPlatinum.Mask = "00>L0000000";
            this.txtPlatinum.Name = "txtPlatinum";
            this.txtPlatinum.Size = new System.Drawing.Size(100, 20);
            this.txtPlatinum.TabIndex = 2;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(79, 74);
            this.txtGrupo.Mask = "0000-000";
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtGrupo.TabIndex = 1;
            this.txtGrupo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Comentarios:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.AcceptsReturn = true;
            this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentarios.Enabled = false;
            this.txtComentarios.Location = new System.Drawing.Point(411, 60);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(328, 67);
            this.txtComentarios.TabIndex = 5;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolicitante.Enabled = false;
            this.txtSolicitante.Location = new System.Drawing.Point(250, 107);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(152, 20);
            this.txtSolicitante.TabIndex = 4;
            // 
            // txtVin
            // 
            this.txtVin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVin.Enabled = false;
            this.txtVin.Location = new System.Drawing.Point(250, 74);
            this.txtVin.MaxLength = 17;
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(152, 20);
            this.txtVin.TabIndex = 3;
            // 
            // txtTitular
            // 
            this.txtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitular.Enabled = false;
            this.txtTitular.Location = new System.Drawing.Point(79, 44);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(323, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Solicitante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Platinum;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "VIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Titular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grupo int.:";
            // 
            // herramientasMod
            // 
            this.herramientasMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.btnRealizada});
            this.herramientasMod.Location = new System.Drawing.Point(3, 16);
            this.herramientasMod.Name = "herramientasMod";
            this.herramientasMod.Size = new System.Drawing.Size(742, 25);
            this.herramientasMod.TabIndex = 0;
            this.herramientasMod.Text = "toolStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(23, 22);
            this.btnModificar.Text = "Editar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar edición";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRealizada
            // 
            this.btnRealizada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRealizada.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizada.Image")));
            this.btnRealizada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRealizada.Name = "btnRealizada";
            this.btnRealizada.Size = new System.Drawing.Size(23, 22);
            this.btnRealizada.Text = "Marcar como terminada";
            this.btnRealizada.ToolTipText = "Marcar como terminada";
            this.btnRealizada.Click += new System.EventHandler(this.btnRealizada_Click);
            // 
            // barraHerramientas
            // 
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevaTarea,
            this.toolStripSeparator2,
            this.btnActualizar});
            this.barraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.barraHerramientas.Name = "barraHerramientas";
            this.barraHerramientas.Size = new System.Drawing.Size(754, 25);
            this.barraHerramientas.TabIndex = 2;
            this.barraHerramientas.Text = "toolStrip1";
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevaTarea.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaTarea.Image")));
            this.btnNuevaTarea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(23, 22);
            this.btnNuevaTarea.Text = "Agregar tarea pendiente";
            this.btnNuevaTarea.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de pendientes";
            this.Load += new System.EventHandler(this.frmPendientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.herramientasMod.ResumeLayout(false);
            this.herramientasMod.PerformLayout();
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupLista;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.ToolStrip barraHerramientas;
        private System.Windows.Forms.ToolStripButton btnNuevaTarea;
        private System.Windows.Forms.ToolStrip herramientasMod;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRealizada;
        private System.Windows.Forms.MaskedTextBox txtGrupo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.MaskedTextBox txtPlatinum;
    }
}