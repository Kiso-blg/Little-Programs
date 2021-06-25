// <copyright file="Form_SelectTeacher.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SelectTeacher class.
    /// Contains methods for Form_SelectTeacher class.
    /// </summary>
    public partial class Form_SelectTeacher : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SelectTeacher" /> class.
        /// </summary>
        public Form_SelectTeacher()
        {
            this.InitializeComponent();
            this.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets or sets the selected index.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Load Form_SelectTeacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void Form_SelectTeacher_Load(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            DataTable teachersTable = teachers.GetTeachersData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                   "Select All Teachers",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridViewTeachers.DataSource = teachersTable;
                this.dataGridViewTeachers.ClearSelection();
            }
        }

        /// <summary>
        /// Select teacher id and close the form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void DataGridViewTeachers_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridViewTeachers.CurrentRow.Cells["TeacherId"].Value.ToString());
            this.Close();
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridViewTeachers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridViewTeachers
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridViewTeachers.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridViewTeachers.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridViewTeachers.SortOrder == SortOrder.Ascending)
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
                this.dataGridViewTeachers.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridViewTeachers.ClearSelection();
            this.dataGridViewTeachers.Rows[0].Selected = false;
            this.dataGridViewTeachers.Columns[0].Selected = false;
        }        
    }
}
