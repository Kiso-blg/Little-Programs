// <copyright file="Form_RegisterCollege.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_RegisterCollege class.
    /// Contains methods for Form_RegisterCollege class.
    /// </summary>
    public partial class Form_RegisterCollege : Form
    {
        /// <summary>
        /// Probably reserve information if the mouse button is clicked in hexadecimal number.
        /// </summary>
        private const int WMNCLBUTTONDOWN = 0xA1;

        /// <summary>
        /// Probably reserve information if the mouse button is clicked in hexadecimal number.
        /// </summary>
        private const int HTCAPTIOM = 0X2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_RegisterCollege" /> class.
        /// </summary>
        public Form_RegisterCollege()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Send message.
        /// </summary>
        /// <param name="hwnd">Integer parameter.</param>
        /// <param name="msg">Message result in integer.</param>
        /// <param name="paramW">Parameter W.</param>
        /// <param name="paramL">Parameter L.</param>
        /// <returns>
        /// Returns integer as a result.
        /// </returns>
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int paramW, int paramL);

        /// <summary>
        /// Returns True if the visual object is captures with the mouse button and false if it is not.
        /// </summary>
        /// <returns>
        /// Returns True or False depending if the moving object is captures.
        /// </returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Invokes method LoadLoginForm.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.LoadLoginForm();            
        }

        /// <summary>
        /// Closes Form_RegisterCollege and returns to Form_Login.
        /// </summary>
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

        /// <summary>
        /// Registers new college.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonRegisterCollege_Click(object sender, EventArgs e)
        {
            string collegeName = this.textBoxCollegeName.Text.Trim();
            string rectorFirstName = this.textBoxRectorFirstName.Text.Trim();
            string rectorLastName = this.textBoxRectorLastName.Text.Trim();
            string administrator = this.textBoxAdministrator.Text.Trim();
            string password = this.textBoxPassword.Text.Trim();
            string confirmPassword = this.textBoxConfirmPassword.Text.Trim();
            Colleges colleges = new Colleges();

            if (password == confirmPassword)
            {
                if (colleges.IsDataValid(collegeName, rectorFirstName, rectorLastName, administrator, password, out string errorMsg))
                {
                    if (!colleges.DoesCollegeExists(collegeName, out errorMsg))
                    {
                        if (colleges.AddNewCollege(collegeName, rectorFirstName, rectorLastName, administrator, password, out errorMsg))
                        {
                            MessageBox.Show(
                                errorMsg,
                                "Register College",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.ClearData();
                        }
                        else
                        {
                            MessageBox.Show(
                                errorMsg,
                                "Register College",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Register College",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "The next Fields are incorrect: " + errorMsg,
                        "Register College",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Password and Confirm Password must be the same!",
                    "Register College",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }

        /// <summary>
        /// Clear the entered data.
        /// </summary>
        private void ClearData()
        {
            this.textBoxCollegeName.Clear();
            this.textBoxRectorFirstName.Clear();
            this.textBoxRectorLastName.Clear();
            this.textBoxAdministrator.Clear();
            this.textBoxPassword.Clear();
            this.textBoxConfirmPassword.Clear();
        }

        /// <summary>
        /// Invokes method LoadLoginForm.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.LoadLoginForm();            
        }

        /// <summary>
        /// Move the form method.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void PanelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WMNCLBUTTONDOWN, HTCAPTIOM, 0);
            }
        }

        /// <summary>
        /// Show characters on Mouse Enter event.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void TextBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Hide characters on Mouse Leave event.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void TextBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Show characters on Mouse Enter event.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void TextBoxConfirmPassword_MouseEnter(object sender, EventArgs e)
        {
            this.textBoxConfirmPassword.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Hide characters on Mouse Leave event.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void TextBoxConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
        }
    }
}
