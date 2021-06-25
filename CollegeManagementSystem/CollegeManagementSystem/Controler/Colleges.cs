// <copyright file="Colleges.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The main Colleges class.
    /// Perform all functions for colleges.
    /// </summary>
    internal class Colleges
    {
        /// <summary>
        /// Contains Regex Pattern for College Name.
        /// </summary>
        private const string RegexCollegePattern = "^[a-zA-Z ]{5,300}$";

        /// <summary>
        /// Contains Regex Pattern.
        /// </summary>
        private const string RegexPattern = "^[a-zA-Z]{2,60}$";

        /// <summary>
        /// Contains Regex Pattern for Admin Name.
        /// </summary>
        private const string RegexAdminPattern = "^[a-zA-Z0-9]{3,60}$";

        /// <summary>
        /// Contains SQL Connection.
        /// </summary>
        private readonly CollegeDB db = new CollegeDB();

        /// <summary>
        /// Check if the entered data for registration is valid.
        /// </summary>
        /// <returns>
        /// Return True if the entered data is valid.
        /// </returns>
        /// <param name="collegeName">String containing college name.</param>
        /// <param name="rectorFirstName">String containing rector first name.</param>
        /// <param name="rectorLastName">String containing rector last name.</param>
        /// <param name="administrator">String containing administrator name.</param>
        /// <param name="password">String containing administrator password.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool IsDataValid(string collegeName, string rectorFirstName, string rectorLastName, string administrator, string password, out string errorMsg)
        {
            bool result = true;
            errorMsg = string.Empty;

            if (Regex.Match(collegeName, RegexCollegePattern).Success == false)
            {
                errorMsg += "College Name, ";
                result = false;
            }

            if (Regex.Match(rectorFirstName, RegexPattern).Success == false)
            {
                errorMsg += "Rector First Name, ";
                result = false;
            }

            if (Regex.Match(rectorLastName, RegexPattern).Success == false)
            {
                errorMsg += "Rector Last Name, ";
                result = false;
            }

            if (Regex.Match(administrator, RegexAdminPattern).Success == false)
            {
                errorMsg += "Administrator, ";
                result = false;
            }

            if (Regex.Match(password, RegexAdminPattern).Success == false)
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

        /// <summary>
        /// Check if the entered data for login is valid.
        /// </summary>
        /// <returns>
        /// Return True if the entered data is valid.
        /// </returns>
        /// <param name="administrator">String containing administrator name.</param>
        /// <param name="password">String containing administrator password.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool IsDataValid(string administrator, string password, out string errorMsg)
        {
            bool result = true;
            errorMsg = string.Empty;

            if (Regex.Match(administrator, RegexAdminPattern).Success == false)
            {
                errorMsg += "Administrator, ";
                result = false;
            }

            if (Regex.Match(password, RegexAdminPattern).Success == false)
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

        /// <summary>
        /// Check if the college already exists.
        /// </summary>
        /// <returns>
        /// Return True if the college already exists.
        /// </returns>
        /// <param name="collegeName">String containing college name.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool DoesCollegeExists(string collegeName, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DoesCollegeExists", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar, 300)).Value = collegeName;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        this.db.OpenConnection();

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
                        this.db.CloseConnection();
                    }
                }
            }
        }

        /// <summary>
        /// Register new college.
        /// </summary>
        /// <returns>
        /// Return True if the registration is successful.
        /// </returns>
        /// <param name="collegeName">String containing college name.</param>
        /// <param name="rectorFirstName">String containing rector first name.</param>
        /// <param name="rectorLastName">String containing rector last name.</param>
        /// <param name="administrator">String containing administrator name.</param>
        /// <param name="password">String containing administrator password.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool AddNewCollege(string collegeName, string rectorFirstName, string rectorLastName, string administrator, string password, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewCollege", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CollegeName", SqlDbType.VarChar, 300)).Value = collegeName;
                command.Parameters.Add(new SqlParameter("@RectorFirstName", SqlDbType.VarChar, 60)).Value = rectorFirstName;
                command.Parameters.Add(new SqlParameter("@RectorLastName", SqlDbType.VarChar, 60)).Value = rectorLastName;
                command.Parameters.Add(new SqlParameter("@Administrator", SqlDbType.VarChar, 60)).Value = administrator;
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 60)).Value = password;

                try
                {
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Login into college.
        /// </summary>
        /// <returns>
        /// Return True if the login is successful.
        /// </returns>
        /// <param name="administrator">String containing administrator name.</param>
        /// <param name="password">String containing administrator password.</param>
        /// <param name="collegeId">Integer containing college Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool Login(string administrator, string password, out int collegeId, out string errorMsg)
        {
            collegeId = 0;

            using (SqlCommand command = new SqlCommand("AdministratorLogin", this.db.GetConnection))
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
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }
    }
}
