using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;

namespace LibraryManagementSystem
{
    class Student
    {
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-z]{2,}(\.[a-z]{2,})$";
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";

        private readonly DBase db = new DBase();

        // Check if the entered data is valid.
        internal bool IsDataValid(string studentName, string enrollmentNo, string department, string studentSemester, string mobilePhone, string email, out string errorMessage)
        {
            bool result = true;
            errorMessage = string.Empty;

            if (studentName == string.Empty)
            {
                result = false;
                errorMessage += "Name, ";
            }

            if (enrollmentNo == string.Empty)
            {
                result = false;
                errorMessage += "Enrollment No, ";
            }

            if (department == string.Empty)
            {
                result = false;
                errorMessage += "Department, ";
            }

            if (studentSemester == string.Empty)
            {
                result = false;
                errorMessage += "Semester, ";
            }

            if (Regex.Match(mobilePhone, PhonePattern).Success == false)
            {
                result = false;
                errorMessage += "Contact, ";
            }

            if (email != string.Empty)
            {
                if (Regex.Match(email, EmailPattern).Success == false)
                {
                    result = false;
                    errorMessage += "Email";
                }
            }

            if (result == false)
            {
                errorMessage = errorMessage.Substring(0, errorMessage.Length - 2);
            }

            return result;
        }

        // Check if the Student already exists.
        internal bool DoesStudentExists(string enrollmentNo, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("SelectStudent", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            errorMessage = string.Empty;
                            return true;
                        }
                        else
                        {
                            errorMessage = "The student already exists!";
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

        // Add new Student.
        internal bool InsertNewStudent(string studentName, string enrollmentNo, string department, string studentSemester, string mobilePhone, string email, out string message)
        {
            using (SqlCommand command = new SqlCommand("InsertNewStudent", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentName", SqlDbType.VarChar, 250)).Value = studentName;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@StudentDepartment", SqlDbType.VarChar, 250)).Value = department;
                command.Parameters.Add(new SqlParameter("@StudentSemester", SqlDbType.VarChar, 250)).Value = studentSemester;
                command.Parameters.Add(new SqlParameter("@StudentContact", SqlDbType.VarChar, 20)).Value = mobilePhone;
                command.Parameters.Add(new SqlParameter("@StudentEmail", SqlDbType.VarChar, 250)).Value = email;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        message = "New Student was added Successfully";
                        return true;
                    }
                    else
                    {
                        message = "Could not add New Student!";
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

        // Return Student by Student Number.
        internal DataTable GetStudentById(string enrollmentNo)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

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

        // Return a list with all Students.
        internal DataTable GetAllStudents(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllStudents", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);
                        errorMessage = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            return table;
        }

        // Search Student.
        internal DataTable GetTableByCurrentText(string currentSearchText)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentsByStudentNo", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = currentSearchText;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

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

        // Return the current Student data.
        internal DataTable GetCurrentStudent(string enrollmentNo, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectCurrentStudent", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);
                        errorMessage = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            return table;
        }

        // Update Student data.
        internal bool UpdateStudent(string studentName, string enrollmentNo, string department, string studentSemester, string mobilePhone, string email, out string message)
        {
            using (SqlCommand command = new SqlCommand("UpdateStudentData", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentName", SqlDbType.VarChar, 250)).Value = studentName;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@StudentDepartment", SqlDbType.VarChar, 250)).Value = department;
                command.Parameters.Add(new SqlParameter("@StudentSemester", SqlDbType.VarChar, 250)).Value = studentSemester;
                command.Parameters.Add(new SqlParameter("@StudentContact", SqlDbType.VarChar, 20)).Value = mobilePhone;
                command.Parameters.Add(new SqlParameter("@StudentEmail", SqlDbType.VarChar, 250)).Value = email;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        message = "Student was updated Successfully";
                        return true;
                    }
                    else
                    {
                        message = "Could not update the Student!";
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

        // Delete current student.
        internal bool DeleteStudent(string currentStudentNo, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("DeleteStudent", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = currentStudentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "Student was deleted successfully!";
                        return true;
                    }
                    else
                    {
                        errorMessage = "The student was not deleted!";
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