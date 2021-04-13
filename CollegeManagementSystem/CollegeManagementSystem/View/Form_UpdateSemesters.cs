namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_UpdateSemesters : Form
    {
        public Form_UpdateSemesters()
        {
            InitializeComponent();
        }

        private readonly Admissions admission = new Admissions();
        private bool isComboBoxCoursesFilled = false;
        private bool isComboBoxDatesFilled = false;
        private bool isComboBoxSemestersFilled = false;

        public int CourseId { get; private set; }
        public int StartYear { get; private set; }
        public int SemesterId { get; private set; }

        // Form Load
        private void Form_UpdateSemesters_Load(object sender, EventArgs e)
        {
            GetCoursesInComboBox();
        }        

        // Fill ComboBox Courses
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            DataTable coursesTable = course.GetAllCourses(out string errorMsg);

            if (coursesTable.Rows.Count > 0)
            {
                this.comboBox_Courses.DisplayMember = "CourseName";
                this.comboBox_Courses.ValueMember = "CourseId";
                this.isComboBoxCoursesFilled = true;
                this.comboBox_Courses.DataSource = coursesTable;                
            }
            else
            {
                if (errorMsg != string.Empty)
                {
                    MessageBox.Show(errorMsg,
                        "Fill ComboBox Courses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No Courses Found!",
                        "Fill ComboBox Courses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                this.isComboBoxCoursesFilled = false;
            }
        }

        // Reload the dates in ComboBox Dates on Courses Selected Index Change
        private void ComboBox_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDatesInComboBox();
            ClearStudentData();
        }

        // Fill ComboBox Dates
        private void GetDatesInComboBox()
        {
            if (this.isComboBoxCoursesFilled)
            {
                int coursesId = int.Parse(this.comboBox_Courses.SelectedValue.ToString());
                DataTable yearsTable = admission.GetDates(coursesId, out string errorMsg);

                if (yearsTable.Rows.Count > 0)
                {
                    this.comboBox_Dates.DisplayMember = "Year";
                    this.isComboBoxDatesFilled = true;
                    this.comboBox_Dates.DataSource = yearsTable;
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(errorMsg,
                            "Fill ComboBox Courses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    ClearComboBoxDates();
                }
            }
            else
            {
                ClearComboBoxDates();
            }
        }

        // Clear ComboBox Dates
        private void ClearComboBoxDates()
        {
            this.isComboBoxDatesFilled = false;
            this.comboBox_Dates.DataSource = null;
            this.comboBox_Dates.Text = string.Empty;
        }

        // Reload the semesters in ComboBox Semesters on Dates Select Index Change
        private void ComboBox_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSemestersInComboBox();
            ClearStudentData();
        }

        // Fill ComboBox Semesters
        private void GetSemestersInComboBox()
        {
            if (this.isComboBoxDatesFilled)
            {
                int coursesId = int.Parse(this.comboBox_Courses.SelectedValue.ToString());
                int year = int.Parse(this.comboBox_Dates.Text);
                DataTable semestersTable = admission.GetSemesters(coursesId, year, out string errorMsg);

                if (semestersTable.Rows.Count > 0)
                {
                    this.comboBox_Semesters.DisplayMember = "SemesterName";
                    this.comboBox_Semesters.ValueMember = "SemesterId";
                    this.isComboBoxSemestersFilled = true;
                    this.comboBox_Semesters.DataSource = semestersTable;
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(errorMsg,
                            "Fill ComboBox Semesters",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    ClearComboBoxSemesters();
                }
            }
            else
            {
                ClearComboBoxSemesters();
            }
        }

        // Clear ComboBox Semesters
        private void ClearComboBoxSemesters()
        {
            this.isComboBoxSemestersFilled = false;
            this.comboBox_Semesters.DataSource = null;
            this.comboBox_Semesters.Text = string.Empty;            
        }

        // Clear the selected sudent data on ComboBox Semesters Selected Index Change event
        private void ComboBox_Semesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearStudentData();
        }

        // Update Semester
        private void Button_UpdateSemester_Click(object sender, EventArgs e)
        {
            if (this.label_StudentId.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure? The current student semester will be updated",
                    "Update Semester",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int studentId = int.Parse(this.label_StudentId.Text);

                    if (admission.UpdateSemesters(studentId, out string errorMsg))
                    {
                        MessageBox.Show(errorMsg,
                            "Update Semester",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);                        
                        GetDatesInComboBox();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "Update Semester",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }                
            }
        }

        // Select students with current course, inlist date and semester who had paid their fees.
        private void Button_SelectStudent_Click(object sender, EventArgs e)
        {
            if (isComboBoxSemestersFilled)
            {
                int courseId = int.Parse(this.comboBox_Courses.SelectedValue.ToString());
                int year = int.Parse(this.comboBox_Dates.Text);
                int semesterId = int.Parse(this.comboBox_Semesters.SelectedValue.ToString());

                SetCourseId(courseId);
                SetStartYear(year);
                SetSemesterId(semesterId);

                string studentId = string.Empty;
                string studentName = string.Empty;
                string studentSurname = string.Empty;

                using (Form_SelectStudent selectStudent = new Form_SelectStudent(this))
                {
                    selectStudent.ShowDialog();

                    if (selectStudent.dataGridView_SelectStudents.Rows.Count > 0)
                    {
                        studentId = selectStudent.dataGridView_SelectStudents.CurrentRow.Cells["AdmissionId"].Value.ToString();
                        studentName = selectStudent.dataGridView_SelectStudents.CurrentRow.Cells["Name"].Value.ToString();
                        studentSurname = selectStudent.dataGridView_SelectStudents.CurrentRow.Cells["Surname"].Value.ToString();
                    }                    
                }

                this.label_StudentId.Text = studentId;
                this.label_StudentName.Text = studentName + " " + studentSurname;
            }            
        }

        // Set Course Id 
        private void SetCourseId(int courseId)
        {
            this.CourseId = courseId;
        }

        // Set Start Date
        private void SetStartYear(int year)
        {
            this.StartYear = year;
        }

        // Set Semester Id
        private void SetSemesterId(int semesterId)
        {
            this.SemesterId = semesterId;
        }

        // Clear the selected student data.
        private void ClearStudentData()
        {
            this.label_StudentId.Text = string.Empty;
            this.label_StudentName.Text = string.Empty;
        }        
    }
}