namespace CollegeManagementSystem
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

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

        // Exit from the application.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Go to register Form.
        private void Button_RegisterCollete_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form_RegisterCollege register = new Form_RegisterCollege())
            {
                register.ShowDialog();
            }
        }

        // Move the form method.
        private void Panel_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Login to the application.
        private void Button_Login_Click(object sender, EventArgs e)
        {
            string administrator = this.textBox_Administrator.Text.Trim();
            string password = this.textBox_Password.Text.Trim();
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
                    MessageBox.Show(errorMsg,
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + errorMsg,
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
    }
}