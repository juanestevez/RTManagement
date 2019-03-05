namespace RT_Management
{
    partial class frmUsuariosPortalAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosPortalAgregar));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkReporteGeneral = new System.Windows.Forms.CheckBox();
            this.checkReporteComandos = new System.Windows.Forms.CheckBox();
            this.checkLocalizacion = new System.Windows.Forms.CheckBox();
            this.check20p = new System.Windows.Forms.CheckBox();
            this.check10p = new System.Windows.Forms.CheckBox();
            this.checkInmovilizar = new System.Windows.Forms.CheckBox();
            this.checkCancelar = new System.Windows.Forms.CheckBox();
            this.checkMovilizar = new System.Windows.Forms.CheckBox();
            this.checkIndividual = new System.Windows.Forms.CheckBox();
            this.checkMasivo = new System.Windows.Forms.CheckBox();
            this.checkRastreo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaRevision = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaBaja = new System.Windows.Forms.DateTimePicker();
            this.lblBaja = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(382, 266);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(301, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkReporteGeneral);
            this.groupBox2.Controls.Add(this.checkReporteComandos);
            this.groupBox2.Controls.Add(this.checkLocalizacion);
            this.groupBox2.Controls.Add(this.check20p);
            this.groupBox2.Controls.Add(this.check10p);
            this.groupBox2.Controls.Add(this.checkInmovilizar);
            this.groupBox2.Controls.Add(this.checkCancelar);
            this.groupBox2.Controls.Add(this.checkMovilizar);
            this.groupBox2.Controls.Add(this.checkIndividual);
            this.groupBox2.Controls.Add(this.checkMasivo);
            this.groupBox2.Controls.Add(this.checkRastreo);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // checkReporteGeneral
            // 
            this.checkReporteGeneral.AutoSize = true;
            this.checkReporteGeneral.Location = new System.Drawing.Point(268, 65);
            this.checkReporteGeneral.Name = "checkReporteGeneral";
            this.checkReporteGeneral.Size = new System.Drawing.Size(102, 17);
            this.checkReporteGeneral.TabIndex = 10;
            this.checkReporteGeneral.Text = "Reporte general";
            this.checkReporteGeneral.UseVisualStyleBackColor = true;
            // 
            // checkReporteComandos
            // 
            this.checkReporteComandos.AutoSize = true;
            this.checkReporteComandos.Location = new System.Drawing.Point(268, 42);
            this.checkReporteComandos.Name = "checkReporteComandos";
            this.checkReporteComandos.Size = new System.Drawing.Size(126, 17);
            this.checkReporteComandos.TabIndex = 9;
            this.checkReporteComandos.Text = "Estado de comandos";
            this.checkReporteComandos.UseVisualStyleBackColor = true;
            // 
            // checkLocalizacion
            // 
            this.checkLocalizacion.AutoSize = true;
            this.checkLocalizacion.Location = new System.Drawing.Point(268, 19);
            this.checkLocalizacion.Name = "checkLocalizacion";
            this.checkLocalizacion.Size = new System.Drawing.Size(85, 17);
            this.checkLocalizacion.TabIndex = 8;
            this.checkLocalizacion.Text = "Localización";
            this.checkLocalizacion.UseVisualStyleBackColor = true;
            // 
            // check20p
            // 
            this.check20p.AutoSize = true;
            this.check20p.Location = new System.Drawing.Point(163, 88);
            this.check20p.Name = "check20p";
            this.check20p.Size = new System.Drawing.Size(45, 17);
            this.check20p.TabIndex = 7;
            this.check20p.Text = "20P";
            this.check20p.UseVisualStyleBackColor = true;
            // 
            // check10p
            // 
            this.check10p.AutoSize = true;
            this.check10p.Location = new System.Drawing.Point(163, 65);
            this.check10p.Name = "check10p";
            this.check10p.Size = new System.Drawing.Size(45, 17);
            this.check10p.TabIndex = 6;
            this.check10p.Text = "10P";
            this.check10p.UseVisualStyleBackColor = true;
            // 
            // checkInmovilizar
            // 
            this.checkInmovilizar.AutoSize = true;
            this.checkInmovilizar.Location = new System.Drawing.Point(163, 42);
            this.checkInmovilizar.Name = "checkInmovilizar";
            this.checkInmovilizar.Size = new System.Drawing.Size(75, 17);
            this.checkInmovilizar.TabIndex = 5;
            this.checkInmovilizar.Text = "Inmovilizar";
            this.checkInmovilizar.UseVisualStyleBackColor = true;
            // 
            // checkCancelar
            // 
            this.checkCancelar.AutoSize = true;
            this.checkCancelar.Location = new System.Drawing.Point(163, 19);
            this.checkCancelar.Name = "checkCancelar";
            this.checkCancelar.Size = new System.Drawing.Size(68, 17);
            this.checkCancelar.TabIndex = 4;
            this.checkCancelar.Text = "Cancelar";
            this.checkCancelar.UseVisualStyleBackColor = true;
            // 
            // checkMovilizar
            // 
            this.checkMovilizar.AutoSize = true;
            this.checkMovilizar.Location = new System.Drawing.Point(6, 88);
            this.checkMovilizar.Name = "checkMovilizar";
            this.checkMovilizar.Size = new System.Drawing.Size(67, 17);
            this.checkMovilizar.TabIndex = 3;
            this.checkMovilizar.Text = "Movilizar";
            this.checkMovilizar.UseVisualStyleBackColor = true;
            // 
            // checkIndividual
            // 
            this.checkIndividual.AutoSize = true;
            this.checkIndividual.Location = new System.Drawing.Point(6, 65);
            this.checkIndividual.Name = "checkIndividual";
            this.checkIndividual.Size = new System.Drawing.Size(123, 17);
            this.checkIndividual.TabIndex = 2;
            this.checkIndividual.Text = "Comandos individual";
            this.checkIndividual.UseVisualStyleBackColor = true;
            // 
            // checkMasivo
            // 
            this.checkMasivo.AutoSize = true;
            this.checkMasivo.Location = new System.Drawing.Point(6, 42);
            this.checkMasivo.Name = "checkMasivo";
            this.checkMasivo.Size = new System.Drawing.Size(112, 17);
            this.checkMasivo.TabIndex = 1;
            this.checkMasivo.Text = "Comandos masivo";
            this.checkMasivo.UseVisualStyleBackColor = true;
            // 
            // checkRastreo
            // 
            this.checkRastreo.AutoSize = true;
            this.checkRastreo.Location = new System.Drawing.Point(6, 19);
            this.checkRastreo.Name = "checkRastreo";
            this.checkRastreo.Size = new System.Drawing.Size(120, 17);
            this.checkRastreo.TabIndex = 0;
            this.checkRastreo.Text = "Rastreo de registros";
            this.checkRastreo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaRevision);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fechaBaja);
            this.groupBox1.Controls.Add(this.lblBaja);
            this.groupBox1.Controls.Add(this.fechaAlta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.checkActivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // fechaRevision
            // 
            this.fechaRevision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRevision.Location = new System.Drawing.Point(246, 71);
            this.fechaRevision.Name = "fechaRevision";
            this.fechaRevision.Size = new System.Drawing.Size(100, 20);
            this.fechaRevision.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Revisión:";
            // 
            // fechaBaja
            // 
            this.fechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBaja.Location = new System.Drawing.Point(73, 97);
            this.fechaBaja.Name = "fechaBaja";
            this.fechaBaja.Size = new System.Drawing.Size(100, 20);
            this.fechaBaja.TabIndex = 13;
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.Location = new System.Drawing.Point(3, 101);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(31, 13);
            this.lblBaja.TabIndex = 16;
            this.lblBaja.Text = "Baja:";
            // 
            // fechaAlta
            // 
            this.fechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAlta.Location = new System.Drawing.Point(73, 71);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(100, 20);
            this.fechaAlta.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alta:";
            // 
            // txtPass
            // 
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPass.Location = new System.Drawing.Point(73, 45);
            this.txtPass.MaxLength = 10;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(3, 48);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 19);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(382, 21);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(56, 17);
            this.checkActivo.TabIndex = 1;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            this.checkActivo.CheckedChanged += new System.EventHandler(this.CheckUsuarioActivo_CheckedChanged);
            // 
            // frmUsuariosPortalAgregar
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuariosPortalAgregar";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar usuario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkReporteGeneral;
        private System.Windows.Forms.CheckBox checkReporteComandos;
        private System.Windows.Forms.CheckBox checkLocalizacion;
        private System.Windows.Forms.CheckBox check20p;
        private System.Windows.Forms.CheckBox check10p;
        private System.Windows.Forms.CheckBox checkInmovilizar;
        private System.Windows.Forms.CheckBox checkCancelar;
        private System.Windows.Forms.CheckBox checkMovilizar;
        private System.Windows.Forms.CheckBox checkIndividual;
        private System.Windows.Forms.CheckBox checkMasivo;
        private System.Windows.Forms.CheckBox checkRastreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.DateTimePicker fechaRevision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechaBaja;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label label4;
    }
}