﻿using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class DBase
    {
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