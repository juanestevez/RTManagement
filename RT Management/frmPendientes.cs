using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmPendientes : Form
    {      

        private static frmPendientes m_FormDefInstance;
        private static string user = "";

        public frmPendientes()
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

        public static frmPendientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmPendientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void frmPendientes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            groupLista.Text = "Pendientes al día " + DateTime.Now.Day + " de " + getMonth(DateTime.Now.Month) + " de " + DateTime.Now.Year;
            getData();
        }

        private string getMonth(int month) 
        {
            String Month = "";

            switch (month) 
            {
                case 1: Month = "enero";
                    break;
                case 2: Month = "febrero";
                    break;
                case 3: Month = "marzo";
                    break;
                case 4: Month = "abril";
                    break;
                case 5: Month = "mayo";
                    break;
                case 6: Month = "junio";
                    break;
                case 7: Month = "julio";
                    break;
                case 8: Month = "agosto";
                    break;
                case 9: Month = "septiembre";
                    break;
                case 10: Month = "octubre";
                    break;
                case 11: Month = "noviembre";
                    break;
                case 12: Month = "diciembre";
                    break;
            }

            return Month;
        }

        private void limpiaCampos() 
        {
            txtComentarios.Text = "";
            txtGrupo.Text = "";
            txtPlatinum.Text = "";
            txtSolicitante.Text = "";
            txtTitular.Text = "";
            txtVin.Text = "";
        }

        private void getData() 
        {
            string query = "SELECT * from pendientes WHERE usuario='" + user + "' AND estado=0 ORDER BY fechaSolicitud ASC";
            conexionBD db = new conexionBD();
            try 
            {
                db.Conectar();
                MySqlDataAdapter datos = db.Adaptar(query);
                DataTable tabla = new DataTable();
                int i = datos.Fill(tabla);

                if (i < 1)
                {
                    gridDatos.DataSource = null;
                    groupLista.Text = "No hay pendientes.";
                    db.Desconectar();
                    limpiaCampos();
                    btnModificar.Enabled = false;
                    btnRealizada.Enabled = false;
                }
                else
                {
                    gridDatos.DataSource = tabla;
                    groupLista.Text = "Pendientes al día " + DateTime.Now.Day + " de " + getMonth(DateTime.Now.Month) + " de " + DateTime.Now.Year;
                    formatoEncabezados();
                    db.Desconectar();
                    btnModificar.Enabled = true;
                    btnRealizada.Enabled = true;
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

        private void formatoEncabezados() 
        {
            gridDatos.Columns[0].Visible = false; //id
            gridDatos.Columns[1].Visible = false; //estado
            gridDatos.Columns[2].Visible = false; //usuario

            gridDatos.Columns[3].HeaderText = "Titular"; //titular
            gridDatos.Columns[4].HeaderText = "Grupo-Int."; //grupo
            gridDatos.Columns[5].HeaderText = "VIN"; //vin
            gridDatos.Columns[6].HeaderText = "Platinum"; //platinum
            gridDatos.Columns[7].HeaderText = "Solicitado por:"; //solicitado
            gridDatos.Columns[8].HeaderText = "Comentarios"; // comentarios

            gridDatos.Columns[9].Visible = false; //fecha de solicitud
            gridDatos.Columns[10].Visible = false; //fecha de solucion

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();
            estilo.Font = new Font(gridDatos.Font, FontStyle.Bold);
            gridDatos.Columns[3].DefaultCellStyle = estilo;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPendientesAgregar frm = new frmPendientesAgregar(user);
            frm.ShowDialog();
            getData();
        }

        private void estadoControles(bool estado) 
        {
            txtComentarios.Enabled = estado;
            txtGrupo.Enabled = estado;
            txtPlatinum.Enabled = estado;
            txtSolicitante.Enabled = estado;
            txtTitular.Enabled = estado;
            txtVin.Enabled = estado;
        }

        private void loadDataToModify(int id) 
        {
            conexionBD db = new conexionBD();
            MySqlDataReader respuesta;
            string query = "SELECT id,solicitado,grupo,vin,platinum,titular,comentarios FROM pendientes WHERE id=" + id + ";";

            try 
            {
                db.Conectar();
                respuesta = db.Buscar(query);
                respuesta.Read();

                txtSolicitante.Text = respuesta[1].ToString();
                txtGrupo.Text = respuesta[2].ToString();
                txtVin.Text = respuesta[3].ToString();
                txtPlatinum.Text = respuesta[4].ToString();
                txtTitular.Text = respuesta[5].ToString();
                txtComentarios.Text = respuesta[6].ToString();
                db.Desconectar();
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

        private void gridDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            loadDataToModify(id);
        }

        private void markAsComplete(int id) 
        {
            conexionBD db = new conexionBD();
            string query = "UPDATE pendientes SET estado=1, fechaSolucion='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id=" + id + ";";
            int i = 0;

            try 
            {
                db.Conectar();
                i = db.Modificar(query);
                if (i > 0) 
                {
                    MessageBox.Show("Tarea completada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.Desconectar();
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                estadoControles(false);
                db.Desconectar();
            }
        }

        private void btnRealizada_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            markAsComplete(id);
        }

        private void modify(int id)
        {
            conexionBD db = new conexionBD();
            string query = "UPDATE pendientes SET solicitado='" + txtSolicitante.Text + "', grupo=" + Convert.ToInt32(txtGrupo.Text) 
                + ", vin='" + txtVin.Text + "', platinum='" + txtPlatinum.Text + "', titular='" + txtTitular.Text 
                + "', comentarios='" + txtComentarios.Text + "' WHERE id=" + id + ";";
            int i = 0;

            try
            {
                db.Conectar();
                i = db.Modificar(query);
                if (i > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.Desconectar();
                    loadDataToModify(id);
                    btnModificar.Enabled = true;
                    estadoControles(false);
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                estadoControles(false);
                db.Desconectar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            estadoControles(true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            modify(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            estadoControles(false);
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            int id;
            id = Convert.ToInt32(gridDatos.CurrentRow.Cells["id"].Value);
            loadDataToModify(id);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            getData();
        }

    }
}
