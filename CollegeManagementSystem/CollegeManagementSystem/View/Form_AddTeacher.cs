namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_AddTeacher : Form
    {
        public Form_AddTeacher()
        {
            InitializeComponent();
        }

        // Form Load
        private void Form_AddTeacher_Load(object sender, EventArgs e)
        {
            GetCoursesInComboBox();
            this.dateTimePicker_DateOfBirth.Value = DateTime.Now.Date;
        }

        // Fill the courses in the combobox.
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            DataTable coursesTable = course.GetAllCourses(out string errorMsg);

            if (coursesTable.Rows.Count > 0)
            {
                this.comboBox_Course.DisplayMember = "CourseName";
                this.comboBox_Course.ValueMember = "CourseId";
                this.comboBox_Course.DataSource = coursesTable;
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
            }
        }

        // Add new teacher.
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            string name = this.textBox_Name.Text.Trim();
            string surname = this.textBox_Surname.Text.Trim();
            char gender = GetGender();
            DateTime dateOfBirth = this.dateTimePicker_DateOfBirth.Value.Date;
            string mobilePhone = this.textBox_MobileNo.Text.Trim();
            string email = this.textBox_Email.Text.Trim();
            int courseId = int.Parse(this.comboBox_Course.SelectedValue.ToString());
            string address = this.richTextBox_Address.Text.Trim();

            if (teachers.IsDataValid(name, surname, gender, mobilePhone, email, address, out string errorMsg))
            {
                if (courseId > 0)
                {
                    if (teachers.AddNewTeacher(name, surname, gender, dateOfBirth, mobilePhone, email, courseId, address, out errorMsg))
                    {
                        MessageBox.Show(errorMsg,
                        "Add New Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        ClearTheEnteredData();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                        "Add New Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No Courses Found!",
                        "Add New Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input! The next Fields are Incorrect:"
                    + Environment.NewLine
                    + errorMsg,
                    "Add New Teacher",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Clear the entered data.
        private void ClearTheEnteredData()
        {
            this.textBox_Name.Clear();
            this.textBox_Surname.Clear();
            this.radioButton_Male.Checked = false;
            this.radioButton_Female.Checked = false;
            this.dateTimePicker_DateOfBirth.Value = DateTime.Now.Date;
            this.textBox_MobileNo.Clear();
            this.textBox_Email.Clear();
            GetCoursesInComboBox();
            this.richTextBox_Address.Clear();
        }

        // Return Gender type.
        private char GetGender()
        {
            if (this.radioButton_Male.Checked)
            {
                return 'M';
            }
            else if (this.radioButton_Female.Checked)
            {
                return 'F';
            }
            else
            {
                return 'O';
            }
        }

        // Button Reset click event. Clear the entered data.
        private void Button_ResetData_Click(object sender, EventArgs e)
        {
            ClearTheEnteredData();
        }
    }
}