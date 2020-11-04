using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp_Login_And_Register
{
    public partial class MainForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        // Label Close
        private void Label_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Move Form Function
        private void LabelMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Return to Login Form
        private void LabelReturn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}