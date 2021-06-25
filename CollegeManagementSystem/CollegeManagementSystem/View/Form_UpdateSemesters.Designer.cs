// <copyright file="Form_UpdateSemesters.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_UpdateSemesters class.
    /// Contains all controllers for Form_UpdateSemesters class.
    /// </summary>
    public partial class Form_UpdateSemesters
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBox.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// Button ButtonUpdateSemester.
        /// </summary>
        private System.Windows.Forms.Button buttonUpdateSemester;

        /// <summary>
        /// ComboBox comboBoxDates.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxDates;

        /// <summary>
        /// ComboBox comboBoxCourses.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxCourses;

        /// <summary>
        /// Label labelSelectStartDate.
        /// </summary>
        private System.Windows.Forms.Label labelSelectStartDate;

        /// <summary>
        /// Label labelSelectCourse.
        /// </summary>
        private System.Windows.Forms.Label labelSelectCourse;

        /// <summary>
        /// ComboBox comboBoxSemesters.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxSemesters;

        /// <summary>
        /// Label labelSelectSemester.
        /// </summary>
        private System.Windows.Forms.Label labelSelectSemester;

        /// <summary>
        /// Button ButtonSelectStudent.
        /// </summary>
        private System.Windows.Forms.Button buttonSelectStudent;

        /// <summary>
        /// Label labelStudentName.
        /// </summary>
        private System.Windows.Forms.Label labelStudentName;

        /// <summary>
        /// Label labelStudentId.
        /// </summary>
        private System.Windows.Forms.Label labelStudentId;

        /// <summary>
        /// Label studentName.
        /// </summary>
        private System.Windows.Forms.Label studentName;

        /// <summary>
        /// Label studentId.
        /// </summary>
        private System.Windows.Forms.Label studentId;

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
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.buttonSelectStudent = new System.Windows.Forms.Button();
            this.comboBoxSemesters = new System.Windows.Forms.ComboBox();
            this.labelSelectSemester = new System.Windows.Forms.Label();
            this.buttonUpdateSemester = new System.Windows.Forms.Button();
            this.comboBoxDates = new System.Windows.Forms.ComboBox();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.labelSelectStartDate = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.labelStudentName);
            this.panelBody.Controls.Add(this.labelStudentId);
            this.panelBody.Controls.Add(this.studentName);
            this.panelBody.Controls.Add(this.studentId);
            this.panelBody.Controls.Add(this.buttonSelectStudent);
            this.panelBody.Controls.Add(this.comboBoxSemesters);
            this.panelBody.Controls.Add(this.labelSelectSemester);
            this.panelBody.Controls.Add(this.buttonUpdateSemester);
            this.panelBody.Controls.Add(this.comboBoxDates);
            this.panelBody.Controls.Add(this.comboBoxCourses);
            this.panelBody.Controls.Add(this.labelSelectStartDate);
            this.panelBody.Controls.Add(this.labelSelectCourse);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(450, 590);
            this.panelBody.TabIndex = 0;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(230, 495);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(0, 16);
            this.labelStudentName.TabIndex = 10;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentId.Location = new System.Drawing.Point(230, 455);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(0, 16);
            this.labelStudentId.TabIndex = 9;
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentName.Location = new System.Drawing.Point(50, 495);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(109, 16);
            this.studentName.TabIndex = 8;
            this.studentName.Text = "Student Name:";
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentId.Location = new System.Drawing.Point(50, 455);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(81, 16);
            this.studentId.TabIndex = 7;
            this.studentId.Text = "Student Id:";
            // 
            // ButtonSelectStudent
            // 
            this.buttonSelectStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectStudent.Location = new System.Drawing.Point(165, 410);
            this.buttonSelectStudent.Name = "ButtonSelectStudent";
            this.buttonSelectStudent.Size = new System.Drawing.Size(120, 25);
            this.buttonSelectStudent.TabIndex = 6;
            this.buttonSelectStudent.Text = "Select Student";
            this.buttonSelectStudent.UseVisualStyleBackColor = true;
            this.buttonSelectStudent.Click += new System.EventHandler(this.ButtonSelectStudent_Click);
            // 
            // comboBoxSemesters
            // 
            this.comboBoxSemesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSemesters.FormattingEnabled = true;
            this.comboBoxSemesters.Location = new System.Drawing.Point(230, 356);
            this.comboBoxSemesters.Name = "comboBoxSemesters";
            this.comboBoxSemesters.Size = new System.Drawing.Size(165, 24);
            this.comboBoxSemesters.TabIndex = 4;
            this.comboBoxSemesters.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSemesters_SelectedIndexChanged);
            // 
            // labelSelectSemester
            // 
            this.labelSelectSemester.AutoSize = true;
            this.labelSelectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectSemester.Location = new System.Drawing.Point(50, 360);
            this.labelSelectSemester.Name = "labelSelectSemester";
            this.labelSelectSemester.Size = new System.Drawing.Size(147, 20);
            this.labelSelectSemester.TabIndex = 5;
            this.labelSelectSemester.Text = "Select Semester:";
            // 
            // ButtonUpdateSemester
            // 
            this.buttonUpdateSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateSemester.Location = new System.Drawing.Point(152, 535);
            this.buttonUpdateSemester.Name = "ButtonUpdateSemester";
            this.buttonUpdateSemester.Size = new System.Drawing.Size(145, 25);
            this.buttonUpdateSemester.TabIndex = 3;
            this.buttonUpdateSemester.Text = "Update Semester";
            this.buttonUpdateSemester.UseVisualStyleBackColor = true;
            this.buttonUpdateSemester.Click += new System.EventHandler(this.ButtonUpdateSemester_Click);
            // 
            // comboBoxDates
            // 
            this.comboBoxDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDates.FormattingEnabled = true;
            this.comboBoxDates.Location = new System.Drawing.Point(230, 296);
            this.comboBoxDates.Name = "comboBoxDates";
            this.comboBoxDates.Size = new System.Drawing.Size(165, 24);
            this.comboBoxDates.TabIndex = 2;
            this.comboBoxDates.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDates_SelectedIndexChanged);
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(230, 236);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(165, 24);
            this.comboBoxCourses.TabIndex = 1;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourses_SelectedIndexChanged);
            // 
            // labelSelectStartDate
            // 
            this.labelSelectStartDate.AutoSize = true;
            this.labelSelectStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectStartDate.Location = new System.Drawing.Point(50, 300);
            this.labelSelectStartDate.Name = "labelSelectStartDate";
            this.labelSelectStartDate.Size = new System.Drawing.Size(154, 20);
            this.labelSelectStartDate.TabIndex = 2;
            this.labelSelectStartDate.Text = "Select Start Date:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCourse.Location = new System.Drawing.Point(50, 240);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(121, 20);
            this.labelSelectCourse.TabIndex = 1;
            this.labelSelectCourse.Text = "Select Couse:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources.semester;
            this.pictureBox.Location = new System.Drawing.Point(32, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(385, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form_UpdateSemesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 590);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_UpdateSemesters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Semester";
            this.Load += new System.EventHandler(this.Form_UpdateSemesters_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion 
    }
}
