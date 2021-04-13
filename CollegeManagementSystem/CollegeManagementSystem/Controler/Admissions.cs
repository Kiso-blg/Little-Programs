namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    internal class Admissions
    {
        private const string NamePattern = "^[a-zA-Z]{2,100}$";
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-zA-Z\-]{2,}(\.[a-z]{2,})$";
        private const string SchoolPattern = "^[a-zA-Z0-9.'\", ]{5,250}$";        

        private const string AddressPattern = "^[a-zA-Z0-9.'\", ]{5,300}$";        

        private const string IdPatterm = "^[0-9]{1,20}$";

        private readonly CollegeDB db = new CollegeDB();        

        // Check if the entered registration number is valid.
        internal bool IsDataValid(string admissionNumber)
        {
            bool result = true;

            if (Regex.Match(admissionNumber, IdPatterm).Success == false)
            {
                result = false;
            }

            return result;
        }
        
        // Check if the entered data is valid.
        internal bool IsDataValid(string name, string surname, char gender, string mobilePhone, string email, string schoolName, string address, out string errorMsg)
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

            if (Regex.Match(schoolName, SchoolPattern).Success == false)
            {
                result = false;
                errorMsg += "School Name, ";
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

        // Return the Id of the last record.
        internal int GetLastRecordId(int collegeId, out string errorMsg)
        {
            int id = 0;

            using (SqlCommand command = new SqlCommand("GetLastId", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = collegeId;
                SqlParameter parameter = new SqlParameter("@Id", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(parameter);

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    id = int.Parse(command.Parameters["@Id"].Value.ToString());
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

                return id;
            }
        }        

        // Return table with AdmissionId and InlistDate.
        internal DataTable GetDates(int coursesId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetInlistDates", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = coursesId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = Globals.MaxSemesterId;

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

        // Return table with list of the semesters.
        internal DataTable GetSemesters(int coursesId, int year, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectSemesters", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = coursesId;
                command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = year;
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

        // Add new admission.
        internal bool AddNewAdmission(string name, string surname, char gender, DateTime birthDate, string mobilePhone, string email, int semesterId, int courseId, string schoolName, DateTime inlistDate, string address, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewAdmission", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 100)).Value = name;
                command.Parameters.Add(new SqlParameter("@Surname", SqlDbType.VarChar, 100)).Value = surname;
                command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Char, 1)).Value = gender;
                command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)).Value = birthDate;
                command.Parameters.Add(new SqlParameter("@MobilePhone", SqlDbType.VarChar, 50)).Value = mobilePhone;
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50)).Value = email;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;
                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@SchoolName", SqlDbType.VarChar, 250)).Value = schoolName;
                command.Parameters.Add(new SqlParameter("@InlistDate", SqlDbType.Date)).Value = inlistDate;
                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 300)).Value = address;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "New Admission was added successfuly.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not add the admission!";
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

        // Update the semesters for the selected year.
        internal bool UpdateSemesters(int studentId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("UpdateSemester", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = studentId;
                command.Parameters.Add(new SqlParameter("@MaxSemesterId", SqlDbType.Int)).Value = Globals.MaxSemesterId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    errorMsg = "The semesters were updated successfully";
                    return true;
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

        // Select Name, Start Date, Semester and Fee for all admissions.
        internal DataTable GetAdmissionsData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetAdmissionData", db.GetConnection))
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

        // Check if the tax for the semester for the current student is already paid.
        internal bool IsTheTaxAlreadyPaid(int admissionNumber, int semesterId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("IsTheSemesterPaid", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionNumber;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        db.OpenConnection();

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            errorMsg = string.Empty;
                            return true;
                        }
                        else
                        {
                            errorMsg = "The student has already paid for this semester!";
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

        // Mark Fee as Paid.
        internal bool InsertFeeTax(int admissionNumber, int semesterId, decimal fee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("InsertFeeData", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FeeAmount", SqlDbType.Money)).Value = fee;
                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionNumber;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The semester fee was updated successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "The semester fee was not updated!!";
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

        // Return table with students with paid fees by course, inlist date and semester.
        internal DataTable GetStudentsWithFees(int courseId, int year, int semesterId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudents", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = year;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;
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

        // Select all students.
        internal DataTable GetStudentsData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentData", db.GetConnection))
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

        // Select current student by student id.
        internal DataTable GetStudentById(int id, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = id;
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

        // Return detailed student data by id.
        internal DataTable GetStudentDetails(int admissionId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentDataById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionId;
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

        // Delete student by student id.
        internal bool DeleteStudent(int admissionId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteStudentById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The student has been removed successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not remove the student!";
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