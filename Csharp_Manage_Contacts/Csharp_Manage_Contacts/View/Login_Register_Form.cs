using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Login_Register_Form : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login_Register_Form()
        {
            InitializeComponent();
        }

        private readonly ConnString cs = new ConnString();

        // Form Load
        private void Login_Register_Form_Load(object sender, EventArgs e)
        {
            // Display image on the panel (close and minimize).
            this.Panel_Minimize_And_Close.BackgroundImage = Image.FromFile("../../Images/HeaderBlue.png");

            // Get the Server Name
            if (!cs.GetServerName())
            {
                MessageBox.Show("Could not retrieve Serve Name. The Program will Close!!",
                    "Server Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Create the Connection Strings Master
            if (!cs.EstablishMasterConnection())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Check the Database
            if (!cs.CheckIfDatabaseExists())
            {
                // Load Database from Script File
                if (!cs.LoadDatabaseFromScript())
                {
                    MessageBox.Show("Could not check if database exists or Could not load Database from script!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Database from script has been loaded!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            // Create the Connection Strings with the Database
            if (!cs.EstablishConnection())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Login button
        private void Button_Login_Click(object sender, EventArgs e)
        {
            ManageContacts_DB db = new ManageContacts_DB();
            DataTable table = new DataTable();

            using (SqlCommand command = new SqlCommand("uspLogin", db.GetConnection))                
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100));
                command.Parameters["@Username"].Value = this.textBoxUsername.Text;

                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 20));
                command.Parameters["@Password"].Value = this.textBoxPassword.Text;

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {                                       
                    try
                    {
                        db.OpenConnection();

                        adapter.SelectCommand = command;
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

            // Check for empty fields
            if (VerifyFields("login"))
            {
                // Check if this user exists
                if (table.Rows.Count > 0)
                {
                    // Get user Id
                    int userId = Convert.ToInt32(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserId(userId);

                    // Show the Main App From
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Show an Error Message
                    this.DialogResult = MessageBox.Show("Invalid Username or Password",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                // Show an Error Message
                this.DialogResult = MessageBox.Show("Empty Username or Password",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        // Register Button
        private void Button_Register_Click(object sender, EventArgs e)
        {
            string firstName = this.textBoxFirstName.Text.Trim();
            string lastName = this.textBoxLastName.Text.Trim();
            string username = this.textBoxUsernameRegister.Text.Trim();
            string password = this.textBoxPasswordRegister.Text.Trim();

            User user = new User();

            if (VerifyFields("register"))
            {
                // Get User Image
                MemoryStream picture = GetUserPicture();

                // Check if the username already exists
                if (!user.DoesUsernameExists(username))
                {
                    if (user.InsertUser(firstName, lastName, username, password, picture))
                    {
                        MessageBox.Show("Registration Completed Successfully",
                            "Register",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        GoBackToLogin();
                    }
                    else
                    {
                        MessageBox.Show("Something went Wrong",
                            "Register",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Username Already Exists. Try Another One",
                            "Invalid Username",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("* Required Fields - Firstname / Lastname / Username / Password",
                            "Register",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        // Get User Picture Method
        private MemoryStream GetUserPicture()
        {
            MemoryStream picture = new MemoryStream();

            if (this.pictureBoxProfileImage.Image != null)
            {
                // Upload picture
                this.pictureBoxProfileImage.Image.Save(picture, this.pictureBoxProfileImage.Image.RawFormat);
            }
            else
            {
                // Set default User Blank if no picture was selected.
                Image image = Image.FromFile("../../Images/UserBlank.png");
                this.pictureBoxProfileImage.Image = image;
                image.Save(picture, image.RawFormat);
            }

            return picture;
        }

        // Create a function to check for empty fields
        private bool VerifyFields(string operation)
        {
            bool check = false;

            // If the Operation is to Register
            if (operation == "register")
            {
                if (this.textBoxUsernameRegister.Text.Equals(string.Empty) 
                    || this.textBoxPasswordRegister.Text.Equals(string.Empty)
                    || this.textBoxFirstName.Text.Equals(string.Empty)
                    || this.textBoxLastName.Text.Equals(string.Empty))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            // If the Operation is to Login
            else if (operation == "login")
            {
                if (this.textBoxUsername.Text.Trim().Equals(string.Empty)
                    || this.textBoxPassword.Text.Trim().Equals(string.Empty))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }

            return check;
        }

        // Browse button
        private void Button_Browse_Click(object sender, EventArgs e)
        {
            // Select and diplay image in the picturebox
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxProfileImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Label go to the register section
        private void LabelGoToRegister_Click(object sender, EventArgs e)
        {
            this.Timer_GoToRegister.Start();
            this.LabelGoToRegister.Enabled = false;
            this.LabelGoToLogin.Enabled = false;
        }

        // Label go to the login section
        private void LabelGoToLogin_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        // Method Back to Login after Regostration
        private void GoBackToLogin()
        {
            this.Timer_GoToLogin.Start();
            this.LabelGoToLogin.Enabled = false;
            this.LabelGoToRegister.Enabled = false;
        }

        // Button close
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button minimize
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // When this timer will start the form will show only the register part
        private void Timer_GoToRegister_Tick(object sender, EventArgs e)
        {
            // -260 is where you can see the register part
            // the first 260 is where the login part is
            // so the panel need to go outside the form by 260
            // and the same when we want to show the login part
            // we need to set the location (X) of the panel to 0
            if (this.panelMenu.Location.X > -260)
            {
                this.panelMenu.Location = new Point(this.panelMenu.Location.X - 130, this.panelMenu.Location.Y);
            }
            else
            {
                this.Timer_GoToRegister.Stop();
                this.LabelGoToLogin.Enabled = true;
                this.LabelGoToRegister.Enabled = true;
            }
        }

        // When this timer will start the form will show only the login part
        private void Timer_GoToLogin_Tick(object sender, EventArgs e)
        {
            // 0 is where you can see the log in part
            if (this.panelMenu.Location.X < 0)
            {
                this.panelMenu.Location = new Point(this.panelMenu.Location.X + 130, this.panelMenu.Location.Y);
            }
            else
            {
                this.Timer_GoToLogin.Stop();
                this.LabelGoToLogin.Enabled = true;
                this.LabelGoToRegister.Enabled = true;
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