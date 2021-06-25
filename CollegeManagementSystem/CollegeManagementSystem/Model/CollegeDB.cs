// <copyright file="CollegeDB.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// The main CollegeDB class.
    /// Perform all processes with the SQL connection.
    /// </summary>
    internal class CollegeDB
    {
        /// <summary>
        /// Gets SQL connection.
        /// </summary>
        /// <value>SQL connection.</value>
        public SqlConnection GetConnection { get; } = new SqlConnection(Globals.ConnectionString);

        /// <summary>
        /// Open the Connection
        /// </summary>
        public void OpenConnection()
        {
            if (this.GetConnection.State == ConnectionState.Closed)
            {
                this.GetConnection.Open();
            }
        }

        /// <summary>
        /// Close the Connection
        /// </summary>
        public void CloseConnection()
        {
            if (this.GetConnection.State == ConnectionState.Open)
            {
                this.GetConnection.Close();
            }
        }
    }
}
