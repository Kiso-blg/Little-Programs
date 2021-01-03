using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    class Administrator
    {
        private const string regexPattern = "^[a-zA-Z0-9]{3,50}$";

        private static readonly DBase db = new DBase();

        // Check if the data is valid for adding new administrator.
        internal bool IsDataValid(string chiefAdmin, string adminPassword, string newAdmin, string firstName, string lastName, string password, string confirmPassword, out string message)
        {
            bool result = true;
            message = string.Empty;

            if (Regex.Match(chiefAdmin, regexPattern).Success == false)
            {
                message += "Chief Administrator, ";
                result = false;
            }

            if (Regex.Match(adminPassword, regexPattern).Success == false)
            {
                message += "Admin Password, ";
                result = false;
            }

            if (Regex.Match(newAdmin, regexPattern).Success == false)
            {
                message += "New Administrator, ";
                result = false;
            }

            if (Regex.Match(firstName, regexPattern).Success == false)
            {
                message += "Administrator First Name, ";
                result = false;
            }

            if (Regex.Match(lastName, regexPattern).Success == false)
            {
                message += "Administrator Last Name, ";
                result = false;
            }

            if (Regex.Match(password, regexPattern).Success == false
                || password == "Password")
            {
                message += "Password, ";
                result = false;
            }

            if (Regex.Match(confirmPassword, regexPattern).Success == false)
            {
                message += "Confirm Password, ";
                result = false;
            }

            if (!result)
            {
                message = message.Substring(0, message.Length - 2);
            }

            return result;
        }        

        // Check if the data is valid for deleting administration.
        internal bool IsDataValid(string chiefAdminLogin, string chiefAdminPassword, string adminName, out string errorMessage)
        {
            bool result = true;
            errorMessage = string.Empty;            

            if (Regex.Match(chiefAdminLogin, regexPattern).Success == false)
            {
                errorMessage += "Chief Administrator, ";
                result = false;
            }

            if (Regex.Match(chiefAdminPassword, regexPattern).Success == false
                || chiefAdminPassword == "Password")
            {
                errorMessage += "Password, ";
                result = false;
            }

            if (Regex.Match(adminName, regexPattern).Success == false)
            {
                errorMessage += "Administrator Login, ";
                result = false;
            }

            if (!result)
            {
                errorMessage = errorMessage.Substring(0, errorMessage.Length - 2);
            }

            return result;
        }        

        // Check if the data is valid for selecting administration.
        internal bool IsDataValid(string admin, string password, out string message)
        {
            bool result = true;
            message = string.Empty;

            if (Regex.Match(admin, regexPattern).Success == false)
            {
                message += "Administrator, ";
                result = false;
            }

            if (Regex.Match(password, regexPattern).Success == false
                || password == "Password")
            {
                message += "Password, ";
                result = false;
            }

            if (!result)
            {
                message = message.Substring(0, message.Length - 2);
            }

            return result;
        }

        // Check if there is an administrator with the current username and password and return its administration ID.
        internal bool IsLoginAdminCorrect(string adminLogin, string adminPassword, out int administrationId, out string message)
        {
            administrationId = 0;

            using (SqlCommand command = new SqlCommand("DoesAdminExists", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministratorLogin", SqlDbType.VarChar, 50)).Value = adminLogin;
                command.Parameters.Add(new SqlParameter("@AdministratorPassword", SqlDbType.VarChar, 50)).Value = adminPassword;
                SqlParameter parameter = new SqlParameter("@AdministrationId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parameter);

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    administrationId = int.Parse(command.Parameters["@AdministrationId"].Value.ToString());

                    if (administrationId > 0)
                    {
                        message = string.Empty;
                        return true;
                    }
                    else
                    {
                        message = "Wrong Administrator or Password!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    return false;
                }
            }
        }

        // Check if the administrator already exists.
        internal bool DoesAdministratorExists(int administrationId, string newAdmin, out string message)
        {
            using (SqlCommand command = new SqlCommand("SelectAdministrator", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = administrationId;
                command.Parameters.Add(new SqlParameter("@AdministratorLogin", SqlDbType.VarChar, 50)).Value = newAdmin;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            message = "The administrator already exists!";
                            return true;
                        }
                        else
                        {
                            message = string.Empty;
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        message = ex.Message;
                        return true;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }        

        // Add new Administrator.
        internal bool AddNewAdministrator(int administrationId, string newAdmin, string firstName, string lastName, string password, out string message)
        {
            using (SqlCommand command = new SqlCommand("AddNewAdministrator", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = administrationId;
                command.Parameters.Add(new SqlParameter("@AdministratorLogin", SqlDbType.VarChar, 50)).Value = newAdmin;
                command.Parameters.Add(new SqlParameter("@AdminFirstName", SqlDbType.VarChar, 50)).Value = firstName;
                command.Parameters.Add(new SqlParameter("@AdminLastName", SqlDbType.VarChar, 50)).Value = lastName;
                command.Parameters.Add(new SqlParameter("@AdminPassword", SqlDbType.VarChar, 50)).Value = password;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        message = $"Administrator {newAdmin} was added successfully.";
                        return true;
                    }
                    else
                    {
                        message = "Could not add the administrator!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    return false;
                }
            }
        }

        // Select table with all administrators and return them to Form Select Administrator.
        internal DataTable SelectAllAdministrators(int administrationId, out string message)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllAdministrators", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = administrationId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();
                        
                        adapter.Fill(table);
                        message = string.Empty;                        
                }
                    catch (Exception ex)
                    {
                        message = ex.Message;
                    }
                }                
            }

            return table;
        }

        // Delete Administrator.
        internal bool DeleteAdministrator(int administrationId, string adminName, out string message)
        {
            using (SqlCommand command = new SqlCommand("DeleteAdministrator", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = administrationId;
                command.Parameters.Add(new SqlParameter("@AdministratorLogin", SqlDbType.VarChar, 50)).Value = adminName;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        message = "The Administrator was deleted successfully.";
                        return true;
                    }
                    else
                    {
                        message = "Could not delete the Administrator or Administrator does not exists!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
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