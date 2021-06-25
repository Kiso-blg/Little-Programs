// <copyright file="Form_StudentIndividualDetails.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_StudentIndividualDetails class.
    /// Contains methods for Form_StudentIndividualDetails class.
    /// </summary>
    public partial class Form_StudentIndividualDetails : Form
    {
        /// <summary>
        /// Contains the pattern with which are fulfilled the empty labels.
        /// </summary>
        private const string EmptyLabelText = "________";

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_StudentIndividualDetails" /> class.
        /// </summary>
        public Form_StudentIndividualDetails()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button search student by admission id.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonSelectStudent_Click(object sender, EventArgs e)
        {
            int admissionId;

            using (Form_SelectAdmission selectAdmission = new Form_SelectAdmission())
            {
                selectAdmission.ShowDialog();
                ////admissionId = int.Parse(selectAdmission.dataGridView_Admissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
                admissionId = selectAdmission.SelectedIndex;
            }

            if (admissionId > 0)
            {
                this.PopulateStudentDetails(admissionId);
            }            
        }

        /// <summary>
        /// Populate the student data in the labels.
        /// </summary>
        /// <param name="admissionId">Contains the admission id.</param>
        private void PopulateStudentDetails(int admissionId)
        {
            Admissions admission = new Admissions();
            DataTable studentDetails = admission.GetStudentDetails(admissionId, out string errorMsg);            

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Populate Stdent Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (studentDetails.Rows.Count == 1)
                {
                    DataRow studentDetailsRow = studentDetails.Rows[0];

                    this.labelRegistrationId.Text = studentDetailsRow.ItemArray[0].ToString();
                    this.firstFirstName.Text = studentDetailsRow.ItemArray[1].ToString();
                    this.labelLastName.Text = studentDetailsRow.ItemArray[2].ToString();
                    this.labelGender.Text = studentDetailsRow.ItemArray[3].ToString();
                    this.labelDateOfBirth.Text = DateTime.Parse(studentDetailsRow.ItemArray[4].ToString()).Date.ToString("dd.MM.yyyy");
                    this.labelMobilePhone.Text = studentDetailsRow.ItemArray[5].ToString();
                    this.labelEmail.Text = studentDetailsRow.ItemArray[6].ToString();
                    this.labelSemester.Text = studentDetailsRow.ItemArray[7].ToString();
                    this.labelCourse.Text = studentDetailsRow.ItemArray[8].ToString();
                    this.labelSchoolName.Text = studentDetailsRow.ItemArray[9].ToString();
                    this.labelEnlistDate.Text = DateTime.Parse(studentDetailsRow.ItemArray[10].ToString()).Date.ToString("dd.MM.yyyy");
                    this.labelAddress.Text = studentDetailsRow.ItemArray[11].ToString();
                }    
            }            
        }

        /// <summary>
        /// Clear the student data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.labelRegistrationId.Text = EmptyLabelText;
            this.firstFirstName.Text = EmptyLabelText;
            this.labelLastName.Text = EmptyLabelText;
            this.labelGender.Text = EmptyLabelText;
            this.labelDateOfBirth.Text = EmptyLabelText;
            this.labelMobilePhone.Text = EmptyLabelText;
            this.labelEmail.Text = EmptyLabelText;
            this.labelSemester.Text = EmptyLabelText;
            this.labelCourse.Text = EmptyLabelText;
            this.labelSchoolName.Text = EmptyLabelText;
            this.labelEnlistDate.Text = EmptyLabelText;
            this.labelAddress.Text = EmptyLabelText;
        }
    }
}
