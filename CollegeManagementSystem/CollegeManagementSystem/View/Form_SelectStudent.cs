// <copyright file="Form_SelectStudent.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SelectStudent class.
    /// Contains methods for Form_SelectStudent class.
    /// </summary>
    public partial class Form_SelectStudent : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SelectStudent" /> class.
        /// </summary>
        /// <param name="updateSemesters">Contains form type Form_UpdateSemesters</param>
        public Form_SelectStudent(Form_UpdateSemesters updateSemesters)
        {
            this.InitializeComponent();
            this.UpdateSemesters = updateSemesters;
        }

        /// <summary>
        /// Gets or sets the selected index.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets form type Form_UpdateSemesters.
        /// </summary>
        public Form_UpdateSemesters UpdateSemesters { get; set; }

        /// <summary>
        /// Gets or sets the DataGridViewSelectStudents data.
        /// </summary>
        public DataGridView DataGridViewSelectStudents { get; set; }

        /// <summary>
        /// Load Form_SelectStudent.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
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
                    MessageBox.Show(
                        errorMsg,
                        "Select Students",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    this.dataGridViewSelectStudents.DataSource = studentsTable;
                    this.dataGridViewSelectStudents.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show(
                    "No Students Found",
                    "Select Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Close();
            }            
        }

        /// <summary>
        /// Select student data and close the form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void DataGridViewSelectStudents_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridViewSelectStudents.CurrentRow.Cells["AdmissionId"].Value.ToString());
            this.DataGridViewSelectStudents = this.dataGridViewSelectStudents;
            this.Close();
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridView_SelectStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridViewSelectStudents
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridViewSelectStudents.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridViewSelectStudents.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridViewSelectStudents.SortOrder == SortOrder.Ascending)
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
                this.dataGridViewSelectStudents.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridViewSelectStudents.ClearSelection();
        }
    }
}
