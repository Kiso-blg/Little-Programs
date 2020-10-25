namespace Csharp_Manage_Contacts
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Button_Show_Full_List = new System.Windows.Forms.Button();
            this.textBoxContactId = new System.Windows.Forms.TextBox();
            this.Button_Select_Contact = new System.Windows.Forms.Button();
            this.Button_Remove_Contact = new System.Windows.Forms.Button();
            this.Button_Edit_Contacts = new System.Windows.Forms.Button();
            this.Button_Add_Contacts = new System.Windows.Forms.Button();
            this.LabelContacts = new System.Windows.Forms.Label();
            this.panel_Border = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxRemoveGroupId = new System.Windows.Forms.ComboBox();
            this.LabelSelectGroupForRemove = new System.Windows.Forms.Label();
            this.Button_Remove_Group = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEditGroupId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEditGroupName = new System.Windows.Forms.TextBox();
            this.LabelSelectGroupForEdit = new System.Windows.Forms.Label();
            this.Button_Edit_Group = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Add_Group = new System.Windows.Forms.Button();
            this.textBoxAddGroupName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel_Minimize_And_Close = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.LabelRefresh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelEditUserData = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.pictureBoxUserPicture = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel_Minimize_And_Close.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.Button_Show_Full_List);
            this.panelMenu.Controls.Add(this.textBoxContactId);
            this.panelMenu.Controls.Add(this.Button_Select_Contact);
            this.panelMenu.Controls.Add(this.Button_Remove_Contact);
            this.panelMenu.Controls.Add(this.Button_Edit_Contacts);
            this.panelMenu.Controls.Add(this.Button_Add_Contacts);
            this.panelMenu.Controls.Add(this.LabelContacts);
            this.panelMenu.Controls.Add(this.panel_Border);
            this.panelMenu.Controls.Add(this.groupBox2);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.groupBox);
            this.panelMenu.Controls.Add(this.labelGroup);
            this.panelMenu.Location = new System.Drawing.Point(0, 55);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(790, 445);
            this.panelMenu.TabIndex = 1;
            // 
            // Button_Show_Full_List
            // 
            this.Button_Show_Full_List.BackColor = System.Drawing.Color.Orange;
            this.Button_Show_Full_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Show_Full_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Show_Full_List.ForeColor = System.Drawing.Color.White;
            this.Button_Show_Full_List.Location = new System.Drawing.Point(15, 370);
            this.Button_Show_Full_List.Name = "Button_Show_Full_List";
            this.Button_Show_Full_List.Size = new System.Drawing.Size(280, 55);
            this.Button_Show_Full_List.TabIndex = 8;
            this.Button_Show_Full_List.Text = "Show Full List";
            this.Button_Show_Full_List.UseVisualStyleBackColor = false;
            this.Button_Show_Full_List.Click += new System.EventHandler(this.Button_Show_Full_List_Click);
            // 
            // textBoxContactId
            // 
            this.textBoxContactId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContactId.Location = new System.Drawing.Point(15, 319);
            this.textBoxContactId.Multiline = true;
            this.textBoxContactId.Name = "textBoxContactId";
            this.textBoxContactId.Size = new System.Drawing.Size(137, 29);
            this.textBoxContactId.TabIndex = 6;
            // 
            // Button_Select_Contact
            // 
            this.Button_Select_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Button_Select_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Select_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Select_Contact.ForeColor = System.Drawing.Color.White;
            this.Button_Select_Contact.Location = new System.Drawing.Point(15, 278);
            this.Button_Select_Contact.Name = "Button_Select_Contact";
            this.Button_Select_Contact.Size = new System.Drawing.Size(137, 35);
            this.Button_Select_Contact.TabIndex = 5;
            this.Button_Select_Contact.Text = "Select Contact";
            this.Button_Select_Contact.UseVisualStyleBackColor = false;
            this.Button_Select_Contact.Click += new System.EventHandler(this.Button_Select_Contact_Click);
            // 
            // Button_Remove_Contact
            // 
            this.Button_Remove_Contact.BackColor = System.Drawing.Color.Orange;
            this.Button_Remove_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Remove_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Remove_Contact.ForeColor = System.Drawing.Color.White;
            this.Button_Remove_Contact.Location = new System.Drawing.Point(160, 278);
            this.Button_Remove_Contact.Name = "Button_Remove_Contact";
            this.Button_Remove_Contact.Size = new System.Drawing.Size(145, 70);
            this.Button_Remove_Contact.TabIndex = 7;
            this.Button_Remove_Contact.Text = "Remove";
            this.Button_Remove_Contact.UseVisualStyleBackColor = false;
            this.Button_Remove_Contact.Click += new System.EventHandler(this.Button_Remove_Contact_Click);
            // 
            // Button_Edit_Contacts
            // 
            this.Button_Edit_Contacts.BackColor = System.Drawing.Color.Orange;
            this.Button_Edit_Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Edit_Contacts.ForeColor = System.Drawing.Color.White;
            this.Button_Edit_Contacts.Location = new System.Drawing.Point(70, 190);
            this.Button_Edit_Contacts.Name = "Button_Edit_Contacts";
            this.Button_Edit_Contacts.Size = new System.Drawing.Size(230, 65);
            this.Button_Edit_Contacts.TabIndex = 4;
            this.Button_Edit_Contacts.Text = "Edit";
            this.Button_Edit_Contacts.UseVisualStyleBackColor = false;
            this.Button_Edit_Contacts.Click += new System.EventHandler(this.Button_Edit_Contacts_Click);
            // 
            // Button_Add_Contacts
            // 
            this.Button_Add_Contacts.BackColor = System.Drawing.Color.Orange;
            this.Button_Add_Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add_Contacts.ForeColor = System.Drawing.Color.White;
            this.Button_Add_Contacts.Location = new System.Drawing.Point(70, 100);
            this.Button_Add_Contacts.Name = "Button_Add_Contacts";
            this.Button_Add_Contacts.Size = new System.Drawing.Size(230, 65);
            this.Button_Add_Contacts.TabIndex = 3;
            this.Button_Add_Contacts.Text = "Add";
            this.Button_Add_Contacts.UseVisualStyleBackColor = false;
            this.Button_Add_Contacts.Click += new System.EventHandler(this.Button_Add_Contacts_Click);
            // 
            // LabelContacts
            // 
            this.LabelContacts.AutoSize = true;
            this.LabelContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContacts.ForeColor = System.Drawing.Color.White;
            this.LabelContacts.Location = new System.Drawing.Point(110, 25);
            this.LabelContacts.Name = "LabelContacts";
            this.LabelContacts.Size = new System.Drawing.Size(155, 39);
            this.LabelContacts.TabIndex = 0;
            this.LabelContacts.Text = "Contacts";
            // 
            // panel_Border
            // 
            this.panel_Border.BackColor = System.Drawing.Color.White;
            this.panel_Border.Location = new System.Drawing.Point(360, 20);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(10, 410);
            this.panel_Border.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRemoveGroupId);
            this.groupBox2.Controls.Add(this.LabelSelectGroupForRemove);
            this.groupBox2.Controls.Add(this.Button_Remove_Group);
            this.groupBox2.Location = new System.Drawing.Point(410, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxRemoveGroupId
            // 
            this.comboBoxRemoveGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRemoveGroupId.FormattingEnabled = true;
            this.comboBoxRemoveGroupId.Location = new System.Drawing.Point(161, 13);
            this.comboBoxRemoveGroupId.Name = "comboBoxRemoveGroupId";
            this.comboBoxRemoveGroupId.Size = new System.Drawing.Size(195, 28);
            this.comboBoxRemoveGroupId.TabIndex = 14;
            // 
            // LabelSelectGroupForRemove
            // 
            this.LabelSelectGroupForRemove.AutoSize = true;
            this.LabelSelectGroupForRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelectGroupForRemove.ForeColor = System.Drawing.Color.White;
            this.LabelSelectGroupForRemove.Location = new System.Drawing.Point(48, 16);
            this.LabelSelectGroupForRemove.Name = "LabelSelectGroupForRemove";
            this.LabelSelectGroupForRemove.Size = new System.Drawing.Size(107, 20);
            this.LabelSelectGroupForRemove.TabIndex = 0;
            this.LabelSelectGroupForRemove.Text = "Select Group:";
            // 
            // Button_Remove_Group
            // 
            this.Button_Remove_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.Button_Remove_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Remove_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Remove_Group.ForeColor = System.Drawing.Color.White;
            this.Button_Remove_Group.Location = new System.Drawing.Point(6, 53);
            this.Button_Remove_Group.Name = "Button_Remove_Group";
            this.Button_Remove_Group.Size = new System.Drawing.Size(350, 30);
            this.Button_Remove_Group.TabIndex = 15;
            this.Button_Remove_Group.Text = "Remove";
            this.Button_Remove_Group.UseVisualStyleBackColor = false;
            this.Button_Remove_Group.Click += new System.EventHandler(this.Button_Remove_Group_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEditGroupId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEditGroupName);
            this.groupBox1.Controls.Add(this.LabelSelectGroupForEdit);
            this.groupBox1.Controls.Add(this.Button_Edit_Group);
            this.groupBox1.Location = new System.Drawing.Point(410, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxEditGroupId
            // 
            this.comboBoxEditGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditGroupId.FormattingEnabled = true;
            this.comboBoxEditGroupId.Location = new System.Drawing.Point(161, 13);
            this.comboBoxEditGroupId.Name = "comboBoxEditGroupId";
            this.comboBoxEditGroupId.Size = new System.Drawing.Size(195, 28);
            this.comboBoxEditGroupId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter New Name:";
            // 
            // textBoxEditGroupName
            // 
            this.textBoxEditGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditGroupName.Location = new System.Drawing.Point(161, 51);
            this.textBoxEditGroupName.Name = "textBoxEditGroupName";
            this.textBoxEditGroupName.Size = new System.Drawing.Size(195, 26);
            this.textBoxEditGroupName.TabIndex = 12;
            // 
            // LabelSelectGroupForEdit
            // 
            this.LabelSelectGroupForEdit.AutoSize = true;
            this.LabelSelectGroupForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelectGroupForEdit.ForeColor = System.Drawing.Color.White;
            this.LabelSelectGroupForEdit.Location = new System.Drawing.Point(52, 16);
            this.LabelSelectGroupForEdit.Name = "LabelSelectGroupForEdit";
            this.LabelSelectGroupForEdit.Size = new System.Drawing.Size(107, 20);
            this.LabelSelectGroupForEdit.TabIndex = 0;
            this.LabelSelectGroupForEdit.Text = "Select Group:";
            // 
            // Button_Edit_Group
            // 
            this.Button_Edit_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.Button_Edit_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Edit_Group.ForeColor = System.Drawing.Color.White;
            this.Button_Edit_Group.Location = new System.Drawing.Point(6, 93);
            this.Button_Edit_Group.Name = "Button_Edit_Group";
            this.Button_Edit_Group.Size = new System.Drawing.Size(350, 30);
            this.Button_Edit_Group.TabIndex = 13;
            this.Button_Edit_Group.Text = "Edit";
            this.Button_Edit_Group.UseVisualStyleBackColor = false;
            this.Button_Edit_Group.Click += new System.EventHandler(this.Button_Edit_Group_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.Button_Add_Group);
            this.groupBox.Controls.Add(this.textBoxAddGroupName);
            this.groupBox.Location = new System.Drawing.Point(410, 90);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(365, 90);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Group Name:";
            // 
            // Button_Add_Group
            // 
            this.Button_Add_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.Button_Add_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add_Group.ForeColor = System.Drawing.Color.White;
            this.Button_Add_Group.Location = new System.Drawing.Point(6, 53);
            this.Button_Add_Group.Name = "Button_Add_Group";
            this.Button_Add_Group.Size = new System.Drawing.Size(350, 30);
            this.Button_Add_Group.TabIndex = 10;
            this.Button_Add_Group.Text = "Add";
            this.Button_Add_Group.UseVisualStyleBackColor = false;
            this.Button_Add_Group.Click += new System.EventHandler(this.Button_Add_Group_Click);
            // 
            // textBoxAddGroupName
            // 
            this.textBoxAddGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddGroupName.Location = new System.Drawing.Point(161, 11);
            this.textBoxAddGroupName.Name = "textBoxAddGroupName";
            this.textBoxAddGroupName.Size = new System.Drawing.Size(195, 26);
            this.textBoxAddGroupName.TabIndex = 9;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.ForeColor = System.Drawing.Color.White;
            this.labelGroup.Location = new System.Drawing.Point(520, 25);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(113, 39);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Group";
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizePurple;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(0, 2);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(36, 36);
            this.ButtonMinimize.TabIndex = 16;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonClosePurple;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Location = new System.Drawing.Point(40, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 17;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel_Minimize_And_Close
            // 
            this.panel_Minimize_And_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel_Minimize_And_Close.Controls.Add(this.ButtonMinimize);
            this.panel_Minimize_And_Close.Controls.Add(this.ButtonClose);
            this.panel_Minimize_And_Close.Location = new System.Drawing.Point(709, 5);
            this.panel_Minimize_And_Close.Name = "panel_Minimize_And_Close";
            this.panel_Minimize_And_Close.Size = new System.Drawing.Size(78, 40);
            this.panel_Minimize_And_Close.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelMain.Controls.Add(this.LabelRefresh);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.LabelEditUserData);
            this.panelMain.Controls.Add(this.LabelUsername);
            this.panelMain.Controls.Add(this.pictureBoxUserPicture);
            this.panelMain.Controls.Add(this.panel_Minimize_And_Close);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(790, 500);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
            // 
            // LabelRefresh
            // 
            this.LabelRefresh.AutoSize = true;
            this.LabelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRefresh.ForeColor = System.Drawing.Color.Azure;
            this.LabelRefresh.Location = new System.Drawing.Point(160, 32);
            this.LabelRefresh.Name = "LabelRefresh";
            this.LabelRefresh.Size = new System.Drawing.Size(55, 16);
            this.LabelRefresh.TabIndex = 2;
            this.LabelRefresh.Text = "Refresh";
            this.LabelRefresh.Click += new System.EventHandler(this.LabelRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(145, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "|";
            // 
            // LabelEditUserData
            // 
            this.LabelEditUserData.AutoSize = true;
            this.LabelEditUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEditUserData.ForeColor = System.Drawing.Color.Azure;
            this.LabelEditUserData.Location = new System.Drawing.Point(65, 32);
            this.LabelEditUserData.Name = "LabelEditUserData";
            this.LabelEditUserData.Size = new System.Drawing.Size(76, 16);
            this.LabelEditUserData.TabIndex = 1;
            this.LabelEditUserData.Text = "Edit my info";
            this.LabelEditUserData.Click += new System.EventHandler(this.LabelEditUserData_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Cornsilk;
            this.LabelUsername.Location = new System.Drawing.Point(65, 7);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(137, 16);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Welcome (username)";
            // 
            // pictureBoxUserPicture
            // 
            this.pictureBoxUserPicture.BackColor = System.Drawing.Color.Red;
            this.pictureBoxUserPicture.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
            this.pictureBoxUserPicture.Size = new System.Drawing.Size(47, 47);
            this.pictureBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserPicture.TabIndex = 0;
            this.pictureBoxUserPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel_Minimize_And_Close.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel panel_Minimize_And_Close;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.PictureBox pictureBoxUserPicture;
        private System.Windows.Forms.Label LabelEditUserData;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Add_Group;
        private System.Windows.Forms.TextBox textBoxAddGroupName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEditGroupId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEditGroupName;
        private System.Windows.Forms.Label LabelSelectGroupForEdit;
        private System.Windows.Forms.Button Button_Edit_Group;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelSelectGroupForRemove;
        private System.Windows.Forms.Button Button_Remove_Group;
        private System.Windows.Forms.ComboBox comboBoxRemoveGroupId;
        private System.Windows.Forms.Label LabelRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Show_Full_List;
        private System.Windows.Forms.TextBox textBoxContactId;
        private System.Windows.Forms.Button Button_Select_Contact;
        private System.Windows.Forms.Button Button_Remove_Contact;
        private System.Windows.Forms.Button Button_Edit_Contacts;
        private System.Windows.Forms.Button Button_Add_Contacts;
        private System.Windows.Forms.Label LabelContacts;
        private System.Windows.Forms.Panel panel_Border;
    }
}