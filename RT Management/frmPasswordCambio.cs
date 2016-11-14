using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmPasswordCambio : Form
    {
        private string user;

        public frmPasswordCambio(string usuario)
        {
            InitializeComponent();
            this.user = usuario;
        }

        private void frmPass_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = user;
            lblInvitado.Text = "";            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            conexionBD db = new conexionBD();
            MySqlDataReader respuesta = null;
            passEncrypt pwd = new passEncrypt();
            string actualPass = pwd.encriptar(txtActual.Text);
            string newPass = pwd.encriptar(txtNueva.Text);
            string confirmPass = pwd.encriptar(txtConfirma.Text);

            try
            {
                db.Conectar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((txtActual.Text == "") || (txtConfirma.Text == "") || (txtNueva.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    respuesta = db.Buscar("SELECT user, pass FROM login WHERE user='" + this.user + "';");
                    respuesta.Read();

                    if (actualPass == respuesta[1].ToString())
                    {
                        if (newPass == confirmPass)
                        {
                            conexionBD dbMod = new conexionBD();
                            try
                            {
                                dbMod.Conectar();
                                dbMod.Modificar("UPDATE login SET pass='" + newPass + "' WHERE user='" + this.user + "';");
                                MessageBox.Show("Se ha cambiado la contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dbMod.Desconectar();
                                Close();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            db.Desconectar();
        }

        private void txtActual_Enter(object sender, EventArgs e)
        {
            txtActual.SelectionStart = 0;
            txtActual.SelectionLength = txtActual.Text.Length;
        }

        private void txtNueva_Enter(object sender, EventArgs e)
        {
            txtNueva.SelectionStart = 0;
            txtNueva.SelectionLength = txtNueva.Text.Length;
        }

        private void txtConfirma_Enter(object sender, EventArgs e)
        {
            txtConfirma.SelectionStart = 0;
            txtConfirma.SelectionLength = txtConfirma.Text.Length;
        }

    }
}
