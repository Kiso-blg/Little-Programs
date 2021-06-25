// <copyright file="Form_UpdateSemesters.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_UpdateSemesters class.
    /// Contains methods for Form_UpdateSemesters class.
    /// </summary>
    public partial class Form_UpdateSemesters : Form
    {
        /// <summary>
        /// Contains an instance of Admissions class.
        /// </summary>
        private readonly Admissions admission = new Admissions();

        /// <summary>
        /// Checks if combo box isComboBoxCoursesFilled is filled with data.
        /// Returns True if the combo box is filled and False if it is empty.
        /// </summary>
        private bool isComboBoxCoursesFilled = false;

        /// <summary>
        /// Checks if combo box isComboBoxDatesFilled is filled with data.
        /// Returns True if the combo box is filled and False if it is empty.
        /// </summary>
        private bool isComboBoxDatesFilled = false;

        /// <summary>
        /// Checks if combo box isComboBoxSemestersFilled is filled with data.
        /// Returns True if the combo box is filled and False if it is empty.
        /// </summary>
        private bool isComboBoxSemestersFilled = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_UpdateSemesters" /> class.
        /// </summary>
        public Form_UpdateSemesters()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets Course Id.
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// Gets or sets Enlist date.
        /// </summary>
        public int StartYear { get; set; }

        /// <summary>
        /// Gets or sets Semester Id.
        /// </summary>
        public int SemesterId { get; set; }

        /// <summary>
        /// Load Form_UpdateSemesters_Load.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void Form_UpdateSemesters_Load(object sender, EventArgs e)
        {
            this.GetCoursesInComboBox();
        }

        /// <summary>
        /// Fills ComboBox Courses.
        /// </summary>
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            DataTable coursesTable = course.GetAllCourses(out string errorMsg);

            if (coursesTable.Rows.Count > 0)
            {
                this.comboBoxCourses.DisplayMember = "CourseName";
                this.comboBoxCourses.ValueMember = "CourseId";
                this.isComboBoxCoursesFilled = true;
                this.comboBoxCourses.DataSource = coursesTable;                
            }
            else
            {
                if (errorMsg != string.Empty)
                {
                    MessageBox.Show(
                        errorMsg,
                        "Fill ComboBox Courses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "No Courses Found!",
                        "Fill ComboBox Courses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                this.isComboBoxCoursesFilled = false;
            }
        }

        /// <summary>
        /// Reload the dates in ComboBox Dates on Courses Selected Index Change.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ComboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetDatesInComboBox();
            this.ClearStudentData();
        }

        /// <summary>
        /// Fills ComboBox Dates.
        /// </summary>
        private void GetDatesInComboBox()
        {
            if (this.isComboBoxCoursesFilled)
            {
                int coursesId = int.Parse(this.comboBoxCourses.SelectedValue.ToString());
                DataTable yearsTable = admission.GetDates(coursesId, out string errorMsg);

                if (yearsTable.Rows.Count > 0)
                {
                    this.comboBoxDates.DisplayMember = "Year";
                    this.isComboBoxDatesFilled = true;
                    this.comboBoxDates.DataSource = yearsTable;
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Fill ComboBox Courses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    this.ClearComboBoxDates();
                }
            }
            else
            {
                this.ClearComboBoxDates();
            }
        }

        /// <summary>
        /// Clears ComboBox Dates.
        /// </summary>
        private void ClearComboBoxDates()
        {
            this.isComboBoxDatesFilled = false;
            this.comboBoxDates.DataSource = null;
            this.comboBoxDates.Text = string.Empty;
        }

        /// <summary>
        /// Reload the semesters in ComboBox Semesters on Dates Select Index Change.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ComboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetSemestersInComboBox();
            this.ClearStudentData();
        }

        /// <summary>
        /// Fill ComboBox Semesters.
        /// </summary>
        private void GetSemestersInComboBox()
        {
            if (this.isComboBoxDatesFilled)
            {
                int coursesId = int.Parse(this.comboBoxCourses.SelectedValue.ToString());
                int year = int.Parse(this.comboBoxDates.Text);
                DataTable semestersTable = admission.GetSemesters(coursesId, year, out string errorMsg);

                if (semestersTable.Rows.Count > 0)
                {
                    this.comboBoxSemesters.DisplayMember = "SemesterName";
                    this.comboBoxSemesters.ValueMember = "SemesterId";
                    this.isComboBoxSemestersFilled = true;
                    this.comboBoxSemesters.DataSource = semestersTable;
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Fill ComboBox Semesters",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    this.ClearComboBoxSemesters();
                }
            }
            else
            {
                this.ClearComboBoxSemesters();
            }
        }

        /// <summary>
        /// Clear ComboBox Semesters.
        /// </summary>
        private void ClearComboBoxSemesters()
        {
            this.isComboBoxSemestersFilled = false;
            this.comboBoxSemesters.DataSource = null;
            this.comboBoxSemesters.Text = string.Empty;            
        }

        /// <summary>
        /// Clears the selected student data on ComboBox Semesters Selected Index Change event.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ComboBoxSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClearStudentData();
        }

        /// <summary>
        /// Updates Semester.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonUpdateSemester_Click(object sender, EventArgs e)
        {
            if (this.labelStudentId.Text != string.Empty)
            {
                if (MessageBox.Show(
                    "Are you sure? The current student semester will be updated",
                    "Update Semester",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int studentId = int.Parse(this.labelStudentId.Text);

                    if (admission.UpdateSemesters(studentId, out string errorMsg))
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Update Semester",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.GetDatesInComboBox();
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Update Semester",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }                
            }
        }

        /// <summary>
        /// Select students with current course, enlist date and semester who had paid their fees.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonSelectStudent_Click(object sender, EventArgs e)
        {
            if (isComboBoxSemestersFilled)
            {
                int courseId = int.Parse(this.comboBoxCourses.SelectedValue.ToString());
                int year = int.Parse(this.comboBoxDates.Text);
                int semesterId = int.Parse(this.comboBoxSemesters.SelectedValue.ToString());

                this.SetCourseId(courseId);
                this.SetStartYear(year);
                this.SetSemesterId(semesterId);

                string studentId = string.Empty;
                string studentName = string.Empty;
                string studentSurname = string.Empty;

                using (Form_SelectStudent selectStudent = new Form_SelectStudent(this))
                {
                    selectStudent.ShowDialog();

                    if (selectStudent.SelectedIndex > 0)
                    {
                        studentId = selectStudent.DataGridViewSelectStudents.CurrentRow.Cells["AdmissionId"].Value.ToString();
                        studentName = selectStudent.DataGridViewSelectStudents.CurrentRow.Cells["Name"].Value.ToString();
                        studentSurname = selectStudent.DataGridViewSelectStudents.CurrentRow.Cells["Surname"].Value.ToString();
                    }                    
                }

                this.labelStudentId.Text = studentId;
                this.labelStudentName.Text = studentName + " " + studentSurname;
            }            
        }

        /// <summary>
        /// Sets Course Id.
        /// </summary>
        /// <param name="courseId">Contains the course id.</param>
        private void SetCourseId(int courseId)
        {
            this.CourseId = courseId;
        }

        /// <summary>
        /// Sets Start Date.
        /// </summary>
        /// <param name="year">Contains the year of the enlist date.</param>
        private void SetStartYear(int year)
        {
            this.StartYear = year;
        }

        /// <summary>
        /// Sets Semester Id.
        /// </summary>
        /// <param name="semesterId">Contains the semester id.</param>
        private void SetSemesterId(int semesterId)
        {
            this.SemesterId = semesterId;
        }

        /// <summary>
        /// Clear the selected student data.
        /// </summary>
        private void ClearStudentData()
        {
            this.labelStudentId.Text = string.Empty;
            this.labelStudentName.Text = string.Empty;
        }        
    }
}
