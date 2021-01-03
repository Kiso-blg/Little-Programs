using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_AddBook : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_AddBook()
        {
            InitializeComponent();
        }

        // Button Save New Book
        private void Button_Save_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            string bookName = this.textBox_BookName.Text.Trim();
            string authorName = this.textBox_AuthorName.Text.Trim();
            string bookPublication = this.textBox_Publication.Text.Trim();
            DateTime purchaseDate = this.dateTimePicker.Value;
            string strBookPrice = this.textBox_BookPrice.Text.Trim();
            string strQuantity = this.textBox_BookQuantity.Text.Trim();

            if (book.IsDataValid(bookName, authorName, bookPublication, strBookPrice, strQuantity, out string errorMessage, out decimal bookPrice, out int bookQuantity))
            {
                if (book.InsertNewBook(bookName, authorName, bookPublication, purchaseDate, bookPrice, bookQuantity, out errorMessage))
                {
                    MessageBox.Show("Data Saved!", 
                        "Add New Book",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                }
                else
                {
                    MessageBox.Show(errorMessage,
                        "Add New Book",
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
                    + errorMessage,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Clear the TextBoxes Data
        private void ClearData()
        {
            this.textBox_BookName.Clear();
            this.textBox_AuthorName.Clear();
            this.textBox_Publication.Clear();
            this.dateTimePicker.ResetText();
            this.textBox_BookPrice.Clear();
            this.textBox_BookQuantity.Clear();
        }

        // Exit from Form AddBook.
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            if (this.textBox_BookName.Text != string.Empty 
                || this.textBox_AuthorName.Text != string.Empty 
                || this.textBox_Publication.Text != string.Empty 
                || this.textBox_BookPrice.Text != string.Empty 
                || this.textBox_BookQuantity.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure? This will delete your unsaved data",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }            
        }

        // Button Close
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form Move Function
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