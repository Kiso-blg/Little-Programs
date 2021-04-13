namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    internal class Teachers
    {
        private const string NamePattern = "^[a-zA-Z]{2,100}$";
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-zA-Z\-]{2,}(\.[a-z]{2,})$";
        private const string AddressPattern = "^[a-zA-Z0-9.'\", ]{5,300}$";

        private readonly CollegeDB db = new CollegeDB();

        // Check if the entered data is valid.
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
                errorMsg += "Address";
            }

            if (!result)
            {
                errorMsg = errorMsg.Substring(0, errorMsg.Length - 2);
            }

            return result;
        }        

        // Add new teacher.
        internal bool AddNewTeacher(string name, string surname, char gender, DateTime dateOfBirth, string mobilePhone, string email, int courseId, string address, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewTeacher", db.GetConnection))
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
                    db.OpenConnection();

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
                    db.CloseConnection();
                }
            }
        }        

        // Select all teachers.
        internal DataTable GetTeachersData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllTeachers", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);
                        errorMsg = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            return table;
        }

        // Select current teacher by teacher id.
        internal DataTable GetTeacherById(int teacherId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectTeacherById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TeacherId", SqlDbType.Int)).Value = teacherId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);
                        errorMsg = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            return table;
        }

        // Delete teacher by Id.
        internal bool DeleteTeacher(int teacherId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteTeacherById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@TeacherId", SqlDbType.Int)).Value = teacherId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

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
                    db.CloseConnection();
                }
            }
        }
    }
}