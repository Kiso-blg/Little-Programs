using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    class Contact
    {
        readonly ManageContacts_DB db = new ManageContacts_DB();

        // Insert a new Contact 
        public bool InsertContact(string firstName, string lastName, int groupId, string phone, string email, string address, MemoryStream picture, int userId)
        {
            using (SqlCommand command = new SqlCommand("InserContact", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50));
                command.Parameters["@FirstName"].Value = firstName;

                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50));
                command.Parameters["@LastName"].Value = lastName;

                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int));
                command.Parameters["@GroupId"].Value = groupId;

                command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 20));
                command.Parameters["@Phone"].Value = phone;

                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30));
                command.Parameters["@Email"].Value = email;

                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.Text));
                command.Parameters["@Address"].Value = address;

                command.Parameters.Add(new SqlParameter("@Picture", SqlDbType.VarBinary));
                command.Parameters["@Picture"].Value = picture.ToArray();

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;                

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }        

        // Edit a Contact 
        public bool UpdateContact(int contactId, string firstName, string lastName, int groupId, string phone, string email, string address, MemoryStream picture)
        {
            using (SqlCommand command = new SqlCommand("UpdateContact", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50));
                command.Parameters["@FirstName"].Value = firstName;

                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50));
                command.Parameters["@LastName"].Value = lastName;

                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int));
                command.Parameters["@GroupId"].Value = groupId;

                command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 20));
                command.Parameters["@Phone"].Value = phone;

                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 30));
                command.Parameters["@Email"].Value = email;

                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.Text));
                command.Parameters["@Address"].Value = address;

                command.Parameters.Add(new SqlParameter("@Picture", SqlDbType.VarBinary));
                command.Parameters["@Picture"].Value = picture.ToArray();

                command.Parameters.Add(new SqlParameter("@ContactId", SqlDbType.Int));
                command.Parameters["@ContactId"].Value = contactId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // Function Return a list of Contacts depending on the given command
        public DataTable SelectContactLists(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            DataTable table = new DataTable();

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

            return table;
        }

        // Get Contact by Id Method
        public DataTable GetContactById(int contactId)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectContactsByContactId", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ContactId", SqlDbType.Int)).Value = contactId;

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

        // Method Delete Contact by ContactId 
        public bool DeleteContact(int contactId)
        {
            using (SqlCommand command = new SqlCommand("DeleteContactByContactId", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ContactId", SqlDbType.Int));
                command.Parameters["@ContactId"].Value = contactId;

                try
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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