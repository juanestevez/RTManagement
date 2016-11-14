using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RT_Management
{
    public partial class frmDeduciblesAgregar : Form
    {
        private string usuario;

        public frmDeduciblesAgregar(string user)
        {
            InitializeComponent();
            this.usuario = user;
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validaCampos() 
        {
            //Comprueba si alguno de los campos obligatorios está vacío
            Boolean valido = false;
            if ((cmbEstado.Text == "") || (txtTitular.Text == "") || (txtGrupo.Text == "") || (txtVin.Text == "") || (txtPlatinum.Text == "") || (txtTelCelular.Text == "") || (txtEmail.Text == "") || (cmbAseguradora.Text == "")) 
            {
                valido = false;
            }
            else 
            {
                valido = true;
            }

            return valido;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbEstado.SelectedIndex == 2) || (cmbEstado.SelectedIndex == 3)) //Procedente, No procedente
            {
                lblRobo.Visible = true;
                dateRobo.Visible = true;
                lblVisita.Visible = true;
                dateVisita.Visible = true;
                lblDiasProceso.Visible = true;
                numDiasProceso.Visible = true;
                lblDictamen.Visible = true;
                dateDictamen.Visible = true;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = true;
                dateC3.Visible = true;
            }
            else if (cmbEstado.SelectedIndex == 1) //Incompleto
            {
                lblRobo.Visible = true;
                dateRobo.Visible = true;
                lblVisita.Visible = true;
                dateVisita.Visible = true;
                lblRecepcion.Visible = false;
                dateRecepcion.Visible = false;
                lblPqr.Visible = false;
                datePqr.Visible = false;
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
            }
            else if (cmbEstado.SelectedIndex == 4) //Para envío
            {
                lblRobo.Visible = true;
                dateRobo.Visible = true;
                lblVisita.Visible = true;
                dateVisita.Visible = true;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
                numDiasProceso.Value = 0;
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = false;
                datePqr.Visible = false;
                lblC3.Visible = false;
                dateC3.Visible = false;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
            }
            else if (cmbEstado.SelectedIndex == 5) //Entregado a PQR
            {
                lblRobo.Visible = true;
                dateRobo.Visible = true;
                lblVisita.Visible = true;
                dateVisita.Visible = true;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
                numDiasProceso.Value = 0;
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = false;
                dateC3.Visible = false;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
            }
            else
            {
                lblRobo.Visible = true;
                dateRobo.Visible = true;
                lblVisita.Visible = true;
                dateVisita.Visible = true;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
                numDiasProceso.Value = 0;
                lblDictamen.Visible = false;
                dateDictamen.Visible = false;
                lblRecepcion.Visible = true;
                dateRecepcion.Visible = true;
                lblPqr.Visible = true;
                datePqr.Visible = true;
                lblC3.Visible = true;
                dateC3.Visible = true;
                lblDiasProceso.Visible = false;
                numDiasProceso.Visible = false;
            }
        }

        private void limpiarCampos() 
        {
            txtEmail.Text = "";
            txtGrupo.Text = "";
            txtPlatinum.Text = "";
            txtTelAlterno.Text = "";
            txtTelCelular.Text = "";
            txtTelDomicilio.Text = "";
            txtTitular.Text = "";
            txtVin.Text = "";
            dateDictamen.Value = DateTime.Now;
            datePqr.Value = DateTime.Now;
            dateRecepcion.Value = DateTime.Now;
            dateRobo.Value = DateTime.Now.AddDays(-30);
            dateVisita.Value = DateTime.Now;
            dateC3.Value = DateTime.Now;
            numDeducible.Value = 0;
            numDiasProceso.Value = 0;
            numMonto.Value = 0;
            numValorFactura.Value = 0;
            cmbAseguradora.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtTitular.Focus();
            txtExpediente.Text = "";
            checkAcuse.Checked = false;
            checkFiniquito.Checked = false;
            checkCartaPerdida.Checked = false;
            checkPoliza.Checked = false;
            checkFactura.Checked = false;
            checkActa.Checked = false;
            checkAcred.Checked = false;
            checkBaja.Checked = false;
            checkPagoBaja.Checked = false;
            checkTenencia.Checked = false;
            checkIdentificacion.Checked = false;
            checkPfp.Checked = false;
            checkContrato.Checked = false;
            numSumaA.Value = 0;
            lblRobo.Visible = false;
            lblVisita.Visible = false;
            lblRecepcion.Visible = false;
            lblPqr.Visible = false;
            lblC3.Visible = false;
            lblDictamen.Visible = false;
            dateRobo.Visible = false;
            dateVisita.Visible = false;
            dateRecepcion.Visible = false;
            datePqr.Visible = false;
            dateC3.Visible = false;
            dateDictamen.Visible = false;
        }

        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                } 
        }

        private void txtTelDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                } 
        }

        private void txtTelCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                } 
        }

        private void txtTelAlterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                } 
        }

        private void numValorFactura_Enter(object sender, EventArgs e)
        {
            numValorFactura.Select(0, numValorFactura.Text.Length);
        }

        private void numDeducible_Enter(object sender, EventArgs e)
        {
            numDeducible.Select(0, numDeducible.Text.Length);
        }

        private void numMonto_Enter(object sender, EventArgs e)
        {
            numMonto.Select(0, numMonto.Text.Length);
        }

        private void numDiasProceso_Enter(object sender, EventArgs e)
        {
            numDiasProceso.Select(0, numDiasProceso.Text.Length);
        }

        private void txtTelDomicilio_Enter(object sender, EventArgs e)
        {
            txtTelDomicilio.SelectionStart = 0;
            txtTelDomicilio.SelectionLength = txtTelDomicilio.Text.Length;
        }

        private void txtTelCelular_Enter(object sender, EventArgs e)
        {
            txtTelCelular.SelectionStart = 0;
            txtTelCelular.SelectionLength = txtTelCelular.Text.Length;
        }

        private void txtTelAlterno_Enter(object sender, EventArgs e)
        {
            txtTelAlterno.SelectionStart = 0;
            txtTelAlterno.SelectionLength = txtTelAlterno.Text.Length;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string idNuevo = DateTime.Now.ToString("yyyyMMddHHmmss");
            MySqlCommand cmd;
            int valor = 9;
            conexionBD conexion = new conexionBD();

            string cadena = "INSERT INTO deducibles(id, clave, status, titular, grupo, platinum, vin, fechaVisita, "
                + "fechaRecepcion, FechaPQR, fechaDictamen, fechaC3, diasProceso, comentarios, telefonoDomicilio, "
                + "telefonoCelular, telefonoAdicional, email, fechaRobo, aseguradora, valorFactura, valorDeducible, montoPago, expediente, "
                + "acuse, finiquito, sumaAsegurada, cartaPerdida, poliza, factura, acta, acred, baja, pagoBaja, tenencia, identificacion, "
                + "pfp, contrato, goodWill, fechaGoodWill, porcentajeGoodWill) VALUES (NULL, @clave, @status, @titular, @grupo, @platinum, "
                + "@vin, @fechaVisita, @fechaRecepcion, @fechaPQR, @fechaDictamen, @fechaC3, @diasProceso, NULL, @telefonoDomicilio, "
                + "@telefonoCelular, @telefonoAdicional, @email, @fechaRobo, @aseguradora, @valorFactura, @valorDeducible, @montoPago, " 
                + "@expediente, @acuse, @finiquito, @sumaAsegurada, @cartaPerdida, @poliza, @factura, @acta, @acred, @baja, @pagoBaja, "
                + "@tenencia, @identificacion, @pfp, @contrato, @goodWill, @fechaGoodWill, @porcentajeGoodWill);";

            if (validaCampos())
            {
                try
                {
                    conexion.Conectar();

                    cmd = conexion.Insertar(cadena);

                    if (cmbEstado.SelectedIndex == 0)
                    {
                        valor = 0;
                    }
                    else if (cmbEstado.SelectedIndex == 1)
                    {
                        valor = 1;
                    }
                    else if (cmbEstado.SelectedIndex == 2)
                    {
                        valor = 2;
                    }
                    else if (cmbEstado.SelectedIndex == 3)
                    {
                        valor = 3;
                    }
                    else if (cmbEstado.SelectedIndex == 4)
                    {
                        valor = 4;
                    }
                    else if (cmbEstado.SelectedIndex == 5)
                    {
                        valor = 5;
                    }

                    cmd.Parameters.AddWithValue("clave", idNuevo);

                    cmd.Parameters.AddWithValue("status", valor);
                    cmd.Parameters.AddWithValue("titular", txtTitular.Text);
                    cmd.Parameters.AddWithValue("grupo", Convert.ToInt32(txtGrupo.Text));
                    cmd.Parameters.AddWithValue("platinum", txtPlatinum.Text);
                    cmd.Parameters.AddWithValue("vin", txtVin.Text);

                    cmd.Parameters.AddWithValue("fechaVisita", dateVisita.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                    if (cmbEstado.SelectedIndex == 0) //En proceso
                    {
                        cmd.Parameters.AddWithValue("fechaRecepcion", dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaPQR", datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaDictamen", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaC3", dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else if (cmbEstado.SelectedIndex == 1) //Incompleto
                    {
                        cmd.Parameters.AddWithValue("fechaRecepcion", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaPQR", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaDictamen", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaC3", "0000-00-00 00:00:00");
                    }
                    else if ((cmbEstado.SelectedIndex == 2) || (cmbEstado.SelectedIndex == 3)) //Procedente y no procedente
                    {
                        cmd.Parameters.AddWithValue("fechaRecepcion", dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaPQR", datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaDictamen", dateDictamen.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaC3", dateC3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else if (cmbEstado.SelectedIndex == 4) //Para envío
                    {
                        cmd.Parameters.AddWithValue("fechaRecepcion", dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaPQR", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaDictamen", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaC3", "0000-00-00 00:00:00");
                    }
                    else if (cmbEstado.SelectedIndex == 5) //Entregado a PQR
                    {
                        cmd.Parameters.AddWithValue("fechaRecepcion", dateRecepcion.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaPQR", datePqr.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("fechaDictamen", "0000-00-00 00:00:00");
                        cmd.Parameters.AddWithValue("fechaC3", "0000-00-00 00:00:00");
                    }

                    if ((cmbEstado.SelectedIndex == 0) || (cmbEstado.SelectedIndex == 1))
                    {
                        cmd.Parameters.AddWithValue("diasProceso", -1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("diasProceso", numDiasProceso.Value);
                    }

                    if (txtTelDomicilio.Text == "")
                    {
                        cmd.Parameters.AddWithValue("telefonoDomicilio", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("telefonoDomicilio", Convert.ToInt64(txtTelDomicilio.Text));
                    }

                    cmd.Parameters.AddWithValue("telefonoCelular", Convert.ToInt64(txtTelCelular.Text));


                    if (txtTelAlterno.Text == "")
                    {
                        cmd.Parameters.AddWithValue("telefonoAdicional", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("telefonoAdicional", Convert.ToInt64(txtTelAlterno.Text));
                    }
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("fechaRobo", dateRobo.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                    cmd.Parameters.AddWithValue("aseguradora", cmbAseguradora.Text);
                    cmd.Parameters.AddWithValue("valorFactura", numValorFactura.Value);
                    cmd.Parameters.AddWithValue("valorDeducible", numDeducible.Value);
                    cmd.Parameters.AddWithValue("montoPago", numMonto.Value);
                    cmd.Parameters.AddWithValue("expediente", txtExpediente.Text);

                    cmd.Parameters.AddWithValue("acuse", checkAcuse.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("finiquito", checkFiniquito.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("sumaAsegurada", numSumaA.Value);
                    cmd.Parameters.AddWithValue("cartaPerdida", checkCartaPerdida.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("poliza", checkPoliza.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("factura", checkFactura.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("acta", checkActa.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("acred", checkAcred.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("baja", checkBaja.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("pagoBaja", checkPagoBaja.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("tenencia", checkTenencia.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("identificacion", checkIdentificacion.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("pfp", checkPfp.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("contrato", checkContrato.Checked ? 1 : 0);

                    cmd.Parameters.AddWithValue("goodWill", 0);
                    cmd.Parameters.AddWithValue("fechaGoodWill", "0000-00");
                    cmd.Parameters.AddWithValue("porcentajeGoodWill", 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.lastModify(idNuevo, this.usuario, "Created", cmbEstado.Text);
                    limpiarCampos();
                    conexion.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en el guardado.\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Desconectar();
                }
                finally
                {
                    conexion.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Los campos marcados con asterisco no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDeduciblesAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cmbAseguradora_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtExpediente.Text.Length < 4)
            {
                if (cmbAseguradora.Text == "Banorte")
                {
                    numDeducible.Value = 20;
                    txtExpediente.Text = "B-";
                }
                else if (cmbAseguradora.Text == "Mapfre")
                {
                    numDeducible.Value = 10;
                    txtExpediente.Text = "MP-";
                }
                else if (cmbAseguradora.Text == "Qualitas")
                {
                    numDeducible.Value = 30;
                    txtExpediente.Text = "QT-";
                }
                else if (cmbAseguradora.Text == "GNP")
                {
                    numDeducible.Value = 10;
                    txtExpediente.Text = "G-";
                }
                else
                {
                    numDeducible.Value = 0;
                    txtExpediente.Text = "";
                }
            }
        }

        private void calculaPago()
        {
            decimal porcentaje = numDeducible.Value;
            decimal sumaAsegurada = numSumaA.Value;
            decimal valorFactura = numValorFactura.Value;
            decimal montoDeducible = 0;
            decimal montoPago = 0;
            decimal IVA = 1.16m;

            if (porcentaje > 0) //¿Porcentaje mayor a cero?
            {
                if (sumaAsegurada > 0)
                {
                    if (porcentaje > 20)
                    {
                        montoDeducible =(sumaAsegurada) * 0.20m;
                        montoPago = montoDeducible / IVA;
                        numMonto.Value = (sumaAsegurada) * (porcentaje / 100);
                        MessageBox.Show("El valor máximo a pagar es del 20%.\nEl monto del deducible al 20% es de " + montoDeducible.ToString("c2") 
                            + "\nEl monto a pagar es de " + montoPago.ToString("c2"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        montoDeducible = (sumaAsegurada) * (porcentaje / 100);
                        montoPago = montoDeducible / IVA;
                        numMonto.Value = montoDeducible;
                        MessageBox.Show("El monto del deducible es de " + montoDeducible.ToString("c2") 
                            + "\nEl monto a pagar es de " + montoPago.ToString("c2"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario capturar la suma asegurada.", "No es posible realizar el cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //Porcentaje es cero
            {
                MessageBox.Show("Es necesario capturar el porcentaje del deducible.", "No es posible realizar el cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            calculaPago();
        }
    } //
}//