namespace Csharp_Manage_Contacts
{
    partial class Contact_Full_List_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.Label_Contacts_Without_Group = new System.Windows.Forms.Label();
            this.Label_Show_All = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.DataGridView_ContactsList = new System.Windows.Forms.DataGridView();
            this.ListBoxGroups = new System.Windows.Forms.ListBox();
            this.panelMain.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ContactsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMain.Controls.Add(this.Panel_Header);
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(959, 621);
            this.panelMain.TabIndex = 2;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Panel_Header.Controls.Add(this.ButtonMinimize);
            this.Panel_Header.Controls.Add(this.ButtonClose);
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(960, 45);
            this.Panel_Header.TabIndex = 2;
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Header_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizeGrey;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(879, 6);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(36, 36);
            this.ButtonMinimize.TabIndex = 19;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonCloseGrey;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Location = new System.Drawing.Point(918, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelBody.Controls.Add(this.Label_Contacts_Without_Group);
            this.panelBody.Controls.Add(this.Label_Show_All);
            this.panelBody.Controls.Add(this.textBoxAddress);
            this.panelBody.Controls.Add(this.LabelAddress);
            this.panelBody.Controls.Add(this.DataGridView_ContactsList);
            this.panelBody.Controls.Add(this.ListBoxGroups);
            this.panelBody.Location = new System.Drawing.Point(5, 50);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(950, 565);
            this.panelBody.TabIndex = 0;
            // 
            // Label_Contacts_Without_Group
            // 
            this.Label_Contacts_Without_Group.AutoSize = true;
            this.Label_Contacts_Without_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Contacts_Without_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            this.Label_Contacts_Without_Group.Location = new System.Drawing.Point(315, 15);
            this.Label_Contacts_Without_Group.Name = "Label_Contacts_Without_Group";
            this.Label_Contacts_Without_Group.Size = new System.Drawing.Size(257, 24);
            this.Label_Contacts_Without_Group.TabIndex = 21;
            this.Label_Contacts_Without_Group.Text = "Show Contacts without Group";
            this.Label_Contacts_Without_Group.Click += new System.EventHandler(this.Label_Contacts_Without_Group_Click);
            // 
            // Label_Show_All
            // 
            this.Label_Show_All.AutoSize = true;
            this.Label_Show_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Show_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(24)))));
            this.Label_Show_All.Location = new System.Drawing.Point(225, 15);
            this.Label_Show_All.Name = "Label_Show_All";
            this.Label_Show_All.Size = new System.Drawing.Size(84, 24);
            this.Label_Show_All.TabIndex = 20;
            this.Label_Show_All.Text = "Show All";
            this.Label_Show_All.Click += new System.EventHandler(this.Label_Show_All_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(305, 455);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(635, 65);
            this.textBoxAddress.TabIndex = 19;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddress.ForeColor = System.Drawing.Color.White;
            this.LabelAddress.Location = new System.Drawing.Point(225, 455);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(72, 20);
            this.LabelAddress.TabIndex = 18;
            this.LabelAddress.Text = "Address:";
            // 
            // DataGridView_ContactsList
            // 
            this.DataGridView_ContactsList.AllowUserToAddRows = false;
            this.DataGridView_ContactsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_ContactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ContactsList.Location = new System.Drawing.Point(225, 45);
            this.DataGridView_ContactsList.Name = "DataGridView_ContactsList";
            this.DataGridView_ContactsList.Size = new System.Drawing.Size(715, 395);
            this.DataGridView_ContactsList.TabIndex = 1;
            this.DataGridView_ContactsList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_ColumnHeaderMouseClick);
            this.DataGridView_ContactsList.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ListBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 20;
            this.ListBoxGroups.Location = new System.Drawing.Point(15, 45);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(185, 264);
            this.ListBoxGroups.TabIndex = 0;
            this.ListBoxGroups.Click += new System.EventHandler(this.ListBoxGroups_Click);
            // 
            // Contact_Full_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 621);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contact_Full_List_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact_Full_List_Form";
            this.Load += new System.EventHandler(this.Contact_Full_List_Form_Load);
            this.panelMain.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ContactsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView DataGridView_ContactsList;
        private System.Windows.Forms.ListBox ListBoxGroups;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label Label_Show_All;
        private System.Windows.Forms.Label Label_Contacts_Without_Group;
    }
}