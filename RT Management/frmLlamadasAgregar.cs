using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmLlamadasAgregar : Form
    {
        string usuario = "";
        string telefono = "";
        string tipo = "";
        string tipoLlamada = "";
        string idExpediente = "0";

        public frmLlamadasAgregar(string usuario, string telefono, string tipo, string id, string tipoLlamada)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.telefono = telefono;
            this.tipo = tipo;
            this.idExpediente = id;
            this.tipoLlamada = tipoLlamada;
        }

        private void frmLlamadasAgregar_Load(object sender, EventArgs e)
        {
            txtNumero.Text = telefono;
            lblTipo.Text = tipo;

            if (this.tipoLlamada == "Inbound")
            {
                txtNumero.Enabled = true;
                lblNombre.Text = "Llamante:";
                cmbEstado.SelectedIndex = 0;
                txtNumero.Focus();
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.FlatStyle == FlatStyle.Standard)
            {
                txtNumero.Enabled = true;
                btnEdit.FlatStyle = FlatStyle.Popup;
            }
            else 
            {
                txtNumero.Enabled = false;
                btnEdit.FlatStyle = FlatStyle.Standard;
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((cmbEstado.SelectedIndex == 0) || (cmbEstado.SelectedIndex == 1) || (cmbEstado.SelectedIndex == 2) || (cmbEstado.SelectedIndex == 3) || (cmbEstado.SelectedIndex == 4))
            {
                saveData();
            }
            else 
            {
                MessageBox.Show("Seleccione el estado de la llamada","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEstado.Focus();
            }
        }

        private void saveData() 
        {
            conexionBD db = new conexionBD();
            MySqlCommand cmd;
            string query = "INSERT INTO llamadas (id, idExpediente, fecha, status, tipo, telefono, recibeLlamada, comentarios, usuario) "
                + "VALUES (NULL, @idExpediente, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', @status, @tipo, @telefono, @recibeLlamada, @Comentarios, @usuario);";
        
            try 
            {
                db.Conectar();
                cmd = db.Insertar(query);

                cmd.Parameters.AddWithValue("idExpediente", idExpediente);
                cmd.Parameters.AddWithValue("status", cmbEstado.Text);
                cmd.Parameters.AddWithValue("tipo", this.tipoLlamada);

                if (txtNumero.Text == "")
                {
                    cmd.Parameters.AddWithValue("telefono", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("telefono", txtNumero.Text);
                }
                
                cmd.Parameters.AddWithValue("recibeLlamada", txtRecibe.Text);
                cmd.Parameters.AddWithValue("comentarios", txtComentarios.Text);
                cmd.Parameters.AddWithValue("usuario", this.usuario);           

                cmd.ExecuteNonQuery();
                MessageBox.Show("Llamada registrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Desconectar();
                this.Close();
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Desconectar();
            }
        }

        private void frmLlamadasAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemplate.SelectedIndex == 0) 
            {
                txtComentarios.Text = "Notificación de recepción de documentos.";
            }
            else if (cmbTemplate.SelectedIndex == 1)
            {
                txtComentarios.Text = "Notificación de documentos faltantes.";
            }
            if (cmbTemplate.SelectedIndex == 2)
            {
                txtComentarios.Text = "Notificación de envío de dictamen.";
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex == 0) //Contacto
            {
                txtRecibe.Enabled = true;
                txtRecibe.Text = "";
            }
            else if (cmbEstado.SelectedIndex == 1) //No contesta    
            {
                txtRecibe.Enabled = false;
                txtRecibe.Text = "-";
            }
            else if (cmbEstado.SelectedIndex == 2) //No se encuentra
            {
                txtRecibe.Enabled = true;
                txtRecibe.Text = "";
            }
            else if (cmbEstado.SelectedIndex == 3) //Buzón de voz
            {
                txtRecibe.Enabled = false;
                txtRecibe.Text = "-";
            }
            else if (cmbEstado.SelectedIndex == 4) //Fuera de servicio
            {
                txtRecibe.Enabled = false;
                txtRecibe.Text = "-";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
