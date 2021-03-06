﻿using Microsoft.SqlServer.Management.Smo.Wmi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyDictionary
{
    public partial class MyDictionaryForm : Form
    {
        private string _connectionString;
        private string _connectionStringMaster;
        private string _serverName;
        private readonly string _backupPath = AppDomain.CurrentDomain.BaseDirectory + "BackupMyDictionaryDB.bak";

        private const string CONNECTIONSTRING_TEMPLATE = "Data Source=<servername>;Initial Catalog=<databasename>;Integrated Security=SSPI";
        private const string DATABASE_NAME = "MyDictionaryDB";
        private const string DATABASE_NAME_MASTER = "master";

        private bool _doesBackupFileExists;
        private bool _isConnectionSuccessful;
        private bool _doesDatabaseExists;

        private string word;
        private string wordTranslation;
        private bool isWritten;
        private int isWrittenCount;

        public MyDictionaryForm()
        {
            InitializeComponent();
            this.word = string.Empty;
            this.wordTranslation = string.Empty;
        }

        private void MyDictionaryForm_Load(object sender, EventArgs e)
        {
            CheckIfBackupFileExists();
            GetServerName();
            CreateConnectionStrings();
            TestConnection();
            CheckIfDatabaseExists();

            if (!this._doesDatabaseExists)
            {
                RestoreDatabaseFromFile();
            }

            RefreshListBox();
            this.lblIsWritten.BackColor = this.BackColor;
        }

        private void TestConnection()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this._connectionStringMaster))
            {
                try
                {
                    sqlConnection.Open();
                    this._isConnectionSuccessful = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not connect to SQL Server! The program will close!");
                    this._isConnectionSuccessful = false;
                    this.Close();
                }
            }
        }

        private void RestoreDatabaseFromFile()
        {
            if (this._doesBackupFileExists)
            {
                string restoreQuery = $@"RESTORE DATABASE [{DATABASE_NAME}]   
                                         FROM DISK = '{this._backupPath}'   
                                            WITH FILE = 1;";

                using (SqlConnection sqlConnection = new SqlConnection(this._connectionStringMaster))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(restoreQuery, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;

                        try
                        {
                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Could not restore database"
                                + Environment.NewLine
                                + ex.Message
                                + ex.InnerException
                                + "The program will close.");
                            this.Close();
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Backup file do not exist!" +
                                Environment.NewLine +
                                "The program will close.");
                this.Close();
            }
        }

        private void CheckIfDatabaseExists()
        {
            string sqlQuery = $"SELECT db_id('{DATABASE_NAME}')";

            using (SqlConnection sqlConnection = new SqlConnection(this._connectionStringMaster))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    try
                    {
                        sqlConnection.Open();
                        this._doesDatabaseExists = sqlCommand.ExecuteScalar() != DBNull.Value;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not check if database exists!!");
                        this._doesDatabaseExists = false;
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void CreateConnectionStrings()
        {
            string temporaryString = CONNECTIONSTRING_TEMPLATE;

            if (!string.IsNullOrEmpty(this._serverName))
            {
                temporaryString = temporaryString.Replace("<servername>", this._serverName);
            }
            else
            {
                MessageBox.Show("Could not find SQL Server!!" +
                                Environment.NewLine +
                                "The program will close.");
                this._doesDatabaseExists = false;
                this.Close();
            }

            this._connectionString = temporaryString.Replace("<databasename>", DATABASE_NAME);
            this._connectionStringMaster = temporaryString.Replace("<databasename>", DATABASE_NAME_MASTER);
        }

        private void GetServerName()
        {
            try
            {
                ManagedComputer mc = new ManagedComputer();
                mc.ConnectionSettings.ProviderArchitecture = ProviderArchitecture.Use64bit;
                this._serverName = mc.Name + "\\" + mc.ServerInstances[0].Name;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not retrieve Serve Name. The Program will Close!!");
                this.Close();
            }
        }

        private void RefreshIsWrittenLabel()
        {
            int idx = this.listBoxDictionary.SelectedIndex;

            if (idx > -1)
            {
                if (this.isWritten)
                {
                    this.lblIsWritten.BackColor = Color.LightGreen;
                }
                else
                {
                    this.lblIsWritten.BackColor = Color.Red;
                }
            }
        }

        private void RefreshNoWrittenWordsWarning()
        {
            if (this.isWrittenCount > 0)
            {
                this.lblNonWrittenWordsWarnin.Text = $"You have {this.isWrittenCount} word(s) to write!";
            }
            else
            {
                this.lblNonWrittenWordsWarnin.Text = string.Empty;
            }
        }

        private void RefreshListBox()
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("MyDictionaryDB.uspSelectWord", connection))
                {
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        DataTable table = new DataTable();
                        sqlDataAdapter.Fill(table);
                        this.isWrittenCount = 0;
                        List<string> listWords = new List<string>();

                        foreach (DataRow row in table.Rows)
                        {
                            listWords.Add((string)row[0]);

                            if (!(bool)row[1])
                            {
                                this.isWrittenCount++;
                            }
                        }

                        this.listBoxDictionary.DataSource = listWords;
                        table.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not select word column" +
                            Environment.NewLine + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            RefreshNoWrittenWordsWarning();
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearchBar.Text == string.Empty)
            {
                RefreshListBox();
            }
            else
            {
                List<string> list = new List<string>();

                using (SqlConnection connection = new SqlConnection(this._connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspSelectWord", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        try
                        {
                            connection.Open();

                            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                            while (sqlReader.Read())
                            {
                                string currentItem = sqlReader["Word"].ToString().ToLower();

                                if (currentItem.Contains(this.txtSearchBar.Text.ToLower()))
                                {
                                    list.Add(currentItem);
                                }
                            }

                            sqlReader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

                this.listBoxDictionary.DataSource = list;
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm(this))
            {
                addItemForm.ShowDialog();

                if (addItemForm.CanProceed)
                {
                    string item = addItemForm.Item.Replace("_", " ");
                    string itemTranslation = addItemForm.Translation.Replace("_", " ");

                    using (SqlConnection connection = new SqlConnection(this._connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspAddItem", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@word", item);
                            sqlCommand.Parameters.AddWithValue("@WordTranslation", itemTranslation);

                            try
                            {
                                connection.Open();

                                sqlCommand.ExecuteNonQuery();

                                new ToolTip().Show($"Item {addItemForm.Item} has been added successfuly.",
                                    this.btnAddItem,
                                    this.btnAddItem.Location.X,
                                    this.btnAddItem.Location.Y,
                                    5000);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Could not add item and translation" +
                                                Environment.NewLine +
                                                ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }

                RefreshListBox();
                RefreshNoWrittenWordsWarning();
            }
        }

        private void LblIsWritten_MouseEnter(object sender, EventArgs e)
        {
            if (this.isWrittenCount > 0)
            {
                Label lbl = (Label)sender;
                int visibleTime = 1000;

                ToolTip tt = new ToolTip
                {
                    AutoPopDelay = 5000,
                    InitialDelay = 500,
                    ReshowDelay = 200,
                    AutomaticDelay = 200,
                    ShowAlways = true
                };

                if (this.isWritten)
                {
                    tt.Show("The item has been written on five rows.", lbl, visibleTime);
                }
                else
                {
                    tt.Show("The item has not been written on five rows!", lbl, visibleTime);
                }
            }
        }

        private void ListBoxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = this.listBoxDictionary.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspSelectCurrentItem", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@Word", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@Word"].Value = currentItem;

                    try
                    {
                        connection.Open();

                        SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            this.word = sqlReader["Word"].ToString();
                            this.wordTranslation = sqlReader["WordTranslation"].ToString();
                            this.isWritten = (bool)sqlReader["IsWritten"];
                        }

                        this.lblTranslation.Text = this.wordTranslation;
                        sqlReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            RefreshIsWrittenLabel();
        }

        private void ListBoxDictionary_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.isWritten == true)
                {
                    this.markAsWrittenToolStripMenuItem.Enabled = false;
                }

                contextMenuStrip.Show();
            }
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            int selectedIndex = this.listBoxDictionary.IndexFromPoint(
                this.listBoxDictionary.PointToClient(Cursor.Position));

            if (selectedIndex < 0)
            {
                e.Cancel = true;
            }
            else
            {
                if (this.isWritten == true)
                {
                    this.markAsWrittenToolStripMenuItem.Enabled = false;
                }
                else
                {
                    this.markAsWrittenToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void MarkAsWrittenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string sqlUpdateQuery = $@"UPDATE [MyDictionaryTable]
            //                           SET [IsWritten] = 1
            //                           WHERE Word = '{this.word}'";

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlCommand sqlComand = new SqlCommand("MyDictionaryDB.uspUpdateItem", connection))
                {
                    sqlComand.CommandType = CommandType.StoredProcedure;

                    sqlComand.Parameters.Add(new SqlParameter("@Word", SqlDbType.NVarChar, 40));
                    sqlComand.Parameters["@Word"].Value = this.word;

                    try
                    {
                        connection.Open();

                        sqlComand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            this.isWritten = true;
            this.isWrittenCount--;
            RefreshNoWrittenWordsWarning();
            RefreshIsWrittenLabel();
        }

        private void EditItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm(this))
            {
                addItemForm.Item = this.word;
                addItemForm.Translation = this.wordTranslation;
                addItemForm.ShowDialog();

                if (addItemForm.CanProceed)
                {
                    addItemForm.Item = addItemForm.Item.Replace("_", " ");
                    addItemForm.Translation = addItemForm.Translation.Replace("_", " ");

                    using (SqlConnection connection = new SqlConnection(this._connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspEditItem", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.Add(new SqlParameter("@Word", SqlDbType.NVarChar, 40));
                            sqlCommand.Parameters["@Word"].Value = addItemForm.Item;

                            sqlCommand.Parameters.Add(new SqlParameter("@WordTranslation", SqlDbType.NVarChar));
                            sqlCommand.Parameters["@WordTranslation"].Value = addItemForm.Translation;

                            sqlCommand.Parameters.Add(new SqlParameter("@CurrentWord", SqlDbType.NVarChar, 40));
                            sqlCommand.Parameters["@CurrentWord"].Value = this.word;

                            try
                            {
                                connection.Open();

                                sqlCommand.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                    this.isWritten = false;
                    RefreshListBox();
                    RefreshNoWrittenWordsWarning();
                    RefreshIsWrittenLabel();
                }
            }
        }

        private void DeleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspDeleteItem", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Word", this.word);

                    try
                    {
                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            RefreshListBox();
            RefreshNoWrittenWordsWarning();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyDictionaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._doesDatabaseExists && this._isConnectionSuccessful)
            {
                File.Delete(this._backupPath);

                //string backupQuery = $@"BACKUP DATABASE [{DATABASE_NAME}]
                //                        TO DISK = '{this._backupPath}'
                //                            WITH FORMAT,
                //                                MEDIANAME = 'SQLServerBackups',
                //                                NAME = 'Full Backup of {DATABASE_NAME}';";

                using (SqlConnection sqlConnection = new SqlConnection(this._connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("MyDictionaryDB.uspBackupDatabase", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@DatabaseName", SqlDbType.VarChar, 20));
                        sqlCommand.Parameters["@DatabaseName"].Value = DATABASE_NAME;

                        sqlCommand.Parameters.Add("@BackupPath", SqlDbType.VarChar);
                        sqlCommand.Parameters["@BackupPath"].Value = this._backupPath;

                        try
                        {
                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Could not backup database!"
                                            + Environment.NewLine
                                            + ex.Message);
                        }
                        finally
                        {                            
                            sqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not backup database!!");
            }
        }

        private void CheckIfBackupFileExists()
        {
            if (File.Exists(this._backupPath))
            {
                this._doesBackupFileExists = true;
            }
            else
            {
                this._doesBackupFileExists = false;
            }
        }        
    }
}