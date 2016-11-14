using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmInstalacionesVer : Form
    {
        int idR;

        public frmInstalacionesVer(int id, int levelUser)
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.idR = id;
            LoadData(id);
            this.KeyDown += new KeyEventHandler(frmInstalacionesVer_KeyDown);
            if (levelUser == 3)
            {
                toolsEditar.Enabled = false;
            }
        }

        /// <summary>
        /// Consulta la base de datos y maneja errores.
        /// </summary>
        /// <param name="idReg">Identificación del número de registro.</param>
        private void LoadData(int idReg) 
        {
            conexionBD db = new conexionBD();
            MySqlDataReader respuesta = null;

            EstadoControles(true);

            try
            {
                db.Conectar();
                respuesta = db.Buscar("SELECT cliente, grupoIntegrante, vin, vinAnterior, " + 
                    "fecha, actividad, Cuenta, platinumInstalado, platinumRetirado, carta, marca, " + 
                    "modelo, anio, color, comentarios, Falla, Solucion FROM instalaciones WHERE id=" + idReg + ";");
                respuesta.Read();
                LlenaCampos(respuesta);
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

        /// <summary>
        /// Llena los campos del formulario de acuerdo a la consulta SQL.
        /// </summary>
        /// <param name="reader">DataReader que debe contener una consulta SQL válida.</param>
        private void LlenaCampos(MySqlDataReader reader) 
        {
            txtCliente.Text = reader[0].ToString();
            txtGrupo.Text = reader[1].ToString();
            txtVin.Text = reader[2].ToString();
            txtVinA.Text = reader[3].ToString();
            txtFecha.Text = reader[4].ToString();
            txtActividad.Text = reader[5].ToString();
            txtCuenta.Text = reader[6].ToString();
            txtPlatinum.Text = reader[7].ToString();
            txtPlatinumA.Text = reader[8].ToString();
            txtCarta.Text = reader[9].ToString();
            txtMarca.Text = reader[10].ToString();
            txtModelo.Text = reader[11].ToString();
            txtAnio.Text = reader[12].ToString();
            txtColor.Text = reader[13].ToString();
            txtComentarios.Text = reader[14].ToString();
            txtFalla.Text = reader[15].ToString();
            txtSolucion.Text = reader[16].ToString();
        }

        /// <summary>
        /// Activa o desactiva los controles.
        /// </summary>
        /// <param name="estado">Estado de los controles</param>
        private void EstadoControles(Boolean estado) 
        {
            txtCliente.ReadOnly = estado;
            txtGrupo.ReadOnly = estado;
            txtVin.ReadOnly = estado;
            txtVinA.ReadOnly = estado;
            txtActividad.ReadOnly = estado;
            txtPlatinum.ReadOnly = estado;
            txtPlatinumA.ReadOnly = estado;
            txtCarta.ReadOnly = estado;
            txtMarca.ReadOnly = estado;
            txtModelo.ReadOnly = estado;
            txtAnio.ReadOnly = estado;
            txtColor.ReadOnly = estado;
            txtComentarios.ReadOnly = estado;
            txtFalla.ReadOnly = estado;
            txtSolucion.ReadOnly = estado;
            txtCuenta.ReadOnly = estado;
        }


        private void frmInstalacionesVer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (toolsEditar.Enabled == true)
                {
                    this.Close();
                }
            }
        }

        private void toolsEditar_Click(object sender, EventArgs e)
        {
            toolsEditar.Enabled = false;
            toolsGuardar.Enabled = true;
            toolsCancelar.Enabled = true;
            EstadoControles(false);
        }

        private void toolsCancelar_Click(object sender, EventArgs e)
        {
            toolsEditar.Enabled = true;
            toolsGuardar.Enabled = false;
            toolsCancelar.Enabled = false;
            EstadoControles(true);
            LoadData(idR);
        }

        private void toolsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolsGuardar_Click(object sender, EventArgs e)
        {
            toolsEditar.Enabled = true;
            toolsGuardar.Enabled = false;
            toolsCancelar.Enabled = false;
            EstadoControles(true);
            GuardarDatos(idR);
        }

        /// <summary>
        /// Modifica en la base de datos la información capturada.
        /// </summary>
        /// <param name="id">Identificador del registro.</param>
        /// <returns>True si el guardado fue exitoso.</returns>
        private bool GuardarDatos(int id) 
        {
            string consulta = GetConsulta();
            bool estado = false;
            int i = 0;

            conexionBD db = new conexionBD();

            try
            {
                db.Conectar();
                i = db.Modificar(consulta);
                if (i > 0) 
                {
                    MessageBox.Show("Registro modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = true;
                    db.Desconectar();
                    LoadData(idR);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado = false;
            }
            finally
            {
                db.Desconectar();
                EstadoControles(true);
                toolsEditar.Enabled = true;
            }
            return estado;
        }

        /// <summary>
        /// Construye la consulta para modificar registros de la base de datos.
        /// </summary>
        /// <returns>Cadena de texto con la consulta SQL.</returns>
        private string GetConsulta() 
        {
            string consulta = "UPDATE instalaciones SET Cliente='" + txtCliente.Text + "', grupoIntegrante='" + txtGrupo.Text 
                + "', vin='" + txtVin.Text + "', vinAnterior='" + txtVinA.Text + "', actividad='" + txtActividad.Text 
                + "', Cuenta='"+ txtCuenta.Text + "', platinumInstalado='" + txtPlatinum.Text + "', platinumRetirado='" + txtPlatinumA.Text 
                + "', carta='" + txtCarta.Text + "', marca='" + txtMarca.Text + "', modelo='" + txtModelo.Text
                + "', anio='" + txtAnio.Text + "', color='" + txtColor.Text + "', comentarios='" + txtComentarios .Text 
                + "', Falla='" + txtFalla.Text + "', Solucion='" +txtSolucion.Text + "' WHERE id=" + this.idR + ";";
            return consulta;
        }

    }
}
