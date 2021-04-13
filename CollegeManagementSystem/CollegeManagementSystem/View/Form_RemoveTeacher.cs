namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_RemoveTeacher : Form
    {
        private const string EmptyLabelText = "________";

        public Form_RemoveTeacher()
        {
            InitializeComponent();
        }

        private readonly Teachers teachers = new Teachers();

        // Load Form SelectTeachers
        private void Button_SelectRegistrationId_Click(object sender, EventArgs e)
        {
            int teacherId;

            using (Form_SelectTeacher selectTeachers = new Form_SelectTeacher())
            {
                selectTeachers.ShowDialog();
                teacherId = selectTeachers.SelectedIndex;
            }

            if (teacherId > 0)
            {
                PopulateTeacherData(teacherId);
            }
        }

        // Populate the teacher data in the labels.
        private void PopulateTeacherData(int teacherId)
        {
            DataTable teacherData = teachers.GetTeacherById(teacherId, out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Populate Teacher Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (teacherData.Rows.Count == 1)
                {
                    DataRow teacherDataRow = teacherData.Rows[0];

                    this.label_RegistrationId.Text = teacherDataRow.ItemArray[0].ToString();
                    this.label_Name.Text = teacherDataRow.ItemArray[1].ToString();
                    this.label_Surname.Text = teacherDataRow.ItemArray[2].ToString();
                    this.label_BirthDate.Text = DateTime.Parse(teacherDataRow.ItemArray[4].ToString()).Date.ToString("dd.MM.yyyy");
                    this.label_MobilePhone.Text = teacherDataRow.ItemArray[5].ToString();
                    this.label_Email.Text = teacherDataRow.ItemArray[6].ToString();
                    this.label_Course.Text = teacherDataRow.ItemArray[8].ToString();
                }
            }
        }

        // Button Remove Teacher
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (this.label_RegistrationId.Text != EmptyLabelText)
            {
                int teacherId = int.Parse(this.label_RegistrationId.Text);

                if (teachers.DeleteTeacher(teacherId, out string errorMsg))
                {
                    MessageBox.Show(errorMsg,
                        "Delete Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearTheTeacherData();
                }
                else
                {
                    MessageBox.Show(errorMsg,
                        "Delete Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Button Clear Click Event
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ClearTheTeacherData();
        }

        // Reset the lables and clear the teacher data.
        private void ClearTheTeacherData()
        {
            this.label_RegistrationId.Text = EmptyLabelText;
            this.label_Name.Text = EmptyLabelText;
            this.label_Surname.Text = EmptyLabelText;
            this.label_BirthDate.Text = EmptyLabelText;
            this.label_MobilePhone.Text = EmptyLabelText;
            this.label_Email.Text = EmptyLabelText;
            this.label_Course.Text = EmptyLabelText;
        }
    }
}