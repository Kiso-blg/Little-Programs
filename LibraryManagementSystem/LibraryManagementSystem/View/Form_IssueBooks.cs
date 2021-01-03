using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_IssueBooks : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_IssueBooks()
        {
            InitializeComponent();
        }

        readonly Book book = new Book();
        readonly Student student = new Student();

        // Load Form.
        private void Form_IssueBooks_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            this.dateTimePicker_BookIssueDate.Value = DateTime.Now.Date;
        }

        // Populate ComboBox Books.
        private void PopulateComboBox()
        {
            DataTable table = book.GetBooksByIdAndName(out string errorMessage);

            if (table.Rows.Count > 0)
            {
                this.comboBox_Books.DataSource = table;
                this.comboBox_Books.DisplayMember = "BookName";
                this.comboBox_Books.ValueMember = "BookId";                
            }
            else
            {
                MessageBox.Show(errorMessage,
                    "ComboBox",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.button_IssueBook.Enabled = false;
            }
        }

        // Close the Form.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Close the IssueBook from.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Search Student by student EnrollmentNo.
        private void Button_SearchStudent_Click(object sender, EventArgs e)
        {
            if (this.textBox_EnrollmentNo.Text != string.Empty)
            {
                string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();
                DataTable table = student.GetStudentById(enrollmentNo);

                if (table.Rows.Count > 0)
                {
                    this.textBox_StudentName.Text = table.Rows[0]["StudentName"].ToString();
                    this.textBox_Department.Text = table.Rows[0]["StudentDepartment"].ToString();
                    this.textBox_Semester.Text = table.Rows[0]["StudentSemester"].ToString();
                    this.textBox_Contact.Text = table.Rows[0]["StudentContact"].ToString();
                    this.textBox_Email.Text = table.Rows[0]["StudentEmail"].ToString();
                }
                else
                {
                    ClearStudentData();
                }
            }
        }

        // Clear the Student data.
        private void ClearStudentData()
        {
            this.textBox_StudentName.Clear();
            this.textBox_Department.Clear();
            this.textBox_Semester.Clear();
            this.textBox_Contact.Clear();
            this.textBox_Email.Clear();
        }

        // Button Issue Book
        private void Button_IssueBook_Click(object sender, EventArgs e)
        {
            if (this.textBox_StudentName.Text != string.Empty && this.comboBox_Books.SelectedIndex != -1)
            {              
                string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();
                int bookId = int.Parse(this.comboBox_Books.SelectedValue.ToString());
                IssueBook issueBook = new IssueBook();

                if (!issueBook.IsBookAlreadyIssued(enrollmentNo, bookId, out string errorMessage))
                {
                    if (!issueBook.CanStudentTakeMoreBooks(enrollmentNo, out errorMessage))
                    {
                        if (issueBook.GiveABook(enrollmentNo, bookId, out errorMessage))
                        {
                            MessageBox.Show(errorMessage,
                                "Issue Book",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearStudentData();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage,
                                "Issue Book",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage,
                        "Issue Book",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage,
                        "Issue Book",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("No Student selected or no Book found!",
                        "Issue Book",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        // Move the From by holding mouse left button.
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Maximize From and return it to normal
        private void Button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // Minimize the Form.
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Clear the filled data.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            this.textBox_EnrollmentNo.Clear();
            this.textBox_StudentName.Clear();
            this.textBox_Department.Clear();
            this.textBox_Semester.Clear();
            this.textBox_Contact.Clear();
            this.textBox_Email.Clear();
        }
    }
}