// <copyright file="Form_Login.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_AddTeacher class.
    /// Performing login in into the system.
    /// </summary>
    public partial class Form_Login : Form
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
        /// Initializes a new instance of the <see cref="Form_Login" /> class.
        /// </summary>
        public Form_Login()
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
        /// Exit from the application.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Go to register Form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonRegisterCollege_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_RegisterCollege register = new Form_RegisterCollege())
            {
                register.ShowDialog();
            }
        }

        /// <summary>
        /// Move the form method.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void PanelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WMNCLBUTTONDOWN, HTCAPTIOM, 0);
            }
        }

        /// <summary>
        /// Login to the application.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string administrator = this.textBoxAdministrator.Text.Trim();
            string password = this.textBoxPassword.Text.Trim();
            Colleges colleges = new Colleges();

            if (colleges.IsDataValid(administrator, password, out string errorMsg))
            {
                if (colleges.Login(administrator, password, out int collegeId, out errorMsg))
                {
                    Globals.SetGlobalCollegeId(collegeId);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        errorMsg,
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "The next Fields are incorrect: " + errorMsg,
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
    }
}
