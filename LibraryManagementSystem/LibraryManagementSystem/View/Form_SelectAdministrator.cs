using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_SelectAdministrator : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_SelectAdministrator()
        {
            InitializeComponent();
        }

        // Form Load
        private void Form_SelectAdministrator_Load(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            //Form_DeleteAdministrator deleteAdmin = new Form_DeleteAdministrator();
            using (Form_DeleteAdministrator deleteAdmin = new Form_DeleteAdministrator())
            {
                int administrationId = deleteAdmin.GetAdministrationId();
                DataTable table = administrator.SelectAllAdministrators(administrationId, out string message);

                if (table.Rows.Count > 0)
                {
                    this.dataGridView_Administrators.DataSource = table;
                    this.dataGridView_Administrators.ClearSelection();
                }
                else
                {
                    if (message != string.Empty)
                    {
                        MessageBox.Show(message,
                            "Select Administrators",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }             
        }

        // Close the form and go back to Form Login.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }        

        // Sort the DataGridView by current column in ascending or descending order.
        private void DataGridView_Administrators_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sortedcolumn?view=net-5.0
            DataGridViewColumn newColumn = this.dataGridView_Administrators
                .Columns
                .GetColumnCount(DataGridViewElementStates.Selected) == 1 ?
                this.dataGridView_Administrators.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = this.dataGridView_Administrators.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sorf the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    this.dataGridView_Administrators.SortOrder == SortOrder.Ascending)
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
                this.dataGridView_Administrators.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }

            this.dataGridView_Administrators.ClearSelection();
        }

        // Form move function.
        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }

        // Close the form after selecting an administrator.
        private void DataGridView_Administrators_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}