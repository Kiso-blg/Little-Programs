using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Csharp_Manage_Contacts
{
    public partial class Contact_Full_List_Form : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Contact_Full_List_Form()
        {
            InitializeComponent();
        }

        private readonly ManageContacts_DB db = new ManageContacts_DB();

        // Form Load
        private void Contact_Full_List_Form_Load(object sender, EventArgs e)
        {
            this.DataGridView_ContactsList.RowTemplate.Height = 80;

            // Populate the ListBox with Group Names
            GROUP group = new GROUP();
            this.ListBoxGroups.DataSource = group.GetGroups(Globals.GlobalUserId);
            this.ListBoxGroups.DisplayMember = "GroupName";
            this.ListBoxGroups.ValueMember = "GroupId";

            // Populate DataGridView with Contacts
            PopulateContactsInDataGridView();
        }

        // Populate All Contacts Method
        private void PopulateContactsInDataGridView()
        {
            Contact contact = new Contact();
            using (SqlCommand command = new SqlCommand("SelectAll", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int)).Value = Globals.GlobalUserId;
                this.DataGridView_ContactsList.DataSource = contact.SelectContactLists(command);
            }

            this.DataGridView_ContactsList.Columns["Picture"].Width = 80;
            DataGridViewImageColumn pictureCol = (DataGridViewImageColumn)this.DataGridView_ContactsList.Columns["Picture"];
            pictureCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            AlternateDataGridViewBackgroundColol();
        }

        // Button Close
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Minimize
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ListBox Click
        private void ListBoxGroups_Click(object sender, EventArgs e)
        {
            // Display the Contacts in the Selected Group
            Contact contact = new Contact();
            int groupId = (int)this.ListBoxGroups.SelectedValue;

            using (SqlCommand command = new SqlCommand("SelectAllByGroup", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int)).Value = Globals.GlobalUserId;
                command.Parameters.Add(new SqlParameter("@GroupId", SqlDbType.Int)).Value = groupId;
                this.DataGridView_ContactsList.DataSource = contact.SelectContactLists(command);
            }

            AlternateDataGridViewBackgroundColol();
        }

        // Show All Contacts
        private void Label_Show_All_Click(object sender, EventArgs e)
        {
            PopulateContactsInDataGridView();
        }

        // Alternate the DataGridView Background Color
        public void AlternateDataGridViewBackgroundColol()
        {
            for (int i = 0; i < this.DataGridView_ContactsList.Rows.Count; i++)
            {
                if ((i & 1) == 1)
                {
                    this.DataGridView_ContactsList.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                }
            }

            this.DataGridView_ContactsList.ClearSelection();
            this.textBoxAddress.Text = string.Empty;
        }

        // Alternate the DataGridView Background Color
        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AlternateDataGridViewBackgroundColol();
        }

        // Fulfill textBox Address
        private void DataGridView_Click(object sender, EventArgs e)
        {
            // Display the Address in the TextBox
            this.textBoxAddress.Text = this.DataGridView_ContactsList.CurrentRow.Cells["Address"].Value.ToString();
        }

        // Populate Contacts without Group
        private void Label_Contacts_Without_Group_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            using (SqlCommand command = new SqlCommand("SelectContactsWithoutGroup", db.GetConnection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int)).Value = Globals.GlobalUserId;
                this.DataGridView_ContactsList.DataSource = contact.SelectContactLists(command);
            }

            this.DataGridView_ContactsList.Columns["Picture"].Width = 80;
            DataGridViewImageColumn pictureCol = (DataGridViewImageColumn)this.DataGridView_ContactsList.Columns["Picture"];
            pictureCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            AlternateDataGridViewBackgroundColol();
        }

        // Function Move Form
        private void Panel_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }
    }
}