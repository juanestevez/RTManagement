namespace RT_Management
{
    partial class frmDeduciblesCambioStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeduciblesCambioStatus));
            this.dateDictamen = new System.Windows.Forms.DateTimePicker();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDictamen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.numDiasProceso = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateRecepcion = new System.Windows.Forms.DateTimePicker();
            this.lblRecepcion = new System.Windows.Forms.Label();
            this.lblC3 = new System.Windows.Forms.Label();
            this.dateC3 = new System.Windows.Forms.DateTimePicker();
            this.lblPqr = new System.Windows.Forms.Label();
            this.datePqr = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDictamen
            // 
            this.dateDictamen.CustomFormat = "";
            this.dateDictamen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDictamen.Location = new System.Drawing.Point(132, 91);
            this.dateDictamen.Name = "dateDictamen";
            this.dateDictamen.Size = new System.Drawing.Size(94, 20);
            this.dateDictamen.TabIndex = 1;
            this.dateDictamen.Visible = false;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(15, 90);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(102, 21);
            this.comboEstado.TabIndex = 2;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.ComboEstado_SelectedIndexChanged);
            this.comboEstado.SelectedValueChanged += new System.EventHandler(this.ComboEstado_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(86, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo estado:";
            // 
            // lblDictamen
            // 
            this.lblDictamen.AutoSize = true;
            this.lblDictamen.Location = new System.Drawing.Point(129, 75);
            this.lblDictamen.Name = "lblDictamen";
            this.lblDictamen.Size = new System.Drawing.Size(101, 13);
            this.lblDictamen.TabIndex = 6;
            this.lblDictamen.Text = "Fecha de dictamen:";
            this.lblDictamen.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado actual:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(86, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Estado";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(243, 75);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(89, 13);
            this.lblDias.TabIndex = 9;
            this.lblDias.Text = "Días en proceso:";
            this.lblDias.Visible = false;
            // 
            // numDiasProceso
            // 
            this.numDiasProceso.Location = new System.Drawing.Point(246, 91);
            this.numDiasProceso.Name = "numDiasProceso";
            this.numDiasProceso.Size = new System.Drawing.Size(94, 20);
            this.numDiasProceso.TabIndex = 10;
            this.numDiasProceso.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(267, 171);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(173, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dateRecepcion
            // 
            this.dateRecepcion.CustomFormat = "";
            this.dateRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecepcion.Location = new System.Drawing.Point(15, 142);
            this.dateRecepcion.Name = "dateRecepcion";
            this.dateRecepcion.Size = new System.Drawing.Size(94, 20);
            this.dateRecepcion.TabIndex = 13;
            this.dateRecepcion.Visible = false;
            // 
            // lblRecepcion
            // 
            this.lblRecepcion.AutoSize = true;
            this.lblRecepcion.Location = new System.Drawing.Point(12, 126);
            this.lblRecepcion.Name = "lblRecepcion";
            this.lblRecepcion.Size = new System.Drawing.Size(105, 13);
            this.lblRecepcion.TabIndex = 14;
            this.lblRecepcion.Text = "Fecha de recepción:";
            this.lblRecepcion.Visible = false;
            // 
            // lblC3
            // 
            this.lblC3.AutoSize = true;
            this.lblC3.Location = new System.Drawing.Point(243, 126);
            this.lblC3.Name = "lblC3";
            this.lblC3.Size = new System.Drawing.Size(56, 13);
            this.lblC3.TabIndex = 16;
            this.lblC3.Text = "Fecha C3:";
            this.lblC3.Visible = false;
            // 
            // dateC3
            // 
            this.dateC3.CustomFormat = "";
            this.dateC3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateC3.Location = new System.Drawing.Point(246, 142);
            this.dateC3.Name = "dateC3";
            this.dateC3.Size = new System.Drawing.Size(94, 20);
            this.dateC3.TabIndex = 15;
            this.dateC3.Visible = false;
            // 
            // lblPqr
            // 
            this.lblPqr.AutoSize = true;
            this.lblPqr.Location = new System.Drawing.Point(129, 126);
            this.lblPqr.Name = "lblPqr";
            this.lblPqr.Size = new System.Drawing.Size(64, 13);
            this.lblPqr.TabIndex = 18;
            this.lblPqr.Text = "Envío a C3:";
            this.lblPqr.Visible = false;
            // 
            // datePqr
            // 
            this.datePqr.CustomFormat = "";
            this.datePqr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePqr.Location = new System.Drawing.Point(132, 142);
            this.datePqr.Name = "datePqr";
            this.datePqr.Size = new System.Drawing.Size(94, 20);
            this.datePqr.TabIndex = 17;
            this.datePqr.Visible = false;
            // 
            // frmDeduciblesCambioStatus
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(363, 206);
            this.Controls.Add(this.lblPqr);
            this.Controls.Add(this.datePqr);
            this.Controls.Add(this.lblC3);
            this.Controls.Add(this.dateC3);
            this.Controls.Add(this.lblRecepcion);
            this.Controls.Add(this.dateRecepcion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numDiasProceso);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDictamen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.dateDictamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeduciblesCambioStatus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio de estado";
            this.Load += new System.EventHandler(this.FrmCambioStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiasProceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDictamen;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDictamen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown numDiasProceso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateRecepcion;
        private System.Windows.Forms.Label lblRecepcion;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.DateTimePicker dateC3;
        private System.Windows.Forms.Label lblPqr;
        private System.Windows.Forms.DateTimePicker datePqr;
    }
}