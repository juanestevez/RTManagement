using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmDeduciblesCambioStatus : Form
    {
        /// <summary>
        /// Identificador el expediente al que se cambiará el estatus.
        /// </summary>
        private string idDeducible;
        /// <summary>
        /// Estatus actual del expediente.
        /// </summary>
        private int estatusActual;
        /// <summary>
        /// Nombre del titular, sólo para fines informativos.
        /// </summary>
        private string titularDeducible;
        /// <summary>
        /// Usuario que realizará la modificación.
        /// </summary>
        private string usuario;

        private enum Estado { ENPROCESO, INCOMPLETO, PROCEDENTE, NOPROCEDENTE, PARAENVIO, ENTREGADO, ARCHIVADO };

        public frmDeduciblesCambioStatus(string id, int estatusActual, string titular, string user)
        {
            InitializeComponent();
            idDeducible = id;
            this.estatusActual = estatusActual;
            titularDeducible = titular;
            usuario = user;
        }

        private void FrmCambioStatus_Load(object sender, EventArgs e)
        {
            lblCliente.Text = titularDeducible;

            if (estatusActual == (int)Estado.ENPROCESO)
            {
                lblStatus.Text = "En proceso";
                comboEstado.Items.Add("Procedente");
                comboEstado.Items.Add("No procedente");
                comboEstado.Items.Add("Archivado");
            }
            else if (estatusActual == (int)Estado.INCOMPLETO)
            {
                lblStatus.Text = "Incompleto";
                comboEstado.Items.Add("Para envío");
                comboEstado.Items.Add("En proceso");
                comboEstado.Items.Add("Procedente");
                comboEstado.Items.Add("No procedente");
                comboEstado.Items.Add("Archivado");
            }
            else if (estatusActual == (int)Estado.PROCEDENTE)
            {
                lblStatus.Text = "Procedente";
                comboEstado.Enabled = false;
            }
            else if (estatusActual == (int)Estado.NOPROCEDENTE)
            {
                lblStatus.Text = "No procedente";
                comboEstado.Enabled = false;
            }
            else if (estatusActual == (int)Estado.PARAENVIO)
            {
                lblStatus.Text = "Para envío";
                comboEstado.Items.Add("Entregado a PQR");
                comboEstado.Items.Add("Incompleto");
                comboEstado.Items.Add("Archivado");
            }
            else if (estatusActual == (int)Estado.ENTREGADO)
            {
                lblStatus.Text = "Entregado a PQR";
                comboEstado.Items.Add("En proceso");
                comboEstado.Items.Add("Incompleto");
                comboEstado.Items.Add("Archivado");
            }
            else if (estatusActual == (int)Estado.ARCHIVADO)
            {
                lblStatus.Text = "Archivado";
                comboEstado.Items.Add("Para envío");
                comboEstado.Items.Add("Procedente");
                comboEstado.Items.Add("No procedente");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string consulta = GetConsulta();
            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                db.Modificar(consulta);
                MessageBox.Show("Se ha cambiado correctamente el estado del expediente.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.lastModify(idDeducible, usuario, "Status Changed", comboEstado.Text);
                db.Desconectar();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al realizar el cambio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                db.Desconectar();
            }
        }

        private string GetConsulta()
        {
            string texto = "";
            int estadoNuevo = GetEstado();
            if ((estatusActual == (int)Estado.ENPROCESO) && ((estadoNuevo == (int)Estado.PROCEDENTE) || (estadoNuevo == (int)Estado.NOPROCEDENTE)))
            {
                texto = $"UPDATE deducibles SET status={estadoNuevo}, fechaDictamen='{dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"diasProceso={numDiasProceso.Value} WHERE clave='{idDeducible}';";
            }
            else if (( (estatusActual == (int)Estado.ARCHIVADO) || (estatusActual == (int)Estado.INCOMPLETO) ) 
                && ((estadoNuevo == (int)Estado.PROCEDENTE) || (estadoNuevo == (int)Estado.NOPROCEDENTE)))
            {
                texto = $"UPDATE deducibles SET status={estadoNuevo}, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}', fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaDictamen='{dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss")}', diasProceso={numDiasProceso.Value} WHERE clave='{idDeducible}';";
            }
            else if ((estatusActual == (int)Estado.PARAENVIO) && (estadoNuevo == (int)Estado.ENTREGADO))
            {
                texto = $"UPDATE deducibles SET status=5, fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if ((estatusActual == (int)Estado.PARAENVIO) && (estadoNuevo == (int)Estado.INCOMPLETO))
            {
                texto = $"UPDATE deducibles SET status=1, fechaPqr='0000-00-00 00:00:00' WHERE clave='{idDeducible}';";
            }
            else if ((estatusActual == (int)Estado.ENTREGADO) && (estadoNuevo == (int)Estado.ENPROCESO))
            {
                texto = $"UPDATE deducibles SET status=0, fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if (((estatusActual == (int)Estado.INCOMPLETO) || (estatusActual == (int)Estado.ARCHIVADO)) && (estadoNuevo == (int)Estado.PARAENVIO))
            {
                texto = $"UPDATE deducibles SET status=4, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if ((estatusActual == (int)Estado.INCOMPLETO) && (estadoNuevo == (int)Estado.ENPROCESO))
            {
                texto = $"UPDATE deducibles SET status=0, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}', fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                    $"WHERE clave='{idDeducible}';";
            }
            else if ((estatusActual == (int)Estado.ENTREGADO) && (estadoNuevo == (int)Estado.INCOMPLETO))
            {
                texto = $"UPDATE deducibles SET status=1, fechaRecepcion='0000-00-00 00:00:00' WHERE clave='{idDeducible}';";
            }
            else if (estadoNuevo == (int)Estado.ARCHIVADO)
            {
                texto = $"UPDATE deducibles SET status=6, candidato=0 WHERE clave='{idDeducible}';";
            }
            return texto;
        }

        /// <summary>
        /// Obtiene el equivalente numérico del estado seleccionado en el combo (nuevo estado).
        /// </summary>
        /// <returns>Estado en formato entero.</returns>
        private int GetEstado() 
        { 
            int estado = -1;

            if(comboEstado.Text == "En proceso")
            {
                estado = 0;
            }
            else if (comboEstado.Text == "Incompleto")
            {
                estado = 1;
            }
            else if (comboEstado.Text == "Procedente") 
            {
                estado = 2;
            }
            else if (comboEstado.Text == "No procedente")
            {
                estado = 3;
            }
            else if (comboEstado.Text == "Para envío")
            {
                estado = 4;
            }
            else if (comboEstado.Text == "Entregado a PQR")
            {
                estado = 5;
            }
            else if (comboEstado.Text == "Archivado")
            {
                estado = 6;
            }
            return estado;
        }       

        /// <summary>
        /// Al seleccionar el nuevo estado del combo se muestran u ocultan los campos de fecha.
        /// </summary>
        private void ComboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            // En proceso -> Procedente o No procedente
            if ( (estatusActual == (int)Estado.ENPROCESO) && ((comboEstado.Text == "Procedente") || (comboEstado.Text == "No procedente")) )
            {
                lblDictamen.Visible = true;
                dateDictamen.Visible = true;
                lblDias.Visible = true;
                numDiasProceso.Visible = true;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                btnAceptar.Enabled = true;
            }
            // Archivado o Incompleto -> Procedente o No procedente
            else if ( ( (estatusActual == (int)Estado.ARCHIVADO) || (estatusActual == (int)Estado.INCOMPLETO) ) 
                && ((comboEstado.Text == "Procedente") || (comboEstado.Text == "No procedente")) )
            {
                lblDictamen.Visible = true;
                dateDictamen.Visible = true;
                lblDias.Visible = true;
                numDiasProceso.Visible = true;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblC3.Visible = true;
                dateC3.Visible = true;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                btnAceptar.Enabled = true;
            } 
            // Incompleto -> En proceso
            else if ((estatusActual == (int)Estado.INCOMPLETO) && (GetEstado() == (int)Estado.ENPROCESO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = true;
                dateC3.Visible = true;
                btnAceptar.Enabled = true;
            } 
            // Incompleto o Archivado -> Para envío
            else if (((estatusActual == (int)Estado.INCOMPLETO) || (estatusActual == (int)Estado.ARCHIVADO) ) && (GetEstado() == (int)Estado.PARAENVIO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = false;
                datePqr.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                btnAceptar.Enabled = true;
            } 
            // Para envío -> En proceso
            else if ((estatusActual == (int)Estado.PARAENVIO) && (GetEstado() == (int)Estado.ENPROCESO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = true;
                dateC3.Visible = true;
                btnAceptar.Enabled = true;
            } 
            // Para envío -> Entregado
            else if ((estatusActual == (int)Estado.PARAENVIO) && (GetEstado() == (int)Estado.ENTREGADO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = false;
                dateC3.Visible = false;
                btnAceptar.Enabled = true;
            } 
            // Entregado -> En proceso
            else if ((estatusActual == (int)Estado.ENTREGADO) && (GetEstado() == (int)Estado.ENPROCESO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblC3.Visible = true;
                dateC3.Visible = true;
                btnAceptar.Enabled = true;
            }
            // Cualquier estado -> Archivado
            else if ((GetEstado() == (int)Estado.ARCHIVADO))
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                lblPqr.Visible = false;
                datePqr.Visible = false;
                btnAceptar.Enabled = true;
            }
            else
            {
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblDias.Visible = false;
                numDiasProceso.Visible = false;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                btnAceptar.Enabled = false;
            }
        }

        private void ComboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEstado.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
