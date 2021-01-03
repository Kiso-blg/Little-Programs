using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_ViewBook : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_ViewBook()
        {
            InitializeComponent();
        }

        readonly Book book = new Book();
        private int currentBookId;

        // Form Load
        private void Form_ViewBook_Load(object sender, EventArgs e)
        {
            this.panel_BookData.Visible = false;
            FillDataGridView();                      
        }

        // Fill the DataGridView.
        private void FillDataGridView()
        {
            DataTable table = this.book.GetAllBooks(out string errorMessage);

            if (table.Rows.Count > 0)
            {
                this.dataGridView_BooksTable.DataSource = table;
                this.dataGridView_BooksTable.ClearSelection();
            }
            else
            {
                MessageBox.Show("No table found!"
                    + Environment.NewLine
                    + errorMessage,
                    "Load Books",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Select a book and show its data in the panel Book Data.
        private void DataGridView_BooksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_BooksTable.SelectedCells != null)
            {
                if (e.RowIndex > -1)
                {
                    int bookId = Convert.ToInt32(this.dataGridView_BooksTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                    DataTable table = this.book.GetCurrentBook(bookId, out string errorMessage);
                    FillBookData(table, errorMessage);
                    this.panel_BookData.Visible = true;
                    this.Size = new Size(964, 660);
                }
                else
                {
                    this.panel_BookData.Visible = false;
                    this.Size = new Size(964, 415);
                }
            }
            else
            {
                this.panel_BookData.Visible = false;
                this.Size = new Size(964, 415);
            }
        }

        // Fill the selected book data in the panel Book Data.
        private void FillBookData(DataTable table, string errorMessage)
        {
            if (table.Rows.Count > 0)
            {
                this.textBox_BookName.Text = table.Rows[0]["BookName"].ToString();
                this.textBox_BookAuthorName.Text = table.Rows[0]["BookAuthor"].ToString();
                this.textBox_BookPublication.Text = table.Rows[0]["BookPublication"].ToString();
                this.dateTimePicker_BookPurchaseDate.Text = table.Rows[0]["BookPurchaseDate"].ToString();
                this.textBox_BookPrice.Text = table.Rows[0]["BookPrice"].ToString();
                this.textBox_BookQuantity.Text = table.Rows[0]["BookQuantity"].ToString();
                this.currentBookId = int.Parse(table.Rows[0]["BookId"].ToString());
            }
            else
            {
                MessageBox.Show(errorMessage,
                    "Select Book",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_BooksTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_BooksTable
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_BooksTable.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_BooksTable.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_BooksTable.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_BooksTable.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }
            
            this.dataGridView_BooksTable.ClearSelection();
        }

        // When Cancel hide the book data.
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.panel_BookData.Visible = false;
            this.Size = new Size(964, 415);
        }

        // Search book by book name.
        private void TextBox_SearchBook_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_SearchBook.Text != string.Empty)
            {
                string nameToContain = this.textBox_SearchBook.Text.Trim();
                DataTable table = this.book.GetBooksByCurrentText(nameToContain, out string errorMessage);

                if (table.Rows.Count > 0)
                {
                    this.dataGridView_BooksTable.DataSource = table;
                    this.dataGridView_BooksTable.ClearSelection();
                }
                else
                {
                    MessageBox.Show(errorMessage + "Or No tables found!",
                        "Load Books",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Refresh the book data and the DataGridView.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {            
            this.textBox_SearchBook.Text = string.Empty;
            FillDataGridView();
            this.panel_BookData.Visible = false;
            this.Size = new Size(964, 415);
        }

        // Update the book data.
        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure? The book data will be changed permanently!",
                "Update Book",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bookName = this.textBox_BookName.Text.Trim();
                string authorName = this.textBox_BookAuthorName.Text.Trim();
                string bookPublication = this.textBox_BookPublication.Text.Trim();
                DateTime purchaseDate = this.dateTimePicker_BookPurchaseDate.Value;
                string strBookPrice = this.textBox_BookPrice.Text.Trim();
                string strQuantity = this.textBox_BookQuantity.Text.Trim();

                if (book.IsDataValid(bookName, authorName, bookPublication, strBookPrice, strQuantity, out string invalidFields, out decimal bookPrice, out int bookQuantity))
                {
                    if (this.book.UpdateBook(bookName, authorName, bookPublication, purchaseDate, bookPrice, bookQuantity, this.currentBookId, out string errorMessage))
                    {
                        MessageBox.Show(errorMessage,
                            "Update Book",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        FillDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Could Not Update the Book Data!"
                            + Environment.NewLine
                            + errorMessage,
                            "Update Book",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!"
                        + Environment.NewLine
                        + "The next Fields are Incorrect:"
                        + Environment.NewLine
                        + invalidFields,
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            } 
        }

        // Delete the selected book.
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();

            if (MessageBox.Show("Are you sure, you want to delete the book?",
                "Delete Book",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (!issueBook.IsBookIssued(this.currentBookId, out string errorMessage))
                {
                    if (issueBook.DeleteRecordsFromIssueReturnBookTable(this.currentBookId, out errorMessage))
                    {
                        if (this.book.DeleteBook(this.currentBookId, out errorMessage))
                        {
                            MessageBox.Show(errorMessage,
                                "Delete Book",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            FillDataGridView();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage,
                                "Delete Book",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage,
                            "Delete Book",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }                    
                }
                else
                {
                    MessageBox.Show("Could not delete the book!"
                        + Environment.NewLine
                        + errorMessage,
                        "Delete Book",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }  
        }

        // Close ViewBook from.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Move the form on mouse left button hold.
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}