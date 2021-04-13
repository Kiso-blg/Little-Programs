namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    class Course
    {
        private readonly CollegeDB db = new CollegeDB();

        // Insert new course.
        internal bool AddNewCourse(string courseName, decimal courseFee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("InsertNewCourse", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseName", SqlDbType.VarChar, 100)).Value = courseName;
                command.Parameters.Add(new SqlParameter("@CourseFee", SqlDbType.Money)).Value = courseFee;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

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
            }
        }        

        // Get the data for the current course by CourseId.
        internal DataTable GetCourseData(int courseId, out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("GetCourseData", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
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

        // Update course data by CourseId.
        internal bool UpdateCourse(int courseId, string courseName, decimal fee, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("UpdateCourseData", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@CourseName", SqlDbType.VarChar, 100)).Value = courseName;
                command.Parameters.Add(new SqlParameter("@CourseFee", SqlDbType.Money)).Value = fee;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

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
                    db.CloseConnection();
                }
            }
        }

        // Delete ourse by CourseId.
        internal bool DeleteCourse(int courseId, out string errorMsg)
        {
            using (SqlCommand command = new SqlCommand("DeleteCourseById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)).Value = courseId;
                command.Parameters.Add(new SqlParameter("@CollegeId", SqlDbType.Int)).Value = Globals.GlobalCollegeId;

                try
                {
                    db.OpenConnection();

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
                    db.CloseConnection();
                }
            }
        }

        // Select all courses.
        internal DataTable GetAllCourses(out string errorMsg)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllCourses", db.GetConnection))
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
    }
}