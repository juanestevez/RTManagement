using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmAddComment : Form
    {
        string user = "";
        string id = "0";
        string tabla = "";

        public frmAddComment(string id, string user, string tabla)
        {
            InitializeComponent();
            this.id = id;
            this.user = user;
            this.tabla = tabla;
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
            string destino = "";

            if (tabla == "deducibles")
            {
                destino = "comentarios";
            }
            else if (tabla == "correcciones")
            {
                destino = "correccioncontratoscom";
            }

            string query = "INSERT INTO " + destino + "(idExpediente, fecha, comentario, usuario) " 
                + " VALUES (@idExpediente,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', @comentario, @usuario);";
            conexionBD db = new conexionBD();
            MySqlCommand cmd;

            try
            {
                db.Conectar();
                cmd = db.Insertar(query);
                cmd.Parameters.AddWithValue("idExpediente", this.id);
                cmd.Parameters.AddWithValue("comentario", txtComment.Text);
                cmd.Parameters.AddWithValue("usuario", this.user);

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Comentario añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmAddComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                    this.Close();
            }
        }
    }
}
