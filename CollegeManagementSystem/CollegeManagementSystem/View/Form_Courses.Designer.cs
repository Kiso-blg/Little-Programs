
namespace CollegeManagementSystem
{
    partial class Form_Courses
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.button_AddCourse = new System.Windows.Forms.Button();
            this.labelCourseFee = new System.Windows.Forms.Label();
            this.textBox_Fee = new System.Windows.Forms.TextBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.button_SelectCours = new System.Windows.Forms.Button();
            this.textBox_EditCourseName = new System.Windows.Forms.TextBox();
            this.button_EditCourse = new System.Windows.Forms.Button();
            this.button_DeleteCourse = new System.Windows.Forms.Button();
            this.textBox_EditFee = new System.Windows.Forms.TextBox();
            this.labelEditCourseFee = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox_CourseId = new System.Windows.Forms.TextBox();
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
            this.splitContainer.Panel1.Controls.Add(this.button_AddCourse);
            this.splitContainer.Panel1.Controls.Add(this.labelCourseFee);
            this.splitContainer.Panel1.Controls.Add(this.textBox_Fee);
            this.splitContainer.Panel1.Controls.Add(this.textBox_CourseName);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.button_SelectCours);
            this.splitContainer.Panel2.Controls.Add(this.textBox_EditCourseName);
            this.splitContainer.Panel2.Controls.Add(this.button_EditCourse);
            this.splitContainer.Panel2.Controls.Add(this.button_DeleteCourse);
            this.splitContainer.Panel2.Controls.Add(this.textBox_EditFee);
            this.splitContainer.Panel2.Controls.Add(this.labelEditCourseFee);
            this.splitContainer.Panel2.Controls.Add(this.labelName);
            this.splitContainer.Panel2.Controls.Add(this.textBox_CourseId);
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
            this.button_AddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddCourse.Location = new System.Drawing.Point(310, 65);
            this.button_AddCourse.Name = "button_AddCourse";
            this.button_AddCourse.Size = new System.Drawing.Size(145, 30);
            this.button_AddCourse.TabIndex = 3;
            this.button_AddCourse.Text = "Add New Course";
            this.button_AddCourse.UseVisualStyleBackColor = true;
            this.button_AddCourse.Click += new System.EventHandler(this.Button_AddCourse_Click);
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
            this.textBox_Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Fee.Location = new System.Drawing.Point(170, 73);
            this.textBox_Fee.Name = "textBox_Fee";
            this.textBox_Fee.Size = new System.Drawing.Size(100, 22);
            this.textBox_Fee.TabIndex = 2;
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CourseName.Location = new System.Drawing.Point(170, 28);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(285, 22);
            this.textBox_CourseName.TabIndex = 1;
            // 
            // button_SelectCours
            // 
            this.button_SelectCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SelectCours.Location = new System.Drawing.Point(34, 23);
            this.button_SelectCours.Name = "button_SelectCours";
            this.button_SelectCours.Size = new System.Drawing.Size(120, 25);
            this.button_SelectCours.TabIndex = 9;
            this.button_SelectCours.Text = "Select Course";
            this.button_SelectCours.UseVisualStyleBackColor = true;
            this.button_SelectCours.Click += new System.EventHandler(this.Button_SelectCours_Click);
            // 
            // textBox_EditCourseName
            // 
            this.textBox_EditCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditCourseName.Location = new System.Drawing.Point(190, 63);
            this.textBox_EditCourseName.Name = "textBox_EditCourseName";
            this.textBox_EditCourseName.Size = new System.Drawing.Size(265, 22);
            this.textBox_EditCourseName.TabIndex = 6;
            // 
            // button_EditCourse
            // 
            this.button_EditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EditCourse.Location = new System.Drawing.Point(335, 100);
            this.button_EditCourse.Name = "button_EditCourse";
            this.button_EditCourse.Size = new System.Drawing.Size(120, 25);
            this.button_EditCourse.TabIndex = 8;
            this.button_EditCourse.Text = "Edit Course";
            this.button_EditCourse.UseVisualStyleBackColor = true;
            this.button_EditCourse.Click += new System.EventHandler(this.Button_EditCourse_Click);
            // 
            // button_DeleteCourse
            // 
            this.button_DeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteCourse.Location = new System.Drawing.Point(325, 20);
            this.button_DeleteCourse.Name = "button_DeleteCourse";
            this.button_DeleteCourse.Size = new System.Drawing.Size(130, 25);
            this.button_DeleteCourse.TabIndex = 5;
            this.button_DeleteCourse.Text = "Delete Course";
            this.button_DeleteCourse.UseVisualStyleBackColor = true;
            this.button_DeleteCourse.Click += new System.EventHandler(this.Button_DeleteCourse_Click);
            // 
            // textBox_EditFee
            // 
            this.textBox_EditFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditFee.Location = new System.Drawing.Point(190, 103);
            this.textBox_EditFee.Name = "textBox_EditFee";
            this.textBox_EditFee.Size = new System.Drawing.Size(100, 22);
            this.textBox_EditFee.TabIndex = 7;
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
            this.textBox_CourseId.Enabled = false;
            this.textBox_CourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CourseId.Location = new System.Drawing.Point(190, 23);
            this.textBox_CourseId.Name = "textBox_CourseId";
            this.textBox_CourseId.Size = new System.Drawing.Size(80, 22);
            this.textBox_CourseId.TabIndex = 4;
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

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBoxCourses;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button button_AddCourse;
        private System.Windows.Forms.Label labelCourseFee;
        private System.Windows.Forms.TextBox textBox_Fee;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox_CourseId;
        private System.Windows.Forms.Button button_EditCourse;
        private System.Windows.Forms.Button button_DeleteCourse;
        private System.Windows.Forms.TextBox textBox_EditFee;
        private System.Windows.Forms.Label labelEditCourseFee;
        private System.Windows.Forms.TextBox textBox_EditCourseName;
        private System.Windows.Forms.Button button_SelectCours;
    }
}