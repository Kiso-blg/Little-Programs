// <copyright file="Form_RemoveTeacher.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_RemoveTeacher class.
    /// Contains methods for Form_RemoveTeacher class.
    /// </summary>
    public partial class Form_RemoveTeacher : Form
    {
        /// <summary>
        /// Contains pattern for the empty labels.
        /// </summary>
        private const string EmptyLabelText = "________";

        /// <summary>
        /// Contains an instance of Teachers class.
        /// </summary>
        private readonly Teachers teachers = new Teachers();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_RemoveTeacher" /> class.
        /// </summary>
        public Form_RemoveTeacher()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load Form_SelectTeachers.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSelectRegistrationId_Click(object sender, EventArgs e)
        {
            int teacherId;

            using (Form_SelectTeacher selectTeachers = new Form_SelectTeacher())
            {
                selectTeachers.ShowDialog();
                teacherId = selectTeachers.SelectedIndex;
            }

            if (teacherId > 0)
            {
                this.PopulateTeacherData(teacherId);
            }
        }

        /// <summary>
        /// Populates the teacher data in the labels.
        /// </summary>
        /// <param name="teacherId">Contains teacher id.</param>
        private void PopulateTeacherData(int teacherId)
        {
            DataTable teacherData = teachers.GetTeacherById(teacherId, out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Populate Teacher Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (teacherData.Rows.Count == 1)
                {
                    DataRow teacherDataRow = teacherData.Rows[0];

                    this.labelRegistrationId.Text = teacherDataRow.ItemArray[0].ToString();
                    this.labelName.Text = teacherDataRow.ItemArray[1].ToString();
                    this.labelSurname.Text = teacherDataRow.ItemArray[2].ToString();
                    this.labelBirthDate.Text = DateTime.Parse(teacherDataRow.ItemArray[4].ToString()).Date.ToString("dd.MM.yyyy");
                    this.labelMobilePhone.Text = teacherDataRow.ItemArray[5].ToString();
                    this.labelEmail.Text = teacherDataRow.ItemArray[6].ToString();
                    this.labelCourse.Text = teacherDataRow.ItemArray[8].ToString();
                }
            }
        }

        /// <summary>
        /// Remove teacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (this.labelRegistrationId.Text != EmptyLabelText)
            {
                int teacherId = int.Parse(this.labelRegistrationId.Text);

                if (teachers.DeleteTeacher(teacherId, out string errorMsg))
                {
                    MessageBox.Show(
                        errorMsg,
                        "Delete Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.ClearTheTeacherData();
                }
                else
                {
                    MessageBox.Show(
                        errorMsg,
                        "Delete Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Invokes method ClearTheTeacherData.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.ClearTheTeacherData();
        }

        /// <summary>
        /// Reset the labels and clear the teacher data.
        /// </summary>
        private void ClearTheTeacherData()
        {
            this.labelRegistrationId.Text = EmptyLabelText;
            this.labelName.Text = EmptyLabelText;
            this.labelSurname.Text = EmptyLabelText;
            this.labelBirthDate.Text = EmptyLabelText;
            this.labelMobilePhone.Text = EmptyLabelText;
            this.labelEmail.Text = EmptyLabelText;
            this.labelCourse.Text = EmptyLabelText;
        }
    }
}
