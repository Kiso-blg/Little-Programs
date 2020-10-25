using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Add_Contact_Form : Form
    {
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-z]{2,}(\.[a-z]{2,})$";
        private const string PhonePattern = @"^08([7-9]{1}[2-9]{1}[0-9]{6})$";

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Add_Contact_Form()
        {
            InitializeComponent();
        }

        // Form Load
        private void Add_Contact_Form_Load(object sender, EventArgs e)
        {            
            this.comboBoxGroup.Enabled = false;            
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

        // Button Add Contact
        private void Button_Add_Contact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            string firstName = this.textBoxFirstName.Text.Trim();
            string lastName = this.textBoxLastName.Text.Trim();
            string phone = this.textBoxPhone.Text.Trim();
            string email = this.textBoxEmail.Text.Trim();
            string address = this.textBoxAddress.Text.Trim();
            int userId = Globals.GlobalUserId;
            // Get Group Id
            int groupId = this.CheckBoxEnableGroups.Checked == true
                ? Convert.ToInt32(this.comboBoxGroup.SelectedValue.ToString())
                : -1;

            // Get Contact Image
            MemoryStream picture = GetContactPicture();

            // Check if the required fields are empty.
            if (!firstName.Equals(string.Empty) && !phone.Equals(string.Empty))
            {
                if (IsPhoneValid(phone))
                {
                    if (IsEmailValid(email))
                    {
                        if (contact.InsertContact(firstName, lastName, groupId, phone, email, address, picture, userId))
                        {
                            MessageBox.Show("New Contact was Added",
                                "Add Contact",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error! Could not Add a Contact",
                                "Add Contact",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Email Addres is not Valid!",
                            "Add Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    MessageBox.Show("The Entered Phone is not Valid!",
                            "Add Contact",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Require First Name and Phone Number atleast!",
                        "Add Contact",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        // Validate Email Input
        private bool IsEmailValid(string email)
        {
            if (!email.Equals(string.Empty))
            {
                return Regex.Match(email, EmailPattern).Success;
            }

            return true;
        }

        // Validate Phone Input 
        private bool IsPhoneValid(string phone)
        {
            return Regex.Match(phone, PhonePattern).Success;
        }

        // Function Get Picture
        private MemoryStream GetContactPicture()
        {            
            MemoryStream picture = new MemoryStream();

            if (this.pictureBoxContactImage.Image != null)
            {
                // Upload picture
                this.pictureBoxContactImage.Image.Save(picture, this.pictureBoxContactImage.Image.RawFormat);
            }
            else
            {
                // Set default User Blank if no picture was selected.
                Image image = Image.FromFile("../../Images/UserBlank.png");
                this.pictureBoxContactImage.Image = image;
                image.Save(picture, image.RawFormat);
            }

            return picture;
        }

        // Button Browse Image
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

        // CheckBox Checked Change Method
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