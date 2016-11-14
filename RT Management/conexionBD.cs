﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RT_Management.Properties;
using System.Configuration;

namespace RT_Management
{
    class conexionBD
    {
        private MySqlCommand command;
        private MySqlConnection conexionMySQL = null;
        private MySqlDataReader reader;
        private MySqlDataAdapter adaptador;

        /// <summary>
        /// Obtiene la cadena de conexión desde app.config
        /// </summary>
        /// <returns>Cadena de conexión</returns>
        private string getCadenaConexion()
        {
            return Settings.Default.BdRtmanagement;
        }

        /// <summary>
        /// Conecta a la base de datos, si la conexión se encuentra abierta primero se cerrará.
        /// </summary>
        public void Conectar()
        {
            if (conexionMySQL != null)
            {
                conexionMySQL.Close();
            }

            string cadenaConexion = getCadenaConexion();

            try
            {
                conexionMySQL = new MySqlConnection(cadenaConexion);
                conexionMySQL.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Cierra la conexión a la base de datos.
        /// </summary>
        public void Desconectar()
        {
            if (conexionMySQL != null)
            {
                conexionMySQL.Close();
            }
        }

        /// <summary>
        /// Busca registros dentro de la base de datos.
        /// </summary>
        /// <param name="cadena">Consulta SQL a ejecutar.</param>
        /// <returns></returns>
        public MySqlDataReader Buscar(String cadena)
        {
            command = new MySqlCommand(cadena, conexionMySQL);
            reader = command.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// Busca registros.
        /// </summary>
        /// <param name="cadena">Cadena SQL con la consulta.</param>
        /// <returns>Número de registros encontrados.</returns>
        public int BuscarNum(String cadena) 
        {
            int valor = 0;

            command = new MySqlCommand(cadena, conexionMySQL);
            reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                valor++;
            }

            return valor;
        }

        public MySqlDataAdapter Adaptar(String cadena)
        {
            command = new MySqlCommand(cadena, conexionMySQL);
            adaptador = new MySqlDataAdapter(command);
            return adaptador;
        }

        /// <summary>
        /// Modifica registro de la base de datos.
        /// </summary>
        /// <param name="cadena">Consulta SQL.</param>
        /// <returns>Número de filas afectadas.</returns>
        public int Modificar(String cadena)
        {
            int i = 0;

            command = new MySqlCommand(cadena, conexionMySQL);
            i = command.ExecuteNonQuery();

            //Regresa el numero de registros (update, delete, insert, etc) realizados
            return i;
        }

        /// <summary>
        /// Inserta un nuevo registro en la base de datos.
        /// </summary>
        /// <param name="cadena">Cadena SQL.</param>
        /// <returns></returns>
        public MySqlCommand Insertar(String cadena)
        {
            command = new MySqlCommand(cadena, conexionMySQL);
            return command;
        }

        /// <summary>
        /// Guarda el registro de modificación.
        /// </summary>
        /// <param name="id">Identificador del expediente.</param>
        /// <param name="usuario">Usuario que modifica.</param>
        /// <param name="accion">Acción realizada.</param>
        /// <param name="motivo">Motivo de la edición.</param>
        public void lastModify(string id, string usuario, string accion, string motivo)
        {
            string cadena = "INSERT INTO modificaciones (idExpediente, usuario, fechaHora, accion, motivo) "
                + "VALUES (@idExpediente, @usuario, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', @accion, @motivo)";
            command = new MySqlCommand(cadena, conexionMySQL);
            command.Parameters.AddWithValue("idExpediente", id);
            command.Parameters.AddWithValue("usuario", usuario);
            command.Parameters.AddWithValue("accion", accion);
            command.Parameters.AddWithValue("motivo", motivo);
            command.ExecuteNonQuery();
        }

    } //Clase
} //Namespace
