using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RT_Management
{
    public partial class FrmUsuariosPortalModificar : Form
    {
        private int id = 0;

        public FrmUsuariosPortalModificar(int idUsuario)
        {
            id = idUsuario;
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            conexionBD db = new conexionBD();
            MySqlDataReader respuesta;
            string query = $"SELECT * FROM usuariosportal WHERE id = {id};";
            string activo = "";

            try
            {
                db.Conectar();
                respuesta = db.Buscar(query);
                respuesta.Read();

                txtNombre.Text = respuesta[1].ToString();
                txtPass.Text = respuesta[2].ToString();
                activo = respuesta[3].ToString();
                fechaAlta.Value = Convert.ToDateTime(respuesta[4].ToString());
                if (activo == "True")
                {
                    checkActivo.Checked = true;
                    lblBaja.Visible = false;
                    fechaBaja.Visible = false;
                    fechaBaja.Value = DateTime.Now;
                }
                else
                {
                    checkActivo.Checked = false;
                    lblBaja.Visible = true;
                    fechaBaja.Visible = true;
                    fechaBaja.Value = Convert.ToDateTime(respuesta[5].ToString());
                }
                fechaRevision.Value = Convert.ToDateTime(respuesta[6].ToString());
                checkRastreo.Checked = respuesta[7].ToString() == "True" ? true : false;
                checkMasivo.Checked = respuesta[8].ToString() == "True" ? true : false;
                checkIndividual.Checked = respuesta[9].ToString() == "True" ? true : false;
                check10p.Checked = respuesta[10].ToString() == "True" ? true : false;
                check20p.Checked = respuesta[11].ToString() == "True" ? true : false;
                checkInmovilizar.Checked = respuesta[12].ToString() == "True" ? true : false;
                checkMovilizar.Checked = respuesta[13].ToString() == "True" ? true : false;
                checkCancelar.Checked = respuesta[14].ToString() == "True" ? true : false;
                checkLocalizacion.Checked = respuesta[15].ToString() == "True" ? true : false;
                checkReporteComandos.Checked = respuesta[16].ToString() == "True" ? true : false;
                checkReporteGeneral.Checked = respuesta[17].ToString() == "True" ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar expediente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.Desconectar();
            }
            finally
            {
                db.Desconectar();
            }
        }

        private void GuardarDatos()
        {
            int i;
            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                i = db.Modificar(GetConsulta());
                if (i > 0)
                {
                    MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    db.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Desconectar();
            }
        }

        private string GetConsulta()
        {
            int activo = checkActivo.Checked ? 1 : 0;
            int rastreo = checkRastreo.Checked ? 1 : 0;
            int masivo = checkMasivo.Checked ? 1 : 0;
            int individual = checkIndividual.Checked ? 1 : 0;
            int diez = check10p.Checked ? 1 : 0;
            int veinte = check20p.Checked ? 1 : 0;
            int inmovilizar = checkInmovilizar.Checked ? 1 : 0;
            int movilizar = checkMovilizar.Checked ? 1 : 0;
            int cancelar = checkCancelar.Checked ? 1 : 0;
            int localizacion = checkLocalizacion.Checked ? 1 : 0;
            int reporteComandos = checkReporteComandos.Checked ? 1 : 0;
            int reporteGeneral = checkReporteGeneral.Checked ? 1 : 0;
            string consulta = "", baja = "";
            string alta = fechaAlta.Value.ToString("yyyy-MM-dd");
            string revision = fechaRevision.Value.ToString("yyyy-MM-dd");

            if (checkActivo.Checked)
            {
                baja = "0000-00-00";
            }
            else
            {
                baja = fechaBaja.Value.ToString("yyyy-MM-dd");
            }
            consulta = $"UPDATE usuariosportal set nombre='{txtNombre.Text}', pass='{txtPass.Text}', " +
                $"activo={activo}, alta='{alta}', baja='{baja}', revision='{revision}', " +
                $"rastreo={rastreo}, masivo={masivo}, individual={individual}, diez={diez}, veinte={veinte}, " +
                $"inmovilizar={inmovilizar}, movilizar={movilizar}, cancelar={cancelar}, localizacion={localizacion}, " +
                $"comandos={reporteComandos}, reportegral={reporteGeneral} WHERE id={id};";
            return consulta;
        }

        private void CheckActivo_CheckedChanged(object sender, EventArgs e)
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
                fechaBaja.Value = DateTime.Now;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            this.Close();
        }
    }
}
