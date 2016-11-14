using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmPendientesAgregar : Form
    {
        private string usuarioActivo = "";

        public frmPendientesAgregar(string usuario)
        {
            InitializeComponent();
            this.usuarioActivo = usuario;
        }        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData() 
        {
            string query = "INSERT INTO pendientes(id, estado, usuario, titular, grupo, vin, platinum, " +
                "solicitado, comentarios, fechaSolicitud, fechaSolucion) VALUES (NULL, @estado, @usuario, " +
                "@titular, @grupo, @vin, @platinum, @solicitado, @comentarios, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + 
                "', '0000-00-00 00:00:00');";
            conexionBD db = new conexionBD();
            MySqlCommand cmd;

            try 
            {
                db.Conectar();
                cmd = db.Insertar(query);
                cmd.Parameters.AddWithValue("estado", 0);
                cmd.Parameters.AddWithValue("usuario", this.usuarioActivo);
                cmd.Parameters.AddWithValue("titular", txtTitular.Text);
                cmd.Parameters.AddWithValue("grupo", Convert.ToInt32(txtGrupo.Text));
                cmd.Parameters.AddWithValue("vin", txtVin.Text);
                cmd.Parameters.AddWithValue("platinum", txtPlatinum.Text);
                cmd.Parameters.AddWithValue("solicitado", txtSolicitante.Text);
                cmd.Parameters.AddWithValue("comentarios", txtComentarios.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Desconectar();
                this.Close();
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
}
