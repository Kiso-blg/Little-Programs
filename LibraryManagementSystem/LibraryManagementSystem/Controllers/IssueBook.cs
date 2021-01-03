using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class IssueBook
    {
        private static readonly DBase db = new DBase();

        // Recod an issued book.
        internal bool GiveABook(string enrollmentNo, int bookId, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("GiveBook", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = bookId;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "Book Issued.";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not issue the book!";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.GetType() + Environment.NewLine + ex.Message;
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }        

        // Check if the book is already taken by the student.
        internal bool IsBookAlreadyIssued(string enrollmentNo, int bookId, out string errorMessage)
        {            
            using (SqlCommand command = new SqlCommand("IsBookAlreadyTaken", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = bookId;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;
                SqlParameter returnParameter = new SqlParameter("@RowsCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(returnParameter);

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    int rowsCount = (int)command.Parameters["@RowsCount"].Value;

                    if (rowsCount == 0)
                    {
                        errorMessage = string.Empty;
                        return false;
                    }
                    else
                    {
                        errorMessage = "The Book is already taken by the student!";
                        return true;
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

        // Check if the student can take more books.
        internal bool CanStudentTakeMoreBooks(string enrollmentNo, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("CanStudentTakeMoreBooks", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = enrollmentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;
                SqlParameter returnParameter = new SqlParameter("@BooksCount", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(returnParameter);

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    int rowsCount = (int)command.Parameters["@BooksCount"].Value;

                    if (rowsCount < 3)
                    {
                        errorMessage = string.Empty;
                        return false;
                    }
                    else
                    {
                        errorMessage = "The Student can not take more Books!";
                        return true;
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

        // Check if the book is issued before being deleted. If the book is issued, can not be deleted.
        internal bool IsBookIssued(int currentBookId, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("IsBookIssued", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = currentBookId;
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
                            errorMessage = "The book is issued. All books must be returned before being Deleted!";
                            return true;
                        }
                        else
                        {
                            errorMessage = string.Empty;
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

        // Check if the student has issued before being deleted. If the student has issued, can not be deleted.
        internal bool HasStudentIssuedBooks(string currentStudentNo, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("HasStudentIssuedBooks", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = currentStudentNo;
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
                            errorMessage = "The student has issued books. All books must be returned before being Deleted!";
                            return true;
                        }
                        else
                        {
                            errorMessage = string.Empty;
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

        // Return table with Students and Issed Books information.
        internal DataTable GetStudentAndNotReturnedBooks(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentAndNotReturnedBooks", db.GetConnection))
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

        // Return table with Students and Issed Books information for the current student.
        internal DataTable GetNotReturnedBooksByStudentNo(string enrollmentNo, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectNotReturnetBooksByStudentNumber", db.GetConnection))
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
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }

            errorMessage = string.Empty;
            return table;
        }                

        // Function return Book.
        internal bool ReturnBook(int bookId, string studentNumber, DateTime returnDate, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("ReturnBook", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = bookId;
                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = studentNumber;
                command.Parameters.Add(new SqlParameter("@ReturnBookDate", SqlDbType.Date)).Value = returnDate;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "The book has been returned successfully.";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not update the IssueReturnBook_Table!";
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

        // Return table with data for books and students for all books which are Not returned.
        internal DataTable GetAllNotReturnedBooks(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllNotReturnedBooks", db.GetConnection))
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

        // Return table with data for books and students for all books which are returned.
        internal DataTable GetAllReturnedBooks(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllReturnedBooks", db.GetConnection))
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

        // Return table with all issued and Not returned books for a current student.
        internal DataTable GetStudentIssuedBooks(string enrollmentNo, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentNotReturnedBooks", db.GetConnection))
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

        // Return table with all issued and Returned books for a current student.
        internal DataTable GetStudentReturnedBooks(string enrollmentNo, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectStudentReturnedBooks", db.GetConnection))
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

        // Delete all records of a book from IssueReturnBook_Table when deleteng the current book from the administration
        internal bool DeleteRecordsFromIssueReturnBookTable(int currentBookId, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("DeleteRecordInIssueReturnBookTableByBookId", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = currentBookId;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    errorMessage = string.Empty;
                    return true;
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

        // Delete all records of a student from IssueReturnBook_Table when deleteng the current student from the administration
        internal bool DeleteStudentRecordsFromIssueReturnBook(string currentStudentNo, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("DeleteRecordInIssueReturnBookTableByStudentNumber", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@StudentNumber", SqlDbType.VarChar, 250)).Value = currentStudentNo;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    command.ExecuteNonQuery();
                    errorMessage = string.Empty;
                    return true;
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