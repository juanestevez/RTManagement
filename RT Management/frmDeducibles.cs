using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace RT_Management
{
    public partial class frmDeducibles : Form
    {
        private static frmDeducibles m_FormDefInstance;
        private static string user = "";
        private static int level = 7;
        private string idDeducible = "";
        private int statusExpediente;
        private string titular = "";
        private int montoP = -1;

        enum status {ENPROCESO, INCOMPLETO, PROCEDENTE, NOPROCEDENTE, PARAENVIO, ENTREGADO, ARCHIVADO};

        public frmDeducibles()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Propiedad para guardar el nombre del usuario activo.
        /// </summary>
        public static string UsuarioActivo
        {
            set
            {
                user = value;
            }
            get 
            {
                return user;
            }
        }

        /// <summary>
        /// Propiedad para guardar el nivel de permiso del usuario.
        /// </summary>
        public static int levelUser
        {
            set
            {
                level = value;
            }
            get
            {
                return level;
            }
        }

        /// <summary>
        /// Evita que se abra una segunda instancia del formulario.
        /// </summary>
        public static frmDeducibles DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmDeducibles();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void frmDeducibles_Load(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            comboFiltro.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
            this.WindowState = FormWindowState.Maximized;
            txtBusqueda.Focus();
            if (level != 0) 
            {
                btnTodos.Visible = false;
                separadorTodo.Visible = false;
                tabControlSecciones.TabPages.Remove(tabConsulta);
            }
            if (level == 3)
            {
                btnNuevo.Enabled = false;
                toolsEditar.Enabled = false;
                toolsCambio.Enabled = false;
                tools.Enabled = false;
                btnMakeCallAlt.Enabled = false;
                btnMakeCallHome.Enabled = false;
                bntMakeCallCell.Enabled = false;
                toolsLlamadaEntrante.Enabled = false;
            }
            else
            {
                btnNuevo.Enabled = true;
                toolsEditar.Enabled = true;
                toolsCambio.Enabled = true;
                tools.Enabled = true;
                btnMakeCallAlt.Enabled = true;
                btnMakeCallHome.Enabled = true;
                bntMakeCallCell.Enabled = true;
                toolsLlamadaEntrante.Enabled = true;
            }
            fechaInicio.MaxDate = DateTime.Today;
            fechaFin.MaxDate = DateTime.Today;
            tools.Visible = false;
        }

        /********************** NN **********************/

        /// <summary>
        /// Genera la búsqueda a través del campo buscar y de acuerdo al filtro seleccionado.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            resetControles();
            string filtro = comboFiltro.Text;
            string filtroColumna = "";
            string tipo = comboTipo.Text;
            string consulta;
            conexionBD db = new conexionBD();

            if (comboFiltro.SelectedIndex == 0) 
            {
                filtroColumna = "titular";
            } 
            else if (comboFiltro.SelectedIndex == 1) 
            {
                filtroColumna = "grupo";
            }
            else if (comboFiltro.SelectedIndex == 2)
            {
                filtroColumna = "vin";
            }
            else if (comboFiltro.SelectedIndex == 3)
            {
                filtroColumna = "platinum";
            }


            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Ingrese el término a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (comboTipo.SelectedIndex == 0)
                {
                    consulta = $"SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, fechaVisita AS 'Fecha de visita', montoPendiente FROM deducibles WHERE {filtroColumna} LIKE '%{txtBusqueda.Text}%'";
                }
                else
                {
                    consulta = $"SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, fechaVisita AS 'Fecha de visita', montoPendiente FROM deducibles WHERE {filtroColumna} ='{txtBusqueda.Text.ToUpper()}'";
                }
                try
                {
                    db.Conectar();
                    MySqlDataAdapter datos = db.Adaptar(consulta);
                    DataTable tabla = new DataTable();
                    int i = datos.Fill(tabla);
                    if (i < 1)
                    {
                        gridDatos.DataSource = null;
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        txtBusqueda.SelectionStart = 0;
                        txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
                        db.Desconectar();
                    }
                    else
                    {
                        txtBusqueda.SelectionStart = 0;
                        txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
                        gridDatos.DataSource = tabla;
                        formatoEncabezados();
                        gridDatos.CurrentCell = gridDatos[2,0];
                        db.Desconectar();

                        if (i == 1)
                        {
                            lblResultados.Text = i.ToString() + " resultado";
                            gridDatos.Focus();
                        }
                        else if (i == 0)
                        {
                            lblResultados.Text = "No se encontraron registros";
                        }
                        else if (i > 1)
                        {
                            lblResultados.Text = i.ToString() + " resultados";
                            gridDatos.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Desconectar();
                }            
            }            
        }

        /// <summary>
        /// Abre formulario para agregar un nuevo expediente.
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            frmDeduciblesAgregar deducible = new frmDeduciblesAgregar(UsuarioActivo);
            deducible.Show();
            btnNuevo.Enabled = true;
        }

        /// <summary>
        /// Muestra los registros de acuerdo a los botones de la barra de herramientas.
        /// </summary>
        /// <param name="tipo">Tipo de búsqueda.</param>
        private void verRegistros(string tipo)
        {
            resetControles();
            string consulta = "";
            conexionBD db = new conexionBD();

            if(tipo == "proceso")
            {
               consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaC3 As 'Entrega a C3', " 
                    + "aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=0 ORDER BY fechaC3";
            }
            else if(tipo == "incompleto")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, fechaVisita AS 'Fecha de visita', "
                    + "platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=1 ORDER BY fechaVisita";
            }
            else if (tipo == "procedente")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaDictamen AS 'Envio de dictamen', "
                    + "aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=2 ORDER BY fechaDictamen";
            }
            else if (tipo == "no procedente")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaDictamen AS 'Envio de dictamen', "
                    + "aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=3 ORDER BY fechaDictamen";
            }
            else if (tipo == "para envio") 
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaRecepcion AS 'Recepcion', " 
                    + "aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=4 ORDER BY fechaRecepcion";
            }
            else if (tipo == "entregado")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaPQR AS 'Envio a C3', "
                    + "aseguradora AS Aseguradora, platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE status=5 ORDER BY fechaPQR";
            }
            else if (tipo == "good will")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, "
                    + "platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE goodWill=1 ORDER BY fechaGoodWill";
            }
            else if (tipo == "monto")
            {
                consulta = "SELECT clave, status, titular AS Titular, aseguradora AS Aseguradora, grupo AS Contrato, fechaDictamen AS 'Envio de dictamen',"
                    + "platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE montoPendiente=1 ORDER BY fechaDictamen";
            }
            else if (tipo == "todo")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, fechaVisita AS 'Fecha de visita',"
                    + "aseguradora AS Aseguradora,  platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles ORDER BY fechaVisita";
            }            
            else if (tipo == "fechaDictamen")
            {
                DateTime inicio = fechaInicio.Value;
                DateTime fin = fechaFin.Value;

                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, fechaDictamen AS 'Envio de dictamen', "
                    + " platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE fechaDictamen BETWEEN '"
                    + inicio.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + fin.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY fechaDictamen ASC;";
            }
            else if (tipo == "fechaVisita")
            {
                DateTime inicio = fechaInicio.Value; 
                DateTime fin = fechaFin.Value;

                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, fechaVisita AS 'Fecha de visita', "
                    + "platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE fechaVisita BETWEEN '"
                    + inicio.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + fin.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY fechaVisita ASC;";
            }
            else if (tipo == "fechaRecepcion")
            {
                DateTime inicio = fechaInicio.Value;
                DateTime fin = fechaFin.Value;

                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, fechaRecepcion AS 'Recepcion', "
                    + "platinum AS Platinum, vin AS VIN, montoPendiente FROM deducibles WHERE fechaRecepcion BETWEEN '"
                    + inicio.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + fin.ToString("yyyy-MM-dd") + " 23:59:59' ORDER BY fechaRecepcion ASC;";
            }
            else if (tipo == "Good Will")
            {
                string mes = obtenNumeroDeMes(comboGWmes);

                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, platinum AS Platinum, "
                    + "vin AS VIN, fechaDictamen AS 'Envio de dictamen', montoPendiente FROM deducibles WHERE goodWill=1 " + "AND fechaGoodWill='" + comboGWyear.Text + "-" + mes 
                    + "' ORDER BY fechaGoodWill;";
            }
            else if (tipo == "Good Will Todo")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, "
                     + "platinum AS Platinum, vin AS VIN, fechaDictamen AS 'Envio de dictamen', montoPendiente FROM deducibles WHERE goodWill=1 ORDER BY fechaGoodWill;";
            }
            else if (tipo == "archivados")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, "
                    + "platinum AS Platinum, vin AS VIN, fechaVisita AS 'Fecha de visita', montoPendiente FROM deducibles WHERE status=6 ORDER BY fechaVisita";
            }
            else if (tipo == "candidato")
            {
                consulta = "SELECT clave, status, titular AS Titular, grupo AS Contrato, aseguradora AS Aseguradora, "
                     + "platinum AS Platinum, vin AS VIN, fechaVisita AS 'Fecha de visita', montoPendiente FROM deducibles WHERE candidato=1 ORDER BY fechaDictamen";
            }

            try
            {
                int i = -1;
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(consulta);
                DataTable tabla = new DataTable();
                
                datos.Fill(tabla);                
                gridDatos.DataSource = tabla;
                formatoEncabezados();

                i = gridDatos.RowCount;

                if (i == 1)
                {
                    lblResultados.Text = i.ToString() + " resultado";
                    gridDatos.Focus();
					gridDatos.CurrentCell = gridDatos[2, 0];
                }
                else if (i == 0) 
                {
                    lblResultados.Text = "No se encontraron registros";
                }
                else if (i > 1) 
                {
                    lblResultados.Text = i.ToString() + " resultados";
                    gridDatos.Focus();
					gridDatos.CurrentCell = gridDatos[2, 0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Desconectar();
            }

        }

        /// <summary>
        /// Devuelve el número de mes de acuerdo al nombre.
        /// </summary>
        /// <param name="cmb">Combobox con la lista de meses</param>
        /// <returns>Número de mes 1-12</returns>
        private string obtenNumeroDeMes(ComboBox cmb)
        {
            string mes = "";

            if (cmb.Text == "Enero")
            {
                mes = "01";
            }
            else if (cmb.Text == "Febrero")
            {
                mes = "02";
            }
            else if (cmb.Text == "Marzo")
            {
                mes = "03";
            }
            else if (cmb.Text == "Abril")
            {
                mes = "04";
            }
            else if (cmb.Text == "Mayo")
            {
                mes = "05";
            }
            else if (cmb.Text == "Junio")
            {
                mes = "06";
            }
            else if (cmb.Text == "Julio")
            {
                mes = "07";
            }
            else if (cmb.Text == "Agosto")
            {
                mes = "08";
            }
            else if (cmb.Text == "Septiembre")
            {
                mes = "09";
            }
            else if (cmb.Text == "Octubre")
            {
                mes = "10";
            }
            else if (cmb.Text == "Noviembre")
            {
                mes = "11";
            }
            else if (cmb.Text == "Diciembre")
            {
                mes = "12";
            }
            return mes;
        }

        private void formatoEncabezados() 
        {      
            gridDatos.Columns[0].Visible = false; 
            gridDatos.Columns[1].HeaderText = "";
            gridDatos.Columns[8].Visible = false;
        }

        private void enProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("proceso");
        }

        private void incompletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("incompleto");
        }

        private void procedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("procedente");
        }

        private void noProcedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("no procedente");
        }

        private void GoodWillStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("good will");
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("todo");
        }

        private void itemVer_ButtonClick(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("incompleto");
        }

        private void paraEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("para envio");
        }

        private void entregadoStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("entregado");
        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            txtBusqueda.SelectionStart = 0;
            txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
        }

        private void txtBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.SelectionStart = 0;
            txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
        }        

        /// <summary>
        /// Realiza búsqueda de expedientes de acuerdo a las fechas seleccionadas.
        /// </summary>
        private void btnBuscarfecha_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            DateTime inicio = Convert.ToDateTime(fechaInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            DateTime fin = Convert.ToDateTime(fechaFin.Value.ToString("yyyy-MM-dd") + " 23:59:59");            

            if (inicio < fin)
            {
                if (comboFiltroFecha.SelectedIndex == 0) //Dictamen
                {
                    verRegistros("fechaDictamen");
                }
                else if (comboFiltroFecha.SelectedIndex == 1) //Visita
                {
                    verRegistros("fechaVisita");
                }
                else if (comboFiltroFecha.SelectedIndex == 2) //Recepción
                {
                    verRegistros("fechaRecepcion");
                }
            }
            else 
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Regresa los campos a sus valores predeterminados.
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {            
            gridDatos.DataSource = null;
            resetControles();

            if (tabControlSecciones.SelectedIndex == 0)
            {
                txtBusqueda.Text = "";
                lblResultados.Text = "";
                txtBusqueda.Focus();
                this.AcceptButton = btnBuscar;
            }
            else if (tabControlSecciones.SelectedIndex == 1)
            {
                fechaInicio.MaxDate = DateTime.Today;
                fechaFin.MaxDate = DateTime.Today;
                fechaFin.Value = DateTime.Today;
                fechaInicio.Value = DateTime.Today;                
                lblResultados.Text = "";
                comboFiltroFecha.SelectedIndex = 0;
            }
            else if (tabControlSecciones.SelectedIndex == 2)
            {
                comboGWyear.Text = DateTime.Now.Year.ToString();
                radioGWfecha.Checked = true;
                lblResultados.Text = "";
            }
            else if (tabControlSecciones.SelectedIndex == 3)
            {
                txtQuery.Text = "";
                txtQuery.Focus();
                this.AcceptButton = btnExecuteQuery;
            }
        }

        /// <summary>
        /// Realiza el formato por color de acuerdo al status del expediente.
        /// </summary>
        private void gridDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {            
            if (gridDatos.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value.ToString() == "0") //En proceso
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "1") //Incompleto
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "2") //Procedente
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "3") //No procedente
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "4") //Para envío
                {
                    e.CellStyle.BackColor = Color.DarkBlue;
                    e.CellStyle.ForeColor = Color.DarkBlue;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "5") //Entregado
                {
                    e.CellStyle.BackColor = Color.Chartreuse;
                    e.CellStyle.ForeColor = Color.Chartreuse;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }
                if (e.Value.ToString() == "6") //Archivado
                {
                	e.CellStyle.BackColor = Color.Sienna;
                    e.CellStyle.ForeColor = Color.Sienna;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }
            }
        }

        private void gridDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolsGuardar.Enabled = false;
            toolsEditar.Enabled = true;
            toolsCancelar.Enabled = false;
            estadoControles(false);
            estadoControles(false);
            idDeducible = gridDatos.CurrentRow.Cells["clave"].Value.ToString();
            statusExpediente = Convert.ToInt16(gridDatos.CurrentRow.Cells["status"].Value);
            montoP = Convert.ToInt16(gridDatos.CurrentRow.Cells["montoPendiente"].Value);
            panelFile.Visible = true;
            panelStatus.Visible = true;
            groupComentarios.Visible = true;
            groupHistorialLlamadas.Visible = true;
            tools.Visible = true;
            loadDataMod();
        }
        
        /// <summary>
        /// Reestablece los campos a sus valores predeterminados al cambiar de expediente o realizar busquedas.
        /// </summary>
        private void resetControles()
        {
            panelFile.Visible = false;
            panelStatus.Visible = false;
            groupComentarios.Visible = true;
            groupHistorialLlamadas.Visible = true;
            tools.Visible = false;
            txtEmail.Text = "";
            txtExpediente.Text = "";
            txtGrupo.Text = "";
            txtPlatinum.Text = "";
            txtTelAlterno.Text = "";
            txtTelCelular.Text = "";
            txtTelDomicilio.Text = "";
            txtTitular.Text = "";
            txtVin.Text = "";
            dateC3.Value = DateTime.Today;
            dateDictamen.Value = DateTime.Today;
            dateFechaProbable.Value = DateTime.Today;
            datePqr.Value = DateTime.Today;
            dateRecepcion.Value = DateTime.Today;
            dateRobo.Value = DateTime.Today;
            dateVisita.Value = DateTime.Today;
            numDeducible.Value = 0;
            numDiasProceso.Value = 0;
            numGoodWillPorc.Value = 50;
            numMonto.Value = 0;
            numSumaA.Value = 0;
            numValorFactura.Value = 0;
            gridComentarios.DataSource = null;
            gridLlamadas.DataSource = null;
            gridDatos.DataSource = null;
            boxEstado.BackColor = SystemColors.Control;
            lblStatusCall.Visible = false;
            lblStatusComment.Visible = false;
            checkAcred.Checked = false;
            checkActa.Checked = false;
            checkAcuse.Checked = false;
            checkBaja.Checked = false;
            checkCartaPerdida.Checked = false;
            checkContrato.Checked = false;
            checkFactura.Checked = false;
            checkFiniquito.Checked = false;
            checkFiniquito.Checked = false;
            checkGoodWill.Checked = false;
            checkIdentificacion.Checked = false;
            checkPagoBaja.Checked = false;
            checkPfp.Checked = false;
            checkPoliza.Checked = false;
            checkTenencia.Checked = false;
            dateC3.Visible = false;
            dateC3.Visible = false;
            dateC3.Visible = false;
            dateC3.Visible = false;
            dateC3.Visible = false;
        }

        /********************** EDICION DE EXPEDIENTES **********************/

        /// <summary>
        /// Realiza la carga de expediente, comentarios y registros de llamadas.
        /// </summary>
        private void loadDataMod()
        {
            loadComment();   //Carga de comentarios
            loadCallData();  //Carga de registro de llamadas
            loadFile();      //Carga de expediente
            toolsEditar.Enabled = true;
            toolsCambio.Enabled = true;
            toolsAddComment.Enabled = true;
        }

        /// <summary>
        /// Carga la lista de comentarios de acuerdo al id del expediente.
        /// </summary>
        private void loadComment()
        {

            string query = $"SELECT fecha, comentario, usuario FROM comentarios WHERE idExpediente='{this.idDeducible}' ORDER BY fecha DESC";
            conexionBD db = new conexionBD();
            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(query);
                DataTable tabla = new DataTable();
                int i = datos.Fill(tabla);

                if (i < 1)
                {
                    lblStatusComment.Visible = true;
                    gridComentarios.DataSource = null;
                    db.Desconectar();
                }
                else
                {
                    lblStatusComment.Visible = false;
                    gridComentarios.DataSource = tabla;
                    gridComentarios.Columns[0].HeaderText = "Fecha";
                    gridComentarios.Columns[1].HeaderText = "Comentario";
                    gridComentarios.Columns[2].HeaderText = "Usuario";
                    db.Desconectar();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar comentarios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
        }

        /// <summary>
        /// Carga la lista de llamadas de acuerdo al id del expediente.
        /// </summary>
        private void loadCallData()
        {
            string query = $"SELECT * FROM llamadas WHERE idExpediente='{idDeducible}' ORDER BY fecha DESC;";
            conexionBD db = new conexionBD();
            DataTable tabla = new DataTable();

            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(query);
                int i = datos.Fill(tabla);

                if (i < 1)
                {
                    lblStatusCall.Visible = true;
                    gridLlamadas.DataSource = null;
                    db.Desconectar();
                }
                else
                {
                    lblStatusCall.Visible = false;
                    gridLlamadas.DataSource = tabla;

                    gridLlamadas.Columns[0].Visible = false; //id
                    gridLlamadas.Columns[1].Visible = false; //idExpediente
                    gridLlamadas.Columns[2].HeaderText = "Fecha";
                    gridLlamadas.Columns[3].HeaderText = "Status";
                    gridLlamadas.Columns[4].HeaderText = "Tipo";
                    gridLlamadas.Columns[5].HeaderText = "Teléfono";
                    gridLlamadas.Columns[6].HeaderText = "Recibe llamada";
                    gridLlamadas.Columns[7].HeaderText = "Comentarios";
                    gridLlamadas.Columns[8].HeaderText = "Usuario";

                    db.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar llamadas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Desconectar();
            }
        }

        /// <summary>
        /// Carga los datos del expediente.
        /// </summary>
        private void loadFile()
        {
            conexionBD db = new conexionBD();
            DateTime fechaActual = DateTime.Now;
            MySqlDataReader respuesta;

            try
            {
                db.Conectar();
                respuesta = db.Buscar("SELECT * FROM deducibles WHERE clave='" + this.idDeducible + "';");
                respuesta.Read();

                this.statusExpediente = Convert.ToInt32(respuesta[2]);
                this.titular = respuesta[3].ToString();

                string pqr = respuesta[9].ToString();
                string recepcion = respuesta[8].ToString();
                string robo = respuesta[18].ToString();
                string visita = respuesta[7].ToString();
                string c3 = respuesta[11].ToString();

                string goodWill = respuesta[38].ToString();
                string candidato = respuesta[41].ToString();
                string montoPendiente = respuesta[42].ToString();

                if (this.statusExpediente == (int)status.ENPROCESO)
                {
                    boxEstado.BackColor = Color.Yellow;
                    numDiasProceso.Value = diasProceso(Convert.ToDateTime(c3), fechaActual);
                    groupGoodWill.Visible = false;
                    lblFechaProbable.Visible = true;
                    dateFechaProbable.Visible = true;
                    numDiasProceso.Visible = true;
                    lblDiasProceso.Visible = true;
                    toolCmontoPendiente.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = true;
                    dateRecepcion.Visible = true;
                    lblFechaPqr.Visible = true;
                    datePqr.Visible = true;
                    lblFechaC3.Visible = true;
                    dateC3.Visible = true;
                    lblFechaDictamen.Visible = false;
                    dateDictamen.Visible = false;

                    datePqr.Value = Convert.ToDateTime(pqr);
                    dateRecepcion.Value = Convert.ToDateTime(recepcion);
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = Convert.ToDateTime(c3);

                    if (candidato == "0") //No candidato
                    {
                        toolCgoodWill.Visible = true;
                        toolCgoodWillC.Visible = false;
                    }
                    else if (candidato == "1")
                    {
                        toolCgoodWill.Visible = false;
                        toolCgoodWillC.Visible = true;
                    }

                    marcaMontoPendiente(montoPendiente);
                }
                else if (this.statusExpediente == (int)status.INCOMPLETO)
                {
                    boxEstado.BackColor = Color.Orange;
                    numDiasProceso.Value = 0;
                    groupGoodWill.Visible = false;
                    lblFechaProbable.Visible = false;
                    dateFechaProbable.Visible = false;
                    numDiasProceso.Visible = false;
                    lblDiasProceso.Visible = false;
                    toolCmontoPendiente.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = false;
                    dateRecepcion.Visible = false;
                    lblFechaPqr.Visible = false;
                    datePqr.Visible = false;
                    lblFechaC3.Visible = false;
                    dateC3.Visible = false;
                    lblFechaDictamen.Visible = false;
                    dateDictamen.Visible = false;

                    datePqr.Value = DateTime.Now;
                    dateRecepcion.Value = DateTime.Now;
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = DateTime.Now;

                    if (candidato == "0") //No candidato
                    {
                        toolCgoodWill.Visible = true;
                        toolCgoodWillC.Visible = false;
                    }
                    else if (candidato == "1")
                    {
                        toolCgoodWill.Visible = false;
                        toolCgoodWillC.Visible = true;
                    }

                }
                else if (this.statusExpediente == (int)status.PROCEDENTE)
                {
                    boxEstado.BackColor = Color.Green;
                    string fechaDictamen = respuesta[10].ToString();
                    dateDictamen.Text = String.Format("{0:dd/MM/yyyy HH:mm:ss}", fechaDictamen);
                    numDiasProceso.Value = Convert.ToInt32(respuesta[12]);
                    groupGoodWill.Visible = false;
                    numDiasProceso.Visible = true;
                    lblDiasProceso.Visible = true;
                    lblFechaProbable.Visible = false;
                    dateFechaProbable.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = true;
                    dateRecepcion.Visible = true;
                    lblFechaPqr.Visible = true;
                    datePqr.Visible = true;
                    lblFechaC3.Visible = true;
                    dateC3.Visible = true;
                    lblFechaDictamen.Visible = true;
                    dateDictamen.Visible = true;

                    datePqr.Value = Convert.ToDateTime(pqr);
                    dateRecepcion.Value = Convert.ToDateTime(recepcion);
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = Convert.ToDateTime(c3);

                    toolCgoodWill.Visible = false;
                    toolCgoodWillC.Visible = false;

                    marcaMontoPendiente(montoPendiente);
                }
                else if (this.statusExpediente == (int)status.NOPROCEDENTE)
                {
                    boxEstado.BackColor = Color.Red;
                    string fechaDictamen = respuesta[10].ToString();
                    dateDictamen.Text = String.Format("{0:dd/MM/yyyy HH:mm:ss}", fechaDictamen);
                    numDiasProceso.Value = Convert.ToInt32(respuesta[12]);
                    groupGoodWill.Visible = true;
                    lblFechaProbable.Visible = false;
                    dateFechaProbable.Visible = false;
                    numDiasProceso.Visible = true;
                    lblDiasProceso.Visible = true;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = true;
                    dateRecepcion.Visible = true;
                    lblFechaPqr.Visible = true;
                    datePqr.Visible = true;
                    lblFechaC3.Visible = true;
                    dateC3.Visible = true;
                    lblFechaDictamen.Visible = true;
                    dateDictamen.Visible = true;

                    if (goodWill == "1")
                    {
                        string fechaGW = respuesta[39].ToString();
                        string[] fecha = fechaGW.Split('-');

                        checkGoodWill.Checked = true;
                        lblGoodWillYear.Visible = true;
                        comboGWdataYear.Visible = true;
                        lblGoodWillMes.Visible = true;
                        comboGWdataMes.Visible = true;
                        lblGoodWillPorc.Visible = true;
                        numGoodWillPorc.Value = Convert.ToInt32(respuesta[40]);
                        comboGWdataYear.Text = fecha[0];
                        comboGWdataMes.Text = mesAnumero(fecha[1]);
                        toolCgoodWill.Visible = false;
                        toolCgoodWillC.Visible = false;
                        marcaMontoPendiente(montoPendiente);
                    }
                    else
                    {
                        checkGoodWill.Checked = false;
                        lblGoodWillPorc.Visible = false;
                        numGoodWillPorc.Value = 50;
                        numGoodWillPorc.Visible = false;
                        lblGoodWillYear.Visible = false;
                        comboGWdataYear.Visible = false;
                        lblGoodWillMes.Visible = false;
                        comboGWdataMes.Visible = false;
                        toolCmontoPendiente.Visible = false;

                        if (candidato == "0")
                        {
                            toolCgoodWill.Visible = true;
                            toolCgoodWillC.Visible = false;
                        }
                        else if (candidato == "1")
                        {
                            toolCgoodWill.Visible = false;
                            toolCgoodWillC.Visible = true;
                        }
                    }

                    datePqr.Value = Convert.ToDateTime(pqr);
                    dateRecepcion.Value = Convert.ToDateTime(recepcion);
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = Convert.ToDateTime(c3);
                }
                else if (this.statusExpediente == (int)status.PARAENVIO)
                {
                    boxEstado.BackColor = Color.Navy;
                    numDiasProceso.Value = 0;
                    groupGoodWill.Visible = false;
                    numDiasProceso.Visible = false;
                    lblFechaProbable.Visible = false;
                    dateFechaProbable.Visible = false;
                    numDiasProceso.Visible = false;
                    lblDiasProceso.Visible = false;
                    toolCmontoPendiente.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = true;
                    dateRecepcion.Visible = true;
                    lblFechaPqr.Visible = false;
                    datePqr.Visible = false;
                    lblFechaC3.Visible = false;
                    dateC3.Visible = false;
                    lblFechaDictamen.Visible = false;
                    dateDictamen.Visible = false;

                    datePqr.Value = DateTime.Now;
                    dateRecepcion.Value = Convert.ToDateTime(recepcion);
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = DateTime.Now;
                    dateDictamen.Value = DateTime.Now;

                    if (candidato == "0") //No candidato
                    {
                        toolCgoodWill.Visible = true;
                        toolCgoodWillC.Visible = false;
                    }
                    else if (candidato == "1")
                    {
                        toolCgoodWill.Visible = false;
                        toolCgoodWillC.Visible = true;
                    }
                }
                else if (this.statusExpediente == (int)status.ENTREGADO)
                {
                    boxEstado.BackColor = Color.Chartreuse;
                    numDiasProceso.Value = 0;
                    groupGoodWill.Visible = false;
                    lblFechaProbable.Visible = true;
                    dateFechaProbable.Visible = true;
                    numDiasProceso.Visible = true;
                    lblDiasProceso.Visible = true;
                    numDiasProceso.Value = diasProceso(Convert.ToDateTime(pqr), fechaActual);
                    toolCmontoPendiente.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;
                    lblFechaRecepcion.Visible = true;
                    dateRecepcion.Visible = true;
                    lblFechaPqr.Visible = true;
                    datePqr.Visible = true;
                    lblFechaC3.Visible = false;
                    dateC3.Visible = false;
                    lblFechaDictamen.Visible = false;
                    dateDictamen.Visible = false;

                    datePqr.Value = Convert.ToDateTime(pqr);
                    dateRecepcion.Value = Convert.ToDateTime(recepcion);
                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);
                    dateC3.Value = DateTime.Now;
                    dateDictamen.Value = DateTime.Now;

                    if (candidato == "0") //No candidato
                    {
                        toolCgoodWill.Visible = true;
                        toolCgoodWillC.Visible = false;
                    }
                    else if (candidato == "1")
                    {
                        toolCgoodWill.Visible = false;
                        toolCgoodWillC.Visible = true;
                    }
                }
                else if (this.statusExpediente == (int)status.ARCHIVADO)
                {
                    boxEstado.BackColor = Color.Sienna;
                    numDiasProceso.Value = 0;
                    groupGoodWill.Visible = false;
                    lblFechaProbable.Visible = false;
                    dateFechaProbable.Value = DateTime.Now;
                    dateFechaProbable.Visible = false;
                    numDiasProceso.Visible = false;
                    lblDiasProceso.Visible = false;
                    toolCmontoPendiente.Visible = false;

                    lblFechaRobo.Visible = true;
                    dateRobo.Visible = true;
                    lblFechaVisita.Visible = true;
                    dateVisita.Visible = true;

                    lblFechaPqr.Visible = false;
                    datePqr.Visible = false;
                    lblFechaC3.Visible = false;
                    dateC3.Visible = false;
                    lblFechaDictamen.Visible = false;
                    dateDictamen.Visible = false;

                    dateRobo.Value = Convert.ToDateTime(robo);
                    dateVisita.Value = Convert.ToDateTime(visita);

                    /* TODO: Añadir validación para la fecha de recepción*/
                    dateRecepcion.Value = DateTime.Now;
                    lblFechaRecepcion.Visible = false;
                    dateRecepcion.Visible = false;

                    datePqr.Value = DateTime.Now;
                    dateC3.Value = DateTime.Now;
                    dateDictamen.Value = DateTime.Now;

                    toolCgoodWill.Visible = false;
                    toolCgoodWillC.Visible = false;
                }

                numDeducible.Value = Convert.ToInt16(respuesta[21]);
                numMonto.Value = Convert.ToDecimal(respuesta[22]);
                numValorFactura.Value = Convert.ToDecimal(respuesta[20]);

                txtEmail.Text = respuesta[17].ToString();
                txtGrupo.Text = respuesta[4].ToString();
                txtPlatinum.Text = respuesta[5].ToString();

                String telDomicilio = respuesta[14].ToString();
                String telCelular = respuesta[15].ToString();
                String telAlterno = respuesta[16].ToString();

                txtTelAlterno.Text =   (telAlterno.Length < 8)   ? "" : telAlterno;
                txtTelCelular.Text =   (telCelular.Length < 8)   ? "" : telCelular;
                txtTelDomicilio.Text = (telDomicilio.Length < 8) ? "" : telDomicilio;

                txtTitular.Text = respuesta[3].ToString();
                txtVin.Text = respuesta[6].ToString();

                cmbAseguradora.Text = respuesta[19].ToString();

                txtExpediente.Text = respuesta[23].ToString();

                if (this.statusExpediente == (int)status.ENPROCESO)
                {
                    dateFechaProbable.Value = diasLaborales(dateC3.Value);
                }
                else if (this.statusExpediente == (int)status.ENTREGADO)
                {
                    dateFechaProbable.Value = diasLaborales(datePqr.Value);
                }
                else
                {
                    dateFechaProbable.Value = DateTime.Now;
                }
                
                checkAcuse.Checked = respuesta[24].ToString() == "1" ? true : false;
                checkFiniquito.Checked = respuesta[25].ToString() == "1" ? true : false;

                numSumaA.Value = Convert.ToDecimal(respuesta[26]);

                checkCartaPerdida.Checked = respuesta[27].ToString() == "1" ? true : false;
                checkPoliza.Checked = respuesta[28].ToString() == "1" ? true : false;
                checkFactura.Checked = respuesta[29].ToString() == "1" ? true : false;
                checkActa.Checked = respuesta[30].ToString() == "1" ? true : false;
                checkAcred.Checked = respuesta[31].ToString() == "1" ? true : false;
                checkBaja.Checked = respuesta[32].ToString() == "1" ? true : false;
                checkPagoBaja.Checked = respuesta[33].ToString() == "1" ? true : false;
                checkTenencia.Checked = respuesta[34].ToString() == "1" ? true : false;
                checkIdentificacion.Checked = respuesta[35].ToString() == "1" ? true : false;
                checkPfp.Checked = respuesta[36].ToString() == "1" ? true : false;
                checkContrato.Checked = respuesta[37].ToString() == "1" ? true : false;

                db.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar expediente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
        }

        /// <summary>
        /// Activa o desactiva el botón de monto pendiente.
        /// </summary>
        /// <param name="estado">0: Muestra botón. 1: Oculta botón.</param>
        private void marcaMontoPendiente(string estado)
        {
            if (estado == "0")
                toolCmontoPendiente.Visible = true;
            else if (estado == "1")
                toolCmontoPendiente.Visible = false;
        }

        /// <summary>
        /// Gerera consulta SQL de acuerdo al estado del expediente.
        /// </summary>
        /// <returns>Consulta SQL para carga de expediente.</returns>
        private string getConsulta()
        {
            string texto = "";
            int acuse = 9;
            int finiquito = 9;
            int montoPendiente = -1;

            if (checkAcuse.Checked)
            {
                acuse = 1;
            }
            else
            {
                acuse = 0;
            }

            if (checkFiniquito.Checked)
            {
                finiquito = 1;
            }
            else
            {
                finiquito = 0;
            }

            long telCasa = 0;
            long telCel = 0;
            long telAlt = 0;

            if (txtTelDomicilio.Text != "")
            {
                telCasa = Convert.ToInt64(txtTelDomicilio.Text);
            }

            if (txtTelCelular.Text != "")
            {
                telCel = Convert.ToInt64(txtTelCelular.Text);
            }

            if (txtTelAlterno.Text != "")
            {
                telAlt = Convert.ToInt64(txtTelAlterno.Text);
            }


            if (this.statusExpediente == (int)status.ENPROCESO)
            {
                montoPendiente = isMontoPendiente();

                texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                    + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='"
                    + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='"
                    + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaPqr='"
                    + datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaC3='"
                    + dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', telefonoDomicilio=" + telCasa + ", telefonoCelular="
                    + telCel + ", telefonoAdicional=" + telAlt + ", email='" + txtEmail.Text + "', fechaRobo='"
                    + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', aseguradora='" + cmbAseguradora.Text
                    + "', valorFactura=" + numValorFactura.Value + ", valorDeducible=" + numDeducible.Value + ", montoPago="
                    + numMonto.Value + ", expediente='" + txtExpediente.Text + "', acuse =" + acuse + ", finiquito="
                    + finiquito + ", sumaAsegurada=" + numSumaA.Value + ", " + getDocs() + ", montoPendiente=" + montoPendiente + " WHERE clave='" + this.idDeducible
                    + "';";
            }
            else if ((this.statusExpediente == (int)status.INCOMPLETO) || (this.statusExpediente == (int)status.ARCHIVADO))
            {
                texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                    + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='"
                    + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', telefonoDomicilio=" + telCasa
                    + ", telefonoCelular=" + telCel + ", telefonoAdicional=" + telAlt + ", email='" + txtEmail.Text
                    + "', fechaRobo='" + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', aseguradora='"
                    + cmbAseguradora.Text + "', valorFactura=" + numValorFactura.Value + ", valorDeducible="
                    + numDeducible.Value + ", montoPago=" + numMonto.Value + ", expediente='"
                    + txtExpediente.Text + "', acuse =" + acuse + ", finiquito=" + finiquito + ", sumaAsegurada="
                    + numSumaA.Value + ", " + getDocs() + " WHERE clave='" + this.idDeducible + "';";
            }
            else if (this.statusExpediente == (int)status.PROCEDENTE)
            {
                montoPendiente = isMontoPendiente();

                texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                    + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='"
                    + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='"
                    + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaPqr='"
                    + datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaC3='"
                    + dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaDictamen='"
                    + dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', diasProceso=" + numDiasProceso.Value
                    + ", telefonoDomicilio=" + telCasa + ", telefonoCelular=" + telCel + ", telefonoAdicional=" + telAlt
                    + ", email='" + txtEmail.Text + "', fechaRobo='" + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    + "', aseguradora='" + cmbAseguradora.Text + "', valorFactura=" + numValorFactura.Value
                    + ", valorDeducible=" + numDeducible.Value + ", montoPago=" + numMonto.Value + ", expediente='" 
                    + txtExpediente.Text + "', acuse =" + acuse + ", finiquito=" + finiquito + ", sumaAsegurada=" 
                    + numSumaA.Value + ", " + getDocs() + ", montoPendiente=" + montoPendiente + " WHERE clave='" 
                    + this.idDeducible + "';";
            }
            else if (this.statusExpediente == (int)status.NOPROCEDENTE)
            {
                if (checkGoodWill.Checked) // Si tiene Good Will otorgado
                {
                    montoPendiente = isMontoPendiente();

                    texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                        + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='"
                        + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='"
                        + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaPqr='"
                        + datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaC3='"
                        + dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaDictamen='"
                        + dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', diasProceso=" + numDiasProceso.Value
                        + ", telefonoDomicilio=" + telCasa + ", telefonoCelular=" + telCel + ", telefonoAdicional=" + telAlt
                        + ", email='" + txtEmail.Text + "', fechaRobo='" + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss")
                        + "', aseguradora='" + cmbAseguradora.Text + "', valorFactura=" + numValorFactura.Value
                        + ", valorDeducible=" + numDeducible.Value + ", montoPago=" + numMonto.Value + ", expediente='" 
                        + txtExpediente.Text + "', acuse =" + acuse + ", finiquito=" + finiquito + ", sumaAsegurada=" 
                        + numSumaA.Value + ", " + getDocs() + ", goodWill=1, fechaGoodWill='" + comboGWdataYear.Text 
                        + "-" + obtenNumeroDeMes(comboGWdataMes) + "', porcentajeGoodWill=" + numGoodWillPorc.Value 
                        + ", candidato=0, montoPendiente=" + montoPendiente + " WHERE clave='" + this.idDeducible + "';";
                }
                else 
                {
                    texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                        + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='"
                        + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='"
                        + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaPqr='"
                        + datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaC3='"
                        + dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaDictamen='"
                        + dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', diasProceso=" + numDiasProceso.Value
                        + ", telefonoDomicilio=" + telCasa + ", telefonoCelular=" + telCel + ", telefonoAdicional=" + telAlt
                        + ", email='" + txtEmail.Text + "', fechaRobo='" + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss")
                        + "', aseguradora='" + cmbAseguradora.Text + "', valorFactura=" + numValorFactura.Value
                        + ", valorDeducible=" + numDeducible.Value + ", montoPago=" + numMonto.Value + ", expediente='" 
                        + txtExpediente.Text + "', acuse =" + acuse + ", finiquito=" + finiquito + ", sumaAsegurada=" 
                        + numSumaA.Value + ", " + getDocs() + ", goodWill=0, fechaGoodWill='0000-00', porcentajeGoodWill=0 WHERE clave='" 
                        + this.idDeducible + "';";
                }                
            }
            else if (this.statusExpediente == (int)status.PARAENVIO)
            {
                texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                    + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='" 
                    + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='"
                    + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', telefonoDomicilio=" + telCasa 
                    + ", telefonoCelular=" + telCel + ", telefonoAdicional=" + telAlt + ", email='" + txtEmail.Text 
                    + "', fechaRobo='" + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', aseguradora='" 
                    + cmbAseguradora.Text + "', valorFactura=" + numValorFactura.Value + ", valorDeducible=" 
                    + numDeducible.Value + ", montoPago=" + numMonto.Value + ", expediente='" 
                    + txtExpediente.Text + "', acuse =" + acuse + ", finiquito=" + finiquito + ", sumaAsegurada=" 
                    + numSumaA.Value + ", " + getDocs() + " WHERE clave='" + this.idDeducible + "';";
            }
            else if (this.statusExpediente == (int)status.ENTREGADO)
            {
                texto = "UPDATE deducibles SET titular='" + txtTitular.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text)
                   + ", platinum='" + txtPlatinum.Text + "', vin='" + txtVin.Text + "', fechavisita='" 
                   + dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRecepcion='" 
                   + dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaPqr='" 
                   + datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', telefonoDomicilio=" + telCasa + ", telefonoCelular=" 
                   + telCel + ", telefonoAdicional=" + telAlt + ", email='" + txtEmail.Text + "', fechaRobo='" 
                   + dateRobo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', aseguradora='" + cmbAseguradora.Text
                   + "', valorFactura=" + numValorFactura.Value + ", valorDeducible=" + numDeducible.Value + ", montoPago=" 
                   + numMonto.Value + ", expediente='" + txtExpediente.Text + "', acuse =" + acuse + ", finiquito="
                   + finiquito + ", sumaAsegurada=" + numSumaA.Value + ", " + getDocs() + " WHERE clave='" + this.idDeducible 
                   + "';";
            }
            
            return texto;
        }

        private int isMontoPendiente()
        {
            if (this.montoP == 1)
            {
                if (numMonto.Value == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Calcula fecha aproximada de respuesta de un expediente.
        /// El tiempo máximo de respuesta es de 30 días hábiles.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        private DateTime diasLaborales(DateTime fecha)
        {
            int dias = 30;

            while (dias != 0)
            {
                fecha = fecha.AddDays(1);
                if ((fecha.DayOfWeek != DayOfWeek.Saturday) && (fecha.DayOfWeek != DayOfWeek.Sunday))
                {
                    dias--;
                }
            }
            return fecha;
        }

        /// <summary>
        /// Calcula los días hábiles transcurridos entre dos fechas.
        /// </summary>
        /// <param name="inicio">Fecha de inicio.</param>
        /// <param name="fin">Fecha final.</param>
        /// <returns>Días hábiles transcurridos.</returns>
        private int diasProceso(DateTime inicio, DateTime fin)
        {
            TimeSpan diferencia = fin - inicio;
            int dias = diferencia.Days;
            int i = 0;
            int semanas = dias / 7;
            int finSemanas = semanas * 2;

            i = dias - finSemanas;

            return i;
        }

        /// <summary>
        /// Genera cadena para la carga de lista de documentos.
        /// Se usa para no sobrecargar el código en las consultas.
        /// </summary>
        /// <returns>Consulta para lista de documentos.</returns>
        private string getDocs()
        {
            string queryDocs = "";

            int cartaPerdida = checkCartaPerdida.Checked ? 1 : 0;
            int poliza = checkPoliza.Checked ? 1 : 0;
            int factura = checkFactura.Checked ? 1 : 0;
            int acta = checkActa.Checked ? 1 : 0;
            int acred = checkAcred.Checked ? 1 : 0;
            int baja = checkBaja.Checked ? 1 : 0;
            int pagoBaja = checkPagoBaja.Checked ? 1 : 0;
            int tenencia = checkTenencia.Checked ? 1 : 0;
            int identificacion = checkIdentificacion.Checked ? 1 : 0;
            int pfp = checkPfp.Checked ? 1 : 0;
            int contrato = checkContrato.Checked ? 1 : 0;

            queryDocs = "cartaPerdida=" + cartaPerdida + ", poliza=" + poliza + ", factura=" + factura + ", acta=" + acta
                + ", acred=" + acred + ", baja=" + baja + ", pagoBaja=" + pagoBaja + ", tenencia=" + tenencia
                + ", identificacion=" + identificacion + ", pfp=" + pfp + ", contrato=" + contrato;

            return queryDocs;
        }


        /// <summary>
        /// Calcula el monto a pagar por deducible.
        /// </summary>
        private void calculaPago()
        {
            decimal porcentaje = numDeducible.Value;
            decimal sumaAsegurada = numSumaA.Value;
            decimal valorFactura = numValorFactura.Value;
            decimal montoDeducible = 0;
            decimal montoPago = 0;
            decimal IVA = 1.16m;

            if (porcentaje > 0)
            {
                if (sumaAsegurada > 0)
                {
                    if (porcentaje > 20)
                    {
                        montoDeducible = (sumaAsegurada) * 0.20m;
                        montoPago = montoDeducible / IVA;
                        if (toolsEditar.Enabled == false)
                        {
                            numMonto.Value = (sumaAsegurada) * (porcentaje / 100);
                        }                        
                        MessageBox.Show("El valor máximo a pagar es del 20%.\nEl monto del deducible al 20% es de " 
                            + montoDeducible.ToString("c2") + "\nEl monto a pagar es de " + montoPago.ToString("c2"), 
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        montoDeducible = (sumaAsegurada) * (porcentaje / 100);
                        montoPago = montoDeducible / IVA;                        
                        if (toolsEditar.Enabled == false)
                        {
                            numMonto.Value = montoDeducible;
                        }
                        MessageBox.Show("El monto del deducible es de " + montoDeducible.ToString("c2") 
                            + "\nEl monto a pagar es de " + montoPago.ToString("c2"), "Información", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario capturar la suma asegurada.", "No es posible realizar el cálculo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //Porcentaje es cero
            {
                MessageBox.Show("Es necesario capturar el porcentaje del deducible.", "No es posible realizar el cálculo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMakeCallHome_Click(object sender, EventArgs e)
        {
            string tel = txtTelDomicilio.Text;

            if (tel != "0")
            {
                frmLlamadasAgregar frm = new frmLlamadasAgregar(UsuarioActivo, tel, "domicilio", idDeducible, "Outbound");
                frm.ShowDialog();
                loadCallData();
            }
            else
            {
                MessageBox.Show("No hay número que registrar. Seleccione otro teléfono.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }     
        }

        private void bntMakeCallCell_Click(object sender, EventArgs e)
        {
            string tel = txtTelCelular.Text;

            if (tel != "0")
            {
                frmLlamadasAgregar frm = new frmLlamadasAgregar(UsuarioActivo, tel, "celular", idDeducible, "Outbound");
                frm.ShowDialog();
                loadCallData();
            }
            else
            {
                MessageBox.Show("No hay número que registrar. Seleccione otro teléfono.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }       
        }

        private void btnMakeCallAlt_Click(object sender, EventArgs e)
        {
            string tel = txtTelAlterno.Text;

            if (tel != "0")
            {
                frmLlamadasAgregar frm = new frmLlamadasAgregar(UsuarioActivo, tel, "alterno", idDeducible, "Outbound");
                frm.ShowDialog();
                loadCallData();
            }
            else
            {
                MessageBox.Show("No hay número que registrar. Seleccione otro teléfono.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void toolsSalir_Click(object sender, EventArgs e)
        {
            frmAddComment frm = new frmAddComment(this.idDeducible, UsuarioActivo, "deducibles");
            frm.ShowDialog();
            loadComment();
        }

        private void toolsCambio_Click(object sender, EventArgs e)
        {
            if ((this.statusExpediente == (int)status.PROCEDENTE) || (this.statusExpediente == (int)status.NOPROCEDENTE) || (this.statusExpediente == (int)status.ARCHIVADO))
            {
                MessageBox.Show("No se puede cambiar el estado. El expediente se encuentra cerrado.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                estadoControles(false);
                frmDeduciblesCambioStatus cambiaStatus = new frmDeduciblesCambioStatus(this.idDeducible, this.statusExpediente, 
                    this.titular, UsuarioActivo);
                cambiaStatus.ShowDialog();
                loadDataMod();
                toolsCancelar.Enabled = false;
                toolsGuardar.Enabled = false;
            }            
        }

        /// <summary>
        /// Activa o desactiva los controles.
        /// </summary>
        /// <param name="status">True o False</param>
        private void estadoControles(Boolean status)
        {
            dateDictamen.Enabled = status;
            dateFechaProbable.Enabled = status;
            datePqr.Enabled = status;
            dateRecepcion.Enabled = status;
            dateRobo.Enabled = status;
            dateVisita.Enabled = status;
            dateC3.Enabled = status;
            numDeducible.Enabled = status;
            numDiasProceso.Enabled = status;
            numMonto.Enabled = status;
            numValorFactura.Enabled = status;
            numSumaA.Enabled = status;
            txtEmail.ReadOnly = !status;
            txtGrupo.ReadOnly = !status;
            txtPlatinum.ReadOnly = !status;
            txtTelAlterno.ReadOnly = !status;
            txtTelCelular.ReadOnly = !status;
            txtTelDomicilio.ReadOnly = !status;
            txtTitular.ReadOnly = !status;
            txtVin.ReadOnly = !status;
            cmbAseguradora.Enabled = status;
            txtExpediente.Enabled = status;
            checkAcuse.Enabled = status;
            checkFiniquito.Enabled = status;
            checkCartaPerdida.Enabled = status;
            checkPoliza.Enabled = status;
            checkFactura.Enabled = status;
            checkActa.Enabled = status;
            checkAcred.Enabled = status;
            checkBaja.Enabled = status;
            checkPagoBaja.Enabled = status;
            checkTenencia.Enabled = status;
            checkIdentificacion.Enabled = status;
            checkPfp.Enabled = status;
            checkContrato.Enabled = status;
            checkGoodWill.Enabled = status;
            numGoodWillPorc.Enabled = status;
            comboGWdataMes.Enabled = status;
            comboGWdataYear.Enabled = status;
        }

        private void toolsEditar_Click(object sender, EventArgs e)
        {
            estadoControles(true);
            txtTelDomicilio.Mask = "00-0000-0000";
            txtTelCelular.Mask = "00-0000-0000";
            txtTelAlterno.Mask = "00-0000-0000";

            toolsEditar.Enabled = false;
            toolsCancelar.Enabled = true;
            toolsGuardar.Enabled = true;
            if (this.statusExpediente == (int)status.ENPROCESO)
            {
                numDiasProceso.Enabled = false;
                dateFechaProbable.Enabled = false;
            }
        }

        private void toolsCancelar_Click(object sender, EventArgs e)
        {
            toolsGuardar.Enabled = false;
            toolsEditar.Enabled = true;
            toolsCancelar.Enabled = false;
            estadoControles(false);
            loadFile();
        }

        private void toolsGuardar_Click(object sender, EventArgs e)
        {
            estadoControles(false);
            toolsCancelar.Enabled = false;
            toolsGuardar.Enabled = false;
            string consulta = "";
            conexionBD db = new conexionBD();
            int i = 0;

            consulta = getConsulta();

            try
            {
                db.Conectar();
                i = db.Modificar(consulta);
                if (i > 0)
                {
                    db.lastModify(this.idDeducible, UsuarioActivo, "Edited", "");
                    MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    db.Desconectar();
                    loadDataMod();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
                estadoControles(false);
                toolsEditar.Enabled = true;
            }
        }

        private void checkGoodWill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGoodWill.Checked == true)
            {
                lblGoodWillPorc.Visible = true;
                numGoodWillPorc.Visible = true;
                lblGoodWillYear.Visible = true;
                comboGWdataYear.Visible = true;
                lblGoodWillMes.Visible = true;
                comboGWdataMes.Visible = true;
                comboGWdataMes.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month-1);
                comboGWdataYear.Text = DateTime.Now.Year.ToString();
            }
            else 
            {
                lblGoodWillPorc.Visible = false;
                numGoodWillPorc.Visible = false;
                lblGoodWillYear.Visible = false;
                comboGWdataYear.Visible = false;
                lblGoodWillMes.Visible = false;
                comboGWdataMes.Visible = false;
            }
        }

        private void lblMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            calculaPago();
        }

        private void frmDeducibles_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.L))
            {
                txtBusqueda.Focus();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.B))
            {
                gridDatos.Focus();
            }
        }

        private void btnParaEnvio_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("para envio");
        }

        private void btnPQR_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("entregado");
        }

        private void btnEnProceso_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("proceso");
        }

        private void btnIncompleto_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("incompleto");
        }

        private void btnProcedente_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("procedente");
        }

        private void btnNoProcedente_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("no procedente");
        }

        private void btnGoodWill_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("good will");
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("todo");
        }

        private void btnMontos_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("monto");
        }

        private void btnBuscarGW_Click(object sender, EventArgs e)
        {
            if (radioGWfecha.Checked)
            {
                verRegistros("Good Will");
            }
            else if (radioGWtodos.Checked)
            {
                verRegistros("Good Will Todo");
            }

        }

        private void btnCandidato_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("candidato");
        }

        private void radioGWtodos_CheckedChanged(object sender, EventArgs e)
        {
            comboGWmes.Enabled = false;
            comboGWyear.Enabled = false;
        }

        private void radioGWfecha_CheckedChanged(object sender, EventArgs e)
        {
            comboGWmes.Enabled = true;
            comboGWyear.Enabled = true;
        }        

        private void toolsLlamadaEntrante_Click(object sender, EventArgs e)
        {
            frmLlamadasAgregar frm = new frmLlamadasAgregar(UsuarioActivo, "", "Llamada entrante", idDeducible, "Inbound");
            frm.ShowDialog();
            loadCallData();
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();     
        }

        private void ejecutarConsulta()
        {
            if (txtQuery.Text != "")
            {
                conexionBD db = new conexionBD();
                String consulta = $"SELECT clave, status, titular, aseguradora, grupo, platinum, vin, fechaVisita, montoPendiente FROM deducibles WHERE {txtQuery.Text}";

                try
                {
                    db.Conectar();
                    MySqlDataAdapter datos = db.Adaptar(consulta);
                    DataTable tabla = new DataTable();
                    int i = datos.Fill(tabla);
                    if (i < 1)
                    {
                        gridDatos.DataSource = null;
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        txtQuery.SelectionStart = 0;
                        txtQuery.SelectionLength = txtBusqueda.Text.Length;
                        db.Desconectar();
                    }
                    else
                    {
                        txtBusqueda.SelectionStart = 0;
                        txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
                        gridDatos.DataSource = tabla;
                        formatoEncabezados();
                        gridDatos.CurrentCell = gridDatos[2, 0];
                        db.Desconectar();

                        if (i == 1)
                        {
                            lblResultados.Text = i.ToString() + " resultado";
                            gridDatos.Focus();
                        }
                        else if (i == 0)
                        {
                            lblResultados.Text = "No se encontraron registros";
                        }
                        else if (i > 1)
                        {
                            lblResultados.Text = i.ToString() + " resultados";
                            gridDatos.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Ingrese la condición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridLlamadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridLlamadas.Columns[e.ColumnIndex].Name == "tipo")
            {
                if (e.Value.ToString() == "Inbound")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }

            if (gridLlamadas.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value.ToString() == "Contacto")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// Ver registros archivados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchivados_Click(object sender, EventArgs e)
        {
            tabControlSecciones.SelectedIndex = 0;
            txtBusqueda.Text = "";
            verRegistros("archivados");
        }

        /// <summary>
        /// Convierte un número a su correspondencia con el nombre de mes.
        /// Ejemplo: 11 - Noviembre.
        /// </summary>
        /// <param name="num">Número de mes</param>
        /// <returns></returns>
        private string mesAnumero(string num)
        {
            string mes = "";

            if (num == "01")
            {
                mes = "Enero";
            }
            else if (num == "02")
            {
                mes = "Febrero";
            }
            else if (num == "03")
            {
                mes = "Marzo";
            }
            else if (num == "04")
            {
                mes = "Abril";
            }
            else if (num == "05")
            {
                mes = "Mayo";
            }
            else if (num == "06")
            {
                mes = "Junio";
            }
            else if (num == "07")
            {
                mes = "Julio";
            }
            else if (num == "08")
            {
                mes = "Agosto";
            }
            else if (num == "09")
            {
                mes = "Septiembre";
            }
            else if (num == "10")
            {
                mes = "Octubre";
            }
            else if (num == "11")
            {
                mes = "Noviembre";
            }
            else if (num == "12")
            {
                mes = "Diciembre";
            }
            return mes;
        }
        
        private void toolCgoodWill_Click(object sender, EventArgs e)
        {
            candidatoAgoodWill(1);
        }

        private void toolCgoodWillC_Click(object sender, EventArgs e)
        {
            candidatoAgoodWill(0);
        }

        /// <summary>
        /// Marca o desmarca un expediente como candidato a Good Will.
        /// Genera una marca en la tabla de modificaciones.
        /// </summary>
        /// <param name="op">1: Marca como candidato. 0: Quita la marca.</param>
        private void candidatoAgoodWill(int op)
        {
            conexionBD db = new conexionBD();
            int i = -1;
            string consulta = "UPDATE deducibles SET candidato=" + op.ToString() + " WHERE clave='" + this.idDeducible + "';";

            try
            {
                db.Conectar();
                i = db.Modificar(consulta);
                if (i > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.", "Marcar como good will", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadDataMod();

                    if (op == 0)
                    {
                        db.lastModify(this.idDeducible, UsuarioActivo, "Cancel candidate", "");
                    }
                    else if (op == 1)
                    {
                        db.lastModify(this.idDeducible, UsuarioActivo, "Candidate", "");
                    }
                    db.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Marcar como good will", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
        }

        /// <summary>
        /// Marca un expediente para tenerlo como monto pendiente de solicitar.
        /// </summary>
        /// <param name="op">1: Marca como pendiente. 0: Quita la marca.</param>
        private void montoPendiente(int op)
        {
            conexionBD db = new conexionBD();
            int i = -1;
            string consulta = "UPDATE deducibles SET montoPendiente=" + op.ToString() + " WHERE clave='" + this.idDeducible + "';";

            try
            {
                db.Conectar();
                i = db.Modificar(consulta);
                if (i > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.", "Monto pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataMod();

                    if (op == 0)
                    {
                        db.lastModify(this.idDeducible, UsuarioActivo, "Monto agregado", "");
                    }
                    else if (op == 1)
                    {
                        db.lastModify(this.idDeducible, UsuarioActivo, "Monto pendiente", "");
                    }
                    db.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Monto pendiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
        }

        /// <summary>
        /// Abre el gestor de correo electrónico predeterminado para enviar email a la dirección registrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text == "pendiente")
            {
                MessageBox.Show("No es posible enviar correo electrónico.\nNo hay correo capturado o no tiene el formato correcto.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                System.Diagnostics.Process.Start("mailto:" + txtEmail.Text);
            }
        }

        private void toolCmontoPendiente_Click(object sender, EventArgs e)
        {
            montoPendiente(1);
        }

        private void txtEmail_DoubleClick(object sender, EventArgs e)
        {
            txtEmail.SelectionStart = 0;
            txtEmail.SelectionLength = txtEmail.Text.Length;
        }
    }
}
