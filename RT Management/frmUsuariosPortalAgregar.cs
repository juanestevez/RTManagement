using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RT_Management
{
    public partial class frmUsuariosPortalAgregar : Form
    {
        string usuarioActivo = "";
        public frmUsuariosPortalAgregar(string usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarUsuario();
            }
        }

        private void GuardarUsuario()
        {
            MySqlCommand cmd;
            conexionBD conexion = new conexionBD();
            string query = "INSERT into usuariosportal(id, nombre, pass, activo, alta, baja, revision, " +
                "rastreo, masivo, individual, diez, veinte, inmovilizar, movilizar, cancelar, localizacion, " +
                "comandos, reportegral, usuario) values(NULL, @nombre, @pass, @activo, @alta, @baja, @revision, @rastreo," +
                "@masivo, @individual, @diez, @veinte, @inmovilizar, @movilizar, @cancelar, @localizacion, " +
                "@comandos, @reportegral, @usuario);";
            string baja = "";

            try
            {
                conexion.Conectar();
                cmd = conexion.Insertar(query);

                try
                {
                    cmd.Parameters.AddWithValue("nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("pass", txtPass.Text);
                    cmd.Parameters.AddWithValue("activo", checkActivo.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("alta", fechaAlta.Value.ToString("yyyy-MM-dd"));
                    if (checkActivo.Checked)
                    {
                        baja = "0000-00-00";
                    }
                    else
                    {
                        baja = fechaBaja.Value.ToString("yyyy-MM-dd");
                    }
                    cmd.Parameters.AddWithValue("baja", baja);
                    cmd.Parameters.AddWithValue("revision", fechaRevision.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("rastreo", checkRastreo.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("masivo", checkMasivo.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("individual", checkIndividual.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("diez", check10p.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("veinte", check20p.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("inmovilizar", checkInmovilizar.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("movilizar", checkMovilizar.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("cancelar", checkCancelar.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("localizacion", checkLocalizacion.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("comandos", checkReporteComandos.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("reportegral", checkReporteGeneral.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("usuario", usuarioActivo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha registrado el usuario", "Registro exitoso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar datos.\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al conectar con la base de datos.\n", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Desconectar();
            }
            finally
            {
                conexion.Desconectar();
            }         
        }

        private bool ValidarCampos()
        {
            bool respuesta = false;

            if (txtNombre.Text == "")
            {
                lblNombre.ForeColor = Color.Red;
                lblPass.ForeColor = Control.DefaultForeColor;
                txtNombre.Focus();
                respuesta = false;
                MessageBox.Show("Ingrese el nombre", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass.Text == "")
            {
                lblPass.ForeColor = Color.Red;
                lblNombre.ForeColor = Control.DefaultForeColor;
                txtPass.Focus();
                respuesta = false;
                MessageBox.Show("Ingrese la contraseña", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblNombre.ForeColor = Control.DefaultForeColor;
                lblPass.ForeColor = Control.DefaultForeColor;
                respuesta = true;
            }
            return respuesta;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPass.Text = "";
            checkActivo.Checked = false;
            checkRastreo.Checked = false;
            checkMasivo.Checked = false;
            checkIndividual.Checked = false;
            check10p.Checked = false;
            check20p.Checked = false;
            checkInmovilizar.Checked = false;
            checkMovilizar.Checked = false;
            checkCancelar.Checked = false;
            checkLocalizacion.Checked = false;
            checkReporteComandos.Checked = false;
            checkReporteGeneral.Checked = false;
            fechaAlta.Value = DateTime.Now;
            fechaRevision.Value = DateTime.Now;
            fechaBaja.Value = DateTime.Now;
            txtNombre.Focus();
        }

        private void CheckUsuarioActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkActivo.Checked)
            {
                lblBaja.Visible = false;
                fechaBaja.Visible = false;
            }
            else
            {
                lblBaja.Visible = true;
                fechaBaja.Visible = true;
            }
        }
    }
}
