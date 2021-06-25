// <copyright file="Form_SelectCourse.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SelectCourse class.
    /// Contains methods for Form_SelectCourse class.
    /// </summary>
    public partial class Form_SelectCourse : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SelectCourse" /> class.
        /// </summary>
        public Form_SelectCourse()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the selected index.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets the DataGridViewCourses data.
        /// </summary>
        public DataGridView DataGridViewCourses { get; set; }

        /// <summary>
        /// Load Form_SelectCourse_Load.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void Form_SelectCourse_Load(object sender, EventArgs e)
        {
            Course course = new Course();
            this.dataGridViewCourses.DataSource = course.GetAllCourses(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Select All Courses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridViewCourses.ClearSelection();
            }            
        }

        /// <summary>
        /// Close the Form after selecting a Course.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void DataGridViewCourses_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridViewCourses.CurrentRow.Cells["CourseId"].Value.ToString());
            this.DataGridViewCourses = this.dataGridViewCourses;
            this.Close();
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridViewCourses_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridViewCourses
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridViewCourses.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridViewCourses.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridViewCourses.SortOrder == SortOrder.Ascending)
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
                this.dataGridViewCourses.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridViewCourses.ClearSelection();
        }
    }
}
