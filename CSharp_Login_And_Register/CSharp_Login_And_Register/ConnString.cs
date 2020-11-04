using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Data;
using System.IO;

namespace CSharp_Login_And_Register
{
    class ConnString
    {
        private string _connectionString;
        private string _connectionStringMaster;
        private string _serverName;

        private const string CONNECTIONSTRING_TEMPLATE = "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI";
        private const string DATABASE_NAME = "CSharp_Users_DB";
        private const string DATABASE_NAME_MASTER = "master";

        // Get Server Name Method
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

        // Create the Connection String Master Method
        internal bool CreateConnectionStringMaster()
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

        // Check if the Database Exists Method
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
                        return false;
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
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "CSharp_Login_And_RegisterSQLQuery.sql";

            try
            {
                string sqlScriptQuery = File.ReadAllText(filePath);

                ServerConnection serverConnection = new ServerConnection(this._serverName);
                Server server = new Server(serverConnection);
                serverConnection.Connect();
                server.ConnectionContext.ExecuteNonQuery(sqlScriptQuery);
                serverConnection.Disconnect();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        // Create the Connection Strings Method
        internal bool EstablishConnection()
        {
            string temporaryString = CONNECTIONSTRING_TEMPLATE;

            if (!string.IsNullOrEmpty(this._serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this._serverName);
                this._connectionString = temporaryString.Replace("<databasename>", DATABASE_NAME);
                DB.SetConnectionString(this._connectionString);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}