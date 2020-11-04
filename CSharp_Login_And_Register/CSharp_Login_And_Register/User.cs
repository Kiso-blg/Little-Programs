using System;
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Login_And_Register
{
    class User
    {
        // Check if the Username alread exists
        internal bool CheckIfUsernameExists(string username)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectUserByUsername", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100)).Value = username;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpneConnection();

                        adapter.Fill(table);

                        // Check if the User exist or not
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }            
        }

        // Insert New User
        internal bool InsertNewUser(string firstName, string lastName, string email, string username, string password)
        {
            DB db = new DB();

            using (SqlCommand command = new SqlCommand("InsertNewUser", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50)).Value = firstName;
                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50)).Value = lastName;
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100)).Value = email;
                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100)).Value = username;
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50)).Value = password;

                try
                {
                    db.OpneConnection();

                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}