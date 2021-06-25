// <copyright file="Form_SearchStudent.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SearchStudent class.
    /// Contains methods for Form_SearchStudent class.
    /// </summary>
    public partial class Form_SearchStudent : Form
    {
        /// <summary>
        /// Contains an instance of Admissions class.
        /// </summary>
        private readonly Admissions admission = new Admissions();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SearchStudent" /> class.
        /// </summary>
        public Form_SearchStudent()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Form load method.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void Form_SearchStudent_Load(object sender, EventArgs e)
        {
            this.PopulateDataGridView();            
        }

        /// <summary>
        /// Populates the DataGridView.
        /// </summary>
        private void PopulateDataGridView()
        {
            DataTable studentsTable = this.admission.GetStudentsData(out string errorMsg);

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Search Students",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridViewStudents.DataSource = studentsTable;
                this.dataGridViewStudents.ClearSelection();
            }
        }

        /// <summary>
        /// Searches student by id.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string strRegistrationId = this.textBoxRegistrationId.Text.Trim();

            if (strRegistrationId != string.Empty)
            {
                if (int.TryParse(strRegistrationId, out int id))
                {
                    DataTable studentTable = this.admission.GetStudentById(id, out string errorMsg);

                    if (errorMsg != string.Empty)
                    {
                        MessageBox.Show(
                            errorMsg,
                            "Search Student",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (studentTable.Rows.Count == 1)
                        {
                            this.dataGridViewStudents.DataSource = studentTable;
                            this.dataGridViewStudents.ClearSelection();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Invalid Input!",
                        "Search Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.PopulateDataGridView();
            }
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridViewStudents_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridViewStudents
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridViewStudents.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridViewStudents.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridViewStudents.SortOrder == SortOrder.Ascending)
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
                this.dataGridViewStudents.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridViewStudents.ClearSelection();
        }

        /// <summary>
        /// Clears TextBox RegistrationId and reload the DataGridView.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            this.textBoxRegistrationId.Clear();
            this.PopulateDataGridView();
        }
    }
}
