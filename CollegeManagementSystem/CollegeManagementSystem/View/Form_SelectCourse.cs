namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class Form_SelectCourse : Form
    {
        public Form_SelectCourse()
        {
            InitializeComponent();
        }

        // Form Load.
        private void Form_SelectCourse_Load(object sender, EventArgs e)
        {
            Course course = new Course();
            this.dataGridView_Courses.DataSource = course.GetAllCourses(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Select All Courses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView_Courses.ClearSelection();
            }            
        }

        // Close the Form after selecting a Course.
        private void DataGridView_Courses_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Courses_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Courses
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Courses.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Courses.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Courses.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_Courses.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Courses.ClearSelection();
        }
    }
}