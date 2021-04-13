
namespace CollegeManagementSystem
{
    partial class Form_UpdateSemesters
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
            this.label_StudentName = new System.Windows.Forms.Label();
            this.label_StudentId = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.Button_SelectStudent = new System.Windows.Forms.Button();
            this.comboBox_Semesters = new System.Windows.Forms.ComboBox();
            this.labelSelectSemester = new System.Windows.Forms.Label();
            this.Button_UpdateSemester = new System.Windows.Forms.Button();
            this.comboBox_Dates = new System.Windows.Forms.ComboBox();
            this.comboBox_Courses = new System.Windows.Forms.ComboBox();
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
            this.panelBody.Controls.Add(this.label_StudentName);
            this.panelBody.Controls.Add(this.label_StudentId);
            this.panelBody.Controls.Add(this.labelStudentName);
            this.panelBody.Controls.Add(this.labelStudentId);
            this.panelBody.Controls.Add(this.Button_SelectStudent);
            this.panelBody.Controls.Add(this.comboBox_Semesters);
            this.panelBody.Controls.Add(this.labelSelectSemester);
            this.panelBody.Controls.Add(this.Button_UpdateSemester);
            this.panelBody.Controls.Add(this.comboBox_Dates);
            this.panelBody.Controls.Add(this.comboBox_Courses);
            this.panelBody.Controls.Add(this.labelSelectStartDate);
            this.panelBody.Controls.Add(this.labelSelectCourse);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(450, 590);
            this.panelBody.TabIndex = 0;
            // 
            // label_StudentName
            // 
            this.label_StudentName.AutoSize = true;
            this.label_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StudentName.Location = new System.Drawing.Point(230, 495);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(0, 16);
            this.label_StudentName.TabIndex = 10;
            // 
            // label_StudentId
            // 
            this.label_StudentId.AutoSize = true;
            this.label_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StudentId.Location = new System.Drawing.Point(230, 455);
            this.label_StudentId.Name = "label_StudentId";
            this.label_StudentId.Size = new System.Drawing.Size(0, 16);
            this.label_StudentId.TabIndex = 9;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(50, 495);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(109, 16);
            this.labelStudentName.TabIndex = 8;
            this.labelStudentName.Text = "Student Name:";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentId.Location = new System.Drawing.Point(50, 455);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(81, 16);
            this.labelStudentId.TabIndex = 7;
            this.labelStudentId.Text = "Student Id:";
            // 
            // Button_SelectStudent
            // 
            this.Button_SelectStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SelectStudent.Location = new System.Drawing.Point(165, 410);
            this.Button_SelectStudent.Name = "Button_SelectStudent";
            this.Button_SelectStudent.Size = new System.Drawing.Size(120, 25);
            this.Button_SelectStudent.TabIndex = 6;
            this.Button_SelectStudent.Text = "Select Student";
            this.Button_SelectStudent.UseVisualStyleBackColor = true;
            this.Button_SelectStudent.Click += new System.EventHandler(this.Button_SelectStudent_Click);
            // 
            // comboBox_Semesters
            // 
            this.comboBox_Semesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Semesters.FormattingEnabled = true;
            this.comboBox_Semesters.Location = new System.Drawing.Point(230, 356);
            this.comboBox_Semesters.Name = "comboBox_Semesters";
            this.comboBox_Semesters.Size = new System.Drawing.Size(165, 24);
            this.comboBox_Semesters.TabIndex = 4;
            this.comboBox_Semesters.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Semesters_SelectedIndexChanged);
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
            // Button_UpdateSemester
            // 
            this.Button_UpdateSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_UpdateSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_UpdateSemester.Location = new System.Drawing.Point(152, 535);
            this.Button_UpdateSemester.Name = "Button_UpdateSemester";
            this.Button_UpdateSemester.Size = new System.Drawing.Size(145, 25);
            this.Button_UpdateSemester.TabIndex = 3;
            this.Button_UpdateSemester.Text = "Update Semester";
            this.Button_UpdateSemester.UseVisualStyleBackColor = true;
            this.Button_UpdateSemester.Click += new System.EventHandler(this.Button_UpdateSemester_Click);
            // 
            // comboBox_Dates
            // 
            this.comboBox_Dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Dates.FormattingEnabled = true;
            this.comboBox_Dates.Location = new System.Drawing.Point(230, 296);
            this.comboBox_Dates.Name = "comboBox_Dates";
            this.comboBox_Dates.Size = new System.Drawing.Size(165, 24);
            this.comboBox_Dates.TabIndex = 2;
            this.comboBox_Dates.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Dates_SelectedIndexChanged);
            // 
            // comboBox_Courses
            // 
            this.comboBox_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Courses.FormattingEnabled = true;
            this.comboBox_Courses.Location = new System.Drawing.Point(230, 236);
            this.comboBox_Courses.Name = "comboBox_Courses";
            this.comboBox_Courses.Size = new System.Drawing.Size(165, 24);
            this.comboBox_Courses.TabIndex = 1;
            this.comboBox_Courses.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Courses_SelectedIndexChanged);
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

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Button_UpdateSemester;
        private System.Windows.Forms.ComboBox comboBox_Dates;
        private System.Windows.Forms.ComboBox comboBox_Courses;
        private System.Windows.Forms.Label labelSelectStartDate;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.ComboBox comboBox_Semesters;
        private System.Windows.Forms.Label labelSelectSemester;
        private System.Windows.Forms.Button Button_SelectStudent;
        private System.Windows.Forms.Label label_StudentName;
        private System.Windows.Forms.Label label_StudentId;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentId;
    }
}