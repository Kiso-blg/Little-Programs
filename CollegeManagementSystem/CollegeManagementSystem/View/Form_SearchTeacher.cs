// <copyright file="Form_SearchTeacher.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SearchTeacher class.
    /// Contains methods for Form_SearchTeacher class.
    /// </summary>
    public partial class Form_SearchTeacher : Form
    {
        /// <summary>
        /// Contains an instance of Teachers class.
        /// </summary>
        private readonly Teachers teachers = new Teachers();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SearchTeacher" /> class.
        /// </summary>
        public Form_SearchTeacher()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load Form_SearchTeacher.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void Form_SearchTeacher_Load(object sender, EventArgs e)
        {
            this.PopulateTheDataGridView();
        }

        /// <summary>
        /// Populates the DataGridView.
        /// </summary>
        private void PopulateTheDataGridView()
        {
            DataTable teachersTable = this.teachers.GetTeachersData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Search Teachers",
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
        /// Searches teacher by id.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string strRegistrationId = this.textBoxRegistrationId.Text.Trim();

            if (strRegistrationId != string.Empty)
            {
                if (int.TryParse(strRegistrationId, out int teacherId))
                {
                    DataTable table = this.teachers.GetTeacherById(teacherId, out string errorMsg);

                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(
                            "Invalid Input!",
                            "Search Teacher",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    if (table.Rows.Count == 1)
                    {
                        this.dataGridViewTeachers.DataSource = table;
                        this.dataGridViewTeachers.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Input!",
                        "Search Teacher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.PopulateTheDataGridView();
            }
        }

        /// <summary>
        /// Clears the TextBox RegistrationId and reload the DataGridView.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.textBoxRegistrationId.Clear();
            this.PopulateTheDataGridView();
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridViewTeachers_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
        }
    }
}
