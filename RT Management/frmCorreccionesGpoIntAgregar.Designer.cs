namespace RT_Management
{
    partial class frmCorreccionesGpoIntAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreccionesGpoIntAgregar));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSolicitadoPor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateSolicitud = new System.Windows.Forms.DateTimePicker();
            this.txtDistribuidora = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlatinumC = new System.Windows.Forms.MaskedTextBox();
            this.txtVinC = new System.Windows.Forms.MaskedTextBox();
            this.txtContratoC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitularC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlatinumI = new System.Windows.Forms.MaskedTextBox();
            this.txtVinI = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitularI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtContratoI = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtSolicitadoPor);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.dateSolicitud);
            this.groupBox5.Controls.Add(this.txtDistribuidora);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(372, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 258);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Solicitado por:";
            // 
            // txtSolicitadoPor
            // 
            this.txtSolicitadoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolicitadoPor.Location = new System.Drawing.Point(6, 113);
            this.txtSolicitadoPor.Name = "txtSolicitadoPor";
            this.txtSolicitadoPor.Size = new System.Drawing.Size(217, 20);
            this.txtSolicitadoPor.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Solicitud:";
            // 
            // dateSolicitud
            // 
            this.dateSolicitud.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSolicitud.Location = new System.Drawing.Point(80, 17);
            this.dateSolicitud.Name = "dateSolicitud";
            this.dateSolicitud.Size = new System.Drawing.Size(143, 20);
            this.dateSolicitud.TabIndex = 0;
            // 
            // txtDistribuidora
            // 
            this.txtDistribuidora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistribuidora.Location = new System.Drawing.Point(6, 61);
            this.txtDistribuidora.Name = "txtDistribuidora";
            this.txtDistribuidora.Size = new System.Drawing.Size(217, 20);
            this.txtDistribuidora.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Distribuidora:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPlatinumC);
            this.groupBox2.Controls.Add(this.txtVinC);
            this.groupBox2.Controls.Add(this.txtContratoC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTitularC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos correctos";
            // 
            // txtPlatinumC
            // 
            this.txtPlatinumC.Location = new System.Drawing.Point(63, 97);
            this.txtPlatinumC.Mask = "00>L0000000";
            this.txtPlatinumC.Name = "txtPlatinumC";
            this.txtPlatinumC.Size = new System.Drawing.Size(100, 20);
            this.txtPlatinumC.TabIndex = 3;
            // 
            // txtVinC
            // 
            this.txtVinC.AsciiOnly = true;
            this.txtVinC.Location = new System.Drawing.Point(63, 71);
            this.txtVinC.Mask = ">A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A";
            this.txtVinC.Name = "txtVinC";
            this.txtVinC.Size = new System.Drawing.Size(148, 20);
            this.txtVinC.TabIndex = 2;
            // 
            // txtContratoC
            // 
            this.txtContratoC.Location = new System.Drawing.Point(63, 45);
            this.txtContratoC.Mask = "0000-000";
            this.txtContratoC.Name = "txtContratoC";
            this.txtContratoC.Size = new System.Drawing.Size(100, 20);
            this.txtContratoC.TabIndex = 1;
            this.txtContratoC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Platinum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gpo. Int.:";
            // 
            // txtTitularC
            // 
            this.txtTitularC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitularC.Location = new System.Drawing.Point(63, 19);
            this.txtTitularC.Name = "txtTitularC";
            this.txtTitularC.Size = new System.Drawing.Size(285, 20);
            this.txtTitularC.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContratoI);
            this.groupBox1.Controls.Add(this.txtPlatinumI);
            this.groupBox1.Controls.Add(this.txtVinI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTitularI);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos incorrectos";
            // 
            // txtPlatinumI
            // 
            this.txtPlatinumI.Location = new System.Drawing.Point(63, 97);
            this.txtPlatinumI.Mask = "00>L0000000";
            this.txtPlatinumI.Name = "txtPlatinumI";
            this.txtPlatinumI.Size = new System.Drawing.Size(100, 20);
            this.txtPlatinumI.TabIndex = 3;
            // 
            // txtVinI
            // 
            this.txtVinI.AsciiOnly = true;
            this.txtVinI.Location = new System.Drawing.Point(63, 71);
            this.txtVinI.Mask = ">A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A";
            this.txtVinI.Name = "txtVinI";
            this.txtVinI.Size = new System.Drawing.Size(148, 20);
            this.txtVinI.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Platinum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "VIN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Gpo. Int.:";
            // 
            // txtTitularI
            // 
            this.txtTitularI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitularI.Location = new System.Drawing.Point(63, 19);
            this.txtTitularI.Name = "txtTitularI";
            this.txtTitularI.Size = new System.Drawing.Size(285, 20);
            this.txtTitularI.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Titular:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnCancelar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(613, 25);
            this.toolStrip.TabIndex = 25;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContratoI
            // 
            this.txtContratoI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContratoI.Location = new System.Drawing.Point(64, 45);
            this.txtContratoI.Name = "txtContratoI";
            this.txtContratoI.Size = new System.Drawing.Size(100, 20);
            this.txtContratoI.TabIndex = 7;
            // 
            // frmCorreccionesGpoIntAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 293);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCorreccionesGpoIntAgregar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar solicitud";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSolicitadoPor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateSolicitud;
        private System.Windows.Forms.TextBox txtDistribuidora;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtPlatinumC;
        private System.Windows.Forms.MaskedTextBox txtVinC;
        private System.Windows.Forms.MaskedTextBox txtContratoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitularC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtPlatinumI;
        private System.Windows.Forms.MaskedTextBox txtVinI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitularI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox txtContratoI;
    }
}