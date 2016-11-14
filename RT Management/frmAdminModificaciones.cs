using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmAdminModificaciones : Form
    {
        private static frmAdminModificaciones m_FormDefInstance;

        public frmAdminModificaciones()
        {
            InitializeComponent();
        }

        public static frmAdminModificaciones DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmAdminModificaciones();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void frmAdminModificaciones_Load(object sender, EventArgs e)
        {
            comboFiltro.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = comboFiltro.Text;
            string filtroColumna = "";
            string tipo = comboTipo.Text;
            string consulta;
            gridDatos.DataSource = null;
            conexionBD db = new conexionBD();

            if (comboFiltro.SelectedIndex == 0)
            {
                filtroColumna = "titular";
            }
            else if (comboFiltro.SelectedIndex == 1)
            {
                filtroColumna = "grupo";
            }
            else if (comboFiltro.SelectedIndex == 2)
            {
                filtroColumna = "vin";
            }
            else if (comboFiltro.SelectedIndex == 3)
            {
                filtroColumna = "platinum";
            }


            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Ingrese el término a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboTipo.SelectedIndex == 0)
                {
                    consulta = "SELECT id, clave, titular, grupo, platinum, vin FROM deducibles WHERE " + filtroColumna + " LIKE '%" + txtBusqueda.Text + "%'";
                }
                else
                {
                    consulta = "SELECT id, clave, titular, grupo, platinum, vin FROM deducibles WHERE " + filtroColumna + "='" + txtBusqueda.Text.ToUpper() + "'";
                }

                try
                {
                    db.Conectar();
                    MySqlDataAdapter datos = db.Adaptar(consulta);
                    DataTable tabla = new DataTable();
                    int i = datos.Fill(tabla);
                    if (i < 1)
                    {
                        gridExpedientes.DataSource = null;
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        gridExpedientes.DataSource = tabla;
                        formatoEncabezados();
                        gridExpedientes.Focus();
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


        private void formatoEncabezados()
        {
            gridExpedientes.Columns[0].HeaderText = "Id";
            gridExpedientes.Columns[1].HeaderText = "Clave";
            gridExpedientes.Columns[2].HeaderText = "Titular";
            gridExpedientes.Columns[3].HeaderText = "Contrato";
            gridExpedientes.Columns[4].HeaderText = "VIN";
            gridExpedientes.Columns[5].HeaderText = "Platinum";
        }

        private void gridDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idExpediente = gridExpedientes.CurrentRow.Cells["Clave"].Value.ToString();
            getData(idExpediente);
        }


        private void getData(string id)
        {
            conexionBD db = new conexionBD();
            string sql = "SELECT * FROM modificaciones where idExpediente='" + id + "';";

            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(sql);
                DataTable tabla = new DataTable();

                int i = datos.Fill(tabla);
                if (i < 1)
                {
                    gridDatos.DataSource = null;
                    MessageBox.Show("No existen movimientos para el expediente seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gridDatos.DataSource = tabla;
                    formatoEncabezadosMod();
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

        private void formatoEncabezadosMod()
        {
            gridDatos.Columns[0].HeaderText = "Transacción";
            gridDatos.Columns[1].Visible = false;
            gridDatos.Columns[2].HeaderText = "Usuario";
            gridDatos.Columns[3].HeaderText = "Fecha/Hora";
            gridDatos.Columns[4].HeaderText = "Acción";
            gridDatos.Columns[5].HeaderText = "Comentario";
        }
        




    }
}
