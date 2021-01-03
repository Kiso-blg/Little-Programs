using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_ReturnBook : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_ReturnBook()
        {
            InitializeComponent();
        }

        static readonly IssueBook issueBook = new IssueBook();
        private int bookId;
        private string studentNumber;

        // Form Load.
        private void Form_ReturnBook_Load(object sender, EventArgs e)
        {
            this.Size = new Size(985, 395);
            PopulateDataGridView();
        }

        // Populate the DataGridView.
        private void PopulateDataGridView()
        {
            DataTable table = issueBook.GetStudentAndNotReturnedBooks(out string errorMessage);

            if (table.Rows.Count > 0)
            {
                this.dataGridView_AllBooks.DataSource = table;
                this.dataGridView_AllBooks.ClearSelection();
            }
            else
            {
                MessageBox.Show("No table found!"
                    + Environment.NewLine
                    + errorMessage,
                    "Load Students and Books",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Button search Student by student number.
        private void Button_SearchStudent_Click(object sender, EventArgs e)
        {
            if (this.textBox_EnrollmentNo.Text != string.Empty)
            {
                string enrollmentNo = this.textBox_EnrollmentNo.Text.Trim();
                DataTable table = issueBook.GetNotReturnedBooksByStudentNo(enrollmentNo, out string errorMessage);

                if (table.Rows.Count > 0)
                {
                    this.dataGridView_AllBooks.DataSource = table;
                    this.dataGridView_AllBooks.ClearSelection();
                }
                else
                {
                    if (errorMessage != string.Empty)
                    {
                        MessageBox.Show("No table found!"
                        + Environment.NewLine
                        + errorMessage,
                        "Load Students and Books",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The student has no issued books!",
                       "Load Students and Books",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_AllBooks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_AllBooks
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_AllBooks.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_AllBooks.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_AllBooks.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_AllBooks.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_AllBooks.ClearSelection();
        }

        // Close the Form.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Reload the Form.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Form_ReturnBook_Load(this, null);
        }

        // Select book from the DataGridView.
        private void DataGridView_AllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_AllBooks.SelectedCells != null)
            {
                if (e.RowIndex > -1)
                {
                    this.bookId = int.Parse(this.dataGridView_AllBooks.Rows[e.RowIndex].Cells["Book Id"].Value.ToString());
                    this.studentNumber = this.dataGridView_AllBooks.Rows[e.RowIndex].Cells["Student Number"].Value.ToString();
                    string bookName = this.dataGridView_AllBooks.Rows[e.RowIndex].Cells["Book Name"].Value.ToString();
                    string bookIssueDate = this.dataGridView_AllBooks.Rows[e.RowIndex].Cells["Book Issue Date"].Value.ToString();
                    string bookReturnDate = this.dataGridView_AllBooks.Rows[e.RowIndex].Cells["Book Return Date"].Value.ToString();
                    this.textBox_BookName.Text = bookName;
                    this.textBox_BookIssueDate.Text = bookIssueDate;

                    if (bookReturnDate != string.Empty)
                    {
                        this.dateTimePicker_BookReturnDate.Value = DateTime.Parse(bookReturnDate);
                        this.dateTimePicker_BookReturnDate.Enabled = false;
                        this.Button_Return.Enabled = false;
                    }
                    else
                    {
                        this.dateTimePicker_BookReturnDate.Value = DateTime.Now.Date;
                        this.dateTimePicker_BookReturnDate.MinDate = DateTime.Parse(bookIssueDate).Date;
                        this.dateTimePicker_BookReturnDate.Enabled = true;
                        this.Button_Return.Enabled = true;
                    }
                }
            }

            this.panel_BookData.Visible = true;
            this.Size = new Size(985, 550);
        }

        // Cancel returning the book.
        private void Button_Cancel_Click(object sender, EventArgs e)
        {           
            this.panel_BookData.Visible = false;
            this.Size = new Size(985, 395);
        }

        // Return Book.
        private void Button_Return_Click(object sender, EventArgs e)
        {
            DateTime returnDate = this.dateTimePicker_BookReturnDate.Value.Date;

            if (issueBook.ReturnBook(this.bookId, this.studentNumber, returnDate, out string errorMessage))
            {
                MessageBox.Show(errorMessage,
                       "Return Book",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                PopulateDataGridView();
                Button_Cancel_Click(this, null);
            }
            else
            {
                MessageBox.Show(errorMessage,
                       "Return Book",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        // Move the form on mouse left button hold.
        private void Panel_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}