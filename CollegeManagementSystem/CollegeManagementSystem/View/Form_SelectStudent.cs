namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_SelectStudent : Form
    {
        public Form_SelectStudent(Form_UpdateSemesters updateSemesters)
        {
            InitializeComponent();
            this.UpdateSemesters = updateSemesters;
        }

        public Form_UpdateSemesters UpdateSemesters { get; set; }

        // Load Form SelectStudent
        private void Form_SelectStudent_Load(object sender, EventArgs e)
        {
            int courseId = this.UpdateSemesters.CourseId;
            int year = this.UpdateSemesters.StartYear;
            int semesterId = this.UpdateSemesters.SemesterId;

            Admissions admissions = new Admissions();
            DataTable studentsTable = admissions.GetStudentsWithFees(courseId, year, semesterId, out string errorMsg);

            if (studentsTable.Rows.Count > 0)
            {
                if (errorMsg != string.Empty)
                {
                    MessageBox.Show(errorMsg,
                        "Select Students",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    this.dataGridView_SelectStudents.DataSource = studentsTable;
                    this.dataGridView_SelectStudents.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No Students Found",
                    "Select Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Close();
            }            
        }

        // Select student data and close the form.
        private void DataGridView_SelectStudents_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }        

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_SelectStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_SelectStudents
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_SelectStudents.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_SelectStudents.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_SelectStudents.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_SelectStudents.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_SelectStudents.ClearSelection();
        }
    }
}