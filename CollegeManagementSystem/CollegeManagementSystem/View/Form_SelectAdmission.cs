// <copyright file="Form_SelectAdmission.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// The main Form_SelectAdmission class.
    /// Contains methods for Form_SelectAdmission class.
    /// </summary>
    public partial class Form_SelectAdmission : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_SelectAdmission" /> class.
        /// </summary>
        public Form_SelectAdmission()
        {
            this.InitializeComponent();
            this.SelectedIndex = 0;
        }

        /// <summary>
        /// Gets or sets the selected index.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets the DataGridViewAdmissions data.
        /// </summary>
        public DataGridView DataGridViewAdmissions { get; set; }

        /// <summary>
        /// Load Form_SelectAdmission.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void FormSelectAdmission_Load(object sender, EventArgs e)
        {
            Admissions admission = new Admissions();
            DataTable admissionsTable = admission.GetAdmissionsData(out string errorMsg);            

            if (errorMsg != string.Empty)
            {
                MessageBox.Show(
                    errorMsg,
                    "Select All Admissions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridViewAdmissions.DataSource = admissionsTable;
                this.dataGridViewAdmissions.ClearSelection();
            }
        }

        /// <summary>
        /// Selects Admission data and close the form.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains event argument.</param>
        private void DataGridViewAdmissions_DoubleClick(object sender, EventArgs e)
        {
            this.SelectedIndex = int.Parse(this.dataGridViewAdmissions.CurrentRow.Cells["AdmissionId"].Value.ToString());
            this.DataGridViewAdmissions = this.dataGridViewAdmissions;
            this.Close();
        }

        /// <summary>
        /// Sorts the DataGridView by current column in ascending or descending order.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Contains DataGridViewCellMouseEventArgs event argument.</param>
        private void DataGridViewAdmissions_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridViewAdmissions
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridViewAdmissions.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridViewAdmissions.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridViewAdmissions.SortOrder == SortOrder.Ascending)
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
                this.dataGridViewAdmissions.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridViewAdmissions.ClearSelection();
            this.dataGridViewAdmissions.Rows[0].Selected = false;
            this.dataGridViewAdmissions.Columns[0].Selected = false;
        }
    }
}
