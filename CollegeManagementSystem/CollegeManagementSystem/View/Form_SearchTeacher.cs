namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_SearchTeacher : Form
    {
        public Form_SearchTeacher()
        {
            InitializeComponent();
        }

        private readonly Teachers teachers = new Teachers();

        // Form Load
        private void Form_SearchTeacher_Load(object sender, EventArgs e)
        {
            PopulateTheDataGridView();
        }

        // Populate the DataGreidView.
        private void PopulateTheDataGridView()
        {
            DataTable teachersTable = teachers.GetTeachersData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Search Teachers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView_Teachers.DataSource = teachersTable;
                this.dataGridView_Teachers.ClearSelection();
            }
        }

        // Button Search Teacher by Id.
        private void Button_Search_Click(object sender, EventArgs e)
        {
            string strRegistrationId = this.textBox_RegistrationId.Text.Trim();

            if (strRegistrationId != string.Empty)
            {
                if (int.TryParse(strRegistrationId, out int teacherId))
                {
                    DataTable table = teachers.GetTeacherById(teacherId, out string errorMsg);

                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show("Invalid Input!",
                            "Search Teacher",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    if (table.Rows.Count == 1)
                    {
                        this.dataGridView_Teachers.DataSource = table;
                        this.dataGridView_Teachers.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!",
                        "Search Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                PopulateTheDataGridView();
            }
        }

        // Clear the TextBox RegistrationId and reload the DataGridView.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            this.textBox_RegistrationId.Clear();
            PopulateTheDataGridView();
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Teachers_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
        }
    }
}