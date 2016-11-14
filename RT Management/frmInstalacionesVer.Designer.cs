namespace RT_Management
{
    partial class frmInstalacionesVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstalacionesVer));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolsGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolsEditar = new System.Windows.Forms.ToolStripButton();
            this.toolsCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlatinumA = new System.Windows.Forms.TextBox();
            this.txtPlatinum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVinA = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCarta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.tools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tools.Size = new System.Drawing.Size(588, 25);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPlatinumA);
            this.groupBox1.Controls.Add(this.txtPlatinum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVinA);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehículo";
            // 
            // txtCuenta
            // 
            this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.Location = new System.Drawing.Point(238, 150);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(118, 20);
            this.txtCuenta.TabIndex = 24;
            this.txtCuenta.Text = "NISSAN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(187, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Cuenta:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtGrupo.Location = new System.Drawing.Point(62, 150);
            this.txtGrupo.Mask = "9999-999";
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(118, 20);
            this.txtGrupo.TabIndex = 8;
            this.txtGrupo.Text = "1234567";
            this.txtGrupo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Grupo-Int.:";
            // 
            // txtAnio
            // 
            this.txtAnio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtAnio.Location = new System.Drawing.Point(238, 124);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(50, 20);
            this.txtAnio.TabIndex = 7;
            this.txtAnio.Text = "2013";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Año:";
            // 
            // txtColor
            // 
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Location = new System.Drawing.Point(62, 124);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(118, 20);
            this.txtColor.TabIndex = 6;
            this.txtColor.Text = "ROJO BURDEOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Color:";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(238, 98);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(118, 20);
            this.txtModelo.TabIndex = 5;
            this.txtModelo.Text = "NV350 URVAN";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(62, 98);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(118, 20);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.Text = "RENAULT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Marca:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(62, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(294, 20);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.Text = "JUAN MANUEL ESTEVEZ SAUCEDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Anterior:";
            // 
            // txtPlatinumA
            // 
            this.txtPlatinumA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlatinumA.Location = new System.Drawing.Point(238, 70);
            this.txtPlatinumA.Name = "txtPlatinumA";
            this.txtPlatinumA.Size = new System.Drawing.Size(118, 20);
            this.txtPlatinumA.TabIndex = 3;
            this.txtPlatinumA.Text = "12U1110987";
            // 
            // txtPlatinum
            // 
            this.txtPlatinum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlatinum.Location = new System.Drawing.Point(62, 70);
            this.txtPlatinum.Name = "txtPlatinum";
            this.txtPlatinum.Size = new System.Drawing.Size(118, 20);
            this.txtPlatinum.TabIndex = 2;
            this.txtPlatinum.Text = "13U2103456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anterior:";
            // 
            // txtVinA
            // 
            this.txtVinA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVinA.Location = new System.Drawing.Point(238, 45);
            this.txtVinA.Name = "txtVinA";
            this.txtVinA.Size = new System.Drawing.Size(118, 20);
            this.txtVinA.TabIndex = 1;
            this.txtVinA.Text = "3N1EB31S2EK123456";
            // 
            // txtVin
            // 
            this.txtVin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVin.Location = new System.Drawing.Point(62, 45);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(118, 20);
            this.txtVin.TabIndex = 0;
            this.txtVin.Text = "3N1EB31S2EK123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Platinum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCarta);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtActividad);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(384, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instalación";
            // 
            // txtCarta
            // 
            this.txtCarta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarta.Location = new System.Drawing.Point(62, 71);
            this.txtCarta.MaxLength = 15;
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.Size = new System.Drawing.Size(118, 20);
            this.txtCarta.TabIndex = 2;
            this.txtCarta.Text = "12345";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Carta:";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(62, 44);
            this.txtActividad.MaxLength = 20;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(118, 20);
            this.txtActividad.TabIndex = 1;
            this.txtActividad.Text = "Instalación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Actividad:";
            // 
            // txtFecha
            // 
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Location = new System.Drawing.Point(62, 18);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(118, 20);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.Text = "01/01/2000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentarios.Location = new System.Drawing.Point(384, 146);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(191, 64);
            this.txtComentarios.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Comentarios:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSolucion);
            this.groupBox3.Controls.Add(this.txtFalla);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Revisión/Garantía";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Solución:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Falla:";
            // 
            // txtSolucion
            // 
            this.txtSolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolucion.Location = new System.Drawing.Point(284, 35);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucion.Size = new System.Drawing.Size(270, 53);
            this.txtSolucion.TabIndex = 4;
            // 
            // txtFalla
            // 
            this.txtFalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFalla.Location = new System.Drawing.Point(8, 35);
            this.txtFalla.Multiline = true;
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFalla.Size = new System.Drawing.Size(270, 53);
            this.txtFalla.TabIndex = 3;
            // 
            // frmInstalacionesVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstalacionesVer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vista individual";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInstalacionesVer_KeyDown);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlatinumA;
        private System.Windows.Forms.TextBox txtPlatinum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVinA;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtGrupo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCarta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label17;
    }
}