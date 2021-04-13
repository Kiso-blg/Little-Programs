
namespace CollegeManagementSystem
{
    partial class Form_SelectCourse
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
            this.dataGridView_Courses = new System.Windows.Forms.DataGridView();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridView_Courses);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(390, 320);
            this.panelBody.TabIndex = 0;
            // 
            // dataGridView_Courses
            // 
            this.dataGridView_Courses.AllowUserToAddRows = false;
            this.dataGridView_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Courses.Location = new System.Drawing.Point(10, 10);
            this.dataGridView_Courses.Name = "dataGridView_Courses";
            this.dataGridView_Courses.Size = new System.Drawing.Size(370, 300);
            this.dataGridView_Courses.TabIndex = 0;
            this.dataGridView_Courses.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Courses_ColumnHeaderMouseClick);
            this.dataGridView_Courses.DoubleClick += new System.EventHandler(this.DataGridView_Courses_DoubleClick);
            // 
            // Form_SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_SelectCourse";
            this.Text = "Select Course";
            this.Load += new System.EventHandler(this.Form_SelectCourse_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        internal System.Windows.Forms.DataGridView dataGridView_Courses;
    }
}