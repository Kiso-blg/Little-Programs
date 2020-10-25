using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    class GROUP
    {
        public readonly ManageContacts_DB db = new ManageContacts_DB();

        // Function to add a group to the logged in user
        public bool InsertGroup(string groupName, int userId)
        {
            using (SqlCommand command = new SqlCommand("InsertNewGroup", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 100));
                command.Parameters["@GroupName"].Value = groupName;
                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

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

        // Check if the group name already exists while add new group name
        public bool DoesGroupExists(string groupName, int userId)
        {
            using (SqlCommand command = new SqlCommand("SelectGroupNameAndId", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 100));
                command.Parameters["@GroupName"].Value = groupName;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);

                        // If the group name exists return True
                        if (table.Rows.Count > 0)
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

        // Check if the group name already exists while eidt group name
        internal bool DoesGroupExists(string newGroupName, int userId, int groupId)
        {
            using (SqlCommand command = new SqlCommand("SelectAllFromGroupsTable", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 100));
                command.Parameters["@GroupName"].Value = newGroupName;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int));
                command.Parameters["@GroupId"].Value = groupId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        db.OpenConnection();

                        adapter.Fill(table);

                        // If the group name exists return True
                        if (table.Rows.Count > 0)
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

        // Create a function to get all user groups
        public DataTable GetGroups(int userId)
        {
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("SelectNamesOfTheGroups", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = userId;

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

        // Create a function to edit a group name
        public bool UpdateGroup(int groupId, string newGroupName)
        {
            using (SqlCommand command = new SqlCommand("UpdateGroupName", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.VarChar, 100));
                command.Parameters["@GroupName"].Value = newGroupName;
                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int));
                command.Parameters["@GroupId"].Value = groupId;

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
        
        // Create a Function to Remove group
        public bool DeleteGroup(int groupId)
        {
            using (SqlCommand command = new SqlCommand("[DeleteGroupById]", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int));
                command.Parameters["@GroupId"].Value = groupId;

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