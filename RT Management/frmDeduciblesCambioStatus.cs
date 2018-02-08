using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmDeduciblesCambioStatus : Form
    {
        private string idDeducible;
        private int status;
        private string titularDeducible;
        private string usuario;

        private enum Estado { ENPROCESO, INCOMPLETO, PROCEDENTE, NOPROCEDENTE, PARAENVIO, ENTREGADO, ARCHIVADO };

        public frmDeduciblesCambioStatus(string id, int status, string titular, string user)
        {
            InitializeComponent();
            idDeducible = id;
            this.status = status;
            titularDeducible = titular;
            usuario = user;
        }

        private void frmCambioStatus_Load(object sender, EventArgs e)
        {
            lblCliente.Text = titularDeducible;

            if (status == (int)Estado.ENPROCESO)
            {
                lblStatus.Text = "En proceso";
                comboEstado.Items.Add("Procedente");
                comboEstado.Items.Add("No procedente");
                comboEstado.Items.Add("Archivado");
            }
            else if (status == (int)Estado.INCOMPLETO)
            {
                lblStatus.Text = "Incompleto";
                comboEstado.Items.Add("Para envío");
                comboEstado.Items.Add("En proceso");
                comboEstado.Items.Add("Archivado");
            }
            else if (status == (int)Estado.PROCEDENTE)
            {
                lblStatus.Text = "Procedente";
                comboEstado.Enabled = false;
            }
            else if (status == (int)Estado.NOPROCEDENTE)
            {
                lblStatus.Text = "No procedente";
                comboEstado.Enabled = false;
            }
            else if (status == (int)Estado.PARAENVIO)
            {
                lblStatus.Text = "Para envío";
                comboEstado.Items.Add("Entregado a PQR");
                comboEstado.Items.Add("Incompleto");
                comboEstado.Items.Add("Archivado");
            }
            else if (status == (int)Estado.ENTREGADO)
            {
                lblStatus.Text = "Entregado a PQR";
                comboEstado.Items.Add("En proceso");
                comboEstado.Items.Add("Incompleto");
                comboEstado.Items.Add("Archivado");
            }
            else if (status == (int)Estado.ARCHIVADO)
            {
                lblStatus.Text = "Archivado";
                comboEstado.Items.Add("Procedente");
                comboEstado.Items.Add("No procedente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string consulta = getConsulta();
            conexionBD db = new conexionBD();

            try 
            {
                db.Conectar();
                db.Modificar(consulta);
                MessageBox.Show("Se ha cambiado correctamente el estado del expediente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.lastModify(idDeducible, usuario, "Status Changed", comboEstado.Text);
                db.Desconectar();
                Close();
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

        private string getConsulta()
        {
            string texto = "";
            if ((status == (int)Estado.ENPROCESO) && ((getEstado() == (int)Estado.PROCEDENTE) || (getEstado() == (int)Estado.NOPROCEDENTE)))
            {
                texto = $"UPDATE deducibles SET status={getEstado()}, fechaDictamen='{dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"diasProceso={numDiasProceso.Value} WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.ARCHIVADO) && ((getEstado() == (int)Estado.PROCEDENTE) || (getEstado() == (int)Estado.NOPROCEDENTE)))
            {
                texto = $"UPDATE deducibles SET status={getEstado()}, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}', fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaDictamen='{dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss")}', diasProceso={numDiasProceso.Value} WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.PARAENVIO) && (getEstado() == (int)Estado.ENTREGADO))
            {
                texto = $"UPDATE deducibles SET status=5, fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.PARAENVIO) && (getEstado() == (int)Estado.INCOMPLETO))
            {
                texto = $"UPDATE deducibles SET status=1, fechaPqr='0000-00-00 00:00:00' WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.ENTREGADO) && (getEstado() == (int)Estado.ENPROCESO))
            {
                texto = $"UPDATE deducibles SET status=0, fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.INCOMPLETO) && (getEstado() == (int)Estado.PARAENVIO))
            {
                texto = $"UPDATE deducibles SET status=4, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.INCOMPLETO) && (getEstado() == (int)Estado.ENPROCESO))
            {
                texto = $"UPDATE deducibles SET status=0, fechaRecepcion='{dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"fechaPqr='{datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss")}', fechaC3='{dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                    $"WHERE clave='{idDeducible}';";
            }
            else if ((status == (int)Estado.ENTREGADO) && (getEstado() == (int)Estado.INCOMPLETO))
            {
                texto = $"UPDATE deducibles SET status=1, fechaRecepcion='0000-00-00 00:00:00' WHERE clave='{idDeducible}';";
            }
            else if (getEstado() == (int)Estado.ARCHIVADO)
            {
                texto = $"UPDATE deducibles SET status=6, candidato=0 WHERE clave='{idDeducible}';";
            }
            return texto;
        }

        /// <summary>
        /// Obtiene el equivalente numérico del estado seleccionado en el combo (nuevo estado).
        /// </summary>
        /// <returns>Estado en formato entero.</returns>
        private int getEstado() 
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

        private string formateaFecha(string date)
        {
            return date.ToString();
        }

        /// <summary>
        /// Al seleccionar el nuevo estado del combo se muestran u ocultan los campos de fecha.
        /// </summary>
        private void comboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            // En proceso a Procedente o No procedente
            if ( (status == (int)Estado.ENPROCESO) && ((comboEstado.Text == "Procedente") || (comboEstado.Text == "No procedente")) )
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
            // Archivado a Procedente o No procedente
            else if ( (status == (int)Estado.ARCHIVADO) && ((comboEstado.Text == "Procedente") || (comboEstado.Text == "No procedente")) )
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
            else if ((status == (int)Estado.INCOMPLETO) && (getEstado() == (int)Estado.ENPROCESO))
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
            else if ((status == (int)Estado.INCOMPLETO) && (getEstado() == (int)Estado.PARAENVIO))
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
            else if ((status == (int)Estado.PARAENVIO) && (getEstado() == (int)Estado.ENPROCESO))
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
            else if ((status == (int)Estado.PARAENVIO) && (getEstado() == (int)Estado.ENTREGADO))
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
            else if ((status == (int)Estado.ENTREGADO) && (getEstado() == (int)Estado.ENPROCESO))
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
            else if ((getEstado() == (int)Estado.ARCHIVADO))
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

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
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
