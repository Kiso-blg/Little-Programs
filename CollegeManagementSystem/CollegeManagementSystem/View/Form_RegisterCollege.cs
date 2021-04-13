namespace CollegeManagementSystem
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class Form_RegisterCollege : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_RegisterCollege()
        {
            InitializeComponent();
        }        

        // Close RegisterCollege form.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            LoadLoginForm();            
        }

        // Load LoginForm
        private void LoadLoginForm()
        {
            Form_Login login = new Form_Login
            {
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };
            login.Show();

            this.Close();
        }

        // Register new college.
        private void Button_RegisterCollege_Click(object sender, EventArgs e)
        {
            string collegeName = this.textBox_CollegeName.Text.Trim();
            string rectorFirstName = this.textBox_RectorFirstName.Text.Trim();
            string rectorLastName = this.textBox_RectorLastName.Text.Trim();
            string administrator = this.textBox_Administrator.Text.Trim();
            string password = this.textBox_Password.Text.Trim();
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();
            Colleges colleges = new Colleges();

            if (password == confirmPassword)
            {
                if (colleges.IsDataValid(collegeName, rectorFirstName, rectorLastName, administrator, password, out string errorMsg))
                {
                    if (!colleges.DoesCollegeExists(collegeName, out errorMsg))
                    {
                        if (colleges.AddNewCollege(collegeName, rectorFirstName, rectorLastName, administrator, password, out errorMsg))
                        {
                            MessageBox.Show(errorMsg,
                                "Register College",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show(errorMsg,
                                "Register College",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "Register College",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The next Fields are incorrect: " + errorMsg,
                        "Register College",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password must be the same!",
                    "Register College",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }

        // Clear the entered data.
        private void ClearData()
        {
            this.textBox_CollegeName.Clear();
            this.textBox_RectorFirstName.Clear();
            this.textBox_RectorLastName.Clear();
            this.textBox_Administrator.Clear();
            this.textBox_Password.Clear();
            this.textBox_ConfirmPassword.Clear();
        }

        // Return to login form.
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            LoadLoginForm();            
        }

        // Move the form.
        private void Panel_Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Show characters on Mouse Enter event.
        private void TextBox_Password_MouseEnter(object sender, EventArgs e)
        {
            this.textBox_Password.UseSystemPasswordChar = false;
        }

        // Hide caracters on Mouse Leave event.
        private void TextBox_Password_MouseLeave(object sender, EventArgs e)
        {
            this.textBox_Password.UseSystemPasswordChar = true;
        }

        // Show characters on Mouse Enter event.
        private void TextBox_ConfirmPassword_MouseEnter(object sender, EventArgs e)
        {
            this.textBox_ConfirmPassword.UseSystemPasswordChar = false;
        }

        // Hide caracters on Mouse Leave event.
        private void TextBox_ConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}