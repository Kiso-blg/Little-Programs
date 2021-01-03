using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class DBase
    {
        public SqlConnection GetConnection { get; } = new SqlConnection(
            "Data Source=KISO-DESKTOP\\SQLEXPRESS;Initial Catalog=Library_Management_System_DB;Integrated Security=True");

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