// <copyright file="Course.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// The main Course class.
    /// Perform all functions for courses.
    /// </summary>
    internal class Course
    {
        /// <summary>
        /// Contains SQL Connection.
        /// </summary>
        private readonly CollegeDB db = new CollegeDB();

        /// <summary>
        /// Insert new course.
        /// </summary>
        /// <returns>
        /// Return True if the adding new course is successful.
        /// </returns>
        /// <param name="courseName">String containing course name.</param>
        /// <param name="courseFee">Decimal containing the fee amount.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool AddNewCourse(string courseName, decimal courseFee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("InsertNewCourse", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseName", SqlDbType.VarChar, 100)).Value = courseName;
                command.Parameters.Add(new SqlParameter("@CourseFee", SqlDbType.Money)).Value = courseFee;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The course was added successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not insert course data!";
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
        /// Get the data for the current course by CourseId.
        /// </summary>
        /// <returns>
        /// Return table with the information for the selected course.
        /// </returns>
        /// <param name="courseId">Integer containing course Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetCourseData(int courseId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetCourseData", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
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
        /// Update course data by CourseId.
        /// </summary>
        /// <returns>
        /// Return table with the information for the selected course.
        /// </returns>
        /// <param name="courseId">Integer containing course Id.</param>
        /// <param name="courseName">String containing course name.</param>
        /// <param name="fee">Decimal containing the fee amount.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool UpdateCourse(int courseId, string courseName, decimal fee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("UpdateCourseData", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@CourseName", SqlDbType.VarChar, 100)).Value = courseName;
                command.Parameters.Add(new SqlParameter("@CourseFee", SqlDbType.Money)).Value = fee;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The course data was updated successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = "Could not update the course data!";
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
        /// Delete course by CourseId.
        /// </summary>
        /// <returns>
        /// Return True if the process is successful.
        /// </returns>
        /// <param name="courseId">Integer containing course Id.</param>
        /// <param name="errorMsg">String containing message with error.</param>
        internal bool DeleteCourse(int courseId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteCourseById", this.db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    this.db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMsg = "The course deleted successfully.";
                        return true;
                    }
                    else
                    {
                        errorMsg = string.Empty;
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
        /// Select all courses.
        /// </summary>
        /// <returns>
        /// Return table with all courses.
        /// </returns>
        /// <param name="errorMsg">String containing message with error.</param>
        internal DataTable GetAllCourses(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllCourses", this.db.GetConnection))
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
    }
}
