// <copyright file="Admissions.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The main Admissions class.
    /// Perform all functions for admissions and students.
    /// </summary>
    internal class Admissions
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
        /// Contains Regex Pattern for School Name.
        /// </summary>
        private const string SchoolPattern = "^[a-zA-Z0-9.'\", ]{5,250}$";

        /// <summary>
        /// Contains Regex Pattern for Address.
        /// </summary>
        private const string AddressPattern = "^[a-zA-Z0-9.'\", ]{5,300}$";

        /// <summary>
        /// Contains Regex Pattern for ID.
        /// </summary>
        private const string IdPatterm = "^[0-9]{1,20}$";

        /// <summary>
        /// Contains SQL Connection.
        /// </summary>
        private readonly CollegeDB db = new CollegeDB();

        /// <summary>
        /// Check if the entered registration number is valid.
        /// </summary>
        /// <returns>
        /// Return True if the registration number is valid
        /// </returns>
        /// <param name="admissionNumber">String containing admission number.</param>
        internal bool IsDataValid(string admissionNumber)
        {
            bool result = true;

            if (Regex.Match(admissionNumber, IdPatterm).Success == false)
            {
                result = false;
            }

            return result;
        }

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
        /// <param name="schoolName">String containing school name.</param>
        /// <param name="address">String containing address.</param>
        /// <param name="errorMsg">String containing message with error.</param>
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

        /// <summary>
        /// Takes the college id and returns the Id of the last record.
        /// </summary>
        /// <returns>
        /// Returns the Id of the last record.
        /// </returns>
        /// <param name="collegeId">Integer containing the college Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal int GetLastRecordId(int collegeId, out string errorMsg)
        {
            int id = 0;

            using (SqlCommand command = new SqlCommand("GetLastId", this.db.GetConnection))
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
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }

                return id;
            }
        }

        /// <summary>
        /// Takes the integer coursesId and returns table with AdmissionId and EnlistDate.
        /// </summary>
        /// <returns>
        /// Return table with AdmissionId and EnlistDate.
        /// </returns>
        /// <param name="coursesId">Integer containing the course Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetDates(int coursesId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetEnlistDates", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = coursesId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = Globals.MaxSemesterId;

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
        /// Takes the integers coursesId and year, and returns table with list of the semesters.
        /// </summary>
        /// <returns>
        /// Return table with list of the semesters.
        /// </returns>
        /// <param name="coursesId">Integer containing the course Id.</param>
        /// <param name="year">Integer containing year.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetSemesters(int coursesId, int year, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectSemesters", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = coursesId;
                command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Int)).Value = year;
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
        /// Add new admission.
        /// </summary>
        /// <returns>
        /// Return True if the adding new admission is successful.
        /// </returns>
        /// <param name="name">String Name.</param>
        /// <param name="surname">String Surname.</param>
        /// <param name="gender">Char Gender.</param>
        /// <param name="birthDate">DateTime BirthDate.</param>
        /// <param name="mobilePhone">String mobilePhone.</param>
        /// <param name="email">String email.</param>
        /// <param name="semesterId">Integer containing the semester Id.</param>
        /// <param name="courseId">Integer containing the course Id.</param>
        /// <param name="schoolName">String schoolName.</param>
        /// <param name="enlistDate">DateTime enlistDate.</param>
        /// <param name="address">String address.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool AddNewAdmission(string name, string surname, char gender, DateTime birthDate, string mobilePhone, string email, int semesterId, int courseId, string schoolName, DateTime enlistDate, string address, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("AddNewAdmission", this.db.GetConnection))
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
                command.Parameters.Add(new SqlParameter("@EnlistDate", SqlDbType.Date)).Value = enlistDate;
                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 300)).Value = address;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Update the semesters for the selected year.
        /// </summary>
        /// <returns>
        /// Return True if the semester was updated successfully.
        /// </returns>
        /// <param name="studentId">Integer containing the student Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool UpdateSemesters(int studentId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("UpdateSemester", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = studentId;
                command.Parameters.Add(new SqlParameter("@MaxSemesterId", SqlDbType.Int)).Value = Globals.MaxSemesterId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Select Name, Start Date, Semester and Fee for all admissions.
        /// </summary>
        /// <returns>
        /// Return Table with the selected data.
        /// </returns>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetAdmissionsData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetAdmissionData", this.db.GetConnection))
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
        /// Check if the tax for the semester for the current student is already paid.
        /// </summary>
        /// <returns>
        /// Return True if the tax is is already paid.
        /// </returns>
        /// <param name="admissionNumber">Integer containing the admission Number.</param>
        /// <param name="semesterId">Integer containing the semester Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool IsTheTaxAlreadyPaid(int admissionNumber, int semesterId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("IsTheSemesterPaid", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionNumber;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        this.db.OpenConnection();

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
                        this.db.CloseConnection();
                    }
                }
            }
        }

        /// <summary>
        /// Mark Fee as Paid.
        /// </summary>
        /// <returns>
        /// Return True if the process was successful.
        /// </returns>
        /// <param name="admissionNumber">Integer containing the admission Number.</param>
        /// <param name="semesterId">Integer containing the semester Id.</param>
        /// <param name="fee">Decimal containing the fee amount.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool InsertFeeTax(int admissionNumber, int semesterId, decimal fee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("InsertFeeData", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FeeAmount", SqlDbType.Money)).Value = fee;
                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionNumber;
                command.Parameters.Add(new SqlParameter("@SemesterId", SqlDbType.Int)).Value = semesterId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }

        /// <summary>
        /// Select students which fees are already paid.
        /// </summary>
        /// <returns>
        /// Return table with students with paid fees by course, enlist date and semester.
        /// </returns>
        /// <param name="courseId">Integer containing the course Id.</param>
        /// <param name="year">Integer containing year.</param>
        /// <param name="semesterId">Integer containing semester Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetStudentsWithFees(int courseId, int year, int semesterId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudents", this.db.GetConnection))
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
        /// Select all students.
        /// </summary>
        /// <returns>
        /// Return Table with all students.
        /// </returns>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetStudentsData(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentData", this.db.GetConnection))
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
        /// Select student by Id.
        /// </summary>
        /// <returns>
        /// Return Table with the selected student.
        /// </returns>
        /// <param name="id">Integer containing the admission id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetStudentById(int id, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = id;
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
        /// Select detailed student by Id.
        /// </summary>
        /// <returns>
        /// Return Table with the selected student.
        /// </returns>
        /// <param name="admissionId">Integer containing the admission id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetStudentDetails(int admissionId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentDataById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionId;
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
        /// Delete student by student id.
        /// </summary>
        /// <returns>
        /// Return True the process was successful.
        /// </returns>
        /// <param name="admissionId">Integer containing the admission id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool DeleteStudent(int admissionId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteStudentById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@AdmissionId", SqlDbType.Int)).Value = admissionId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

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
                    this.db.CloseConnection();
                }
            }
        }
    }
}
