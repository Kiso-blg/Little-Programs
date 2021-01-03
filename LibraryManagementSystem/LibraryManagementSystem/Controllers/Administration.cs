using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    internal class Administration
    {
        private const string regexPattern = "^[a-zA-Z0-9]{3,50}$";

        private readonly DBase db = new DBase();

        // Check if the data is valid for adding new administration.
        internal bool IsDataValid(string administrationName, string chiefAdmin, string adminFirstName, string adminLastName, string password, string confirmPassword, out string errorMessage)
        {
            bool result = true;
            errorMessage = string.Empty;

            if (Regex.Match(administrationName, regexPattern).Success == false)
            {
                errorMessage += "Administration Name, ";
                result = false;
            }

            if (Regex.Match(chiefAdmin, regexPattern).Success == false)
            {
                errorMessage += "Chief Administrator, ";
                result = false;
            }

            if (Regex.Match(adminFirstName, regexPattern).Success == false)
            {
                errorMessage += "Administrator First Name, ";
                result = false;
            }

            if (Regex.Match(adminLastName, regexPattern).Success == false)
            {
                errorMessage += "Administrator Last Name, ";
                result = false;
            }

            if (Regex.Match(password, regexPattern).Success == false
                || password == "Password")
            {
                errorMessage += "Password, ";
                result = false;
            }

            if (Regex.Match(confirmPassword, regexPattern).Success == false)
            {
                errorMessage += "Confirm Password, ";
                result = false;
            }

            if (!result)
            {
                errorMessage = errorMessage.Substring(0, errorMessage.Length - 2);
            }

            return result;
        }

        // Check if the entered data is valid.
        internal bool IsDataValid(string administrationName, out string message)
        {
            bool result = true;
            message = string.Empty;

            if (Regex.Match(administrationName, regexPattern).Success == false)
            {
                message += "Administration Name is incorrect!";
                result = false;
            }

            return result;
        }

        // Check if the data is valid for deleting administration.
        internal bool IsDataValid(string administrationName, string chiefAdminLogin, string chiefAdminPassword, out string errorMessage)
        {
            bool result = true;
            errorMessage = string.Empty;

            if (Regex.Match(administrationName, regexPattern).Success == false)
            {
                errorMessage += "Administration Name, ";
                result = false;
            }

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

            if (!result)
            {
                errorMessage = errorMessage.Substring(0, errorMessage.Length - 2);
            }

            return result;
        }

        // Check if there is an administration with the current chief admin.
        // Return administration Id or 0.
        internal bool IsChiefAdminCorrect(string chiefAdmin, string adminPassword, out int administrationId, out string message)
        {
            administrationId = 0;

            using (SqlCommand command = new SqlCommand("DoesChiefAdminExists", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorLogin", SqlDbType.VarChar, 50)).Value = chiefAdmin;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorPassword", SqlDbType.VarChar, 50)).Value = adminPassword;
                SqlParameter returnAdminnistrationId = new SqlParameter("@AdministrationId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(returnAdminnistrationId);

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
                        message = "Wrong Chief Administrator or Password!";
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

        // Check if the Administration already exists.
        internal bool DoesAdministrationExists(string administrationName, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("SelectfAdministration", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@AdministrationName", SqlDbType.VarChar, 50)).Value = administrationName;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            errorMessage = "The administration already exists!";
                            return true;
                        }
                        else
                        {
                            errorMessage = "The administration does not exists!";
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                        return true;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }

        // Add new Administration.
        internal bool AddAdministration(string administrationName, string chiefAdminLogin, string password, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("AddAdministration", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationName", SqlDbType.VarChar, 50)).Value = administrationName;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorLogin", SqlDbType.VarChar, 50)).Value = chiefAdminLogin;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorPassword", SqlDbType.VarChar, 50)).Value = password;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = string.Empty;
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not add Administration!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }                       

        // Add new Chief Administrator.
        internal bool AddChiefAdministrator(string administrationName, string chiefAdminLogin, string adminFirstName, string adminLastName, string password, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("AddChiefAdministrator", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministratorLogin", SqlDbType.VarChar, 50)).Value = chiefAdminLogin;
                command.Parameters.Add(new SqlParameter("@AdminFirstName", SqlDbType.VarChar, 50)).Value = adminFirstName;
                command.Parameters.Add(new SqlParameter("@AdminLastName", SqlDbType.VarChar, 50)).Value = adminLastName;
                command.Parameters.Add(new SqlParameter("@AdminPassword", SqlDbType.VarChar, 50)).Value = password;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = $"Administration {administrationName} with Chief Administrator {chiefAdminLogin} were added successfully.";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not add Chief Administrator!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // Delete Administration.
        internal bool DeleteAdministration(string administrationName, string chiefAdminLogin, string password, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("DeleteAdministration", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationName", SqlDbType.VarChar, 50)).Value = administrationName;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorLogin", SqlDbType.VarChar, 50)).Value = chiefAdminLogin;
                command.Parameters.Add(new SqlParameter("@ChiefAdministratorPassword", SqlDbType.VarChar, 50)).Value = password;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "The Administration was deleted successfully.";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not delete the Administration!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
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