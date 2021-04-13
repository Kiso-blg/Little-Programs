namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    public partial class Form_Courses : Form
    {
        public Form_Courses()
        {
            InitializeComponent();
        }

        private readonly Course course = new Course();

        // Add new Course.
        private void Button_AddCourse_Click(object sender, EventArgs e)
        {
            string courseName = this.textBox_CourseName.Text.Trim();
            string strCourseFee = this.textBox_Fee.Text.Trim();

            if (courseName != string.Empty)
            {
                if (decimal.TryParse(strCourseFee, out decimal courseFee))
                {
                    if (course.AddNewCourse(courseName, courseFee, out string errorMsg))
                    {
                        MessageBox.Show(errorMsg,
                            "Add New Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "Add New Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }

                    this.textBox_CourseName.Clear();
                    this.textBox_Fee.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Fee!",
                        "Add New Course",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter the course name first.",
                    "Add New Course",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Edint course data.
        private void Button_EditCourse_Click(object sender, EventArgs e)
        {
            if (this.textBox_EditCourseName.Text != string.Empty && this.textBox_EditFee.Text != string.Empty)
            {
                if (decimal.TryParse(this.textBox_EditFee.Text, out decimal fee))
                {
                    int courseId = int.Parse(this.textBox_CourseId.Text.Trim());
                    string courseName = this.textBox_EditCourseName.Text.Trim();                    

                    if (course.UpdateCourse(courseId, courseName, fee, out string errorMsg))
                    {
                        MessageBox.Show(errorMsg,
                            "Edit Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.textBox_CourseId.Clear();
                        ClearCourseData();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "Edit Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Delete course data.
        private void Button_DeleteCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBox_CourseId.Text.Trim(), out int courseId))
            {
                if (course.DeleteCourse(courseId, out string errorMsg))
                {
                    MessageBox.Show(errorMsg,
                        "Delete Course",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.textBox_CourseId.Clear();
                    ClearCourseData();
                }
                else
                {
                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(errorMsg,
                            "Delete Course",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }                    
                }
            }
        }

        // Clear the textboxes textBox_EditCourseName and textBox_EditFee.
        private void ClearCourseData()
        {
            this.textBox_EditCourseName.Clear();
            this.textBox_EditFee.Clear();
        }

        // Button Select Course. Load Form SelectCourse.
        private void Button_SelectCours_Click(object sender, EventArgs e)
        {
            int courseId;
            string courseName;
            decimal courseFee;

            using (Form_SelectCourse selectCourse = new Form_SelectCourse())
            {
                selectCourse.ShowDialog();
                courseId = int.Parse(selectCourse.dataGridView_Courses.CurrentRow.Cells["CourseId"].Value.ToString());
                courseName = selectCourse.dataGridView_Courses.CurrentRow.Cells["CourseName"].Value.ToString();
                courseFee = decimal.Parse(selectCourse.dataGridView_Courses.CurrentRow.Cells["CourseFee"].Value.ToString());
            }

            this.textBox_CourseId.Text = courseId.ToString();
            this.textBox_EditCourseName.Text = courseName;
            this.textBox_EditFee.Text = Math.Round(courseFee, 2).ToString();
        }
    }
}