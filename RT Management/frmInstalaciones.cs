using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmInstalaciones : Form
    {
        private static frmInstalaciones m_FormDefInstance;
        private static int level = -1;

        public static int levelUser
        {
            set
            {
                level = value;
            }
            get
            {
                return level;
            }
        }

        public frmInstalaciones()
        {
            InitializeComponent();
        }

        public static frmInstalaciones DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmInstalaciones();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void frmInstalaciones_Load(object sender, EventArgs e)
        {
            comboFiltro.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
            this.WindowState = FormWindowState.Maximized;
            lblRegistros.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            progreso.Visible = true;
            progreso.MarqueeAnimationSpeed = 30;
            
            Buscar();
        }

        private void Buscar()
        {           
            if (txtBusqueda.TextLength < 4)
            {
                MessageBox.Show("Ingrese al menos 4 caracteres para relizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                
                string filtro = comboFiltro.Text;
                string filtroColumna = "";
                string tipo = comboTipo.Text;
                string consulta;
                conexionBD db = new conexionBD();

                if (comboFiltro.SelectedIndex == 0)
                {
                    filtroColumna = "Cliente";
                }
                else if (comboFiltro.SelectedIndex == 1)
                {
                    filtroColumna = "GrupoIntegrante";
                }
                else if (comboFiltro.SelectedIndex == 2)
                {
                    filtroColumna = "Vin";
                }
                else if (comboFiltro.SelectedIndex == 3)
                {
                    filtroColumna = "PlatinumInstalado";
                }


                if (txtBusqueda.Text == "")
                {
                    MessageBox.Show("Ingrese el término a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboTipo.SelectedIndex == 0)
                    {
                        consulta = "SELECT Id, Cliente, Vin, VinAnterior, Fecha, Actividad, PlatinumInstalado, PlatinumRetirado, Carta, Marca, Modelo FROM instalaciones WHERE " + filtroColumna + " LIKE '%" + txtBusqueda.Text + "%';";
                    }
                    else
                    {
                        consulta = "SELECT Id, Cliente, Vin, VinAnterior, Fecha, Actividad, PlatinumInstalado, PlatinumRetirado, Carta, Marca, Modelo FROM instalaciones WHERE " + filtroColumna + "='" + txtBusqueda.Text.ToUpper() + "';";
                    }

                    try
                    {
                        db.Conectar();
                        MySqlDataAdapter datos = db.Adaptar(consulta);
                        DataTable tabla = new DataTable();
                        int i = datos.Fill(tabla);
                        if (i < 1)
                        {
                            gridDatos.DataSource = null;
                            lblRegistros.Text = "";
                            MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.Desconectar();
                        }
                        else
                        {

                            gridDatos.DataSource = tabla;
                            formatoEncabezados();
                            lblRegistros.Text = i.ToString() + " registros encontrados.";                            
                        }
                        db.Desconectar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Desconectar();
                    }
                    finally
                    {
                        db.Desconectar();
                    }
                }
            }//if
            progreso.MarqueeAnimationSpeed = 0;
            progreso.Visible = false;
        }

        private void formatoEncabezados()
        {
            gridDatos.Columns[0].Visible = false;
            gridDatos.Columns[1].HeaderText = "Titular";
            gridDatos.Columns[2].HeaderText = "VIN";
            gridDatos.Columns[3].HeaderText = "VIN Anterior";
            gridDatos.Columns[4].HeaderText = "Fecha";
            gridDatos.Columns[5].HeaderText = "Actividad";
            gridDatos.Columns[6].HeaderText = "Platinum Instalado";
            gridDatos.Columns[7].HeaderText = "Platinum Retirado";
            gridDatos.Columns[8].HeaderText = "Carta";
            gridDatos.Columns[9].HeaderText = "Marca";
            gridDatos.Columns[10].HeaderText = "Modelo";
        }

        private void gridDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            frmInstalacionesVer instalacion = new frmInstalacionesVer(id, levelUser);
            instalacion.ShowDialog();
        }
       

    } //Clase principal
}//Namespace
