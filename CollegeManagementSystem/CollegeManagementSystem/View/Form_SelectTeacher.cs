namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_SelectTeacher : Form
    {
        public Form_SelectTeacher()
        {
            InitializeComponent();
            this.SelectedIndex = 0;
        }

        public int SelectedIndex { get; set; }

        // Form Load
        private void Form_SelectTeacher_Load(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            DataTable teachersTable = teachers.GetTeachersData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                   "Select All Teachers",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView_Teachers.DataSource = teachersTable;
                this.dataGridView_Teachers.ClearSelection();
            }
        }

        // Select teacher id and close the form.
        private void DataGridView_Teachers_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridView_Teachers.CurrentRow.Cells["TeacherId"].Value.ToString());
            this.Close();
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Teachers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Teachers
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Teachers.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Teachers.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Teachers.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_Teachers.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Teachers.ClearSelection();
            this.dataGridView_Teachers.Rows[0].Selected = false;
            this.dataGridView_Teachers.Columns[0].Selected = false;
        }        
    }
}