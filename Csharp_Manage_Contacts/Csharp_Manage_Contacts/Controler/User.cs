using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    class User
    {
        readonly ManageContacts_DB db = new ManageContacts_DB();

        // Function to check if the Username Exists while Register new User
        public bool DoesUsernameExists(string username)
        {
            using (SqlCommand sqlCommand = new SqlCommand("uspSelectCurrentUsername", db.GetConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100));
                sqlCommand.Parameters["@Username"].Value = username;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // If the user exists return true
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }

                }
            }
        }

        // Function to check if the Username exists while Edit Data of a Logged in User
        public bool DoesUsernameExists(string username, int userId)
        {
            using (SqlCommand sqlCommand = new SqlCommand("uspEditCurrentUsername", db.GetConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100));
                sqlCommand.Parameters["@Username"].Value = username;

                sqlCommand.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                sqlCommand.Parameters["@UserId"].Value = userId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // If the user exists return true
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }

                }
            }
        }

        // Insert a new User
        public bool InsertUser(string firstName, string lastName, string username, string password, MemoryStream picture)
        {
            using (SqlCommand command = new SqlCommand("uspInsertUser", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 100));
                command.Parameters["@FirstName"].Value = firstName;

                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 100));
                command.Parameters["@LastName"].Value = lastName;

                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100));
                command.Parameters["@Username"].Value = username;

                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 20));
                command.Parameters["@Password"].Value = password;

                command.Parameters.Add(new SqlParameter("@Picture", SqlDbType.VarBinary));
                command.Parameters["@Picture"].Value = picture.ToArray();

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // Create a Function to Return the User Data using Id
        public DataTable GetUserByID(int userId)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("uspSelectAllFromUsers", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            return table;
        }

        // Create a Function to Edit the User Data
        public bool UpdateUser(int userId, string firstName, string lastName, string username, string password, MemoryStream picture)
        {
            using (SqlCommand command = new SqlCommand("uspEditUser", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 100));
                command.Parameters["@FirstName"].Value = firstName;

                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 100));
                command.Parameters["@LastName"].Value = lastName;

                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100));
                command.Parameters["@Username"].Value = username;

                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 20));
                command.Parameters["@Password"].Value = password;

                command.Parameters.Add(new SqlParameter("@Picture", SqlDbType.VarBinary));
                command.Parameters["@Picture"].Value = picture.ToArray();

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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