using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmUsuarios : Form
    {
        private static frmUsuarios m_FormDefInstance;
        private static string user = "";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public static string UsuarioActivo
        {
            set
            {
                user = value;
            }
            get
            {
                return user;
            }
        }

        public static frmUsuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmUsuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionBD db = new conexionBD();
            string texto = txtBusqueda.Text;
            string consulta = "SELECT user, name, lastname, last, created, usercreated FROM login WHERE user LIKE '%" + texto + "%'";

            if (txtBusqueda.TextLength < 3) 
            {
                MessageBox.Show("Ingrese al menos 3 caracteres para relizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try
                {
                    db.Conectar();
                    MySqlDataAdapter datos = db.Adaptar(consulta);
                    DataTable tabla = new DataTable();
                    int i = datos.Fill(tabla);
                    if (i < 1)
                    {
                        gridDatos.DataSource = null;
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        gridDatos.DataSource = tabla;
                        formatoEncabezados();
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
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void formatoEncabezados()
        {
            gridDatos.Columns[0].HeaderText = "Usuario";
            gridDatos.Columns[1].HeaderText = "Nombre";
            gridDatos.Columns[2].HeaderText = "Apellidos";
            gridDatos.Columns[3].HeaderText = "Último ingreso";
            gridDatos.Columns[4].HeaderText = "Creación";
            gridDatos.Columns[5].HeaderText = "Administrador";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmUsuariosAgregar agregarUsuario = new frmUsuariosAgregar(user);
            agregarUsuario.ShowDialog();
        }

        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string usuario = gridDatos.CurrentRow.Cells["user"].Value.ToString();
            frmUsuariosVer frmUsuario = new frmUsuariosVer(usuario);
            frmUsuario.ShowDialog();
        }


    }
}
