
namespace CollegeManagementSystem
{
    partial class Form_Main
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelSistem = new System.Windows.Forms.Label();
            this.labelManagement = new System.Windows.Forms.Label();
            this.labelCollege = new System.Windows.Forms.Label();
            this.menuStripButtons = new System.Windows.Forms.MenuStrip();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_NewAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboudUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Body.SuspendLayout();
            this.menuStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.home;
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Controls.Add(this.splitter1);
            this.panel_Body.Controls.Add(this.labelSistem);
            this.panel_Body.Controls.Add(this.labelManagement);
            this.panel_Body.Controls.Add(this.labelCollege);
            this.panel_Body.Controls.Add(this.menuStripButtons);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1127, 633);
            this.panel_Body.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 83);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 550);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // labelSistem
            // 
            this.labelSistem.AutoSize = true;
            this.labelSistem.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSistem.Location = new System.Drawing.Point(755, 530);
            this.labelSistem.Name = "labelSistem";
            this.labelSistem.Size = new System.Drawing.Size(222, 63);
            this.labelSistem.TabIndex = 2;
            this.labelSistem.Text = "SYSTEM";
            // 
            // labelManagement
            // 
            this.labelManagement.AutoSize = true;
            this.labelManagement.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagement.Location = new System.Drawing.Point(375, 460);
            this.labelManagement.Name = "labelManagement";
            this.labelManagement.Size = new System.Drawing.Size(379, 63);
            this.labelManagement.TabIndex = 1;
            this.labelManagement.Text = "MANAGEMENT";
            // 
            // labelCollege
            // 
            this.labelCollege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCollege.AutoSize = true;
            this.labelCollege.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollege.Location = new System.Drawing.Point(135, 390);
            this.labelCollege.Name = "labelCollege";
            this.labelCollege.Size = new System.Drawing.Size(239, 63);
            this.labelCollege.TabIndex = 0;
            this.labelCollege.Text = "COLLEGE";
            // 
            // menuStripButtons
            // 
            this.menuStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.removeStudentToolStripMenuItem,
            this.aboudUsToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
            this.menuStripButtons.Location = new System.Drawing.Point(0, 0);
            this.menuStripButtons.Name = "menuStripButtons";
            this.menuStripButtons.Size = new System.Drawing.Size(1127, 83);
            this.menuStripButtons.TabIndex = 4;
            this.menuStripButtons.Text = "Menu";
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_NewAdmissionToolStripMenuItem,
            this.updateSemesterToolStripMenuItem,
            this.addRemoveCourseToolStripMenuItem});
            this.admissionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admissionToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.admissions_message_logo;
            this.admissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(75, 79);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Button_NewAdmissionToolStripMenuItem
            // 
            this.Button_NewAdmissionToolStripMenuItem.Name = "Button_NewAdmissionToolStripMenuItem";
            this.Button_NewAdmissionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.Button_NewAdmissionToolStripMenuItem.Text = "New Admission";
            this.Button_NewAdmissionToolStripMenuItem.Click += new System.EventHandler(this.Button_NewAdmissionToolStripMenuItem_Click);
            // 
            // updateSemesterToolStripMenuItem
            // 
            this.updateSemesterToolStripMenuItem.Name = "updateSemesterToolStripMenuItem";
            this.updateSemesterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.updateSemesterToolStripMenuItem.Text = "Update Semester";
            this.updateSemesterToolStripMenuItem.Click += new System.EventHandler(this.UpdateSemesterToolStripMenuItem_Click);
            // 
            // addRemoveCourseToolStripMenuItem
            // 
            this.addRemoveCourseToolStripMenuItem.Name = "addRemoveCourseToolStripMenuItem";
            this.addRemoveCourseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addRemoveCourseToolStripMenuItem.Text = "Add/Remove Course";
            this.addRemoveCourseToolStripMenuItem.Click += new System.EventHandler(this.AddRemoveCourseToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feesToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.icon_fees;
            this.feesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.FeesToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem,
            this.individualDetailsToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentDetailsToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.stdicon;
            this.studentDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(105, 79);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.SearchStudentToolStripMenuItem_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            this.individualDetailsToolStripMenuItem.Click += new System.EventHandler(this.IndividualDetailsToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherInformationToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.teachersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.icon_djt_mb_im_a_teacher_296691;
            this.teachersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // addTeacherInformationToolStripMenuItem
            // 
            this.addTeacherInformationToolStripMenuItem.Name = "addTeacherInformationToolStripMenuItem";
            this.addTeacherInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTeacherInformationToolStripMenuItem.Text = "Add Teacher";
            this.addTeacherInformationToolStripMenuItem.Click += new System.EventHandler(this.AddTeacherInformationToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search Teacher";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeStudentToolStripMenuItem1,
            this.removeTeacherToolStripMenuItem});
            this.removeStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeStudentToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.remstdicon;
            this.removeStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.removeStudentToolStripMenuItem.Text = "Remove ";
            this.removeStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeStudentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // removeStudentToolStripMenuItem1
            // 
            this.removeStudentToolStripMenuItem1.Name = "removeStudentToolStripMenuItem1";
            this.removeStudentToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.removeStudentToolStripMenuItem1.Text = "Remove Student";
            this.removeStudentToolStripMenuItem1.Click += new System.EventHandler(this.RemoveStudentToolStripMenuItem1_Click);
            // 
            // removeTeacherToolStripMenuItem
            // 
            this.removeTeacherToolStripMenuItem.Name = "removeTeacherToolStripMenuItem";
            this.removeTeacherToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.removeTeacherToolStripMenuItem.Text = "Remove Teacher";
            this.removeTeacherToolStripMenuItem.Click += new System.EventHandler(this.RemoveTeacherToolStripMenuItem_Click);
            // 
            // aboudUsToolStripMenuItem
            // 
            this.aboudUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboudUsToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.abouticon;
            this.aboudUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboudUsToolStripMenuItem.Name = "aboudUsToolStripMenuItem";
            this.aboudUsToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.aboudUsToolStripMenuItem.Text = "Aboud Us";
            this.aboudUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboudUsToolStripMenuItem.Click += new System.EventHandler(this.AboudUsToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitSystemToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.exiticon;
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(84, 79);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            this.exitSystemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitSystemToolStripMenuItem.Click += new System.EventHandler(this.ExitSystemToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 633);
            this.Controls.Add(this.panel_Body);
            this.MainMenuStrip = this.menuStripButtons;
            this.Name = "Form_Main";
            this.Text = "College Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.menuStripButtons.ResumeLayout(false);
            this.menuStripButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label labelSistem;
        private System.Windows.Forms.Label labelManagement;
        private System.Windows.Forms.Label labelCollege;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Button_NewAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboudUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.MenuStrip menuStripButtons;
        private System.Windows.Forms.ToolStripMenuItem addRemoveCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeTeacherToolStripMenuItem;
    }
}