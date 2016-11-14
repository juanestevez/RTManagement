using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmCorreccionesGpoIntAgregar : Form
    {
        private string usuario = "";

        public frmCorreccionesGpoIntAgregar(string us)
        {
            InitializeComponent();
            usuario = us;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarRegistro();
        }

        private void agregarRegistro()
        {
            conexionBD db = new conexionBD();
            MySqlCommand cmd;
            string cadena = "INSERT INTO correccioncontratos(id, estado, fechaSolicitud, fechaRespuesta, cTitular, cContrato, "
                + "cVin, cPlatinum, iTitular, iContrato, iVin, iPlatinum, distribuidora, solicitado, usuario) VALUES (NULL, 0, @fechaSolicitud, "
                + "NULL, @cTitular, @cContrato, @cVin, @cPlatinum, @iTitular, @iContrato, @iVin, @iPlatinum, "
                + "@distribuidora, @solicitado, '" + usuario + "');";
            try
            {
                db.Conectar();
                cmd = db.Insertar(cadena);

                cmd.Parameters.AddWithValue("fechaSolicitud", dateSolicitud.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("cTitular", txtTitularC.Text);
                cmd.Parameters.AddWithValue("cContrato", Convert.ToInt32(txtContratoC.Text));
                cmd.Parameters.AddWithValue("cVin", txtVinC.Text);
                cmd.Parameters.AddWithValue("cPlatinum", txtPlatinumC.Text);
                cmd.Parameters.AddWithValue("iTitular", txtTitularI.Text);
                cmd.Parameters.AddWithValue("iContrato", txtContratoI.Text);
                cmd.Parameters.AddWithValue("iVin", txtVinI.Text);
                cmd.Parameters.AddWithValue("iPlatinum", txtPlatinumI.Text);
                cmd.Parameters.AddWithValue("distribuidora", txtDistribuidora.Text);
                cmd.Parameters.AddWithValue("solicitado", txtSolicitadoPor.Text);

                cmd.ExecuteNonQuery();
                limpiaCamposAgregar();
                if (MessageBox.Show("Registro guardado con exito.\n¿Desea agregar otro registro?", "Registro guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Close();
                }
                db.Desconectar();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al guardar los datos: " + e.Message, "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
        }

        private void limpiaCamposAgregar()
        {
            txtContratoC.Clear();
            txtContratoI.Clear();
            txtDistribuidora.Clear();
            txtPlatinumC.Clear(); ;
            txtPlatinumI.Clear();
            txtTitularC.Clear();
            txtTitularI.Clear();
            txtVinC.Clear();
            txtVinI.Clear();
            txtSolicitadoPor.Clear();
            dateSolicitud.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    } //Clase
}//namespace
