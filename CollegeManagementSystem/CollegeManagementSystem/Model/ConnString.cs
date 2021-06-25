// <copyright file="ConnString.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using Microsoft.SqlServer.Management.Common;
    using Microsoft.SqlServer.Management.Smo;
    using Microsoft.SqlServer.Management.Smo.Wmi;            

    /// <summary>
    /// The main ConnString class.
    /// Check the database and creates connection strings.
    /// </summary>
    internal class ConnString
    {
        /// <summary>
        /// Contains template for the connection string.
        /// </summary>
        private const string ConnectionStringTemplate = "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI";

        /// <summary>
        /// Contains the database name.
        /// </summary>
        private const string DatabaseName = "CollegeManagementSystem_DB";

        /// <summary>
        /// Contains the database "master" name.
        /// </summary>
        private const string DatabaseMasterName = "master";

        /// <summary>
        /// Contains the connection string for the database.
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Contains the connection string for the Master database.
        /// </summary>
        private string connectionStringMaster;

        /// <summary>
        /// Contains the server name.
        /// </summary>
        private string serverName;

        /// <summary>
        /// Get the Server Name method.
        /// </summary>
        /// <returns>
        /// Return True if the process is successful.
        /// </returns>
        internal bool GetServerName()
        {
            try
            {
                ManagedComputer ms = new ManagedComputer();
                ms.ConnectionSettings.ProviderArchitecture = ProviderArchitecture.Use64bit;
                this.serverName = ms.Name + "\\" + ms.ServerInstances[0].Name;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Establish the Connection with database Master method.
        /// </summary>
        /// <returns>
        /// Return True if the process is successful.
        /// </returns>
        internal bool EstablishConnectionMaster()
        {
            string temporaryString = ConnectionStringTemplate;

            if (!string.IsNullOrEmpty(this.serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this.serverName);
                this.connectionStringMaster = temporaryString.Replace("<databasename>", DatabaseMasterName);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if Database Exists method.
        /// </summary>
        /// <returns>
        /// Return True if the database exists.
        /// </returns>
        internal bool CheckIfDatabaseExists()
        {
            string sqlQuery = $"SELECT db_id('{DatabaseName}')";

            using (SqlConnection connection = new SqlConnection(this.connectionStringMaster))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;

                    try
                    {
                        connection.Open();

                        return command.ExecuteScalar() != DBNull.Value;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Execute Database Query from .SQL script file.
        /// </summary>
        /// <returns>
        /// Return True if executing the database query is successful.
        /// </returns>
        internal bool LoadDatabaseFromScript()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "CollegeManagementSystem_DB_SQLQuery";

            try
            {
                string sqlScriptQuery = File.ReadAllText(filePath);

                ServerConnection serverConn = new ServerConnection(this.serverName);
                Server server = new Server(serverConn);
                serverConn.Connect();
                server.ConnectionContext.ExecuteNonQuery(sqlScriptQuery);
                serverConn.Disconnect();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// Create the ConnectionString method.
        /// </summary>
        /// <returns>
        /// Return True if the process is successful.
        /// </returns>
        internal bool EstablishConnection()
        {
            string temporaryString = ConnectionStringTemplate;

            if (!string.IsNullOrEmpty(this.serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this.serverName);
                this.connectionString = temporaryString.Replace("<databasename>", DatabaseName);
                Globals.SetConnectionString(this.connectionString);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
