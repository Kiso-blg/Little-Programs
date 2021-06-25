// <copyright file="Form_AddTeacher.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_AddTeacher class.
    /// Contains methods for Form_AddTeacher class.
    /// </summary>
    public partial class Form_AddTeacher : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_AddTeacher" /> class.
        /// </summary>
        public Form_AddTeacher()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form Load.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void Form_AddTeacher_Load(object sender, EventArgs e)
        {
            this.GetCoursesInComboBox();
            this.dateTimePickerDateOfBirth.Value = DateTime.Now.Date;
        }

        /// <summary>
        /// Fill the courses in the comboBox.
        /// </summary>
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            DataTable coursesTable = course.GetAllCourses(out string errorMsg);

            if (coursesTable.Rows.Count > 0)
            {
                this.comboBoxCourse.DisplayMember = "CourseName";
                this.comboBoxCourse.ValueMember = "CourseId";
                this.comboBoxCourse.DataSource = coursesTable;
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
            }
        }

        /// <summary>
        /// Add new teacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            string name = this.textBoxName.Text.Trim();
            string surname = this.textBoxSurname.Text.Trim();
            char gender = this.GetGender();
            DateTime dateOfBirth = this.dateTimePickerDateOfBirth.Value.Date;
            string mobilePhone = this.textBoxMobileNo.Text.Trim();
            string email = this.textBoxEmail.Text.Trim();
            int courseId = int.Parse(this.comboBoxCourse.SelectedValue.ToString());
            string address = this.richTextBoxAddress.Text.Trim();

            if (teachers.IsDataValid(name, surname, gender, mobilePhone, email, address, out string errorMsg))
            {
                if (courseId > 0)
                {
                    if (teachers.AddNewTeacher(name, surname, gender, dateOfBirth, mobilePhone, email, courseId, address, out errorMsg))
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Add New Teacher",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            this.ClearTheEnteredData();
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Add New Teacher",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No Courses Found!",
                        "Add New Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid input! The next Fields are Incorrect:"
                    + Environment.NewLine
                    + errorMsg,
                    "Add New Teacher",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Clear the entered data.
        /// </summary>
        private void ClearTheEnteredData()
        {
            this.textBoxName.Clear();
            this.textBoxSurname.Clear();
            this.radioButtonMale.Checked = false;
            this.radioButtonFemale.Checked = false;
            this.dateTimePickerDateOfBirth.Value = DateTime.Now.Date;
            this.textBoxMobileNo.Clear();
            this.textBoxEmail.Clear();
            this.GetCoursesInComboBox();
            this.richTextBoxAddress.Clear();
        }

        /// <summary>
        /// Return Gender type.
        /// </summary>
        /// <returns>
        /// Returns M for male, F for female and O if something went wrong.
        /// </returns>
        private char GetGender()
        {
            if (this.radioButtonMale.Checked)
            {
                return 'M';
            }
            else if (this.radioButtonFemale.Checked)
            {
                return 'F';
            }
            else
            {
                return 'O';
            }
        }

        /// <summary>
        /// Button Reset click event. Clear the entered data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonResetData_Click(object sender, EventArgs e)
        {
            this.ClearTheEnteredData();
        }
    }
}
