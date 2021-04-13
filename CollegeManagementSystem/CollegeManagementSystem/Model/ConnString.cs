namespace CollegeManagementSystem
{
    using Microsoft.SqlServer.Management.Common;
    using Microsoft.SqlServer.Management.Smo;
    using Microsoft.SqlServer.Management.Smo.Wmi;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;

    class ConnString
    {
        private string _connectionString;
        private string _connectionStringMaster;
        private string _serverName;

        private const string CONNECTIONSTRING_TEMPLATE = "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI";
        private const string DATABASE_NAME = "CollegeManagementSystem_DB";
        private const string DATABASE_NAME_MASTER = "master";

        // Get the Server Name method.
        internal bool GetServerName()
        {
            try
            {
                ManagedComputer ms = new ManagedComputer();
                ms.ConnectionSettings.ProviderArchitecture = ProviderArchitecture.Use64bit;
                this._serverName = ms.Name + "\\" + ms.ServerInstances[0].Name;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Establish the Connection with Master method.
        internal bool EstablishConnectionMaster()
        {
            string temporaryString = CONNECTIONSTRING_TEMPLATE;

            if (!string.IsNullOrEmpty(this._serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this._serverName);
                this._connectionStringMaster = temporaryString.Replace("<databasename>", DATABASE_NAME_MASTER);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Check if Database Exists method
        internal bool CheckIfDatabaseExists()
        {
            string sqlQuery = $"SELECT db_id('{DATABASE_NAME}')";

            using (SqlConnection connection = new SqlConnection(this._connectionStringMaster))
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

        // Execute Database Query from .SQL script file
        internal bool LoadDatabaseFromScript()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "CollegeManagementSystem_DB_SQLQuery";

            try
            {
                string sqlScriptQuery = File.ReadAllText(filePath);

                ServerConnection serverConn = new ServerConnection(this._serverName);
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

        // Create the ConnectionString method
        internal bool EstablishConnection()
        {
            string temporaryString = CONNECTIONSTRING_TEMPLATE;

            if (!string.IsNullOrEmpty(this._serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this._serverName);
                this._connectionString = temporaryString.Replace("<databasename>", DATABASE_NAME);
                Globals.SetConnectionString(this._connectionString);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}