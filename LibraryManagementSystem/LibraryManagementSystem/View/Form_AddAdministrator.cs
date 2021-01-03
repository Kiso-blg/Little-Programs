using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_AddAdministrator : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_AddAdministrator()
        {
            InitializeComponent();
        }        

        // TextBox Chief Administrator Enter Event.
        private void TextBox_ChiefAdministrator_Enter(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdmin.Equals("Chief Administrator"))
            {
                this.textBox_ChiefAdministrator.Text = string.Empty;
                this.textBox_ChiefAdministrator.ForeColor = Color.Black;
            }
        }

        // TextBox Chief Administrator Leave Event.
        private void TextBox_ChiefAdministrator_Leave(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdmin.Equals(string.Empty))
            {
                this.textBox_ChiefAdministrator.Text = "Chief Administrator";
                this.textBox_ChiefAdministrator.ForeColor = Color.LightGray;
            }
        }

        // TextBox Chief Administrator Password Enter Event.
        private void TextBox_ChiefAdminPassword_Enter(object sender, EventArgs e)
        {
            string adminPassword = this.textBox_ChiefAdminPassword.Text.Trim();

            if (adminPassword.Equals("Admin Password"))
            {
                this.textBox_ChiefAdminPassword.Text = string.Empty;
                this.textBox_ChiefAdminPassword.ForeColor = Color.Black;
            }
        }

        // TextBox Chief Administrator Password Leave Event.
        private void TextBox_ChiefAdminPassword_Leave(object sender, EventArgs e)
        {
            string adminPassword = this.textBox_ChiefAdminPassword.Text.Trim();

            if (adminPassword.Equals(string.Empty))
            {
                this.textBox_ChiefAdminPassword.Text = "Admin Password";
                this.textBox_ChiefAdminPassword.ForeColor = Color.LightGray;
            }
        }

        // TextBox New Administrator Enter Event.
        private void TextBox_NewAdministrator_Enter(object sender, EventArgs e)
        {
            string newAdministrator = this.textBox_NewAdministrator.Text.Trim();

            if (newAdministrator.Equals("New Administrator"))
            {
                this.textBox_NewAdministrator.Text = string.Empty;
                this.textBox_NewAdministrator.ForeColor = Color.Black;
            }
        }

        // TextBox New Administrator Leave Event.
        private void TextBox_NewAdministrator_Leave(object sender, EventArgs e)
        {
            string newAdministrator = this.textBox_NewAdministrator.Text.Trim();

            if (newAdministrator.Equals(string.Empty))
            {
                this.textBox_NewAdministrator.Text = "New Administrator";
                this.textBox_NewAdministrator.ForeColor = Color.LightGray;
            }
        }

        // TextBox New Administrator First Name Enter Event.
        private void TextBox_AdministratorFirtName_Enter(object sender, EventArgs e)
        {
            string adminFirstName = this.textBox_AdministratorFirstName.Text.Trim();

            if (adminFirstName.Equals("Administrator First Name"))
            {
                this.textBox_AdministratorFirstName.Text = string.Empty;
                this.textBox_AdministratorFirstName.ForeColor = Color.Black;
            }
        }

        // TextBox New Administrator First Name Leave Event.
        private void TextBox_AdministratorFirtName_Leave(object sender, EventArgs e)
        {
            string adminFirstName = this.textBox_AdministratorFirstName.Text.Trim();

            if (adminFirstName.Equals(string.Empty))
            {
                this.textBox_AdministratorFirstName.Text = "Administrator First Name";
                this.textBox_AdministratorFirstName.ForeColor = Color.LightGray;
            }
        }

        // TextBox New Administrator Last Name Enter Event.
        private void TextBox_AdministratorLastName_Enter(object sender, EventArgs e)
        {
            string adminLastName = this.textBox_AdministratorLastName.Text.Trim();

            if (adminLastName.Equals("Administrator Last Name"))
            {
                this.textBox_AdministratorLastName.Text = string.Empty;
                this.textBox_AdministratorLastName.ForeColor = Color.Black;
            }
        }

        // TextBox New Administrator Last Name Leave Event.
        private void TextBox_AdministratorLastName_Leave(object sender, EventArgs e)
        {
            string adminLastName = this.textBox_AdministratorLastName.Text.Trim();

            if (adminLastName.Equals(string.Empty))
            {
                this.textBox_AdministratorLastName.Text = "Administrator Last Name";
                this.textBox_AdministratorLastName.ForeColor = Color.LightGray;
            }
        }

        // TextBox New Administrator Password Enter Event.
        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            string password = this.textBox_Password.Text.Trim();

            if (password.Equals("Password"))
            {
                this.textBox_Password.Text = string.Empty;
                this.textBox_Password.ForeColor = Color.Black;
            }
        }

        // TextBox New Administrator Password Leave Event.
        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            string password = this.textBox_Password.Text.Trim();

            if (password.Equals(string.Empty))
            {
                this.textBox_Password.Text = "Password";
                this.textBox_Password.ForeColor = Color.LightGray;
            }
        }

        // TextBox New Administrator Confirm Password Enter Event.
        private void TextBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();

            if (confirmPassword.Equals("Confirm Password"))
            {
                this.textBox_ConfirmPassword.Text = string.Empty;
                this.textBox_ConfirmPassword.ForeColor = Color.Black;
            }
        }

        // TextBox New Administrator Confirm Password Leave Event.
        private void TextBox_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();

            if (confirmPassword.Equals(string.Empty))
            {
                this.textBox_ConfirmPassword.Text = "Confirm Password";
                this.textBox_ConfirmPassword.ForeColor = Color.LightGray;
            }
        }        

        // Add new Administrator.
        private void Button_AddAdministrator_Click(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();
            string adminPassword = this.textBox_ChiefAdminPassword.Text.Trim();
            string newAdmin = this.textBox_NewAdministrator.Text.Trim();
            string firstName = this.textBox_AdministratorFirstName.Text.Trim();
            string lastName = this.textBox_AdministratorLastName.Text.Trim();
            string password = this.textBox_Password.Text.Trim();
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();
            Administrator administrator = new Administrator();
            Administration administration = new Administration();

            if (administrator.IsDataValid(chiefAdmin, adminPassword, newAdmin, firstName, lastName, password, confirmPassword, out string message))
            {
                if (administration.IsChiefAdminCorrect(chiefAdmin, adminPassword, out int administrationId, out message))
                {
                    if (!administrator.DoesAdministratorExists(administrationId, newAdmin, out message))
                    {
                        if (password == confirmPassword)
                        {
                            if (administrator.AddNewAdministrator(administrationId, newAdmin, firstName, lastName, password, out message))
                            {
                                MessageBox.Show(message,
                                    "Add Administrator",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ClearNewAdminData();
                            }
                            else
                            {
                                MessageBox.Show(message,
                                    "Add Administrator",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password and Confirm Password must be the same!",
                                "Add Administrator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message,
                            "Add Administrator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(message,
                        "Add Administrator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }                                               
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + message,
                    "Add Administrator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Clear the entered data.
        private void ClearNewAdminData()
        {
            this.textBox_NewAdministrator.Text = "New Administrator";
            this.textBox_NewAdministrator.ForeColor = Color.LightGray;
            this.textBox_AdministratorFirstName.Text = "Administrator First Name";
            this.textBox_AdministratorFirstName.ForeColor = Color.LightGray;
            this.textBox_AdministratorLastName.Text = "Administrator Last Name";
            this.textBox_AdministratorLastName.ForeColor = Color.LightGray;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.ForeColor = Color.LightGray;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.ForeColor = Color.LightGray;
        }

        // Close the form and go back to Login Form.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }

        // Form move function.
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