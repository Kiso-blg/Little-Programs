// <copyright file="Form_Courses.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_Courses class.
    /// Contains all controllers for Form_AddTeacher class.
    /// </summary>
    public partial class Form_Courses
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBoxCourses.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxCourses;

        /// <summary>
        /// Label labelCourseName.
        /// </summary>
        private System.Windows.Forms.Label labelCourseName;

        /// <summary>
        /// SplitContainer splitContainer.
        /// </summary>
        private System.Windows.Forms.SplitContainer splitContainer;

        /// <summary>
        /// Button buttonAddCourse.
        /// </summary>
        private System.Windows.Forms.Button buttonAddCourse;

        /// <summary>
        /// Label labelCourseFee.
        /// </summary>
        private System.Windows.Forms.Label labelCourseFee;

        /// <summary>
        /// TextBox textBoxFee.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxFee;

        /// <summary>
        /// TextBox textBoxCourseName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxCourseName;

        /// <summary>
        /// Label labelName.
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// TextBox textBoxCourseId.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxCourseId;

        /// <summary>
        /// Button buttonEditCourse.
        /// </summary>
        private System.Windows.Forms.Button buttonEditCourse;

        /// <summary>
        /// Button buttonDeleteCourse.
        /// </summary>
        private System.Windows.Forms.Button buttonDeleteCourse;

        /// <summary>
        /// TextBox textBoxEditFee.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxEditFee;

        /// <summary>
        /// Label labelEditCourseFee.
        /// </summary>
        private System.Windows.Forms.Label labelEditCourseFee;

        /// <summary>
        /// TextBox textBoxEditCourseName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxEditCourseName;

        /// <summary>
        /// Button buttonSelectCourse.
        /// </summary>
        private System.Windows.Forms.Button buttonSelectCourse;

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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.labelCourseFee = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonSelectCourse = new System.Windows.Forms.Button();
            this.textBoxEditCourseName = new System.Windows.Forms.TextBox();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.textBoxEditFee = new System.Windows.Forms.TextBox();
            this.labelEditCourseFee = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.pictureBoxCourses = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.splitContainer);
            this.panelBody.Controls.Add(this.pictureBoxCourses);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(500, 400);
            this.panelBody.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 115);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.labelCourseName);
            this.splitContainer.Panel1.Controls.Add(this.buttonAddCourse);
            this.splitContainer.Panel1.Controls.Add(this.labelCourseFee);
            this.splitContainer.Panel1.Controls.Add(this.textBoxFee);
            this.splitContainer.Panel1.Controls.Add(this.textBoxCourseName);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonSelectCourse);
            this.splitContainer.Panel2.Controls.Add(this.textBoxEditCourseName);
            this.splitContainer.Panel2.Controls.Add(this.buttonEditCourse);
            this.splitContainer.Panel2.Controls.Add(this.buttonDeleteCourse);
            this.splitContainer.Panel2.Controls.Add(this.textBoxEditFee);
            this.splitContainer.Panel2.Controls.Add(this.labelEditCourseFee);
            this.splitContainer.Panel2.Controls.Add(this.labelName);
            this.splitContainer.Panel2.Controls.Add(this.textBoxCourseId);
            this.splitContainer.Size = new System.Drawing.Size(500, 285);
            this.splitContainer.SplitterDistance = 125;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 6;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourseName.Location = new System.Drawing.Point(30, 30);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(122, 20);
            this.labelCourseName.TabIndex = 0;
            this.labelCourseName.Text = "Course Name:";
            // 
            // button_AddCourse
            // 
            this.buttonAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCourse.Location = new System.Drawing.Point(310, 65);
            this.buttonAddCourse.Name = "button_AddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(145, 30);
            this.buttonAddCourse.TabIndex = 3;
            this.buttonAddCourse.Text = "Add New Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.ButtonAddCourse_Click);
            // 
            // labelCourseFee
            // 
            this.labelCourseFee.AutoSize = true;
            this.labelCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourseFee.Location = new System.Drawing.Point(30, 75);
            this.labelCourseFee.Name = "labelCourseFee";
            this.labelCourseFee.Size = new System.Drawing.Size(107, 20);
            this.labelCourseFee.TabIndex = 2;
            this.labelCourseFee.Text = "Course Fee:";
            // 
            // textBox_Fee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFee.Location = new System.Drawing.Point(170, 73);
            this.textBoxFee.Name = "textBox_Fee";
            this.textBoxFee.Size = new System.Drawing.Size(100, 22);
            this.textBoxFee.TabIndex = 2;
            // 
            // textBox_CourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCourseName.Location = new System.Drawing.Point(170, 28);
            this.textBoxCourseName.Name = "textBox_CourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(285, 22);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // button_SelectCours
            // 
            this.buttonSelectCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectCourse.Location = new System.Drawing.Point(34, 23);
            this.buttonSelectCourse.Name = "button_SelectCours";
            this.buttonSelectCourse.Size = new System.Drawing.Size(120, 25);
            this.buttonSelectCourse.TabIndex = 9;
            this.buttonSelectCourse.Text = "Select Course";
            this.buttonSelectCourse.UseVisualStyleBackColor = true;
            this.buttonSelectCourse.Click += new System.EventHandler(this.ButtonSelectCours_Click);
            // 
            // textBox_EditCourseName
            // 
            this.textBoxEditCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditCourseName.Location = new System.Drawing.Point(190, 63);
            this.textBoxEditCourseName.Name = "textBox_EditCourseName";
            this.textBoxEditCourseName.Size = new System.Drawing.Size(265, 22);
            this.textBoxEditCourseName.TabIndex = 6;
            // 
            // button_EditCourse
            // 
            this.buttonEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCourse.Location = new System.Drawing.Point(335, 100);
            this.buttonEditCourse.Name = "button_EditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(120, 25);
            this.buttonEditCourse.TabIndex = 8;
            this.buttonEditCourse.Text = "Edit Course";
            this.buttonEditCourse.UseVisualStyleBackColor = true;
            this.buttonEditCourse.Click += new System.EventHandler(this.ButtonEditCourse_Click);
            // 
            // button_DeleteCourse
            // 
            this.buttonDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCourse.Location = new System.Drawing.Point(325, 20);
            this.buttonDeleteCourse.Name = "button_DeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(130, 25);
            this.buttonDeleteCourse.TabIndex = 5;
            this.buttonDeleteCourse.Text = "Delete Course";
            this.buttonDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.ButtonDeleteCourse_Click);
            // 
            // textBox_EditFee
            // 
            this.textBoxEditFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditFee.Location = new System.Drawing.Point(190, 103);
            this.textBoxEditFee.Name = "textBox_EditFee";
            this.textBoxEditFee.Size = new System.Drawing.Size(100, 22);
            this.textBoxEditFee.TabIndex = 7;
            // 
            // labelEditCourseFee
            // 
            this.labelEditCourseFee.AutoSize = true;
            this.labelEditCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEditCourseFee.Location = new System.Drawing.Point(30, 105);
            this.labelEditCourseFee.Name = "labelEditCourseFee";
            this.labelEditCourseFee.Size = new System.Drawing.Size(107, 20);
            this.labelEditCourseFee.TabIndex = 8;
            this.labelEditCourseFee.Text = "Course Fee:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(30, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Course Name:";
            // 
            // textBox_CourseId
            // 
            this.textBoxCourseId.Enabled = false;
            this.textBoxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCourseId.Location = new System.Drawing.Point(190, 23);
            this.textBoxCourseId.Name = "textBox_CourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(80, 22);
            this.textBoxCourseId.TabIndex = 4;
            // 
            // pictureBoxCourses
            // 
            this.pictureBoxCourses.Image = global::CollegeManagementSystem.Properties.Resources.course_overview;
            this.pictureBoxCourses.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCourses.Name = "pictureBoxCourses";
            this.pictureBoxCourses.Size = new System.Drawing.Size(500, 115);
            this.pictureBoxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCourses.TabIndex = 1;
            this.pictureBoxCourses.TabStop = false;
            // 
            // Form_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove Courses";
            this.panelBody.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
