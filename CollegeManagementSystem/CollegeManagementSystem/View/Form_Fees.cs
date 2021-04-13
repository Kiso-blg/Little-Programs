namespace CollegeManagementSystem
{
    using System;
    using System.Windows.Forms;

    public partial class Form_Fees : Form
    {
        public Form_Fees()
        {
            InitializeComponent();
        }

        private readonly Admissions admission = new Admissions();
        int semesterId = 0;

        // Button Select Admission. Load Form_SelectAdmission.
        private void Button_SelectRegistrationId_Click(object sender, EventArgs e)
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
                admissionId = int.Parse(selectAdmission.dataGridView_Admissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
                name = selectAdmission.dataGridView_Admissions.CurrentRow.Cells["Name"].Value.ToString();
                surname = selectAdmission.dataGridView_Admissions.CurrentRow.Cells["Surname"].Value.ToString();
                year = selectAdmission.dataGridView_Admissions.CurrentRow.Cells["Year"].Value.ToString();
                this.semesterId = int.Parse(selectAdmission.dataGridView_Admissions.CurrentRow.Cells["SemesterId"].Value.ToString());
                semesterName = selectAdmission.dataGridView_Admissions.CurrentRow.Cells["SemesterName"].Value.ToString();   
                fee = decimal.Parse(selectAdmission.dataGridView_Admissions.CurrentRow.Cells["CourseFee"].Value.ToString());
            }

            this.label_RegistrationId.Text = admissionId.ToString();
            this.label_Name.Text = name;
            this.label_Surname.Text = surname;
            this.label_Date.Text = year;
            this.label_Semester.Text = semesterName;
            this.label_Fee.Text = Math.Round(fee, 2).ToString();
        }

        // Submit the data in Fees Table.
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (this.label_RegistrationId.Text != "________")
            {
                if (this.label_Semester.Text != "Completed")
                {
                    int admissionNumber = int.Parse(this.label_RegistrationId.Text.Trim());

                    if (admission.IsTheTaxAlreadyPaid(admissionNumber, this.semesterId, out string errorMsg))
                    {
                        decimal fee = decimal.Parse(this.label_Fee.Text);

                        if (admission.InsertFeeTax(admissionNumber, semesterId, fee, out errorMsg))
                        {
                            MessageBox.Show(errorMsg,
                                "Semester Fee",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetLabels();
                        }
                        else
                        {
                            MessageBox.Show(errorMsg,
                                "Semester Fee",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMsg,
                            "Semester Fee",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        ResetLabels();
                    }
                }                
            }
        }        

        // Reset the lables to their start position.
        private void ResetLabels()
        {
            this.label_RegistrationId.Text = "________";
            this.label_Name.Text = "________";
            this.label_Surname.Text = "________";
            this.label_Date.Text = "________";
            this.label_Semester.Text = "________";
            this.label_Fee.Text = "________";
            this.semesterId = 0;
        }
    }
}