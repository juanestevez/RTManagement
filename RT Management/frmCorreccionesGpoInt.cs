using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmCorreccionesGpoInt : Form
    {
        private static frmCorreccionesGpoInt m_FormDefInstance;
        private static string user = "";
        private static int level = -1;
        private int idRegistro = 0;
        private int status = 0;

        public frmCorreccionesGpoInt()
        {
            InitializeComponent();            
            estadoControlesMod(false);
        }

        private void frmCorreccionesGpoInt_Load(object sender, EventArgs e)
        {
            comboFiltro.Text = "Titular";
            comboTipo.Text = "Like";
            lblTiempoRespuesta.Text = "";
            WindowState = FormWindowState.Maximized;
            txtBusqueda.Focus();
            if (level == 3)
            {
                btnNuevo.Enabled = false;
                toolData.Enabled = false;
            }
            escondeDatos(false);
        }

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

        public static frmCorreccionesGpoInt DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmCorreccionesGpoInt();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        /*** FUNCIONALIDAD COMÚN ***/

        private void loadDataLast()
        {
            conexionBD db = new conexionBD();
            string texto = txtBusqueda.Text;
            string consulta = "SELECT * FROM correccioncontratos ORDER BY fechaSolicitud DESC LIMIT 15;";

            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(consulta);
                DataTable tabla = new DataTable();
                int i = datos.Fill(tabla);
                gridDatos.DataSource = tabla;
                formatoEncabezados();

                if (i > 0)
                {
                    escondeDatos(true);
                    gridDatos.CurrentCell = gridDatos[2, 0];
                }

                db.Desconectar();
                
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

        private void formatoEncabezados()
        {
            gridDatos.Columns[0].Visible = false;
            gridDatos.Columns[1].HeaderText = "";
            gridDatos.Columns[2].HeaderText = "Fecha Solicitud";
            gridDatos.Columns[3].HeaderText = "Fecha Respuesta";
            gridDatos.Columns[4].HeaderText = "Titular correcto";
            gridDatos.Columns[5].HeaderText = "Contrato correcto";
            gridDatos.Columns[6].HeaderText = "VIN correcto";
            gridDatos.Columns[7].HeaderText = "Platinum correcto";
            gridDatos.Columns[8].HeaderText = "Titular incorrrecto";
            gridDatos.Columns[9].HeaderText = "Contrato incorrecto";
            gridDatos.Columns[10].HeaderText = "Vin incorrecto";
            gridDatos.Columns[11].HeaderText = "Platinum incorrecto";
            gridDatos.Columns[12].HeaderText = "Distribuidora";
            gridDatos.Columns[13].HeaderText = "Solicitado por";
            gridDatos.Columns[14].HeaderText = "Usuario";
        }

        private void estadoControlesMod(Boolean estado)
        {
            txt1TitularC.Enabled = estado;
            txt1TitularI.Enabled = estado;
            txt1GrupoC.Enabled = estado;
            txt1GrupoI.Enabled = estado;
            txt1VinC.Enabled = estado;
            txt1VinI.Enabled = estado;
            txt1PlatinumC.Enabled = estado;
            txt1PlatinumI.Enabled = estado;
            txt1Distribuidora.Enabled = estado;
            dateRespuesta.Enabled = estado;
            dateSolicitud.Enabled = estado;
            txtSolicitadoPor.Enabled = estado;
        }


        /*** GUI ***/

        private void tabOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridDatos.DataSource = null;
            escondeDatos(false);

            if (tabOpciones.SelectedTab.Text == "Buscar")
            {
                AcceptButton = btnBuscar;
                txtBusqueda.Text = "";
                txtBusqueda.Focus();
                comboFiltro.Text = "Titular";
                comboTipo.Text = "Like";
            }
            else if (tabOpciones.SelectedTab.Text == "Rango de fechas")
            {
                AcceptButton = btnBuscarfecha;
                fechaFin.Value = DateTime.Now;
                fechaInicio.Value = DateTime.Now;
                radioSolicitud.Checked = true;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            int i = gridDatos.RowCount;

            if (i > 0)
            {
                exportarAcsv(gridDatos);
            }
            else
            {
                MessageBox.Show("No hay información para exportar.", "Advertencia", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void exportarAcsv(DataGridView grid)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Archivo CSV (*.csv)|*.csv";
            dlGuardar.FileName = "Correccion de contratos " + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //Encabezados
                for (int i = 1; i < grid.Columns.Count; i++)
                {
                    if (i == grid.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("{0}", grid.Columns[i].HeaderText));
                    }
                    else
                    {
                        if (i == 1)
                        {
                            csvMemoria.Append("Estado,");
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("{0},", grid.Columns[i].HeaderText));
                        }
                        
                    }
                }
                csvMemoria.AppendLine();


                for (int m = 0; m < grid.Rows.Count; m++)
                {
                    for (int n = 1; n < grid.Columns.Count; n++)
                    {
                        //si es la última columna no se agrega la coma
                        if (n == grid.Columns.Count - 1)
                        {                         
                            csvMemoria.Append(String.Format("{0}", grid.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            if (n == 1)
                            {
                                if (grid.Rows[m].Cells[n].Value.ToString() == "1")
                                {
                                    csvMemoria.Append("Completado,");
                                }
                                else if (grid.Rows[m].Cells[n].Value.ToString() == "0")
                                {
                                    csvMemoria.Append("En proceso,");
                                }
                                else
                                {
                                    csvMemoria.Append(String.Format("{0},", grid.Rows[m].Cells[n].Value));
                                }
                            }
                            else if ( n == 3)
                            {
                                if (grid.Rows[m].Cells[n].Value.ToString() == "")
                                {
                                    csvMemoria.Append(",");
                                }
                                else
                                {
                                    csvMemoria.Append(String.Format("{0},", grid.Rows[m].Cells[n].Value));
                                }
                            }
                            else
                            {
                                csvMemoria.Append(String.Format("{0},", grid.Rows[m].Cells[n].Value));
                            }
                            
                        }
                    }
                    csvMemoria.AppendLine();
                }

                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlGuardar.FileName, false, System.Text.Encoding.UTF8);
                sw.Write(csvMemoria.ToString());
                sw.Close();
                MessageBox.Show("Archivo guardado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void gridDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            gridDatos.Columns[1].DefaultCellStyle.Format = "N0";

            if (gridDatos.Columns[e.ColumnIndex].Name == "estado")
            {
                if (e.Value.ToString() == "0") //En proceso
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "1") //Completo
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }
            }
        }

        private void gridDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            escondeDatos(true);

            btnDataModificar.Enabled = true;
            btnDataCancelar.Enabled = false;
            btnDataGuardar.Enabled = false;
            btnDataComentario.Enabled = true;
            idRegistro = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            status = Convert.ToInt32(gridDatos.CurrentRow.Cells["estado"].Value);
            loadItemMod();
        }

        private void loadItemMod()
        {
            conexionBD db = new conexionBD();
            DateTime fechaActual = DateTime.Now;
            MySqlDataReader respuesta;
            TimeSpan ts;
            int dias = 0;
            int horas = 0;
            int minutos = 0;

            try
            {
                db.Conectar();
                lbl1Solicitud.Visible = true;
                dateSolicitud.Visible = true;
                respuesta = db.Buscar("SELECT * FROM correccioncontratos WHERE id='" + idRegistro + "';");
                respuesta.Read();

                status = Convert.ToInt32(respuesta[1]); //estado

                dateSolicitud.Value = Convert.ToDateTime(respuesta[2].ToString()); //fechaSolicitud

                if (status == 1) // Completado
                {
                    dateRespuesta.Visible = true;
                    lbl1Respuesta.Visible = true;
                    dateRespuesta.Value = Convert.ToDateTime(respuesta[3].ToString()); //fechaRespuesta
                    btnDataCompletado.Enabled = false;
                    ts = dateRespuesta.Value - dateSolicitud.Value;
                    dias = ts.Days;
                    horas = ts.Hours;
                    minutos = ts.Minutes;
                    lblTiempoRespuesta.Visible = true;
                    lblTiempoRespuesta.Text = String.Format("Tiempo de respuesta {0} dias, {1} horas, {2} minutos.", 
                        dias, horas, minutos);
                    boxEstado.BackColor = Color.Green;
                }
                else
                {
                    dateRespuesta.Value = DateTime.Now;
                    dateRespuesta.Visible = false;
                    lbl1Respuesta.Visible = false;
                    btnDataCompletado.Enabled = true;
                    lblTiempoRespuesta.Visible = false;
                    boxEstado.BackColor = Color.Yellow;
                    lblTiempoRespuesta.Text = "";
                }

                txt1TitularC.Text = respuesta[4].ToString(); //cTitular
                txt1GrupoC.Text = respuesta[5].ToString(); //cContrato
                txt1VinC.Text = respuesta[6].ToString(); //CVin
                txt1PlatinumC.Text = respuesta[7].ToString(); //cPlatinum
                txt1TitularI.Text = respuesta[8].ToString(); //iTitular
                txt1GrupoI.Text = respuesta[9].ToString(); //iContrato
                txt1VinI.Text = respuesta[10].ToString(); //iVin
                txt1PlatinumI.Text = respuesta[11].ToString(); //iPlatinum
                txt1Distribuidora.Text = respuesta[12].ToString(); // iDistribuidora
                txtSolicitadoPor.Text = respuesta[13].ToString();

                db.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
            loadComment();
        }

        private void btnDataCompletado_Click(object sender, EventArgs e)
        {
            marcarCompletado(DateTime.Now.ToString(), idRegistro.ToString());
            loadItemMod();
        }

        private void marcarCompletado(string fecha, string id)
        {
            string consulta = "UPDATE correccioncontratos SET estado=1, fechaRespuesta='" 
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id='"+ id+ "';";
            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                db.Modificar(consulta);
                MessageBox.Show("Se ha cambiado correctamente el estado de la solicitud.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Desconectar();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCorreccionesGpoIntAgregar frm = new frmCorreccionesGpoIntAgregar(UsuarioActivo);
            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            txtBusqueda.Text = "";
            loadDataLast();
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            int i = gridDatos.RowCount;

            if (i > 0)
            {
                exportarAcsv(gridDatos);
            }
            else
            {
                MessageBox.Show("No hay información para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnDataModificar_Click(object sender, EventArgs e)
        {
            estadoControlesMod(true);
            btnDataModificar.Enabled = false;
            btnDataGuardar.Enabled = true;
            btnDataCancelar.Enabled = true;
            txt1TitularC.Focus();
        }

        /**
        **
        **
        **
        **
        **/
        private void btnDataGuardar_Click(object sender, EventArgs e)
        {
            guardarModificacion();
            estadoControlesMod(false);
            btnDataModificar.Enabled = true;
            btnDataGuardar.Enabled = false;
            btnDataCancelar.Enabled = false;
        }

        private void btnDataCancelar_Click(object sender, EventArgs e)
        {
            estadoControlesMod(false);
            btnDataModificar.Enabled = true;
            btnDataGuardar.Enabled = false;
            btnDataCancelar.Enabled = false;
            loadItemMod();
        }

        private void btnDataComentario_Click(object sender, EventArgs e)
        {
            string idItem = gridDatos.CurrentRow.Cells["id"].Value.ToString();
            frmAddComment frm = new frmAddComment(idItem, UsuarioActivo, "correcciones");
            frm.ShowDialog();
            loadComment();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblResultados.Text = "";
            buscar();
        }

        private void loadComment()
        {

            string query = "SELECT fecha, comentario, usuario FROM correccioncontratoscom WHERE idExpediente='" 
                + idRegistro + "' ORDER BY fecha DESC";
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

        private void escondeDatos(bool estado)
        {
            panelInfo.Visible = estado;
            boxEstado.Visible = estado;
            lblTiempoRespuesta.Visible = estado;
            toolData.Visible = estado;
        }

        /*** Funciones de búsqueda ***/

        private void buscar()
        {
            string filtro = comboFiltro.Text;
            string filtroColumna = "";
            string tipo = comboTipo.Text;
            string consulta;
            conexionBD db = new conexionBD();

            if (comboFiltro.SelectedIndex == 0)
            {
                filtroColumna = "Titular";
            }
            else if (comboFiltro.SelectedIndex == 1)
            {
                filtroColumna = "Contrato";
            }
            else if (comboFiltro.SelectedIndex == 2)
            {
                filtroColumna = "Vin";
            }
            else if (comboFiltro.SelectedIndex == 3)
            {
                filtroColumna = "Platinum";
            }


            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Ingrese el término a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboTipo.SelectedIndex == 0)
                {
                    consulta = "SELECT * FROM correccioncontratos WHERE c" + filtroColumna + " LIKE '%" 
                        + txtBusqueda.Text + "%' OR i" + filtroColumna + " LIKE '%" + txtBusqueda.Text + "%';";
                }
                else
                {
                    consulta = "SELECT * FROM correccioncontratos WHERE c" + filtroColumna + "='"
                        + txtBusqueda.Text.ToUpper() + "' OR i" + filtroColumna + "='" + txtBusqueda.Text.ToUpper() + "';";
                }
                try
                {
                    db.Conectar();
                    MySqlDataAdapter datos = db.Adaptar(consulta);
                    DataTable tabla = new DataTable();
                    int i = datos.Fill(tabla);
                    if (i < 1)
                    {
                        escondeDatos(false);
                        gridDatos.DataSource = null;
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        txtBusqueda.SelectionStart = 0;
                        txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
                        db.Desconectar();                        
                    }
                    else
                    {
                        escondeDatos(true);
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
        }


        private void guardarModificacion()
        {
            string consulta = "";
            conexionBD db = new conexionBD();

            if (status == 0) //En proceso
            {              
                consulta = "UPDATE correccioncontratos SET fechaSolicitud='" 
                    + dateSolicitud.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', cTitular='" + txt1TitularC.Text 
                    + "', cContrato=" + txt1GrupoC.Text + ", cVin='" + txt1VinC.Text + "', cPlatinum='" + txt1PlatinumC.Text 
                    + "', iTitular='" + txt1TitularI.Text + "', iContrato='" + txt1GrupoI.Text + "', iVin='" + txt1VinI.Text 
                    + "', iPlatinum='" + txt1PlatinumI.Text + "', distribuidora='" + txt1Distribuidora.Text + "', solicitado='" 
                    + txtSolicitadoPor.Text + "' WHERE id=" + idRegistro + ";";
            }
            else if (status == 1) //Completo
            {
                consulta = "UPDATE correccioncontratos SET fechaSolicitud='" 
                    + dateSolicitud.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', fechaRespuesta='" 
                    + dateRespuesta.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', cTitular='" + txt1TitularC.Text 
                    + "', cContrato=" + txt1GrupoC.Text + ", cVin='" + txt1VinC.Text + "', cPlatinum='" + txt1PlatinumC.Text 
                    + "', iTitular='" + txt1TitularI.Text + "', iContrato='" + txt1GrupoI.Text + "', iVin='" + txt1VinI.Text 
                    + "', iPlatinum='" + txt1PlatinumI.Text + "', distribuidora='" + txt1Distribuidora.Text + "', solicitado='" 
                    + txtSolicitadoPor.Text + "' WHERE id=" + idRegistro + ";";
            }

            try
            {
                db.Conectar();
                int i = db.Modificar(consulta);
                if (i > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    db.Desconectar();
                    loadItemMod();
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
            }

        }

        private void btnBuscarfecha_Click(object sender, EventArgs e)
        {
            rangoDeFechas();
        }

        private void rangoDeFechas()
        {
            conexionBD db = new conexionBD();
            lblResultados.Text = "";
            string consulta = "";
            DateTime inicio = Convert.ToDateTime(fechaInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            DateTime fin = Convert.ToDateTime(fechaFin.Value.ToString("yyyy-MM-dd") + " 23:59:59");            

            if (inicio < fin)
            {
                if (radioSolicitud.Checked)
                {
                    consulta = "SELECT * FROM correccioncontratos WHERE fechaSolicitud BETWEEN '" 
                        + inicio.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + fin.ToString("yyyy-MM-dd") 
                        + " 23:59:59' ORDER BY fechaSolicitud ASC;";
                }
                else if (radioRespuesta.Checked)
                {
                    consulta = "SELECT * FROM correccioncontratos WHERE fechaRespuesta BETWEEN '"
                        + inicio.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + fin.ToString("yyyy-MM-dd") 
                        + " 23:59:59' ORDER BY fechaRespuesta ASC;";
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
                        escondeDatos(true);
                        lblResultados.Text = i.ToString() + " resultado";
                        gridDatos.Focus();
                        gridDatos.CurrentCell = gridDatos[2, 0];                        
                    }
                    else if (i == 0)
                    {
                        escondeDatos(false);
                        lblResultados.Text = "No se encontraron registros";
                    }
                    else if (i > 1)
                    {
                        escondeDatos(true);
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
            else
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha final.", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

    }//Clase


}//Namespace
