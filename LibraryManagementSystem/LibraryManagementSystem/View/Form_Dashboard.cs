using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_Dashboard : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_Dashboard()
        {
            InitializeComponent();
        }

        // Exit Application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are You Sure, You Want to Exit?",
            //    "Confirm",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //} 

            Application.Exit();
        }

        // Load Form Add New Book
        private void AddNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AddBook addBook = new Form_AddBook())
            {
                addBook.ShowDialog();
            }
        }

        // Function Move Form
        private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Load Form View Book
        private void ViewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_ViewBook viewBook = new Form_ViewBook())
            {
                viewBook.ShowDialog();
            }
        }

        // Load Form AddStudent.
        private void AddAStrudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AddStudent addStudent = new Form_AddStudent())
            {
                addStudent.ShowDialog();
            }
        }

        // Load Form ViewStudent.
        private void ViewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_ViewStudent viewStudent = new Form_ViewStudent())
            {
                viewStudent.ShowDialog();
            }
        }

        // Load Form IssueBook.
        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_IssueBooks issueBook = new Form_IssueBooks())
            {
                issueBook.ShowDialog();
            }
        }

        // Load Form ReturnBook.
        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_ReturnBook returnBook = new Form_ReturnBook())
            {
                returnBook.ShowDialog();
            }
        }

        // Load Form Books Details.
        private void CompleteBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_BookDetails booksDetails = new Form_BookDetails())
            {
                booksDetails.ShowDialog();
            }
        }
    }
}