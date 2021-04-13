namespace CollegeManagementSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form_NewAdmission : Form
    {
        public Form_NewAdmission()
        {
            InitializeComponent();
        }

        readonly Admissions admissions = new Admissions();

        // Form Load
        private void Form_NewAdmission_Load(object sender, EventArgs e)
        {
            GetRegistrationNumber();
            GetCoursesInComboBox();
            this.comboBox_Date.DataSource = Enumerable.Range(DateTime.Now.Year, 10).ToList();
        }

        // Get the next registration number.
        private void GetRegistrationNumber()
        {
            int id = admissions.GetLastRecordId(Globals.GlobalCollegeId, out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Registration Id",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (id > 0)
            {
                this.labelRegistrationId.Text = (++id).ToString();
            }
        }

        // Fill the courses in the combobox.
        private void GetCoursesInComboBox()
        {
            Course course = new Course();
            this.comboBox_Course.DataSource = course.GetAllCourses(out string errorMsg);

            if (this.comboBox_Course.Items.Count > 0)
            {               
                this.comboBox_Course.DisplayMember = "CourseName";
                this.comboBox_Course.ValueMember = "CourseId";                
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

                this.Button_Submit.Enabled = false;
            }            
        }

        // Submit new admission.
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string name = this.textBox_Name.Text.Trim();
            string surname = this.textBox_Surname.Text.Trim();
            char gender = GetGender();
            DateTime birthDate = this.dateTimePickerBirthDate.Value.Date;
            string mobilePhone = this.textBox_MobilePhone.Text.Trim();
            string email = this.textBox_Email.Text.Trim();
            int semesterId = 1;
            int courseId = int.Parse(this.comboBox_Course.SelectedValue.ToString());
            string schoolName = this.textBox_SchoolName.Text.Trim();
            DateTime inlistDate = new DateTime(int.Parse(this.comboBox_Date.SelectedItem.ToString()), DateTime.Now.Month, DateTime.Now.Day);
            string address = this.richTextBox_Address.Text.Trim();

            if (admissions.IsDataValid(name, surname, gender, mobilePhone, email, schoolName, address, out string errorMsg))
            {
                if (semesterId > 0 && courseId > 0)
                {
                    if (admissions.AddNewAdmission(name, surname, gender, birthDate, mobilePhone, email, semesterId, courseId, schoolName, inlistDate, address, out errorMsg))
                    {
                        MessageBox.Show(errorMsg,
                            "New Admission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearTheEnteredData();
                        GetRegistrationNumber();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "New Admission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the Comboboxes!",
                            "New Admission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid input! The next Fields are Incorrect:"
                    + Environment.NewLine
                    + errorMsg,
                    "New Admission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Return Gender type.
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

        // Button Reset
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            ClearTheEnteredData();
        }

        // Clear the entered data.
        private void ClearTheEnteredData()
        {
            this.textBox_Name.Clear();
            this.textBox_Surname.Clear();
            this.radioButtonFemale.Checked = false;
            this.radioButtonMale.Checked = false;
            this.dateTimePickerBirthDate.Value = DateTime.Now.Date;
            this.textBox_MobilePhone.Clear();
            this.textBox_Email.Clear();
            GetCoursesInComboBox();
            this.textBox_SchoolName.Clear();
            this.richTextBox_Address.Clear();
        }
    }
}