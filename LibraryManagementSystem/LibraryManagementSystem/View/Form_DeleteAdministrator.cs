using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form_DeleteAdministrator : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTIOM = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form_DeleteAdministrator()
        {
            InitializeComponent();
        }

        private static readonly Administrator administrator = new Administrator();
        private static readonly Administration administration = new Administration();

        public static int Id { get; private set; }

        // Return administration Id.
        public int GetAdministrationId()
        {
            return Id;
        }

        // Close the form and go back to Form Login.
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login login = new Form_Login();
            login.Show();
        }

        // TextBox Chief Administrator Enter Event.
        private void TextBox_ChiefAdministrator_Enter(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdmin.Equals("Chief Administrator"))
            {
                this.textBox_ChiefAdministrator.Text = string.Empty;
                this.textBox_ChiefAdministrator.ForeColor = Color.Black;
            }
        }

        // TextBox Chief Administrator Leave Event.
        private void TextBox_ChiefAdministrator_Leave(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();

            if (chiefAdmin.Equals(string.Empty))
            {
                this.textBox_ChiefAdministrator.Text = "Chief Administrator";
                this.textBox_ChiefAdministrator.ForeColor = Color.LightGray;
            }
        }

        // TextBox Chief Administrator Password Enter Event.
        private void TextBox_ChiefAdminPassword_Enter(object sender, EventArgs e)
        {
            string adminPassword = this.textBox_ChiefAdminPassword.Text.Trim();

            if (adminPassword.Equals("Admin Password"))
            {
                this.textBox_ChiefAdminPassword.Text = string.Empty;
                this.textBox_ChiefAdminPassword.ForeColor = Color.Black;
            }
        }

        // TextBox Chief Administrator Password Leave Event.
        private void TextBox_ChiefAdminPassword_Leave(object sender, EventArgs e)
        {
            string adminPassword = this.textBox_ChiefAdminPassword.Text.Trim();

            if (adminPassword.Equals(string.Empty))
            {
                this.textBox_ChiefAdminPassword.Text = "Admin Password";
                this.textBox_ChiefAdminPassword.ForeColor = Color.LightGray;
            }
        }

        // TextBox Administrator Login Enter Event.
        private void TextBox_AdministratorName_Enter(object sender, EventArgs e)
        {
            string newAdministrator = this.textBox_AdministratorName.Text.Trim();

            if (newAdministrator.Equals("Administrator Login"))
            {
                this.textBox_AdministratorName.Text = string.Empty;
                this.textBox_AdministratorName.ForeColor = Color.Black;
            }
        }

        // TextBox Administrator Login Leave Event.
        private void TextBox_AdministratorName_Leave(object sender, EventArgs e)
        {
            string newAdministrator = this.textBox_AdministratorName.Text.Trim();

            if (newAdministrator.Equals(string.Empty))
            {
                this.textBox_AdministratorName.Text = "Administrator Login";
                this.textBox_AdministratorName.ForeColor = Color.LightGray;
            }
        }

        // Button Select Administrator. Shows list of all administrators.
        private void Button_ShowAdministrators_Click(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();
            string chiefPassword = this.textBox_ChiefAdminPassword.Text.Trim();

            if (administrator.IsDataValid(chiefAdmin, chiefPassword, out string message))
            {
                if (administration.IsChiefAdminCorrect(chiefAdmin, chiefPassword, out int administrationId, out message))
                {
                    Id = administrationId;

                    // Show a Form to select the Administrator which we want to delete.
                    Form_SelectAdministrator selectAdmin = new Form_SelectAdministrator();

                    using (selectAdmin)
                    {
                        selectAdmin.ShowDialog();
                        this.textBox_AdministratorName.Text = selectAdmin.dataGridView_Administrators.CurrentRow.Cells["Administrator Login"].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show(message,
                        "Select Administrator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + message,
                    "Select Administrator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }            
        }

        // Button delete Administrator.
        private void Button_DeleteAdministrator_Click(object sender, EventArgs e)
        {
            string chiefAdmin = this.textBox_ChiefAdministrator.Text.Trim();
            string chiefPassword = this.textBox_ChiefAdminPassword.Text.Trim();
            string adminName = this.textBox_AdministratorName.Text.Trim();                        

            if (administrator.IsDataValid(chiefAdmin, chiefPassword, adminName, out string message))
            {
                if (administration.IsChiefAdminCorrect(chiefAdmin, chiefPassword, out int administrationId, out message))
                {
                    if (chiefAdmin != adminName)
                    {
                        if (administrator.DeleteAdministrator(administrationId, adminName, out message))
                        {
                            MessageBox.Show(message,
                                "Delete Administrator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show(message,
                                "Delete Administrator",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Chief Administrarot can be deleted only with the administration!",
                            "Delete Administrator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(message,
                        "Delete Administrator",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The next Fields are incorrect: " + message,
                    "Delete Administrator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Clear the entered data.
        private void ClearData()
        {
            this.textBox_ChiefAdministrator.Text = "Chief Administrator";
            this.textBox_ChiefAdministrator.ForeColor = Color.LightGray;
            this.textBox_ChiefAdminPassword.Text = "Admin Password";
            this.textBox_ChiefAdminPassword.ForeColor = Color.LightGray;
            this.textBox_AdministratorName.Text = "Administrator Login";
            this.textBox_AdministratorName.ForeColor = Color.LightGray;
        }

        // Form move function.
        private void PanelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTIOM, 0);
            }
        }        
    }
}