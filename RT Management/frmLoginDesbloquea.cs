using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace RT_Management
{
    public partial class frmLoginDesbloquea : Form
    {
        Form padre;

        public frmLoginDesbloquea(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void frmLoginDesbloquea_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }

        private void btnDesbloquea_Click(object sender, System.EventArgs e)
        {
            desbloquear();
        }     

        public static string GetSHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private void desbloquear()
        {
            conexionBD db = new conexionBD();
            conexionBD dbMod = new conexionBD();
            string usuario = txtUsuario.Text;
            string password = GetSHA1(txtPass.Text);
            int nivel = -1;
            int pass = 0;

            try
            {
                db.Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message.ToString(), "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MySqlDataReader respuesta = null;
            respuesta = db.Buscar("SELECT user, pass, level FROM login WHERE user='" + usuario + "';");

            if (respuesta.HasRows)
            {
                pass = 0;
            }
            else
            {
                pass = 1;
            }

            while (respuesta.Read())
            {
                if ((usuario == respuesta[0].ToString()) && (password == respuesta[1].ToString())) //Datos correctos
                {
                    nivel = Convert.ToInt16(respuesta[2]);

                    if (nivel == 0 || nivel == 1)
                    {
                        dbMod.Conectar();
                        dbMod.Modificar($"UPDATE login SET active=0 WHERE user='{usuario}';");
                        dbMod.Desconectar();
                        MessageBox.Show("Usuario desbloqueado.\nYa puede iniciar sesion.", "Desbloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos necesarios.\nContacte al administrador.", "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else if (password != respuesta[1].ToString())
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            

            if (pass == 1)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtUsuario.SelectionStart = 0;
                txtUsuario.SelectionLength = txtUsuario.Text.Length;
            }

            db.Desconectar();

        } //Desbloquear

    } //Clase
} //Namespace
