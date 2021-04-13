namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    class Colleges
    {
        private const string regexCollegePattern = "^[a-zA-Z ]{5,300}$";
        private const string regexPattern = "^[a-zA-Z]{2,60}$";
        private const string regexAdminPattern = "^[a-zA-Z0-9]{3,60}$";

        private readonly CollegeDB db = new CollegeDB();

        // check if the entered data for registration is valid.
        internal bool IsDataValid(string collegeName, string rectorFirstName, string rectorLastName, string administrator, string password, out string errorMsg)
        {
            bool result = true;
            errorMsg = string.Empty;

            if (Regex.Match(collegeName, regexCollegePattern).Success == false)
            {
                errorMsg += "College Name, ";
                result = false;
            }

            if (Regex.Match(rectorFirstName, regexPattern).Success == false)
            {
                errorMsg += "Rector First Name, ";
                result = false;
            }

            if (Regex.Match(rectorLastName, regexPattern).Success == false)
            {
                errorMsg += "Rector Last Name, ";
                result = false;
            }

            if (Regex.Match(administrator, regexAdminPattern).Success == false)
            {
                errorMsg += "Administrator, ";
                result = false;
            }

            if (Regex.Match(password, regexAdminPattern).Success == false)
            {
                errorMsg += "Password, ";
                result = false;
            }

            if (!result)
            {
                errorMsg = errorMsg.Substring(0, errorMsg.Length - 2);
            }

            return result;
        }

        // Check if the entered data for login is valid.
        internal bool IsDataValid(string administrator, string password, out string errorMsg)
        {
            bool result = true;
            errorMsg = string.Empty;

            if (Regex.Match(administrator, regexAdminPattern).Success == false)
            {
                errorMsg += "Administrator, ";
                result = false;
            }

            if (Regex.Match(password, regexAdminPattern).Success == false)
            {
                errorMsg += "Password, ";
                result = false;
            }

            if (!result)
            {
                errorMsg = errorMsg.Substring(0, errorMsg.Length - 2);
            }

            return result;
        }        

        // Check if the college already exists.
        internal bool DoesCollegeExists(string collegeName, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DoesCollegeExists", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar, 300)).Value = collegeName;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            errorMsg = "The college already exists!";
                            return true;
                        }
                        else
                        {
                            errorMsg = "The college does not exists!";
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                        return true;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }

        // Register new college.
        internal bool AddNewCollege(string collegeName, string rectorFirstName, string rectorLastName, string administrator, string password, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewCollege", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar, 300)).Value = collegeName;
                command.Parameters.Add(new SqlParameter("@RectorFirstName", SqlDbType.VarChar, 60)).Value = rectorFirstName;
                command.Parameters.Add(new SqlParameter("@RectorLastName", SqlDbType.VarChar, 60)).Value = rectorLastName;
                command.Parameters.Add(new SqlParameter("@Administrator", SqlDbType.VarChar, 60)).Value = administrator;
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 60)).Value = password;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The college war registered successfuly.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not add college!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    errorMsg = ex.Message;
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // Login into college
        internal bool Login(string administrator, string password, out int collegeId, out string errorMsg)
        {
            collegeId = 0;

            using (SqlCommand command = new SqlCommand("AdministratorLogin", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Administrator", SqlDbType.VarChar, 60)).Value = administrator;
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 60)).Value = password;
                SqlParameter parameter = new SqlParameter("@CollegeId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parameter);

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();

                    if (int.TryParse(command.Parameters["@CollegeId"].Value.ToString(), out collegeId))
                    {
                        errorMsg = string.Empty;
                        return true;
                    }
                    else
                    {
                        errorMsg = "Wrond Administrator or Password!";
                        return false;
                    }                    
                }
                catch (Exception ex)
                {
                    errorMsg = ex.Message;
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