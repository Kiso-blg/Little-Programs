namespace CollegeManagementSystem
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_StudentIndividualDetails : Form
    {
        private const string EmptyLabelText = "________";

        public Form_StudentIndividualDetails()
        {
            InitializeComponent();
        }

        // Button Search Student
        private void Button_SelectStudent_Click(object sender, EventArgs e)
        {
            int admissionId;

            using (Form_SelectAdmission selectAdmission = new Form_SelectAdmission())
            {
                selectAdmission.ShowDialog();
                //admissionId = int.Parse(selectAdmission.dataGridView_Admissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
                admissionId = selectAdmission.SelectedIndex;
            }

            if (admissionId > 0)
            {
                PopulateStudentDetails(admissionId);
            }            
        }

        // Populate the student data in the labels.
        private void PopulateStudentDetails(int admissionId)
        {
            Admissions admission = new Admissions();
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
                    this.label_LastName.Text = studentDetailsRow.ItemArray[2].ToString();
                    this.label_Gender.Text = studentDetailsRow.ItemArray[3].ToString();
                    this.label_DateOfBirth.Text = DateTime.Parse(studentDetailsRow.ItemArray[4].ToString()).Date.ToString("dd.MM.yyyy");
                    this.label_MobilePhone.Text = studentDetailsRow.ItemArray[5].ToString();
                    this.label_Email.Text = studentDetailsRow.ItemArray[6].ToString();
                    this.label_Semester.Text = studentDetailsRow.ItemArray[7].ToString();
                    this.label_Course.Text = studentDetailsRow.ItemArray[8].ToString();
                    this.label_SchoolName.Text = studentDetailsRow.ItemArray[9].ToString();
                    this.label_InlistDate.Text = DateTime.Parse(studentDetailsRow.ItemArray[10].ToString()).Date.ToString("dd.MM.yyyy");
                    this.label_Address.Text = studentDetailsRow.ItemArray[11].ToString();
                }    
            }            
        }

        // Clear the student data.
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            this.label_RegistrationId.Text = EmptyLabelText;
            this.label_Name.Text = EmptyLabelText;
            this.label_LastName.Text = EmptyLabelText;
            this.label_Gender.Text = EmptyLabelText;
            this.label_DateOfBirth.Text = EmptyLabelText;
            this.label_MobilePhone.Text = EmptyLabelText;
            this.label_Email.Text = EmptyLabelText;
            this.label_Semester.Text = EmptyLabelText;
            this.label_Course.Text = EmptyLabelText;
            this.label_SchoolName.Text = EmptyLabelText;
            this.label_InlistDate.Text = EmptyLabelText;
            this.label_Address.Text = EmptyLabelText;
        }
    }
}