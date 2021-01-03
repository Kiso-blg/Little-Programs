using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_AddStudent : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_AddStudent()
        {
            InitializeComponent();
        }

        // Close the form
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Exit closes the form.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Button Refresh Click Event
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        // Clear the student data.
        private void ClearData()
        {
            this.textBox_StudentName.Clear();
            this.textBox_EnrollmentNo.Clear();
            this.textBox_Department.Clear();
            this.textBox_StudentSemester.Clear();
            this.textBox_StudentContact.Clear();
            this.textBox_StudentEmail.Clear();
        }

        // Save the student information.
        private void Button_SaveInfo_Click(object sender, EventArgs e)
        {
            string studentName = this.textBox_StudentName.Text.Trim();
            string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();
            string department = this.textBox_Department.Text.Trim();
            string studentSemester = this.textBox_StudentSemester.Text.Trim();
            string mobilePhone = this.textBox_StudentContact.Text.Trim();
            string email = this.textBox_StudentEmail.Text.Trim();
            Student student = new Student();

            if (student.IsDataValid(studentName, enrollmentNo, department, studentSemester, mobilePhone, email, out string errorMessage))
            {                
                if (!student.DoesStudentExists(enrollmentNo, out string errorMsg))
                {
                    if (student.InsertNewStudent(studentName, enrollmentNo, department, studentSemester, mobilePhone, email, out string message))
                    {
                        MessageBox.Show(message,
                            "Add Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show(message,
                            "Add Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMsg,
                        "Add Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input! The next Fields are Incorrect:"
                    + Environment.NewLine
                    + errorMessage,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Move the form on mouse left button hold.
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}