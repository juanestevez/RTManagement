namespace RT_Management
{
    partial class frmDeduciblesAgregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeduciblesAgregar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlatinum = new System.Windows.Forms.MaskedTextBox();
            this.txtGrupo = new System.Windows.Forms.MaskedTextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateC3 = new System.Windows.Forms.DateTimePicker();
            this.lblC3 = new System.Windows.Forms.Label();
            this.dateDictamen = new System.Windows.Forms.DateTimePicker();
            this.lblDictamen = new System.Windows.Forms.Label();
            this.lblRobo = new System.Windows.Forms.Label();
            this.dateRobo = new System.Windows.Forms.DateTimePicker();
            this.datePqr = new System.Windows.Forms.DateTimePicker();
            this.dateRecepcion = new System.Windows.Forms.DateTimePicker();
            this.dateVisita = new System.Windows.Forms.DateTimePicker();
            this.lblPqr = new System.Windows.Forms.Label();
            this.lblRecepcion = new System.Windows.Forms.Label();
            this.lblVisita = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelAlterno = new System.Windows.Forms.TextBox();
            this.txtTelCelular = new System.Windows.Forms.TextBox();
            this.txtTelDomicilio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.LinkLabel();
            this.numSumaA = new System.Windows.Forms.NumericUpDown();
            this.lblSumaA = new System.Windows.Forms.Label();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.numDeducible = new System.Windows.Forms.NumericUpDown();
            this.numValorFactura = new System.Windows.Forms.NumericUpDown();
            this.numDiasProceso = new System.Windows.Forms.NumericUpDown();
            this.lblDiasProceso = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbAseguradora = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.checkFiniquito = new System.Windows.Forms.CheckBox();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkContrato = new System.Windows.Forms.CheckBox();
            this.checkPfp = new System.Windows.Forms.CheckBox();
            this.checkIdentificacion = new System.Windows.Forms.CheckBox();
            this.checkActa = new System.Windows.Forms.CheckBox();
            this.checkFactura = new System.Windows.Forms.CheckBox();
            this.checkBaja = new System.Windows.Forms.CheckBox();
            this.checkAcred = new System.Windows.Forms.CheckBox();
            this.checkTenencia = new System.Windows.Forms.CheckBox();
            this.checkPagoBaja = new System.Windows.Forms.CheckBox();
            this.checkPoliza = new System.Windows.Forms.CheckBox();
            this.checkCartaPerdida = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSumaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeducible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasProceso)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlatinum);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.txtTitular);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehículo";
            // 
            // txtPlatinum
            // 
            this.txtPlatinum.Location = new System.Drawing.Point(103, 101);
            this.txtPlatinum.Mask = "00>L0000000";
            this.txtPlatinum.Name = "txtPlatinum";
            this.txtPlatinum.Size = new System.Drawing.Size(106, 20);
            this.txtPlatinum.TabIndex = 3;
            this.txtPlatinum.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(103, 50);
            this.txtGrupo.Mask = "0000-000";
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(106, 20);
            this.txtGrupo.TabIndex = 1;
            this.txtGrupo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTitular
            // 
            this.txtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitular.Location = new System.Drawing.Point(103, 25);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(106, 20);
            this.txtTitular.TabIndex = 0;
            // 
            // txtVin
            // 
            this.txtVin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVin.Location = new System.Drawing.Point(103, 75);
            this.txtVin.MaxLength = 17;
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(106, 20);
            this.txtVin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "*Platinum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "*VIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "*Gpo. Int.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Titular:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateC3);
            this.groupBox2.Controls.Add(this.lblC3);
            this.groupBox2.Controls.Add(this.dateDictamen);
            this.groupBox2.Controls.Add(this.lblDictamen);
            this.groupBox2.Controls.Add(this.lblRobo);
            this.groupBox2.Controls.Add(this.dateRobo);
            this.groupBox2.Controls.Add(this.datePqr);
            this.groupBox2.Controls.Add(this.dateRecepcion);
            this.groupBox2.Controls.Add(this.dateVisita);
            this.groupBox2.Controls.Add(this.lblPqr);
            this.groupBox2.Controls.Add(this.lblRecepcion);
            this.groupBox2.Controls.Add(this.lblVisita);
            this.groupBox2.Location = new System.Drawing.Point(224, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // dateC3
            // 
            this.dateC3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateC3.Location = new System.Drawing.Point(115, 129);
            this.dateC3.Name = "dateC3";
            this.dateC3.Size = new System.Drawing.Size(94, 20);
            this.dateC3.TabIndex = 4;
            this.dateC3.Visible = false;
            // 
            // lblC3
            // 
            this.lblC3.AutoSize = true;
            this.lblC3.Location = new System.Drawing.Point(8, 133);
            this.lblC3.Name = "lblC3";
            this.lblC3.Size = new System.Drawing.Size(51, 13);
            this.lblC3.TabIndex = 19;
            this.lblC3.Text = "Inicio C3:";
            this.lblC3.Visible = false;
            // 
            // dateDictamen
            // 
            this.dateDictamen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDictamen.Location = new System.Drawing.Point(115, 156);
            this.dateDictamen.Name = "dateDictamen";
            this.dateDictamen.Size = new System.Drawing.Size(94, 20);
            this.dateDictamen.TabIndex = 5;
            this.dateDictamen.Visible = false;
            // 
            // lblDictamen
            // 
            this.lblDictamen.AutoSize = true;
            this.lblDictamen.Location = new System.Drawing.Point(8, 160);
            this.lblDictamen.Name = "lblDictamen";
            this.lblDictamen.Size = new System.Drawing.Size(100, 13);
            this.lblDictamen.TabIndex = 17;
            this.lblDictamen.Text = "Envío de dictamen:";
            this.lblDictamen.Visible = false;
            // 
            // lblRobo
            // 
            this.lblRobo.AutoSize = true;
            this.lblRobo.Location = new System.Drawing.Point(7, 27);
            this.lblRobo.Name = "lblRobo";
            this.lblRobo.Size = new System.Drawing.Size(50, 13);
            this.lblRobo.TabIndex = 16;
            this.lblRobo.Text = "Siniestro:";
            this.lblRobo.Visible = false;
            // 
            // dateRobo
            // 
            this.dateRobo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRobo.Location = new System.Drawing.Point(114, 23);
            this.dateRobo.Name = "dateRobo";
            this.dateRobo.Size = new System.Drawing.Size(94, 20);
            this.dateRobo.TabIndex = 0;
            this.dateRobo.Value = new System.DateTime(2014, 12, 22, 0, 0, 0, 0);
            this.dateRobo.Visible = false;
            // 
            // datePqr
            // 
            this.datePqr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePqr.Location = new System.Drawing.Point(115, 102);
            this.datePqr.Name = "datePqr";
            this.datePqr.Size = new System.Drawing.Size(94, 20);
            this.datePqr.TabIndex = 3;
            this.datePqr.Visible = false;
            // 
            // dateRecepcion
            // 
            this.dateRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRecepcion.Location = new System.Drawing.Point(115, 76);
            this.dateRecepcion.Name = "dateRecepcion";
            this.dateRecepcion.Size = new System.Drawing.Size(94, 20);
            this.dateRecepcion.TabIndex = 2;
            this.dateRecepcion.Visible = false;
            // 
            // dateVisita
            // 
            this.dateVisita.CustomFormat = "";
            this.dateVisita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVisita.Location = new System.Drawing.Point(115, 49);
            this.dateVisita.Name = "dateVisita";
            this.dateVisita.Size = new System.Drawing.Size(94, 20);
            this.dateVisita.TabIndex = 1;
            this.dateVisita.Visible = false;
            // 
            // lblPqr
            // 
            this.lblPqr.AutoSize = true;
            this.lblPqr.Location = new System.Drawing.Point(8, 106);
            this.lblPqr.Name = "lblPqr";
            this.lblPqr.Size = new System.Drawing.Size(64, 13);
            this.lblPqr.TabIndex = 11;
            this.lblPqr.Text = "Envío a C3:";
            this.lblPqr.Visible = false;
            // 
            // lblRecepcion
            // 
            this.lblRecepcion.AutoSize = true;
            this.lblRecepcion.Location = new System.Drawing.Point(8, 80);
            this.lblRecepcion.Name = "lblRecepcion";
            this.lblRecepcion.Size = new System.Drawing.Size(62, 13);
            this.lblRecepcion.TabIndex = 10;
            this.lblRecepcion.Text = "Recepción:";
            this.lblRecepcion.Visible = false;
            // 
            // lblVisita
            // 
            this.lblVisita.AutoSize = true;
            this.lblVisita.Location = new System.Drawing.Point(8, 53);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(35, 13);
            this.lblVisita.TabIndex = 9;
            this.lblVisita.Text = "Visita:";
            this.lblVisita.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtTelAlterno);
            this.groupBox3.Controls.Add(this.txtTelCelular);
            this.groupBox3.Controls.Add(this.txtTelDomicilio);
            this.groupBox3.Location = new System.Drawing.Point(224, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "*Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tel. alterno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tel. celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tel. domicilio:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(100, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(108, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTelAlterno
            // 
            this.txtTelAlterno.Location = new System.Drawing.Point(100, 76);
            this.txtTelAlterno.MaxLength = 10;
            this.txtTelAlterno.Name = "txtTelAlterno";
            this.txtTelAlterno.Size = new System.Drawing.Size(108, 20);
            this.txtTelAlterno.TabIndex = 2;
            this.txtTelAlterno.Enter += new System.EventHandler(this.txtTelAlterno_Enter);
            this.txtTelAlterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelAlterno_KeyPress);
            // 
            // txtTelCelular
            // 
            this.txtTelCelular.Location = new System.Drawing.Point(100, 50);
            this.txtTelCelular.MaxLength = 10;
            this.txtTelCelular.Name = "txtTelCelular";
            this.txtTelCelular.Size = new System.Drawing.Size(108, 20);
            this.txtTelCelular.TabIndex = 1;
            this.txtTelCelular.Enter += new System.EventHandler(this.txtTelCelular_Enter);
            this.txtTelCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCelular_KeyPress);
            // 
            // txtTelDomicilio
            // 
            this.txtTelDomicilio.Location = new System.Drawing.Point(100, 24);
            this.txtTelDomicilio.MaxLength = 10;
            this.txtTelDomicilio.Name = "txtTelDomicilio";
            this.txtTelDomicilio.Size = new System.Drawing.Size(108, 20);
            this.txtTelDomicilio.TabIndex = 0;
            this.txtTelDomicilio.Enter += new System.EventHandler(this.txtTelDomicilio_Enter);
            this.txtTelDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelDomicilio_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMonto);
            this.groupBox4.Controls.Add(this.numSumaA);
            this.groupBox4.Controls.Add(this.lblSumaA);
            this.groupBox4.Controls.Add(this.numMonto);
            this.groupBox4.Controls.Add(this.numDeducible);
            this.groupBox4.Controls.Add(this.numValorFactura);
            this.groupBox4.Controls.Add(this.numDiasProceso);
            this.groupBox4.Controls.Add(this.lblDiasProceso);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cmbAseguradora);
            this.groupBox4.Location = new System.Drawing.Point(3, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 191);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deducibles";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.LinkColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(6, 106);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.TabStop = true;
            this.lblMonto.Text = "Monto:";
            this.lblMonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMonto_LinkClicked);
            // 
            // numSumaA
            // 
            this.numSumaA.DecimalPlaces = 2;
            this.numSumaA.Location = new System.Drawing.Point(101, 129);
            this.numSumaA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSumaA.Name = "numSumaA";
            this.numSumaA.Size = new System.Drawing.Size(100, 20);
            this.numSumaA.TabIndex = 4;
            this.numSumaA.ThousandsSeparator = true;
            // 
            // lblSumaA
            // 
            this.lblSumaA.AutoSize = true;
            this.lblSumaA.Location = new System.Drawing.Point(6, 133);
            this.lblSumaA.Name = "lblSumaA";
            this.lblSumaA.Size = new System.Drawing.Size(90, 13);
            this.lblSumaA.TabIndex = 27;
            this.lblSumaA.Text = "Suma asegurada:";
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Location = new System.Drawing.Point(101, 102);
            this.numMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(100, 20);
            this.numMonto.TabIndex = 3;
            this.numMonto.ThousandsSeparator = true;
            this.numMonto.Enter += new System.EventHandler(this.numMonto_Enter);
            // 
            // numDeducible
            // 
            this.numDeducible.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDeducible.Location = new System.Drawing.Point(101, 76);
            this.numDeducible.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDeducible.Name = "numDeducible";
            this.numDeducible.Size = new System.Drawing.Size(100, 20);
            this.numDeducible.TabIndex = 2;
            this.numDeducible.Enter += new System.EventHandler(this.numDeducible_Enter);
            // 
            // numValorFactura
            // 
            this.numValorFactura.DecimalPlaces = 2;
            this.numValorFactura.Increment = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numValorFactura.Location = new System.Drawing.Point(101, 50);
            this.numValorFactura.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValorFactura.Name = "numValorFactura";
            this.numValorFactura.Size = new System.Drawing.Size(100, 20);
            this.numValorFactura.TabIndex = 1;
            this.numValorFactura.ThousandsSeparator = true;
            this.numValorFactura.Enter += new System.EventHandler(this.numValorFactura_Enter);
            // 
            // numDiasProceso
            // 
            this.numDiasProceso.Location = new System.Drawing.Point(101, 155);
            this.numDiasProceso.Name = "numDiasProceso";
            this.numDiasProceso.Size = new System.Drawing.Size(100, 20);
            this.numDiasProceso.TabIndex = 5;
            this.numDiasProceso.Visible = false;
            this.numDiasProceso.Enter += new System.EventHandler(this.numDiasProceso_Enter);
            // 
            // lblDiasProceso
            // 
            this.lblDiasProceso.AutoSize = true;
            this.lblDiasProceso.Location = new System.Drawing.Point(6, 160);
            this.lblDiasProceso.Name = "lblDiasProceso";
            this.lblDiasProceso.Size = new System.Drawing.Size(89, 13);
            this.lblDiasProceso.TabIndex = 25;
            this.lblDiasProceso.Text = "Días en proceso:";
            this.lblDiasProceso.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "*Aseguradora:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Valor factura:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "% deducible:";
            // 
            // cmbAseguradora
            // 
            this.cmbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAseguradora.FormattingEnabled = true;
            this.cmbAseguradora.Items.AddRange(new object[] {
            "Banorte",
            "Qualitas",
            "Mapfre",
            "GNP",
            "Axa",
            "HDI",
            "Inbursa",
            "Otra"});
            this.cmbAseguradora.Location = new System.Drawing.Point(101, 23);
            this.cmbAseguradora.Name = "cmbAseguradora";
            this.cmbAseguradora.Size = new System.Drawing.Size(100, 21);
            this.cmbAseguradora.TabIndex = 0;
            this.cmbAseguradora.SelectedIndexChanged += new System.EventHandler(this.cmbAseguradora_SelectedIndexChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtExpediente);
            this.groupBox5.Controls.Add(this.checkFiniquito);
            this.groupBox5.Controls.Add(this.lblExpediente);
            this.groupBox5.Controls.Add(this.cmbEstado);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.checkContrato);
            this.groupBox5.Controls.Add(this.checkPfp);
            this.groupBox5.Controls.Add(this.checkIdentificacion);
            this.groupBox5.Controls.Add(this.checkActa);
            this.groupBox5.Controls.Add(this.checkFactura);
            this.groupBox5.Controls.Add(this.checkBaja);
            this.groupBox5.Controls.Add(this.checkAcred);
            this.groupBox5.Controls.Add(this.checkTenencia);
            this.groupBox5.Controls.Add(this.checkPagoBaja);
            this.groupBox5.Controls.Add(this.checkPoliza);
            this.groupBox5.Controls.Add(this.checkCartaPerdida);
            this.groupBox5.Location = new System.Drawing.Point(445, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 332);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Documentación";
            // 
            // txtExpediente
            // 
            this.txtExpediente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExpediente.Location = new System.Drawing.Point(7, 259);
            this.txtExpediente.MaxLength = 8;
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtExpediente.TabIndex = 31;
            // 
            // checkFiniquito
            // 
            this.checkFiniquito.AutoSize = true;
            this.checkFiniquito.Location = new System.Drawing.Point(7, 196);
            this.checkFiniquito.Name = "checkFiniquito";
            this.checkFiniquito.Size = new System.Drawing.Size(65, 17);
            this.checkFiniquito.TabIndex = 12;
            this.checkFiniquito.Text = "Finiquito";
            this.checkFiniquito.UseVisualStyleBackColor = true;
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(6, 243);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(88, 13);
            this.lblExpediente.TabIndex = 28;
            this.lblExpediente.Text = "Expediente NSC:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "En proceso",
            "Incompleto",
            "Procedente",
            "No procedente",
            "Para envío",
            "Entregado a PQR"});
            this.cmbEstado.Location = new System.Drawing.Point(8, 304);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(119, 21);
            this.cmbEstado.TabIndex = 14;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "*Estado:";
            // 
            // checkContrato
            // 
            this.checkContrato.AutoSize = true;
            this.checkContrato.Location = new System.Drawing.Point(7, 178);
            this.checkContrato.Name = "checkContrato";
            this.checkContrato.Size = new System.Drawing.Size(120, 17);
            this.checkContrato.TabIndex = 10;
            this.checkContrato.Text = "Contrato de servicio";
            this.checkContrato.UseVisualStyleBackColor = true;
            // 
            // checkPfp
            // 
            this.checkPfp.AutoSize = true;
            this.checkPfp.Location = new System.Drawing.Point(7, 214);
            this.checkPfp.Name = "checkPfp";
            this.checkPfp.Size = new System.Drawing.Size(138, 17);
            this.checkPfp.TabIndex = 9;
            this.checkPfp.Text = "Reporte Policía Federal";
            this.checkPfp.UseVisualStyleBackColor = true;
            // 
            // checkIdentificacion
            // 
            this.checkIdentificacion.AutoSize = true;
            this.checkIdentificacion.Location = new System.Drawing.Point(7, 160);
            this.checkIdentificacion.Name = "checkIdentificacion";
            this.checkIdentificacion.Size = new System.Drawing.Size(89, 17);
            this.checkIdentificacion.TabIndex = 8;
            this.checkIdentificacion.Text = "Identificación";
            this.checkIdentificacion.UseVisualStyleBackColor = true;
            // 
            // checkActa
            // 
            this.checkActa.AutoSize = true;
            this.checkActa.Location = new System.Drawing.Point(7, 124);
            this.checkActa.Name = "checkActa";
            this.checkActa.Size = new System.Drawing.Size(91, 17);
            this.checkActa.TabIndex = 3;
            this.checkActa.Text = "Acta ante MP";
            this.checkActa.UseVisualStyleBackColor = true;
            // 
            // checkFactura
            // 
            this.checkFactura.AutoSize = true;
            this.checkFactura.Location = new System.Drawing.Point(7, 16);
            this.checkFactura.Name = "checkFactura";
            this.checkFactura.Size = new System.Drawing.Size(134, 17);
            this.checkFactura.TabIndex = 2;
            this.checkFactura.Text = "Factura o carta factura";
            this.checkFactura.UseVisualStyleBackColor = true;
            // 
            // checkBaja
            // 
            this.checkBaja.AutoSize = true;
            this.checkBaja.Location = new System.Drawing.Point(7, 88);
            this.checkBaja.Name = "checkBaja";
            this.checkBaja.Size = new System.Drawing.Size(127, 17);
            this.checkBaja.TabIndex = 5;
            this.checkBaja.Text = "Comprobante de baja";
            this.checkBaja.UseVisualStyleBackColor = true;
            // 
            // checkAcred
            // 
            this.checkAcred.AutoSize = true;
            this.checkAcred.Location = new System.Drawing.Point(7, 142);
            this.checkAcred.Name = "checkAcred";
            this.checkAcred.Size = new System.Drawing.Size(161, 17);
            this.checkAcred.TabIndex = 4;
            this.checkAcred.Text = "Acreditación de la propiedad";
            this.checkAcred.UseVisualStyleBackColor = true;
            // 
            // checkTenencia
            // 
            this.checkTenencia.AutoSize = true;
            this.checkTenencia.Location = new System.Drawing.Point(7, 70);
            this.checkTenencia.Name = "checkTenencia";
            this.checkTenencia.Size = new System.Drawing.Size(71, 17);
            this.checkTenencia.TabIndex = 7;
            this.checkTenencia.Text = "Tenencia";
            this.checkTenencia.UseVisualStyleBackColor = true;
            // 
            // checkPagoBaja
            // 
            this.checkPagoBaja.AutoSize = true;
            this.checkPagoBaja.Location = new System.Drawing.Point(7, 106);
            this.checkPagoBaja.Name = "checkPagoBaja";
            this.checkPagoBaja.Size = new System.Drawing.Size(89, 17);
            this.checkPagoBaja.TabIndex = 6;
            this.checkPagoBaja.Text = "Pago de baja";
            this.checkPagoBaja.UseVisualStyleBackColor = true;
            // 
            // checkPoliza
            // 
            this.checkPoliza.AutoSize = true;
            this.checkPoliza.Location = new System.Drawing.Point(7, 34);
            this.checkPoliza.Name = "checkPoliza";
            this.checkPoliza.Size = new System.Drawing.Size(104, 17);
            this.checkPoliza.TabIndex = 1;
            this.checkPoliza.Text = "Póliza de seguro";
            this.checkPoliza.UseVisualStyleBackColor = true;
            // 
            // checkCartaPerdida
            // 
            this.checkCartaPerdida.AutoSize = true;
            this.checkCartaPerdida.Location = new System.Drawing.Point(7, 52);
            this.checkCartaPerdida.Name = "checkCartaPerdida";
            this.checkCartaPerdida.Size = new System.Drawing.Size(127, 17);
            this.checkCartaPerdida.TabIndex = 0;
            this.checkCartaPerdida.Text = "Carta de pérdida total";
            this.checkCartaPerdida.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(23, 22);
            this.toolStripCancelar.Text = "Limpiar campos";
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmDeduciblesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 363);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeduciblesAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar registro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDeduciblesAgregar_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSumaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeducible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasProceso)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datePqr;
        private System.Windows.Forms.DateTimePicker dateRecepcion;
        private System.Windows.Forms.DateTimePicker dateVisita;
        private System.Windows.Forms.Label lblPqr;
        private System.Windows.Forms.Label lblRecepcion;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelAlterno;
        private System.Windows.Forms.TextBox txtTelCelular;
        private System.Windows.Forms.TextBox txtTelDomicilio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRobo;
        private System.Windows.Forms.DateTimePicker dateRobo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbAseguradora;
        private System.Windows.Forms.NumericUpDown numDiasProceso;
        private System.Windows.Forms.Label lblDiasProceso;
        private System.Windows.Forms.DateTimePicker dateDictamen;
        private System.Windows.Forms.Label lblDictamen;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.NumericUpDown numDeducible;
        private System.Windows.Forms.NumericUpDown numValorFactura;
        private System.Windows.Forms.DateTimePicker dateC3;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.MaskedTextBox txtGrupo;
        private System.Windows.Forms.MaskedTextBox txtPlatinum;
        private System.Windows.Forms.NumericUpDown numSumaA;
        private System.Windows.Forms.Label lblSumaA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkFiniquito;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkContrato;
        private System.Windows.Forms.CheckBox checkPfp;
        private System.Windows.Forms.CheckBox checkIdentificacion;
        private System.Windows.Forms.CheckBox checkActa;
        private System.Windows.Forms.CheckBox checkFactura;
        private System.Windows.Forms.CheckBox checkBaja;
        private System.Windows.Forms.CheckBox checkAcred;
        private System.Windows.Forms.CheckBox checkTenencia;
        private System.Windows.Forms.CheckBox checkPagoBaja;
        private System.Windows.Forms.CheckBox checkPoliza;
        private System.Windows.Forms.CheckBox checkCartaPerdida;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.LinkLabel lblMonto;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}