using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharp_Login_And_Register
{
    public partial class RegisterForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const string FirstLastNamePattern = @"^[a-zA-Z]{1}((?=.{1})([.]{1})|([a-zA-Z]{1,49}))$";
        private const string EmailPattern = @"^[a-zA-Z0-9]{1}[a-zA-Z0-9\._-]{1,}\@[a-z]{1,}[-]{0,1}[a-z]{1,}(\.[a-z]{2,})$";
        private const string UsernamePattern = @"^[a-zA-Z0-9]{3,50}";
        private const string PasswordPattern = @"^[a-zA-Z0-9]{6,50}";

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Register Form Load
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.labelUserRegister;
        }

        // Label Close
        private void Label_Close_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // TextBox First Name Enter Event
        private void TextBoxFirstName_Enter(object sender, EventArgs e)
        {
            string firstName = this.textBoxFirstName.Text.Trim(); 

            if (firstName.Equals("First name"))
            {
                this.textBoxFirstName.Text = string.Empty;
                this.textBoxFirstName.ForeColor = Color.Black;
            }
        }

        // TextBox First Name Leave Event
        private void TextBoxFirstName_Leave(object sender, EventArgs e)
        {
            string firstName = this.textBoxFirstName.Text.Trim();

            if (firstName.Equals(string.Empty))
            {
                this.textBoxFirstName.Text = "First name";
                this.textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        // TextBox Last Name Enter Event
        private void TextBoxLastName_Enter(object sender, EventArgs e)
        {
            string lastName = this.textBoxLastName.Text.Trim();

            if (lastName.Equals("Last name"))
            {
                this.textBoxLastName.Text = string.Empty;
                this.textBoxLastName.ForeColor = Color.Black;
            }
        }

        // TextBox Last Name Leave Event
        private void TextBoxLastName_Leave(object sender, EventArgs e)
        {
            string lastName = this.textBoxLastName.Text.Trim();

            if (lastName.Equals(string.Empty))
            {
                this.textBoxLastName.Text = "Last name";
                this.textBoxLastName.ForeColor = Color.Gray;
            }
        }

        // TextBox Email Enter Event
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            string emailAddress = this.textBoxEmail.Text.Trim();

            if (emailAddress.Equals("Email Address"))
            {
                this.textBoxEmail.Text = string.Empty;
                this.textBoxEmail.ForeColor = Color.Black;
            }
        }

        // TextBox Email Leave Event
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            string emailAddress = this.textBoxEmail.Text.Trim();

            if (emailAddress.Equals(string.Empty))
            {
                this.textBoxEmail.Text = "Email Address";
                this.textBoxEmail.ForeColor = Color.Gray;
            }
        }

        // TextBox Username Enter Event
        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text.Trim();

            if (username.Equals("Username"))
            {
                this.textBoxUsername.Text = string.Empty;
                this.textBoxUsername.ForeColor = Color.Black;
            }
        }

        // TextBox Username Leave Event
        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text.Trim();

            if (username.Equals(string.Empty))
            {
                this.textBoxUsername.Text = "Username";
                this.textBoxUsername.ForeColor = Color.Gray;
            }
        }

        // TextBox Password Enter Event
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            string password = this.textBoxPassword.Text.Trim();

            if (password.Equals("Password"))
            {
                this.textBoxPassword.Text = string.Empty;
                this.textBoxPassword.UseSystemPasswordChar = true;
                this.textBoxPassword.ForeColor = Color.Black;
            }
        }

        // TextBox Password Leave Event
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            string password = this.textBoxPassword.Text.Trim();

            if (password.Equals(string.Empty))
            {
                this.textBoxPassword.Text = "Password";
                this.textBoxPassword.UseSystemPasswordChar = false;
                this.textBoxPassword.ForeColor = Color.Gray;
            }
        }

        // TextBox Confirm Password Enter Event
        private void TextBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            string confirmPassword = this.textBoxConfirmPassword.Text.Trim();

            if (confirmPassword.Equals("Confirm password"))
            {
                this.textBoxConfirmPassword.Text = string.Empty;
                this.textBoxConfirmPassword.UseSystemPasswordChar = true;
                this.textBoxConfirmPassword.ForeColor = Color.Black;
            }
        }

        // TextBox Confirm Password Leave Event
        private void TextBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            string confirmPassword = this.textBoxConfirmPassword.Text.Trim();

            if (confirmPassword.Equals(string.Empty))
            {
                this.textBoxConfirmPassword.Text = "Confirm password";
                this.textBoxConfirmPassword.UseSystemPasswordChar = false;
                this.textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        // Label Close Mouse Enter Event
        private void Label_Close_MouseEnter(object sender, EventArgs e)
        {
            this.Label_Close.ForeColor = Color.White;
        }

        // Label Close Mouse Leave Event
        private void Label_Close_MouseLeave(object sender, EventArgs e)
        {
            this.Label_Close.ForeColor = Color.Black;
        }

        // Register a New User
        private void Button_CreateAccount_Click(object sender, EventArgs e)
        {
            string firstName = this.textBoxFirstName.Text.Trim() != "First name" ? this.textBoxFirstName.Text.Trim() : string.Empty;
            string lastName = this.textBoxLastName.Text.Trim() != "Last name" ? this.textBoxLastName.Text.Trim() : string.Empty;
            string email = this.textBoxEmail.Text.Trim() != "Email Address" ? this.textBoxEmail.Text.Trim() : string.Empty;
            string username = this.textBoxUsername.Text.Trim();
            string password = this.textBoxPassword.Text.Trim();
            string confirmPassword = this.textBoxConfirmPassword.Text.Trim();

            User user = new User();

            // Check if the User Data is Valid
            if (IsUserDataValid(firstName, lastName, email, username, password, confirmPassword, out string errorMessage))
            {
                // Check if the Username already Exists
                if (!user.CheckIfUsernameExists(username))
                {
                    // Register New User
                    if (user.InsertNewUser(firstName, lastName, email, username, password))
                    {
                        MessageBox.Show($"{errorMessage} The Account was Created",
                                    "Register new User",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The Account was NOT Created!",
                        "Register new User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This Username Already Exists!",
                    "Register new User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The Data Is NOT Valid!"
                    + Environment.NewLine
                    + $"The following field is incorrect: {errorMessage}",
                    "Register new User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }        

        // Check if the User Enters a Valid Data
        private bool IsUserDataValid(string firstName, string lastName, string email, string username, string password, string confirmPassword, out string errorMessage)
        {
            if (firstName != string.Empty)
            {
                if (Regex.Match(firstName, FirstLastNamePattern).Success == false
                || firstName.Length > 50)
                {
                    errorMessage = "First Name";
                    return false;
                }
            }

            if (lastName != string.Empty)
            {
                if (Regex.Match(lastName, FirstLastNamePattern).Success == false
                || lastName.Length > 50)
                {
                    errorMessage = "Last Name";
                    return false;
                }
            }

            if (email != string.Empty)
            {
                if (email.Length > 50
                || Regex.Match(email, EmailPattern).Success == false)
                {
                    errorMessage = "Email";
                    return false;
                }
            }            

            if (username == "Username" 
                || Regex.Match(username, UsernamePattern).Success == false)
            {
                errorMessage = "Username";
                return false;
            }

            if (password == string.Empty || confirmPassword == string.Empty)
            {
                errorMessage = "Confirm Password";
                return false;
            }

            if (password != confirmPassword)
            {
                errorMessage = "Confirm Password";
                return false;
            }

            if (Regex.Match(password, PasswordPattern).Success == false)
            {
                errorMessage = "Password";
                return false;
            }

            errorMessage = "Success!";
            return true;
        }

        // Label_Go_To_Login Click Event
        private void Label_Go_To_Login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // Label_Go_To_Login Mouse Enter Event
        private void Label_Go_To_Login_MouseEnter(object sender, EventArgs e)
        {
            this.Label_Go_To_Login.ForeColor = Color.Yellow;
        }

        // Label_Go_To_Login Mouse Leave Event
        private void Label_Go_To_Login_MouseLeave(object sender, EventArgs e)
        {
            this.Label_Go_To_Login.ForeColor = Color.White;
        }

        // Form Move Function
        private void LabelUserRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}