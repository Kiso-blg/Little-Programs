// <copyright file="Form_RemoveStudent.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_RemoveStudent class.
    /// Contains methods for Form_RemoveStudent class.
    /// </summary>
    public partial class Form_RemoveStudent : Form
    {
        /// <summary>
        /// Contains pattern for the empty labels.
        /// </summary>
        private const string EmptyLabelText = "________";

        /// <summary>
        /// Contains an instance of Admissions class.
        /// </summary>
        private readonly Admissions admission = new Admissions();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_RemoveStudent" /> class.
        /// </summary>
        public Form_RemoveStudent()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Select student. Load Form_SelectAdmission.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSelectRegistrationId_Click(object sender, EventArgs e)
        {
            int admissionId;
            
            using (Form_SelectAdmission selectAdmission = new Form_SelectAdmission())
            {
                selectAdmission.ShowDialog();
                admissionId = selectAdmission.SelectedIndex;              
            }

            if (admissionId > 0)
            {
                this.PopulateTheStudentData(admissionId);
            }            
        }

        /// <summary>
        /// Populates the student data in the labels.
        /// </summary>
        /// <param name="admissionId">Contains admission id.</param>
        private void PopulateTheStudentData(int admissionId)
        {
            DataTable studentDetails = this.admission.GetStudentDetails(admissionId, out string errorMsg);

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
                    this.labelName.Text = studentDetailsRow.ItemArray[1].ToString();
                    this.labelSurname.Text = studentDetailsRow.ItemArray[2].ToString();
                    this.labelEnlistDate.Text = DateTime.Parse(studentDetailsRow.ItemArray[10].ToString()).Date.ToString("dd.MM.yyyy");

                    string semesterName = studentDetailsRow.ItemArray[7].ToString();
                    this.labelSemester.Text = semesterName;

                    if (semesterName == "Completed")
                    {
                        this.labelSemester.ForeColor = Color.Green;
                    }
                    else
                    {
                        this.labelSemester.ForeColor = Color.Red;
                    }
                }
            }
        }

        /// <summary>
        /// Remove student.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.labelSemester.ForeColor == Color.Red)
            {
                if (MessageBox.Show(
                    "Are you sure? The student hasn't comeplete his education!",
                    "Delete Student",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    this.ClearTheStudentData();
                }
            }

            if (this.labelRegistrationId.Text != "________")
            {
                int admissionId = int.Parse(this.labelRegistrationId.Text);

                if (this.admission.DeleteStudent(admissionId, out string errorMsg))
                {
                    MessageBox.Show(
                        errorMsg,
                        "Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.ClearTheStudentData();
                }
                else
                {
                    MessageBox.Show(
                        errorMsg,
                        "Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Invokes ClearTheStudentData() method.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearTheStudentData();
        }

        /// <summary>
        /// Reset the labels to their start position.
        /// </summary>
        private void ClearTheStudentData()
        {
            this.labelRegistrationId.Text = EmptyLabelText;
            this.labelName.Text = EmptyLabelText;
            this.labelSurname.Text = EmptyLabelText;
            this.labelEnlistDate.Text = EmptyLabelText;
            this.labelSemester.Text = EmptyLabelText;
            this.labelSemester.ForeColor = Color.Black;
        }        
    }
}
