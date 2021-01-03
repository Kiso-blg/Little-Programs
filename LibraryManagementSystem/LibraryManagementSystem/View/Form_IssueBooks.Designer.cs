namespace LibraryManagementSystem
{
    partial class Form_IssueBooks
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel_Data = new System.Windows.Forms.Panel();
            this.button_IssueBook = new System.Windows.Forms.Button();
            this.dateTimePicker_BookIssueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Books = new System.Windows.Forms.ComboBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Semester = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.label_Warning = new System.Windows.Forms.Label();
            this.labelBookIssueDate = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.panel_SelectStudent = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_SearchStudent = new System.Windows.Forms.Button();
            this.textBox_EnrollmentNo = new System.Windows.Forms.TextBox();
            this.labelEnrollmentNo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Button_Minimize = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.labelIssueBooks = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.Button_Maximize = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            this.panel_Data.SuspendLayout();
            this.panel_SelectStudent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelBody.Controls.Add(this.panel_Data);
            this.panelBody.Controls.Add(this.panel_SelectStudent);
            this.panelBody.Controls.Add(this.panelHeader);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(714, 516);
            this.panelBody.TabIndex = 0;
            // 
            // panel_Data
            // 
            this.panel_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_Data.Controls.Add(this.button_IssueBook);
            this.panel_Data.Controls.Add(this.dateTimePicker_BookIssueDate);
            this.panel_Data.Controls.Add(this.comboBox_Books);
            this.panel_Data.Controls.Add(this.textBox_Email);
            this.panel_Data.Controls.Add(this.textBox_Contact);
            this.panel_Data.Controls.Add(this.textBox_Semester);
            this.panel_Data.Controls.Add(this.textBox_Department);
            this.panel_Data.Controls.Add(this.textBox_StudentName);
            this.panel_Data.Controls.Add(this.label_Warning);
            this.panel_Data.Controls.Add(this.labelBookIssueDate);
            this.panel_Data.Controls.Add(this.labelBookName);
            this.panel_Data.Controls.Add(this.labelEmail);
            this.panel_Data.Controls.Add(this.labelContact);
            this.panel_Data.Controls.Add(this.labelSemester);
            this.panel_Data.Controls.Add(this.labelDepartment);
            this.panel_Data.Controls.Add(this.labelStudentName);
            this.panel_Data.Location = new System.Drawing.Point(280, 140);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(425, 370);
            this.panel_Data.TabIndex = 2;
            // 
            // button_IssueBook
            // 
            this.button_IssueBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_IssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_IssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_IssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_IssueBook.Location = new System.Drawing.Point(270, 305);
            this.button_IssueBook.Name = "button_IssueBook";
            this.button_IssueBook.Size = new System.Drawing.Size(115, 30);
            this.button_IssueBook.TabIndex = 12;
            this.button_IssueBook.Text = "Issue Book";
            this.button_IssueBook.UseVisualStyleBackColor = true;
            this.button_IssueBook.Click += new System.EventHandler(this.Button_IssueBook_Click);
            // 
            // dateTimePicker_BookIssueDate
            // 
            this.dateTimePicker_BookIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_BookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_BookIssueDate.Location = new System.Drawing.Point(170, 264);
            this.dateTimePicker_BookIssueDate.Name = "dateTimePicker_BookIssueDate";
            this.dateTimePicker_BookIssueDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_BookIssueDate.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker_BookIssueDate.TabIndex = 11;
            // 
            // comboBox_Books
            // 
            this.comboBox_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Books.FormattingEnabled = true;
            this.comboBox_Books.Location = new System.Drawing.Point(170, 222);
            this.comboBox_Books.Name = "comboBox_Books";
            this.comboBox_Books.Size = new System.Drawing.Size(215, 24);
            this.comboBox_Books.TabIndex = 10;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Email.Location = new System.Drawing.Point(170, 184);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(215, 22);
            this.textBox_Email.TabIndex = 9;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Contact.Location = new System.Drawing.Point(170, 144);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.ReadOnly = true;
            this.textBox_Contact.Size = new System.Drawing.Size(215, 22);
            this.textBox_Contact.TabIndex = 8;
            // 
            // textBox_Semester
            // 
            this.textBox_Semester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Semester.Location = new System.Drawing.Point(170, 104);
            this.textBox_Semester.Name = "textBox_Semester";
            this.textBox_Semester.ReadOnly = true;
            this.textBox_Semester.Size = new System.Drawing.Size(215, 22);
            this.textBox_Semester.TabIndex = 7;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Department.Location = new System.Drawing.Point(170, 64);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.ReadOnly = true;
            this.textBox_Department.Size = new System.Drawing.Size(215, 22);
            this.textBox_Department.TabIndex = 6;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_StudentName.Location = new System.Drawing.Point(170, 24);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.ReadOnly = true;
            this.textBox_StudentName.Size = new System.Drawing.Size(215, 22);
            this.textBox_StudentName.TabIndex = 5;
            // 
            // label_Warning
            // 
            this.label_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Warning.AutoSize = true;
            this.label_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Warning.ForeColor = System.Drawing.Color.Red;
            this.label_Warning.Location = new System.Drawing.Point(66, 351);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(356, 16);
            this.label_Warning.TabIndex = 7;
            this.label_Warning.Text = "Maximum 3 Books Can be ISSUED by one Student!";
            // 
            // labelBookIssueDate
            // 
            this.labelBookIssueDate.AutoSize = true;
            this.labelBookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookIssueDate.Location = new System.Drawing.Point(30, 270);
            this.labelBookIssueDate.Name = "labelBookIssueDate";
            this.labelBookIssueDate.Size = new System.Drawing.Size(107, 16);
            this.labelBookIssueDate.TabIndex = 6;
            this.labelBookIssueDate.Text = "Book Issue Date";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookName.Location = new System.Drawing.Point(30, 230);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(80, 16);
            this.labelBookName.TabIndex = 5;
            this.labelBookName.Text = "Book Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(30, 190);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(90, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Student Email";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContact.Location = new System.Drawing.Point(30, 150);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(101, 16);
            this.labelContact.TabIndex = 3;
            this.labelContact.Text = "Student Contact";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(30, 110);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(114, 16);
            this.labelSemester.TabIndex = 2;
            this.labelSemester.Text = "Student Semester";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.Location = new System.Drawing.Point(30, 70);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(78, 16);
            this.labelDepartment.TabIndex = 1;
            this.labelDepartment.Text = "Department";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(30, 30);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(93, 16);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name";
            // 
            // panel_SelectStudent
            // 
            this.panel_SelectStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SelectStudent.BackColor = System.Drawing.Color.Silver;
            this.panel_SelectStudent.Controls.Add(this.Button_Exit);
            this.panel_SelectStudent.Controls.Add(this.Button_Refresh);
            this.panel_SelectStudent.Controls.Add(this.Button_SearchStudent);
            this.panel_SelectStudent.Controls.Add(this.textBox_EnrollmentNo);
            this.panel_SelectStudent.Controls.Add(this.labelEnrollmentNo);
            this.panel_SelectStudent.Controls.Add(this.pictureBoxStudent);
            this.panel_SelectStudent.Location = new System.Drawing.Point(10, 140);
            this.panel_SelectStudent.Name = "panel_SelectStudent";
            this.panel_SelectStudent.Size = new System.Drawing.Size(260, 370);
            this.panel_SelectStudent.TabIndex = 1;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(140, 310);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(90, 30);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Refresh.Location = new System.Drawing.Point(30, 310);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(90, 30);
            this.Button_Refresh.TabIndex = 3;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_SearchStudent
            // 
            this.Button_SearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_SearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchStudent.Location = new System.Drawing.Point(60, 220);
            this.Button_SearchStudent.Name = "Button_SearchStudent";
            this.Button_SearchStudent.Size = new System.Drawing.Size(140, 40);
            this.Button_SearchStudent.TabIndex = 2;
            this.Button_SearchStudent.Text = "Search Student";
            this.Button_SearchStudent.UseVisualStyleBackColor = true;
            this.Button_SearchStudent.Click += new System.EventHandler(this.Button_SearchStudent_Click);
            // 
            // textBox_EnrollmentNo
            // 
            this.textBox_EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EnrollmentNo.Location = new System.Drawing.Point(30, 175);
            this.textBox_EnrollmentNo.Name = "textBox_EnrollmentNo";
            this.textBox_EnrollmentNo.Size = new System.Drawing.Size(200, 22);
            this.textBox_EnrollmentNo.TabIndex = 1;
            // 
            // labelEnrollmentNo
            // 
            this.labelEnrollmentNo.AutoSize = true;
            this.labelEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentNo.Location = new System.Drawing.Point(58, 140);
            this.labelEnrollmentNo.Name = "labelEnrollmentNo";
            this.labelEnrollmentNo.Size = new System.Drawing.Size(152, 20);
            this.labelEnrollmentNo.TabIndex = 1;
            this.labelEnrollmentNo.Text = "Enter Enrollment No";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.Button_Maximize);
            this.panelHeader.Controls.Add(this.Button_Minimize);
            this.panelHeader.Controls.Add(this.Button_Close);
            this.panelHeader.Controls.Add(this.labelIssueBooks);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Location = new System.Drawing.Point(10, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(695, 125);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Minimize.Location = new System.Drawing.Point(620, 0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Button_Minimize.TabIndex = 14;
            this.Button_Minimize.Text = "-";
            this.Button_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Minimize.UseVisualStyleBackColor = true;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(670, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 13;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelIssueBooks
            // 
            this.labelIssueBooks.AutoSize = true;
            this.labelIssueBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssueBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIssueBooks.Location = new System.Drawing.Point(380, 98);
            this.labelIssueBooks.Name = "labelIssueBooks";
            this.labelIssueBooks.Size = new System.Drawing.Size(140, 25);
            this.labelIssueBooks.TabIndex = 1;
            this.labelIssueBooks.Text = "Issue Books";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::LibraryManagementSystem.Properties.Resources.icons8_student_male_1001;
            this.pictureBoxStudent.Location = new System.Drawing.Point(80, 25);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 0;
            this.pictureBoxStudent.TabStop = false;
            // 
            // Button_Maximize
            // 
            this.Button_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Maximize.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.maximize_size_option_318_49002;
            this.Button_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Maximize.Location = new System.Drawing.Point(645, 0);
            this.Button_Maximize.Name = "Button_Maximize";
            this.Button_Maximize.Size = new System.Drawing.Size(25, 25);
            this.Button_Maximize.TabIndex = 15;
            this.Button_Maximize.UseVisualStyleBackColor = true;
            this.Button_Maximize.Click += new System.EventHandler(this.Button_Maximize_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LibraryManagementSystem.Properties.Resources.issueBook;
            this.pictureBoxLogo.Location = new System.Drawing.Point(180, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(260, 125);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form_IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_IssueBooks";
            this.Load += new System.EventHandler(this.Form_IssueBooks_Load);
            this.panelBody.ResumeLayout(false);
            this.panel_Data.ResumeLayout(false);
            this.panel_Data.PerformLayout();
            this.panel_SelectStudent.ResumeLayout(false);
            this.panel_SelectStudent.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel_SelectStudent;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Label labelIssueBooks;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_SearchStudent;
        private System.Windows.Forms.TextBox textBox_EnrollmentNo;
        private System.Windows.Forms.Label labelEnrollmentNo;
        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.Button button_IssueBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookIssueDate;
        private System.Windows.Forms.ComboBox comboBox_Books;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_Semester;
        private System.Windows.Forms.TextBox textBox_Department;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.Label labelBookIssueDate;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Maximize;
        private System.Windows.Forms.Button Button_Minimize;
    }
}