using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Select_Contact_Form : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Select_Contact_Form()
        {
            InitializeComponent();
        }

        // Form Load
        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            //Display the logged in user Contacts list
            using (SqlCommand command = new SqlCommand("SelectContactsByGroup"))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                command.Parameters["@UserId"].Value = Globals.GlobalUserId;

                Contact contact = new Contact();
                this.DataGridViewContactsList.DataSource = contact.SelectContactLists(command);
                this.DataGridViewContactsList.ClearSelection();
            }   
        }

        // Buttton Close
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Minimize 
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Close the Form after selecting a Contact
        private void DataGridViewContactsList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Function Move Form
        private void Panel_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}