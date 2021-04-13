
namespace CollegeManagementSystem
{
    partial class Form_RemoveStudent
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_RegistrationId = new System.Windows.Forms.Label();
            this.button_SelectRegistrationId = new System.Windows.Forms.Button();
            this.label_Semester = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.labelInlistDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.labelInformation);
            this.panelBody.Controls.Add(this.button_Clear);
            this.panelBody.Controls.Add(this.label_RegistrationId);
            this.panelBody.Controls.Add(this.button_SelectRegistrationId);
            this.panelBody.Controls.Add(this.label_Semester);
            this.panelBody.Controls.Add(this.labelSemester);
            this.panelBody.Controls.Add(this.button_Delete);
            this.panelBody.Controls.Add(this.label_Date);
            this.panelBody.Controls.Add(this.label_Surname);
            this.panelBody.Controls.Add(this.label_Name);
            this.panelBody.Controls.Add(this.labelInlistDate);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.pictureBoxRemove);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(470, 465);
            this.panelBody.TabIndex = 0;
            // 
            // button_Clear
            // 
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(243, 400);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 30);
            this.button_Clear.TabIndex = 27;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // label_RegistrationId
            // 
            this.label_RegistrationId.AutoSize = true;
            this.label_RegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RegistrationId.Location = new System.Drawing.Point(270, 170);
            this.label_RegistrationId.Name = "label_RegistrationId";
            this.label_RegistrationId.Size = new System.Drawing.Size(89, 20);
            this.label_RegistrationId.TabIndex = 26;
            this.label_RegistrationId.Text = "________";
            // 
            // button_SelectRegistrationId
            // 
            this.button_SelectRegistrationId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SelectRegistrationId.Location = new System.Drawing.Point(40, 170);
            this.button_SelectRegistrationId.Name = "button_SelectRegistrationId";
            this.button_SelectRegistrationId.Size = new System.Drawing.Size(175, 26);
            this.button_SelectRegistrationId.TabIndex = 24;
            this.button_SelectRegistrationId.Text = "Select Registration ID:";
            this.button_SelectRegistrationId.UseVisualStyleBackColor = true;
            this.button_SelectRegistrationId.Click += new System.EventHandler(this.Button_SelectRegistrationId_Click);
            // 
            // label_Semester
            // 
            this.label_Semester.AutoSize = true;
            this.label_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Semester.Location = new System.Drawing.Point(270, 350);
            this.label_Semester.Name = "label_Semester";
            this.label_Semester.Size = new System.Drawing.Size(89, 20);
            this.label_Semester.TabIndex = 23;
            this.label_Semester.Text = "________";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(40, 350);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(104, 24);
            this.labelSemester.TabIndex = 22;
            this.labelSemester.Text = "Semester:";
            // 
            // button_Delete
            // 
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Delete.Location = new System.Drawing.Point(128, 400);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(100, 30);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(270, 305);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(89, 20);
            this.label_Date.TabIndex = 21;
            this.label_Date.Text = "________";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(270, 260);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(89, 20);
            this.label_Surname.TabIndex = 20;
            this.label_Surname.Text = "________";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(270, 215);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(89, 20);
            this.label_Name.TabIndex = 19;
            this.label_Name.Text = "________";
            // 
            // labelInlistDate
            // 
            this.labelInlistDate.AutoSize = true;
            this.labelInlistDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInlistDate.Location = new System.Drawing.Point(40, 305);
            this.labelInlistDate.Name = "labelInlistDate";
            this.labelInlistDate.Size = new System.Drawing.Size(105, 24);
            this.labelInlistDate.TabIndex = 17;
            this.labelInlistDate.Text = "Start Date:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(40, 260);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(100, 24);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(40, 215);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 24);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Image = global::CollegeManagementSystem.Properties.Resources._1;
            this.pictureBoxRemove.Location = new System.Drawing.Point(40, 15);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 0;
            this.pictureBoxRemove.TabStop = false;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelInformation.Location = new System.Drawing.Point(201, 70);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(238, 24);
            this.labelInformation.TabIndex = 28;
            this.labelInformation.Text = "Remove Student Record";
            // 
            // Form_RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 465);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_RemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Student";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private System.Windows.Forms.Label label_RegistrationId;
        private System.Windows.Forms.Button button_SelectRegistrationId;
        private System.Windows.Forms.Label label_Semester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label labelInlistDate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label labelInformation;
    }
}