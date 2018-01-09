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
        private string usuario;

        public frmLoginDesbloquea(Form padre, string usuario)
        {
            InitializeComponent();
            this.padre = padre;
            this.usuario = usuario;
            lblUsuarioDes.Text = "Usuario a desbloquear: " + usuario;
        }

        private void frmLoginDesbloquea_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }

        private void btnDesbloquea_Click(object sender, System.EventArgs e)
        {
            int respuesta = verificaAdmin();

            switch (respuesta)
            {
                case 0:
                    desbloquear(usuario);
                    break;
                case 1:
                    MessageBox.Show("No cuenta con los permisos necesarios.\nContacte al administrador.", 
                        "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtUsuario.SelectionStart = 0;
                    txtUsuario.SelectionLength = txtUsuario.Text.Length;
                    break;
                case 4:
                    ///
                    break;
            }
        }

        /// <summary>
        /// Verifica los datos del usuario para saber si cuenta con permisos de administrador.
        /// </summary>
        /// <returns></returns>
        private int verificaAdmin()
        {
            int resultado = -1;
            conexionBD db = new conexionBD();
            string password = GetSHA1(txtPass.Text);
            int nivel = -1;
            int existe = -1; // ¿Existe el usuario?
            MySqlDataReader respuesta = null;

            try
            {
                db.Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message.ToString(), "Error de conexión", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            respuesta = db.Buscar("SELECT user, pass, level FROM login WHERE user='" + txtUsuario.Text + "';");

            if (respuesta.HasRows)
            {
                existe = 0;
            }
            else
            {
                existe = 1;
                resultado = 3;
            }

            while (respuesta.Read())
            {
                if ((txtUsuario.Text == respuesta[0].ToString()) && (password == respuesta[1].ToString())) //Datos correctos
                {
                    nivel = Convert.ToInt16(respuesta[2]);

                    if (nivel == 0 || nivel == 1)
                    {
                        resultado = 0; //Todo ok
                    }
                    else
                    {
                        resultado = 1; //Sin permisos
                    }
                }
                else if (password != respuesta[1].ToString())
                {
                    resultado = 2; //Contraseña incorrecta
                }
            }

            db.Desconectar();

            return resultado;
        }

        private void desbloquear(string usuarioAdesbloquear)
        {
            conexionBD dbMod = new conexionBD();
            try
            {
                dbMod.Conectar();
                dbMod.Modificar($"UPDATE login SET active=0 WHERE user='{usuarioAdesbloquear}';");
                dbMod.Desconectar();
                MessageBox.Show("Usuario desbloqueado.\nYa puede iniciar sesion.", "Desbloqueado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message.ToString(), "Error de conexión", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbMod.Desconectar();
            }          
        } //Desbloquear


        public static string GetSHA1(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        } // GetSHA1

    } //Clase
} //Namespace
