using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace RT_Management
{
    public partial class frmUsuariosAgregar : Form
    {
        string usuarioActivo = "";

        public frmUsuariosAgregar(string usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar() 
        {
            string consulta = "";
            MySqlCommand cmd;
            conexionBD conexion = new conexionBD();         

            if (ValidaUsuario()) 
            {
                if (ValidaCampos())
                {
                    if (ValidaPass())
                    {
                        try
                        {
                            consulta = "INSERT INTO login (user, pass, name, lastname, level, last, created, usercreated, active) " 
                                + "VALUES (@user, @pass, @name, @lastname, @level, @last, @created, @usercreated, @active);";
                            conexion.Conectar();
                            cmd = conexion.Insertar(consulta);

                            cmd.Parameters.AddWithValue("user", txtUsuario.Text);
                            cmd.Parameters.AddWithValue("pass", Encriptar(txtPass.Text));
                            cmd.Parameters.AddWithValue("name", txtNombre.Text);
                            cmd.Parameters.AddWithValue("lastname", txtApellidos.Text);
                            cmd.Parameters.AddWithValue("level", GetLevel(comboLevel.Text));
                            cmd.Parameters.AddWithValue("last", "0000-00-00 00:00:00");
                            cmd.Parameters.AddWithValue("created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("usercreated", usuarioActivo);
                            cmd.Parameters.AddWithValue("active", 0);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally 
                        {
                            conexion.Desconectar();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Las contraseñas no son iguales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else 
                {
                    MessageBox.Show("No puede haber campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ValidaPass() 
        {
            Boolean respuesta = false;

            if (txtPass.Text == txtConfirmPass.Text)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        private Boolean ValidaUsuario() 
        {
            Boolean respuesta = false;
            conexionBD db = new conexionBD();
            int contador = 0;

            try 
            {
                MySqlDataReader respuestaDB = null;
                db.Conectar();
                respuestaDB = db.Buscar("SELECT * FROM login WHERE user='" + txtUsuario.Text + "';");
                while (respuestaDB.Read()) 
                {
                    contador++;
                }

                if (contador < 1)
                {
                    respuesta = true;
                }
                else 
                {
                    respuesta = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                respuesta = false;
            }
            finally 
            {
                db.Desconectar();
            }


            return respuesta;
        }

        private Boolean ValidaCampos() 
        {
            Boolean respuesta = false;

            if ((txtUsuario.Text == "") || (txtNombre.Text == "") || (txtApellidos.Text == "") || (txtPass.Text == "") || (txtConfirmPass.Text == "") || (comboLevel.Text == ""))
            {
                respuesta = false;
            }
            else 
            {
                respuesta = true;
            }

            return respuesta;
        }

        private int GetLevel(string nivel) 
        {
            int level = 0;

            if (nivel == "Administrador")
            {
                level = 1;
            }
            else if (nivel == "Usuario")
            {
                level = 2;
            }
            else if (nivel == "Invitado")
            {
                level = 3;
            }

            return level;
        }

        public static string Encriptar(string str)
        {
            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }



    }
}
