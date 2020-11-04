namespace CSharp_Login_And_Register
{
    using System.Data;
    using System.Data.SqlClient;

    class DB
    {
        // The Connection String Container
        public static string ConnectionString { get; private set; }

        // Get Sql Connection
        public SqlConnection GetConnection { get; } 
            = new SqlConnection(ConnectionString);

        // Open the Connection
        public void OpneConnection()
        {
            if (this.GetConnection.State == ConnectionState.Closed)
            {
                this.GetConnection.Open();
            }
        }

        // Close the Connection
        public void CloseConnection()
        {
            if (this.GetConnection.State == ConnectionState.Open)
            {
                this.GetConnection.Close();
            }
        }

        // Set the Connection String
        public static void SetConnectionString(string connString)
        {
            ConnectionString = connString;
        }
    }
}