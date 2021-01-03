using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_AddAdministration : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_AddAdministration()
        {
            InitializeComponent();
        }

        // Close the form and go back to Login Form.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }        

        // TextBos Administration Name Enter Event.
        private void TextBox_AdministrationName_Enter(object sender, EventArgs e)
        {
            string administrationName = this.textBox_AdministrationName.Text.Trim();

            if (administrationName.Equals("Administration Name"))
            {
                this.textBox_AdministrationName.Text = string.Empty;
                this.textBox_AdministrationName.ForeColor = Color.Black;
            }
        }

        // TextBos Administration Name Leave Event.
        private void TextBox_AdministrationName_Leave(object sender, EventArgs e)
        {
            string administrationName = this.textBox_AdministrationName.Text.Trim();

            if (administrationName.Equals(string.Empty))
            {
                this.textBox_AdministrationName.Text = "Administration Name";
                this.textBox_AdministrationName.ForeColor = Color.DarkOliveGreen;
            }
        }

        // TextBos Chief Administrator Name Enter Event.
        private void TextBox_ChiefAdministratkor_Enter(object sender, EventArgs e)
        {
            string chiefAdministrator = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdministrator.Equals("Chief Administrator"))
            {
                this.textBox_ChiefAdministrator.Text = string.Empty;
                this.textBox_ChiefAdministrator.ForeColor = Color.Black;
            }
        }

        // TextBos Chief Administrator Name Leave Event.
        private void TextBox_ChiefAdministratkor_Leave(object sender, EventArgs e)
        {
            string chiefAdministrator = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdministrator.Equals(string.Empty))
            {
                this.textBox_ChiefAdministrator.Text = "Chief Administrator";
                this.textBox_ChiefAdministrator.ForeColor = Color.DarkOliveGreen;
            }
        }

        // TextBos Administrator First Name Enter Event.
        private void TextBox_AdministratorFirtName_Enter(object sender, EventArgs e)
        {
            string firstName = this.textBox_AdministratorFirtName.Text.Trim();

            if (firstName.Equals("Administrator First Name"))
            {
                this.textBox_AdministratorFirtName.Text = string.Empty;
                this.textBox_AdministratorFirtName.ForeColor = Color.Black;
            }
        }

        // TextBos Administrator First Name Leave Event.
        private void TextBox_AdministratorFirtName_Leave(object sender, EventArgs e)
        {
            string firstName = this.textBox_AdministratorFirtName.Text.Trim();

            if (firstName.Equals(string.Empty))
            {
                this.textBox_AdministratorFirtName.Text = "Administrator First Name";
                this.textBox_AdministratorFirtName.ForeColor = Color.DarkOliveGreen;
            }
        }

        // TextBos Administrator Last Name Enter Event.
        private void TextBox_AdministratorLastName_Enter(object sender, EventArgs e)
        {
            string lastName = this.textBox_AdministratorLastName.Text.Trim();

            if (lastName.Equals("Administrator Last Name"))
            {
                this.textBox_AdministratorLastName.Text = string.Empty;
                this.textBox_AdministratorLastName.ForeColor = Color.Black;
            }
        }

        // TextBos Administrator Last Name Leave Event.
        private void TextBox_AdministratorLastName_Leave(object sender, EventArgs e)
        {
            string lastName = this.textBox_AdministratorLastName.Text.Trim();

            if (lastName.Equals(string.Empty))
            {
                this.textBox_AdministratorLastName.Text = "Administrator Last Name";
                this.textBox_AdministratorLastName.ForeColor = Color.DarkOliveGreen;
            }
        }

        // TextBos Password Enter Event.
        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            string password = this.textBox_Password.Text.Trim();

            if (password.Equals("Password"))
            {
                this.textBox_Password.Text = string.Empty;
                this.textBox_Password.ForeColor = Color.Black;
                this.textBox_Password.UseSystemPasswordChar = true;
            }
        }

        // TextBos Password Leave Event.
        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            string password = this.textBox_Password.Text.Trim();

            if (password.Equals(string.Empty))
            {
                this.textBox_Password.Text = "Password";
                this.textBox_Password.ForeColor = Color.DarkOliveGreen;
                this.textBox_Password.UseSystemPasswordChar = false;
            }
        }

        // TextBos Confirm Password Enter Event.
        private void TextBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();

            if (confirmPassword.Equals("Confirm Password"))
            {
                this.textBox_ConfirmPassword.Text = string.Empty;
                this.textBox_ConfirmPassword.ForeColor = Color.Black;
                this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        // TextBos Confirm Password Leave Event.
        private void TextBox_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();

            if (confirmPassword.Equals(string.Empty))
            {
                this.textBox_ConfirmPassword.Text = "Confirm Password";
                this.textBox_ConfirmPassword.ForeColor = Color.DarkOliveGreen;
                this.textBox_ConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        // Button Close Mouse Enter event
        private void Button_Close_MouseEnter(object sender, EventArgs e)
        {
            this.Button_Close.ForeColor = Color.Black;
        }

        // Button Close Mouse Leave event
        private void Button_Close_MouseLeave(object sender, EventArgs e)
        {
            this.Button_Close.ForeColor = Color.DarkOliveGreen;
        }

        // Add new Administration
        private void Button_AddAdministration_Click(object sender, EventArgs e)
        {
            string administrationName = this.textBox_AdministrationName.Text.Trim();
            string chiefAdminLogin = this.textBox_ChiefAdministrator.Text.Trim();
            string adminFirstName = this.textBox_AdministratorFirtName.Text.Trim();
            string adminLastName = this.textBox_AdministratorLastName.Text.Trim();
            string password = this.textBox_Password.Text.Trim();
            string confirmPassword = this.textBox_ConfirmPassword.Text.Trim();
            Administration administration = new Administration();

            if (administration.IsDataValid(administrationName, chiefAdminLogin, adminFirstName, adminLastName, password, confirmPassword, out string errorMessage))
            {
                if (password == confirmPassword)
                {
                    if (!administration.DoesAdministrationExists(administrationName, out errorMessage))
                    {
                        if (administration.AddAdministration(administrationName, chiefAdminLogin, password, out errorMessage))
                        {
                            if (administration.AddChiefAdministrator(administrationName, chiefAdminLogin, adminFirstName, adminLastName, password, out errorMessage))
                            {
                                MessageBox.Show(errorMessage,
                                    "Add Administration",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ClearTextBoxesData();
                            }
                            else
                            {
                                // Delete the unsuccessfulli registered administration.
                                if (!administration.DeleteAdministration(administrationName, chiefAdminLogin, password, out string deleteError))
                                {
                                    errorMessage += Environment.NewLine
                                        +  deleteError
                                        + Environment.NewLine
                                        + "Please ask your database admin to delete the administration manualy!";
                                }

                                MessageBox.Show(errorMessage,
                                    "Add Administration",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(errorMessage,
                                "Add Administration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage,
                            "Add Administration",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password must be the same!",
                        "Add Administration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + errorMessage,
                    "Add Administration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Clear the filled data for adding administration in the textbosex.
        private void ClearTextBoxesData()
        {
            this.textBox_AdministrationName.Text = "Administration Name";
            this.textBox_AdministrationName.ForeColor = Color.DarkOliveGreen;
            this.textBox_ChiefAdministrator.Text = "Chief Administrator";
            this.textBox_ChiefAdministrator.ForeColor = Color.DarkOliveGreen;
            this.textBox_AdministratorFirtName.Text = "Administrator First Name";
            this.textBox_AdministratorFirtName.ForeColor = Color.DarkOliveGreen;
            this.textBox_AdministratorLastName.Text = "Administrator Last Name";
            this.textBox_AdministratorLastName.ForeColor = Color.DarkOliveGreen;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.ForeColor = Color.DarkOliveGreen;
            this.textBox_Password.UseSystemPasswordChar = false;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.ForeColor = Color.DarkOliveGreen;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = false;
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