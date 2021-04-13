namespace CollegeManagementSystem
{
    using System.Data;
    using System.Data.SqlClient;

    class CollegeDB
    {
        // Return the Connection
        public SqlConnection GetConnection { get; } = new SqlConnection(Globals.ConnectionString);

        // Open the Connection
        public void OpenConnection()
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
    }
}