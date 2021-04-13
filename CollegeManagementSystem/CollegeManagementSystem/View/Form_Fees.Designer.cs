
namespace CollegeManagementSystem
{
    partial class Form_Fees
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
            this.label_RegistrationId = new System.Windows.Forms.Label();
            this.label_Fee = new System.Windows.Forms.Label();
            this.button_SelectRegistrationId = new System.Windows.Forms.Button();
            this.label_Semester = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelInlistDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxFees = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.label_RegistrationId);
            this.panelBody.Controls.Add(this.label_Fee);
            this.panelBody.Controls.Add(this.button_SelectRegistrationId);
            this.panelBody.Controls.Add(this.label_Semester);
            this.panelBody.Controls.Add(this.labelSemester);
            this.panelBody.Controls.Add(this.button_Submit);
            this.panelBody.Controls.Add(this.label_Date);
            this.panelBody.Controls.Add(this.label_Surname);
            this.panelBody.Controls.Add(this.label_Name);
            this.panelBody.Controls.Add(this.labelFees);
            this.panelBody.Controls.Add(this.labelInlistDate);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.pictureBoxFees);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(470, 525);
            this.panelBody.TabIndex = 0;
            // 
            // label_RegistrationId
            // 
            this.label_RegistrationId.AutoSize = true;
            this.label_RegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RegistrationId.Location = new System.Drawing.Point(270, 200);
            this.label_RegistrationId.Name = "label_RegistrationId";
            this.label_RegistrationId.Size = new System.Drawing.Size(89, 20);
            this.label_RegistrationId.TabIndex = 13;
            this.label_RegistrationId.Text = "________";
            // 
            // label_Fee
            // 
            this.label_Fee.AutoSize = true;
            this.label_Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fee.Location = new System.Drawing.Point(270, 425);
            this.label_Fee.Name = "label_Fee";
            this.label_Fee.Size = new System.Drawing.Size(89, 20);
            this.label_Fee.TabIndex = 12;
            this.label_Fee.Text = "________";
            // 
            // button_SelectRegistrationId
            // 
            this.button_SelectRegistrationId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SelectRegistrationId.Location = new System.Drawing.Point(40, 200);
            this.button_SelectRegistrationId.Name = "button_SelectRegistrationId";
            this.button_SelectRegistrationId.Size = new System.Drawing.Size(175, 26);
            this.button_SelectRegistrationId.TabIndex = 11;
            this.button_SelectRegistrationId.Text = "Select Registration ID:";
            this.button_SelectRegistrationId.UseVisualStyleBackColor = true;
            this.button_SelectRegistrationId.Click += new System.EventHandler(this.Button_SelectRegistrationId_Click);
            // 
            // label_Semester
            // 
            this.label_Semester.AutoSize = true;
            this.label_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Semester.Location = new System.Drawing.Point(270, 380);
            this.label_Semester.Name = "label_Semester";
            this.label_Semester.Size = new System.Drawing.Size(89, 20);
            this.label_Semester.TabIndex = 10;
            this.label_Semester.Text = "________";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(40, 380);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(104, 24);
            this.labelSemester.TabIndex = 9;
            this.labelSemester.Text = "Semester:";
            // 
            // button_Submit
            // 
            this.button_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Submit.Location = new System.Drawing.Point(185, 475);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(100, 30);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Date.Location = new System.Drawing.Point(270, 335);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(89, 20);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "________";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Surname.Location = new System.Drawing.Point(270, 290);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(89, 20);
            this.label_Surname.TabIndex = 7;
            this.label_Surname.Text = "________";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(270, 245);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(89, 20);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "________";
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFees.Location = new System.Drawing.Point(40, 425);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(63, 24);
            this.labelFees.TabIndex = 5;
            this.labelFees.Text = "Fees:";
            // 
            // labelInlistDate
            // 
            this.labelInlistDate.AutoSize = true;
            this.labelInlistDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInlistDate.Location = new System.Drawing.Point(40, 335);
            this.labelInlistDate.Name = "labelInlistDate";
            this.labelInlistDate.Size = new System.Drawing.Size(105, 24);
            this.labelInlistDate.TabIndex = 4;
            this.labelInlistDate.Text = "Start Date:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(40, 290);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(100, 24);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(40, 245);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // pictureBoxFees
            // 
            this.pictureBoxFees.Image = global::CollegeManagementSystem.Properties.Resources.fees;
            this.pictureBoxFees.Location = new System.Drawing.Point(100, 15);
            this.pictureBoxFees.Name = "pictureBoxFees";
            this.pictureBoxFees.Size = new System.Drawing.Size(270, 160);
            this.pictureBoxFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFees.TabIndex = 0;
            this.pictureBoxFees.TabStop = false;
            // 
            // Form_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 525);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBoxFees;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label labelInlistDate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label_Semester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label label_RegistrationId;
        private System.Windows.Forms.Label label_Fee;
        private System.Windows.Forms.Button button_SelectRegistrationId;
    }
}