using System;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace RT_Management
{
    public partial class frmMain : Form
    {
        private string user;
        private int level;

        public frmMain(string usuario, int nivel)
        {
            InitializeComponent();
            this.user = usuario;
            this.level = nivel;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string estado = "Usuario activo: " + this.user;
            lblUser.Text = estado;
            if (this.level == 0 || this.level == 1)
            {
                menuAdmin.Visible = true;
                usuariosPortalToolStripMenuItem.Visible = true;
            }
            else
            {
                menuAdmin.Visible = false;
                usuariosPortalToolStripMenuItem.Visible = false;
            }

            if (this.level == 0)
            {
                deduciblesToolStripMenuItem1.Visible = true;
                deduciblesToolStripMenuItem1.Visible = true;
            }
            else 
            {
                deduciblesToolStripMenuItem1.Visible = false;
                deduciblesToolStripMenuItem1.Visible = false;
            }

            if (this.level == 3)
            {
                correccionesSolicitadasToolStripMenuItem.Visible = false;
                pendientesToolStripMenuItem.Visible = false;
                estadísticasToolStripMenuItem.Visible = false;
                toolStripMenuItem5.Visible = false;
                toolStripMenuItem2.Visible = false;
            }

            this.Text = $"RT Management v{Assembly.GetExecutingAssembly().GetName().Version.ToString()} Test";
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeduciblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeducibles.DefInstance.MdiParent = this;
            frmDeducibles.UsuarioActivo = this.user;
            frmDeducibles.levelUser = this.level;
            frmDeducibles.DefInstance.Activate();
            frmDeducibles.DefInstance.Show();
            FixMenu();
        }

        private void CambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswordCambio pass = new frmPasswordCambio(this.user);
            pass.ShowDialog();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios.DefInstance.MdiParent = this;
            frmUsuarios.DefInstance.Activate();
            frmUsuarios.UsuarioActivo = user;
            frmUsuarios.DefInstance.Show();
            FixMenu();
        }

        private void EnCascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ApiladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void EnParaleloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        public string GetUsuario()
        {
            return this.user;
        }

        private void DeduciblesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdminDeducibles.DefInstance.MdiParent = this;
            frmAdminDeducibles.DefInstance.Show();
            frmAdminDeducibles.DefInstance.Activate();
            FixMenu();
        }

        private void VerModificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminModificaciones.DefInstance.MdiParent = this;
            frmAdminModificaciones.DefInstance.Activate();
            frmAdminModificaciones.DefInstance.Show();
            FixMenu();
        }

        private void FixMenu()
        {
            this.menu.Visible = false;
            this.menu.Visible = true;
            this.menu.ResumeLayout();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmInstalaciones.DefInstance.MdiParent = this;
            frmInstalaciones.DefInstance.Activate();
            frmInstalaciones.levelUser = this.level;
            frmInstalaciones.DefInstance.Show();
            FixMenu();
        }

        private void EstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStats stats = new frmStats();
            stats.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexionBD bd = new conexionBD();
            bd.Conectar();
            bd.Modificar($"UPDATE login SET active=0 WHERE user='{user}';");
            bd.Desconectar();
            Application.Exit();
        }

        private void PendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendientes.DefInstance.MdiParent = this;
            frmPendientes.UsuarioActivo = this.user;
            frmPendientes.DefInstance.Activate();            
            frmPendientes.DefInstance.Show();
            FixMenu();
        }

        /// <summary>
        /// Realiza un respaldo de las bases de datos usando mysqldump.
        /// </summary>
        /// <param name="tablas">Parámetro con el nombre de las tablas al respaldar y sus opciones.</param>
        /// <param name="tipo">Tipo de respaldo: data o instalaciones.</param>
        public void Backup(string tablas, string tipo)
        {
            try
            {
                //Localización del programa mysqldump
                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Program Files\MariaDB 10.2\bin\mysqldump", tablas);

               // string directorio = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string nombreArchivo = DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");
                string filename = "";

                filename = GetRutaBackup(tipo);

                if (filename != "")
                {
                    this.Cursor = Cursors.WaitCursor;
                    using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
                    {
                        using (Process process = new Process())
                        {
                            psi.CreateNoWindow = true; // Evita que el proceso se inicie en una nueva ventana.
                            psi.UseShellExecute = false; // Evita que se use el shell del sistema operativo para iniciar el proceso.
                            psi.RedirectStandardOutput = true; // Escribir la salida en Process.StandarOuput
                            psi.StandardOutputEncoding = Encoding.UTF8; // Codificación de los datos de salida
                            process.StartInfo = psi;

                            process.OutputDataReceived +=

                            delegate (object sender, DataReceivedEventArgs e)
                            {
                                writer.WriteLine(e.Data);
                            };

                            process.Start();
                            process.BeginOutputReadLine(); // Lectura asincrónica del stream de salida
                            process.WaitForExit(); // Esperar a que el proceso termine.
                        }
                    }
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Copia de seguridad realizada con exito", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
            }
            catch (Exception exc)
            {
                MessageBox.Show("Se ha producido un error al realizar la copia de seguridad: " + exc, "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Backup

        /// <summary>
        /// Solicita al usuario nombre y directorio para guardar el respaldo.
        /// </summary>
        /// <param name="tipo">Tipo de respaldo: data o instalaciones.</param>
        /// <returns>Ruta del archivo a guardar</returns>
        private string GetRutaBackup(string tipo)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Archivo SQL (*.sql)|*.sql";
            dlGuardar.FileName = tipo + " " + DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");
            dlGuardar.Title = "Copia de seguridad";
            string filename = "";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                filename = dlGuardar.FileName;
            }
            else 
            {
                filename = "";
            }
            return filename;
        }

        private void MenuBackupInfo_Click(object sender, EventArgs e)
        {
            Backup("-u rtmanagement -p\"rtmanagement\" rtmanagement --add-drop-table --complete-insert --ignore-table=rtmanagement.instalaciones", "data");
        }

        private void MenuBackupInstalaciones_Click(object sender, EventArgs e)
        {
            Backup("-u rtmanagement -p\"rtmanagement\" rtmanagement --add-drop-table --complete-insert --extended-insert --tables instalaciones", "instalaciones");
        }

        private void CorreccionesSolicitadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCorreccionesGpoInt.DefInstance.MdiParent = this;
            frmCorreccionesGpoInt.UsuarioActivo = this.user;
            frmCorreccionesGpoInt.levelUser = this.level;
            frmCorreccionesGpoInt.DefInstance.Activate();
            frmCorreccionesGpoInt.DefInstance.Show();
            FixMenu();
        }

        private void UsuariosPortalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuariosPortal.DefInstance.MdiParent = this;
            frmUsuariosPortal.UsuarioActivo = this.user;
            frmUsuariosPortal.DefInstance.Activate();
            frmUsuariosPortal.DefInstance.Show();
            FixMenu();
        }
    } //Clase
} //Namespace
