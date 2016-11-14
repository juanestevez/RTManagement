using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace RT_Management
{
    public partial class frmAdminDeducibles : Form
    {
        private static frmAdminDeducibles m_FormDefInstance;

        public frmAdminDeducibles()
        {
            InitializeComponent();
        }

        public static frmAdminDeducibles DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmAdminDeducibles();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void frmAdminDeducibles_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            comboFiltro.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = comboFiltro.Text;
            string filtroColumna = "";
            string tipo = comboTipo.Text;
            string consulta;
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
            else {
                if (comboTipo.SelectedIndex == 0)
                {
                    consulta = "SELECT * FROM deducibles WHERE " + filtroColumna + " LIKE '%" + txtBusqueda.Text + "%'";
                }
                else
                {
                    consulta = "SELECT * FROM deducibles WHERE " + filtroColumna + "='" + txtBusqueda.Text.ToUpper() + "'";
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

        private void verRegistros(string tipo)
        {
            string consulta = "";
            conexionBD db = new conexionBD();

            if (tipo == "pendiente")
            {
                consulta = "SELECT * FROM deducibles WHERE status=0";
            }
            else if (tipo == "incompleto")
            {
                consulta = "SELECT * FROM deducibles WHERE status=1";
            }
            else if (tipo == "procedente")
            {
                consulta = "SELECT * FROM deducibles WHERE status=2";
            }
            else if (tipo == "no procedente")
            {
                consulta = "SELECT * FROM deducibles WHERE status=3";
            }
            else if (tipo == "todo")
            {
                consulta = "SELECT * FROM deducibles";
            }

            try
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(consulta);
                DataTable tabla = new DataTable();

                datos.Fill(tabla);
                gridDatos.DataSource = tabla;

                formatoEncabezados();
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

        private void formatoEncabezados()
        {
            /*gridDatos.Columns[0].HeaderText = "Id";
            gridDatos.Columns[1].HeaderText = "Estatus";
            gridDatos.Columns[2].HeaderText = "Titular";
            gridDatos.Columns[3].HeaderText = "Contrato";
            gridDatos.Columns[4].HeaderText = "Platinum";
            gridDatos.Columns[5].HeaderText = "VIN";
            gridDatos.Columns[6].HeaderText = "Visita";
            gridDatos.Columns[7].HeaderText = "Recepción";
            gridDatos.Columns[8].HeaderText = "PQR";
            gridDatos.Columns[9].HeaderText = "Dictamen";
            gridDatos.Columns[10].HeaderText = "Proceso";
            gridDatos.Columns[11].HeaderText = "Comentarios";
            gridDatos.Columns[12].HeaderText = "Tel. Domicilio";
            gridDatos.Columns[13].HeaderText = "Tel. Celular";
            gridDatos.Columns[14].HeaderText = "Tel. Alerno";
            gridDatos.Columns[15].HeaderText = "Email";
            gridDatos.Columns[16].HeaderText = "Robo";
            gridDatos.Columns[17].HeaderText = "Aseguradora";
            gridDatos.Columns[18].HeaderText = "Valor factura";
            gridDatos.Columns[19].HeaderText = "% Deducible";
            gridDatos.Columns[20].HeaderText = "Monto deducible";*/
        }

        private void itemVer_ButtonClick(object sender, EventArgs e)
        {
            verRegistros("todo");
        }

        private void enProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verRegistros("pendiente");
        }

        private void incompletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verRegistros("incompleto");
        }

        private void procedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verRegistros("procedente");
        }

        private void noProcedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verRegistros("no procedente");
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verRegistros("todo");
        }

        private void gridDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridDatos.Columns[e.ColumnIndex].Name == "status")
            {
                if (e.Value.ToString() == "0") //En proceso
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "1") //Incompleto
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "2") //Procedente
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "3") //No procedente
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "4") //Para envío
                {
                    e.CellStyle.BackColor = Color.DarkBlue;
                    e.CellStyle.ForeColor = Color.DarkBlue;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }

                if (e.Value.ToString() == "5") //Entregado
                {
                    e.CellStyle.BackColor = Color.Chartreuse;
                    e.CellStyle.ForeColor = Color.Chartreuse;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }
                if (e.Value.ToString() == "6") //Archivado
                {
                    e.CellStyle.BackColor = Color.Sienna;
                    e.CellStyle.ForeColor = Color.Sienna;
                    e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                    e.CellStyle.SelectionForeColor = SystemColors.Highlight;
                }
            }
        }
    } //clase
} //namespace
