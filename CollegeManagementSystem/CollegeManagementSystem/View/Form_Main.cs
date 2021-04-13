namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    // Source: https://www.youtube.com/watch?v=rOlIWTcuJaA&feature=emb_logo&ab_channel=BTechDays

    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private readonly ConnString cs = new ConnString();

        // Form load method.
        private void Form_Main_Load(object sender, EventArgs e)
        {
            ConnectoToSqlServerAndSettleTheConnection();
            LoadLoginForm();
            this.menuStripButtons.Visible = true;
        }

        // Connect to server and create a connection string.
        private void ConnectoToSqlServerAndSettleTheConnection()
        {
            // Get the Server Name
            if (!cs.GetServerName())
            {
                MessageBox.Show("Could not retrieve Serve Name. The Program will Close!!",
                    "Server Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Create the ConnectionString Master
            if (!cs.EstablishConnectionMaster())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                   "Create Connection",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                this.Close();
            }

            // Check the Database
            if (!cs.CheckIfDatabaseExists())
            {
                // Load Database from Script File
                if (!cs.LoadDatabaseFromScript())
                {
                    MessageBox.Show("Could not check if database exists or Could not load Database from script!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Database from script has been loaded!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            // Create the ConnectionString with the Database
            if (!cs.EstablishConnection())
            {
                MessageBox.Show("Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Load Form_Login.
        private void LoadLoginForm()
        {
            using (Form_Login login = new Form_Login())
            {
                login.ShowDialog();
            }
        }

        // Load Form NewAdmission
        private void Button_NewAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_NewAdmission newAdmission = new Form_NewAdmission())
            {
                newAdmission.ShowDialog();
            }
        }

        // Load Form Update Semester
        private void UpdateSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_UpdateSemesters updateSemester = new Form_UpdateSemesters())
            {
                updateSemester.ShowDialog();
            }
        }

        // Exit the application.
        private void ExitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Load Form Fees
        private void FeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Fees formFees = new Form_Fees())
            {
                formFees.ShowDialog();
            }
        }

        // Load Form Courses
        private void AddRemoveCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Courses courses = new Form_Courses())
            {
                courses.ShowDialog();
            }
        }

        // Load Form SearchStudent
        private void SearchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_SearchStudent searchStudent = new Form_SearchStudent())
            {
                searchStudent.ShowDialog();
            }
        }

        // Load Form Student Individual Details
        private void IndividualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_StudentIndividualDetails studentDetails = new Form_StudentIndividualDetails())
            {
                studentDetails.ShowDialog();
            }
        }

        // Load Form Teachers
        private void AddTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AddTeacher addTeacher = new Form_AddTeacher())
            {
                addTeacher.ShowDialog();
            }
        }

        // Load Form Seach Teacher
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_SearchTeacher searchTeacher = new Form_SearchTeacher())
            {
                searchTeacher.ShowDialog();
            }
        }

        // Load Form RemoveStudent
        private void RemoveStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Form_RemoveStudent removeStudent = new Form_RemoveStudent())
            {
                removeStudent.ShowDialog();
            }
        }

        // Load Form RemoveTeacher
        private void RemoveTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_RemoveTeacher removeTeacher = new Form_RemoveTeacher())
            {
                removeTeacher.ShowDialog();
            }
        }

        // Load Form About Us
        private void AboudUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AboutUs aboutUs = new Form_AboutUs())
            {
                aboutUs.ShowDialog();
            }
        }
    }
}