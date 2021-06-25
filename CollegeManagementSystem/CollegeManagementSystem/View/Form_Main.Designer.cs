// <copyright file="Form_Main.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_Main class.
    /// Contains all controllers for Form_Main class.
    /// </summary>
    public partial class Form_Main
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// Label labelSystem.
        /// </summary>
        private System.Windows.Forms.Label labelSystem;

        /// <summary>
        /// Label labelManagement.
        /// </summary>
        private System.Windows.Forms.Label labelManagement;

        /// <summary>
        /// Label labelCollege.
        /// </summary>
        private System.Windows.Forms.Label labelCollege;

        /// <summary>
        /// ToolStripMenuItem admissionToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem buttonNewAdmissionToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem buttonNewAdmissionToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem buttonNewAdmissionToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem updateSemesterToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem feesToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem studentDetailsToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem searchStudentToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem individualDetailsToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem teachersToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem addTeacherInformationToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem addTeacherInformationToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem searchToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem removeStudentOrTeacherToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem removeStudentOrTeacherToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem aboutUsToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem exitSystemToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;

        /// <summary>
        /// Splitter splitter.
        /// </summary>
        private System.Windows.Forms.Splitter splitter;

        /// <summary>
        /// MenuStrip menuStripButtons.
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStripButtons;

        /// <summary>
        /// ToolStripMenuItem addRemoveCourseToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem addRemoveCourseToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem removeStudentToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;

        /// <summary>
        /// ToolStripMenuItem removeTeacherToolStripMenuItem.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem removeTeacherToolStripMenuItem;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.splitter = new System.Windows.Forms.Splitter();
            this.labelSystem = new System.Windows.Forms.Label();
            this.labelManagement = new System.Windows.Forms.Label();
            this.labelCollege = new System.Windows.Forms.Label();
            this.menuStripButtons = new System.Windows.Forms.MenuStrip();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNewAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentOrTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBody.SuspendLayout();
            this.menuStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.home;
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.Controls.Add(this.splitter);
            this.panelBody.Controls.Add(this.labelSystem);
            this.panelBody.Controls.Add(this.labelManagement);
            this.panelBody.Controls.Add(this.labelCollege);
            this.panelBody.Controls.Add(this.menuStripButtons);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1127, 633);
            this.panelBody.TabIndex = 0;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(0, 83);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 550);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // labelSistem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystem.Location = new System.Drawing.Point(755, 530);
            this.labelSystem.Name = "labelSistem";
            this.labelSystem.Size = new System.Drawing.Size(222, 63);
            this.labelSystem.TabIndex = 2;
            this.labelSystem.Text = "SYSTEM";
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
            this.removeStudentOrTeacherToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
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
            this.buttonNewAdmissionToolStripMenuItem,
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
            // buttonNewAdmissionToolStripMenuItem
            // 
            this.buttonNewAdmissionToolStripMenuItem.Name = "buttonNewAdmissionToolStripMenuItem";
            this.buttonNewAdmissionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buttonNewAdmissionToolStripMenuItem.Text = "New Admission";
            this.buttonNewAdmissionToolStripMenuItem.Click += new System.EventHandler(this.ButtonNewAdmissionToolStripMenuItem_Click);
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
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.SearchStudentToolStripMenuItem_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.addTeacherInformationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addTeacherInformationToolStripMenuItem.Text = "Add Teacher";
            this.addTeacherInformationToolStripMenuItem.Click += new System.EventHandler(this.AddTeacherInformationToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.searchToolStripMenuItem.Text = "Search Teacher";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // removeStudentOrTeacherToolStripMenuItem
            // 
            this.removeStudentOrTeacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeStudentToolStripMenuItem,
            this.removeTeacherToolStripMenuItem});
            this.removeStudentOrTeacherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeStudentOrTeacherToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.remstdicon;
            this.removeStudentOrTeacherToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeStudentOrTeacherToolStripMenuItem.Name = "removeStudentOrTeacherToolStripMenuItem";
            this.removeStudentOrTeacherToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.removeStudentOrTeacherToolStripMenuItem.Text = "Remove ";
            this.removeStudentOrTeacherToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeStudentOrTeacherToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeStudentToolStripMenuItem.Text = "Remove Student";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.RemoveStudentToolStripMenuItem_Click);
            // 
            // removeTeacherToolStripMenuItem
            // 
            this.removeTeacherToolStripMenuItem.Name = "removeTeacherToolStripMenuItem";
            this.removeTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeTeacherToolStripMenuItem.Text = "Remove Teacher";
            this.removeTeacherToolStripMenuItem.Click += new System.EventHandler(this.RemoveTeacherToolStripMenuItem_Click);
            // 
            // aboudUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutUsToolStripMenuItem.Image = global::CollegeManagementSystem.Properties.Resources.abouticon;
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboudUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(72, 79);
            this.aboutUsToolStripMenuItem.Text = "Aboud Us";
            this.aboutUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboudUsToolStripMenuItem_Click);
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
            this.Controls.Add(this.panelBody);
            this.MainMenuStrip = this.menuStripButtons;
            this.Name = "Form_Main";
            this.Text = "College Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.menuStripButtons.ResumeLayout(false);
            this.menuStripButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
