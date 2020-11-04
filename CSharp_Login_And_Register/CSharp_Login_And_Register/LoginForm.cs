using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp_Login_And_Register
{
    public partial class LoginForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private readonly ConnString cs = new ConnString();

        // Form Load
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Get Server Name
            if (!cs.GetServerName())
            {
                MessageBox.Show("Could not retrieve Serve Name. The Program will Close!!",
                    "Server Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Establish Connection with Master Database
            if (!cs.CreateConnectionStringMaster())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Check if the Database Exists
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

            // Create the Connection String with the Database
            if (!cs.EstablishConnection())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Close the Form
        private void Label_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Button_Login_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            User user = new User();
            DataTable table = new DataTable();

            string username = this.textBoxUsername.Text.Trim();
            string password = this.textBoxPassword.Text.Trim(); 

            if (!username.Equals(string.Empty) && !password.Equals(string.Empty))
            {
                if (user.CheckIfUsernameExists(username))
                {
                    using (SqlCommand command = new SqlCommand("SelectAllFromUsers", db.GetConnection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100)).Value = username;
                        command.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50)).Value = password;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            try
                            {
                                db.OpneConnection();

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

                    // Check if the User exist or not
                    if (table.Rows.Count > 0)
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();

                        using (mainForm)
                        {
                            mainForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not Login!",
                            "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Username does not Exists!",
                        "Login User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }                               
            }
            else
            {
                MessageBox.Show("Please, fill the Username and Password fields");
            }   
        }

        // Go To Register Form
        private void Label_Go_ToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();

            using (registerForm)
            {
                registerForm.ShowDialog();
            }
        }

        // Label_Go_ToSignUp Mouse Enter Event
        private void Label_Go_ToSignUp_MouseEnter(object sender, EventArgs e)
        {
            this.Label_Go_ToSignUp.ForeColor = Color.Yellow;
        }

        // Label_Go_ToSignUp Mouse Leave Event
        private void Label_Go_ToSignUp_MouseLeave(object sender, EventArgs e)
        {
            this.Label_Go_ToSignUp.ForeColor = Color.White;
        }

        // Form Move Function
        private void LabelUserLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}