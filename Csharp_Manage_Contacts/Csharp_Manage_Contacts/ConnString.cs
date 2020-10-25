using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Csharp_Manage_Contacts
{
    class ConnString
    {
        private string _connectionString;
        private string _connectionStringMaster;
        private string _serverName;

        private const string CONNECTIONSTRING_TEMPLATE = "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI";
        private const string DATABASE_NAME = "Contacts_DB";
        private const string DATABASE_NAME_MASTER = "master";

        // Establish the Connection with Master Method
        internal bool EstablishMasterConnection()
        {
            return CreateConnectionStrings();
        }

        // Create the Connection Strings Master Method
        private bool CreateConnectionStrings()
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

        // Create the Connection Strings Method
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

        // Get the Server Name Method
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

        // Check if the Database Exists Method
        internal bool CheckIfDatabaseExists()
        {
            string sqlQuery = $"SELECT db_id('{DATABASE_NAME}')";

            using (SqlConnection sqlConnection = new SqlConnection(this._connectionStringMaster))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    try
                    {
                        sqlConnection.Open();

                        return sqlCommand.ExecuteScalar() != DBNull.Value;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        // Execute Database Query from .SQL script file
        internal bool LoadDatabaseFromScript()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Csharp_Manage_ContactsSQLQuery.sql";

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
    }
}