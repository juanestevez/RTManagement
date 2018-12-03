namespace RT_Management
{
    partial class frmCorreccionesGpoInt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreccionesGpoInt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblResultados = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxEstado = new System.Windows.Forms.PictureBox();
            this.lblTiempoRespuesta = new System.Windows.Forms.Label();
            this.toolData = new System.Windows.Forms.ToolStrip();
            this.btnDataGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnDataModificar = new System.Windows.Forms.ToolStripButton();
            this.btnDataCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnDataCompletado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDataComentario = new System.Windows.Forms.ToolStripButton();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.groupDataCorrectos = new System.Windows.Forms.GroupBox();
            this.txt1PlatinumC = new System.Windows.Forms.MaskedTextBox();
            this.txt1VinC = new System.Windows.Forms.MaskedTextBox();
            this.txt1GrupoC = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt1TitularC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupSolicitud = new System.Windows.Forms.GroupBox();
            this.lbl1Respuesta = new System.Windows.Forms.Label();
            this.lbl1Solicitud = new System.Windows.Forms.Label();
            this.dateRespuesta = new System.Windows.Forms.DateTimePicker();
            this.dateSolicitud = new System.Windows.Forms.DateTimePicker();
            this.txt1Distribuidora = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.layoutData = new System.Windows.Forms.TableLayoutPanel();
            this.groupDataIncorrectos = new System.Windows.Forms.GroupBox();
            this.txt1GrupoI = new System.Windows.Forms.TextBox();
            this.txt1PlatinumI = new System.Windows.Forms.MaskedTextBox();
            this.txt1VinI = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt1TitularI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupSolicitado = new System.Windows.Forms.GroupBox();
            this.txtSolicitadoPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusComment = new System.Windows.Forms.Label();
            this.gridComentarios = new System.Windows.Forms.DataGridView();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.tabFechas = new System.Windows.Forms.TabPage();
            this.radioRespuesta = new System.Windows.Forms.RadioButton();
            this.radioSolicitud = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarfecha = new System.Windows.Forms.Button();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BarraHerramientas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxEstado)).BeginInit();
            this.toolData.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.groupDataCorrectos.SuspendLayout();
            this.groupSolicitud.SuspendLayout();
            this.layoutData.SuspendLayout();
            this.groupDataIncorrectos.SuspendLayout();
            this.groupSolicitado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).BeginInit();
            this.tabOpciones.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.tabFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator1,
            this.btnActualizar,
            this.toolStripSeparator3,
            this.btnExportar,
            this.toolStripSeparator4,
            this.lblResultados});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(1244, 25);
            this.BarraHerramientas.TabIndex = 2;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "Agregar solicitud";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Ver registros recientes";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportar
            // 
            this.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(23, 22);
            this.btnExportar.Text = "Exportar datos a CSV";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblResultados
            // 
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 22);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boxEstado);
            this.panel2.Controls.Add(this.lblTiempoRespuesta);
            this.panel2.Controls.Add(this.toolData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(578, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 64);
            this.panel2.TabIndex = 3;
            // 
            // boxEstado
            // 
            this.boxEstado.Location = new System.Drawing.Point(6, 31);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(58, 16);
            this.boxEstado.TabIndex = 43;
            this.boxEstado.TabStop = false;
            this.boxEstado.Visible = false;
            // 
            // lblTiempoRespuesta
            // 
            this.lblTiempoRespuesta.AutoSize = true;
            this.lblTiempoRespuesta.Location = new System.Drawing.Point(70, 33);
            this.lblTiempoRespuesta.Name = "lblTiempoRespuesta";
            this.lblTiempoRespuesta.Size = new System.Drawing.Size(256, 13);
            this.lblTiempoRespuesta.TabIndex = 24;
            this.lblTiempoRespuesta.Text = "Tiempo de respuesta {0} dias, {1} horas, {2} minutos.";
            this.lblTiempoRespuesta.Visible = false;
            // 
            // toolData
            // 
            this.toolData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDataGuardar,
            this.btnDataModificar,
            this.btnDataCancelar,
            this.btnDataCompletado,
            this.toolStripSeparator2,
            this.btnDataComentario});
            this.toolData.Location = new System.Drawing.Point(0, 0);
            this.toolData.Name = "toolData";
            this.toolData.Size = new System.Drawing.Size(673, 25);
            this.toolData.TabIndex = 23;
            this.toolData.Text = "toolStrip1";
            // 
            // btnDataGuardar
            // 
            this.btnDataGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataGuardar.Enabled = false;
            this.btnDataGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnDataGuardar.Image")));
            this.btnDataGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataGuardar.Name = "btnDataGuardar";
            this.btnDataGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnDataGuardar.Text = "Guardar";
            this.btnDataGuardar.Click += new System.EventHandler(this.btnDataGuardar_Click);
            // 
            // btnDataModificar
            // 
            this.btnDataModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnDataModificar.Image")));
            this.btnDataModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataModificar.Name = "btnDataModificar";
            this.btnDataModificar.Size = new System.Drawing.Size(23, 22);
            this.btnDataModificar.Text = "Editar";
            this.btnDataModificar.Click += new System.EventHandler(this.btnDataModificar_Click);
            // 
            // btnDataCancelar
            // 
            this.btnDataCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataCancelar.Enabled = false;
            this.btnDataCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnDataCancelar.Image")));
            this.btnDataCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataCancelar.Name = "btnDataCancelar";
            this.btnDataCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnDataCancelar.Text = "Cancelar";
            this.btnDataCancelar.Click += new System.EventHandler(this.btnDataCancelar_Click);
            // 
            // btnDataCompletado
            // 
            this.btnDataCompletado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataCompletado.Enabled = false;
            this.btnDataCompletado.Image = ((System.Drawing.Image)(resources.GetObject("btnDataCompletado.Image")));
            this.btnDataCompletado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataCompletado.Name = "btnDataCompletado";
            this.btnDataCompletado.Size = new System.Drawing.Size(23, 22);
            this.btnDataCompletado.Text = "Marcar como completado";
            this.btnDataCompletado.Click += new System.EventHandler(this.btnDataCompletado_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDataComentario
            // 
            this.btnDataComentario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDataComentario.Enabled = false;
            this.btnDataComentario.Image = ((System.Drawing.Image)(resources.GetObject("btnDataComentario.Image")));
            this.btnDataComentario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataComentario.Name = "btnDataComentario";
            this.btnDataComentario.Size = new System.Drawing.Size(23, 22);
            this.btnDataComentario.Text = "Agregar comentario";
            this.btnDataComentario.Click += new System.EventHandler(this.btnDataComentario_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.groupDataCorrectos);
            this.panelInfo.Controls.Add(this.groupSolicitud);
            this.panelInfo.Controls.Add(this.layoutData);
            this.panelInfo.Controls.Add(this.panel1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(578, 73);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(673, 443);
            this.panelInfo.TabIndex = 2;
            // 
            // groupDataCorrectos
            // 
            this.groupDataCorrectos.Controls.Add(this.txt1PlatinumC);
            this.groupDataCorrectos.Controls.Add(this.txt1VinC);
            this.groupDataCorrectos.Controls.Add(this.txt1GrupoC);
            this.groupDataCorrectos.Controls.Add(this.label14);
            this.groupDataCorrectos.Controls.Add(this.label15);
            this.groupDataCorrectos.Controls.Add(this.label16);
            this.groupDataCorrectos.Controls.Add(this.txt1TitularC);
            this.groupDataCorrectos.Controls.Add(this.label17);
            this.groupDataCorrectos.ForeColor = System.Drawing.Color.Green;
            this.groupDataCorrectos.Location = new System.Drawing.Point(3, 3);
            this.groupDataCorrectos.Name = "groupDataCorrectos";
            this.groupDataCorrectos.Size = new System.Drawing.Size(354, 127);
            this.groupDataCorrectos.TabIndex = 0;
            this.groupDataCorrectos.TabStop = false;
            this.groupDataCorrectos.Text = "Datos correctos";
            // 
            // txt1PlatinumC
            // 
            this.txt1PlatinumC.Location = new System.Drawing.Point(63, 97);
            this.txt1PlatinumC.Mask = "00L0000000";
            this.txt1PlatinumC.Name = "txt1PlatinumC";
            this.txt1PlatinumC.Size = new System.Drawing.Size(100, 20);
            this.txt1PlatinumC.TabIndex = 3;
            this.txt1PlatinumC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt1VinC
            // 
            this.txt1VinC.Location = new System.Drawing.Point(63, 71);
            this.txt1VinC.Mask = "AAAAAAAAAAAAAAAAA";
            this.txt1VinC.Name = "txt1VinC";
            this.txt1VinC.Size = new System.Drawing.Size(148, 20);
            this.txt1VinC.TabIndex = 2;
            this.txt1VinC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt1GrupoC
            // 
            this.txt1GrupoC.Location = new System.Drawing.Point(63, 45);
            this.txt1GrupoC.Mask = "0000-000";
            this.txt1GrupoC.Name = "txt1GrupoC";
            this.txt1GrupoC.Size = new System.Drawing.Size(100, 20);
            this.txt1GrupoC.TabIndex = 1;
            this.txt1GrupoC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Platinum:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "VIN:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Gpo. Int.:";
            // 
            // txt1TitularC
            // 
            this.txt1TitularC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt1TitularC.Location = new System.Drawing.Point(63, 19);
            this.txt1TitularC.Name = "txt1TitularC";
            this.txt1TitularC.Size = new System.Drawing.Size(285, 20);
            this.txt1TitularC.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Titular:";
            // 
            // groupSolicitud
            // 
            this.groupSolicitud.Controls.Add(this.lbl1Respuesta);
            this.groupSolicitud.Controls.Add(this.lbl1Solicitud);
            this.groupSolicitud.Controls.Add(this.dateRespuesta);
            this.groupSolicitud.Controls.Add(this.dateSolicitud);
            this.groupSolicitud.Controls.Add(this.txt1Distribuidora);
            this.groupSolicitud.Controls.Add(this.label18);
            this.groupSolicitud.Location = new System.Drawing.Point(363, 3);
            this.groupSolicitud.Name = "groupSolicitud";
            this.groupSolicitud.Size = new System.Drawing.Size(232, 126);
            this.groupSolicitud.TabIndex = 2;
            this.groupSolicitud.TabStop = false;
            // 
            // lbl1Respuesta
            // 
            this.lbl1Respuesta.AutoSize = true;
            this.lbl1Respuesta.Location = new System.Drawing.Point(6, 47);
            this.lbl1Respuesta.Name = "lbl1Respuesta";
            this.lbl1Respuesta.Size = new System.Drawing.Size(61, 13);
            this.lbl1Respuesta.TabIndex = 17;
            this.lbl1Respuesta.Text = "Respuesta:";
            this.lbl1Respuesta.Visible = false;
            // 
            // lbl1Solicitud
            // 
            this.lbl1Solicitud.AutoSize = true;
            this.lbl1Solicitud.Location = new System.Drawing.Point(6, 21);
            this.lbl1Solicitud.Name = "lbl1Solicitud";
            this.lbl1Solicitud.Size = new System.Drawing.Size(50, 13);
            this.lbl1Solicitud.TabIndex = 16;
            this.lbl1Solicitud.Text = "Solicitud:";
            this.lbl1Solicitud.Visible = false;
            // 
            // dateRespuesta
            // 
            this.dateRespuesta.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateRespuesta.Enabled = false;
            this.dateRespuesta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRespuesta.Location = new System.Drawing.Point(80, 43);
            this.dateRespuesta.Name = "dateRespuesta";
            this.dateRespuesta.Size = new System.Drawing.Size(143, 20);
            this.dateRespuesta.TabIndex = 1;
            this.dateRespuesta.Visible = false;
            // 
            // dateSolicitud
            // 
            this.dateSolicitud.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateSolicitud.Enabled = false;
            this.dateSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSolicitud.Location = new System.Drawing.Point(80, 17);
            this.dateSolicitud.Name = "dateSolicitud";
            this.dateSolicitud.Size = new System.Drawing.Size(143, 20);
            this.dateSolicitud.TabIndex = 0;
            this.dateSolicitud.Visible = false;
            // 
            // txt1Distribuidora
            // 
            this.txt1Distribuidora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt1Distribuidora.Location = new System.Drawing.Point(6, 93);
            this.txt1Distribuidora.Name = "txt1Distribuidora";
            this.txt1Distribuidora.Size = new System.Drawing.Size(217, 20);
            this.txt1Distribuidora.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Distribuidora:";
            // 
            // layoutData
            // 
            this.layoutData.ColumnCount = 2;
            this.layoutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.layoutData.Controls.Add(this.groupDataIncorrectos, 0, 0);
            this.layoutData.Controls.Add(this.groupSolicitado, 1, 0);
            this.layoutData.Location = new System.Drawing.Point(3, 136);
            this.layoutData.Name = "layoutData";
            this.layoutData.RowCount = 1;
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutData.Size = new System.Drawing.Size(619, 139);
            this.layoutData.TabIndex = 22;
            // 
            // groupDataIncorrectos
            // 
            this.groupDataIncorrectos.Controls.Add(this.txt1GrupoI);
            this.groupDataIncorrectos.Controls.Add(this.txt1PlatinumI);
            this.groupDataIncorrectos.Controls.Add(this.txt1VinI);
            this.groupDataIncorrectos.Controls.Add(this.label10);
            this.groupDataIncorrectos.Controls.Add(this.label11);
            this.groupDataIncorrectos.Controls.Add(this.label12);
            this.groupDataIncorrectos.Controls.Add(this.txt1TitularI);
            this.groupDataIncorrectos.Controls.Add(this.label13);
            this.groupDataIncorrectos.ForeColor = System.Drawing.Color.Red;
            this.groupDataIncorrectos.Location = new System.Drawing.Point(3, 3);
            this.groupDataIncorrectos.Name = "groupDataIncorrectos";
            this.groupDataIncorrectos.Size = new System.Drawing.Size(354, 126);
            this.groupDataIncorrectos.TabIndex = 1;
            this.groupDataIncorrectos.TabStop = false;
            this.groupDataIncorrectos.Text = "Datos incorrectos";
            // 
            // txt1GrupoI
            // 
            this.txt1GrupoI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt1GrupoI.Location = new System.Drawing.Point(63, 45);
            this.txt1GrupoI.Name = "txt1GrupoI";
            this.txt1GrupoI.Size = new System.Drawing.Size(100, 20);
            this.txt1GrupoI.TabIndex = 8;
            // 
            // txt1PlatinumI
            // 
            this.txt1PlatinumI.Location = new System.Drawing.Point(63, 97);
            this.txt1PlatinumI.Mask = "00L0000000";
            this.txt1PlatinumI.Name = "txt1PlatinumI";
            this.txt1PlatinumI.Size = new System.Drawing.Size(100, 20);
            this.txt1PlatinumI.TabIndex = 3;
            this.txt1PlatinumI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt1VinI
            // 
            this.txt1VinI.Location = new System.Drawing.Point(63, 71);
            this.txt1VinI.Mask = "AAAAAAAAAAAAAAAAA";
            this.txt1VinI.Name = "txt1VinI";
            this.txt1VinI.Size = new System.Drawing.Size(148, 20);
            this.txt1VinI.TabIndex = 2;
            this.txt1VinI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Platinum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "VIN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Gpo. Int.:";
            // 
            // txt1TitularI
            // 
            this.txt1TitularI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt1TitularI.Location = new System.Drawing.Point(63, 19);
            this.txt1TitularI.Name = "txt1TitularI";
            this.txt1TitularI.Size = new System.Drawing.Size(285, 20);
            this.txt1TitularI.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Titular:";
            // 
            // groupSolicitado
            // 
            this.groupSolicitado.Controls.Add(this.txtSolicitadoPor);
            this.groupSolicitado.Controls.Add(this.label1);
            this.groupSolicitado.Location = new System.Drawing.Point(375, 3);
            this.groupSolicitado.Name = "groupSolicitado";
            this.groupSolicitado.Size = new System.Drawing.Size(232, 127);
            this.groupSolicitado.TabIndex = 3;
            this.groupSolicitado.TabStop = false;
            // 
            // txtSolicitadoPor
            // 
            this.txtSolicitadoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolicitadoPor.Enabled = false;
            this.txtSolicitadoPor.Location = new System.Drawing.Point(6, 35);
            this.txtSolicitadoPor.Name = "txtSolicitadoPor";
            this.txtSolicitadoPor.Size = new System.Drawing.Size(217, 20);
            this.txtSolicitadoPor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Solicitado por:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatusComment);
            this.panel1.Controls.Add(this.gridComentarios);
            this.panel1.Location = new System.Drawing.Point(3, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 124);
            this.panel1.TabIndex = 23;
            // 
            // lblStatusComment
            // 
            this.lblStatusComment.AutoSize = true;
            this.lblStatusComment.Location = new System.Drawing.Point(257, 56);
            this.lblStatusComment.Name = "lblStatusComment";
            this.lblStatusComment.Size = new System.Drawing.Size(104, 13);
            this.lblStatusComment.TabIndex = 50;
            this.lblStatusComment.Text = "No hay comentarios.";
            this.lblStatusComment.Visible = false;
            // 
            // gridComentarios
            // 
            this.gridComentarios.AllowUserToAddRows = false;
            this.gridComentarios.AllowUserToDeleteRows = false;
            this.gridComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridComentarios.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridComentarios.Location = new System.Drawing.Point(0, 0);
            this.gridComentarios.Name = "gridComentarios";
            this.gridComentarios.ReadOnly = true;
            this.gridComentarios.RowHeadersVisible = false;
            this.gridComentarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridComentarios.Size = new System.Drawing.Size(619, 124);
            this.gridComentarios.TabIndex = 49;
            // 
            // tabOpciones
            // 
            this.tabOpciones.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabOpciones.Controls.Add(this.tabBuscar);
            this.tabOpciones.Controls.Add(this.tabFechas);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Location = new System.Drawing.Point(3, 3);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(569, 64);
            this.tabOpciones.TabIndex = 1;
            this.tabOpciones.SelectedIndexChanged += new System.EventHandler(this.tabOpciones_SelectedIndexChanged);
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.tabBuscar.Controls.Add(this.btnBuscar);
            this.tabBuscar.Controls.Add(this.txtBusqueda);
            this.tabBuscar.Controls.Add(this.comboTipo);
            this.tabBuscar.Controls.Add(this.comboFiltro);
            this.tabBuscar.Location = new System.Drawing.Point(4, 25);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(561, 35);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(527, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 30);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(171, 6);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(350, 20);
            this.txtBusqueda.TabIndex = 10;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Like",
            "="});
            this.comboTipo.Location = new System.Drawing.Point(107, 6);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(56, 21);
            this.comboTipo.TabIndex = 9;
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
            this.comboFiltro.Location = new System.Drawing.Point(6, 6);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(92, 21);
            this.comboFiltro.TabIndex = 8;
            // 
            // tabFechas
            // 
            this.tabFechas.Controls.Add(this.radioRespuesta);
            this.tabFechas.Controls.Add(this.radioSolicitud);
            this.tabFechas.Controls.Add(this.label2);
            this.tabFechas.Controls.Add(this.label3);
            this.tabFechas.Controls.Add(this.btnBuscarfecha);
            this.tabFechas.Controls.Add(this.fechaFin);
            this.tabFechas.Controls.Add(this.fechaInicio);
            this.tabFechas.Location = new System.Drawing.Point(4, 25);
            this.tabFechas.Name = "tabFechas";
            this.tabFechas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFechas.Size = new System.Drawing.Size(561, 35);
            this.tabFechas.TabIndex = 1;
            this.tabFechas.Text = "Rango de fechas";
            this.tabFechas.UseVisualStyleBackColor = true;
            // 
            // radioRespuesta
            // 
            this.radioRespuesta.AutoSize = true;
            this.radioRespuesta.Location = new System.Drawing.Point(320, 7);
            this.radioRespuesta.Name = "radioRespuesta";
            this.radioRespuesta.Size = new System.Drawing.Size(76, 17);
            this.radioRespuesta.TabIndex = 18;
            this.radioRespuesta.Text = "Respuesta";
            this.radioRespuesta.UseVisualStyleBackColor = true;
            // 
            // radioSolicitud
            // 
            this.radioSolicitud.AutoSize = true;
            this.radioSolicitud.Checked = true;
            this.radioSolicitud.Location = new System.Drawing.Point(249, 7);
            this.radioSolicitud.Name = "radioSolicitud";
            this.radioSolicitud.Size = new System.Drawing.Size(65, 17);
            this.radioSolicitud.TabIndex = 17;
            this.radioSolicitud.TabStop = true;
            this.radioSolicitud.Text = "Solicitud";
            this.radioSolicitud.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inicio:";
            // 
            // btnBuscarfecha
            // 
            this.btnBuscarfecha.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarfecha.Image")));
            this.btnBuscarfecha.Location = new System.Drawing.Point(402, 3);
            this.btnBuscarfecha.Name = "btnBuscarfecha";
            this.btnBuscarfecha.Size = new System.Drawing.Size(24, 25);
            this.btnBuscarfecha.TabIndex = 14;
            this.btnBuscarfecha.UseVisualStyleBackColor = true;
            this.btnBuscarfecha.Click += new System.EventHandler(this.btnBuscarfecha_Click);
            // 
            // fechaFin
            // 
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(158, 5);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(84, 20);
            this.fechaFin.TabIndex = 13;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(42, 5);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(84, 20);
            this.fechaInicio.TabIndex = 12;
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            this.gridDatos.AllowUserToResizeColumns = false;
            this.gridDatos.AllowUserToResizeRows = false;
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.GridColor = System.Drawing.SystemColors.Control;
            this.gridDatos.Location = new System.Drawing.Point(3, 73);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.RowHeadersVisible = false;
            this.gridDatos.Size = new System.Drawing.Size(569, 443);
            this.gridDatos.TabIndex = 0;
            this.gridDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellClick);
            this.gridDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellClick);
            this.gridDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridDatos_CellFormatting);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 679F));
            this.tableLayoutPanel1.Controls.Add(this.gridDatos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabOpciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmCorreccionesGpoInt
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BarraHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1260, 536);
            this.Name = "frmCorreccionesGpoInt";
            this.Text = "Correcciones de grupo integrante";
            this.Load += new System.EventHandler(this.frmCorreccionesGpoInt_Load);
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxEstado)).EndInit();
            this.toolData.ResumeLayout(false);
            this.toolData.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.groupDataCorrectos.ResumeLayout(false);
            this.groupDataCorrectos.PerformLayout();
            this.groupSolicitud.ResumeLayout(false);
            this.groupSolicitud.PerformLayout();
            this.layoutData.ResumeLayout(false);
            this.groupDataIncorrectos.ResumeLayout(false);
            this.groupDataIncorrectos.PerformLayout();
            this.groupSolicitado.ResumeLayout(false);
            this.groupSolicitado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).EndInit();
            this.tabOpciones.ResumeLayout(false);
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            this.tabFechas.ResumeLayout(false);
            this.tabFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private System.Windows.Forms.TableLayoutPanel layoutData;
        private System.Windows.Forms.GroupBox groupDataIncorrectos;
        private System.Windows.Forms.MaskedTextBox txt1PlatinumI;
        private System.Windows.Forms.MaskedTextBox txt1VinI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt1TitularI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupDataCorrectos;
        private System.Windows.Forms.MaskedTextBox txt1PlatinumC;
        private System.Windows.Forms.MaskedTextBox txt1VinC;
        private System.Windows.Forms.MaskedTextBox txt1GrupoC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt1TitularC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupSolicitud;
        private System.Windows.Forms.Label lbl1Respuesta;
        private System.Windows.Forms.Label lbl1Solicitud;
        private System.Windows.Forms.DateTimePicker dateRespuesta;
        private System.Windows.Forms.DateTimePicker dateSolicitud;
        private System.Windows.Forms.TextBox txt1Distribuidora;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupSolicitado;
        private System.Windows.Forms.TextBox txtSolicitadoPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridComentarios;
        private System.Windows.Forms.TabControl tabOpciones;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolData;
        private System.Windows.Forms.ToolStripButton btnDataGuardar;
        private System.Windows.Forms.ToolStripButton btnDataModificar;
        private System.Windows.Forms.ToolStripButton btnDataCancelar;
        private System.Windows.Forms.ToolStripButton btnDataCompletado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDataComentario;
        private System.Windows.Forms.Label lblTiempoRespuesta;
        private System.Windows.Forms.PictureBox boxEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarfecha;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label lblStatusComment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblResultados;
        private System.Windows.Forms.RadioButton radioRespuesta;
        private System.Windows.Forms.RadioButton radioSolicitud;
        private System.Windows.Forms.TextBox txt1GrupoI;
    }
}