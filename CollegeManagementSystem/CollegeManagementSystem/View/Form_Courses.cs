// <copyright file="Form_Courses.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_Courses class.
    /// Contains all controllers for Form_AddTeacher class.
    /// </summary>
    public partial class Form_Courses : Form
    {
        /// <summary>
        /// Contains an instance of object Course.
        /// </summary>
        private readonly Course course = new Course();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Courses" /> class.
        /// </summary>
        public Form_Courses()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Add new Course.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = this.textBoxCourseName.Text.Trim();
            string strCourseFee = this.textBoxFee.Text.Trim();

            if (courseName != string.Empty)
            {
                if (decimal.TryParse(strCourseFee, out decimal courseFee))
                {
                    if (this.course.AddNewCourse($"{courseName}", courseFee, out string errorMsg))
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Add New Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Add New Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }

                    this.textBoxCourseName.Clear();
                    this.textBoxFee.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Fee!",
                        "Add New Course",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "Enter the course name first.",
                    "Add New Course",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Edit course data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonEditCourse_Click(object sender, EventArgs e)
        {
            if (this.textBoxEditCourseName.Text != string.Empty && this.textBoxEditFee.Text != string.Empty)
            {
                if (decimal.TryParse(this.textBoxEditFee.Text, out decimal fee))
                {
                    int courseId = int.Parse(this.textBoxCourseId.Text.Trim());
                    string courseName = this.textBoxEditCourseName.Text.Trim();                    

                    if (this.course.UpdateCourse(courseId, courseName, fee, out string errorMsg))
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Edit Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.textBoxCourseId.Clear();
                        this.ClearCourseData();
                    }
                    else
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Edit Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Delete course data.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonDeleteCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBoxCourseId.Text.Trim(), out int courseId))
            {
                if (this.course.DeleteCourse(courseId, out string errorMsg))
                {
                    MessageBox.Show(
                        errorMsg,
                        "Delete Course",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.textBoxCourseId.Clear();
                    this.ClearCourseData();
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Delete Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }                    
                }
            }
        }

        /// <summary>
        /// Clear the textboxes textBox_EditCourseName and textBox_EditFee.
        /// </summary>
        private void ClearCourseData()
        {
            this.textBoxEditCourseName.Clear();
            this.textBoxEditFee.Clear();
        }

        /// <summary>
        /// Button Select Course. Load Form SelectCourse.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event arguments.</param>
        private void ButtonSelectCours_Click(object sender, EventArgs e)
        {
            int courseId;
            string courseName;
            decimal courseFee;

            using (Form_SelectCourse selectCourse = new Form_SelectCourse())
            {
                selectCourse.ShowDialog();

                if (selectCourse.SelectedIndex > 0)
                {
                    courseId = int.Parse(selectCourse.DataGridViewCourses.CurrentRow.Cells["CourseId"].Value.ToString());
                    courseName = selectCourse.DataGridViewCourses.CurrentRow.Cells["CourseName"].Value.ToString();
                    courseFee = decimal.Parse(selectCourse.DataGridViewCourses.CurrentRow.Cells["CourseFee"].Value.ToString());

                    this.textBoxCourseId.Text = courseId.ToString();
                    this.textBoxEditCourseName.Text = courseName;
                    this.textBoxEditFee.Text = Math.Round(courseFee, 2).ToString();
                }                
            }            
        }
    }
}
