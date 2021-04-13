namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form_RemoveStudent : Form
    {
        private const string EmptyLabelText = "________";

        public Form_RemoveStudent()
        {
            InitializeComponent();
        }   
        
        readonly Admissions admission = new Admissions();

        // Button Select Studenr. Load Form_SelectAdmission.
        private void Button_SelectRegistrationId_Click(object sender, EventArgs e)
        {
            int admissionId;
            
            using (Form_SelectAdmission selectAdmission = new Form_SelectAdmission())
            {
                selectAdmission.ShowDialog();
                admissionId = selectAdmission.SelectedIndex;              
            }

            if (admissionId > 0)
            {
                PopulateTheStudentData(admissionId);
            }            
        }

        // Populate the student data in the labels.
        private void PopulateTheStudentData(int admissionId)
        {
            DataTable studentDetails = admission.GetStudentDetails(admissionId, out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Populate Stdent Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (studentDetails.Rows.Count == 1)
                {
                    DataRow studentDetailsRow = studentDetails.Rows[0];

                    this.label_RegistrationId.Text = studentDetailsRow.ItemArray[0].ToString();
                    this.label_Name.Text = studentDetailsRow.ItemArray[1].ToString();
                    this.label_Surname.Text = studentDetailsRow.ItemArray[2].ToString();
                    this.label_Date.Text = DateTime.Parse(studentDetailsRow.ItemArray[10].ToString()).Date.ToString("dd.MM.yyyy");

                    string semesterName = studentDetailsRow.ItemArray[7].ToString();
                    this.label_Semester.Text = semesterName;

                    if (semesterName == "Completed")
                    {
                        this.label_Semester.ForeColor = Color.Green;
                    }
                    else
                    {
                        this.label_Semester.ForeColor = Color.Red;
                    }
                }
            }
        }

        // Button Remove Student
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (this.label_Semester.ForeColor == Color.Red)
            {
                if (MessageBox.Show("Are you sure? The student hasn't comeplete his education!",
                    "Delete Student",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    ClearTheStudentData();
                }
            }

            if (this.label_RegistrationId.Text != "________")
            {
                int admissionId = int.Parse(this.label_RegistrationId.Text);
                Admissions admission = new Admissions();

                if (admission.DeleteStudent(admissionId, out string errorMsg))
                {
                    MessageBox.Show(errorMsg,
                        "Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearTheStudentData();
                }
                else
                {
                    MessageBox.Show(errorMsg,
                        "Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Button Clear Click Event
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ClearTheStudentData();
        }

        // Reset the lables to their start position.
        private void ClearTheStudentData()
        {
            this.label_RegistrationId.Text = EmptyLabelText;
            this.label_Name.Text = EmptyLabelText;
            this.label_Surname.Text = EmptyLabelText;
            this.label_Date.Text = EmptyLabelText;
            this.label_Semester.Text = EmptyLabelText;
            this.label_Semester.ForeColor = Color.Black;
        }        
    }
}