using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmUsuariosVer : Form
    {
        private string usuario = "";

        public frmUsuariosVer(string user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        private void toolsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuariosVer_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = this.usuario;
            loadData();
        }

        private void estadoControles(Boolean estado) 
        { 
        }

        private void loadData() 
        {
            conexionBD db = new conexionBD();

            try 
            {
                MySqlDataReader respuesta;
                db.Conectar();
                respuesta = db.Buscar("SELECT name, lastname, level FROM login WHERE user='" + this.usuario + "';");
                respuesta.Read();

                txtNombre.Text = respuesta[0].ToString();
                txtApellidos.Text = respuesta[1].ToString();

                if (Convert.ToInt16(respuesta[2]) == 0) 
                {
                    comboNivel.SelectedIndex = 0;
                }
                else if (Convert.ToInt16(respuesta[2]) == 1) 
                {
                    comboNivel.SelectedIndex = 1;
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

        private int getLevel(string texto) 
        {
            int estado = -1;

            if (comboNivel.Text == "Usuario") 
            {
                estado = 1;
            }
            else if (comboNivel.Text == "Administrador")
            {
                estado = 0;
            }
            return estado;
        }

        private void toolsEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            comboNivel.Enabled = true;
            toolsEditar.Enabled = false;
            toolsCancelar.Enabled = true;
            toolsGuardar.Enabled = true;
        }        

        private void toolsCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            comboNivel.Enabled = false;
            toolsEditar.Enabled = true;
            toolsCancelar.Enabled = false;
            toolsGuardar.Enabled = false;
        }

        private void toolsGuardar_Click(object sender, EventArgs e)
        { 
            string consulta = "UPDATE login SET name='" + txtNombre.Text + "', lastname='" + txtApellidos.Text + "', level=" + getLevel(comboNivel.Text)  + " WHERE user='" + txtUsuario.Text + "';";
            //MessageBox.Show(consulta);
            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                db.Modificar(consulta);
                MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Desconectar();
            }

            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            comboNivel.Enabled = false;
            toolsEditar.Enabled = true;
            toolsCancelar.Enabled = false;
            toolsGuardar.Enabled = false;
        }


    }
}
