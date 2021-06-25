// <copyright file="Form_Main.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

//// Source: https://www.youtube.com/watch?v=rOlIWTcuJaA&feature=emb_logo&ab_channel=BTechDays
namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_Main class.
    /// Navigating into the system.
    /// </summary>
    public partial class Form_Main : Form
    {
        /// <summary>
        /// /// Contains an instance of object ConnString.
        /// </summary>
        private readonly ConnString cs = new ConnString();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Main" /> class.
        /// </summary>
        public Form_Main()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form load method.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.ConnectoToSqlServerAndSettleTheConnection();
            this.LoadLoginForm();
            this.menuStripButtons.Visible = true;
        }

        /// <summary>
        /// Connect to server and create a connection string.
        /// </summary>
        private void ConnectoToSqlServerAndSettleTheConnection()
        {
            // Get the Server Name
            if (!this.cs.GetServerName())
            {
                MessageBox.Show(
                    "Could not retrieve Serve Name. The Program will Close!!",
                    "Server Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }

            // Create the ConnectionString Master
            if (!this.cs.EstablishConnectionMaster())
            {
                MessageBox.Show(
                    "Could not create the Connection string. The Program will Close!!",
                   "Create Connection",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                this.Close();
            }

            // Check the Database
            if (!this.cs.CheckIfDatabaseExists())
            {
                // Load Database from Script File
                if (!this.cs.LoadDatabaseFromScript())
                {
                    MessageBox.Show(
                        "Could not check if database exists or Could not load Database from script!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Database from script has been loaded!",
                        "Check Database",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            // Create the ConnectionString with the Database
            if (!this.cs.EstablishConnection())
            {
                MessageBox.Show(
                    "Could not create the Connection string. The Program will Close!!",
                    "Create Connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Load Form_Login.
        /// </summary>
        private void LoadLoginForm()
        {
            using (Form_Login login = new Form_Login())
            {
                login.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form_NewAdmission
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonNewAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_NewAdmission newAdmission = new Form_NewAdmission())
            {
                newAdmission.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form Update Semester.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void UpdateSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_UpdateSemesters updateSemester = new Form_UpdateSemesters())
            {
                updateSemester.ShowDialog();
            }
        }

        /// <summary>
        /// Exit the application.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ExitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Load Form Fees.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void FeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Fees formFees = new Form_Fees())
            {
                formFees.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form Courses.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void AddRemoveCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Courses courses = new Form_Courses())
            {
                courses.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form SearchStudent.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void SearchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_SearchStudent searchStudent = new Form_SearchStudent())
            {
                searchStudent.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form Student Individual Details.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void IndividualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_StudentIndividualDetails studentDetails = new Form_StudentIndividualDetails())
            {
                studentDetails.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form Teachers.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void AddTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AddTeacher addTeacher = new Form_AddTeacher())
            {
                addTeacher.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form Search Teacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_SearchTeacher searchTeacher = new Form_SearchTeacher())
            {
                searchTeacher.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form RemoveStudent.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void RemoveStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_RemoveStudent removeStudent = new Form_RemoveStudent())
            {
                removeStudent.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form RemoveTeacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void RemoveTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_RemoveTeacher removeTeacher = new Form_RemoveTeacher())
            {
                removeTeacher.ShowDialog();
            }
        }

        /// <summary>
        /// Load Form About Us.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void AboudUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_AboutUs aboutUs = new Form_AboutUs())
            {
                aboutUs.ShowDialog();
            }
        }
    }
}
