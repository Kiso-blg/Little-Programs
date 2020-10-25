using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Edit_User_Data_Form : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Edit_User_Data_Form()
        {
            InitializeComponent();
        }

        private readonly User user = new User();

        // Form Load
        private void Edit_User_Data_Form_Load(object sender, EventArgs e)
        {
            DisplayUserData();
        }

        // Display the user data
        private void DisplayUserData()
        {            
            DataTable table = user.GetUserByID(Globals.GlobalUserId);
            this.textBoxFirstName.Text = table.Rows[0]["FirstName"].ToString();
            this.textBoxLastName.Text = table.Rows[0]["LastName"].ToString();
            this.textBoxUsername.Text = table.Rows[0]["Username"].ToString();
            this.textBoxPasswor.Text = table.Rows[0]["Password"].ToString();

            byte[] pic = (byte[])table.Rows[0]["Picture"];
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBoxUserImage.Image = Image.FromStream(picture);
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

        // Button Browse Picture
        private void Button_Browse_Click(object sender, EventArgs e)
        {
            // Select and diplay image in the picturebox
            OpenFileDialog opf = new OpenFileDialog
            {
                Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxUserImage.Image = Image.FromFile(opf.FileName);
            }
        }

        // Button edit the User data
        private void Button_Edit_User_Click(object sender, EventArgs e)
        {
            int userId = Globals.GlobalUserId; // Get the logged int user Id
            string firstName = this.textBoxFirstName.Text.Trim();
            string lastName = this.textBoxLastName.Text.Trim();
            string username = this.textBoxUsername.Text.Trim();
            string password = this.textBoxPasswor.Text.Trim();

            MemoryStream picture = new MemoryStream();
            this.pictureBoxUserImage.Image.Save(picture, this.pictureBoxUserImage.Image.RawFormat);
            
            // Check for empty fields
            if (firstName.Equals(string.Empty)
                || lastName.Equals(string.Empty)
                || username.Equals(string.Empty) 
                || password.Equals(string.Empty))
            {
                MessageBox.Show("Required All Fields To Be Filled Up!",
                    "Edit Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                // Check if the username already exists
                if (user.DoesUsernameExists(username, userId))
                {
                    MessageBox.Show("This Username Already Exists. Try Another One",
                            "Invalid Username",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
                else if (user.UpdateUser(userId, firstName, lastName, username, password, picture))
                {
                    MessageBox.Show("Your Information Has Been Updated",
                        "Edit Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error! Could not edit User Data!",
                        "Edit Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
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