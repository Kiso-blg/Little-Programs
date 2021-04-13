namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_SearchStudent : Form
    {
        public Form_SearchStudent()
        {
            InitializeComponent();
        }

        private readonly Admissions admission = new Admissions();

        // Load Form.
        private void Form_SearchStudent_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();            
        }

        // Populate the DataGreidView.
        private void PopulateDataGridView()
        {
            DataTable studentsTable = admission.GetStudentsData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Search Students",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView_Students.DataSource = studentsTable;
                this.dataGridView_Students.ClearSelection();
            }
        }

        // Button Search Student by Id
        private void Button_Search_Click(object sender, EventArgs e)
        {
            string strRegistrationId = this.textBox_RegistrationId.Text.Trim();

            if (strRegistrationId != string.Empty)
            {
                if (int.TryParse(strRegistrationId, out int id))
                {
                    DataTable studentTable = admission.GetStudentById(id, out string errorMsg);

                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(errorMsg,
                            "Search Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (studentTable.Rows.Count == 1)
                        {
                            this.dataGridView_Students.DataSource = studentTable;
                            this.dataGridView_Students.ClearSelection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!",
                        "Search Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                PopulateDataGridView();
            }
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Students_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Students
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Students.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Students.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Students.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If new column is selected, sort by new column.
            if (newColumn != null)
            {
                this.dataGridView_Students.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Students.ClearSelection();
        }

        // Clear TextBox RegistrationId and reload the DataGridView.
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            this.textBox_RegistrationId.Clear();
            PopulateDataGridView();
        }
    }
}