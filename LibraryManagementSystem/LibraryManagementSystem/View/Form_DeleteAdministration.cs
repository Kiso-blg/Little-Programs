using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_DeleteAdministration : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_DeleteAdministration()
        {
            InitializeComponent();
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
        private void TextBox_ChiefAdministrator_Enter(object sender, EventArgs e)
        {
            string chiefAdministrator = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdministrator.Equals("Chief Administrator"))
            {
                this.textBox_ChiefAdministrator.Text = string.Empty;
                this.textBox_ChiefAdministrator.ForeColor = Color.Black;
            }
        }

        // TextBos Chief Administrator Name Leave Event.
        private void TextBox_ChiefAdministrator_Leave(object sender, EventArgs e)
        {
            string chiefAdministrator = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdministrator.Equals(string.Empty))
            {
                this.textBox_ChiefAdministrator.Text = "Chief Administrator";
                this.textBox_ChiefAdministrator.ForeColor = Color.DarkOliveGreen;
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

        // Delete Administration
        private void Button_DeleteAdministration_Click(object sender, EventArgs e)
        {
            string administrationName = this.textBox_AdministrationName.Text.Trim();
            string chiefAdminLogin = this.textBox_ChiefAdministrator.Text.Trim();
            string chiefAdminPassword = this.textBox_Password.Text.Trim();
            Administration administration = new Administration();

            if (administration.IsDataValid(administrationName, chiefAdminLogin, chiefAdminPassword, out string errorMessage))
            {
                if (administration.DoesAdministrationExists(administrationName, out errorMessage))
                {
                    if (administration.DeleteAdministration(administrationName, chiefAdminLogin, chiefAdminPassword, out errorMessage))
                    {
                        MessageBox.Show(errorMessage,
                            "Delete Administration",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearTextBoxesData();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage + " Please inform your database administrator.",
                            "Delete Administration",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage,
                        "Delete Administration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }                
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + errorMessage,
                    "Delete Administration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }

        // Clear the data in the textboxes.
        private void ClearTextBoxesData()
        {
            this.textBox_AdministrationName.Text = "Administration Name";
            this.textBox_AdministrationName.ForeColor = Color.DarkOliveGreen;
            this.textBox_ChiefAdministrator.Text = "Chief Administrator";
            this.textBox_ChiefAdministrator.ForeColor = Color.DarkOliveGreen;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.ForeColor = Color.DarkOliveGreen;
            this.textBox_Password.UseSystemPasswordChar = false;
        }

        // Close the form and go back to Login Form.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }

        // From move function.
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