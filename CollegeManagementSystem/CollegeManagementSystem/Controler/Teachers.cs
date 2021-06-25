// <copyright file="Teachers.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The main Teachers class.
    /// Perform all functions for teachers.
    /// </summary>
    internal class Teachers
    {
        /// <summary>
        /// Contains Regex Pattern for Name.
        /// </summary>
        private const string NamePattern = "^[a-zA-Z]{2,100}$";

        /// <summary>
        /// Contains Regex Pattern for Phone Number.
        /// </summary>
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";

        /// <summary>
        /// Contains Regex Pattern for E-mail Address.
        /// </summary>
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-zA-Z\-]{2,}(\.[a-z]{2,})$";

        /// <summary>
        /// Contains Regex Pattern for Address.
        /// </summary>
        private const string AddressPattern = "^[a-zA-Z0-9.'\", ]{5,300}$";

        /// <summary>
        /// Contains SQL Connection.
        /// </summary>
        private readonly CollegeDB db = new CollegeDB();

        /// <summary>
        /// Check if the entered data is valid.
        /// </summary>
        /// <returns>
        /// Return True if the entered data is valid.
        /// </returns>
        /// <param name="name">String containing Name.</param>
        /// <param name="surname">String containing surname.</param>
        /// <param name="gender">Char containing gender info.</param>
        /// <param name="mobilePhone">String containing phone number.</param>
        /// <param name="email">String containing email address.</param>
        /// <param name="address">String containing address.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool IsDataValid(string name, string surname, char gender, string mobilePhone, string email, string address, out string errorMsg)
        {
            bool result = true;
            errorMsg = string.Empty;

            if (Regex.Match(name, NamePattern).Success == false)
            {
                result = false;
                errorMsg += "Name, ";
            }

            if (Regex.Match(surname, NamePattern).Success == false)
            {
                result = false;
                errorMsg += "Surname, ";
            }

            if (char.ToLower(gender) != 'm' && char.ToLower(gender) != 'f')
            {
                result = false;
                errorMsg += "Gender, ";
            }

            if (Regex.Match(mobilePhone, PhonePattern).Success == false)
            {
                result = false;
                errorMsg += "Mobile Phone, ";
            }

            if (Regex.Match(email, EmailPattern).Success == false)
            {
                result = false;
                errorMsg += "E-mail, ";
            }

            if (Regex.Match(address, AddressPattern).Success == false)
            {
                result = false;
                errorMsg += "Address, ";
            }

            if (!result)
            {
                errorMsg = errorMsg.Substring(0, errorMsg.Length - 2);
            }

            return result;
        }

        /// <summary>
        /// Add new teacher.
        /// </summary>
        /// <returns>
        /// Return True if the adding new teacher is successful.
        /// </returns>
        /// <param name="name">String Name.</param>
        /// <param name="surname">String Surname.</param>
        /// <param name="gender">Char Gender.</param>
        /// <param name="dateOfBirth">DateTime birth date.</param>
        /// <param name="mobilePhone">String mobilePhone.</param>
        /// <param name="email">String email.</param>
        /// <param name="courseId">Integer containing the course Id.</param>
        /// <param name="address">String address.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool AddNewTeacher(string name, string surname, char gender, DateTime dateOfBirth, string mobilePhone, string email, int courseId, string address, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewTeacher", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TeacherName", SqlDbType.VarChar, 100)).Value = name;
                command.Parameters.Add(new SqlParameter("@TeacherSurname", SqlDbType.VarChar, 100)).Value = surname;
                command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Char, 1)).Value = gender;
                command.Parameters.Add(new SqlParameter("@DateOfBirth", SqlDbType.Date)).Value = dateOfBirth;
                command.Parameters.Add(new SqlParameter("@MobilePhone", SqlDbType.VarChar, 50)).Value = mobilePhone;
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50)).Value = email;
                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 300)).Value = address;
                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "New Teacher was added successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not add new Teacher!";
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
        /// Select all teachers.
        /// </summary>
        /// <returns>
        /// Return table with all teachers.
        /// </returns>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetTeachersData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllTeachers", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        this.db.OpenConnection();

                        adapter.Fill(table);
                        errorMsg = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                    }
                    finally
                    {
                        this.db.CloseConnection();
                    }
                }
            }

            return table;
        }

        /// <summary>
        /// Select current teacher by teacher id.
        /// </summary>
        /// <returns>
        /// Return table with the data for the selected teacher.
        /// </returns>
        /// <param name="teacherId">Integer containing teacher Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetTeacherById(int teacherId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectTeacherById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TeacherId", SqlDbType.Int)).Value = teacherId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        this.db.OpenConnection();

                        adapter.Fill(table);
                        errorMsg = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                    }
                    finally
                    {
                        this.db.CloseConnection();
                    }
                }
            }

            return table;
        }

        /// <summary>
        /// Delete teacher by Id.
        /// </summary>
        /// <returns>
        /// Return True if the process is successful.
        /// </returns>
        /// <param name="teacherId">Integer containing teacher Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool DeleteTeacher(int teacherId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteTeacherById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TeacherId", SqlDbType.Int)).Value = teacherId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The Teacher was removed successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not remove the teacher!";
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
