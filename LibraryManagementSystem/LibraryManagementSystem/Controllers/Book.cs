using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Book
    {
        private static readonly DBase db = new DBase();

        // Check if the entered book data is valid.
        internal bool IsDataValid(string bookName, string authorName, string bookPublication, string strBookPrice, string strQuantity, out string invalidFields, out decimal bookPrice, out int bookQuantity)
        {
            bool result = true;
            invalidFields = string.Empty;

            if (bookName == string.Empty)
            {
                result = false;
                invalidFields += "Book Name, ";
            }

            if (authorName == string.Empty)
            {
                result = false;
                invalidFields += "Book Author Name, ";
            }

            if (bookPublication == string.Empty)
            {
                result = false;
                invalidFields += "Book Publication, ";
            }

            if (!decimal.TryParse(strBookPrice, out bookPrice))
            {
                result = false;
                invalidFields += "Book Price, ";
            }

            if (!int.TryParse(strQuantity, out bookQuantity))
            {
                result = false;
                invalidFields += "Book Quantity, ";
            }

            if (result == false)
            {
                invalidFields = invalidFields.Substring(0, invalidFields.Length - 2);
            }

            return result;
        }

        // Function Insert a New Book
        internal bool InsertNewBook(string bookName, string authorName, string bookPublication, DateTime purchaseDate, decimal bookPrice, int bookQuantity, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("AddNewBook", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookName", SqlDbType.VarChar, 300)).Value = bookName;
                command.Parameters.Add(new SqlParameter("@BookAuthor", SqlDbType.VarChar, 250)).Value = authorName;
                command.Parameters.Add(new SqlParameter("@BookPublication", SqlDbType.VarChar, 250)).Value = bookPublication;
                command.Parameters.Add(new SqlParameter("@BookPurchaseDate", SqlDbType.DateTime)).Value = purchaseDate;
                command.Parameters.Add(new SqlParameter("@BookPrice", SqlDbType.Money)).Value = bookPrice;
                command.Parameters.Add(new SqlParameter("@BookQuantity", SqlDbType.Int)).Value = bookQuantity;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = string.Empty;
                        return true;
                    }

                    errorMessage = "Could not add new book!";
                    return false;
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

        // Return table with all books.
        internal DataTable GetAllBooks(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectAllBooks", db.GetConnection))
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

        // Return table with all books only containing BookId and BookName.
        internal DataTable GetBooksByIdAndName(out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectBooksByNameAnd", db.GetConnection))
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

        // Return book by current Id.
        internal DataTable GetCurrentBook(int bookId, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectBooksById", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = bookId;
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

        // Return books which name contains current string.
        internal DataTable GetBooksByCurrentText(string nameToContain, out string errorMessage)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectBookByBookName", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookContainsString", SqlDbType.VarChar, 300)).Value = nameToContain;
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

        // Function Update the current Book data.
        internal bool UpdateBook(string bookName, string authorName, string bookPublication, DateTime purchaseDate, decimal bookPrice, int bookQuantity, int currentBookId, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("UpdateBook", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookName", SqlDbType.VarChar, 300)).Value = bookName;
                command.Parameters.Add(new SqlParameter("@BookAuthor", SqlDbType.VarChar, 250)).Value = authorName;
                command.Parameters.Add(new SqlParameter("@BookPublication", SqlDbType.VarChar, 250)).Value = bookPublication;
                command.Parameters.Add(new SqlParameter("@BookPurchaseDate", SqlDbType.DateTime)).Value = purchaseDate;
                command.Parameters.Add(new SqlParameter("@BookPrice", SqlDbType.Money)).Value = bookPrice;
                command.Parameters.Add(new SqlParameter("@BookQuantity", SqlDbType.Int)).Value = bookQuantity;
                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = currentBookId;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "Book was Updated Successfully!";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Could not Update Book Data!";
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

        // Delete book.
        internal bool DeleteBook(int currentBookId, out string errorMessage)
        {
            using (SqlCommand command = new SqlCommand("DeleteBook", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = currentBookId;
                command.Parameters.Add(new SqlParameter("@AdministrationId", SqlDbType.Int)).Value = Globals.GlobalAdministrationId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        errorMessage = "Book was deleted successfully!";
                        return true;
                    }
                    else
                    {
                        errorMessage = "The book was not deleted!";
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