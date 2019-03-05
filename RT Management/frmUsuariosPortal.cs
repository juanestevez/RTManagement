using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RT_Management
{
    public partial class frmUsuariosPortal : Form
    {
        private static frmUsuariosPortal m_FormDefInstance;
        private static string user = "";

        public frmUsuariosPortal()
        {
            InitializeComponent();
        }

        public static frmUsuariosPortal DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmUsuariosPortal();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
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

        private void ToolAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuariosPortalAgregar frm = new frmUsuariosPortalAgregar(UsuarioActivo);
            frm.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreAbuscar = txtBuscarNombre.Text;

            if (nombreAbuscar != "")
            {
                BuscarRegistros("nombre AS Nombre, pass AS Password, activo AS Activo", $"nombre LIKE '%{nombreAbuscar}%'");
            }
            else
            {
                MessageBox.Show("Ingrese el nombre a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarRegistros(string campos, string condicion)
        {
            string query = $"SELECT id, {campos} FROM usuariosportal WHERE {condicion};";
            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(query);
                DataTable tabla = new DataTable();
                int i = datos.Fill(tabla);

                if (i < 1)
                {
                    gridUsuarios.DataSource = null;
                    MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    txtBuscarNombre.SelectionStart = 0;
                    txtBuscarNombre.SelectionLength = txtBuscarNombre.Text.Length;
                }
                else
                {
                    gridUsuarios.DataSource = tabla;
                    gridUsuarios.Columns[0].Visible = false;

                    if (i == 1)
                    {
                        txtEstatus.Text = i.ToString() + " resultado";
                        gridUsuarios.Focus();
                    }
                    else if (i == 0)
                    {
                        txtEstatus.Text = "No se encontraron registros";
                    }
                    else if (i > 1)
                    {
                        txtEstatus.Text = i.ToString() + " resultados";
                        gridUsuarios.Focus();
                    }
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

        private void ActivosToolStripMenuItemActivos_Click(object sender, EventArgs e)
        {
            gridUsuarios.DataSource = null;
            BuscarRegistros("nombre AS Nombre, pass AS Acceso, alta AS Alta, revision AS Revision, " +
                "rastreo AS 'Rastreo de registros', masivo AS 'Comandos masivo', individual AS 'Comandos individual', " +
                "diez AS 10P, veinte AS 20P, inmovilizar AS Inmovilizar, movilizar AS Movilizar, cancelar AS Cancelar, " +
                "localizacion AS Localizacion, comandos AS 'Reporte de comandos', reportegral AS 'Reporte general'", 
                "activo = 1;");
            gridUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void VerTodoToolStripMenuItemVerTodo_Click(object sender, EventArgs e)
        {
            gridUsuarios.DataSource = null;
            BuscarRegistros("nombre AS Nombre, pass AS Acceso, activo AS Activo, alta AS Alta, " +
                "baja AS Baja, revision AS Revision, rastreo AS 'Rastreo de registros', masivo AS 'Comandos masivo', " +
                "individual AS 'Comandos individual', diez AS 10P, veinte AS 20P, inmovilizar AS Inmovilizar, " +
                "movilizar AS Movilizar, cancelar AS Cancelar, localizacion AS Localizacion, " +
                "comandos AS 'Reporte de comandos', reportegral AS 'Reporte general'", "activo = 1 OR activo = 0;");
            gridUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void GridUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridUsuarios.CurrentRow.Cells["id"].Value.ToString());
            var mod = new FrmUsuariosPortalModificar(id);
            mod.ShowDialog();
        }
    }
}
