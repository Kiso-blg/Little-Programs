// <copyright file="Form_Fees.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_Fees class.
    /// Collect data for new fees in Form_Fees class.
    /// </summary>
    public partial class Form_Fees : Form
    {
        /// <summary>
        /// Contains an instance of object Admissions.
        /// </summary>
        private readonly Admissions admission = new Admissions();

        /// <summary>
        /// Contains the semester Id.
        /// </summary>
        private int semesterId = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Fees" /> class.
        /// </summary>
        public Form_Fees()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button Select Admission. Load Form_SelectAdmission.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSelectRegistrationId_Click(object sender, EventArgs e)
        {
            int admissionId;
            string name;
            string surname;
            string year;
            string semesterName;
            decimal fee;

            using (Form_SelectAdmission selectAdmission = new Form_SelectAdmission())
            {
                selectAdmission.ShowDialog();

                if (selectAdmission.SelectedIndex > 0)
                {
                    admissionId = int.Parse(selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
                    name = selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["Name"].Value.ToString();
                    surname = selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["Surname"].Value.ToString();
                    year = selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["Year"].Value.ToString();
                    this.semesterId = int.Parse(selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["SemesterId"].Value.ToString());
                    semesterName = selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["SemesterName"].Value.ToString();
                    fee = decimal.Parse(selectAdmission.DataGridViewAdmissions.CurrentRow.Cells["CourseFee"].Value.ToString());

                    this.labelRegistrationId.Text = admissionId.ToString();
                    this.labelName.Text = name;
                    this.labelSurname.Text = surname;
                    this.labelDate.Text = year;
                    this.labelSemester.Text = semesterName;
                    this.labelFee.Text = Math.Round(fee, 2).ToString();
                }                
            }            
        }

        /// <summary>
        /// Submit the data in Fees Table.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.labelRegistrationId.Text != "________")
            {
                if (this.labelSemester.Text != "Completed")
                {
                    int admissionNumber = int.Parse(this.labelRegistrationId.Text.Trim());

                    if (this.admission.IsTheTaxAlreadyPaid(admissionNumber, this.semesterId, out string errorMsg))
                    {
                        decimal fee = decimal.Parse(this.labelFee.Text);

                        if (this.admission.InsertFeeTax(admissionNumber, semesterId, fee, out errorMsg))
                        {
                            MessageBox.Show(
                                errorMsg,
                                "Semester Fee",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetLabels();
                        }
                        else
                        {
                            MessageBox.Show(
                                errorMsg,
                                "Semester Fee",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Semester Fee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        this.ResetLabels();
                    }
                }                
            }
        }

        /// <summary>
        /// Reset the labels to their start position.
        /// </summary>
        private void ResetLabels()
        {
            this.labelRegistrationId.Text = "________";
            this.labelName.Text = "________";
            this.labelSurname.Text = "________";
            this.labelDate.Text = "________";
            this.labelSemester.Text = "________";
            this.labelFee.Text = "________";
            this.semesterId = 0;
        }
    }
}
