// <copyright file="Form_NewAdmission.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_NewAdmission class.
    /// Perform adding new admission.
    /// </summary>
    public partial class Form_NewAdmission : Form
    {
        /// <summary>
        /// Contains an instance of Admissions class.
        /// </summary>
        private readonly Admissions admissions = new Admissions();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_NewAdmission" /> class.
        /// </summary>
        public Form_NewAdmission()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load form Form_NewAdmission.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void Form_NewAdmission_Load(object sender, EventArgs e)
        {
            this.GetRegistrationNumber();
            this.GetCoursesInComboBox();
            this.comboBoxDate.DataSource = Enumerable.Range(DateTime.Now.Year, 10).ToList();
        }

        /// <summary>
        /// Get the next registration number.
        /// </summary>
        private void GetRegistrationNumber()
        {
            int id = this.admissions.GetLastRecordId(Globals.GlobalCollegeId, out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Registration Id",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (id > 0)
            {
                this.labelRegistrationId.Text = (++id).ToString();
            }
        }

        /// <summary>
        /// Fill the courses in the comboBox.
        /// </summary>
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            this.comboBoxCourse.DataSource = course.GetAllCourses(out string errorMsg);

            if (this.comboBoxCourse.Items.Count > 0)
            {               
                this.comboBoxCourse.DisplayMember = "CourseName";
                this.comboBoxCourse.ValueMember = "CourseId";                
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

                this.buttonSubmit.Enabled = false;
            }            
        }

        /// <summary>
        /// Submit new admission.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text.Trim();
            string surname = this.textBoxSurname.Text.Trim();
            char gender = GetGender();
            DateTime birthDate = this.dateTimePickerBirthDate.Value.Date;
            string mobilePhone = this.textBoxMobilePhone.Text.Trim();
            string email = this.textBoxEmail.Text.Trim();
            int semesterId = 1;
            int courseId = int.Parse(this.comboBoxCourse.SelectedValue.ToString());
            string schoolName = this.textBoxSchoolName.Text.Trim();
            DateTime inlistDate = new DateTime(int.Parse(this.comboBoxDate.SelectedItem.ToString()), DateTime.Now.Month, DateTime.Now.Day);
            string address = this.richTextBoxAddress.Text.Trim();

            if (this.admissions.IsDataValid(name, surname, gender, mobilePhone, email, schoolName, address, out string errorMsg))
            {
                if (semesterId > 0 && courseId > 0)
                {
                    if (this.admissions.AddNewAdmission(name, surname, gender, birthDate, mobilePhone, email, semesterId, courseId, schoolName, inlistDate, address, out errorMsg))
                    {
                        MessageBox.Show(
                            errorMsg,
                            "New Admission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.ClearTheEnteredData();
                        this.GetRegistrationNumber();
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "New Admission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Please fill the Comboboxes!",
                        "New Admission",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid input! The next Fields are Incorrect:"
                    + Environment.NewLine
                    + errorMsg,
                    "New Admission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Return Gender type.
        /// </summary>
        /// <returns>
        /// Returns M for male, F for female and O if something went wrong.
        /// </returns>
        private char GetGender()
        {
            if (this.radioButtonMale.Checked == true)
            {
                return 'M';
            }
            else if (this.radioButtonFemale.Checked == true)
            {
                return 'F';
            }
            else
            {
                return 'O';
            }
        }

        /// <summary>
        /// Reset the controllers data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.ClearTheEnteredData();
        }

        /// <summary>
        /// Clear the entered data.
        /// </summary>
        private void ClearTheEnteredData()
        {
            this.textBoxName.Clear();
            this.textBoxSurname.Clear();
            this.radioButtonFemale.Checked = false;
            this.radioButtonMale.Checked = false;
            this.dateTimePickerBirthDate.Value = DateTime.Now.Date;
            this.textBoxMobilePhone.Clear();
            this.textBoxEmail.Clear();
            this.GetCoursesInComboBox();
            this.textBoxSchoolName.Clear();
            this.richTextBoxAddress.Clear();
        }
    }
}
