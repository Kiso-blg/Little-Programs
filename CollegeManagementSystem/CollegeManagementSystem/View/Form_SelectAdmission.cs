namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form_SelectAdmission : Form
    {
        public Form_SelectAdmission()
        {
            InitializeComponent();
            this.SelectedIndex = 0;
        }

        public int SelectedIndex { get; set; }

        // Load Form SelectAdmission
        private void Form_SelectAdmission_Load(object sender, EventArgs e)
        {
            Admissions admission = new Admissions();
            DataTable admissionsTable = admission.GetAdmissionsData(out string errorMsg);            

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(errorMsg,
                    "Select All Admissions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView_Admissions.DataSource = admissionsTable;
                this.dataGridView_Admissions.ClearSelection();
            }
        }

        // Select Admission data and close the form.
        private void DataGridView_Admissions_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridView_Admissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
            this.Close();
        }       

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Admissions_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Admissions
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Admissions.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Admissions.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Admissions.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_Admissions.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Admissions.ClearSelection();
            this.dataGridView_Admissions.Rows[0].Selected = false;
            this.dataGridView_Admissions.Columns[0].Selected = false;
        }
    }
}