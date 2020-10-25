using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class MainForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        private readonly ManageContacts_DB myDB = new ManageContacts_DB();
        private readonly GROUP group = new GROUP();

        // Form Load Method
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate Picture and Username
            GetImageAndUsername();

            // Populate the ComboBox with groups names
            GetGroupsInComboBoxes();
        }

        // Button Close
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Minimize
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Display the logged in user image and username
        internal void GetImageAndUsername()
        {
            using (SqlCommand command = new SqlCommand("uspSelectUsernameAndPicture", myDB.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = Globals.GlobalUserId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    try
                    {
                        myDB.OpenConnection();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            // Display the user image
                            byte[] pic = (byte[])table.Rows[0]["Picture"];
                            MemoryStream picture = new MemoryStream(pic);
                            this.pictureBoxUserPicture.Image = Image.FromStream(picture);

                            //display the user username
                            if (this.LabelUsername.Text == "(username)")
                            {
                                this.LabelUsername.Text = this.LabelUsername.Text.Replace("(username)", table.Rows[0]["Username"].ToString());
                            }
                            else
                            {
                                this.LabelUsername.Text = table.Rows[0]["Username"].ToString();
                            }                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myDB.CloseConnection();
                    }
                }
            }
        }

        // Label edit user data
        private void LabelEditUserData_Click(object sender, EventArgs e)
        {
            using (Edit_User_Data_Form editUserForm = new Edit_User_Data_Form())
            {
                editUserForm.ShowDialog(this);
            }

            GetImageAndUsername();
        }

        // Button add new group
        private void Button_Add_Group_Click(object sender, EventArgs e)
        {
            string groupName = this.textBoxAddGroupName.Text.Trim();

            if (!groupName.Equals(string.Empty))
            {
                // Check if the group name alredy exists for the logged in user
                if (!group.DoesGroupExists(groupName, Globals.GlobalUserId))
                {
                    if (group.InsertGroup(groupName, Globals.GlobalUserId))
                    {
                        MessageBox.Show("New Group Inserted.",
                            "Add Group",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        GetGroupsInComboBoxes(); // Populate the comboBox again to display the new data
                    }
                    else
                    {
                        MessageBox.Show("Group Not Inserted.",
                            "Add Group",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Group Name Already Exists.",
                            "Add Group",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter a Group Name Before Inserting.",
                            "Add Group",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

            this.textBoxAddGroupName.Text = string.Empty;
        }

        // Populate the ComboBox
        internal void GetGroupsInComboBoxes()
        {
            // Populate Edit ComboBox
            this.comboBoxEditGroupId.Text = string.Empty;
            this.comboBoxEditGroupId.DataSource = group.GetGroups(Globals.GlobalUserId);
            this.comboBoxEditGroupId.DisplayMember = "GroupName";
            this.comboBoxEditGroupId.ValueMember = "GroupId";

            // Populate Remove ComboBox
            this.comboBoxRemoveGroupId.Text = string.Empty;
            this.comboBoxRemoveGroupId.DataSource = group.GetGroups(Globals.GlobalUserId);
            this.comboBoxRemoveGroupId.DisplayMember = "GroupName";
            this.comboBoxRemoveGroupId.ValueMember = "GroupId";
        }

        // Button edit group name
        private void Button_Edit_Group_Click(object sender, EventArgs e)
        {            
            if (this.comboBoxEditGroupId.Items.Count > 0)
            {
                string newGroupName = this.textBoxEditGroupName.Text.Trim();
                int groupId = Convert.ToInt32(this.comboBoxEditGroupId.SelectedValue.ToString());

                if (!newGroupName.Equals(string.Empty))
                {
                    if (!group.DoesGroupExists(newGroupName, Globals.GlobalUserId, groupId))
                    {
                        if (group.UpdateGroup(groupId, newGroupName))
                        {
                            MessageBox.Show("Group Name Updated.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            this.textBoxEditGroupName.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Group Was Not Name Updated.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Group Name Already Exists.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    }

                    GetGroupsInComboBoxes();
                }
                else
                {
                    MessageBox.Show("Enter a Group Name Before Editing.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are no groups.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        // Button remove selected group
        private void Button_Remove_Group_Click(object sender, EventArgs e)
        {
            if (this.comboBoxRemoveGroupId.Items.Count > 0)
            {
                int groupId = Convert.ToInt32(this.comboBoxRemoveGroupId.SelectedValue.ToString());

                if (MessageBox.Show("Are You Sure You Want to Delete This Group",
                    "Remove Group",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.DeleteGroup(groupId))
                    {
                        MessageBox.Show("Group Was Deleted",
                        "Remove Group",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Group Was Not Deleted",
                        "Remove Group",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }

                GetGroupsInComboBoxes();
                this.textBoxEditGroupName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("There are no groups.",
                                    "Edit Group",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        // Refresh the user image and username
        private void LabelRefresh_Click(object sender, EventArgs e)
        {
            GetImageAndUsername();
        }

        // Button Add Contact
        private void Button_Add_Contacts_Click(object sender, EventArgs e)
        {
            // Show Add Contact Form
            using (Add_Contact_Form addContactForm = new Add_Contact_Form())
            {
                addContactForm.ShowDialog(this);
            }
        }

        // Button Edit Contact
        private void Button_Edit_Contacts_Click(object sender, EventArgs e)
        {
            // Show Edit_Contact_Form
            using (Edit_Contacts_Form editContactForm = new Edit_Contacts_Form())
            {
                editContactForm.ShowDialog(this);
            }
        }

        // Button Select Contact
        private void Button_Select_Contact_Click(object sender, EventArgs e)
        {
            // Show a From to select the Contact we watn to edit
            Select_Contact_Form selectContactForm = new Select_Contact_Form();
            int contactId;

            using (selectContactForm)
            {
                selectContactForm.ShowDialog(this);
                contactId = Convert.ToInt32(selectContactForm.DataGridViewContactsList.CurrentRow.Cells["ContactId"].Value.ToString());
            }            
             
            this.textBoxContactId.Text = contactId.ToString();            
        }

        // Button Delete the selected Contact
        private void Button_Remove_Contact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            // Check if textBoxContactId is Empty
            if (!this.textBoxContactId.Text.Trim().Equals(string.Empty))
            {
                if (int.TryParse(this.textBoxContactId.Text, out int contactId))
                {
                    if (contact.DeleteContact(contactId))
                    {
                        MessageBox.Show("Contact Was Deleted",
                            "Remove Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error! Contact Was not Deleted or Selected Indes Was Incorect!",
                            "Remove Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error! Contact Index Must Be Integer!",
                            "Remove Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No Contact Selected",
                        "Remove Contact",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            this.textBoxContactId.Text = string.Empty;
        }

        // Button Show Full List
        private void Button_Show_Full_List_Click(object sender, EventArgs e)
        {
            using (Contact_Full_List_Form contactListForm = new Contact_Full_List_Form())
            {
                contactListForm.ShowDialog(this);
            }
        }

        // Function Move Form
        private void PanelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}