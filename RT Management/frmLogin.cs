using System;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            this.lblVersion.Text = String.Format("Versión {0}", AssemblyVersion);        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            conexionBD db = new conexionBD();
            string usuario = txtUser.Text;
            string password = GetSHA1(txtPass.Text);
            string last;
            int nivel = 9;
            int pass = 0;
            int contador = 0;
            int active = 9;

            try
            {
                db.Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message.ToString(), "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            MySqlDataReader respuesta = null;
            respuesta = db.Buscar("SELECT user, pass, level, last, active FROM login WHERE user='" + usuario + "';");

            while (respuesta.Read())
            {
                if ((usuario == respuesta[0].ToString()) && (password == respuesta[1].ToString()))
                {
                    nivel = Convert.ToInt16(respuesta[2]);
                    last = respuesta[3].ToString();
                    active = Convert.ToInt16(respuesta[4]);
                    contador++;                

                    try
                    {
                        conexionBD dbMod = new conexionBD();
                        dbMod.Conectar();
                        dbMod.Modificar("UPDATE login SET last=' " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', active=1 WHERE user='" + usuario + "';");
                        dbMod.Desconectar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo el siguiente error: " + ex.Message.ToString(), "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (active == 0)
                    {
                        frmMain form = new frmMain(usuario, nivel);
                        Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("No es posible iniciar sesión, el usuario ya se encuentra activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnDesbloquea.Visible = true;
                        btnDesbloquea.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass++;
                    txtPass.Focus();
                    txtPass.SelectionStart = 0;
                    txtPass.SelectionLength = txtPass.Text.Length;
                }
            }
            db.Desconectar();

            if ((contador) < 1 && (pass == 0))
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                txtUser.SelectionStart = 0;
                txtUser.SelectionLength = txtUser.Text.Length;
            }
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

        #region Assembly Attribute Accessors

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion

        private void btnDesbloquea_Click(object sender, EventArgs e)
        {
            frmLoginDesbloquea w = new frmLoginDesbloquea(this, txtUser.Text);
            w.Show();
            this.Hide();
        }
    }//Clase
} //Namespace
