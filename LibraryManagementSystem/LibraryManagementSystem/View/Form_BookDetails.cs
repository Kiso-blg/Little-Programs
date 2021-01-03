using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_BookDetails : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_BookDetails()
        {
            InitializeComponent();
        }

        readonly IssueBook issueBook = new IssueBook();

        // Form Load
        private void Form_BookDetails_Load(object sender, EventArgs e)
        {
            PopulateDataGridViews();
        }

        // Populate the two DataGridViews with data for returned and not returned books.
        private void PopulateDataGridViews()
        {
            DataTable notReturnedBooksTable = issueBook.GetAllNotReturnedBooks(out string errorMessage);

            if (notReturnedBooksTable.Rows.Count > 0)
            {
                this.dataGridView_NotReturnedBooks.DataSource = notReturnedBooksTable;
            }
            else
            {
                if (errorMessage != string.Empty)
                {
                    MessageBox.Show(errorMessage,
                        "Issued Books",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            DataTable returnedBooksTable = issueBook.GetAllReturnedBooks(out string errorMsg);

            if (returnedBooksTable.Rows.Count > 0)
            {
                this.dataGridView_ReturnedBooks.DataSource = returnedBooksTable;
            }
            else
            {
                if (errorMessage != string.Empty)
                {
                    MessageBox.Show(errorMsg,
                        "Returned Books",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Search student and books data for the current student.
        private void Button_SearchBooksByStudentNo_Click(object sender, EventArgs e)
        {
            string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();

            if (enrollmentNo != string.Empty)
            {
                DataTable studentIssuedBooks = issueBook.GetStudentIssuedBooks(enrollmentNo, out string errorMessage);

                if (studentIssuedBooks.Rows.Count > 0)
                {
                    this.dataGridView_NotReturnedBooks.DataSource = studentIssuedBooks;
                }
                else
                {
                    if (errorMessage != string.Empty)
                    {
                        MessageBox.Show(errorMessage,
                            "Issued Books",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                DataTable studentReturnedBooks = issueBook.GetStudentReturnedBooks(enrollmentNo, out string errorMsg);

                if (studentReturnedBooks.Rows.Count > 0)
                {
                    this.dataGridView_ReturnedBooks.DataSource = studentReturnedBooks;
                }
                else
                {
                    if (errorMessage != string.Empty)
                    {
                        MessageBox.Show(errorMsg,
                            "Returned Books",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Close the form
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Refresh the DataGridView when the textBox EnrolmentNo is empty.
        private void TextBox_EnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_EnrollmentNo.Text.Trim() == string.Empty)
            {
                PopulateDataGridViews();
            }
        }

        // Move the form on mouse left button hold.
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