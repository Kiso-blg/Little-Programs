using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Edit_Contacts_Form : Form
    {
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-z]{2,}(\.[a-z]{2,})$";
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Edit_Contacts_Form()
        {
            InitializeComponent();
        }

        // Form Load
        private void Edit_Contacts_Form_Load(object sender, EventArgs e)
        {
            this.comboBoxGroup.Enabled = false;
        }

        // Populate the ComboBox
        private void GetGroupsInComboBox()
        {
            GROUP group = new GROUP();
            DataTable table = group.GetGroups(Globals.GlobalUserId);

            this.CheckBoxEnableGroups.Enabled = true;
            this.CheckBoxEnableGroups.Checked = true;
            this.comboBoxGroup.DataSource = table;
            this.comboBoxGroup.DisplayMember = "GroupName";
            this.comboBoxGroup.ValueMember = "GroupId";
        }

        // Button Minimize
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Button Close
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Select Contact
        private void Button_Select_Contact_Click(object sender, EventArgs e)
        {
            // Show a From to select the Contact we watn to edit
            Select_Contact_Form selectContactForm = new Select_Contact_Form();
            int contactId;

            // Dispay the Data
            using (selectContactForm)
            {
                selectContactForm.ShowDialog();
                contactId = Convert.ToInt32(selectContactForm.DataGridViewContactsList.CurrentRow.Cells["ContactId"].Value.ToString());
            }

            Contact contact = new Contact();

            DataTable table = contact.GetContactById(contactId);

            this.textBoxContactID.Text = table.Rows[0]["ContactId"].ToString();
            this.textBoxFirstName.Text = table.Rows[0]["FirstName"].ToString();
            this.textBoxLastName.Text = table.Rows[0]["LastName"].ToString();
            
            // Populate the ComboBox with groups names            
            if (table.Rows[0]["GroupId"].ToString() != string.Empty)
            {
                GetGroupsInComboBox();
                this.comboBoxGroup.SelectedValue = table.Rows[0]["GroupId"];
            }
            else
            {
                this.CheckBoxEnableGroups.Checked = false;
                this.comboBoxGroup.DataSource = null;
                this.comboBoxGroup.Enabled = false;
            }

            this.textBoxPhone.Text = table.Rows[0]["Phone"].ToString();
            this.textBoxEmail.Text = table.Rows[0]["Email"].ToString();
            this.textBoxAddress.Text = table.Rows[0]["Address"].ToString();

            byte[] pic = (byte[])table.Rows[0]["Picture"];
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBoxContactImage.Image = Image.FromStream(picture);
        }

        // Button edint Contact
        private void Button_Edit_Contact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            string firstName = this.textBoxFirstName.Text.Trim();
            string lastName = this.textBoxLastName.Text.Trim();
            string phone = this.textBoxPhone.Text.Trim();
            string email = this.textBoxEmail.Text.Trim();
            string address = this.textBoxAddress.Text.Trim();
            int contactId = Convert.ToInt32(this.textBoxContactID.Text);

            // Get Group Id
            int groupId = this.CheckBoxEnableGroups.Checked == true
                ? Convert.ToInt32(this.comboBoxGroup.SelectedValue.ToString())
                : -1;

            MemoryStream picture = new MemoryStream();
            this.pictureBoxContactImage.Image.Save(picture, this.pictureBoxContactImage.Image.RawFormat);

            // Check if the required fields are empty.
            if (!firstName.Equals(string.Empty) && !phone.Equals(string.Empty))
            {
                if (IsPhoneValid(phone))
                {
                    if (IsEmailValid(email))
                    {
                        if (contact.UpdateContact(contactId, firstName, lastName, groupId, phone, email, address, picture))
                        {
                            MessageBox.Show("New Contact was Added",
                                "Edit Contact",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error! Could not Add a Contact",
                                "Edit Contact",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Email Addres is not Valid!",
                            "Edit Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Entered Phone is not Valid!",
                            "Edit Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Require First Name and Phone atleast!",
                        "Edit Contact",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        // Check if the entered Email is valid Method
        private bool IsEmailValid(string email)
        {
            if (!email.Equals(string.Empty))
            {
                return Regex.Match(email, EmailPattern).Success;
            }

            return true;
        }

        // Check if the entered Phone number is valid Method
        private bool IsPhoneValid(string phone)
        {
            return Regex.Match(phone, PhonePattern).Success;
        }

        // Button Browse picture
        private void Button_Browse_Click(object sender, EventArgs e)
        {
            // Select and diplay image in the PictureBox
            OpenFileDialog opf = new OpenFileDialog
            {
                Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxContactImage.Image = Image.FromFile(opf.FileName);
            }
        }

        // Check if the CheckBox is checked or not
        private void CheckBoxEnableGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxEnableGroups.Checked == true)
            {
                // Populate Edit ComboBox
                GROUP group = new GROUP();
                this.comboBoxGroup.Enabled = true;
                this.comboBoxGroup.DataSource = group.GetGroups(Globals.GlobalUserId);
                this.comboBoxGroup.DisplayMember = "GroupName";
                this.comboBoxGroup.ValueMember = "GroupId";
            }
            else
            {
                this.comboBoxGroup.DataSource = null;
                this.comboBoxGroup.Enabled = false;
            }
        }

        // Function Move Form
        private void Panel_Minimize_And_Close_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}
