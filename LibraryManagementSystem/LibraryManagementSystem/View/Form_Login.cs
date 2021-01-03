using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_Login : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_Login()
        {
            InitializeComponent();
        }

        private readonly ConnString cs = new ConnString();

        // Load Form
        private void Form_Login_Load(object sender, EventArgs e)
        {
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

        // TextBox Administration Enter Event
        private void TextBoxAdministration_Enter(object sender, EventArgs e)
        {
            string administration = this.textBoxAdministration.Text.Trim();

            if (administration.Equals("Administration Name"))
            {
                this.textBoxAdministration.Text = string.Empty;
                this.textBoxAdministration.ForeColor = Color.White;
            }
        }

        // TextBox Administration Leave Event
        private void TextBoxAdministration_Leave(object sender, EventArgs e)
        {
            string administration = this.textBoxAdministration.Text.Trim();

            if (administration.Equals(string.Empty))
            {
                this.textBoxAdministration.Text = "Administration Name";
                this.textBoxAdministration.ForeColor = Color.White;
            }
        }

        // TextBox Username Enter Event
        private void TextBox_Username_Enter(object sender, EventArgs e)
        {
            string admin = this.TextBox_Administrator.Text.Trim();

            if (admin.Equals("Administrator Login"))
            {
                this.TextBox_Administrator.Text = string.Empty;
                this.TextBox_Administrator.ForeColor = Color.LightGray;
            }
        }        

        // TextBox Username Leave Event
        private void TextBox_Username_Leave(object sender, EventArgs e)
        {
            string admin = this.TextBox_Administrator.Text.Trim();

            if (admin.Equals(string.Empty))
            {
                this.TextBox_Administrator.Text = "Administrator Login";
                this.TextBox_Administrator.ForeColor = Color.LightGray;
            }
        }

        // TextBox Password Enter Event
        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            string password = this.TextBox_Password.Text.Trim();

            if (password.Equals("Password"))
            {
                this.TextBox_Password.Text = string.Empty;
                this.TextBox_Password.ForeColor = Color.White;
                this.TextBox_Password.UseSystemPasswordChar = true;
            }
        }

        // TextBox Password Leave Event
        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            string password = this.TextBox_Password.Text.Trim();

            if (password.Equals(string.Empty))
            {
                this.TextBox_Password.Text = "Password";
                this.TextBox_Password.ForeColor = Color.LightGray;
                this.TextBox_Password.UseSystemPasswordChar = false;
            }
        }

        // Load Register form.
        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_AddAdministration addAdministration = new Form_AddAdministration())
            {
                addAdministration.ShowDialog();
            }
        }

        // Login to the Dashboard Form.
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string administrationName = this.textBoxAdministration.Text.Trim();
            string adminLogin = this.TextBox_Administrator.Text.Trim();
            string adminPassword = this.TextBox_Password.Text.Trim();
            Administration administration = new Administration();
            Administrator administrator = new Administrator();

            if (administration.IsDataValid(administrationName, out string message))
            {
                if (administrator.IsDataValid(adminLogin, adminPassword, out message))
                {
                    if (administration.DoesAdministrationExists(administrationName, out message))
                    {
                        if (administrator.IsLoginAdminCorrect(adminLogin, adminPassword, out int administrationId, out message))
                        {
                            Globals.SetGlobalAdministrationId(administrationId);

                            using (Form_Dashboard dashBoard = new Form_Dashboard())
                            {
                                dashBoard.ShowDialog();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(message,
                                "Login",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message,
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }                    
                }
                else
                {
                    MessageBox.Show(message,
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(message,
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }        

        // Load Form Add New Administration.
        private void AddAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_AddAdministration addAdministration = new Form_AddAdministration())
            {
                addAdministration.ShowDialog();
            }
        }

        // Load Form Delete Administration.
        private void DeleteAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_DeleteAdministration deleteAdministration = new Form_DeleteAdministration())
            {
                deleteAdministration.ShowDialog();
            }
        }        

        // Load Form Add Administrator.
        private void AddAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_AddAdministrator addAdministrator = new Form_AddAdministrator())
            {
                addAdministrator.ShowDialog();
            }
        }

        // Load Form Delete Administrator.
        private void DeleteAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_DeleteAdministrator deleteAdministrator = new Form_DeleteAdministrator())
            {
                deleteAdministrator.ShowDialog();
            }
        }

        // Close the Application
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Form move function.
        private void PanelBody_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }        
    }
}