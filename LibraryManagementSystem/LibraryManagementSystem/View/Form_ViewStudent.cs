using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_ViewStudent : Form
    {       
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_ViewStudent()
        {
            InitializeComponent();
        }

        private readonly Student student = new Student();
        private string currentStudentNo;

        // Form Load
        private void Form_ViewStudent_Load(object sender, EventArgs e)
        {
            this.Size = new Size(964, 440);
            FillDataGridView();
        }

        // Populate the DataGridView.
        private void FillDataGridView()
        {
            DataTable table = this.student.GetAllStudents(out string errorMessage);
            
            if (table.Rows.Count > 0)
            {
                this.dataGridView_Students.DataSource = table;
                this.dataGridView_Students.ClearSelection();
            }
            else
            {
                MessageBox.Show("No table found!"
                    + Environment.NewLine
                    + errorMessage,
                    "Load Students",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Close form View Student.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Change the pictureBox image when the textBox_Search is not empty.
        private void TextBox_SearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_SearchStudent.Text != string.Empty)
            {
                Image image = Image.FromFile(@"C:\Users\User\source\repos\LibraryManagementSystem\LibraryManagementSystem\Images\search1.gif");
                this.pictureBox.Image = image;

                string currentSearchText = this.textBox_SearchStudent.Text.Trim();
                DataTable table = this.student.GetTableByCurrentText(currentSearchText);

                if (table.Rows.Count > 0)
                {
                    this.dataGridView_Students.DataSource = table;
                    this.dataGridView_Students.ClearSelection();
                }                
            }
            else
            {
                Image image = Image.FromFile(@"C:\Users\User\source\repos\LibraryManagementSystem\LibraryManagementSystem\Images\search.gif");
                this.pictureBox.Image = image;
                FillDataGridView();
            }
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Students_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Students
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Students.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Students.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Students.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If new column is selected, sort by new column.
            if (newColumn != null)
            {
                this.dataGridView_Students.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Students.ClearSelection();
        }

        // Select a student and display its data in panel Student_Data.
        private void DataGridView_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_Students.SelectedCells != null)
            {
                if (e.RowIndex > -1)
                {
                    string enrollmentNo = this.dataGridView_Students.Rows[e.RowIndex].Cells["StudentNumbeR"].Value.ToString();
                    DataTable table = this.student.GetCurrentStudent(enrollmentNo, out string errorMessage);
                    FillStudentData(table, errorMessage);
                    this.panelStudentData.Visible = true;
                    this.Size = new Size(964, 650);
                }
                else
                {
                    this.panelStudentData.Visible = false;
                    this.Size = new Size(964, 440);
                }
            }
            else
            {
                this.panelStudentData.Visible = false;
                this.Size = new Size(964, 440);
            }
        }

        // Fill the selected student data in the panel Student_Data.
        private void FillStudentData(DataTable table, string errorMessage)
        {
            if (table.Rows.Count > 0)
            {
                this.textBox_StudentName.Text = table.Rows[0]["StudentName"].ToString();
                this.textBox_EnrollmentNo.Text = table.Rows[0]["StudentNumber"].ToString();
                this.textBox_Department.Text = table.Rows[0]["StudentDepartment"].ToString();
                this.textBox_Semester.Text = table.Rows[0]["StudentSemester"].ToString();
                this.textBox_Contact.Text = table.Rows[0]["StudentContact"].ToString();
                this.textBox_Email.Text = table.Rows[0]["StudentEmail"].ToString();
                this.currentStudentNo = table.Rows[0]["StudentNumber"].ToString();
            }
            else
            {
                MessageBox.Show(errorMessage,
                    "Select Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Update the student data.
        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure? The student data will be changed permanently!",
                "Update Student",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentName = this.textBox_StudentName.Text.Trim();
                string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();
                string department = this.textBox_Department.Text.Trim();
                string studentSemester = this.textBox_Semester.Text.Trim();
                string mobilePhone = this.textBox_Contact.Text.Trim();
                string email = this.textBox_Email.Text.Trim();

                if (student.IsDataValid(studentName, enrollmentNo, department, studentSemester, mobilePhone, email, out string invalidFields))
                {
                    if (student.UpdateStudent(studentName, this.currentStudentNo, department, studentSemester, mobilePhone, email, out string message))
                    {
                        MessageBox.Show(message,
                                "Update Student",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        FillDataGridView();
                        this.Size = new Size(964, 440);
                    }
                    else
                    {
                        MessageBox.Show(message,
                                "Update Book",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input! The next Fields are Incorrect: "
                        + invalidFields,
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
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

        // Delete the selected student.
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();

            if (MessageBox.Show("Are you sure, you want to delete the student?",
                "Delete Student",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (!issueBook.HasStudentIssuedBooks(this.currentStudentNo, out string errorMessage))
                {
                    if (issueBook.DeleteStudentRecordsFromIssueReturnBook(this.currentStudentNo, out errorMessage))
                    {
                        if (this.student.DeleteStudent(this.currentStudentNo, out errorMessage))
                        {
                            MessageBox.Show(errorMessage,
                                    "Delete Student",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            FillDataGridView();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage,
                                    "Delete Student",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage,
                            "Delete Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage,
                            "Delete Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }                
            }   
        }

        // When Cancel hide the student data.
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.panelStudentData.Visible = false;
            this.Size = new Size(964, 440);
        }

        // Reload the Form View Student.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            this.textBox_SearchStudent.Clear();
        }
    }
}