using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmLlamadasHistorial : Form
    {
        private int id = 0;

        public frmLlamadasHistorial(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmLlamadasHistorial_Load(object sender, EventArgs e)
        {
            loadData(this.id);
        }

        private void loadData(int id) 
        {
            string query = "SELECT * FROM llamadas WHERE idExpediente='" + id + "' ORDER BY fecha DESC;";
            conexionBD db = new conexionBD();
            DataTable tabla = new DataTable();

            try 
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(query);
                int i = datos.Fill(tabla);

                if (i < 1)
                {
                    gridDatos.DataSource = null;
                    MessageBox.Show("No hay registro de llamadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.Desconectar();
                    this.Close();
                }
                else
                {
                    gridDatos.DataSource = tabla;

                    gridDatos.Columns[0].Visible = false; //id
                    gridDatos.Columns[1].Visible = false; //idExpediente
                    gridDatos.Columns[2].HeaderText = "Fecha";
                    gridDatos.Columns[3].HeaderText = "Status";
                    gridDatos.Columns[4].HeaderText = "Teléfono";
                    gridDatos.Columns[5].HeaderText = "Recibe llamada";
                    gridDatos.Columns[6].HeaderText = "Comentarios";
                    gridDatos.Columns[7].HeaderText = "Usuario";

                    db.Desconectar();

                    if (i == 1) 
                    {
                        this.Text = "Historial de llamadas - 1 registro encontrado.";
                    }
                    else 
                    {
                        this.Text = "Historial de llamadas - " + i + " registros encontrados.";
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

        private void frmLlamadasHistorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        


    }
}
